--SQL Server assignments using the GROUP BY and HAVING clauses 

--Assignment 1: 
--Find the Average Salary in Each Department 
--Task: Retrieve the department name and the average salary of employees in each department. 
--Only display departments where the average salary is greater than 50,000. 
--Tables: 

use newdb;

select * from Departments_;
select * from Employees_1;

select d.DepartmentName, avg(e.Salary) as AverageSalary 
from Employees_1 e
inner join Departments_ d 
on e.DepartmentID = d.DepartmentID
group by d.DepartmentName 
having avg(e.Salary)>50000;

--Assignment 2: 
--Count the Number of Employees in Each Department 
--Task: Retrieve the department name and the total number of employees in each department. 
--Only display departments that have more than 5 employees. 
--Tables: 
-- Employees (EmployeeID, EmployeeName, DepartmentID

select * from Departments_;
select * from Employees_1;

select d.DepartmentName, count(e.EmployeeID) as Number_of_Employees, d.DepartmentName
from Employees_1 e
inner join Departments_ d
on e.DepartmentID = d.DepartmentID
group by DepartmentName
having count(e.EmployeeID)>5;

--Assignment 3: 
--Find the Maximum and Minimum Salary in Each Department 
--Task: Retrieve the department name, maximum salary, and minimum salary for each 
--department. Only include departments where the minimum salary is greater than 30,000. 
--Tables: 
-- Employees (EmployeeID, EmployeeName, Salary, DepartmentID)

select * from Employees_1;
select * from Departments_;

select d.DepartmentName, max(e.Salary) as MaximumSalary, min(e.Salary) as MinimumSalary
from Employees_1 e
inner join Departments_ d
on e.DepartmentID = d.DepartmentID
group by DepartmentName
having min(e.Salary)>30000;

--Assignment 4: 
--Find the Total Sales by Each Salesperson 
--Task: Retrieve the employee name and total sales made by each salesperson. Only display 
--salespersons who have made total sales of more than 100,000. 
--Tables: 
-- Sales (SalesID, EmployeeID, Amount)

create table Employees_2 (
    EmployeeID int primary key,
    EmployeeName varchar(50)
);

create table Sales (
    SalesID int primary key,
    EmployeeID int,
    Amount decimal(10, 2),
    foreign key (EmployeeID) references Employees_2(EmployeeID)
);

insert into Employees_2 (EmployeeID, EmployeeName) values
(1, 'Alice'),
(2, 'Bob'),
(3, 'Charlie'),
(4, 'David'),
(5, 'Eve');

insert into Sales (SalesID, EmployeeID, Amount) values
(1, 1, 50000),
(2, 1, 60000),
(3, 2, 30000),
(4, 2, 40000),
(5, 3, 120000),
(6, 3, 50000),
(7, 4, 20000),
(8, 5, 80000),
(9, 5, 30000);

select * from Employees_2;
select * from Sales;

select e.EmployeeName, sum(s.Amount) as TotalSales
from Sales s
inner join Employees_2 e
on s.EmployeeID = e.EmployeeID
group by e.EmployeeName
having sum(s.Amount) > 100000;

--Find the Number of Orders by Each Customer 
--Task: Retrieve the customer name and the total number of orders placed by each customer. Only 
--display customers who have placed more than 3 orders. 
--Tables: 
-- Orders (OrderID, CustomerID)
-- Customers (CustomerID, CustomerName)

create table Customers_1 (
    CustomerID int primary key,
    CustomerName varchar(50)
);

create table Orders_3 (
    OrderID int primary key,
    CustomerID int,
    foreign key (CustomerID) references Customers_1(CustomerID)
);

insert into Customers_1 (CustomerID, CustomerName) values
(1, 'John'),
(2, 'Alice'),
(3, 'Bob'),
(4, 'Charlie'),
(5, 'David');

insert into Orders_3 (OrderID, CustomerID) values
(1, 1),
(2, 1),
(3, 2),
(4, 3),
(5, 1),
(6, 2),
(7, 3),
(8, 3),
(9, 4),
(10, 3),
(11, 5),
(12, 3);

select * from Orders_3;
select * from Customers_1;

select c.CustomerName, count(o.OrderID) as TotalOrders
from Orders_3 o
join Customers_1 c on o.CustomerID = c.CustomerID
group by c.CustomerName
having count(o.OrderID) > 3;

