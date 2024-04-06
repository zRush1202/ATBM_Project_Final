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
-- grant update select insert on sinh vien, donvi, hocphan, khmo
grant select, insert, update on SINHVIEN to RL_GIAOVU;
grant select, insert, update on HOCPHAN to RL_GIAOVU;
grant select, insert, update on DONVI to RL_GIAOVU;
grant select, insert, update on KHMO to RL_GIAOVU;
-- grant select on phancong
grant select,update on PHANCONG to RL_GIAOVU;
-- grant select phan cong, grnat update on QLHS_PHANCONG_HOCPHAN_VPK
/
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
      STRSQL := 'ALTER SESSION SET "_ORACLE_SCRIPT" = TRUE'; 
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
        object_schema => 'SYS', 
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
    strsql varchar(2000); 
begin
    strsql:= 'HP.MACT = SV.MACT AND SV.MASV = SYS_CONTEXT(''USERENV'',''SESSION_USER'')';
    return strsql;
end;
BEGIN
    DBMS_RLS.ADD_POLICY(
        object_schema => 'SYS', 
        object_name => 'HOCPHAN',
        policy_name => 'SVControl_XEMHP',
        policy_function => 'SVControl_XEMHP',
        update_check => TRUE
    );
END;

create or replace function SVControl_XEMKHMO (P_SCHEMA VARCHAR2, P_OBJ VARCHAR2) 
return varchar2
as 
    strsql varchar(2000); 
begin
    strsql:= 'KH.MACT = SV.MACT AND SV.MASV = SYS_CONTEXT(''USERENV'',''SESSION_USER'')';
    return strsql;
end;
BEGIN
    DBMS_RLS.ADD_POLICY(
        object_schema => 'SYS', 
        object_name => 'KHMO',
        policy_name => 'SVControl_XEMKHMO',
        policy_function => 'SVControl_XEMKHMO',
        update_check => TRUE
    );
END;

-- Thêm, Xóa các dòng dữ liệu Dăng ký học phần (DANGKY) liên quan Dến chính sinh
--viên Dó trong học kỳ của năm học hiện tại (nếu thời Diểm hiệu chỉnh Dăng ký còn hợp
--lệ).
ALTER SESSION SET "_ORACLE_SCRIPT" = FALSE;
    