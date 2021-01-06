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

5. Self Join: A table is joined with itself.
   SELECT c1.first_name, c2.last_name
   FROM customer c1, customer c2
   where c1.first_name != c2.last_name

5. Trigger
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

6. Primary Key

7. Foreign Key

8. Index, Clustered

9. Execution Plan

10. Transaction

