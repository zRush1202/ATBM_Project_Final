ALTER SESSION SET CONTAINER= atbm_projectfinal;
ALTER PLUGGABLE DATABASE OPEN;
SHOW CON_NAME; 

-- DROP TABLE ADPRO.THONGBAO;

DELETE FROM ADPRO.THONGBAO;

CREATE TABLE ADPRO.THONGBAO (
    ID INT,
    NoiDung NVARCHAR2(500),
    PRIMARY KEY (ID)
);
/

BEGIN
  SA_SYSDBA.CREATE_POLICY(
    policy_name => 'THONGBAO_POLICY', 
    column_name => 'THONGBAO_LABEL'
  );
END;
/

--SELECT *
--FROM DBA_SA_POLICIES
--BEGIN
--  SA_SYSDBA.DROP_POLICY(
--    policy_name => 'THONGBAO_POLICY',
--    drop_column => True
--  );
--END;

EXEC SA_SYSDBA.ENABLE_POLICY ('THONGBAO_POLICY'); 

--SELECT * FROM DBA_SA_LEVELS;
--EXECUTE SA_COMPONENTS.DROP_COMPARTMENT('THONGBAO_POLICY','HTTT'); 
--SELECT * FROM DBA_SA_GROUPS;
--SELECT * FROM DBA_SA_LABELS;

EXECUTE SA_COMPONENTS.CREATE_LEVEL('THONGBAO_POLICY',20,'SV','SINH VIEN');
EXECUTE SA_COMPONENTS.CREATE_LEVEL('THONGBAO_POLICY',40,'NV','NHAN VIEN');
EXECUTE SA_COMPONENTS.CREATE_LEVEL('THONGBAO_POLICY',60,'GVU','GIAO VU');
EXECUTE SA_COMPONENTS.CREATE_LEVEL('THONGBAO_POLICY',80,'GV','GIANG VIEN');
EXECUTE SA_COMPONENTS.CREATE_LEVEL('THONGBAO_POLICY',100,'TDV','TRUONG DON VI');
EXECUTE SA_COMPONENTS.CREATE_LEVEL('THONGBAO_POLICY',120,'TK','TRUONG KHOA');
    
EXECUTE SA_COMPONENTS.CREATE_COMPARTMENT('THONGBAO_POLICY',10,'HTTT','HE THONG THONG TIN');
EXECUTE SA_COMPONENTS.CREATE_COMPARTMENT('THONGBAO_POLICY',30,'CNPM','CONG NGHE PHAN MEM'); 
EXECUTE SA_COMPONENTS.CREATE_COMPARTMENT('THONGBAO_POLICY',50,'KHMT','KHOA HOC MAY TINH'); 
EXECUTE SA_COMPONENTS.CREATE_COMPARTMENT('THONGBAO_POLICY',70,'CNTT','CÔNG NGHE TRI THUC'); 
EXECUTE SA_COMPONENTS.CREATE_COMPARTMENT('THONGBAO_POLICY',90,'TGMT','THI GIAC MAY TINH'); 
EXECUTE SA_COMPONENTS.CREATE_COMPARTMENT('THONGBAO_POLICY',110,'MMT','MANG MAY TINH'); 

EXECUTE SA_COMPONENTS.CREATE_GROUP('THONGBAO_POLICY',300,'CS1','CO SO 1'); 
EXECUTE SA_COMPONENTS.CREATE_GROUP('THONGBAO_POLICY',400,'CS2','CO SO 2');

BEGIN
SA_POLICY_ADMIN.APPLY_TABLE_POLICY(
    POLICY_NAME  => 'THONGBAO_POLICY',
    SCHEMA_NAME  => 'ADPRO',
    TABLE_NAME  => 'THONGBAO',
    TABLE_OPTIONS => 'READ_CONTROL'
);
END;
/

INSERT INTO ADPRO.THONGBAO (ID, NoiDung, THONGBAO_LABEL)
VALUES (1, N'Thông báo cho Trưởng Khoa.', CHAR_TO_LABEL('THONGBAO_POLICY', 'TK'));

INSERT INTO ADPRO.THONGBAO (ID, NoiDung, THONGBAO_LABEL)
VALUES (2, N'Thông báo cho Trưởng Đơn Vị.', CHAR_TO_LABEL('THONGBAO_POLICY', 'TDV'));

INSERT INTO ADPRO.THONGBAO (ID, NoiDung, THONGBAO_LABEL)
VALUES (3, N'Thông báo cho Giảng Viên.', CHAR_TO_LABEL('THONGBAO_POLICY', 'GV'));

INSERT INTO ADPRO.THONGBAO (ID, NoiDung, THONGBAO_LABEL)
VALUES (4, N'Thông báo cho Giáo Vụ.', CHAR_TO_LABEL('THONGBAO_POLICY', 'GVU'));

INSERT INTO ADPRO.THONGBAO (ID, NoiDung, THONGBAO_LABEL)
VALUES (5, N'Thông báo cho Nhân Viên.', CHAR_TO_LABEL('THONGBAO_POLICY', 'NV'));

INSERT INTO ADPRO.THONGBAO (ID, NoiDung, THONGBAO_LABEL)
VALUES (6, N'Thông báo cho Sinh Viên.', CHAR_TO_LABEL('THONGBAO_POLICY', 'SV'));

INSERT INTO ADPRO.THONGBAO (ID, NoiDung, THONGBAO_LABEL)
VALUES (7, N'Thông báo về Hệ Thống Thông Tin.', CHAR_TO_LABEL('THONGBAO_POLICY', 'SV:HTTT'));

INSERT INTO ADPRO.THONGBAO (ID, NoiDung, THONGBAO_LABEL)
VALUES (8, N'Thông báo về Công Nghệ Phần Mềm.', CHAR_TO_LABEL('THONGBAO_POLICY', 'SV:CNPM'));

INSERT INTO ADPRO.THONGBAO (ID, NoiDung, THONGBAO_LABEL)
VALUES (9, N'Thông báo về Khoa Học Máy Tính.', CHAR_TO_LABEL('THONGBAO_POLICY', 'SV:KHMT'));

INSERT INTO ADPRO.THONGBAO (ID, NoiDung, THONGBAO_LABEL)
VALUES (10, N'Thông báo về Công Nghệ Tri Thức.', CHAR_TO_LABEL('THONGBAO_POLICY', 'SV:CNTT'));

INSERT INTO ADPRO.THONGBAO (ID, NoiDung, THONGBAO_LABEL)
VALUES (11, N'Thông báo về Thị Giác Máy Tính.', CHAR_TO_LABEL('THONGBAO_POLICY', 'SV:TGMT'));

INSERT INTO ADPRO.THONGBAO (ID, NoiDung, THONGBAO_LABEL)
VALUES (12, N'Thông báo về Mạng Máy Tính.', CHAR_TO_LABEL('THONGBAO_POLICY', 'SV:MMT'));

INSERT INTO ADPRO.THONGBAO (ID, NoiDung, THONGBAO_LABEL)
VALUES (13, N'Thông báo cho Cơ Sở 1.', CHAR_TO_LABEL('THONGBAO_POLICY', 'SV::CS1'));

INSERT INTO ADPRO.THONGBAO (ID, NoiDung, THONGBAO_LABEL)
VALUES (14, N'Thông báo cho Cơ Sở 2.', CHAR_TO_LABEL('THONGBAO_POLICY', 'SV::CS2'));

INSERT INTO ADPRO.THONGBAO (ID, NoiDung, THONGBAO_LABEL)
VALUES (15, N'Thông báo cho Sinh Viên về Hệ Thống Thông Tin ở Cơ Sở 1', CHAR_TO_LABEL('THONGBAO_POLICY', 'SV:HTTT:CS1'));

INSERT INTO ADPRO.THONGBAO (ID, NoiDung, THONGBAO_LABEL)
VALUES (16, N'Thông báo cho Trưởng Đơn Vị về Khoa Học Máy Tính ở Cơ Sở 2', CHAR_TO_LABEL('THONGBAO_POLICY', 'TDV:KHMT:CS2'));

INSERT INTO ADPRO.THONGBAO (ID, NoiDung, THONGBAO_LABEL)
VALUES (17, N'Thông báo cho Giang Vien cua CNPM', CHAR_TO_LABEL('THONGBAO_POLICY', 'GV:CNPM'));

INSERT INTO ADPRO.THONGBAO (ID, NoiDung, THONGBAO_LABEL)
VALUES (18, N'Thông báo cho Giang Vien cua CNPM ở Co So 1', CHAR_TO_LABEL('THONGBAO_POLICY', 'GV:CNPM:CS1'));

--BEGIN
--SA_POLICY_ADMIN.REMOVE_TABLE_POLICY(
--    POLICY_NAME  => 'THONGBAO_POLICY',
--    SCHEMA_NAME  => 'ADPRO',
--    TABLE_NAME  => 'THONGBAO'
--);
--END;
--/

--BEGIN
--SA_POLICY_ADMIN.APPLY_TABLE_POLICY(
--    POLICY_NAME  => 'THONGBAO_POLICY',
--    SCHEMA_NAME  => 'ADPRO',
--    TABLE_NAME  => 'THONGBAO',
--    TABLE_OPTIONS  => 'READ_CONTROL',
--    predicate => NULL 
--);
--END;
--/

UPDATE ADPRO.THONGBAO
SET NoiDung = NoiDung;
COMMIT;

BEGIN
    SA_USER_ADMIN.SET_USER_PRIVS(
        POLICY_NAME => 'THONGBAO_POLICY',
        USER_NAME => 'ADPRO',
        PRIVILEGES => 'FULL,PROFILE_ACCESS'
    );
END;
/

-- Gán nhãn cho ADPRO để kiểm tra toàn bộ bảng
BEGIN
    SA_USER_ADMIN.SET_USER_LABELS(
    POLICY_NAME  =>'THONGBAO_POLICY',
    USER_NAME  => 'ADPRO',
    MAX_READ_LABEL  => 'TK:HTTT,CNPM,KHMT,CNTT,TGMT,MMT:CS1,CS2'
);
END;
/


-- Gán nhãn để OLS cho user test.
GRANT CONNECT TO NV0266;
GRANT SELECT ON ADPRO.THONGBAO TO NV0266; 

BEGIN
    SA_USER_ADMIN.SET_USER_LABELS(
    POLICY_NAME  =>'THONGBAO_POLICY',
    USER_NAME  => 'NV0266',
    MAX_READ_LABEL  => 'GV:CNPM'
);
END;
/

SELECT * FROM ADPRO.THONGBAO;

SELECT * FROM ALL_SA_LABELS;

--BEGIN
--    SA_LABEL_ADMIN.DROP_LABEL(
--    POLICY_NAME  =>'THONGBAO_POLICY',
--    LABEL_VALUE => 'GV'
--);
--END;
--/


-- a)
-- b)
-- c)
-- d)
-- e)
-- f)
-- g)
-- h)