-- Создание таблицы Products
CREATE TABLE Products (
    ProductID INT IDENTITY(1,1) PRIMARY KEY,
    Name NVARCHAR(100) NOT NULL
);

-- Создание таблицы Categories
CREATE TABLE Categories (
    CategoryID INT IDENTITY(1,1) PRIMARY KEY,
    Name NVARCHAR(100) NOT NULL
);

-- Создание таблицы ProductCategories
CREATE TABLE ProductCategories (
    ProductCategoryID INT IDENTITY(1,1) PRIMARY KEY,
    ProductID INT NOT NULL,
    CategoryID INT NOT NULL,
    FOREIGN KEY (ProductID) REFERENCES Products(ProductID),
    FOREIGN KEY (CategoryID) REFERENCES Categories(CategoryID)
);


-- Добавление Productов
INSERT INTO Products (Name) 
VALUES ('Product 1'), ('Product 2'), ('Product 3'), ('Product 4'), ('Product 5');

-- Добавление категорий
INSERT INTO Categories (Name) 
VALUES ('Category 1'), ('Category 2'), ('Category 3');

-- Добавление связей между Productами и Categoryми
INSERT INTO ProductCategories (ProductID, CategoryID) 
VALUES (1, 1), (1, 2), (3, 3), (3, 1), (4, 3), (4, 1), (5, 1), (5, 2), (5, 3);

-- Итоговый запрос
SELECT P.Name AS 'Product', C.Name AS 'Category'
FROM Products P
LEFT JOIN ProductCategories PC ON P.ProductID = PC.ProductID
LEFT JOIN Categories C ON PC.CategoryID = C.CategoryID
ORDER BY P.ProductID;
