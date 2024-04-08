ALTER SESSION SET "_ORACLE_SCRIPT" = True;
create role RL_NVCOBAN;
create role RL_GIANGVIEN;
create role RL_GIAOVU;
create role RL_TRUONGDV;
create role RL_TRUONGKHOA;

grant create session to RL_NVCOBAN;
grant create session to RL_GIANGVIEN;
grant create session to RL_GIAOVU;
grant create session to RL_TRUONGDV;
grant create session to RL_TRUONGKHOA;
-- CS1: Nhân viên cơ bản
create or replace view QLHS_TTCANHAN
as
    select * from NHANSU where MANV = SYS_CONTEXT('USERENV','SESSION_USER');
-- Grant update on view
grant select, update(DT) on QLHS_TTCANHAN to RL_NVCOBAN;
-- Grant select on sinh vien, don vi, hoc phan, khmo
grant select on SINHVIEN to RL_NVCOBAN;
grant select on DONVI to RL_NVCOBAN;
grant select on HOCPHAN to RL_NVCOBAN;
grant select on KHMO to RL_NVCOBAN;
-- CS2 : Giảng viên
-- Như CS1
grant select, update(DT) on QLHS_TTCANHAN to RL_GIANGVIEN;
-- Grant select on sinh vien, don vi, hoc phan, khmo
grant select on SINHVIEN to RL_GIANGVIEN;
grant select on DONVI to RL_GIANGVIEN;
grant select on HOCPHAN to RL_GIANGVIEN;
grant select on KHMO to RL_GIANGVIEN;
--grant RL_NVCOBAN to RL_GIANGVIEN;
-- grant select on QLHS_PHANCONG_GD
-- grant select on QLHS_DANGKY_HPGD
create or replace view QLHS_PHANCONG_GD
as
    select * from PHANCONG where MAGV = SYS_CONTEXT('USERENV','SESSION_USER');

create or replace view QLHS_DANGKY_HPGD
as
    select * from DANGKY where MAGV = SYS_CONTEXT('USERENV','SESSION_USER');
grant select on QLHS_PHANCONG_GD to RL_GIANGVIEN;
grant select on QLHS_DANGKY_HPGD to RL_GIANGVIEN;
-- grant update on dangky(diemth,diemqt, diemck,diemtk)
GRANT SELECT, UPDATE(DIEMTH, DIEMQT, DIEMCK, DIEMTK) ON QLHS_DANGKY_DIEM_GV TO RL_GIANGVIEN;

/
--CS3 : giao vu
-- Như CS1
grant select, update(DT) on QLHS_TTCANHAN to RL_GIAOVU;
--Xem, Thêm mới hoặc Cập nhật dữ liệu trên các quan hệ SINHVIEN, ĐONVI,
--HOCPHAN, KHMO, theo yêu cầu của trưởng khoa.
-- grant update select insert on sinh vien, donvi, hocphan, khmo
grant select, insert, update on SINHVIEN to RL_GIAOVU;
grant select, insert, update on HOCPHAN to RL_GIAOVU;
grant select, insert, update on DONVI to RL_GIAOVU;
grant select, insert, update on KHMO to RL_GIAOVU;
-- grant select on phancong
grant select,update on PHANCONG to RL_GIAOVU;
-- grant select phan cong, grnat update on QLHS_PHANCONG_HOCPHAN_VPK
/
--Xem dữ liệu trên toàn bộ quan hệ PHANCONG. Tuy nhiên, chỉ được sửa trên các dòng
--dữ liệu phân công liên quan các học phần do “Văn phòng khoa” phụ trách phân công
--giảng dạy, thừa hành người trưởng đơn vị tương ứng là trưởng khoa.
CREATE OR REPLACE FUNCTION QL_XEM_HP_VPK(
  P_SCHEMA IN VARCHAR2 DEFAULT NULL,
  P_OBJECT IN VARCHAR2 DEFAULT NULL
) RETURN VARCHAR2 AS
    CURSOR HP IS(select MAHP from HOCPHAN where MADV = 'VPK');
    USERNAME VARCHAR2(128);
    USERROLE VARCHAR2(128);
    TEMP varchar2(5);
    MAHP varchar2(2000);
  
BEGIN
  -- Lấy username của user hiện tại
  USERNAME := SYS_CONTEXT('USERENV', 'SESSION_USER');
--  IF USERNAME = 'QLDA' THEN
--    RETURN '';
--  END IF;
  SELECT GRANTED_ROLE INTO USERROLE
  FROM DBA_ROLE_PRIVS
  WHERE GRANTEE = USERNAME;
  IF 'RL_GIAOVU' IN (USERROLE) THEN 
      OPEN CUR;  
        LOOP 
            FETCH HP INTO TEMP; 
            EXIT WHEN HP%NOTFOUND;
            IF (MAHP IS NOT NULL) THEN
                MAHP :=  MAHP ||''',''';
            ELSE 
                MAHP := MAHP || TEMP;
            END IF;
        END LOOP;
        CLOSE HP;
        RETURN 'MAHP IN ('''||MAHP||''')';
  ELSE
    RETURN '1=0';
  END IF;
END;
/
BEGIN
    DBMS_RLS.ADD_POLICY(
        object_schema => 'ADPRO', 
        object_name => 'PHANCONG',
        policy_name => 'GIAOVU_PHANCONG_CS3',
        policy_function => 'QL_XEM_HP_VPK',
        statement_types => 'INSERT, DELETE, UPDATE',
        update_check => TRUE
    );
END;
/
grant insert, delete on dangky to RL_GIAOVU;
CREATE OR REPLACE TRIGGER CheckRegistrationDate
INSTEAD OF INSERT OR DELETE ON DANGKY
FOR EACH ROW
DECLARE
    v_StartDate DATE;
    v_CurrentDate DATE := SYSDATE;
    v_HK INT;
    v_NAM INT;
BEGIN
    SELECT GRANTED_ROLE INTO USERROLE
    FROM DBA_ROLE_PRIVS
    WHERE GRANTEE = SYS_CONTEXT('USERENV', 'SESSION_USER');
    IF 'RL_GIAOVU' IN (USERROLE) THEN 
        -- Get the semester start date based on the academic year and semester
        SELECT TO_DATE(
            CASE HK
                WHEN 1 THEN TO_CHAR(NAM) || '-01-01'
                WHEN 2 THEN TO_CHAR(NAM) || '-05-01'
                WHEN 3 THEN TO_CHAR(NAM) || '-09-01'
            END,
            'YYYY-MM-DD'
        )
        INTO v_StartDate
        FROM KHMO
        WHERE MAHP = :NEW.MAHP;
    
        -- Check if the current date is within 14 days of the semester start date
        IF (v_CurrentDate - v_StartDate) > 14 THEN
            -- If the current date exceeds the 14-day limit, raise an error for INSERT operations
            IF INSERTING THEN
                RAISE_APPLICATION_ERROR(-20001, 'You cannot add new registration after 14 days from the start of the semester.');
            END IF;
        ELSE
            -- If the current date is within the limit, proceed with the insert or delete operation
            IF INSERTING THEN
                INSERT INTO DANGKY (MASV, MAGV, MAHP, HK, NAM, MACT, DIEMTHI, DIEMQT, DIEMCK, DIEMTK)
                VALUES (:NEW.MASV, :NEW.MAGV, :NEW.MAHP, :NEW.HK, :NEW.NAM, :NEW.MACT, :NEW.DIEMTHI, :NEW.DIEMQT, :NEW.DIEMCK, :NEW.DIEMTK);
            ELSIF DELETING THEN
                DELETE FROM DANGKY
                WHERE MASV = :OLD.MASV AND MAGV = :OLD.MAGV AND MAHP = :OLD.MAHP AND HK = :OLD.HK AND NAM = :OLD.NAM AND MACT = :OLD.MACT;
            END IF;
        END IF;
    END IF;
END;
/


-- CS4 : TRưởng Dơn vị
-- view QLHS_TTCANHAN
-- grant select on QLHS_PHANCONG_GD
-- grant select on QLHS_DANGKY_HPGD
-- grant update on dangky(diemth,diemqt, diemck,diemtk)

-- grant insert , delete, update on QLHS_PHANCONG_TRGDV
create or replace view QLHS_PHANCONG_HP_TRGDV
as
    select pc.* from PHANCONG pc, HOCPHAN hp, DONVI dv 
    where  pc.mahp = hp.mahp and hp.maDv = dv.maDv and dv.trgDv = SYS_CONTEXT('USERENV','SESSION_USER');
-- grant select on QLHS_PHANCONG_GV_DV
create or replace view QLHS_PHANCONG_GV_DV
as
    select pk.* from PHANCONG pc, Donvi dv
    where pc.maDv = dv.maDv and dv.trgDv = SYS_CONTEXT('USERENV','SESSION_USER');
-- CS5: Trưởng khoa
-- view QLHS_TTCANHAN
-- grant select on QLHS_PHANCONG_GD
-- grant select on QLHS_DANGKY_HPGD
-- grant update on dangky(diemth,diemqt, diemck,diemtk)
grant select, update(DT) on QLHS_TTCANHAN to RL_TRUONGKHOA;
-- Grant select on sinh vien, don vi, hoc phan, khmo
grant select on SINHVIEN to RL_TRUONGKHOA;
grant select on DONVI to RL_TRUONGKHOA;
grant select on HOCPHAN to RL_TRUONGKHOA;
grant select on KHMO to RL_TRUONGKHOA;
grant select on QLHS_PHANCONG_GD to RL_TRUONGKHOA;
grant select on QLHS_DANGKY_HPGD to RL_TRUONGKHOA;
-- grant update on dangky(diemth,diemqt, diemck,diemtk)
GRANT SELECT, UPDATE(DIEMTH, DIEMQT, DIEMCK, DIEMTK) ON QLHS_DANGKY_DIEM_GV TO RL_TRUONGKHOA;
-- grant insert, update , delete on QLHS_PHANCONG_HOCPHAN_VPK
grant insert, delete on PHANCONG to RL_TRUONGKHOA; 
--grant insert, update, delete on nhansu 
grant select, insert, delete, update on NHANSU to RL_TRUONGKHOA; 
-- Được quyền Xem (không giới hạn) dữ liệu trên toàn bộ lược đồ CSDL.
grant select any table to RL_TRUONGKHOA;
-- CS6: sinh viên
-- sv select chinh mình , update trên cột DCHI, DT
-- grant update(DCHI,DT) on sinhvien
create or replace function SVControl_XEMTTCN (P_SCHEMA VARCHAR2, P_OBJ VARCHAR2) 
return varchar2
as 
    strsql varchar(2000); 
begin
    strsql:= 'MASV = SYS_CONTEXT(''USERENV'',''SESSION_USER'')';
    return strsql;
end;
/
BEGIN
    DBMS_RLS.ADD_POLICY(
        object_schema => 'SYS', 
        object_name => 'SINHVIEN',
        policy_name => 'SVControl_XEMTTCN',
        policy_function => 'SVControl_XEMTTCN',
        statement_types => 'SELECT, UPDATE',
        update_check => TRUE
    );
END;
/
grant select, update(DT) on sinhvien to RL_SINHVIEN; 
/
-- Xem danh sách tất cả học phần (HOCPHAN), kế hoạch mở môn (KHMO) của chương
-- trình Dào tạo mà sinh viên Dang theo học.
create or replace function SVControl_XEMHP (P_SCHEMA VARCHAR2, P_OBJ VARCHAR2) 
RETURN VARCHAR2 AS
    CURSOR HP IS(select DK.MAHP from DANGKY DK, SINHVIEN SV where DK.MACT = SV.MACT AND SV.MASV = SYS_CONTEXT('USERENV','SESSION_USER') );
    USERNAME VARCHAR2(128);
    USERROLE VARCHAR2(128);
    TEMP varchar2(5);
    MAHP_DK varchar2(2000);
BEGIN
-- Lấy username của user hiện tại
  USERNAME := SYS_CONTEXT('USERENV', 'SESSION_USER');
  SELECT GRANTED_ROLE INTO USERROLE
  FROM DBA_ROLE_PRIVS
  WHERE GRANTEE = USERNAME;
  IF 'RL_SINHVIEN' IN (USERROLE) THEN 
      OPEN CUR;  
        LOOP 
            FETCH HP INTO TEMP; 
            EXIT WHEN HP%NOTFOUND;
            IF (MAHP_DK IS NOT NULL) THEN
                MAHP_DK :=  MAHP_DK ||''',''';
            ELSE 
                MAHP_DK := MAHP_DK || TEMP;
            END IF;
        END LOOP;
        CLOSE HP;
        RETURN 'MAHP IN ('''||MAHP_DK||''')';
  ELSE
    RETURN '1=0';
  END IF;
END;
BEGIN
    DBMS_RLS.ADD_POLICY(
        object_schema => 'ADPRO', 
        object_name => 'HOCPHAN',
        policy_name => 'SVControl_HOCPHAN_CS6',
        policy_function => 'SVControl_XEMHP',
        update_check => TRUE
    );
END;
/
grant select on HOCPHAN to RL_SINHVIEN;
/
create or replace function SVControl_XEMKHMO (P_SCHEMA VARCHAR2, P_OBJ VARCHAR2) 
RETURN VARCHAR2 AS
    CURSOR HP IS(select KH.MAHP from KHMO KH, SINHVIEN SV where KH.MACT = SV.MACT AND SV.MASV = SYS_CONTEXT('USERENV','SESSION_USER') );
    USERNAME VARCHAR2(128);
    USERROLE VARCHAR2(128);
    TEMP varchar2(5);
    MAHP_KH varchar2(2000);
BEGIN
-- Lấy username của user hiện tại
  USERNAME := SYS_CONTEXT('USERENV', 'SESSION_USER');
  SELECT GRANTED_ROLE INTO USERROLE
  FROM DBA_ROLE_PRIVS
  WHERE GRANTEE = USERNAME;
  IF 'RL_SINHVIEN' IN (USERROLE) THEN 
      OPEN CUR;  
        LOOP 
            FETCH HP INTO TEMP; 
            EXIT WHEN HP%NOTFOUND;
            IF (MAHP_KH IS NOT NULL) THEN
                MAHP_KH :=  MAHP_KHMAHP_KH ||''',''';
            ELSE 
                MAHP_KH := MAHP_KHMAHP_KH || TEMP;
            END IF;
        END LOOP;
        CLOSE HP;
        RETURN 'MAHP IN ('''||MAHP_KH||''')';
  ELSE
    RETURN '1=0';
  END IF;
END;
BEGIN
    DBMS_RLS.ADD_POLICY(
        object_schema => 'ADPRO', 
        object_name => 'KHMO',
        policy_name => 'SVControl_KHMO_CS6',
        policy_function => 'SVControl_XEMKHMO',
        update_check => TRUE
    );
END;
grant select on KHMO to RL_SINHVIEN;
-- Thêm, Xóa các dòng dữ liệu Dăng ký học phần (DANGKY) liên quan Dến chính sinh
--viên Dó trong học kỳ của năm học hiện tại (nếu thời Diểm hiệu chỉnh Dăng ký còn hợp
--lệ).
grant select, insert, update, delete on DANGKY to RL_SINHVIEN;
create or replace function SVControl_INSERT_DELETE_DANGKY (P_SCHEMA VARCHAR2, P_OBJ VARCHAR2) 
RETURN VARCHAR2 AS
    v_start_date DATE;
    v_current_date DATE := SYSDATE;
BEGIN
    SELECT GRANTED_ROLE INTO USERROLE
    FROM DBA_ROLE_PRIVS
    WHERE GRANTEE = SYS_CONTEXT('USERENV', 'SESSION_USER');
    IF 'RL_SINHVIEN' IN (USERROLE) THEN 
        -- Get the start date of the semester for the current academic year
        SELECT TO_DATE(
                CASE 
                    WHEN TO_CHAR(SYSDATE, 'MM') BETWEEN 1 AND 4 THEN TO_CHAR(SYSDATE, 'YYYY') || '-01-01'
                    WHEN TO_CHAR(SYSDATE, 'MM') BETWEEN 5 AND 8 THEN TO_CHAR(SYSDATE, 'YYYY') || '-05-01'
                    ELSE TO_CHAR(SYSDATE, 'YYYY') || '-09-01'
                END,
                'YYYY-MM-DD'
            )
        INTO v_start_date
        FROM dual;
    
        -- Check if the current date is within the valid modification period (within the semester start date + 14 days)
        IF (v_current_date - v_start_date) <= 14 THEN
            RETURN '1=1'; -- Modification time is valid
        ELSE RETURN '1=0';
        END IF;
    END IF;
END;
/
BEGIN
    DBMS_RLS.ADD_POLICY(
        object_schema => 'ADPRO', 
        object_name => 'KHMO',
        policy_name => 'SVControl_DANGKY_INSERT_DELETE_CS6',
        policy_function => 'SVControl_INSERT_DELETE_DANGKY',
        STATEMENT_TYPES=>'DELETE, INSERT', 
        update_check => TRUE
    );
END;
--Sinh viên không được chỉnh sửa trên các trường liên quan đến điểm.
create or replace function SVControl_UPDATE_DANGKY (P_SCHEMA VARCHAR2, P_OBJ VARCHAR2) 
RETURN VARCHAR2 AS
    USERNAME VARCHAR2(128);
    USERROLE VARCHAR2(128);
BEGIN
-- Lấy username của user hiện tại
  USERNAME := SYS_CONTEXT('USERENV', 'SESSION_USER');
  SELECT GRANTED_ROLE INTO USERROLE
  FROM DBA_ROLE_PRIVS
  WHERE GRANTEE = USERNAME;
  IF 'RL_SINHVIEN' IN (USERROLE) THEN 
    RETURN '1=0';
  END IF;
END;
BEGIN
    DBMS_RLS.ADD_POLICY(
        object_schema => 'ADPRO', 
        object_name => 'KHMO',
        policy_name => 'SVControl_KHMO_CS6',
        policy_function => 'SVControl_XEMKHMO',
        statement_types=>'UPDATE', 
        sec_relevant_cols => 'DIEMTHI,DIEMQT,DIEMCK,DIEMTK',
        sec_relevant_cols_opt => dbms_rls.ALL_ROWS,
        update_check => TRUE
    );
END;
-- Sinh viên được Xem tất cả thông tin trên quan hệ ĐANGKY tại các dòng dữ liệu liên
-- quan đến chính sinh viên.
/
BEGIN
    DBMS_RLS.ADD_POLICY(
        object_schema => 'ADPRO', 
        object_name => 'DANGKY',
        policy_name => 'SVControl_SELECT_DANGKY',
        policy_function => 'SVControl_XEMTTCN',
        statement_types => 'SELECT',
        update_check => TRUE
    );
END;
/
ALTER SESSION SET "_ORACLE_SCRIPT" = FALSE;
    