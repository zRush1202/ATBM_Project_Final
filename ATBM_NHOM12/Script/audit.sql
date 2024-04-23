--Kiểm tra:
SELECT value FROM v$option WHERE parameter = 'Unified Auditing';

-- STANDARD AUDIT
AUDIT ALL BY NV0204;