CREATE TABLE users
(
	id int PRIMARY KEY IDENTITY (1,1),
	username VARCHAR(MAX) NULL,
	password VARCHAR(MAX) NULL,
	role VARCHAR(MAX) NULL,
	status VARCHAR(MAX) NULL,
	date DATE NULL
)

INSERT INTO users (username, password, role, status) VALUES('tesing1', 'admin123', 'Cashier', 'Active')

SELECT * FROM users

INSERT INTO users(username, password, role, status, date) VALUES('admin', 'admin123', 'Admin', 'Active', '2024-09-12')

CREATE TABLE categories
(
	id INT PRIMARY KEY IDENTITY (1,1),
	category VARCHAR(MAX) NULL,
	date DATE NULL
)

SELECT * FROM categories

CREATE TABLE products
(
	id INT PRIMARY KEY IDENTITY(1,1),
	prod_id VARCHAR(MAX) NULL,
	prod_name VARCHAR(MAX) NULL,
	category VARCHAR(MAX) NULL,
	price FLOAT NULL,
	stock INT NULL,
	image_path VARCHAR(MAX) NULL,
	status VARCHAR(MAX) NULL,
	date_insert DATE NULL
)

SELECT * FROM products

CREATE TABLE orders
(
	id int PRIMARY KEY IDENTITY(1,1),
	prod_id VARCHAR(MAX) NULL,
	prod_name VARCHAR(MAX) NULL,
	category VARCHAR(MAX) NULL,
	qty INT NULL,
	orig_price FLOAT NULL,
	total_price FLOAT NULL,
	order_date DATE NULL,
	customer_id INT NULL
)

ALTER TABLE orders
ADD customer_id INT NULL

SELECT * FROM customers

DELETE FROM orders;

CREATE TABLE customers
(
	id INT PRIMARY KEY IDENTITY(1,1),
	customer_id INT NULL,
	total_price FLOAT NULL,
	amount FLOAT NULL,
	change FLOAT NULL,
	order_date DATE NULL
)


CREATE TABLE creditCustomer
(
    id INT PRIMARY KEY IDENTITY (1,1),       
    customer_id INT NULL,                    
    total_price FLOAT NULL,                   
    amount FLOAT NULL,                        
    change FLOAT NULL,                        
    order_date DATE NULL          
)

SELECT * FROM creditOrders

CREATE TABLE creditOrders 
(
	id int PRIMARY KEY IDENTITY(1,1),
	prod_id VARCHAR(MAX) NULL,
	prod_name VARCHAR(MAX) NULL,
	category VARCHAR(MAX) NULL,
	qty INT NULL,
	orig_price FLOAT NULL,
	total_price FLOAT NULL,
	order_date DATE NULL,
	customer_id INT NULL
)

SELECT * FROM creditOrders

SELECT * FROM creditCustomer

SELECT * FROM customers

SELECT * FROM creditPayments

DBCC CHECKIDENT ('orders', RESEED, 0);


SELECT COUNT(id) FROM customers


DBCC CHECKIDENT ('orders', RESEED, 0);

DBCC CHECKIDENT ('customers', RESEED, 0);

CREATE TABLE creditPayments (
    PaymentID INT PRIMARY KEY IDENTITY(1,1),  -- Unique identifier for each payment
    CustomerID INT NULL,                   -- Reference to the customer making the payment
    TotalPrice FLOAT NULL,       -- Total price for the credit transaction
    AmountPaid FLOAT NULL,-- Amount paid in this transaction
    Amount FLOAT NULL,           -- The amount that remains to be paid (if applicable)
    Change FLOAT NULL,           -- Change returned to the customer
    PaymentDate DATE NULL, -- Date of the payment
)

SELECT * FROM creditPayments



