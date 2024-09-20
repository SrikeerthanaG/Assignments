CREATE DATABASE TechShop;
USE TechShop;
--CUSTOMERS TABLE
CREATE TABLE Customers (
    CustomerID INT PRIMARY KEY,
    FirstName VARCHAR(50),
    LastName VARCHAR(50),
    Email VARCHAR(100),
    Phone VARCHAR(15),
    Address TEXT
);
--PRODUCTS TABLE
CREATE TABLE Products (
    ProductID INT PRIMARY KEY,
    ProductName VARCHAR(100),
    Description TEXT,
    Price DECIMAL(10, 2)
);
--ORDERS TABLE
CREATE TABLE Orders (
    OrderID INT PRIMARY KEY,
    CustomerID INT,
    OrderDate DATE,
    TotalAmount DECIMAL(10, 2),
    FOREIGN KEY (CustomerID) REFERENCES Customers(CustomerID)
);
--ORDER DETAILS TABLE
CREATE TABLE OrderDetails (
    OrderDetailID INT PRIMARY KEY,
    OrderID INT,
    ProductID INT,
    Quantity INT,
    FOREIGN KEY (OrderID) REFERENCES Orders(OrderID),
    FOREIGN KEY (ProductID) REFERENCES Products(ProductID)
);
--INVENTORY TABLE
CREATE TABLE Inventory (
	InventoryID INT PRIMARY KEY,
	ProductID INT,
	QuantityInStocK INT,
	LastStockUpdate DATE,
	FOREIGN KEY (ProductID) REFERENCES Products(ProductID)
);
-- INSERT VALUES INTO CUSTOMERS TABLE
INSERT INTO Customers (CustomerID, FirstName, LastName, Email, Phone, Address)
VALUES 
(1, 'Arun', 'Kumar', 'arun.kumar@gmail.com', '9876543210', '12 Gandhi St, Chennai'),
(2, 'Lakshmi', 'Prabha', 'lakshmi.prabha@gmail.com', '9445567890', '34 Nehru St, Coimbatore'),
(3, 'Ravi', 'Shankar', 'ravi.shankar@gmail.com', '9966778899', '56 Kamaraj St, Madurai'),
(4, 'Meena', 'Devi', 'meena.devi@gmail.com', '9444433221', '78 Anna Nagar, Salem'),
(5, 'Vignesh', 'Raj', 'vignesh.raj@gmail.com', '9000088888', '23 Ooty Road, Erode'),
(6, 'Priya', 'Darshini', 'priya.darshini@gmail.com', '9500000001', '89 MG Road, Trichy'),
(7, 'Karthik', 'S', 'karthik.s@gmail.com', '9845023456', '45 KK Nagar, Tirunelveli'),
(8, 'Bala', 'Murugan', 'bala.murugan@gmail.com', '9567231234', '67 Gandhipuram, Vellore'),
(9, 'Sowmiya', 'Ravi', 'sowmiya.ravi@gmail.com', '9877654321', '12 TVS Nagar, Thanjavur'),
(10, 'Anbu', 'Selvan', 'anbu.selvan@gmail.com', '9888776655', '98 Poompuhar St, Tuticorin');
--INSERT VALUES INTO PRODUCTS
INSERT INTO Products (ProductID, ProductName, Description, Price)
VALUES
(1, 'Laptop', '15-inch display, Intel i7 processor, 16GB RAM, 512GB SSD', 85000.00),
(2, 'Smartphone', '6.5-inch AMOLED display, 128GB storage, 48MP camera', 25000.00),
(3, 'Wireless Headphones', 'Noise-canceling, Bluetooth 5.0, 30-hour battery life', 5500.00),
(4, 'Gaming Console', '4K resolution, 1TB storage, Wireless controllers included', 45000.00),
(5, 'Smartwatch', 'Fitness tracking, Heart rate monitor, GPS, 7-day battery', 12000.00),
(6, 'Tablet', '10-inch display, 64GB storage, Wi-Fi + LTE', 18000.00),
(7, 'External Hard Drive', '2TB storage, USB 3.0, Portable', 4500.00),
(8, 'Bluetooth Speaker', 'Water-resistant, 12-hour battery, Deep bass', 3000.00),
(9, 'Monitor', '27-inch LED, 144Hz refresh rate, 1ms response time', 20000.00),
(10, 'Keyboard & Mouse Combo', 'Mechanical keyboard, RGB backlight, Wireless mouse', 3500.00);

--INSERT VALUES INTO ORDERS
INSERT INTO Orders (OrderID, CustomerID, OrderDate, TotalAmount)
VALUES
(1, 1, '2023-09-01', 85000.00),
(2, 2, '2023-09-02', 25000.00),
(3, 3, '2023-09-03', 5500.00),
(4, 4, '2023-09-04', 45000.00),
(5, 5, '2023-09-05', 12000.00),
(6, 6, '2023-09-06', 18000.00),
(7, 7, '2023-09-07', 4500.00),
(8, 8, '2023-09-08', 3000.00),
(9, 9, '2023-09-09', 20000.00),
(10, 10, '2023-09-10', 3500.00);

--INSERT VALUES INTO ORDERDETAILS
INSERT INTO OrderDetails (OrderDetailID, OrderID, ProductID, Quantity)
VALUES
(1, 1, 1, 1),  
(2, 2, 2, 1),  
(3, 3, 3, 1),  
(4, 4, 4, 1),  
(5, 5, 5, 1),  
(6, 6, 6, 1), 
(7, 7, 7, 1),  
(8, 8, 8, 1),  
(9, 9, 9, 1),  
(10, 10, 10, 1); 

--INSERT VALUES INTO INVENTORY
INSERT INTO Inventory (InventoryID, ProductID, QuantityInStock, LastStockUpdate)
VALUES
(1, 1, 50, '2024-08-01'),
(2, 2, 40, '2024-08-01'),
(3, 3, 30, '2024-08-01'),
(4, 4, 20, '2024-08-01'),
(5, 5, 15, '2024-08-01'),
(6, 6, 10, '2024-08-01'),
(7, 7, 60, '2024-08-01'),
(8, 8, 35, '2024-08-01'),
(9, 9, 80, '2024-08-01'),
(10, 10, 100, '2024-08-01');
--TO DISPLAY THE VALUES OF EACH TABLE
SELECT * FROM Customers;
SELECT * FROM Products;
SELECT * FROM Orders;
SELECT * FROM OrderDetails;
SELECT * FROM Inventory;

-- TASK 2
--Retrieve customer names and emails
SELECT FirstName, LastName, Email 
FROM Customers;

-- List all orders with order dates and customer names
SELECT Orders.OrderID, Orders.OrderDate, Customers.FirstName, Customers.LastName
FROM Orders
JOIN Customers ON Orders.CustomerID = Customers.CustomerID;

-- Insert a new customer record
INSERT INTO Customers (CustomerID, FirstName, LastName, Email, Phone, Address)
VALUES (11, 'Suresh', 'Reddy', 'suresh.reddy@gmail.com', '9876543212', '90 Park Street, Chennai');

-- Update the prices of electronic gadgets by increasing them by 10%
UPDATE Products
SET Price = Price * 1.10;

-- Delete a specific order and its associated order details  
DELETE FROM OrderDetails WHERE OrderID = 2;
DELETE FROM Orders WHERE OrderID = 2;

SELECT *FROM Orders;
SELECT *FROM OrderDetails;

-- Insert a new order into the Orders table
INSERT INTO Orders (OrderID, CustomerID, OrderDate, TotalAmount)
VALUES (11, 1, '2024-09-15', 50000.00); 
SELECT *FROM Orders;

-- Update contact information of a specific customer
UPDATE Customers
SET Email = 'reddy@gmail.com', Address = 'Marudhamalai, Coimbatore'
WHERE CustomerID = 1;
SELECT *FROM Customers;
-- Recalculate and update the total cost of each order
UPDATE Orders
SET TotalAmount = (
    SELECT SUM(Products.Price * OrderDetails.Quantity)
    FROM OrderDetails
    JOIN Products ON OrderDetails.ProductID = Products.ProductID
    WHERE OrderDetails.OrderID = Orders.OrderID
)
SELECT *FROM Orders;
-- Delete all orders and associated order details for a specific customer
DELETE FROM OrderDetails WHERE OrderID IN (SELECT OrderID FROM Orders WHERE CustomerID = 1);
DELETE FROM Orders WHERE CustomerID = 1;
SELECT *FROM Orders;
SELECT *FROM OrderDetails;
-- Insert a new electronic gadget product into the Products table
INSERT INTO Products (ProductID, ProductName, Description, Price)
VALUES (11, 'Smart TV', '55-inch OLED, 4K resolution, Smart features', 65000.00);
SELECT *FROM Products;

-- Update the status of a specific order
-- Add a Status column to the Orders table
ALTER TABLE Orders
ADD Status VARCHAR(20);
UPDATE Orders
SET Status = 
    CASE 
        WHEN OrderDate >= DATEADD(DAY, -7, GETDATE()) THEN 'Shipped'
        WHEN OrderDate >= DATEADD(DAY, -14, GETDATE()) THEN 'Pending'
        ELSE 'Delivered'
    END;
SELECT *FROM Orders;
UPDATE Orders
SET Status = 'Shipping'
WHERE CustomerID = 5;
SELECT *FROM Orders;

-- Calculate and update the number of orders placed by each customer
ALTER TABLE Customers
ADD NumberOfOrders INT DEFAULT 0;

UPDATE Customers
SET NumberOfOrders = (
    SELECT COUNT(*)
    FROM Orders
    WHERE Orders.CustomerID = Customers.CustomerID
);
SELECT *FROM Customers;




