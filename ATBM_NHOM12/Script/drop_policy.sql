--drop role rl_nvcoban;
--drop role rl_giangvien;
--drop role rl_giaovu;
--drop role rl_truongdv;
--drop role rl_truongkhoa;
--drop role rl_sinhvien;
begin
	dbms_rls.drop_policy(
	                    object_schema => 'ADPRO',
	                    object_name   => 'PHANCONG',
	                    policy_name   => 'GIAOVU_PHANCONG_CS3'
	);
end;
/
begin
	dbms_rls.drop_policy(
	                    object_schema => 'ADPRO',
	                    object_name   => 'PHANCONG',
	                    policy_name   => 'TruongDV_PhanCong_HocPhan'
	);
end;
/
begin
	dbms_rls.drop_policy(
	                    object_schema => 'ADPRO',
	                    object_name   => 'NHANSU',
	                    policy_name   => 'TruongDV_NhanSu_DonVi'
	);
end;
/
begin
	dbms_rls.drop_policy(
	                    object_schema => 'ADPRO',
	                    object_name   => 'PHANCONG',
	                    policy_name   => 'TruongDV_PhanCong_NhanSu'
	);
end;
/
begin
	dbms_rls.drop_policy(
	                    object_schema => 'ADPRO',
	                    object_name   => 'HOCPHAN',
	                    policy_name   => 'SINHVIEN_HOCPHAN_CS6'
	);
end;
/
begin
	dbms_rls.drop_policy(
	                    object_schema => 'ADPRO',
	                    object_name   => 'KHMO',
	                    policy_name   => 'SINHVIEN_KHMO_CS6'
	);
end;
/
begin
	dbms_rls.drop_policy(
	                    object_schema => 'ADPRO',
	                    object_name   => 'DANGKY',
	                    policy_name   => 'SINHVIEN_DANGKY_INSERT_DELETE_CS6'
	);
end;
/
begin
	dbms_rls.drop_policy(
	                    object_schema => 'ADPRO',
	                    object_name   => 'DANGKY',
	                    policy_name   => 'SINHVIEN_DANGKY_UPDATE_CS6'
	);
end;
/
begin
	dbms_rls.drop_policy(
	                    object_schema => 'ADPRO',
	                    object_name   => 'DANGKY',
	                    policy_name   => 'SVControl_SELECT_DANGKY'
	);
end;
begin
	dbms_rls.drop_policy(
	                    object_schema => 'ADPRO',
	                    object_name   => 'PHANCONG',
	                    policy_name   => 'TRUONGKHOA_HP_VPK'
	);
end;
/
begin
	dbms_rls.drop_policy(
	                    object_schema => 'ADPRO',
	                    object_name   => 'SINHVIEN',
	                    policy_name   => 'SINHVIEN_XEMTTCN'
	);
end;