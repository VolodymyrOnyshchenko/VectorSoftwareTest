/****** Script for SelectTopNRows command from SSMS  ******/
SELECT * FROM ProductsTable
JOIN SuppliersTable ON SuppliersTable.SupplierID = ProductsTable.SupplierID
JOIN CategoriesTable ON CategoriesTable.CategoryID = ProductsTable.CategoryID


--Select product with product name that begins with �C�.
--WHERE ProductName LIKE 'C%'

--Select product with the smallest price.
--WHERE Price = (SELECT MIN(Price) FROM ProductsTable)

--Select cost of all products from the USA.
--WHERE Country = 'USA'

--Select suppliers that supply Condiments.
--WHERE CategoryName = 'Condiments'
/*
INSERT INTO SuppliersTable (SupplierName,City,Country)
VALUES ('Norske Meierier', 'Lviv', 'Ukraine')


INSERT INTO CategoriesTable (CategoryName, Description)
VALUES ('Beverages', 'Soft drinks, coffees, teas, beers, and ales')

INSERT INTO ProductsTable (ProductName, Price, SupplierID,CategoryID)
VALUES ('Green tea', '10', '6', '1')
*/

