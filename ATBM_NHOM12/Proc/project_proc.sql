CREATE OR REPLACE PROCEDURE SYS.check_user_or_role (p_name IN VARCHAR2, p_result OUT VARCHAR2) AS
  v_user_count NUMBER;
  v_role_count NUMBER;
BEGIN
  SELECT COUNT(*) INTO v_user_count FROM DBA_USERS WHERE USERNAME = UPPER(p_name);
  SELECT COUNT(*) INTO v_role_count FROM DBA_ROLES WHERE ROLE = UPPER(p_name);

  IF v_user_count > 0 THEN
    p_result := 'User';
  ELSIF v_role_count > 0 THEN
    p_result := 'Role';
  ELSE
    p_result := 'CHƯA PHÂN LOẠI';
  END IF;
END;
/
