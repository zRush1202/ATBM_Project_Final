
DROP TABLE ADPRO.DANGKY CASCADE CONSTRAINTS;
DROP TABLE ADPRO.PHANCONG CASCADE CONSTRAINTS;
DROP TABLE ADPRO.KHMO CASCADE CONSTRAINTS;
DROP TABLE ADPRO.HOCPHAN CASCADE CONSTRAINTS;
DROP TABLE ADPRO.DONVI CASCADE CONSTRAINTS;
DROP TABLE ADPRO.NHANSU CASCADE CONSTRAINTS;
DROP TABLE ADPRO.SINHVIEN CASCADE CONSTRAINTS;


create table ADPRO.NHANSU 
(
    MANV varchar(6),
    HOTEN varchar(30),
    PHAI varchar(3),
    NGSINH date,
    PHUCAP float,
    DT char(10),
    VAITRO varchar(30),
    MADV varchar(6),
    primary key(MANV)
)
/
create table ADPRO.SINHVIEN
(
    MASV varchar(6),
    HOTEN varchar(30),
    PHAI varchar(3),
    NGSINH date,
    DCHI varchar(50),
    DT char(10),
    MACT varchar(6),
    MANGANH varchar(6),
    SOTCTL int,
    DTBTL float,
    primary key(MASV)
)
/
create table ADPRO.DONVI 
(
    MADV varchar(6), 
    TENDV varchar(50),
    TRGDV varchar(6),
    primary key(MADV) 
)
/
create table ADPRO.HOCPHAN
(
    MAHP varchar(6),
    TENHP varchar(50),
    SOTC int,
    STLT int,
    STTH int,
    SOSVTD int,
    MADV varchar(6),
    primary key(MAHP)
)
/
create table ADPRO.KHMO 
(
    MAHP varchar(6),
    HK int,
    NAM int,
    MACT varchar(6),
    primary key(MAHP, HK, NAM, MACT)
)
/
create table ADPRO.PHANCONG
(
    MAGV varchar(6),
    MAHP varchar(6),
    HK int,
    NAM int,
    MACT varchar(6),
    primary key (MAGV, MAHP, HK, NAM, MACT)
)
/
create table ADPRO.DANGKY
(
    MASV varchar(6),
    MAGV varchar(6),
    MAHP varchar(6),
    HK int,
    NAM int,
    MACT varchar(6),
    DIEMTH float,
    DIEMQT float,
    DIEMCK float,
    DIEMTK float,
    primary key(MASV, MAGV, MAHP, HK,NAM, MACT)
)
/
-- NhanVien
alter table ADPRO.NHANSU add constraint FK_NHANSU_DONVI foreign key (MADV) references ADPRO.DONVI(MADV);
-- SINHVIEN
-- ĐƠN VỊ
alter table ADPRO.DONVI add constraint FK_DONVI_NHANSU foreign key (TRGDV) references ADPRO.NHANSU(MANV);
-- HỌC PHẦN
alter table ADPRO.HOCPHAN add constraint FK_HOCPHAN_DONVI foreign key (MADV) references ADPRO.DONVI(MADV);
-- KHMO
alter table ADPRO.KHMO add constraint FK_KHMO_HOCPHAN foreign key (MAHP) references ADPRO.HOCPHAN(MAHP);
-- PHANCONG
alter table ADPRO.PHANCONG add constraint FK_PHANCONG_NHANSU foreign key (MAGV) references ADPRO.NHANSU(MANV);
alter table ADPRO.PHANCONG add constraint FK_PHANCONG_HOCPHAN foreign key (MAHP,HK, NAM, MACT) references ADPRO.KHMO(MAHP, HK, NAM, MACT);

-- DANGKY
alter table ADPRO.DANGKY add constraint FK_DANGKY_SINHVIEN foreign key (MASV) references ADPRO.SINHVIEN(MASV);
alter table ADPRO.DANGKY add constraint FK_DANGKY_NHANSU foreign key (MAGV,MAHP,HK, NAM, MACT) references ADPRO.PHANCONG(MAGV,MAHP,HK, NAM, MACT);
