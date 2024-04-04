
DROP TABLE ADPRO.ĐANGKY CASCADE CONSTRAINTS;
DROP TABLE ADPRO.PHANCONG CASCADE CONSTRAINTS;
DROP TABLE ADPRO.KHMO CASCADE CONSTRAINTS;
DROP TABLE ADPRO.HOCPHAN CASCADE CONSTRAINTS;
DROP TABLE ADPRO.ĐONVI CASCADE CONSTRAINTS;
DROP TABLE ADPRO.NHANSU CASCADE CONSTRAINTS;
DROP TABLE ADPRO.SINHVIEN CASCADE CONSTRAINTS;


create table NHANSU 
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
create table SINHVIEN
(
    MASV varchar(6),
    HOTEN varchar(30),
    PHAI varchar(3),
    NGSINH date,
    DCHI varchar(50),
    DT char(5),
    MACT varchar(6),
    MANGANH varchar(6),
    SOTCTL int,
    DTBTL float,
    primary key(MASV)
)
/
create table DONVI 
(
    MADV varchar(6), 
    TENDV varchar(50),
    TRGDV varchar(6),
    primary key(MADV) 
)
/
create table HOCPHAN
(
    MAHP varchar(6),
    TENHP varchar(50),
    SOTC int,
    STLT int,
    STTH int,
    SOSVDT int,
    MADV varchar(6),
    primary key(MAHP)
)
/
create table KHMO 
(
    MAHP varchar(6),
    HK int,
    NAM int,
    MACT varchar(6),
    primary key(MAHP, HK, NAM, MACT)
)
/
create table PHANCONG
(
    MAGV varchar(6),
    MAHP varchar(6),
    HK int,
    NAM int,
    MACT varchar(6),
    primary key (MAGV, MAHP, HK, NAM, MACT)
)
/
create table DANGKY
(
    MASV varchar(6),
    MAGV varchar(6),
    MAHP varchar(6),
    HK int,
    NAM int,
    MACT varchar(6),
    DIEMTHI float,
    DIEMQT float,
    DIEMCK float,
    DIEMTK float,
    primary key(MASV, MAGV, MAHP, HK,NAM, MACT)
)
/
-- NhanVien
alter table NHANSU add constraint FK_NHANSU_DONVI foreign key (MADV) references DONVI(MADV);
-- SINHVIEN
-- ĐƠN VỊ
alter table DONVI add constraint FK_DONVI_NHANSU foreign key (TRGDV) references NHANSU(MANV);
-- HỌC PHẦN
alter table HOCPHAN add constraint FK_HOCPHAN_DONVI foreign key (MADV) references DONVI(MADV);
-- KHMO
alter table KHMO add constraint FK_KHMO_HOCPHAN foreign key (MAHP) references HOCPHAN(MAHP);
-- PHANCONG
alter table PHANCONG add constraint FK_PHANCONG_NHANSU foreign key (MAGV) references NHANSU(MANV);
alter table PHANCONG add constraint FK_PHANCONG_HOCPHAN foreign key (MAHP) references HOCPHAN(MAHP);
-- DANGKY
alter table DANGKY add constraint FK_DANGKY_SINHVIEN foreign key (MASV) references SINHVIEN(MASV);
alter table DANGKY add constraint FK_DANGKY_NHANSU foreign key (MAGV) references NHANSU(MANV);
alter table DANGKY add constraint FK_DANGKY_HOCPHAN foreign key (MAHP) references HOCPHAN(MAHP);
