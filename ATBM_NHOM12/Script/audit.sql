alter session set container = atbm_projectfinal;
alter pluggable database open;
SHOW CON_NAME;

-- Run by sys
alter session set "_ORACLE_SCRIPT" = true;
-- End sys

-- Hàm audit Nhân viên
create or replace procedure adpro.usp_audit_nhanvien
	authid current_user
as
	cursor cur is
	select nv.manv
	  from adpro.nhansu nv,
	       all_users als
	 where nv.manv = als.username;
	strsql varchar2(2000);
	usr    varchar2(6);
begin
	open cur;
	loop
		fetch cur into usr;
		exit when cur%notfound;
		strsql := 'GRANT UNLIMITED TABLESPACE TO ' || usr;
		execute immediate strsql;
		strsql := 'AUDIT ALL BY '
		          || usr
		          || ' BY ACCESS';
		execute immediate strsql;
		strsql := 'AUDIT SELECT TABLE, INSERT TABLE, UPDATE TABLE, DELETE TABLE BY '
		          || usr
		          || ' BY ACCESS';
		execute immediate strsql;
		strsql := 'AUDIT SESSION WHENEVER NOT SUCCESSFUL';
		execute immediate strsql;
	end loop;
	close cur;
end;
/

-- Hàm audit Sinh viên
create or replace procedure adpro.usp_audit_sinhvien
	authid current_user
as
	cursor cur is
	(
		select sv.masv
		  from adpro.sinhvien sv,
		       all_users als
		 where sv.masv = als.username
	);
	strsql varchar2(2000);
	usr    varchar2(6);
begin
	open cur;
	loop
		fetch cur into usr;
		exit when cur%notfound;
		strsql := 'GRANT UNLIMITED TABLESPACE TO ' || usr;
		execute immediate strsql;
		strsql := 'AUDIT ALL BY '
		          || usr
		          || ' BY ACCESS';
		execute immediate strsql;
		strsql := 'AUDIT SELECT TABLE, INSERT TABLE, UPDATE TABLE, DELETE TABLE BY '
		          || usr
		          || ' BY ACCESS';
		execute immediate strsql;
		strsql := 'AUDIT SESSION WHENEVER NOT SUCCESSFUL';
		execute immediate strsql;
	end loop;
	close cur;
end;
/

create or replace procedure adpro.usp_drop_audit_nhanvien
	authid current_user
as
	cursor cur is
	select nv.manv
	  from adpro.nhansu nv,
	       all_users als
	 where nv.manv = als.username;
	strsql varchar2(2000);
	usr    varchar2(6);
begin
	open cur;
	loop
		fetch cur into usr;
		exit when cur%notfound;
		strsql := 'REVOKE UNLIMITED TABLESPACE FROM ' || usr;
		execute immediate strsql;
		strsql := 'NOAUDIT ALL BY ' || usr;
		execute immediate strsql;
		strsql := 'NOAUDIT SELECT TABLE, INSERT TABLE, UPDATE TABLE, DELETE TABLE BY ' || usr;
		execute immediate strsql;
		strsql := 'NOAUDIT SESSION WHENEVER NOT SUCCESSFUL';
		execute immediate strsql;
	end loop;
	close cur;
end;
/
create or replace procedure adpro.usp_drop_audit_sinhvien
	authid current_user
as
	cursor cur is
	(
		select sv.masv
		  from adpro.sinhvien sv,
		       all_users als
		 where sv.masv = als.username
	);
	strsql varchar2(2000);
	usr    varchar2(6);
begin
	open cur;
	loop
		fetch cur into usr;
		exit when cur%notfound;
		strsql := 'REVOKE UNLIMITED TABLESPACE FROM ' || usr;
		execute immediate strsql;
		strsql := 'NOAUDIT ALL BY ' || usr;
		execute immediate strsql;
		strsql := 'NOAUDIT SELECT TABLE, INSERT TABLE, UPDATE TABLE, DELETE TABLE BY ' || usr;
		execute immediate strsql;
		strsql := 'NOAUDIT SESSION WHENEVER NOT SUCCESSFUL';
		execute immediate strsql;
	end loop;
	close cur;
end;
/

-- Chạy hàm audit
EXEC ADPRO.USP_AUDIT_NHANVIEN;
EXEC ADPRO.USP_AUDIT_SINHVIEN;
/

EXEC ADPRO.USP_DROP_AUDIT_NHANVIEN;
EXEC ADPRO.USP_DROP_AUDIT_SINHVIEN;
/

-- Grant privileges and audit

select *
  from adpro.nhansu;

-- kiem tra co phai dùng standard ko : DB,extend
select value
  from v$parameter
 where name = 'audit_trail';

select username,
       obj_name,
       action_name,
       to_char(
	       extended_timestamp,'DD/MM/YYYY HH24:MI:SS'
       ) as time,
       sql_text
  from dba_audit_trail
 where owner = 'ADPRO'
 order by extended_timestamp desc;

--Xóa dữ liệu audit
-- BEGIN
-- DBMS_AUDIT_MGMT.CLEAN_AUDIT_TRAIL(
-- audit_trail_type => DBMS_AUDIT_MGMT.AUDIT_TRAIL_UNIFIED,
-- use_last_arch_timestamp => FALSE);
-- END;
alter session set "_ORACLE_SCRIPT" = false;

------------------------------------------------
-- Fine Grained Audit
alter session set "_ORACLE_SCRIPT" = true;
alter session set "_optimizer_filter_pred_pullup" = false; 
-- 3A)

-- Kiểm tra Role của User hiện tại có phải là Giảng viên
create or replace function adpro.check_rl_giangvien return number as
	userrole nvarchar2(30);
begin
	if ( sys_context(
	                'USERENV',
	                'SESSION_USER'
	     ) = 'ADPRO' ) then
		return 0;
	end if;
	select granted_role
	  into userrole
	  from dba_role_privs
	 where grantee = sys_context(
		'USERENV','SESSION_USER'
	);

	if ( userrole = 'RL_GIANGVIEN' ) then
		return 1; -- true
	else
		return 0; -- false
	end if;
end;
/

-- Áp dụng chính sách FGA
begin
	dbms_fga.add_policy(
	                   object_schema   => 'ADPRO',
	                   object_name     => 'DANGKY',
	                   policy_name     => 'fga_policy_diem',
	                   audit_condition => '(ADPRO.CHECK_RL_GIANGVIEN = 0)', -- adjusted condition
	                   audit_column    => 'DIEMTH, DIEMQT, DIEMCK, DIEMTK',
	                   statement_types => 'INSERT,UPDATE,DELETE'
	);
end;
/

begin
	dbms_fga.enable_policy(
	                      object_schema => 'ADPRO',
	                      object_name   => 'DANGKY',
	                      policy_name   => 'fga_policy_diem',
	                      enable        => true
	);
end;

-- begin
-- 	dbms_fga.drop_policy(
-- 	                    object_schema => 'ADPRO',
-- 	                    object_name   => 'DANGKY',
-- 	                    policy_name   => 'fga_policy_diem'
-- 	);
-- end;

-- TEST
select *
  from adpro.dangky;

update adpro.dangky
   set
	diemth = 9.0
 where masv = 'SV0001';

select db_user,
       object_name,
       statement_type,
       sql_text,
       to_char(
	       extended_timestamp,'DD/MM/YYYY HH24:MI:SS'
       ) as time
  from dba_fga_audit_trail
 where policy_name = 'FGA_POLICY_DIEM';

-- grant select,update on dangky to rl_giangvien;
-- revoke select,update on dangky from rl_giangvien;


-- 3B)
begin
	dbms_fga.add_policy(
	                   object_schema   => 'ADPRO',
	                   object_name     => 'NHANSU',
	                   policy_name     => 'fga_policy_phucap',
	                   audit_column    => 'PHUCAP',
	                   statement_types => 'SELECT',
	                   audit_condition => 'MANV <> SYS_CONTEXT(''USERENV'', ''SESSION_USER'')'
	);
end;

begin
	dbms_fga.enable_policy(
	                      object_schema => 'ADPRO',
	                      object_name   => 'NHANSU',
	                      policy_name   => 'fga_policy_phucap',
	                      enable        => true
	);
end;

-- grant select on NHANSU to RL_TRUONGDV;
--revoke select on NHANSU from RL_TRUONGDV;

-- TEST
select db_user,
       object_name,
       statement_type,
       sql_text,
       to_char(
	       extended_timestamp,'DD/MM/YYYY HH24:MI:SS'
       ) as time
  from dba_fga_audit_trail
 where policy_name = 'FGA_POLICY_PHUCAP';

alter session set "_ORACLE_SCRIPT" = false;

select value
  from v$option
 where parameter = 'Unified Auditing';

-- Check Audit status of user
--  SELECT *
-- FROM DBA_PRIV_AUDIT_OPTS
-- WHERE USER_NAME = 'NV1111';