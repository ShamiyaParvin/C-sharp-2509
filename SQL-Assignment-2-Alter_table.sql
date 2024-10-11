--SQL Server assignments focused on using the ALTER TABLE
--command to perform various table modifications.

--Assignment 1: Add a New Column
--Task: Add a column DateOfBirth (data type DATE) to the Employees table to store employees'
--dates of birth.

use CompanyDB;

select * from Employees_2;

alter table Employees_2
add DateOfBirth date;

--Assignment 2: Modify Column Data Type
--Task: Change the data type of the PhoneNumber column in the Customers table to
--VARCHAR(15).

select * from Customers;

alter table Customers
alter column PhoneNumber varchar(15);

--Assignment 3: Add a Primary Key
--Task: Add a primary key to the DepartmentID column in the Departments table.

create table Department (
	DepartmentID int not null);

alter table Department
add constraint pk_DepartmentID primary key (DepartmentID);

--Assignment 4: Drop a Column
--Task: Remove the MiddleName column from the Employees table.

select * from Employees_2;

alter table Employees_2
add MiddleName varchar(50);

alter table Employees_2
drop column MiddleName;

--Assignment 5: Add a Foreign Key
--Task: Add a foreign key to the EmployeeID column in the Orders table that references the
--EmployeeID column in the Employees table.

select * from Employees_2;

create table Orders_ (
	OrdersID int primary key,
	EmployeeID int
); 

insert into Orders_ (OrdersID,EmployeeID)
values
(1,1),
(2,2),
(3,3);

select * from Orders_;

alter table Orders_
add constraint fk_EmployeeID foreign key (EmployeeID) 
references Employees_2(EmployeeID);

--Assignment 6: Drop a Foreign Key
--Task: Remove the foreign key constraint that references EmployeeID from the Orders table.

alter table Orders_
drop constraint fk_EmployeeID;

--Assignment 7: Rename a Column
--Task: Rename the column FullName to EmployeeFullName in the Employees table.

exec sp_rename 'Employees_2.EmployeeName', 'EmployeeFullName', 'column';

select * from Employees_2;

--Assignment 8: Add a Default Value
--Task: Add a default value of 'Active' to the Status column in the Employees table.

alter table Employees_2 
add Status varchar(20);

alter table Employees_2
add constraint df_Status 
default 'Active' for Status;

insert into Employees_2
values ('Riya','IT',100,'2021-09-10','2000-02-09',default);

select * from Employees_2;

--Assignment 9: Drop a Primary Key
--Task: Drop the primary key constraint from the Departments table.

select * from Department;

alter table Department
drop constraint pk_DepartmentID;

--Assignment 10: Add a Unique Constraint
--Task: Ensure the Email column in the Employees table is unique by adding a unique constraint.

create table Employees_new (
	EmployeeID int primary key,
	Employee_Email varchar(100)
	);

insert into Employees_new (EmployeeID,Employee_Email)
values (1,'xyz@gmail.com'),(2,'dfg@hmail.com');

select * from Employees_new;

alter table Employees_new 
add constraint uq_Emplyee_Email unique (Employee_Email);

--Assignment 11: Add a Check Constraint
--Task: Add a check constraint to the Salary column in the Employees table to ensure that no
--salary is less than 1000.

select * from Employees_2;

alter table Employees_2
add constraint ck_Salary check (Salary>=1000);

--Assignment 13: Drop a Check Constraint
--Task: Remove the check constraint from the Salary column in the Employees table.

alter table Employees_2
drop constraint ck_Salary;

