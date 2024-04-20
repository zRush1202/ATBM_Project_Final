DELETE FROM ADPRO.DONVI;
DELETE FROM ADPRO.HOCPHAN;
DELETE FROM ADPRO.KHMO;
DELETE FROM ADPRO.PHANCONG;
--ALTER TABLE ADPRO.DANGKY DISABLE ALL TRIGGERS;
DELETE FROM ADPRO.DANGKY ;
--ALTER TABLE ADPRO.DANGKY ENABLE ALL TRIGGERS;
insert into ADPRO.DONVI values('VPK', N'Van Phong Khoa', 'NV0042');
insert into ADPRO.DONVI values('HTTT', N'He Thong Thong Tin', 'NV0204');
insert into ADPRO.DONVI values('KHMT', N'Khoa Hoc May Tinh', 'NV0266');
insert into ADPRO.DONVI values('CNTT', N'Cong Nghe Thog Tin', 'NV0527');
insert into ADPRO.DONVI values('TGMT', N'Thi Giac May Tinh', 'NV0896');
insert into ADPRO.DONVI values('MMTVT', N'Mang May Tinh va Vien Thong', 'NV1041');

insert into ADPRO.HOCPHAN values('HP001', N'He dieu hanh', 4, 45, 30, 50, 'VPK');
insert into ADPRO.HOCPHAN values('HP002', N'He quan tri', 4, 45, 30, 50, 'HTTT');
insert into ADPRO.HOCPHAN values('HP003', N'Lap trinh python', 4, 45, 30, 50, 'KHMT');
insert into ADPRO.HOCPHAN values('HP004', N'An toan thong tin', 4, 45, 30, 50, 'VPK');
insert into ADPRO.HOCPHAN values('HP005', N'Tieng anh co ban', 4, 45, 30, 50, 'CNTT');

insert into ADPRO.KHMO values ('HP001', 1, 2024, 'CLC');
insert into ADPRO.KHMO values ('HP002', 2, 2024, 'CLC');
insert into ADPRO.KHMO values ('HP003', 3, 2024, 'CQ');
insert into ADPRO.KHMO values ('HP004', 1, 2024, 'CTTT');
insert into ADPRO.KHMO values ('HP005', 2, 2024, 'VP');

insert into ADPRO.PHANCONG values('NV2859', 'HP001', 1, 2024, 'CLC');
insert into ADPRO.PHANCONG values('NV2982', 'HP001', 1, 2024, 'CLC');
insert into ADPRO.PHANCONG values('NV3094', 'HP002', 2, 2024, 'CLC');
insert into ADPRO.PHANCONG values('NV3209', 'HP002', 2, 2024, 'CLC');
insert into ADPRO.PHANCONG values('NV3321', 'HP003', 3, 2024, 'CQ');
insert into ADPRO.PHANCONG values('NV3209', 'HP004', 1, 2024, 'CTTT');
insert into ADPRO.PHANCONG values('NV2982', 'HP005', 2, 2024, 'VP');

update NHANSU set madv = 'HTTT' where manv = 'NV3094';
update NHANSU set madv = 'HTTT' where manv = 'NV3209';

insert into ADPRO.DANGKY values('SV0001', 'NV2859', 'HP001', 1, 2024, 'CLC', 8.5, 7.0, 8.0, 7.5);
insert into ADPRO.DANGKY values('SV0002', 'NV2982', 'HP001', 1, 2024, 'CLC', 9.0, 8.0, 7.5, 8.3);
insert into ADPRO.DANGKY values('SV0003', 'NV3094', 'HP002', 2, 2024, 'CLC', 7.5, 8.0, 7.0, 7.2);
insert into ADPRO.DANGKY values('SV0007', 'NV3094', 'HP002', 2, 2024, 'CLC', 8.0, 7.5, 8.5, 8.0);
insert into ADPRO.DANGKY values('SV0005', 'NV3321', 'HP003', 3, 2024, 'CQ', 9.0, 9.0, 9.0, 9.0);

ALTER SESSION SET CONTAINER= atbm_projectfinal;
ALTER PLUGGABLE DATABASE OPEN;
SHOW CON_NAME; 
-- Test CS1  :NVCOBAN
conn NV2181/NV2181@localhost:1521/atbm_projectfinal;
select * from ADPRO.QLHS_TTCANHAN;

conn NV2181/NV2181@localhost:1521/atbm_projectfinal;
update ADPRO.QLHS_TTCANHAN set DT = '0123456789';

conn NV2181/NV2181@localhost:1521/atbm_projectfinal;
select * from ADPRO.SINHVIEN;
conn NV2181/NV2181@localhost:1521/atbm_projectfinal;
select * from ADPRO.DONVI;
conn NV2181/NV2181@localhost:1521/atbm_projectfinal;
select * from ADPRO.HOCPHAN;
conn NV2181/NV2181@localhost:1521/atbm_projectfinal;
select * from ADPRO.KHMO;

--Test CS2 : GIANGVIEN
conn NV2859/NV2859@localhost:1521/atbm_projectfinal;
select * from ADPRO.QLHS_TTCANHAN;

conn NV2859/NV2859@localhost:1521/atbm_projectfinal;
update ADPRO.QLHS_TTCANHAN set DT = '0123456789';

conn NV2859/NV2859@localhost:1521/atbm_projectfinal;
select * from ADPRO.SINHVIEN;
conn NV2859/NV2859@localhost:1521/atbm_projectfinal;
select * from ADPRO.DONVI;
conn NV2859/NV2859@localhost:1521/atbm_projectfinal;
select * from ADPRO.HOCPHAN;
conn NV2859/NV2859@localhost:1521/atbm_projectfinal;
select * from ADPRO.KHMO;

conn NV2859/NV2859@localhost:1521/atbm_projectfinal;
select * from ADPRO.QLHS_PHANCONG_GD;

conn NV2859/NV2859@localhost:1521/atbm_projectfinal;
select * from ADPRO.QLHS_DANGKY_HPGD;

conn NV2859/NV2859@localhost:1521/atbm_projectfinal;
update ADPRO.QLHS_DANGKY_HPGD set DIEMTH = 7;

-- Test CS3 : GIAOVU

select * from DBA_TAB_PRIVS where GRANTEE = 'RL_TRUONGDV';
select * from DBA_ROLE_PRIVS where GRANTEE = 'NV1110';
conn NV1110/NV1110@localhost:1521/atbm_projectfinal;
select * from ADPRO.QLHS_TTCANHAN;

conn NV1110/NV1110@localhost:1521/atbm_projectfinal;
update ADPRO.QLHS_TTCANHAN set DT = '0123456789';

conn NV1110/NV1110@localhost:1521/atbm_projectfinal;
select * from ADPRO.SINHVIEN;
conn NV1110/NV1110@localhost:1521/atbm_projectfinal;
insert into ADPRO.DONVI values('KTPM', 'Ky Thuat Phan Mem','NV0266');
conn NV1110/NV1110@localhost:1521/atbm_projectfinal;
update ADPRO.HOCPHAN set SOTC = 5 where mahp = 'HP001';
conn NV1110/NV1110@localhost:1521/atbm_projectfinal;
select * from ADPRO.KHMO;

conn NV1110/NV1110@localhost:1521/atbm_projectfinal;
update ADPRO.PHANCONG set NAM = 2024 where mahp ='HP001' and magv = 'NV2859' ;

conn NV1110/NV1110@localhost:1521/atbm_projectfinal;
delete from ADPRO.DANGKY where masv ='SV0001' ;

conn NV1110/NV1110@localhost:1521/atbm_projectfinal;
insert into ADPRO.DANGKY values('SV0001', 'NV3094', 'HP002', 2, 2024, 'CT002', NULL, NULL, NULL, NULL);

conn NV1110/NV1110@localhost:1521/atbm_projectfinal;
delete from ADPRO.DANGKY where masv ='SV0001' and mahp = 'HP002' and hk = 2 and nam = 2024;

conn NV1110/NV1110@localhost:1521/atbm_projectfinal;
select * from DANGKY;

-- CS4 : TRUONGDV NV0204
-- GIANGVIEN
conn NV0204/NV0204@localhost:1521/atbm_projectfinal;
select * from ADPRO.QLHS_TTCANHAN;

conn NV0204/NV0204@localhost:1521/atbm_projectfinal;
update ADPRO.QLHS_TTCANHAN set DT = '0123456789';

conn NV0204/NV0204@localhost:1521/atbm_projectfinal;
select * from ADPRO.SINHVIEN;
conn NV0204/NV0204@localhost:1521/atbm_projectfinal;
select * from ADPRO.DONVI;
conn NV0204/NV0204@localhost:1521/atbm_projectfinal;
select * from ADPRO.HOCPHAN;
conn NV0204/NV0204@localhost:1521/atbm_projectfinal;
select * from ADPRO.KHMO;

conn NV0204/NV0204@localhost:1521/atbm_projectfinal;
select * from ADPRO.QLHS_PHANCONG_GD;

conn NV0204/NV0204@localhost:1521/atbm_projectfinal;
select * from ADPRO.QLHS_DANGKY_HPGD;

conn NV0204/NV0204@localhost:1521/atbm_projectfinal;
update ADPRO.QLHS_DANGKY_HPGD set DIEMTH = 7;
-- TRUONGDV
conn NV0204/NV0204@localhost:1521/atbm_projectfinal;
insert into ADPRO.PHANCONG values('NV3799', 'HP003', 2, 2024, 'CT002');

conn NV0204/NV0204@localhost:1521/atbm_projectfinal;
delete from ADPRO.PHANCONG where magv = 'NV3799' and mahp = 'HP002';

conn NV0204/NV0204@localhost:1521/atbm_projectfinal;
select * from ADPRO.PHANCONG;

-- CS5 : TRUONGKHOA NV0042
conn NV0042/NV0042@localhost:1521/atbm_projectfinal;
select * from ADPRO.QLHS_TTCANHAN;

conn NV0042/NV0042@localhost:1521/atbm_projectfinal;
update ADPRO.QLHS_TTCANHAN set DT = '0123456789';

conn NV0042/NV0042@localhost:1521/atbm_projectfinal;
select * from ADPRO.SINHVIEN;
conn NV0042/NV0042@localhost:1521/atbm_projectfinal;
select * from ADPRO.DONVI;
conn NV0042/NV0042@localhost:1521/atbm_projectfinal;
select * from ADPRO.HOCPHAN;
conn NV0042/NV0042@localhost:1521/atbm_projectfinal;
select * from ADPRO.KHMO;

conn NV0042/NV0042@localhost:1521/atbm_projectfinal;
select * from ADPRO.QLHS_PHANCONG_GD;

conn NV0042/NV0042@localhost:1521/atbm_projectfinal;
select * from ADPRO.QLHS_DANGKY_HPGD;

conn NV0042/NV0042@localhost:1521/atbm_projectfinal;
update ADPRO.QLHS_DANGKY_HPGD set DIEMTH = 7;

conn NV0042/NV0042@localhost:1521/atbm_projectfinal;
insert into ADPRO.PHANCONG values('NV3799', 'HP001', 1, 2024, 'CT002');

conn NV0042/NV0042@localhost:1521/atbm_projectfinal;
update ADPRO.PHANCONG set hk = 1 where magv = 'NV3799' and mahp = 'HP001';

conn NV0042/NV0042@localhost:1521/atbm_projectfinal;
delete from ADPRO.PHANCONG where magv = 'NV3799' and mahp = 'HP001';

conn NV0042/NV0042@localhost:1521/atbm_projectfinal;
select * from ADPRO.NHANSU;

conn NV0042/NV0042@localhost:1521/atbm_projectfinal;
INSERT INTO ADPRO.NHANSU VALUES (N'NV', N'Toni', N'Nu', TO_DATE('1988-02-28' , 'YYYY-MM-DD'), 1533458.253, N'0597684658', NULL, NULL);

conn NV0042/NV0042@localhost:1521/atbm_projectfinal;
update ADPRO.NHANSU set phai = 'Nam' where manv = 'NV';

conn NV0042/NV0042@localhost:1521/atbm_projectfinal;
delete from ADPRO.NHANSU where manv = 'NV';

-- CS6 :SINHVIEN SV0001
conn SV0001/SV0001@localhost:1521/atbm_projectfinal;
select * from ADPRO.SINHVIEN;

conn SV0001/SV0001@localhost:1521/atbm_projectfinal;
update ADPRO.SINHVIEN set dt = '0123456789', dchi = '123 vo thi sau';

conn SV0001/SV0001@localhost:1521/atbm_projectfinal;
select * from ADPRO.HOCPHAN;

conn SV0001/SV0001@localhost:1521/atbm_projectfinal;
select * from ADPRO.KHMO;
-- NV2859
conn SV0001/SV0001@localhost:1521/atbm_projectfinal; 
insert into ADPRO.DANGKY values('SV0001', 'NV2982', 'HP001', 1, 2024, 'CLC', NULL, NULL, NULL, NULL);
select * from ADPRO.DANGKY;

conn SV0001/SV0001@localhost:1521/atbm_projectfinal;
delete from ADPRO.DANGKY where masv = 'SV0001' and magv = 'NV2859' and mahp = 'HP001';

conn SV0001/SV0001@localhost:1521/atbm_projectfinal;
update ADPRO.DANGKY set diemth = 9 where masv = 'SV0001' and magv = 'NV2859' and mahp = 'HP001';

conn SV0001/SV0001@localhost:1521/atbm_projectfinal;
select * from ADPRO.DANGKY;

conn SV0001/SV0001@localhost:1521/atbm_projectfinal;
select * from DBA_TAB_PRIVS 

SELECT table_name FROM user_tables
select hp.MAHP from ADPRO.HOCPHAN hp, ADPRO.DONVI dv 
    where hp.madv = dv.madv and dv.trgdv = 'NV0204'

SELECT *
FROM DBA_POLICIES
WHERE OBJECT_NAME = 'KHMO';


select * from adpro.phancong
SELECT * FROM ALL_TRIGGERS WHERE TABLE_NAME = 'DANGKY';

conn SV0001/SV0001@localhost:1521/atbm_projectfinal;
SELECT GRANTED_ROLE 
    FROM DBA_ROLE_PRIVS
    WHERE GRANTEE = SYS_CONTEXT('USERENV', 'SESSION_USER');
    
select KH.MAHP from ADPRO.KHMO KH, ADPRO.SINHVIEN SV 
    where KH.MACT = SV.MACT AND SV.MASV = 'SV0001';
select distinct PC.MAHP from ADPRO.PHANCONG PC, ADPRO.SINHVIEN SV 
    where PC.MACT = SV.MACT AND SV.MASV = 'SV0001';
SELECT GRANTED_ROLE 
    FROM DBA_ROLE_PRIVS
    WHERE GRANTEE = SYS_CONTEXT('USERENV', 'SESSION_USER');
    
DECLARE
     v_Semester NUMBER;
    v_Year NUMBER;
    v_SemesterStartDate DATE;
    v_CurrentDate DATE := SYSDATE;
    USERNAME varchar(128);
    USERROLE varchar(128);
BEGIN
      -- Lấy username của user hiện tại
      USERNAME := 'SV0001';
    
      
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
            v_SemesterStartDate := TO_DATE(TO_CHAR(SYSDATE, 'YYYY') || '/04/15', 'YYYY/MM/DD');
        ELSIF v_Semester <= 8 THEN
            v_Semester := 2;
            v_SemesterStartDate := TO_DATE(TO_CHAR(SYSDATE, 'YYYY') || '/05/01', 'YYYY/MM/DD');
        ELSE
            v_Semester := 3;
            v_SemesterStartDate := TO_DATE(TO_CHAR(SYSDATE, 'YYYY') || '/09/01', 'YYYY/MM/DD');
        END IF;
        DBMS_OUTPUT.PUT_LINE('hello1');
        -- Kiểm tra nếu ngày hiện tại cách ngày bắt đầu học kỳ 14 ngày trở lên
        IF (v_CurrentDate - v_SemesterStartDate) < 14 then
            DBMS_OUTPUT.PUT_LINE('hello2');
            DBMS_OUTPUT.PUT_LINE( 'MASV = ''' || USERNAME || ''' AND HK = '||v_Semester||' AND NAM = ' ||v_Year);
--        ELSE 
--            RETURN '1=0';
        END IF;
    END IF;
END;

DBMS_OUTPUT.PUT_LINE(SYS_CONTEXT('USERENV', 'ISDBA'));



select s.sid,s.serial#,s.audsid,s.username,s.osuser, s.client_identifier, s.sql_trace,s.action, p.spid, p.TRACEFILE
from v$session s,v$process p
where s.paddr=p.addr
and s.username is not null;
