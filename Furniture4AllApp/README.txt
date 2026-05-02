For admins:
Username: admin
Password: hashed_pass_2

For employees:
Username: jdoe
Password: hashed_pass_1

Progress:
We have completed 10 out of 12 planned screens: Login, Main Dashboard, Register Member, Search/Edit Member, Search Furniture, Rent Furniture (with Receipt), Rental History, Return Furniture (with Receipt), Return History, and Reports (Admin).

Known Issues:
All required features for iteration 3 are functional. Passwords are now stored as SHA256 hashes in the database.

Database Setup:
1. Run DB/Script 1.txt in SQL Server Management Studio to create the Furniture4All database.
2. If your DB was created before hashing was added (password_hash column contains plain text),
   run Script.PostDeployment.sql once to migrate existing passwords to SHA256 hashes.
   Fresh DBs from Script 1.txt already contain hashed passwords - no migration needed.
