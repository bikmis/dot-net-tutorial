SQL Server:

1. Inner Join
2. Left Join
3. Right Join
4. Full Join
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

