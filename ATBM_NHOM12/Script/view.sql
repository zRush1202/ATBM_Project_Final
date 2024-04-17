ALTER SESSION SET "_ORACLE_SCRIPT" = True;

DROP ROLE RL_NVCOBAN;
DROP ROLE RL_GIANGVIEN;
DROP ROLE RL_GIAOVU;
DROP ROLE RL_TRUONGDV;
DROP ROLE RL_TRUONGKHOA;
DROP ROLE RL_SINHVIEN;

/
create role RL_NVCOBAN;
create role RL_GIANGVIEN;
create role RL_GIAOVU;
create role RL_TRUONGDV;
create role RL_TRUONGKHOA;
create role RL_SINHVIEN;
SELECT * FROM ALL_USERS;
grant create session to RL_NVCOBAN;

grant create session to RL_GIANGVIEN;
grant create session to RL_GIAOVU;
grant create session to RL_TRUONGDV;
grant create session to RL_TRUONGKHOA;
grant create session to RL_SINHVIEN;
-- CS1: Nhân viên cơ bản
create or replace view ADPRO.QLHS_TTCANHAN
as
    select * from ADPRO.NHANSU where MANV = SYS_CONTEXT('USERENV','SESSION_USER');
-- Grant update on view
grant select, update(DT) on ADPRO.QLHS_TTCANHAN to RL_NVCOBAN;
-- Grant select on sinh vien, don vi, hoc phan, khmo
grant select on ADPRO.SINHVIEN to RL_NVCOBAN;
grant select on ADPRO.DONVI to RL_NVCOBAN;
grant select on ADPRO.HOCPHAN to RL_NVCOBAN;
grant select on ADPRO.KHMO to RL_NVCOBAN;
-- CS2 : Giảng viên
-- Như CS1
grant select, update(DT) on ADPRO.QLHS_TTCANHAN to RL_GIANGVIEN;
-- Grant select on sinh vien, don vi, hoc phan, khmo
grant select on ADPRO.SINHVIEN to RL_GIANGVIEN;
grant select on ADPRO.DONVI to RL_GIANGVIEN;
grant select on ADPRO.HOCPHAN to RL_GIANGVIEN;
grant select on ADPRO.KHMO to RL_GIANGVIEN;
--grant RL_NVCOBAN to RL_GIANGVIEN;
-- grant select on QLHS_PHANCONG_GD
-- grant select on QLHS_DANGKY_HPGD
create or replace view ADPRO.QLHS_PHANCONG_GD
as
    select * from ADPRO.PHANCONG where MAGV = SYS_CONTEXT('USERENV','SESSION_USER');

create or replace view ADPRO.QLHS_DANGKY_HPGD
as
    select * from ADPRO.DANGKY where MAGV = SYS_CONTEXT('USERENV','SESSION_USER');
grant select on ADPRO.QLHS_PHANCONG_GD to RL_GIANGVIEN;
grant select on ADPRO.QLHS_DANGKY_HPGD to RL_GIANGVIEN;
-- grant update on dangky(diemth,diemqt, diemck,diemtk)
GRANT SELECT, UPDATE(DIEMTH, DIEMQT, DIEMCK, DIEMTK) ON ADPRO.QLHS_DANGKY_DIEM_GV TO RL_GIANGVIEN;

/
--CS3 : giao vu
-- Như CS1
grant select, update(DT) on ADPRO.QLHS_TTCANHAN to RL_GIAOVU;
--Xem, Thêm mới hoặc Cập nhật dữ liệu trên các quan hệ SINHVIEN, ĐONVI,
--HOCPHAN, KHMO, theo yêu cầu của trưởng khoa.
-- grant update select insert on sinh vien, donvi, hocphan, khmo
grant select, insert, update on ADPRO.SINHVIEN to RL_GIAOVU;
grant select, insert, update on ADPRO.HOCPHAN to RL_GIAOVU;
grant select, insert, update on ADPRO.DONVI to RL_GIAOVU;
grant select, insert, update on ADPRO.KHMO to RL_GIAOVU;
-- grant select on phancong
grant select,update on ADPRO.PHANCONG to RL_GIAOVU;
-- grant select phan cong, grnat update on QLHS_PHANCONG_HOCPHAN_VPK
/
--Xem dữ liệu trên toàn bộ quan hệ PHANCONG. Tuy nhiên, chỉ được sửa trên các dòng
--dữ liệu phân công liên quan các học phần do “Văn phòng khoa” phụ trách phân công
--giảng dạy, thừa hành người trưởng đơn vị tương ứng là trưởng khoa.
CREATE OR REPLACE FUNCTION ADPRO.QL_XEM_HP_VPK(
  P_SCHEMA IN VARCHAR2 DEFAULT NULL,
  P_OBJECT IN VARCHAR2 DEFAULT NULL
) RETURN VARCHAR2 AS
    CURSOR HP IS(select MAHP from ADPRO.HOCPHAN where MADV = 'VPK');
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
        policy_function => 'ADPRO.QL_XEM_HP_VPK',
        statement_types => 'INSERT, DELETE, UPDATE',
        update_check => TRUE
    );
END;
/
grant insert, delete on ADPRO.dangky to RL_GIAOVU;
CREATE OR REPLACE TRIGGER ADPRO.CheckRegistrationDate
INSTEAD OF INSERT OR DELETE ON ADPRO.DANGKY
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
        FROM ADPRO.KHMO
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
                INSERT INTO ADPRO.DANGKY (MASV, MAGV, MAHP, HK, NAM, MACT, DIEMTHI, DIEMQT, DIEMCK, DIEMTK)
                VALUES (:NEW.MASV, :NEW.MAGV, :NEW.MAHP, :NEW.HK, :NEW.NAM, :NEW.MACT, :NEW.DIEMTHI, :NEW.DIEMQT, :NEW.DIEMCK, :NEW.DIEMTK);
            ELSIF DELETING THEN
                DELETE FROM ADPRO.DANGKY
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

--Thêm, Xóa, Cập nhật dữ liệu trên quan hệ PHANCONG, đối với các học phần được
--phụ trách chuyên môn bởi đơn vị mà mình làm trưởng
CREATE OR REPLACE FUNCTION truongdv_policy_function (
    schema_var IN VARCHAR2,
    table_name_var IN VARCHAR2
) RETURN VARCHAR2
AS
    vaitro VARCHAR2(50);
BEGIN
    SELECT NVL(MAX(VAITRO), 'OTHER') INTO vaitro
    FROM NHANSU
    WHERE MANV = SYS_CONTEXT('USERENV', 'SESSION_USER');

    IF vaitro = 'RL_TRUONGDV' THEN
        RETURN 'MADV = (SELECT MADV FROM NHANSU WHERE MANS = SYS_CONTEXT(''USERENV'', ''SESSION_USER''))';
    ELSE
        RETURN '1=1';
    END IF;
END;
/

BEGIN
    DBMS_RLS.ADD_POLICY(
        object_schema   => 'ADPRO',
        object_name     => 'PHANCONG',
        policy_name     => 'TruongDV_Policy',
        policy_function => 'truongdv_policy_function',
        statement_types => 'INSERT, UPDATE, DELETE',
        update_check    => TRUE,
        enable          => TRUE
    );
END;
/

--Được xem dữ liệu phân công giảng dạy của các giảng viên thuộc các đơn vị mà mình
--làm trưởng.
CREATE OR REPLACE FUNCTION truongdv_xem_pc (p_schema VARCHAR2, p_table VARCHAR2)
  RETURN VARCHAR2
AS
  v_condition VARCHAR2(4000);
BEGIN
  v_condition := '1=1';
  IF SYS_CONTEXT('USERENV', 'SESSION_USER') = 'RL_TRUONGDV' THEN
    v_condition := 'EXISTS (
      SELECT 1
      FROM PHANCONG pc
      JOIN NHANSU ns ON pc.MAGV = ns.MANV
      WHERE ns.MADV = (SELECT MADV FROM NHANSU WHERE MANV = SYS_CONTEXT(''USERENV'', ''SESSION_USER''))
        AND pc.MAGV = ns.MANV)';
  END IF;
  RETURN v_condition;
END;
/

BEGIN
  DBMS_RLS.ADD_POLICY(
    object_schema   => 'ADPRO',
    object_name     => 'PHANCONG',
    policy_name     => 'truongdv_xem_pc_policy',
    function_schema => 'ADPRO',
    policy_function => 'truongdv_xem_pc',
    statement_types => 'SELECT'
  );
END;
/

-- CS5: Trưởng khoa
-- view QLHS_TTCANHAN
-- grant select on QLHS_PHANCONG_GD
-- grant select on QLHS_DANGKY_HPGD
-- grant update on dangky(diemth,diemqt, diemck,diemtk)
grant select, update(DT) on ADPRO.QLHS_TTCANHAN to RL_TRUONGKHOA;
-- Grant select on sinh vien, don vi, hoc phan, khmo
grant select on ADPRO.SINHVIEN to RL_TRUONGKHOA;
grant select on ADPRO.DONVI to RL_TRUONGKHOA;
grant select on ADPRO.HOCPHAN to RL_TRUONGKHOA;
grant select on ADPRO.KHMO to RL_TRUONGKHOA;
grant select on ADPRO.QLHS_PHANCONG_GD to RL_TRUONGKHOA;
grant select on ADPRO.QLHS_DANGKY_HPGD to RL_TRUONGKHOA;
-- grant update on dangky(diemth,diemqt, diemck,diemtk)
GRANT SELECT, UPDATE(DIEMTH, DIEMQT, DIEMCK, DIEMTK) ON ADPRO.QLHS_DANGKY_DIEM_GV TO RL_TRUONGKHOA;
-- grant insert, update , delete on QLHS_PHANCONG_HOCPHAN_VPK
grant insert, delete on ADPRO.PHANCONG to RL_TRUONGKHOA; 
--grant insert, update, delete on nhansu 
grant select, insert, delete, update on ADPRO.NHANSU to RL_TRUONGKHOA; 
-- Được quyền Xem (không giới hạn) dữ liệu trên toàn bộ lược đồ CSDL.
grant select any table to RL_TRUONGKHOA;
-- CS6: sinh viên
-- sv select chinh mình , update trên cột DCHI, DT
-- grant update(DCHI,DT) on sinhvien
create or replace function ADPRO.SVControl_XEMTTCN (P_SCHEMA VARCHAR2, P_OBJ VARCHAR2) 
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
        object_schema => 'ADPRO', 
        object_name => 'ADPRO.SINHVIEN',
        policy_name => 'SVControl_XEMTTCN',
        policy_function => 'ADPRO.SVControl_XEMTTCN',
        statement_types => 'SELECT, UPDATE',
        update_check => TRUE
    );
END;
/
grant select, update(DT) on ADPRO.sinhvien to RL_SINHVIEN; 
/
-- Xem danh sách tất cả học phần (HOCPHAN), kế hoạch mở môn (KHMO) của chương
-- trình Dào tạo mà sinh viên Dang theo học.
create or replace function ADPRO.SVControl_XEMHP (P_SCHEMA VARCHAR2, P_OBJ VARCHAR2) 
RETURN VARCHAR2 AS
    CURSOR HP IS(select DK.MAHP from ADPRO.DANGKY DK, ADPRO.SINHVIEN SV where DK.MACT = SV.MACT AND SV.MASV = SYS_CONTEXT('USERENV','SESSION_USER') );
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
        object_name => 'ADPRO.HOCPHAN',
        policy_name => 'SVControl_HOCPHAN_CS6',
        policy_function => 'ADPRO.SVControl_XEMHP',
        update_check => TRUE
    );
END;
/
grant select on ADPRO.HOCPHAN to RL_SINHVIEN;
/
create or replace function ADPRO.SVControl_XEMKHMO (P_SCHEMA VARCHAR2, P_OBJ VARCHAR2) 
RETURN VARCHAR2 AS
    CURSOR HP IS(select KH.MAHP from ADPRO.KHMO KH, ADPRO.SINHVIEN SV where KH.MACT = SV.MACT AND SV.MASV = SYS_CONTEXT('USERENV','SESSION_USER') );
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
        object_name => 'ADPRO.KHMO',
        policy_name => 'ADPRO.SVControl_KHMO_CS6',
        policy_function => 'SVControl_XEMKHMO',
        update_check => TRUE
    );
END;
grant select on ADPRO.KHMO to RL_SINHVIEN;
-- Thêm, Xóa các dòng dữ liệu Dăng ký học phần (DANGKY) liên quan Dến chính sinh
--viên Dó trong học kỳ của năm học hiện tại (nếu thời Diểm hiệu chỉnh Dăng ký còn hợp
--lệ).
grant select, insert, update, delete on ADPRO.DANGKY to RL_SINHVIEN;
create or replace function ADPRO.SVControl_INSERT_DELETE_DANGKY (P_SCHEMA VARCHAR2, P_OBJ VARCHAR2) 
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
        object_name => 'ADPRO.KHMO',
        policy_name => 'SVControl_DANGKY_INSERT_DELETE_CS6',
        policy_function => 'ADPRO.SVControl_INSERT_DELETE_DANGKY',
        STATEMENT_TYPES=>'DELETE, INSERT', 
        update_check => TRUE
    );
END;
--Sinh viên không được chỉnh sửa trên các trường liên quan đến điểm.
create or replace function ADPRO.SVControl_UPDATE_DANGKY (P_SCHEMA VARCHAR2, P_OBJ VARCHAR2) 
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
        object_name => 'ADPRO.KHMO',
        policy_name => 'SVControl_KHMO_CS6',
        policy_function => 'ADPRO.SVControl_XEMKHMO',
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
        object_name => 'ADPRO.DANGKY',
        policy_name => 'SVControl_SELECT_DANGKY',
        policy_function => 'ADPRO.SVControl_XEMTTCN',
        statement_types => 'SELECT',
        update_check => TRUE
    );
END;
/
ALTER SESSION SET "_ORACLE_SCRIPT" = FALSE;

    