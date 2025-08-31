-- сброс всей базы
DROP TABLE IF EXISTS Products;
DROP TABLE IF EXISTS Categories;
DROP TABLE IF EXISTS Suppliers;

--
CREATE TABLE Categories
(
	[CategoryId] BIGINT NOT NULL IDENTITY(1,1) PRIMARY KEY, 
    [Name] VARCHAR(50) NOT NULL, 
    [ParentId] BIGINT NULL,

    UNIQUE(Name),
    FOREIGN KEY (ParentId) REFERENCES Categories(CategoryId)
);


--
CREATE TABLE Suppliers
(
	[SupplierId] BIGINT NOT NULL IDENTITY(1,1) PRIMARY KEY, 
    [Name] VARCHAR(50) NOT NULL, 
    UNIQUE(Name)
);
INSERT INTO Suppliers (Name) VALUES ('Market#1'), ('Molokozavod');

-- 
CREATE TABLE Products
(
	[ProductId] BIGINT NOT NULL IDENTITY(1,1) PRIMARY KEY, 
    [Name] VARCHAR(50) NOT NULL, 
    [Description] VARCHAR(250) NOT NULL, 
    [CategoryId] BIGINT NOT NULL, 
    [SupplierId] BIGINT NOT NULL,

    FOREIGN KEY (CategoryId) REFERENCES Categories(CategoryId),
    FOREIGN KEY (SupplierId) REFERENCES Suppliers(SupplierId)
);

