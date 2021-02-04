ADO.NET

- ADO stands for Active Data Object

- Provides two types of architecture (1) Connected Architecture (2) Disconnected Architecture

- Connection pooling is the ability of reusing your connection to the database.

- DataReader and DataSet: 
    DataReader - holds only one table, used in connected architecture, better performance, read-only access, 
    DataSet - used in a disconnected architecture, lower performance, read/write access, 

- SqlCommand: three methods
    - ExecuteScalar: returns a single value from the database using select statement
    - ExecuteNonQuery: for insert, update, delete and return number of rows impacted by the operation
    - ExecuteReader: returns rows of data using sql select statement
- DataTable represents a table in a database

