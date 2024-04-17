DELETE FROM DONVI;
DELETE FROM HOCPHAN;
DELETE FROM KHMO;
DELETE FROM PHANCONG;
DELETE FROM DANGKY;


insert into DONVI values('VPK', N'Van Phong Khoa', 'NV0069');
insert into DONVI values('HTTT', N'He Thong Thong Tin', 'NV0204');
insert into DONVI values('KHMT', N'Khoa Hoc May Tinh', 'NV0266');
insert into DONVI values('CNTT', N'Cong Nghe Thog Tin', 'NV0527');
insert into DONVI values('TGMT', N'Thi Giac May Tinh', 'NV0896');
insert into DONVI values('MMTVT', N'Mang May Tinh va Vien Thong', 'NV1041');

insert into HOCPHAN values('HP001', N'He dieu hanh', 4, 45, 30, 50, 'CNTT');
insert into HOCPHAN values('HP002', N'He quan tri', 4, 45, 30, 50, 'HTTT');
insert into HOCPHAN values('HP003', N'Lap trinh python', 4, 45, 30, 50, 'KHMT');
insert into HOCPHAN values('HP004', N'An toan thong tin', 4, 45, 30, 50, 'MMTVT');
insert into HOCPHAN values('HP005', N'Tieng anh co ban', 4, 45, 30, 50, 'CNTT');

insert into KHMO values ('HP001', 1, 2024, 'CT001');
insert into KHMO values ('HP002', 2, 2024, 'CT001');
insert into KHMO values ('HP003', 3, 2024, 'CT002');
insert into KHMO values ('HP004', 1, 2024, 'CT002');
insert into KHMO values ('HP005', 2, 2024, 'CT003');

insert into PHANCONG values('NV2859', 'HP001', 1, 2024, 'CT001');
insert into PHANCONG values('NV2982', 'HP001', 1, 2024, 'CT001');
insert into PHANCONG values('NV3094', 'HP002', 1, 2024, 'CT002');
insert into PHANCONG values('NV3209', 'HP002', 1, 2024, 'CT002');
insert into PHANCONG values('NV3321', 'HP003', 2, 2024, 'CT003');

insert into DANGKY values('SV0001', 'NV2859', 'HP001', 1, 2024, 'CT001', 8.5, 7.0, 8.0, 7.5);
insert into DANGKY values('SV0002', 'NV2982', 'HP001', 1, 2024, 'CT001', 9.0, 8.0, 7.5, 8.3);
insert into DANGKY values('SV0003', 'NV3094', 'HP002', 1, 2024, 'CT002', 7.5, 8.0, 7.0, 7.2);
insert into DANGKY values('SV0007', 'NV3094', 'HP002', 1, 2024, 'CT002', 8.0, 7.5, 8.5, 8.0);
insert into DANGKY values('SV0005', 'NV3321', 'HP003', 2, 2024, 'CT003', 9.0, 9.0, 9.0, 9.0);

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
