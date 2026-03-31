INSERT INTO Employee (fname, lname, sex, date_of_birth, address, city, state, zip, phone, username, password_hash, is_admin)
VALUES 
('John', 'Doe', 'M', '1985-05-15', '123 Mulbury St', 'Atlanta', 'GA', '62563', '4045554178', 'jdoe', 'hashed_pass_1', 0),
('Admin', 'User', 'F', '1990-01-01', '5257 Main St.', 'Atlanta', 'GA', '54785', '4045554217', 'admin', 'hashed_pass_2', 1)

INSERT INTO Member (fname, lname, sex, date_of_birth, address, city, state, zip, phone)
VALUES 
('Alice', 'Smith', 'F', '1992-03-12', '5321 SQL Ln', 'Nashville', 'TN', '62442', '4045556275'),
('Bob', 'Robert', 'M', '1980-07-22', '312 Apartment Apt', 'Douglasville', 'GA', '63213', '4045555332'),
('Mike', 'Schmidt', 'M', '1995-11-05', '8799 Elm St', 'Jacksonville', 'FL', '52432', '4045551267');