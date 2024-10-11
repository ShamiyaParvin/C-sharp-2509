--SQL Server assignments that focus on different types of joins (INNER
--JOIN, LEFT JOIN, RIGHT JOIN, FULL OUTER JOIN, CROSS JOIN)

--Assignment 1:
--Retrieve Employees and Their Department Names (INNER JOIN)
--Task: Retrieve the employee names and their corresponding department names.
--Tables:
--? Employees (EmployeeID, EmployeeName, DepartmentID)
--? Departments (DepartmentID, DepartmentName)

use newdb;

create table Departments_ (
    DepartmentID int primary key,
    DepartmentName varchar(100)
);

 create table Employees_1 (
    EmployeeID int primary key,
    EmployeeName varchar(100),
    Salary decimal(10, 2),
    DepartmentID int,
    foreign key (DepartmentID) references Departments_(DepartmentID)
);

insert into Departments_ (DepartmentID, DepartmentName) values
(1, 'HR'),
(2, 'IT'),
(3, 'Finance'),
(4, 'Marketing');

truncate table Employees_1;

insert into Employees_1(EmployeeID, EmployeeName, Salary, DepartmentID) values
(1, 'Alice', 60000, 1),
(2, 'Bob', 70000, 2),
(3, 'Charlie', 4500, 1),
(4, 'David', 80000, 2),
(5, 'Eva', 55000, 3),
(6, 'Frank', 4900, 3),
(7, 'Grace', 72000, 1),
(8, 'Hannah', 51000, null);

select * from Employees_1;
select * from Departments_;

select Employees_1.EmployeeName, Departments.DepartmentName
from Employees_1
inner join Departments
on Employees_1.DepartmentID = Departments.DepartmentID;

--Assignment 2:
--Retrieve All Employees and Their Department Names, Including Those Without
--Departments (LEFT JOIN)
--Task: Retrieve the employee names and their corresponding department names. Include
--employees who are not assigned to any department.
--Tables:
--? Employees (EmployeeID, EmployeeName, DepartmentID)

select * from Employees_1;
select * from Departments_;

select Employees_1.EmployeeName, Departments_.DepartmentName
from Employees_1
left join Departments_
on Employees_1.DepartmentID = Departments_.DepartmentID;

--Assignment 3:
--Retrieve All Departments and the Employees Working in Them (RIGHT JOIN)
--Task: Retrieve all departments and their respective employees. Include departments even if they
--don’t have any employees.
--Tables:
--? Employees (EmployeeID, EmployeeName, DepartmentID)

select * from Employees_1;
select * from Departments_;

select Employees_1.EmployeeName, Departments_.DepartmentName
from Employees_1
right join Departments_
on Employees_1.DepartmentID = Departments_.DepartmentID;

--Assignment 4:
--Retrieve All Employees and Departments, Including Those Without Matches (FULL
--OUTER JOIN)
--Task: Retrieve all employees and all departments, including employees without a department
--and departments without employees.
--Tables:
--? Employees (EmployeeID, EmployeeName, DepartmentID)
--? Departments (DepartmentID, DepartmentName)

select * from Employees_1;
select * from Departments_;

select Employees_1.EmployeeName, Departments_.DepartmentName
from Employees_1
full outer join Departments_
on Employees_1.DepartmentID = Departments_.DepartmentID;

--Assignment 5:
--Retrieve Orders and the Customers Who Placed Them (INNER JOIN)
--Task: Retrieve order IDs and customer names for all orders.
--Tables:
--? Orders (OrderID, CustomerID)

select * from Orders;
select * from Customers;

select Orders.OrderID, Customers.CustomerName
from Orders
inner join Customers
on Orders.CustomerID = Customers.CustomerID;

--Assignment 6: 
--Retrieve Orders and Customers, Including Customers Without Orders (LEFT JOIN) 
--Task: Retrieve all customers and their respective orders. Include customers even if they haven’t 
--placed any orders. 
--Tables: 
--? Orders (OrderID, CustomerID)
--? Customers (CustomerID, CustomerName)

select * from Orders;
select * from Customers;

select c.CustomerID, c.CustomerName, o.OrderID, o.OrderDate
from Customers c
left join Orders o on c.CustomerID = o.CustomerID;

--Assignment 7: 
--Retrieve Products and Their Categories (INNER JOIN) 
--Task: Retrieve product names and their respective category names. 
--Tables: 
--? Products (ProductID, ProductName, CategoryID)
create table Categories (
    CategoryID int primary key,
    CategoryName varchar(100)
);

create table Products_1 (
    ProductID int primary key,
    ProductName varchar(100),
    CategoryID int,
    foreign key (CategoryID) references Categories(CategoryID) on delete cascade
);

insert into Categories (CategoryID, CategoryName) values
(1, 'Electronics'),
(2, 'Furniture'),
(3, 'Clothing');

insert into Products_1 (ProductID, ProductName, CategoryID) values
(1, 'Smartphone', 1),
(2, 'Laptop', 1),
(3, 'Sofa', 2),
(4, 'T-Shirt', 3),
(5, 'Tablet', 1);

select * from Products_1;
select * from Categories;

select p.ProductName, c.CategoryName
from Products_1 p
inner join Categories c on p.CategoryID = c.CategoryID;

--Assignment 8: 
--Retrieve All Categories and Products, Including Categories Without Products (RIGHT 
--JOIN) 
--Task: Retrieve all categories and the products in each category. Include categories that don’t 
--have any products. 
--Tables: 
--? Products (ProductID, ProductName, CategoryID)
--? Categories (CategoryID, CategoryName

select * from Products_1;
select * from Categories;

--insert into Categories (CategoryID, CategoryName) values
--(4, 'plants');

select c.CategoryName, p.ProductName
from Categories c
right join Products_1 p on c.CategoryID = p.CategoryID;

--Assignment 9: 
--Retrieve Employees and Their Managers (Self-Join) 
--Task: Retrieve the employee names and the names of their managers. 
--Tables: 
--? Employees (EmployeeID, EmployeeName, ManagerID)

create table Employees_Manager (
    EmployeeID int primary key,
    EmployeeName varchar(100),
    ManagerID int
);

insert into Employees_Manager(EmployeeID, EmployeeName, ManagerID) values
(1, 'Alice',null),
(2, 'Bob', 1),
(3, 'Charlie', 1),
(4, 'David', 2),
(5, 'Eva', 3);

select * from Employees_Manager;

select e.EmployeeName, m.EmployeeName as Managername
from Employees_Manager e
inner join Employees_Manager m
on e.ManagerID = m.EmployeeID;

--Assignment 10: 
--Get All Possible Combinations of Products and Orders (CROSS JOIN) 
--Task: Retrieve all possible combinations of products and orders (cartesian product). 
--Tables: 
--? Products (ProductID, ProductName)
--? Orders (OrderID)

select * from Products_1;

select * from Orders_2;

SELECT Products_1.ProductID, Products_1.ProductName, Orders_2.OrderID
FROM Products_1
CROSS JOIN Orders_2;


