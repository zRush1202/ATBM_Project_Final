
DROP TABLE "SYS"."ĐANGKY" CASCADE CONSTRAINTS;
DROP TABLE "SYS"."PHANCONG" CASCADE CONSTRAINTS;
DROP TABLE "SYS"."KHMO" CASCADE CONSTRAINTS;
DROP TABLE "SYS"."HOCPHAN" CASCADE CONSTRAINTS;
DROP TABLE "SYS"."ĐONVI" CASCADE CONSTRAINTS;

DROP TABLE "SYS"."NHANSU" CASCADE CONSTRAINTS;
DROP TABLE "SYS"."SINHVIEN" CASCADE CONSTRAINTS;
/

create table NHANSU 
(
    MANV varchar(6),
    HOTEN varchar(30),
    PHAi varchar(3),
    NGSINH date,
    PHUCAP float,
    ĐT char(10), --
    VAITRO varchar(30),
    MAĐV varchar(6), --
    primary key(MANV)
)
/
create table SINHVIEN
(
    MASV varchar(6),
    HOTEN varchar(30),
    PHAI varchar(3),
    NGSINH date,
    ĐCHI varchar(50),
    ĐT char(5), -- 
    MACT varchar(6),
    MANGANH varchar(6),
    SOTCTL int,
    ĐTBTL float, --
    primary key(MASV)
)
/
create table ĐONVI 
(
    MAĐV varchar(6), 
    TENĐV varchar(50),
    TRGĐV varchar(6),
    primary key(MAĐV) 
)
/
create table HOCPHAN
(
    MAHP varchar(6),
    TENHP varchar(50),
    SOTC int,
    STLT int,
    STTH int,
    SOSVĐT int,
    MAĐV varchar(6),
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
create table ĐANGKY
(
    MASV varchar(6),
    MAGV varchar(6),
    MAHP varchar(6),
    HK int,
    NAM int,
    MACT varchar(6),
    ĐIEMTHI float,
    ĐIEMQT float,
    ĐIEMCK float,
    ĐIEMTK float,
    primary key(MASV, MAGV, MAHP, HK,NAM, MACT)
)
/
-- NhanVien
alter table NHANSU add constraint FK_NHANSU_DONVI foreign key (MAĐV) references ĐONVI(MAĐV);
-- SINHVIEN
-- ĐƠN VỊ
alter table ĐONVI add constraint FK_ĐONVI_NHANSU foreign key (TRGĐV) references NHANSU(MANV);
-- HỌC PHẦN
alter table HOCPHAN add constraint FK_HOCPHAN_DONVI foreign key (MAĐV) references ĐONVI(MAĐV);
-- KHMO
alter table KHMO add constraint FK_KHMO_HOCPHAN foreign key (MAHP) references HOCPHAN(MAHP);
-- PHANCONG
alter table PHANCONG add constraint FK_PHANCONG_NHANSU foreign key (MAGV) references NHANSU(MANV);
alter table PHANCONG add constraint FK_PHANCONG_HOCPHAN foreign key (MAHP) references HOCPHAN(MAHP);
-- DANGKY
alter table ĐANGKY add constraint FK_ĐANGKY_SINHVIEN foreign key (MASV) references SINHVIEN(MASV);
alter table ĐANGKY add constraint FK_ĐANGKY_NHANSU foreign key (MAGV) references NHANSU(MANV);
alter table ĐANGKY add constraint FK_ĐANGKY_HOCPHAN foreign key (MAHP) references HOCPHAN(MAHP);
