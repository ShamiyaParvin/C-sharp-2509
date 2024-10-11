--SQL Server assignments involving subqueries.

use CompanyDB;

--Assignment 1:
--Task: Retrieve the names and salaries of employees whose salary is greater than the average
--salary of all employees in the company.
--Tables:
--Employees (EmployeeID, EmployeeName, Salary)

select * from Employees_2;

select avg(Salary) from Employees_2;

select EmployeeID, EmployeeFullName, Salary from Employees_2
where Salary > (select avg(Salary) from Employees_2);

--Assignment 2:
--Task: Retrieve the department names that have more than 5 employees.
--Tables:
--? Employees (EmployeeID, EmployeeName, DepartmentID)

create table Employees_ (
    EmployeeID int primary key,
    EmployeeName varchar(50),
    DepartmentID int
);


insert into Employees_(EmployeeID, EmployeeName, DepartmentID) values
(1, 'alice', 101),
(2, 'bob', 102),
(3, 'charlie', 101),
(4, 'david', 101),
(5, 'eva', 103),
(6, 'alice', 102),
(7, 'grace', 101),
(8, 'riya', 103),
(9, 'ivan', 101),
(10, 'judy', 104),
(11, 'kyle', 101),
(12, 'leo', 102);

select * from Employees_;

select distinct DepartmentID
from Employees_ 
where DepartmentID in(
	select DepartmentID
	from Employees_
	group by DepartmentID
	having count(DepartmentID) > 5);

--Assignment 3:
--Retrieve Products with a Price Higher Than the Maximum Price of Category 'A'
--Task: Retrieve the product names and prices of products that have a price higher than the
--maximum price of products in category 'A'.
--Tables:

--? Products (ProductID, ProductName, Price, CategoryID)

select * from Products_1;

select ProductName, Price from Products_1
where Price > (select max(Price) from Products_1 where CategoryID = 2);

--Assignment 4:
--Retrieve Employees Who Work in Departments with Average Salary Higher Than 50,000
--Task: Retrieve the names of employees who work in departments where the average salary is
--higher than 50,000.
--Tables:
--? Employees (EmployeeID, EmployeeName, Salary, DepartmentID)
--? Departments (DepartmentID, DepartmentName)

create database newdb;
use newdb;

create table Departments (
    DepartmentID int primary key,
    DepartmentName varchar(100)
);

 create table Employees (
    EmployeeID int primary key,
    EmployeeName varchar(100),
    Salary decimal(10, 2),
    DepartmentID int,
    foreign key (DepartmentID) references Departments(DepartmentID)
);

insert into Departments (DepartmentID, DepartmentName) values
(1, 'HR'),
(2, 'IT'),
(3, 'Finance'),
(4, 'Marketing');

insert into Employees (EmployeeID, EmployeeName, Salary, DepartmentID) values
(1, 'Alice', 60000, 1),
(2, 'Bob', 70000, 2),
(3, 'Charlie', 4500, 1),
(4, 'David', 80000, 2),
(5, 'Eva', 55000, 3),
(6, 'Frank', 4900, 3),
(7, 'Grace', 72000, 4),
(8, 'Hannah', 51000, 1);

select * from Employees;
select * from Departments;

select EmployeeName from Employees
where DepartmentID in (
	select DepartmentID
	from Employees
	group by DepartmentID
	having avg(Salary)>50000);

--Assignment 5:
--Find Employees Who Earn More Than Their Department's Average Salary
--Task: Retrieve the names of employees who earn more than the average salary of their
--department.
--Tables:
--? Employees (EmployeeID, EmployeeName, Salary, DepartmentID)

select * from Employees;

select EmployeeName
from Employees
where Salary > (
	select avg(Salary)
	from Employees
	where DepartmentID = Employees.DepartmentID);

--Assignment 6:
--Find Customers Who Have Not Placed Any Orders
--Task: Retrieve the names of customers who have not placed any orders.
--Tables:
--? Customers (CustomerID, CustomerName)

create table Customers(
	CustomerID int primary key,
    CustomerName varchar(100)
);

create table Orders (
    OrderID int primary key,
    CustomerID int,
    OrderDate datetime,
    foreign key (CustomerID) references Customers(CustomerID)
);

insert into Customers(CustomerID, CustomerName) values
(1, 'alice'),
(2, 'bob'),
(3, 'charlie'),
(4, 'david'),
(5, 'eva');

insert into Orders (OrderID, CustomerID, OrderDate) values
(1, 1, '2024-01-01'),
(2, 1, '2024-01-05'),
(3, 2, '2024-01-03');

select * from Customers;

select * from Orders;

select CustomerName 
from Customers
where CustomerID not in (select CustomerID from Orders);

--Assignment 8:

--Find Products That Have Never Been Ordered
--Task: Retrieve the names of products that have never been ordered.
--Tables:
--? Products (ProductID, ProductName)
--? OrderDetails (OrderID, ProductID)

create table Products (
    ProductID int primary key,
    ProductName varchar(100)
);

create table Orders_2 (
    OrderID int,
    ProductID int,
    foreign key (ProductID) references Products(ProductID)
);

insert into Products (ProductID, ProductName) values
(101, 'A'),
(102, 'B'),
(103, 'C'),
(104, 'D'),
(105, 'E');

insert into Orders_2(OrderID, ProductID) values
(1, 101),
(2, 102),
(3, 101),
(4, 103);

select * from Products;
select * from Orders_2;

select ProductName 
from Products
where ProductID not in (
	select ProductID from Orders_2);

