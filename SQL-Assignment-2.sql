-Assignment 1: Sales Database
--Scenario:
--You are given a Sales table containing sales data for various products. The table structure is as
--follows:
--SaleID ProductID ProductName QuantitySold SaleAmount SaleDate
--1 101 Laptop 5 5000 2024-09-01
--2 102 Mouse 10 250 2024-09-02
--3 101 Laptop 3 3000 2024-09-03
--4 103 Keyboard 8 800 2024-09-04
--5 102 Mouse 6 150 2024-09-05

use CompanyDB;

create table Sales(
	SaleId int identity(1,1) primary key,
	ProductId int,
	ProductName varchar(100),
	QuantitySold int,
	SaleAmount int,
	SaleDate date
	);

insert into Sales(ProductId,ProductName,QuantitySold,SaleAmount,SaleDate)
values
(101, 'Laptop', 5, 5000, '2024-09-01'),
(102, 'Mouse', 10, 250, '2024-09-02'),
(101, 'Laptop', 3, 3000, '2024-09-03'),
(103, 'Keyboard', 8, 800, '2024-09-04'),
(102, 'Mouse', 6, 150, '2024-09-05');

select * from Sales;

--Task:
--1. Write a query to calculate the total sales amount for all products (SUM).

select sum(SaleAmount) as TotalSalesAmount
from Sales;

--2. Write a query to find the maximum quantity sold of any product (MAX).

select max(QuantitySold) as MaximumQuantitySold
from Sales;

--3. Write a query to calculate the average sale amount per sale (AVG).

select avg(SaleAmount) as AverageSaleAmount
from Sales;

--4. Write a query to find the minimum sale amount in the database (MIN).

select min(SaleAmount) as MinimumSaleAmount
from Sales;

--5. Write a query to calculate the total quantity sold of a specific product, say "Laptop"
--(SUM with WHERE clause).

select sum(QuantitySold) as TotalQuantitySold 
from Sales
where ProductName = 'Laptop';

--Assignment 2: Employee Salaries
--Scenario:

--You are given an Employees table with salary details. The table structure is as follows:
--EmployeeID EmployeeName Department Salary HireDate
--1 John Doe IT 5000 2022-01-10
--2 Jane Smith HR 6000 2021-03-15
--3 Bob Johnson Finance 5500 2020-06-20
--4 Alice Brown IT 6200 2023-02-01
--5 Charlie White Marketing 4800 2023-03-10

create table Employees_2(
	EmployeeID int identity(1,1) primary key,
	EmployeeName varchar(100),
	Department varchar(100),
	Salary int,
	HireDate date
	);

INSERT INTO Employees_2 (EmployeeName, Department, Salary, HireDate) VALUES
('John Doe', 'IT', 5000, '2022-01-10'),
('Jane Smith', 'HR', 6000, '2021-03-15'),
('Bob Johnson', 'Finance', 5500, '2020-06-20'),
('Alice Brown', 'IT', 6200, '2023-02-01'),
('Charlie White', 'Marketing', 4800, '2023-03-10');

select * from Employees_2;

--1. Write a query to find the total salary expenditure for all employees (SUM).

select sum(Salary) as TotalSalary
from Employees_2;

--2. Write a query to find the highest salary among all employees (MAX).

select max(Salary) as HighestSalary
from Employees_2;

--3. Write a query to calculate the average salary across all employees (AVG).

select avg(Salary) as AverageSalary
from Employees_2;

--4. Write a query to find the minimum salary in the IT department (MIN with WHERE
--clause).

select min(Salary) as MinimumSalaryinIT
from Employees_2 
where Department = 'IT';

--5. Write a query to find the total number of employees in each department (COUNT and
--GROUP BY).

select Department,count(EmployeeID) as TotalEmployees
from Employees_2
group by Department;

--Assignment 3: Inventory Management
--Scenario:
--You are given an Inventory table with information about the stock levels of different products.
--The table structure is as follows:
--ProductID ProductName QuantityInStock ReorderLevel LastRestockDate
--201 Monitor 50 10 2024-08-25
--202 Printer 30 5 2024-09-01
--203 Mouse 100 15 2024-09-10
--204 Keyboard 80 20 2024-09-15
--205 Laptop 25 5 2024-09-20

create table Inventory (
	ProductID int identity(201,1) primary key,
	Productname varchar(100),
	QuantityInStock int,
	ReorderLevel int,
	LastRestockDate date
	);

insert into Inventory (Productname, QuantityInStock, ReorderLevel, LastRestockDate)
values
('Monitor', 50, 10, '2024-08-25'),
('Printer', 30, 5, '2024-09-01'),
('Mouse', 100, 15, '2024-09-10'),
('Keyboard', 80, 20, '2024-09-15'),
('Laptop', 25, 5, '2024-09-20'); 

select * from Inventory;

--1. Write a query to find the total quantity of products in stock (SUM).

select sum(QuantityInStock) as TotalQuantity
from Inventory;

--2. Write a query to find the product with the highest quantity in stock (MAX).

select Productname, QuantityInStock from Inventory
where QuantityInStock = (select max(QuantityInStock) from Inventory);

--3. Write a query to find the average reorder level across all products (AVG).

select avg(ReorderLevel) as AverageReorderLevel
from Inventory;

--4. Write a query to find the product with the lowest reorder level (MIN).

select Productname, ReorderLevel
from Inventory
where ReorderLevel = (select min(ReorderLevel) from Inventory);

-- 5. Write a query to find the total quantity in stock for products where the quantity is
-- less than the reorder level (SUM with WHERE clause).

select sum(QuantityInStock) as TotalQuantity
from Inventory
where QuantityInStock < ReorderLevel;

--Assignment 4: Customer Orders Database
--Scenario:
--You have a CustomerOrders table that contains details about customer orders. The structure of
--the table is as follows:
--OrderID CustomerID OrderDate OrderAmount QuantityOrdered
--501 C001 2024-09-10 1500 3
--502 C002 2024-09-11 2000 5
--503 C001 2024-09-12 1000 2
--504 C003 2024-09-13 2500 4
--505 C002 2024-09-14 3000 6

create table Orders_2 (
    OrderID INT primary key,
    CustomerID varchar(10),
    OrderDate date,
    OrderAmount int,
    QuantityOrdered int
);

insert into Orders_2 (OrderID, CustomerID, OrderDate, OrderAmount, QuantityOrdered)
values
(501, 'C001', '2024-09-10', 1500, 3),
(502, 'C002', '2024-09-11', 2000, 5),
(503, 'C001', '2024-09-12', 1000, 2),
(504, 'C003', '2024-09-13', 2500, 4),
(505, 'C002', '2024-09-14', 3000, 6);

select * from Orders_2;

--1. Write a query to calculate the total order amount for all orders (SUM).

select sum(OrderAmount) as TotalOrderAmount
from Orders_2;

--2. Write a query to find the average order amount for all customers (AVG).

select avg(OrderAmount) as AverageOrderAmount
from Orders_2;

--3. Write a query to find the maximum order amount from a single order (MAX).

select max(OrderAmount) as MaximumOrderAmount
from Orders_2;

--4. Write a query to find the total quantity ordered across all orders (SUM).

select sum(QuantityOrdered) as TotalQuantityOrdered
from Orders_2;

--5. Write a query to find the minimum order amount in the database (MIN).

select min(OrderAmount) as MinimumOrderAmount
from Orders_2;

--Assignment 6: Product Ratings Database
--Scenario:
--You have a ProductRatings table containing customer ratings for various products. The
--structure is as follows:
--RatingID ProductID CustomerID Rating ReviewDate
--1 P001 C001 4 2024-09-01
--2 P002 C002 5 2024-09-02

--RatingID ProductID CustomerID Rating ReviewDate
--3 P001 C003 3 2024-09-03
--4 P003 C001 2 2024-09-04
--5 P002 C004 4 2024-09-05

create table Ratings (
    RatingID int identity(1,1) primary key,
    ProductID varchar(10),
    CustomerID varchar(10),
    Rating decimal(10,2),
    ReviewDate date
);

insert into Ratings (ProductID, CustomerID, Rating, ReviewDate) values
('P001', 'C001', 4, '2024-09-01'),
('P002', 'C002', 5, '2024-09-02'),
('P001', 'C003', 3, '2024-09-03'),
('P003', 'C001', 2, '2024-09-04'),
('P002', 'C004', 4, '2024-09-05');

select * from Ratings;

--1. Write a query to calculate the average rating for each product (AVG with GROUP BY).

select ProductID, avg(Rating) as AverageRating
from Ratings 
group by ProductID;

--2. Write a query to find the highest rating given to any product (MAX).

select max(Rating) as HighestRating
from Ratings;

--3. Write a query to find the lowest rating given to any product (MIN).

select min(Rating) as LowestRating
from Ratings;

--4. Write a query to find the total number of ratings for each product (COUNT and GROUP BY).

select ProductID, count(Rating) as TotalRatings
from Ratings
group by ProductID;

--5. Write a query to find the total number of products rated (COUNT with DISTINCT).

select count(distinct ProductID) as Total_Products_Rated
from Ratings;


--SQL Server assignments and solutions using various SQL operators such as IN,
--BETWEEN, LIKE, AND, OR, NOT, etc.

--Assignment 1:
--Retrieve Employees Who Work in Specific Departments Using IN Operator
--Task: Retrieve the names of employees who work in either the 'HR', 'Finance', or 'IT'
--departments.
--Tables:
--? Employees (EmployeeID, EmployeeName, DepartmentID)

select * from Employees_2;

select EmployeeID,EmployeeName,Department from Employees_2
where Department in ('HR','Finance','IT');

--Assignment 2:
--Retrieve Products Within a Specific Price Range Using BETWEEN Operator
--Task: Retrieve the product names and prices of products that are priced between 100 and 500.
--Tables:
--? Products (ProductID, ProductName, Price)

select * from Products;

select ProductID, ProductName, Price from Products
where Price between 100 and 500;

--Assignment 3:
--Find Customers Whose Name Starts With 'A' Using LIKE Operator
--Task: Retrieve the customer names that start with the letter 'A'.
--Tables:
--? Customers (CustomerID, CustomerName)

select * from Customers;

select CustomerID, CustomerName from Customers
where CustomerName like 'A%';

--Assignment 4:
--Retrieve Orders Placed on Specific Dates Using IN Operator
--Task: Retrieve the order IDs of orders placed on '2023-01-01', '2023-02-01', and '2023-03-01'.
--Tables:
--? Orders (OrderID, OrderDate)

select * from Orders_2;

select OrderID, OrderDate from Orders_2
where OrderDate in ('2023-01-01', '2023-02-01', '2023-03-01');

--Assignment 5:
--Retrieve Products That Are Not Priced Between 100 and 500 Using NOT BETWEEN
--Operator
--Task: Retrieve the product names and prices of products that are not priced between 100 and
--500.
--Tables:
--? Products (ProductID, ProductName, Price)

select * from Products;

select ProductID, ProductName, Price from Products
where Price not between 100 and 500;

--Assignment 6:
--Find Orders Where the Total Amount is More Than 5000 or Less Than 1000 Using OR
--Operator
--Task: Retrieve the order IDs where the total amount is either greater than 5000 or less than 1000.
--Tables:

select * from Orders_2;

select OrderID, OrderAmount
from Orders_2
where OrderAmount > 5000 or OrderAmount <1000;

--Assignment 7:
--Retrieve Employees Who Do Not Work in the 'HR' or 'IT' Departments Using NOT IN
--Operator

--Task: Retrieve the names of employees who do not work in the 'HR' or 'IT' departments.
--Tables:
--? Employees (EmployeeID, EmployeeName, DepartmentID)

select EmployeeID, EmployeeName, Department from Employees_2 
where Department not in ('HR','IT');

--Assignment 8:
--Retrieve Orders Placed in 2023 Using BETWEEN and AND Operators
--Task: Retrieve the order IDs of orders placed between '2023-01-01' and '2023-12-31'.
--Tables:
--? Orders (OrderID, OrderDate)

select * from Orders_2;

select OrderID, OrderDate from Orders_2
where OrderDate between '2023-01-01' and '2023-12-31' ;

--Assignment 9:
--Find Customers Who Do Not Have 'John' in Their Name Using NOT LIKE Operator
--Task: Retrieve the customer names that do not have 'John' in them.
--Tables:
--? Customers (CustomerID, CustomerName)

select * from Customers;

select CustomerID, CustomerName from Customers
where CustomerName not like '%John%';

--Assignment 10:
--Retrieve Products That Are Either in Category 'A' or Priced Below 100 Using IN and OR
--Operators
--Task: Retrieve the product names and prices of products that are either in category 'A' or have a
--price less than 100.
--Tables:
--? Products (ProductID, ProductName, Price, CategoryID)
--? Categories (CategoryID, CategoryName)
--These assignments cover various SQL operators to filter data, using IN, BETWEEN, LIKE,
--NOT, and combining logical operators like AND/OR



create table Category (
	CategoryID int primary key,
	Categories varchar(10)
	);

insert into Category (CategoryID,Categories)
values 
(1,'A'),
(2,'B'),
(3,'C');

create table Products_1 (
	ProductID int primary key,
	ProductName varchar(100),
	Price int,
	CategoryID int,
	foreign key (CategoryID) references Category(CategoryID)
	);

insert into Products_1 (ProductID, ProductName, Price, CategoryID)
values
(101, 'Product1', 150, 1),
(102, 'Product2', 80, 2),
(103, 'Product3', 200, 1),
(104, 'Product4', 50, 3),
(105, 'Product5', 90, 1);

select * from Category;

select * from Products_1

select ProductName, Price 
from Products_1
where CategoryId in (select CategoryID from Category where Categories = 'A')
or Price < 100;
