--CREATE SCHEMA Cheap
--GO

--DROP TABLE Cheap.Customers
CREATE TABLE Cheap.Customers
(
	CustomerID INT IDENTITY NOT NULL,
	UserName NVARCHAR(128) NOT NULL,
	CustomerName NVARCHAR(128) NOT NULL,
	Address NVARCHAR(128) NOT NULL,
);

INSERT INTO Cheap.Customers
VALUES('Joseph Isble', '73 Redemption Rock Trail')

--DROP TABLE Cheap.Carts
CREATE TABLE Cheap.Carts
(
	CartId INT IDENTITY NOT NULL,
	ProductName NVARCHAR(128) NOT NULL,
	CustomerId INT NOT NULL,
);

--DROP TABLE Cheap.Inventorys
CREATE TABLE Cheap.Inventorys
(
	Name NVARCHAR(128) NOT NULL,
	Quantity INT NOT NULL,
	Category NVARCHAR(128),
	Price MONEY NOT NULL,
	Img NVARCHAR(128) NOT NULL
);
UPDATE Cheap.ComputerCases
SET Name = 'Corsair Crystal Series RGB Steel Tempered Glass ATX Mid Tower Case'
WHERE Name = 'Corsair Crystal Series RGB Steel / Tempered Glass ATX Mid Tower Case'

UPDATE Cheap.Inventorys
SET Img = 'motherboard3.jpg'
WHERE Img = 'motherboards3.jpg'

DELETE FROM Cheap.MotherBoards
WHERE Img = 'motherboards3.jpg'



INSERT INTO Cheap.Inventorys
VALUES('Intel Core i9-7940X Skylake X 14-Core 3.1 GHz Desktop Processor', 50, 'CPU', 1149.99,'cpu1.jpg')

INSERT INTO Cheap.Inventorys
VALUES('Intel Core i7-6900K 20M Broadwell-E 8-Core 3.2 GHz Desktop Processor', 20, 'CPU', 1402.99,'cpu2.jpg')

INSERT INTO Cheap.Inventorys
VALUES('Intel Core i5-8600K Coffee Lake 6-Core 3.6 GHz Desktop Processor', 30, 'CPU', 259.99, 'cpu3.jpg')

INSERT INTO Cheap.Inventorys
VALUES('Corsair Crystal Series RGB Steel Tempered Glass ATX Mid Tower Case', 15, 'Computercase', 170.99, 'computercase1.jpg')

INSERT INTO Cheap.Inventorys
VALUES('Thermaltake ATX Open Frame Panoramic Viewing Computer Case', 10, 'Computercase', 119.99, 'computercase2.jpg')

INSERT INTO Cheap.Inventorys
VALUES('Thermaltake View 4-Sided Tempered Glass Full Tower Computer Case', 35, 'Computercase', 184.99, 'computercase3.jpg')

INSERT INTO Cheap.Inventorys
VALUES('MSI B360 GAMING PLUS SATA 6Gbs USB 3.1 ATX Intel Motherboard', 40, 'Motherboard', 94.99, 'motherboards1.jpg')

INSERT INTO Cheap.Inventorys
VALUES('ASUS ROG Strix Z370-E Gaming SATA 6Gbs USB 3.1 ATX Intel Motherboard', 25, 'Motherboard', 197.99, 'motherboards2.jpg')

INSERT INTO Cheap.Inventorys
VALUES('MSI Z370 GAMING PRO CARBON SATA 6Gb/s USB 3.1 ATX Intel Motherboard', 20, 'Motherboard', 159.99, 'motherboards3.jpg')
--DROP TABLE Cheap.CPUs
CREATE TABLE Cheap.CPUs
(
	CPUId INT IDENTITY NOT NULL,
	Name NVARCHAR(128) NOT NULL,
	Speed NVARCHAR(128) NOT NULL,
	Cores INT NOT NULL,
	Price MONEY NOT NULL,
	Img NVARCHAR(128) NOT NULL
);

INSERT INTO Cheap.CPUs
VALUES('Intel Core i9-7940X Skylake X 14-Core 3.1 GHz Desktop Processor', '3.1 GHz', 14, 1149.99,'cpu1.jpg')

INSERT INTO Cheap.CPUs
VALUES('Intel Core i7-6900K 20M Broadwell-E 8-Core 3.2 GHz Desktop Processor', '3.2 GHz', 8, 1402.99,'cpu2.jpg')

INSERT INTO Cheap.CPUs
VALUES('Intel Core i5-8600K Coffee Lake 6-Core 3.6 GHz Desktop Processor', '3.6 Ghz', 6, 259.99, 'cpu3.jpg')


--DROP TABLE Cheap.PowerSupplys
CREATE TABLE Cheap.PowerSupplys
(
	PowerSupplyId INT IDENTITY,
	Name NVARCHAR(128) NOT NULL,
	Wattage NVARCHAR(128) NOT NULL,
	Modular BIT NOT NULL,
	Price MONEY NOT NULL,
	Img NVARCHAR(128) NOT NULL
);

--DROP TABLE Cheap.GraphicsCards
CREATE TABLE Cheap.GraphicsCards
(
	GraphicsCardId INT IDENTITY NOT NULL,
	Name NVARCHAR(128) NOT NULL,
	Speed NVARCHAR(128) NOT NULL,
	Size NVARCHAR(128) NOT NULL,
	Price MONEY NOT NULL,
	Img NVARCHAR(128) NOT NULL
);



--DROP TABLE Cheap.HardDrives
CREATE TABLE Cheap.HardDrives
(
	HardDriveId INT IDENTITY NOT NULL,
	Name NVARCHAR(128) NOT NULL,
	Speed NVARCHAR(128) NOT NULL,
	Size NVARCHAR(128) NOT NULL,
	Category NVARCHAR(128) NOT NULL,
	Price Money NOT NULL,
	Img NVARCHAR(128) NOT NULL
)

--DROP TABLE Cheap.MotherBoards
CREATE TABLE Cheap.MotherBoards
(
	MotherBoardId INT IDENTITY NOT NULL,
	Name NVARCHAR(128) NOT NULL,
	FormFactor NVARCHAR(128) NOT NULL,
	RAMSlots INT NOT NULL,
	PCISlots INT NOT NULL,
	Price MONEY NOT NULL,
	Img NVARCHAR(128) NOT NULL
)


INSERT INTO Cheap.MotherBoards
VALUES('MSI B360 GAMING PLUS SATA 6Gbs USB 3.1 ATX Intel Motherboard', 'ATX', 4, 6, 94.99, 'motherboard1.jpg')

INSERT INTO Cheap.MotherBoards
VALUES('ASUS ROG Strix Z370-E Gaming SATA 6Gbs USB 3.1 ATX Intel Motherboard', 'ATX', 4, 7, 197.99, 'motherboard2.jpg')

INSERT INTO Cheap.MotherBoards
VALUES('MSI Z370 GAMING PRO CARBON SATA 6Gbs USB 3.1 ATX Intel Motherboard', 'ATX', 4, 6, 159.99, 'motherboard3.jpg')

--DROP TABLE Cheap.RAMs
CREATE TABLE Cheap.RAMs
(
	RAMId INT IDENTITY NOT NULL,
	Name NVARCHAR(128) NOT NULL,
	Speed NVARCHAR(128) NOT NULL,
	Size NVARCHAR(128) NOT NULL,
	Price MONEY NOT NULL,
	Img NVARCHAR(128) NOT NULL
);

--DROP TABLE Cheap.ComputerCases
CREATE TABLE Cheap.ComputerCases
(
	ComputerCaseId INT IDENTITY NOT NULL,
	Name NVARCHAR(128) NOT NULL,
	Size NVARCHAR(128) NOT NULL,
	Price MONEY NOT NULL,
	Img NVARCHAR(128) NOT NULL
)

INSERT INTO Cheap.ComputerCases
VALUES('Corsair Crystal Series RGB Steel Tempered Glass ATX Mid Tower Case', 'Mid Tower', 170.99, 'computercase1.jpg')

INSERT INTO Cheap.ComputerCases
VALUES('Thermaltake ATX Open Frame Panoramic Viewing Computer Case', 'Mid Tower', 119.99, 'computercase2.jpg')

INSERT INTO Cheap.ComputerCases
VALUES('Thermaltake View 4-Sided Tempered Glass Full Tower Computer Case', 'Full Tower', 184.99, 'computercase3.jpg')


--DROP TABLE Cheap.PartsOrders
CREATE TABLE Cheap.PartsOrders
(
	OrderID INT IDENTITY NOT NULL,
	CustomerID INT NOT NULL,	
	FinalPrice MONEY NOT NULL,
	TimeOfOrder DATETIME NOT NULL
);

--DROP TABLE Cheap.PartsJunctions
CREATE TABLE Cheap.PartsJunctions
(
	Id INT IDENTITY NOT NULL,
	OrderId INT NOT NULL,
	Name NVARCHAR(128) NOT NULL
);



ALTER TABLE Cheap.Carts
ADD CONSTRAINT PK_Carts_CartId PRIMARY KEY (CartId);

ALTER TABLE Cheap.Customers
ADD CONSTRAINT PK_Customers_CustomerID PRIMARY KEY (CustomerID);
GO

ALTER TABLE Cheap.Inventorys
ADD CONSTRAINT PK_Inventorys_Name PRIMARY KEY (Name)
GO

ALTER TABLE Cheap.CPUs
ADD CONSTRAINT PK_CPUs_CPUId PRIMARY KEY (CPUId)
GO

ALTER TABLE Cheap.PowerSupplys
ADD CONSTRAINT PK_PowerSupplys_PowerSupplyId PRIMARY KEY (PowerSupplyId)
GO

ALTER TABLE Cheap.GraphicsCards
ADD CONSTRAINT PK_GraphicsCards_GraphicsCardId PRIMARY KEY (GraphicsCardId)
GO

ALTER TABLE Cheap.HardDrives
ADD CONSTRAINT PK_HardDrives_HardDriveId PRIMARY KEY (HardDriveId)
GO

ALTER TABLE Cheap.MotherBoards
ADD CONSTRAINT PK_MotherBoards_MotherBoardId PRIMARY KEY (MotherBoardId)
GO

ALTER TABLE Cheap.RAMs
ADD CONSTRAINT PK_RAMs_RAMId PRIMARY KEY (RAMId)
GO

ALTER TABLE Cheap.ComputerCases
ADD CONSTRAINT PK_ComputerCases_ComputerCaseId PRIMARY KEY (ComputerCaseId)
GO

ALTER TABLE Cheap.PartsOrders
ADD CONSTRAINT PK_PartsOrders_OrderID PRIMARY KEY (OrderID)
GO

ALTER TABLE Cheap.PartsJunctions
ADD CONSTRAINT PK_PartsJunctions_Id PRIMARY KEY (Id)
GO




ALTER TABLE Cheap.Carts
ADD CONSTRAINT FK_Carts_ProductName FOREIGN KEY(ProductName) REFERENCES Cheap.Inventorys(Name)
GO

ALTER TABLE Cheap.Carts
ADD CONSTRAINT FK_Carts_CustomerId FOREIGN KEY(CustomerID) REFERENCES Cheap.Customers(CustomerID)
GO

ALTER TABLE Cheap.PartsOrders
ADD CONSTRAINT FK_PartsOrders_CustomerID FOREIGN KEY(CustomerID) REFERENCES Cheap.Customers(CustomerID)
GO

ALTER TABLE Cheap.PartsJunctions
ADD CONSTRAINT FK_PartsJunctions_OrderID FOREIGN KEY(OrderId) REFERENCES Cheap.PartsOrders(OrderID)

ALTER TABLE Cheap.PartsJunctions
ADD CONSTRAINT FK_PartsJunctions_Name FOREIGN KEY(Name) REFERENCES Cheap.Inventorys(Name)

ALTER TABLE Cheap.CPUs
ADD CONSTRAINT FK_CPUs_Name FOREIGN KEY (Name) REFERENCES Cheap.Inventorys(Name)
GO

ALTER TABLE Cheap.PowerSupplys
ADD CONSTRAINT FK_PowerSupplys_Name FOREIGN KEY (Name) REFERENCES Cheap.Inventorys(Name)
GO

ALTER TABLE Cheap.GraphicsCards
ADD CONSTRAINT FK_GraphicsCards_Name FOREIGN KEY (Name) REFERENCES Cheap.Inventorys(Name)
GO

ALTER TABLE Cheap.HardDrives
ADD CONSTRAINT FK_HardDrives_Name FOREIGN KEY (Name) REFERENCES Cheap.Inventorys(Name)
GO

ALTER TABLE Cheap.MotherBoards
ADD CONSTRAINT FK_MotherBoards_Name FOREIGN KEY (Name) REFERENCES Cheap.Inventorys(Name)
GO

ALTER TABLE Cheap.RAMs
ADD CONSTRAINT FK_RAMs_Name FOREIGN KEY (Name) REFERENCES Cheap.Inventorys(Name)
GO

ALTER TABLE Cheap.ComputerCases
ADD CONSTRAINT FK_ComputerCases_Name FOREIGN KEY (Name) REFERENCES Cheap.Inventorys(Name)
GO




SELECT * FROM Cheap.Customers

SELECT * FROM Cheap.Inventorys

SELECT * FROM Cheap.CPUs

SELECT * FROM Cheap.RAMs

SELECT * FROM Cheap.PowerSupplys

SELECT * FROM Cheap.MotherBoards

SELECT * FROM Cheap.ComputerCases

SELECT * FROM Cheap.HardDrives

SELECT * FROM Cheap.GraphicsCards

SELECT * FROM Cheap.PartsOrders

SELECT * FROM Cheap.PartsJunctions

SELECT * FROM Cheap.Carts

