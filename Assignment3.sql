Create database EmployeeManagement;

use EmployeeManagement;

Create table Project (project_number numeric(5) primary key identity,
						proj_name varchar(50) not null,
						startdate date not null  
						);

Create table Department (dept_number numeric(5) primary key identity(100,1),
						dept_name varchar(50) not null
						);

Create table Employee (emp_id numeric(10) primary key identity(1000,1),
						title varchar(20) not null,
						first_name varchar(20) not null,
						last_name varchar(20) not null,
						gender varchar(10) not null,
						DOB date not null,
						Hired_date date not null,
						dept_number numeric(5) references Department(dept_number) on delete cascade ,
						project_number numeric(5) references Project(project_number) on delete cascade
						);