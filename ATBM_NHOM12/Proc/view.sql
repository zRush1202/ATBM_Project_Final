ALTER SESSION SET "_ORACLE_SCRIPT" = True;
create role RL_NVCOBAN;
create role RL_GIANGVIEN;
create role RL_GIAOVU;
create role RL_TRUONGDV;
create role RL_TRUONGKHOA;
create role RL_SINHVIEN;

grant create session to RL_NVCOBAN;
grant create session to RL_GIANGVIEN;
grant create session to RL_GIAOVU;
grant create session to RL_TRUONGDV;
grant create session to RL_TRUONGKHOA;
grant create session to RL_SINHVIEN;
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
-- grant update select insert on sinh vien, donvi, hocphan, khmo
grant select, insert, update on SINHVIEN to RL_GIAOVU;
grant select, insert, update on HOCPHAN to RL_GIAOVU;
grant select, insert, update on DONVI to RL_GIAOVU;
grant select, insert, update on KHMO to RL_GIAOVU;
-- grant select on phancong
grant select,update on PHANCONG to RL_GIAOVU;
-- grant select phan cong, grnat update on QLHS_PHANCONG_HOCPHAN_VPK
/
CREATE OR REPLACE FUNCTION QL_XEM_HP_VPK(P_SCHEMA IN VARCHAR2,P_OBJECT IN VARCHAR2) 
RETURN VARCHAR2 AS
    CURSOR HP IS(select MAHP from HOCPHAN where MADV = 'VPK');
    USERROLE VARCHAR2(128);
    TEMP varchar2(5);
    MAHP varchar2(2000);
  
BEGIN
--  IF USERNAME = 'QLDA' THEN
--    RETURN '';
--  END IF;
  SELECT GRANTED_ROLE INTO USERROLE
  FROM DBA_ROLE_PRIVS
  WHERE GRANTEE = SYS_CONTEXT('USERENV', 'SESSION_USER');
  IF 'RL_GIAOVU' IN (USERROLE) THEN 
--      OPEN CUR; 
--      STRSQL := 'ALTER SESSION SET "_ORACLE_SCRIPT" = TRUE'; 
      EXECUTE IMMEDIATE(STRSQL);  
        LOOP 
            FETCH HP INTO TEMP; 
            EXIT WHEN HP%NOTFOUND;
            IF MAHP IS NOT NULL THEN
                MAHP := MAHP || ',''' || TEMP || '''';
            ELSE 
                MAHP := '''' || TEMP || '''';
            END IF;
        END LOOP;
        CLOSE HP;
        RETURN 'MAHP IN (' || MAHP || ')';
  ELSE
    RETURN '1=0';
  END IF;
END;
/
BEGIN
    DBMS_RLS.ADD_POLICY(
        object_schema => 'ADMIN_HW4', 
        object_name => 'PHANCONG',
        policy_name => 'PHANCONG_CONTROL_CS3',
        policy_function => 'QL_XEM_HP_VPK',
        statement_types => 'UPDATE',
        update_check => TRUE
    );
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

-- grant insert, update , delete on QLHS_PHANCONG_HOCPHAN_VPK

--grant insert, update, delete on nhansu 

-- grant select on sinhvien, donvi, hocphan, kmon, dangky

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
        object_schema => 'ADPRO', 
        object_name => 'SINHVIEN',
        policy_name => 'SVControl_XEMTTCN',
        policy_function => 'SVControl_XEMTTCN',
        statement_types => 'SELECT, UPDATE',
        update_check => TRUE
    );
END;
/
-- Xem danh sách tất cả học phần (HOCPHAN), kế hoạch mở môn (KHMO) của chương
-- trình Dào tạo mà sinh viên Dang theo học.
create or replace function SVControl_XEMHP (P_SCHEMA VARCHAR2, P_OBJ VARCHAR2) 
return varchar2
as 
        CURSOR HP IS(select HP.MAHP from HOCPHAN HP, SINHVIEN SV 
        where HP.MACT = SV.MACT and SV.MASV = SYS_CONTEXT('USERENV','SESSION_USER'));
        USERROLE VARCHAR2(128);
        TEMP varchar2(5);
        MAHP varchar2(2000);
BEGIN
  SELECT GRANTED_ROLE INTO USERROLE
  FROM DBA_ROLE_PRIVS
  WHERE GRANTEE = SYS_CONTEXT('USERENV', 'SESSION_USER');
  IF 'RL_SINHVIEN' IN (USERROLE) THEN 
      OPEN CUR; 
--      STRSQL := 'ALTER SESSION SET "_ORACLE_SCRIPT" = TRUE'; 
--      EXECUTE IMMEDIATE(STRSQL);  
        LOOP 
            FETCH HP INTO TEMP; 
            EXIT WHEN HP%NOTFOUND;
            IF MAHP IS NOT NULL THEN
                MAHP := MAHP || ',''' || TEMP || '''';
            ELSE 
                MAHP := '''' || TEMP || '''';
            END IF;
        END LOOP;
        CLOSE HP;
        RETURN 'MAHP IN (' || MAHP || ')';
  ELSE
    RETURN '1=0';
  END IF;
END;    
BEGIN
    DBMS_RLS.ADD_POLICY(
        object_schema => 'ADPRO', 
        object_name => 'HOCPHAN',
        policy_name => 'SVControl_XEMHP',
        policy_function => 'SVControl_XEMHP',
        update_check => TRUE
    );
END;

create or replace function SVControl_XEMKHMO (P_SCHEMA VARCHAR2, P_OBJ VARCHAR2) 
return varchar2
as 
        CURSOR KH IS(select KH.MAHP from KHMO KH, SINHVIEN SV 
        where KH.MACT = SV.MACT and SV.MASV = SYS_CONTEXT('USERENV','SESSION_USER'));
        USERROLE VARCHAR2(128);
        TEMP varchar2(5);
        MAHP_KH varchar2(2000);
BEGIN
  SELECT GRANTED_ROLE INTO USERROLE
  FROM DBA_ROLE_PRIVS
  WHERE GRANTEE = SYS_CONTEXT('USERENV', 'SESSION_USER');
  IF 'RL_SINHVIEN' IN (USERROLE) THEN 
      OPEN CUR; 
--      STRSQL := 'ALTER SESSION SET "_ORACLE_SCRIPT" = TRUE'; 
--      EXECUTE IMMEDIATE(STRSQL);  
        LOOP 
            FETCH KH INTO TEMP; 
            EXIT WHEN HP%NOTFOUND;
            IF KH IS NOT NULL THEN
                MAHP_KH := MAHP_KH || ',''' || TEMP || '''';
            ELSE 
                MAHP_KH := '''' || TEMP || '''';
            END IF;
        END LOOP;
        CLOSE HP;
        RETURN 'MAHP IN (' || MAHP || ')';
  ELSE
    RETURN '1=0';
  END IF;
END;
/
BEGIN
    DBMS_RLS.ADD_POLICY(
        object_schema => 'ADPRO', 
        object_name => 'KHMO',
        policy_name => 'SVControl_XEMKHMO',
        policy_function => 'SVControl_XEMKHMO',
        update_check => TRUE
    );
END;

-- Thêm, Xóa các dòng dữ liệu Dăng ký học phần (DANGKY) liên quan Dến chính sinh
--viên Dó trong học kỳ của năm học hiện tại (nếu thời Diểm hiệu chỉnh Dăng ký còn hợp
--lệ).
CREATE OR REPLACE FUNCTION SVControl_DANGKY (P_SCHEMA IN VARCHAR2,P_OBJECT IN VARCHAR2) 
RETURN VARCHAR2 AS
  CURRENT_DATE DATE := SYSDATE;
  CURRENT_YEAR NUMBER := TO_NUMBER(TO_CHAR(CURRENT_DATE, 'YYYY'));
  CURRENT_MONTH NUMBER := TO_NUMBER(TO_CHAR(CURRENT_DATE, 'MM'));
  SEMESTER_START_DATE DATE;
  SEMESTER int;
  USERNAME VARCHAR2(128);
BEGIN
  -- Lấy username của user hiện tại
  USERNAME := SYS_CONTEXT('USERENV', 'SESSION_USER');
    SELECT GRANTED_ROLE INTO USERROLE
    FROM DBA_ROLE_PRIVS
    WHERE GRANTEE = SYS_CONTEXT('USERENV', 'SESSION_USER');
    IF 'RL_SINHVIEN' IN (USERROLE) THEN 
      -- Xác định ngày bắt đầu của học kỳ
      IF CURRENT_MONTH <= 4 THEN
        SEMESTER := 1;
        SEMESTER_START_DATE := TO_DATE(CURRENT_YEAR || '/01/01' , 'YYYY/MM/DD');
      ELSIF CURRENT_MONTH <= 8 THEN
        SEMESTER := 2;
        SEMESTER_START_DATE := TO_DATE(CURRENT_YEAR || '/05/01' , 'YYYY/MM/DD');
      ELSE
        SEMESTER := 3;
        SEMESTER_START_DATE := TO_DATE(CURRENT_YEAR || '09/01' , 'YYYY/MM/DD');
      END IF;
    -- Kiểm tra xem ngày hiện tại có vượt quá 14 ngày so với ngày bắt đầu học kỳ không
    IF CURRENT_DATE <= SEMESTER_START_DATE + 14 THEN
    -- Nếu không, cho phép sinh viên chỉnh sửa các dòng liên quan đến chính họ
        RETURN 'MASV = ''' || USERNAME || ''' and HOCKY = '||SEMESTER||' and NAM = '||CURENT_YEAR||'';
    ELSE
    -- Nếu có, không cho phép sinh viên chỉnh sửa bất kỳ dòng nào
        RETURN '1=0';
    END IF;
    
    ELSE
        RETURN '1=0';
    END IF;
END;
/

BEGIN
  DBMS_RLS.ADD_POLICY(
    object_schema => 'ADPRO',
    object_name => 'DANGKY',
    policy_name => 'DANGKY_VPD_POLICY',
    policy_function => 'SVControl_DANGKY',
    statement_types => 'INSERT,DELETE',
    update_check => TRUE
  );
END;
/
-- Sinh viên không được chỉnh sửa trên các trường liên quan đến điểm.
CREATE OR REPLACE FUNCTION SVControl_update_DK (
  schema_p IN VARCHAR2,
  table_p IN VARCHAR2
) RETURN VARCHAR2 AS

    USERROLE VARCHAR2(128);
BEGIN
  -- Nếu người dùng hiện tại là sinh viên, không cho phép họ chỉnh sửa các trường điểm
    SELECT GRANTED_ROLE INTO USERROLE
    FROM DBA_ROLE_PRIVS
    WHERE GRANTEE = SYS_CONTEXT('USERENV', 'SESSION_USER');
  IF 'RL_SINHVIEN' IN (USERROLE) THEN 
    RETURN '1=0'; -- Điều kiện không bao giờ đúng, ngăn chặn mọi thao tác chỉnh sửa
  ELSE
    RETURN '1=1'; -- Cho phép thao tác chỉnh sửa nếu người dùng không phải là sinh viên
  END IF;
END;
/

BEGIN
  DBMS_RLS.ADD_POLICY(
    object_schema => 'ADPRO',
    object_name => 'DANGKY',
    policy_name => 'SVControl_update_DK',
    policy_function => 'SVControl_update_DK',
    statement_types => 'UPDATE',
    sec_relevant_cols => 'DIEMTH, DIEMQT, DIEMCK, DIEMTK',
    sec_relevant_cols_opt => DBMS_RLS.ALL_ROWS
  );
END;
/
ALTER SESSION SET "_ORACLE_SCRIPT" = FALSE;
    