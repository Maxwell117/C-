
/* joins: select all the computers from the products table:
using the products table and the categories table, return the product name and the category name */
SELECT P.Name, C.Name FROM product as P INNER JOIN categories AS C ON C.CategoryID= P.CategoryID WHERE C.Name = "Computers";
/* joins: find all product names, product prices, and products ratings that have a rating of 5 */
SELECT products.Name,products.Price,reviews.Rating FROM products LEFT JOIN reviews ON reviews.ProductID = products.ProductID WHERE reviews.Rating=5;
/* joins: find the employee with the most total quantity sold.  use the sum() function and group by */
SELECT e.Employees, e.LastName, SUM(e.Quantity) AS Total FROM sales as s INNER JOIN employees AS e ON e.EmployeeID= s.EmployeeID GROUP BY e.EmployeeID ORDER BY Total DESC limit 1;
/* joins: find the name of the department, and the name of the category for Appliances and Games */
SELECT d.Name, c.Name FROM departments as d INNER JOIN categories as c ON c.DepartmentID = d.DepartmentID WHERE c.Name= "Appliances" OR c.Name= "Games";
/* joins: find the product name, total # sold, and total price sold,
 for Eagles: Hotel California --You may need to use SUM() */
SELECT p.Name, SUM(s.Quantity) as "total sold", SUM(s.Quantity* s.PricePerUnit) as "total price" FROM products as p INNER JOIN sales as s on s.ProductID=p.ProductID where p.ProductID=97;
/* joins: find Product name, reviewer name, rating, and comment on the Visio TV. (only return for the lowest rating!) */
SELECT p.Name, r.Name,MIN(r.Rating) FROM products as p INNER JOIN reviews as r ON r.ProductID=p.ProductID WHERE p.ProductID=857 GROUP BY p.ProductID;
