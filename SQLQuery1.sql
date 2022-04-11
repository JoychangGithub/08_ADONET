select  c.CategoryID, CategoryName, ProductName
from Products as p
join Categories as c
on p.CategoryID = c.CategoryID
where CategoryName='Beverages'
