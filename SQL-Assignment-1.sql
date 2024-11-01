- 1) 1. Create a database named CompanyDB.
--    2. Create a table named Employees with the following columns:
--         EmployeeID (Primary Key, INT, Identity)
--         FirstName (VARCHAR(50))
--         LastName (VARCHAR(50))
--         Department (VARCHAR(50))
--         Salary (DECIMAL(10, 2))

create database CompanyDB
use CompanyDB

CREATE TABLE Employees (
    EmployeeID INT IDENTITY(1,1) PRIMARY KEY,
    FirstName VARCHAR(50),
    LastName VARCHAR(50),
    Department VARCHAR(50),
    Salary DECIMAL(10, 2)
);

select * from Employees

-- 2) 1. Insert the following records into the Employees table:
--        John Doe, HR, 50000
--        Jane Smith, IT, 60000
--         David Lee, Marketing, 55000

insert into Employees(FirstName, LastName, Department, Salary)
values ('John','Doe','HR',50000.00);
insert into Employees(FirstName,LastName,Department,Salary)
values ('Jane','Smith','IT',60000.00);
insert into Employees(FirstName,LastName,Department,Salary)
values ('David','Lee','Marketing',55000.00)

select * from Employees

--3) Retrieve the FirstName, LastName, and Salary of employees in the IT department and
--   salary greater than 5000
select * from Employees
where Department='IT' and Salary>5000;

-- highest salary from the employee table
select max(Salary) from Employees;

--4) 1. Update the salary of John Doe to 55000.
--   2. Change the department of Jane Smith to Marketing.

update Employees 
set Salary = 55000
where FirstName = 'John' and LastName = 'Doe';

update Employees
set Department = 'Marketing'
where FirstName = 'Jane' and LastName = 'Smith';

select * from Employees;

--5) 1. Delete the record of David Lee from the Employees table.
-- 	2. Delete all employees in the Marketing department.

delete from Employees
where FirstName='David' and LastName = 'Lee';

delete from Employees
where Department='Marketing';

select * from Employees;

/* 6) 1. Create a tabled named Products and insert below records in the table.
ProductID ProductName Category Price Stock
1 Laptop Electronics 1000 50
2 Mouse Electronics 20 200
3 Keyboard Electronics 30 150
4 Printer Electronics 150 75

2. Select all columns from the Products table
3. Select products, sorted by their price in descending order.
4. Update the price of the "Mouse" to 25.
5. Delete the product with ProductID 2 (Mouse).
6. Select products sorted by ProductName in alphabetical order.
*/

create table Products(
	ProductID int primary key identity (1,1),
	ProductName varchar(200),
	Category varchar(200),
	Price int,
	Stock int
	);

insert into Products(ProductName,Category,Price,Stock)
values 
('Laptop','Electronics',1000,50),
('Mouse','Electronics',20,200),
('Keyboard','Electronics',30,150),
('Printer','Electronics',150,75);

select * from Products;

select * from Products order by Price desc;

update Products
set Price=25 where ProductName='Mouse';

delete from Products
where ProductID = 2;

select * from Products order by ProductName asc;


--7) 1. Create a tabled named Books with the below structure and insert below records in the
--table.

--BookID Title Author PublishedYear AvailableCopies
--1 The Great Gatsby F. Scott Fitzgerald 1925 3
--2 1984 George Orwell 1949 2
--3 To Kill a Mockingbird Harper Lee 1960 5
--4 Brave New World Aldous Huxley 1932 4

--2. Update the available copies of "1984" to 5.
--3. Delete the book with BookID 1 (The Great Gatsby).
--4. Write a query to Select books published after 1950.

create table Books(
	BookID int identity(1,1) primary key,
	Title varchar(200),
	Author varchar(200),
	PublishedYear int,
	availableCopies int
	);

insert into Books(Title, Author, PublishedYear, AvailableCopies)
values
('The Great Gatsby', 'F. Scott Fitzgerald', 1925, 3),
('1984', 'George Orwell', 1949, 2),
('To Kill a Mockingbird', 'Harper Lee', 1960, 5),
('Brave New World', 'Aldous Huxley', 1932, 4);

select * from Books;

update Books 
set AvailableCopies= 5
where PublishedYear= 1984;

delete from Books 
where BookID = 1;

select * from Books
where PublishedYear>1950;

--8) 1. Create a Customers table containing details about customers with the below details.

--CustomerID CustomerName Email PhoneNumber
--201 Alice Johnson alice@example.com 555-1234
--202 Bob Smith bob@example.com 555-5678
--203 Charlie Brown charlie@example.com 555-8765

--2. Insert a new customer into the Customers table with the following details:
--a. CustomerID: 204
--b. CustomerName: David Wilson
--c. Email: david@example.com
--d. PhoneNumber: 555-4321
--3. Update the phone number of "Alice Johnson" to "555-9999".
--BookID Title Author PublishedYear AvailableCopies
--1 The Great Gatsby F. Scott Fitzgerald 1925 3
--2 1984 George Orwell 1949 2
--3 To Kill a Mockingbird Harper Lee 1960 5
--4 Brave New World Aldous Huxley 1932 4

--CustomerID CustomerName Email PhoneNumber
--201 Alice Johnson alice@example.com 555-1234
--202 Bob Smith bob@example.com 555-5678
--203 Charlie Brown charlie@example.com 555-8765

--4. Delete the customer with CustomerID 202 (Bob Smith).

create table Customers(
	CustomerID int identity(201,1) primary key,
	CustomerName varchar(200),
	Email varchar(200),
	PhoneNumber varchar(200)
	);
insert into Customers(CustomerName,Email,PhoneNumber)
values
('Alice Johnson', 'alice@example.com', '555-1234'),
('Bob Smith', 'bob@example.com', '555-5678'),
('Charlie Brown', 'charlie@example.com', '555-8765');

select * from Customers;

insert into Customers(CustomerName, Email, PhoneNumber)
values
(204, 'David Wilson', 'david@example.com', '555-4321');

update Customers
set PhoneNumber = '555-9999'
where CustomerName = 'Alice Johnson';

delete from Customers
where CustomerID=202;

select * from Customers;

--Assignment 9: Orders Management
--Task:
--1. Create an Orders table that contains information about customer orders with the below
--details:
--OrderID CustomerID OrderDate TotalAmount
--301 201 2024-09-01 250.00
--302 202 2024-09-02 150.00
--303 203 2024-09-03 200.00

--2. Insert a new order into the Orders table with the following details:
--a. OrderID: 304
--b. CustomerID: 204
--c. OrderDate: 2024-09-04
--d. TotalAmount: 300.00
--3. Update the TotalAmount for OrderID 301 to 275.00.
--4. Delete the order with OrderID 302.
--5. Select orders with a total amount greater than 200.
--6. Select only the OrderID and TotalAmount for all orders.

create table Orders(
	OrderID int primary key,
	CustomerID int,
	OrderDate date,
	TotalAmount decimal(10,2)
	);
insert into Orders(OrderID, CustomerID, OrderDate, TotalAmount)
values 
(301,201,'2024-09-01', 250.00),
(302,202,'2024-09-02', 150.00),
(303,203,'2024-09-03', 200.00);

insert into Orders(OrderID,CustomerID, OrderDate,TotalAmount)
values (304,204,'2024-09-04', 300.00);

update Orders
set TotalAmount=275.00
where OrderID=301;

delete from Orders 
where OrderID = 302;

select * from Orders
where TotalAmount>200;

select OrderId, TotalAmount from Orders;



--Types of keys
--Assignment 10: Primary Key
--Task:
--Create a Students table with a StudentID as the primary key and include the following columns:
--FirstName, LastName, and Email. Insert three records into the table.
--(1, 'John', 'Doe', 'john.doe@example.com'),
--(2, 'Jane', 'Smith', 'jane.smith@example.com'),
--(3, 'Mike', 'Johnson', 'mike.johnson@example.com');

create table Students (
	StudentID int primary key,
	FirstNAme varchar(100),
	LastName varchar(100),
	Email varchar(200)
	);

insert into Students(StudentID, FirstNAme, LastName,Email)
values
(1, 'John', 'Doe', 'john.doe@example.com'),
(2, 'Jane', 'Smith', 'jane.smith@example.com'),
(3, 'Mike', 'Johnson', 'mike.johnson@example.com');

select * from Students;

--Assignment 11: Foreign Key
--Task:
--Create a Courses table with a CourseID as the primary key. Create a Enrollments table with a
--StudentID as a foreign key referencing the Students table and a CourseID as a foreign key
--referencing the Courses table. Insert sample data into both tables.

create table Courses(
	CourseID int primary key,
	CourseName varchar(100)
);

insert into Courses(CourseID,CourseName)
values
(1,'OS'),
(2,'DSA'),
(3,'Computer Networks');

create table Enrollments (
	EnrollmentID int primary key,
	studentID int,
	foreign key (StudentID) references Students(StudentID),
	CourseID int,
	foreign key (CourseID) references Courses(CourseID)
	);

insert into Enrollments(EnrollmentID,studentID,CourseID)
values
(1,1,1),
(2,2,2),
(3,3,1),
(4,1,3);

select * from Students;

select * from Courses;

select * from Enrollments;

--Assignment 12: Composite Key
--Task:
--Create an OrderDetails table that contains OrderID, ProductID, and Quantity. Define a
--composite primary key using OrderID and ProductID.

create table OrderDetails (
	OrderID int,
	ProductID int,
	Quantity int,
	primary key (OrderID, ProductID)
	);


--Assignment 13: Candidate Key and Alternate Key
--Task:
--Create a Users table with UserID as the primary key, and include Email and Username as
--candidate keys. Set the Email column as a unique key.

CREATE TABLE Users (
    UserID INT PRIMARY KEY,
    Email VARCHAR(100) UNIQUE,
    Username VARCHAR(50),
    -- Candidate Key on Username
    CONSTRAINT UC_Username UNIQUE (Username)
);

--Assignment 14: Surrogate Key
--Task:
--Create a Products table with an AutoID as a surrogate key that automatically increments. Include
--ProductName and Price columns.

create table Products1 (
    AutoID int identity(1,1) primary key,
    ProductName varchar(100),
    Price decimal(10, 2)
	);

--Assignment 15: Natural Key
--Task:
--Create a Employees table that uses SSN (Social Security Number) as a natural key. Include
--columns for FirstName, LastName, and Position.

CREATE TABLE Employees1 (
    SSN CHAR(11) PRIMARY KEY,  -- SSN formatted as "123-45-6789"
    FirstName VARCHAR(50),
    LastName VARCHAR(50),
    Position VARCHAR(50)
);

INSERT INTO Employees1 (SSN, FirstName, LastName, Position) VALUES
('123-45-6789', 'John', 'Doe', 'Software Engineer'),
('987-65-4321', 'Jane', 'Smith', 'Data Analyst'),
('456-78-9123', 'Mike', 'Johnson', 'Project Manager');

--Assignment 16: Unique Key
--Task:
--Create a Customers table with a CustomerID as the primary key and a PhoneNumber column
--that must be unique.

create table Customers1 (
    CustomerID int primary key,    
    PhoneNumber varchar(15) unique
);

insert into Customers1 (CustomerID, PhoneNumber) values
(1, '123-456-7890'),
(2, '987-654-3210'),
(3, '555-555-5555');

select * from Customers1;

--Assignment 17: Basic View Creation
--Task:
--1. Create a simple view named EmployeeView that displays the FirstName, LastName, and
--Department columns from the Employees table.
--2. Query the view to display the details

use CompanyDB;

create view EmployeeView as 
select FirstName, Lastname, Department
from Employees;

select * from EmployeeView;

--Assignment 18: Updating Data Through a View
--Task:
--1. Create a view named EditableEmployeeView that shows EmployeeID, FirstName,
--LastName, and Salary.
--2. Update the salary of an employee using the view.
--3. Verify the update

select * from Employees;

create view EditableEmployeeView as
select EmployeeID, FirstName, LastName, Salary
from Employees;

update EditableEmployeeView
set Salary = 3000
where EmployeeID = 1;

select * from EditableEmployeeView;

--Assignment 19: View with Calculated Columns
--Task:
--1. Create a view named EmployeeSalaryBonusView that displays each employee�s
--FirstName, LastName, Salary, and a calculated column Bonus (10% of the salary).
--2. Query the view

create view EmployeeSalaryBonus as
select FirstName, LastName, Salary, Salary * 0.10 as Bonus
from Employees;

select * from EmployeeSalaryBonus;

--Assignment 20: Altering a View
--Task:
--1. Alter the EmployeeView from Assignment 1 to include a new column Salary.
--2. Verify the view with the updated column.

alter view EmployeeView as
select FirstName, LastName, Department, Salary
from Employees;

select * from EmployeeView;

--Assignment 21: View with Parameters (Simulated via Filters)
--Task:
--1. Create a view named FilteredEmployeeView from employees table that displays
--EmployeeID,FirstName,LastName & Department.
--2. Use a query on the view to return employees in a specific department (e.g.,
--DepartmentID = 2).

create view FilteredEmployeeView as
select EmployeeID, FirstName, LastName, Department
from Employees;

select * from FilteredEmployeeView
where Department = 'HR';

--Assignment 22: Dropping a View

--Task:
--1. Drop the EmployeeView that was created in the previous assignments.
--2. Try to query the view again.

drop view EmployeeView;

select * from EmployeeView;
