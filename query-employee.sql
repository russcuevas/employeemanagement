CREATE DATABASE employeemanagement;

use employeemanagement

CREATE TABLE tbl_admin (
    admin_id INT IDENTITY(1,1) PRIMARY KEY,
    username VARCHAR(50) NOT NULL,
    password VARCHAR(255) NOT NULL,
    name VARCHAR(100) NOT NULL,
    age INT,
    email VARCHAR(100),
    number VARCHAR(20),
    position VARCHAR(50)
);


CREATE TABLE tbl_employees (
    employees_id INT IDENTITY(1,1) PRIMARY KEY,
    username VARCHAR(50) NOT NULL,
    password VARCHAR(255) NOT NULL,         
    name VARCHAR(100) NOT NULL,
	status VARCHAR (50),
    age INT,
    email VARCHAR(100),
    number VARCHAR(20),
    position VARCHAR(50)
);

CREATE TABLE tbl_reports (
    reports_id INT IDENTITY(1,1) PRIMARY KEY, 
    employees_id INT,                 
    issue TEXT NOT NULL,     
    status VARCHAR(50) NOT NULL,          
    CONSTRAINT FK_reports_employees FOREIGN KEY (employees_id) 
    REFERENCES tbl_employees (employees_id)
);



CREATE TABLE tbl_tasks (
    tasks_id INT IDENTITY(1,1) PRIMARY KEY,   
    employees_id INT,                         
    tasks_name VARCHAR(255) NOT NULL,
    tasks_date DATETIME NOT NULL,               
    FOREIGN KEY (employees_id) REFERENCES tbl_employees (employees_id) 
    ON DELETE CASCADE                          
);


CREATE TABLE tbl_tasks_status (
    status_id INT IDENTITY(1,1) PRIMARY KEY,   
    tasks_id INT,                              
    status VARCHAR(50) CHECK (status IN ('On working', 'Incomplete', 'Completed')),  
    date_completed DATETIME NULL, 
    FOREIGN KEY (tasks_id) REFERENCES tbl_tasks (tasks_id)
    ON DELETE CASCADE
);

-- Inserting an admin
INSERT INTO tbl_admin (username, password, name, age, email, number, position)
VALUES ('Server', '123', 'Server Admin', 22, 'serveradmin@gmail.com', '1234567890', 'Administrator');

-- Inserting an employee
INSERT INTO tbl_employees (username, password, name, age, email, status, number, position)
VALUES ('Client', '123', 'Client Employee', 23, 'employee@gmail.com', 'New', '1234567890', 'Employee');


-- Get all employees and their tasks:
SELECT e.name AS EmployeeName, t.tasks_name AS TaskName, t.tasks_date
FROM tbl_employees e
INNER JOIN tbl_tasks t ON e.employees_id = t.employees_id;

-- Get the status of a specific task:
SELECT ts.status, ts.date_completed
FROM tbl_tasks_status ts
INNER JOIN tbl_tasks t ON ts.tasks_id = t.tasks_id
WHERE t.tasks_id = 1;

-- Get all tasks for a specific employee:
SELECT t.tasks_name, ts.status, ts.date_completed
FROM tbl_tasks t
INNER JOIN tbl_tasks_status ts ON t.tasks_id = ts.tasks_id
WHERE t.employees_id = 1;

-- Get all tasks for a specific employee:
SELECT 
    e.name AS EmployeeName,
    e.position AS EmployeePosition,
    t.tasks_name AS TaskName,
    t.tasks_date AS TaskDate,
    ts.status AS TaskStatus,
    ts.date_completed AS DateCompleted
FROM 
    tbl_tasks t
INNER JOIN 
    tbl_employees e ON t.employees_id = e.employees_id
INNER JOIN 
    tbl_tasks_status ts ON t.tasks_id = ts.tasks_id
ORDER BY 
    t.tasks_date DESC;


