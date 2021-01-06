SQL Server:

1. Inner Join: The result set contains records from the left table that match the records from the right table.
   SELECT c.id, c.name, o.order_date
   FROM customer c 
   INNER JOIN order o
   ON c.id = o.customer_id

2. Left Join: The left join returns all rows from the left table and matching rows from the right table.
   SELECT c.id, c.name, o.order_date
   FROM customer c 
   LEFT JOIN order o
   ON c.id = o.customer_id  

3. Right Join: The right join returns all rows from the right table and matching rows from the left table.
   SELECT c.id, c.name, o.order_date
   FROM customer c 
   RIGHT JOIN order o
   ON c.id = o.customer_id

4. Full (Outer) Join: The full join returns all rows from both left and right tables.
   SELECT c.id, c.name, o.order_date
   FROM customer c 
   FULL JOIN order o
   ON c.id = o.customer_id

5. Cross Join: A cross join is used to generate a paired combination of each row of the first 
   table with each row of the second table.
   SELECT * FROM meals
   CROSS JOIN drinks

6. Self Join: A table is joined with itself.
   SELECT c1.first_name, c2.last_name
   FROM customer c1, customer c2
   where c1.first_name != c2.last_name

7. Union: Joins result set of two or more SELECT statements.
   SELECT column_name(s) from table1
   UNION (or UNION ALL)
   SELECT column_name(s) from table2

8. Trigger
   A trigger is a function which fires when an event happens such as a row is inserted, a table structure is changed or user is logged in.
   (a) DDL triggers (for creating, modifying or dropping a table) 
   (b) DML triggers (for insert, update or delete on): 
       FOR or AFTER (insert, update or delete)
       INSTEAD OF (insert, update or delete)

       CREATE TRIGGER trigger_name   
       ON { Table name or view name }   
       [ WITH <Options> ]  
       { FOR | AFTER | INSTEAD OF }   
       { [INSERT], [UPDATE] , [DELETE] }
       AS
       { BEGIN .... END... GO}

9. Primary Key
   The primary key constraint on a column or a group of column ensures the column is unique and cannot be null. A table can have only one
   primary key.

10. Foreign Key
    A foreign key constraint is used to link two tables together. A column with a foreign key constraint in a table 
    refers to a column with primary key in another table.

11. Index:
    An index is an on-disk structure associated with a table or view that speeds retrieval of rows from the table or view.
    An index contains keys built from one or more columns in the table or view. These keys are stored in a structure (B-tree) 
    that enables SQL Server to find the row or rows associated with the key values quickly and efficiently.

12. Clustered index
    - Clustered indexes sort and store the data rows in the table or view based on their key values. These are the columns included 
      in the index definition. There can be only one clustered index per table, because the data rows themselves can be stored in only one order.  
    - The only time the data rows in a table are stored in sorted order is when the table contains a clustered index. When a table
      has a clustered index, the table is called a clustered table. If a table has no clustered index, its data rows are stored in 
      an unordered structure called a heap.

13. Non-clustered index
    - Nonclustered indexes have a structure separate from the data rows. A nonclustered index contains the nonclustered index key values 
      and each key value entry has a pointer to the data row that contains the key value.

14. Execution Plan
    - Every day, out in the various discussion boards devoted to Microsoft SQL Server, the same types of questions come up again and
      again: Why is this query running slow? Is my index getting used? Why isn’t my index getting used? Why does this query run faster 
      than this query?. The correct response is probably different in each case, but in order to arrive at the answer you have to 
      ask the same return question in each case: have you looked at the execution plan? An execution plan, simply put, is the 
      result of the query optimizer’s attempt to calculate the most efficient way to implement the request represented by the 
      T-SQL query you submitted.

15. Transaction
    - A transaction is a single unit of work. If a transaction is successful, all of the data modifications made during the transaction 
      are committed and become a permanent part of the database. If a transaction encounters errors and must be canceled or rolled back, 
      then all of the data modifications are erased.

