# Mindbox_library
Решение тестового задания для MindBox.

Напишите на C# библиотеку для поставки внешним клиентам, которая умеет вычислять площадь круга по радиусу и треугольника по трем сторонам. Дополнительно к работоспособности оценим:
<br>
+ Юнит-тесты - **Есть**
+ Легкость добавления других фигур - **Новая фигура должна быть наследником Shape и реализовывать 2 метода**
+ Вычисление площади фигуры без знания типа фигуры в compile-time - **пример полиморфизма в Program.cs**
+ Проверку на то, является ли треугольник прямоугольным - **Есть**

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
-- Пример: Product 1 принадлежит Categoryм 1 и 2, Product 2 - к категории 3 и т.д.
INSERT INTO ProductCategories (ProductID, CategoryID) 
VALUES (1, 1), (1, 2), (3, 3), (3, 1), (4, 3), (4, 1), (5, 1), (5, 2), (5, 3);


SELECT P.Name AS 'Product', C.Name AS 'Category'
FROM Products P
LEFT JOIN ProductCategories PC ON P.ProductID = PC.ProductID
LEFT JOIN Categories C ON PC.CategoryID = C.CategoryID
ORDER BY P.ProductID;

