drop table adpro.dangky cascade constraints;
drop table adpro.phancong cascade constraints;
drop table adpro.khmo cascade constraints;
drop table adpro.hocphan cascade constraints;
drop table adpro.donvi cascade constraints;
drop table adpro.nhansu cascade constraints;
drop table adpro.sinhvien cascade constraints;


create table adpro.nhansu (
	manv   varchar(6),
	hoten  varchar(30),
	phai   varchar(3),
	ngsinh date,
	phucap float,
	dt     char(10),
	vaitro varchar(30),
	madv   varchar(6),
	primary key ( manv )
)
/
create table adpro.sinhvien (
	masv    varchar(6),
	hoten   varchar(30),
	phai    varchar(3),
	ngsinh  date,
	dchi    varchar(50),
	dt      char(10),
	mact    varchar(6),
	manganh varchar(6),
	sotctl  int,
	dtbtl   float,
	primary key ( masv )
)
/
create table adpro.donvi (
	madv  varchar(6),
	tendv varchar(50),
	trgdv varchar(6),
	primary key ( madv )
)
/
create table adpro.hocphan (
	mahp   varchar(6),
	tenhp  varchar(50),
	sotc   int,
	stlt   int,
	stth   int,
	sosvtd int,
	madv   varchar(6),
	primary key ( mahp )
)
/
create table adpro.khmo (
	mahp varchar(6),
	hk   int,
	nam  int,
	mact varchar(6),
	primary key ( mahp,
	              hk,
	              nam,
	              mact )
)
/
create table adpro.phancong (
	magv varchar(6),
	mahp varchar(6),
	hk   int,
	nam  int,
	mact varchar(6),
	primary key ( magv,
	              mahp,
	              hk,
	              nam,
	              mact )
)
/
create table adpro.dangky (
	masv   varchar(6),
	magv   varchar(6),
	mahp   varchar(6),
	hk     int,
	nam    int,
	mact   varchar(6),
	diemth float,
	diemqt float,
	diemck float,
	diemtk float,
	primary key ( masv,
	              magv,
	              mahp,
	              hk,
	              nam,
	              mact )
)
/
-- NhanVien
alter table adpro.nhansu
	add constraint fk_nhansu_donvi foreign key ( madv )
		references adpro.donvi ( madv );
-- SINHVIEN
-- ĐƠN VỊ
alter table adpro.donvi
	add constraint fk_donvi_nhansu foreign key ( trgdv )
		references adpro.nhansu ( manv );
-- HỌC PHẦN
alter table adpro.hocphan
	add constraint fk_hocphan_donvi foreign key ( madv )
		references adpro.donvi ( madv );
-- KHMO
alter table adpro.khmo
	add constraint fk_khmo_hocphan foreign key ( mahp )
		references adpro.hocphan ( mahp );
-- PHANCONG
alter table adpro.phancong
	add constraint fk_phancong_nhansu foreign key ( magv )
		references adpro.nhansu ( manv );
alter table adpro.phancong
	add constraint fk_phancong_hocphan foreign key ( mahp,
	                                                 hk,
	                                                 nam,
	                                                 mact )
		references adpro.khmo ( mahp,
		                        hk,
		                        nam,
		                        mact );

-- DANGKY
alter table adpro.dangky
	add constraint fk_dangky_sinhvien foreign key ( masv )
		references adpro.sinhvien ( masv );
alter table adpro.dangky
	add constraint fk_dangky_nhansu foreign key ( magv,
	                                              mahp,
	                                              hk,
	                                              nam,
	                                              mact )
		references adpro.phancong ( magv,
		                            mahp,
		                            hk,
		                            nam,
		                            mact );