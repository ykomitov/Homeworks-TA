--Problem 1--
--What is SQL? What is DML? What is DDL? Recite the most important SQL commands.--

--SQL (Structured Query Language) is a standard interactive and 
--programming language for getting information from and updating a 
--database. Although SQL is both an ANSI and an ISO standard, many 
--database products support SQL with proprietary extensions to the 
--standard language. Queries take the form of a command language that 
--lets you select, insert, update, find out the location of data, and so
--forth. There is also a programming interface.

--Problem 2--
--What is Transact-SQL (T-SQL)?

--T-SQL (Transact SQL) is an extension to the standard SQL language.
--T-SQL is the standard language used in MS SQL Server.
--Supports if statements, loops, exceptions.
--Constructions used in the high-level procedural programming languages.
--T-SQL is used for writing stored procedures, functions, triggers, etc.

--Problem 4--
--Write a SQL query to find all information about all departments (use "TelerikAcademy" database).--

	USE TelerikAcademy
	SELECT * FROM Departments

--Problem 5--
--Write a SQL query to find all department names.--

	USE TelerikAcademy
	SELECT Departments.Name FROM Departments

--Problem 6--
--Write a SQL query to find the salary of each employee.

	USE TelerikAcademy
	SELECT FirstName + ' ' + LastName as 'Name', Salary
	FROM Employees

--Problem 7--
--Write a SQL to find the full name of each employee.

	USE TelerikAcademy
	SELECT dbo.Employees.FirstName + ' ' + ISNULL(dbo.Employees.MiddleName,'') + ' ' + dbo.Employees.LastName AS 'Full Name'
	FROM Employees

--Problem 8--
--Write a SQL query to find the email addresses of each employee (by his first and last name). Consider that the mail domain is telerik.com. Emails should look like “John.Doe@telerik.com". The produced column should be named "Full Email Addresses".--

	USE TelerikAcademy
	SELECT dbo.Employees.FirstName + ' ' + ISNULL(dbo.Employees.MiddleName,'') + ' ' + dbo.Employees.LastName AS 'Full Name',
	dbo.Employees.FirstName + '.' + dbo.Employees.LastName + '@telerik.com' AS 'Full Email Addresses'
	FROM Employees

--Problem 9--
--Write a SQL query to find all different employee salaries.--

	USE TelerikAcademy
	SELECT DISTINCT dbo.Employees.Salary AS 'Distinct Salaries'
	FROM Employees
	
--Problem 10--
--Write a SQL query to find all information about the employees whose job title is “Sales Representative“.--

	USE TelerikAcademy
	SELECT *
	FROM Employees
	WHERE JobTitle = 'Sales Representative'

--Problem 11--
--Write a SQL query to find the names of all employees whose first name starts with "SA".--

	USE TelerikAcademy
	SELECT *
	FROM Employees
	WHERE FirstName LIKE 'SA%'

--Problem 12--
--Write a SQL query to find the names of all employees whose last name contains "ei".--

	USE TelerikAcademy
	SELECT *
	FROM Employees
	WHERE LastName LIKE '%EI%'

--Problem 13--
--Write a SQL query to find the salary of all employees whose salary is in the range [20000…30000].--

	USE TelerikAcademy
	SELECT *
	FROM Employees
	WHERE Salary >= 20000 AND Salary <= 30000

--Problem 14--
--Write a SQL query to find the names of all employees whose salary is 25000, 14000, 12500 or 23600.--

	USE TelerikAcademy
	SELECT dbo.Employees.FirstName + ' ' + ISNULL(dbo.Employees.MiddleName,'') + ' ' + dbo.Employees.LastName AS 'Full Name',
	dbo.Employees.Salary
	FROM Employees
	WHERE Salary = 25000 OR Salary = 14000 OR Salary = 12500 OR Salary = 23600
	ORDER BY Salary ASC

--Problem 15--	
--Write a SQL query to find all employees that do not have manager.--

	USE TelerikAcademy
	SELECT *
	FROM Employees
	WHERE ManagerID IS NULL
	
--Problem 16--
--Write a SQL query to find all employees that have salary more than 50000. Order them in decreasing order by salary.--

	USE TelerikAcademy
	SELECT *
	FROM Employees
	WHERE Salary > 50000
	ORDER BY Salary DESC 

--Problem 17--
--Write a SQL query to find the top 5 best paid employees.--

	USE TelerikAcademy
	SELECT TOP 5
	EmployeeID, FirstName, LastName, Salary
	FROM Employees
	ORDER BY Salary DESC

--Problem 18--
--Write a SQL query to find all employees along with their address. Use inner join with ON clause.--

	USE TelerikAcademy
	SELECT
	EmployeeID, FirstName, LastName, Addresses.AddressText
	FROM Employees
	INNER JOIN Addresses
	ON Employees.AddressID = Addresses.AddressID
	
--Problem 19--
--Write a SQL query to find all employees and their address. Use equijoins (conditions in the WHERE clause).--

	USE TelerikAcademy
	SELECT
	e.EmployeeID, e.FirstName + ' ' + e.LastName AS 'Full Name', a.AddressText
	FROM Employees e, Addresses a
	WHERE e.AddressID = a.AddressID

--Problem 20--
--Write a SQL query to find all employees along with their manager.--

	USE TelerikAcademy
	SELECT
	e.EmployeeID, e.FirstName + ' ' + e.LastName AS 'Employee Name', 
	m.FirstName + ' ' + m.LastName AS 'Manager Name'
	FROM Employees e
	INNER JOIN Employees m
	ON e.ManagerID = m.EmployeeID

--Problem 21--
--Write a SQL query to find all employees, along with their manager and their address. Join the 3 tables: Employees e, Employees m and Addresses a.--

	USE TelerikAcademy
	SELECT
	e.FirstName + ' ' + e.LastName AS 'Employee Name',
	a.AddressText,
	m.FirstName + ' ' + m.LastName AS 'Manager Name'
	FROM Employees e
	INNER JOIN Employees m
	ON e.ManagerID = m.EmployeeID
	INNER JOIN Addresses a
	ON e.AddressID = a.AddressID


--Problem 22--
--Write a SQL query to find all departments and all town names as a single list. Use UNION.--

	USE TelerikAcademy
	SELECT
	Departments.Name
	FROM Departments
	UNION
	SELECT Towns.Name
	FROM Towns
	
--Problem 23--
--Write a SQL query to find all the employees and the manager for each of them along with the employees that do not have manager. Use right outer join. Rewrite the query to use left outer join.--

--Using RIGHT OUTER JOIN

	USE TelerikAcademy
	SELECT
	e.FirstName + ' ' + e.LastName AS 'Employee Name',
	m.FirstName + ' ' + m.LastName AS 'Manager Name'
	FROM Employees m RIGHT OUTER JOIN Employees e 
	ON e.ManagerID = m.EmployeeID
	
--Using LEFT OUTER JOIN

	USE TelerikAcademy
	SELECT
	e.FirstName + ' ' + e.LastName AS 'Employee Name',
	m.FirstName + ' ' + m.LastName AS 'Manager Name'
	FROM Employees e LEFT OUTER JOIN Employees m
	ON e.ManagerID = m.EmployeeID

--Problem 24--
--Write a SQL query to find the names of all employees from the departments "Sales" and "Finance" whose hire year is between 1995 and 2005.--

	USE TelerikAcademy
	SELECT
	e.FirstName + ' ' + e.LastName AS 'Employee Name',
	e.HireDate,
	d.Name
	FROM Employees e
	INNER JOIN Departments d
	ON e.DepartmentID = d.DepartmentID
	WHERE d.Name = 'Sales' AND YEAR(e.HireDate) BETWEEN 1995 AND 2005 OR d.Name = 'Finance' AND YEAR(e.HireDate) BETWEEN 1995 AND 2005

