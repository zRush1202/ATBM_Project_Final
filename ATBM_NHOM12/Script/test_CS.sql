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
insert into ADPRO.HOCPHAN values('HP004', N'An toan thong tin', 4, 45, 30, 50, 'MMTVT');
insert into ADPRO.HOCPHAN values('HP005', N'Tieng anh co ban', 4, 45, 30, 50, 'CNTT');

insert into ADPRO.KHMO values ('HP001', 1, 2024, 'CT001');
insert into ADPRO.KHMO values ('HP002', 2, 2024, 'CT001');
insert into ADPRO.KHMO values ('HP003', 3, 2024, 'CT002');
insert into ADPRO.KHMO values ('HP004', 1, 2024, 'CT002');
insert into ADPRO.KHMO values ('HP005', 2, 2024, 'CT003');

insert into ADPRO.PHANCONG values('NV2859', 'HP001', 1, 2024, 'CT001');
insert into ADPRO.PHANCONG values('NV2982', 'HP001', 1, 2024, 'CT001');
insert into ADPRO.PHANCONG values('NV3094', 'HP002', 2, 2024, 'CT002');
insert into ADPRO.PHANCONG values('NV3209', 'HP002', 2, 2024, 'CT002');
insert into ADPRO.PHANCONG values('NV3321', 'HP003', 2, 2024, 'CT003');

insert into ADPRO.DANGKY values('SV0001', 'NV2859', 'HP001', 1, 2024, 'CT001', 8.5, 7.0, 8.0, 7.5);
insert into ADPRO.DANGKY values('SV0002', 'NV2982', 'HP001', 1, 2024, 'CT001', 9.0, 8.0, 7.5, 8.3);
insert into ADPRO.DANGKY values('SV0003', 'NV3094', 'HP002', 2, 2024, 'CT002', 7.5, 8.0, 7.0, 7.2);
insert into ADPRO.DANGKY values('SV0007', 'NV3094', 'HP002', 2, 2024, 'CT002', 8.0, 7.5, 8.5, 8.0);
insert into ADPRO.DANGKY values('SV0005', 'NV3321', 'HP003', 2, 2024, 'CT003', 9.0, 9.0, 9.0, 9.0);

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

select * from DBA_TAB_PRIVS where GRANTEE = 'RL_GIAOVU';
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
update ADPRO.PHANCONG set NAM = 2024 where mahp ='HP002' and magv = 'NV2859' ;
select * from phancong;
select * from hocphan;
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

conn NV0204/NV0204@localhost:1521/atbm_projectfinal;
insert into ADPRO.PHANCONG values('NV3799', 'HP002', 2, 2024, 'CT002');

conn NV0204/NV0204@localhost:1521/atbm_projectfinal;
delete from ADPRO.PHANCONG where magv = 'NV3799' and mahp = 'HP002';


select hp.MAHP from ADPRO.HOCPHAN hp, ADPRO.DONVI dv 
    where hp.madv = dv.madv and dv.trgdv = 'NV0204';
select * from adpro.phancong
SELECT *
FROM DBA_POLICIES
WHERE OBJECT_NAME = 'PHANCONG';

SELECT * FROM ALL_TRIGGERS WHERE TABLE_NAME = 'DANGKY';

SELECT GRANTED_ROLE 
    FROM DBA_ROLE_PRIVS
    WHERE GRANTEE = SYS_CONTEXT('USERENV', 'SESSION_USER');
