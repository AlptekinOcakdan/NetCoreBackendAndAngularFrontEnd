--Select
--ANSII
Select ContactName Adi,CompanyName Sirketadi,City Sehir from Customers

Select * from Customers where City = 'Berlin'

--case insensitive
sElEcT * from Products where categoryId=1 or categoryId=3

select * from Products where categoryId=1 and UnitPrice>=10

select * from Products where categoryId=1 order by UnitPrice desc    --ascending  --descending

Select count(*) Adet from Products

select categoryID,count(*) from products where UnitPrice>20 
group by CategoryID having count(*)<10

select Products.ProductID, Products.ProductName, Products.UnitPrice, Categories.CategoryName 
from Products inner join Categories
on Products.CategoryID = Categories.CategoryID
where Products.UnitPrice>10

--DTO Data Transformation object

Select * from Products p inner join [Order Details] od
on p.ProductID = od.ProductID
inner join Orders o
on o.OrderID = od.OrderID


Select * from Customers c left join Orders o
on c.CustomerID = o.CustomerID
where o.CustomerID is null

select Products.productName as [Ürün Adı], (Products.price*Sum(orderdetails.quantity)) as [Toplam Kazanılan Tutar], 
products.productid, sum(orderdetails.quantity ) as [Toplam Adet], products.price
from orderdetails
inner join products on products.productid = orderdetails.productid
inner join orders on orders.orderid = orderdetails.orderid group by products.productname

SELECT p.ProductName 'ÜRÜN ADI',SUM(od.UnitPrice*od.Quantity) 'KAZANILAN TOPLAM MİKTAR'
	FROM Products p
		LEFT JOIN [Order Details] od ON od.ProductID = p.ProductID
		LEFT JOIN Orders o ON o.OrderID = od.OrderID
			GROUP BY p.ProductID,p.ProductName
				ORDER BY p.ProductID

Select P.ProductName , Format(Round(Sum((1 - OD.Discount) * (OD.Quantity * OD.UnitPrice)),2),'C', 'en-US') as [ToplamKazanç] 
from [Order Details] as OD join Orders O on OD.OrderID = O.OrderID inner join Products P on P.ProductID = OD.ProductID
group by P.ProductName
order by P.ProductName asc


Select p.ProductName, sum(Quantity*od.UnitPrice) TotalQuantity
from Products p 
left join [Order Details] od 
on p.ProductID = od.ProductID
group by p.ProductName 
order by p.ProductName

