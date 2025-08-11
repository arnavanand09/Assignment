create database db18
use db18
-- 1. Student Table
CREATE TABLE Student (
    Rn INT PRIMARY KEY,
    Name VARCHAR(100),
    Address VARCHAR(255),
    Marks INT,
    DOB DATE
);

-- 2. Batch Table
CREATE TABLE Batch (
    BatchCode INT PRIMARY KEY,
    Name VARCHAR(100),
    Duration INT,  -- duration in weeks or months
    Description VARCHAR(255)
);

-- 3. Fees Table
CREATE TABLE Fees (
    Rn INT,
    Fees_Paid DECIMAL(10,2),
    Date_Paid DATE,
    FOREIGN KEY (Rn) REFERENCES Student(Rn)
);

-- 4. Trainer Table
CREATE TABLE Trainer (
    TrainerID INT PRIMARY KEY,
    TrainerName VARCHAR(100),
    Address VARCHAR(255),
    Qualification VARCHAR(100),
    Experience INT,
    Domain VARCHAR(100)
);

-- 5. Student-Batch 
CREATE TABLE StudentBatch (
    Rn INT,
    BatchCode INT,
    FOREIGN KEY (Rn) REFERENCES Student(Rn),
    FOREIGN KEY (BatchCode) REFERENCES Batch(BatchCode)
);

-- 6. Batch-Trainer 
CREATE TABLE BatchTrainer (
    BatchCode INT,
    TrainerID INT,
    FOREIGN KEY (BatchCode) REFERENCES Batch(BatchCode),
    FOREIGN KEY (TrainerID) REFERENCES Trainer(TrainerID)
);

INSERT INTO Student (Rn, Name, Address, Marks, DOB)
VALUES
(1, 'Rahul Sharma', 'Delhi', 85, '2003-05-14'),
(2, 'Anjali Verma', 'Mumbai', 78, '2002-11-20'),
(3, 'Karan Mehta', 'Bangalore', 92, '2003-02-08');

INSERT INTO Batch (BatchCode, Name, Duration, Description)
VALUES
(101, 'Python Basics', 3, 'Introduction to Python programming'),
(102, 'Web Development', 4, 'HTML, CSS, JS, and React'),
(103, 'Data Science', 5, 'Data analysis using Python and ML basics');

INSERT INTO Fees (Rn, Fees_Paid, Date_Paid)
VALUES
(1, 5000.00, '2025-07-01'),
(2, 4500.00, '2025-07-03'),
(3, 7000.00, '2025-07-05');

INSERT INTO Trainer (TrainerID, TrainerName, Address, Qualification, Experience, Domain)
VALUES
(1, 'Ravi Kumar', 'Chennai', 'M.Tech', 6, 'Python'),
(2, 'Sneha Nair', 'Hyderabad', 'MCA', 4, 'Web Development'),
(3, 'Amit Desai', 'Pune', 'Ph.D', 8, 'Data Science');

INSERT INTO StudentBatch (Rn, BatchCode)
VALUES
(1, 101),
(2, 102),
(3, 103);

INSERT INTO BatchTrainer (BatchCode, TrainerID)
VALUES
(101, 1),
(102, 2),
(103, 3);

SELECT * FROM Student;

SELECT * FROM Batch;

SELECT * FROM Fees;

SELECT * FROM Trainer;

SELECT * FROM StudentBatch;

SELECT * FROM BatchTrainer;

--1
SELECT * FROM Student;
SELECT 
    s.Name AS StudentName,
    s.Address AS StudentAddress,
    b.BatchCode,
    b.Name AS BatchName,
    t.TrainerName AS FacultyName,
    b.Duration
FROM Student s
JOIN StudentBatch sb ON s.Rn = sb.Rn
JOIN Batch b ON sb.BatchCode = b.BatchCode
JOIN BatchTrainer bt ON b.BatchCode = bt.BatchCode
JOIN Trainer t ON bt.TrainerID = t.TrainerID;
--2
SELECT 
    s.Name AS StudentName,
    f.Fees_Paid,
    f.Date_Paid
FROM Student s
JOIN Fees f ON s.Rn = f.Rn;
--3
SELECT 
    b.BatchCode,
    b.Name AS BatchName,
    t.TrainerID,
    t.TrainerName,
    t.Address,
    t.Qualification,
    t.Experience,
    t.Domain
FROM Batch b
JOIN BatchTrainer bt ON b.BatchCode = bt.BatchCode
JOIN Trainer t ON bt.TrainerID = t.TrainerID;


