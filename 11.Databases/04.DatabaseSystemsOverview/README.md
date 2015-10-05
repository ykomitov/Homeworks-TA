# Database Systems - Overview

## Task 1. What database models do you know?
*   Hierarchical (tree)
*   Network (graph)
*   Relational (table)
*   Object-oriented

## Task 2. Which are the main functions performed by a Relational Database Management System (RDBMS)?
*	Create tables, users, manage access to the database
*   Store information (data) in tables
*   Provide relationships between tables (one-to-many, many-to-many, one-to-one)

## Task 3. Define what is "table" in database terms.
A table is a collection of related data held in a structured format within a database. It consists of fields (columns), and rows.

In relational databases and flat file databases, a table is a set of data elements (values) using a model of vertical columns (identifiable by name) and horizontal rows, the cell being the unit where a row and column intersect.[1] A table has a specified number of columns, but can have any number of rows.[2] Each row is identified by one or more values appearing in a particular column subset. The columns subset which uniquely identifies a row is called the primary key.

## Task 4. Explain the difference between a primary and a foreign key.

###Primary Key 
* Uniquely identifies a record in a table
* Can't accept null values
* We can have only one Primary key in a table

###Foreign Key
* A field in the table that is primary key in another table
* Can accept multiple null value
* Foreign key do not automatically create an index, clustered or non-clustered. You can manually create an index on foreign key
* We can have more than one foreign key in a table

## Task 5. Explain the different kinds of relationships between tables in relational databases.

###One-to-many
A single record in the first table has many corresponding records in the second table

###Many-to-many
Records in the first table have many corresponding records in the second one and vice versa

###One-to-one
A single record in a table corresponds to a single record in the other table

## Task 6. When is a certain database schema normalized? What are the advantages of normalized databases?
Normalization of the relational schema removes repeating data. Non-normalized schemas can contain many data repetitions.

## Task 7. What are database integrity constraints and when are they used?
Integrity constraints ensure data integrity in the database tables. They enforce data rules which cannot be violated.

* Primary key constraint: Ensures that the primary key of a table has unique value for each table row
* Unique key constraint: Ensures that all values in a certain column (or a group of columns) are unique
* Foreign key constraint: Ensures that the value in given column is a key from another table
* Check constraint: Ensures that values in a certain column meet some predefined condition

## Task 8. Point out the pros and cons of using indexes in a database.

	+ Indices speed up searching of values in a certain column or group of columns 
	- Adding and deleting records in indexed tables is slower

## Task 9. What's the main purpose of the SQL language?
The SQL (Structured Query Language) is a standardized declarative language for manipulation of relational databases. It supports creating, altering, deleting tables and other objects in the database. It also supports searching, retrieving, inserting, modifying and deleting table data (rows).

## Task 10. What are transactions used for? Give example.

Transactions are a sequence of database operations which are executed as a single unit. Either all of them execute successfully or none of them is executed at all

**Example:** A bank transfer from one account into another (withdrawal + deposit).   If either the withdrawal or the deposit fails the entire operation should be cancelled.

## Task 11. What is a NoSQL database?
A NoSQL (originally referring to "non SQL" or "non relational") database provides a mechanism for storage and retrieval of data that is modeled in means other than the tabular relations used in relational databases. Such databases have existed since the late 1960s, but did not obtain the "NoSQL" moniker until a surge of popularity in the early twenty-first century, triggered by the needs of Web 2.0 companies such as Facebook, Google and Amazon.com.

## Task 12. Explain the classical non-relational data models.

* Document model (e.g. MongoDB, CouchDB) - set of documents, e.g. JSON strings
* Key-value model (e.g. Redis) - Set of key-value pairs
* Hierarchical key-value - Hierarchy of key-value pairs
* Wide-column model (e.g. Cassandra) - Key-value model with schema
* Object model (e.g. Cache) - Set of OOP-style objects

## Task 13. Give few examples of NoSQL databases and their pros and cons.

Pros of MongoDB:

* Schema-less. If you have a flexible schema, this is ideal for a document store like MongoDB. This is difficult to implement in a performant manner in RDBMS
* Sase of scale-out. Scale reads by using replica sets. Scale writes by using sharding (auto balancing). Just fire up another machine and away you go. Adding more machines = adding more RAM over which to distribute your working set.
* Lower cost. Depends on which RDBMS of course, but MongoDB is free and can run on Linux, ideal for running on cheaper commodity kit.
* You can choose what level of consistency you want depending on the value of the data (e.g. faster performance = fire and forget inserts to MongoDB, slower performance = wait until insert has been replicated to multiple nodes before returning)

Cons of MongoDB:

* Data size in MongoDB is typically higher due to e.g. each document has field names stored it
* Lless flexibity with querying (e.g. no JOINs)
* No support for transactions - certain atomic operations are supported, at a single document level
* Less up to date information available/fast evolving product
