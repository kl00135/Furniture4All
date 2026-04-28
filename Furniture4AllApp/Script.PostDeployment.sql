UPDATE [dbo].[Employee]
SET [password_hash] = CONVERT(VARCHAR(100), HASHBYTES('SHA2_256', [password_hash]), 2)
WHERE [password_hash] IS NOT NULL 
  AND [password_hash] NOT LIKE '0x%';
GO