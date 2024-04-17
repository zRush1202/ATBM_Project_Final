ALTER SESSION SET CONTAINER= atbm_projectfinal;
ALTER PLUGGABLE DATABASE OPEN;
SHOW CON_NAME; 
/
-- Test CS1
grant connect to RL_NVCOBAN;
create user NV2181 identified by 123;
grant RL_NVCOBAN to NV2181;
select * from DBA_TAB_PRIVS where GRANTEE = 'RL_NVCOBAN';

conn NV2181/123@localhost:1521/atbm_projectfinal;
select * from ADPRO.QLHS_TTCANHAN;

conn NV2181/123@localhost:1521/atbm_projectfinal;
show con_name;
update ADPRO.QLHS_TTCANHAN set DT = '0123456789';

select * from DBA_USERS;
conn NV2181/123;
show con_name;

conn NV2181/123@localhost:1521/atbm_projectfinal;
conn NV2181/123;
select * from ADPRO.SINHVIEN;
select * from ADPRO.SINHVIEN;
select * from ADPRO.DONVI;
select * from ADPRO.HOCPHAN;
select * from ADPRO.KHMO;
