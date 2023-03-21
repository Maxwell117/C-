/* joins: select all the computers from the products table:
using the products table and the categories table, return the product name and the category name */
 SELECT P.Name,C.Name FROM product as P INNER JOIN categories AS C ON C.CategoryID=P.CategoryID WHERE C.Name = "Computers";
/* joins: find all product names, product prices, and products ratings that have a rating of 5 */
 SELECT * FROM products LEFT JOIN reviews ON reviews.ProductID = products.ProductID WHERE review.ratings=5;
/* joins: find the employee with the most total quantity sold.  use the sum() function and group by */
SELECT e.employees,e.LastName,SUM(e.quantity) AS Total FROM sales as s INNER JOIN employees AS e ON e.employeesID=s.EmployeesID GROUP BY e.Employees ORDER BY Total DESC limit 1;
/* joins: find the name of the department, and the name of the category for Appliances and Games */
SELECT d.Name,c.Name FROM Departments as d INNER JOIN categories as c ON c.Department=d.DepartmentID WHERE c.Name="Appliances" OR c.Name="Games"; 
/* joins: find the product name, total # sold, and total price sold,
 for Eagles: Hotel California --You may need to use SUM() */
SELECT p.Name,SUM(s.quantity) as "total sold",SUM(s.quantity*s.PricePerUnit) as "total price" FROM products as p INNER JOIN sales as s on s.productID=p.productID where p.productID=;
/* joins: find Product name, reviewer name, rating, and comment on the Visio TV. (only return for the lowest rating!) */
SELECT p.Name,r.Name,r.comment FROM product as p INNER JOIN reviews as r ON r.productID=p.productID WHERE p.productID=857 and r.rating=1 GROUP BY p.productID;
