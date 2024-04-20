

--DROP ROLE RL_NVCOBAN;
--DROP ROLE RL_GIANGVIEN;
--DROP ROLE RL_GIAOVU;
--DROP ROLE RL_TRUONGDV;
--DROP ROLE RL_TRUONGKHOA;
--DROP ROLE RL_SINHVIEN;

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
GRANT SELECT, UPDATE(DIEMTH, DIEMQT, DIEMCK, DIEMTK) ON  ADPRO.QLHS_DANGKY_HPGD TO RL_GIANGVIEN;

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
    TEMP varchar2(6);
    MAHP varchar2(2000);
  
BEGIN
  -- Lấy username của user hiện tại
  USERNAME := SYS_CONTEXT('USERENV', 'SESSION_USER');
  
  IF USERNAME = 'ADPRO' THEN
    RETURN ''; -- Không áp dụng chính sách nếu người dùng là 'ADPRO'
  END IF;
  
  -- Lấy vai trò của người dùng
  SELECT GRANTED_ROLE INTO USERROLE
  FROM DBA_ROLE_PRIVS
  WHERE GRANTEE = USERNAME;
  
  IF 'RL_GIAOVU' IN (USERROLE) THEN 
      OPEN HP;  
        LOOP 
            FETCH HP INTO TEMP; 
            EXIT WHEN HP%NOTFOUND;
            IF (MAHP IS NOT NULL) THEN
                MAHP := MAHP || ',' || '''' || TEMP || '''';
            ELSE
                MAHP :=  '''' || TEMP || '''';
            END IF;
        END LOOP;
        CLOSE HP;
        RETURN 'MAHP IN ('||MAHP||')';
    ELSE
        RETURN '';
  END IF;
END;
/
BEGIN
    DBMS_RLS.ADD_POLICY(
        object_schema => 'ADPRO', 
        object_name => 'PHANCONG',
        policy_name => 'GIAOVU_PHANCONG_CS3',
        function_schema => 'ADPRO', 
        policy_function => 'QL_XEM_HP_VPK',
        statement_types => 'UPDATE',
        update_check => TRUE
    );
END;
/
--BEGIN
--    DBMS_RLS.DROP_POLICY(
--        object_schema => 'ADPRO', 
--        object_name => 'PHANCONG',
--        policy_name => 'GIAOVU_PHANCONG_CS3'
--    );
--END;
grant insert, delete, select on ADPRO.dangky to RL_GIAOVU;
/
CREATE OR REPLACE TRIGGER ADPRO.CheckRegistrationDate
BEFORE INSERT OR DELETE ON ADPRO.DANGKY
FOR EACH ROW
DECLARE
    v_CurrentDate DATE := SYSDATE;
    v_Semester INT;
    v_SemesterStartDate DATE;
    USERROLE VARCHAR2(30);
    v_Username VARCHAR2(128);
BEGIN
    -- Lấy username của user hiện tại
    v_Username := SYS_CONTEXT('USERENV', 'SESSION_USER');

    -- Kiểm tra xem người dùng có phải là 'ADPRO' không
    IF v_Username = 'ADPRO' THEN
        RETURN; -- Nếu là 'ADPRO', không áp dụng trigger
    END IF;
    -- Kiểm tra xem người thực hiện có role 'RL_GIAOVU' không
    SELECT GRANTED_ROLE INTO USERROLE
    FROM DBA_ROLE_PRIVS
    WHERE GRANTEE = v_Username;

    -- Kiểm tra xem người thực hiện có role 'RL_GIAOVU' không
    IF 'RL_GIAOVU' IN (USERROLE) THEN 
        -- Lấy tháng hiện tại
        SELECT EXTRACT(MONTH FROM SYSDATE) INTO v_Semester FROM DUAL;
        
        -- Xác định ngày bắt đầu học kỳ dựa trên tháng hiện tại
        IF v_Semester <= 4 THEN
            v_SemesterStartDate := TO_DATE(TO_CHAR(SYSDATE, 'YYYY') || '/01/01', 'YYYY/MM/DD');
        ELSIF v_Semester <= 8 THEN
            v_SemesterStartDate := TO_DATE(TO_CHAR(SYSDATE, 'YYYY') || '/05/01', 'YYYY/MM/DD');
        ELSE
            v_SemesterStartDate := TO_DATE(TO_CHAR(SYSDATE, 'YYYY') || '/09/01', 'YYYY/MM/DD');
        END IF;

        -- Kiểm tra nếu ngày hiện tại cách ngày bắt đầu học kỳ 14 ngày trở lên
        IF (v_CurrentDate - v_SemesterStartDate) > 14 THEN
            RAISE_APPLICATION_ERROR(-20001, 'Ban khong the xoa hoac them du lieu sau 14 ngay ke tu ngay bat dau ki moi!');
        ELSE
            RETURN;
        END IF;
    END IF;
END;

-- CS4 : TRưởng Dơn vị 
-- view QLHS_TTCANHAN
-- grant select on QLHS_PHANCONG_GD
-- grant select on QLHS_DANGKY_HPGD
-- grant update on dangky(diemth,diemqt, diemck,diemtk)

-- grant insert , delete, update on QLHS_PHANCONG_TRGDV
-- Nhu cs2
grant select, update(DT) on ADPRO.QLHS_TTCANHAN to RL_TRUONGDV;
grant select on ADPRO.SINHVIEN to RL_TRUONGDV;
grant select on ADPRO.DONVI to RL_TRUONGDV;
grant select on ADPRO.HOCPHAN to RL_TRUONGDV;
grant select on ADPRO.KHMO to RL_TRUONGDV;
grant select on ADPRO.QLHS_PHANCONG_GD to RL_TRUONGDV;
grant select on ADPRO.QLHS_DANGKY_HPGD to RL_TRUONGDV;
GRANT SELECT, UPDATE(DIEMTH, DIEMQT, DIEMCK, DIEMTK) ON  ADPRO.QLHS_DANGKY_HPGD TO RL_TRUONGDV;
--Thêm, Xóa, Cập nhật dữ liệu trên quan hệ PHANCONG, đối với các học phần được
--phụ trách chuyên môn bởi đơn vị mà mình làm trưởng
grant select ,insert, delete, update on ADPRO.PHANCONG to RL_TRUONGDV;
CREATE OR REPLACE FUNCTION ADPRO.TDVControl_PhanCong_HocPhan (
  P_SCHEMA IN VARCHAR2 DEFAULT NULL,
  P_OBJECT IN VARCHAR2 DEFAULT NULL
) 
RETURN VARCHAR2 AS
    CURSOR HP IS(select hp.MAHP from ADPRO.HOCPHAN hp, ADPRO.DONVI dv 
    where hp.madv = dv.madv and dv.trgdv = SYS_CONTEXT('USERENV', 'SESSION_USER') );
    USERNAME VARCHAR2(128);
    USERROLE VARCHAR2(128);
    TEMP varchar2(6);
    MAHP varchar2(2000);
  
BEGIN
  -- Lấy username của user hiện tại
  USERNAME := SYS_CONTEXT('USERENV', 'SESSION_USER');
  
  IF USERNAME = 'ADPRO' THEN
    RETURN ''; -- Không áp dụng chính sách nếu người dùng là 'ADPRO'
  END IF;
  
  -- Lấy vai trò của người dùng
  SELECT GRANTED_ROLE INTO USERROLE
  FROM DBA_ROLE_PRIVS
  WHERE GRANTEE = USERNAME;
  
   IF 'RL_TRUONGDV' IN (USERROLE) THEN 
        OPEN HP;  
        LOOP 
            FETCH HP INTO TEMP; 
            EXIT WHEN HP%NOTFOUND;
            IF (MAHP IS NOT NULL) THEN
                MAHP := MAHP || ',' || '''' || TEMP || '''';
            ELSE
                MAHP :=  '''' || TEMP || '''';
            END IF;
        END LOOP;
        CLOSE HP;
        RETURN 'MAHP IN ('||MAHP||')';
    ELSE
        RETURN '';
  END IF;
END;
/
BEGIN
    DBMS_RLS.ADD_POLICY(
        object_schema   => 'ADPRO',
        object_name     => 'PHANCONG',
        policy_name     => 'TruongDV_PhanCong_HocPhan',
        function_schema => 'ADPRO',
        policy_function => 'TDVControl_PhanCong_HocPhan',
        statement_types => 'INSERT, UPDATE, DELETE',
        update_check    => TRUE
    );
END;
/
--BEGIN
--    DBMS_RLS.DROP_POLICY(
--        object_schema => 'ADPRO',
--        object_name => 'PHANCONG',
--        policy_name => 'TruongDV_Policy'
--    );
--END;
--Được xem dữ liệu phân công giảng dạy của các giảng viên thuộc các đơn vị mà mình
--làm trưởng.
grant select on ADPRO.NHANSU to RL_TRUONGDV;

CREATE OR REPLACE FUNCTION ADPRO.TDVControl_PhanCong_NhanSu (
  P_SCHEMA IN VARCHAR2 DEFAULT NULL,
  P_OBJECT IN VARCHAR2 DEFAULT NULL
) 
RETURN VARCHAR2 AS
    CURSOR GV IS(select ns.MANV from ADPRO.NHANSU ns, ADPRO.DONVI dv 
    where (ns.vaitro = 'GIANGVIEN' or ns.vaitro = 'TRUONGDV') and ns.madv = dv.madv and dv.trgdv = SYS_CONTEXT('USERENV', 'SESSION_USER') );
    USERNAME VARCHAR2(128);
    USERROLE VARCHAR2(128);
    TEMP varchar2(6);
    MAGV varchar2(2000);
  
BEGIN
  -- Lấy username của user hiện tại
  USERNAME := SYS_CONTEXT('USERENV', 'SESSION_USER');
  
  IF USERNAME = 'ADPRO' THEN
    RETURN ''; -- Không áp dụng chính sách nếu người dùng là 'ADPRO'
  END IF;
  
  -- Lấy vai trò của người dùng
  SELECT GRANTED_ROLE INTO USERROLE
  FROM DBA_ROLE_PRIVS
  WHERE GRANTEE = USERNAME;
  
   IF 'RL_TRUONGDV' IN (USERROLE) THEN 
        OPEN GV;  
        LOOP 
            FETCH GV INTO TEMP; 
            EXIT WHEN GV%NOTFOUND;
            IF (MAGV IS NOT NULL) THEN
                MAGV := MAGV || ',' || '''' || TEMP || '''';
            ELSE
                MAGV :=  '''' || TEMP || '''';
            END IF;
        END LOOP;
        CLOSE GV;
        RETURN 'MAGV IN ('||MAGV||')';
    ELSE
        RETURN '';
  END IF;
END;
/
BEGIN
    DBMS_RLS.ADD_POLICY(
        object_schema   => 'ADPRO',
        object_name     => 'PHANCONG',
        policy_name     => 'TruongDV_PhanCong_NhanSu',
        function_schema => 'ADPRO',
        policy_function => 'TDVControl_PhanCong_NhanSu',
        statement_types => 'SELECT',
        update_check    => TRUE
    );
END;
/
--BEGIN
--    DBMS_RLS.DROP_POLICY(
--        object_schema => 'ADPRO',
--        object_name => 'PHANCONG',
--        policy_name => 'TruongDV_PhanCong_NhanSu'
--    );
--END;
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
GRANT SELECT, UPDATE(DIEMTH, DIEMQT, DIEMCK, DIEMTK) ON  ADPRO.QLHS_DANGKY_HPGD TO RL_TRUONGKHOA;

grant select, insert, delete, update on ADPRO.PHANCONG to RL_TRUONGKHOA;
-- grant insert, update , delete on QLHS_PHANCONG_HOCPHAN_VPK
CREATE OR REPLACE FUNCTION ADPRO.TKControl_HP_VPK(
  P_SCHEMA IN VARCHAR2 DEFAULT NULL,
  P_OBJECT IN VARCHAR2 DEFAULT NULL
) RETURN VARCHAR2 AS
    CURSOR HP IS(select MAHP from ADPRO.HOCPHAN where MADV = 'VPK');
    USERNAME VARCHAR2(128);
    USERROLE VARCHAR2(128);
    TEMP varchar2(6);
    MAHP varchar2(2000);
  
BEGIN
  -- Lấy username của user hiện tại
  USERNAME := SYS_CONTEXT('USERENV', 'SESSION_USER');
  
  IF USERNAME = 'ADPRO' THEN
    RETURN ''; -- Không áp dụng chính sách nếu người dùng là 'ADPRO'
  END IF;
  
  -- Lấy vai trò của người dùng
  SELECT GRANTED_ROLE INTO USERROLE
  FROM DBA_ROLE_PRIVS
  WHERE GRANTEE = USERNAME;
  
  IF 'RL_TRUONGKHOA' IN (USERROLE) THEN 
      OPEN HP;  
        LOOP 
            FETCH HP INTO TEMP; 
            EXIT WHEN HP%NOTFOUND;
            IF (MAHP IS NOT NULL) THEN
                MAHP := MAHP || ',' || '''' || TEMP || '''';
            ELSE
                MAHP :=  '''' || TEMP || '''';
            END IF;
        END LOOP;
        CLOSE HP;
        RETURN 'MAHP IN ('||MAHP||')';
    ELSE
        RETURN '';
  END IF;
END;
/
BEGIN
    DBMS_RLS.ADD_POLICY(
        object_schema => 'ADPRO', 
        object_name => 'PHANCONG',
        policy_name => 'TRUONGKHOA_HP_VPK',
        function_schema => 'ADPRO', 
        policy_function => 'TKControl_HP_VPK',
        statement_types => 'INSERT,UPDATE,DELETE',
        update_check => TRUE
    );
END;
/
--grant insert, update, delete on nhansu 
grant select, insert, delete, update on ADPRO.NHANSU to RL_TRUONGKHOA; 
-- Được quyền Xem (không giới hạn) dữ liệu trên toàn bộ lược đồ CSDL.
grant select any table to RL_TRUONGKHOA;

-- CS6: sinh viên
-- sv select chinh mình , update trên cột DCHI, DT
-- grant update(DCHI,DT) on sinhvien
grant select, update(DCHI,DT) on ADPRO.sinhvien to RL_SINHVIEN; 
/
create or replace function ADPRO.SVControl_XEMTTCN (P_SCHEMA VARCHAR2, P_OBJ VARCHAR2) 
return varchar2
as 
    strsql varchar(2000); 
    USERNAME varchar(128);
    USERROLE varchar(128);
begin
    USERNAME := SYS_CONTEXT('USERENV', 'SESSION_USER');
    IF USERNAME = 'ADPRO' THEN
    RETURN ''; -- Không áp dụng chính sách nếu người dùng là 'ADPRO'
    END IF;
    SELECT GRANTED_ROLE INTO USERROLE
    FROM DBA_ROLE_PRIVS
    WHERE GRANTEE = USERNAME;
    IF 'RL_SINHVIEN' IN (USERROLE) THEN 
        strsql:= 'MASV = SYS_CONTEXT(''USERENV'',''SESSION_USER'')';
    END IF;
    return strsql;
end;
/
BEGIN
    DBMS_RLS.ADD_POLICY(
        object_schema => 'ADPRO', 
        object_name => 'SINHVIEN',
        policy_name => 'SINHVIEN_XEMTTCN',
        function_schema => 'ADPRO', 
        policy_function => 'SVControl_XEMTTCN',
        statement_types => 'SELECT, UPDATE',
        update_check => TRUE
    );
END;
/

-- Xem danh sách tất cả học phần (HOCPHAN), kế hoạch mở môn (KHMO) của chương
-- trình Dào tạo mà sinh viên Dang theo học.
grant select on ADPRO.HOCPHAN to RL_SINHVIEN;
grant select on ADPRO.KHMO to RL_SINHVIEN;
/
create or replace function ADPRO.SVControl_XEM_HP (P_SCHEMA VARCHAR2, P_OBJ VARCHAR2) 
RETURN VARCHAR2 AS
    CURSOR HP IS(select KH.MAHP from ADPRO.KHMO KH, ADPRO.SINHVIEN SV 
    where KH.MACT = SV.MACT AND SV.MASV = SYS_CONTEXT('USERENV','SESSION_USER'));
    USERNAME VARCHAR2(128);
    USERROLE VARCHAR2(128);
    TEMP varchar2(6);
    MAHP_DK varchar2(2000);
BEGIN
-- Lấy username của user hiện tại
  -- Lấy username của user hiện tại
  USERNAME := SYS_CONTEXT('USERENV', 'SESSION_USER');
  
  IF USERNAME = 'ADPRO' THEN
    RETURN ''; -- Không áp dụng chính sách nếu người dùng là 'ADPRO'
  END IF;
  
  -- Lấy vai trò của người dùng
  SELECT GRANTED_ROLE INTO USERROLE
  FROM DBA_ROLE_PRIVS
  WHERE GRANTEE = USERNAME;
  IF 'RL_SINHVIEN' IN (USERROLE) THEN 
      OPEN HP;  
        LOOP 
            FETCH HP INTO TEMP; 
            EXIT WHEN HP%NOTFOUND;
            IF (MAHP_DK IS NOT NULL) THEN
                MAHP_DK := MAHP_DK || ',' || '''' || TEMP || '''';
            ELSE
                MAHP_DK :=  '''' || TEMP || '''';
            END IF;
        END LOOP;
        CLOSE HP;
        RETURN 'MAHP IN ('||MAHP_DK||')';
  ELSE
    RETURN '';
  END IF;
END;
/
BEGIN
    DBMS_RLS.ADD_POLICY(
        object_schema => 'ADPRO', 
        object_name => 'HOCPHAN',
        policy_name => 'SINHVIEN_HOCPHAN_CS6',
        function_schema => 'ADPRO', 
        policy_function => 'SVControl_XEM_HP',
        update_check => TRUE
    );
END;
/
BEGIN
    DBMS_RLS.DROP_POLICY(
        object_schema   => 'ADPRO',
        object_name     => 'HOCPHAN',
        policy_name     => 'SINHVIEN_HOCPHAN_CS6'
    );
END;
/
CREATE OR REPLACE FUNCTION ADPRO.SVControl_XEM_KHMO (P_SCHEMA VARCHAR2, P_OBJ VARCHAR2) 
RETURN VARCHAR2 AS
    CURSOR HP IS (SELECT KH.MAHP FROM ADPRO.KHMO KH, ADPRO.SINHVIEN SV 
                   WHERE KH.MACT = SV.MACT AND SV.MASV = SYS_CONTEXT('USERENV','SESSION_USER'));
    USERNAME VARCHAR2(128);
    USERROLE VARCHAR2(128);
    TEMP VARCHAR2(6);
    MAHP_DK VARCHAR2(2000);
BEGIN
  -- Lấy username của user hiện tại
  USERNAME := SYS_CONTEXT('USERENV', 'SESSION_USER');
  
  IF USERNAME = 'ADPRO' THEN
    RETURN ''; -- Không áp dụng chính sách nếu người dùng là 'ADPRO'
  END IF;
  
  -- Lấy vai trò của người dùng
  SELECT GRANTED_ROLE INTO USERROLE
  FROM DBA_ROLE_PRIVS
  WHERE GRANTEE = USERNAME;
  
  IF 'RL_SINHVIEN' = USERROLE THEN 
      OPEN HP;  
        LOOP 
            FETCH HP INTO TEMP; 
            EXIT WHEN HP%NOTFOUND;
            IF (MAHP_DK IS NOT NULL) THEN
                MAHP_DK := MAHP_DK || ',' || '''' || TEMP || '''';
            ELSE
                MAHP_DK :=  '''' || TEMP || '''';
            END IF;
            DBMS_OUTPUT.PUT_LINE(MAHP_DK);
        END LOOP;
        CLOSE HP;
        DBMS_OUTPUT.PUT_LINE(MAHP_DK);
        RETURN 'MAHP IN ('||MAHP_DK||')';
  ELSE
    RETURN '';
  END IF;
END;
/
--create or replace function ADPRO.SVControl_XEM_KHMO (P_SCHEMA VARCHAR2, P_OBJ VARCHAR2) 
--RETURN VARCHAR2 AS
--    CURSOR HP IS(select distinct PC.MAHP from ADPRO.PHANCONG PC, ADPRO.SINHVIEN SV 
--    where PC.MACT = SV.MACT AND SV.MASV = SYS_CONTEXT('USERENV','SESSION_USER'));
--    USERNAME VARCHAR2(128);
--    USERROLE VARCHAR2(128);
--    TEMP varchar2(6);
--    MAHP_DK varchar2(2000);
--BEGIN
--  -- Lấy username của user hiện tại
--  USERNAME := SYS_CONTEXT('USERENV', 'SESSION_USER');
--  
--  IF USERNAME = 'ADPRO' THEN
--    RETURN ''; -- Không áp dụng chính sách nếu người dùng là 'ADPRO'
--  END IF;
--  
--  -- Lấy vai trò của người dùng
--  SELECT GRANTED_ROLE INTO USERROLE
--  FROM DBA_ROLE_PRIVS
--  WHERE GRANTEE = USERNAME;
--  IF 'RL_SINHVIEN' IN (USERROLE) THEN 
--      OPEN HP;  
--        LOOP 
--            FETCH HP INTO TEMP; 
--            EXIT WHEN HP%NOTFOUND;
--            IF (MAHP_DK IS NOT NULL) THEN
--                MAHP_DK := MAHP_DK || ',' || '''' || TEMP || '''';
--            ELSE
--                MAHP_DK :=  '''' || TEMP || '''';
--            END IF;
--        END LOOP;
--        CLOSE HP;
--        RETURN 'MAHP IN ('||MAHP_DK||')';
--  ELSE
--    RETURN '';
--  END IF;
--END;
/
BEGIN
    DBMS_RLS.ADD_POLICY(
        object_schema => 'ADPRO', 
        object_name => 'KHMO', 
        policy_name => 'SINHVIEN_KHMO_CS6',
        function_schema => 'ADPRO',
        policy_function => 'SVControl_XEM_KHMO'
    );
END;
/
--BEGIN
--    DBMS_RLS.DROP_POLICY(
--        object_schema   => 'ADPRO',
--        object_name     => 'KHMO',
--        policy_name     => 'SINHVIEN_KHMO_CS6'
--    );
--END;
-- Thêm, Xóa các dòng dữ liệu Dăng ký học phần (DANGKY) liên quan Dến chính sinh
--viên Dó trong học kỳ của năm học hiện tại (nếu thời Diểm hiệu chỉnh Dăng ký còn hợp
--lệ).
grant select, insert, update, delete on ADPRO.DANGKY to RL_SINHVIEN;
create or replace function ADPRO.SVControl_INSERT_DELETE_DANGKY (P_SCHEMA VARCHAR2, P_OBJ VARCHAR2) 
RETURN VARCHAR2 AS
    v_Semester NUMBER;
    v_Year NUMBER;
    v_SemesterStartDate DATE;
    v_CurrentDate DATE := SYSDATE;
    USERNAME varchar(128);
    USERROLE varchar(128);
BEGIN
      -- Lấy username của user hiện tại
      USERNAME := SYS_CONTEXT('USERENV', 'SESSION_USER');
      
      IF USERNAME = 'ADPRO' THEN
        RETURN ''; -- Không áp dụng chính sách nếu người dùng là 'ADPRO'
      END IF;
      
      -- Lấy vai trò của người dùng
      SELECT GRANTED_ROLE INTO USERROLE
      FROM DBA_ROLE_PRIVS
      WHERE GRANTEE = USERNAME;
    IF 'RL_SINHVIEN' IN (USERROLE) THEN 
        SELECT EXTRACT(MONTH FROM SYSDATE) INTO v_Semester FROM DUAL;
        SELECT EXTRACT(YEAR FROM SYSDATE) INTO v_Year FROM DUAL;
        -- Xác định ngày bắt đầu học kỳ dựa trên tháng hiện tại
        IF v_Semester <= 4 THEN
            v_Semester := 1;
            v_SemesterStartDate := TO_DATE(TO_CHAR(SYSDATE, 'YYYY') || '/01/01', 'YYYY/MM/DD');
        ELSIF v_Semester <= 8 THEN
            v_Semester := 2;
            v_SemesterStartDate := TO_DATE(TO_CHAR(SYSDATE, 'YYYY') || '/05/01', 'YYYY/MM/DD');
        ELSE
            v_Semester := 3;
            v_SemesterStartDate := TO_DATE(TO_CHAR(SYSDATE, 'YYYY') || '/09/01', 'YYYY/MM/DD');
        END IF;

        -- Kiểm tra nếu ngày hiện tại cách ngày bắt đầu học kỳ 14 ngày trở lên
        IF (v_CurrentDate - v_SemesterStartDate) < 14 then
            RETURN 'MASV = ''' || USERNAME || ''' AND HK = '||v_Semester||' AND NAM = ' ||v_Year;
        ELSE 
              RETURN '1=0';
        END IF;
    END IF;
END;
/
BEGIN
    DBMS_RLS.ADD_POLICY(
        object_schema => 'ADPRO', 
        object_name => 'DANGKY',
        policy_name => 'SINHVIEN_DANGKY_INSERT_DELETE_CS6',
        function_schema => 'ADPRO',
        policy_function => 'SVControl_INSERT_DELETE_DANGKY',
        STATEMENT_TYPES=>'DELETE, INSERT', 
        update_check => TRUE
    );
END;
/
--BEGIN
--    DBMS_RLS.DROP_POLICY(
--        object_schema => 'ADPRO',
--        object_name => 'DANGKY',
--        policy_name => 'SINHVIEN_DANGKY_INSERT_DELETE_CS6'
--    );
--END;
--Sinh viên không được chỉnh sửa trên các trường liên quan đến điểm.
create or replace function ADPRO.SVControl_UPDATE_DANGKY (P_SCHEMA VARCHAR2, P_OBJ VARCHAR2) 
RETURN VARCHAR2 AS
    USERNAME VARCHAR2(128);
    USERROLE VARCHAR2(128);
BEGIN
-- Lấy username của user hiện tại
  USERNAME := SYS_CONTEXT('USERENV', 'SESSION_USER');
    IF USERNAME = 'ADPRO' THEN
        RETURN ''; -- Không áp dụng chính sách nếu người dùng là 'ADPRO'
    END IF;
  SELECT GRANTED_ROLE INTO USERROLE
  FROM DBA_ROLE_PRIVS
  WHERE GRANTEE = USERNAME;
  IF 'RL_SINHVIEN' IN (USERROLE) THEN 
    RETURN '1=0';
  ELSE 
    RETURN '1=1';
  END IF;
END;
/
BEGIN
    DBMS_RLS.ADD_POLICY(
        object_schema => 'ADPRO', 
        object_name => 'DANGKY',
        policy_name => 'SINHVIEN_DANGKY_UPDATE_CS6',
        function_schema => 'ADPRO', 
        policy_function => 'SVControl_UPDATE_DANGKY',
        statement_types=>'UPDATE', 
        sec_relevant_cols => 'DIEMTH,DIEMQT,DIEMCK,DIEMTK',
        update_check => TRUE
    );
END;
/
--BEGIN
--    DBMS_RLS.DROP_POLICY(
--        object_schema => 'ADPRO',
--        object_name => 'DANGKY',
--        policy_name => 'SINHVIEN_DANGKY_UPDATE_CS6'
--    );
--END;
-- Sinh viên được Xem tất cả thông tin trên quan hệ ĐANGKY tại các dòng dữ liệu liên
-- quan đến chính sinh viên.
/
BEGIN
    DBMS_RLS.ADD_POLICY(
        object_schema => 'ADPRO', 
        object_name => 'DANGKY',
        policy_name => 'SVControl_SELECT_DANGKY',
        function_schema => 'ADPRO', 
        policy_function => 'SVControl_XEMTTCN',
        statement_types => 'SELECT',
        update_check => TRUE
    );
END;
/
--BEGIN
--    DBMS_RLS.DROP_POLICY(
--        object_schema => 'ADPRO',
--        object_name => 'DANGKY',
--        policy_name => 'SVControl_SELECT_DANGKY'
--    );
--END;
--/

    