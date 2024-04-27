--Kiểm tra:
select value
  from v$option
 where parameter = 'Unified Auditing';

-- STANDARD AUDIT
audit all by nv0204;

-- Run by sys
alter session set "_ORACLE_SCRIPT" = true;
-- End sys

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
		strsql := 'AUDIT SESSION WHENEVER NOT SUCCESSFUL';
		execute immediate strsql;
	end loop;
	close cur;
end;
/

create or replace procedure adpro.usp_audit_sinhvien
	authid current_user
as
	cursor cur is
	select sv.masv
	  from adpro.sinhvien sv,
	       all_users als
	 where sv.masv = als.username;
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
		strsql := 'AUDIT SESSION WHENEVER NOT SUCCESSFUL';
		execute immediate strsql;
	end loop;
	close cur;
end;
/

EXEC ADPRO.USP_AUDIT_NHANVIEN;
EXEC ADPRO.USP_AUDIT_SINHVIEN;


select *
  from dba_audit_trail
 where username = 'NV0042'
 order by timestamp;


select *
  from dba_audit_trail
 where action_name = 'LOGON'
   and returncode != 0;

select *
  from auditable_system_actions
 where name like '%TABLE%';


alter session set "_ORACLE_SCRIPT" = false;

------------------------------------------------
-- Full gained audit

alter session set "_ORACLE_SCRIPT" = true;

alter session set "_ORACLE_SCRIPT" = false;

alter session set "_ORACLE_SCRIPT" = false;