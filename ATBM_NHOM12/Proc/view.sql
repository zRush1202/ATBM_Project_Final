-- CS1: Nhân viên cơ bản
create or replace view QLHS_TTCANHAN
as
    select * from NHANSU where MANV = SYS_CONTEXT('USERENV','SESSION_USER');
-- Grant update on view
-- Grant select on sinh vien, don vi, hoc phan, khmo

-- CS2 : Giảng viên
-- view QLHS_TTCANHAN
-- grant select on QLHS_PHANCONG_GD
-- grant select on QLHS_DANGKY_HPGD
create or replace view QLHS_PHANCONG_GD
as
    select * from PHANCONG where MAGV = SYS_CONTEXT('USERENV','SESSION_USER');

create or replace view QLHS_DANGKY_HPGD
as
    select * from ĐANGKY where MAGV = SYS_CONTEXT('USERENV','SESSION_USER');
-- grant update on dangky(diemth,diemqt, diemck,diemtk)

--CS3 : giao vu
-- view QLHS_TTCANHAN
-- grant update select insert on sinh vien, donvi, hocphan, khmo
-- grant select on phancong
-- grant select phan cong, grnat update on QLHS_PHANCONG_HOCPHAN_VPK
create or replace view QLHS_PHANCONG_HOCPHAN_VPK
as
    select pc.* from PHANCONG pc, HOCPHAN hp where pc.mađv = hp.mađv and hp.MAĐV = 'VPK';
    
CREATE OR REPLACE TRIGGER check_ThoiHan_HieuChinh
BEFORE INSERT OR DELETE ON ĐANGKY
FOR EACH ROW
DECLARE
    start_date DATE;
BEGIN
    SELECT NGBATDAU INTO start_date FROM KHMO
    WHERE MAHP = :NEW.MAHP AND HK = :NEW.HK AND NAM = :NEW.NAM;
    
    IF SYSDATE > start_date + 14 THEN
        RAISE_APPLICATION_ERROR(-20001, 'Không thể hiệu chỉnh học phần vì đã quá thời hạn 14 ngày!');
    END IF;
END;
/
-- CS4 : TRưởng đơn vị
-- view QLHS_TTCANHAN
-- grant select on QLHS_PHANCONG_GD
-- grant select on QLHS_DANGKY_HPGD
-- grant update on dangky(diemth,diemqt, diemck,diemtk)

-- grant insert , delete, update on QLHS_PHANCONG_TRGDV
create or replace view QLHS_PHANCONG_HP_TRGDV
as
    select pc.* from PHANCONG pc, HOCPHAN hp, ĐONVI dv 
    where  pc.mahp = hp.mahp and hp.mađv = dv.mađv and dv.trgđv = SYS_CONTEXT('USERENV','SESSION_USER');
-- grant select on QLHS_PHANCONG_GV_DV
create or replace view QLHS_PHANCONG_GV_DV
as
    select pk.* from PHANCONG pc, đonvi dv
    where pc.mađv = dv.mađv and dv.trgđv = SYS_CONTEXT('USERENV','SESSION_USER');
-- CS5: Trưởng khoa
-- view QLHS_TTCANHAN
-- grant select on QLHS_PHANCONG_GD
-- grant select on QLHS_DANGKY_HPGD
-- grant update on dangky(diemth,diemqt, diemck,diemtk)

-- grant insert, update , delete on QLHS_PHANCONG_HOCPHAN_VPK

--grant insert, update, delete on nhansu 

-- grant select on sinhvien, donvi, hocphan, kmon, dangky
    