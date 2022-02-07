--inner join
--Returns records that have matching values in both tables
SELECT Orders.OrderID, Customers.CustomerName
FROM Orders
INNER JOIN Customers ON Orders.CustomerID = Customers.CustomerID;

--outer join
--left, right, full 
SELECT column_name(s)
FROM table1
FULL OUTER JOIN table2
ON table1.column_name = table2.column_name
WHERE condition;

--left(outer) join
--Returns all records from the left table, and the matched records from the right table
SELECT column_name(s)
FROM table1
LEFT JOIN table2
ON table1.column_name = table2.column_name;

--right(outer) join
--Returns all records from the right table, and the matched records from the left table
SELECT column_name(s)
FROM table1
RIGHT JOIN table2
ON table1.column_name = table2.column_name;

--full outer join
--Returns all records when there is a match in either left or right table
SELECT column_name(s)
FROM table1
FULL OUTER JOIN table2
ON table1.column_name = table2.column_name
WHERE condition;

--create view
--In SQL, a view is a virtual table based on the result-set of an SQL statement. A view 
--contains rows and columns, just like a real table. The fields in a view are fields 
--from one or more real tables in the database. You can add SQL statements and functions
-- to a view and present the data as if the data were coming from one single table.
--A view is created with the CREATE VIEW statement.
CREATE VIEW view_name AS
SELECT column1, column2, ...
FROM table_name
WHERE condition;