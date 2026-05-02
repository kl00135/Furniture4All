-- =============================================================================
-- Post-deployment script: hash any plain-text passwords in Employee table.
--
-- This is a one-time migration for DBs that were created before password
-- hashing was implemented. It looks for password_hash values that are
-- shorter than 64 characters (SHA256 hex is exactly 64 chars), which means
-- they are still plain text, and converts them to lowercase SHA256 hex.
--
-- Safe to re-run: rows with already-hashed passwords (LEN = 64) are skipped.
--
-- Author: Anu Rayini
-- Version: 5/2/2026
-- =============================================================================

USE Furniture4All;
GO

UPDATE [dbo].[Employee]
SET [password_hash] = LOWER(CONVERT(VARCHAR(64), HASHBYTES('SHA2_256', [password_hash]), 2))
WHERE [password_hash] IS NOT NULL
  AND LEN([password_hash]) < 64;
GO

-- Verify after running:
SELECT username, password_hash, LEN(password_hash) AS hash_length FROM [dbo].[Employee];
GO
