using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Xml.Linq;
using System.ComponentModel;

namespace DatabaseQueries
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //Declaring variable

            //declare @tuna INT
            //set @tuna = 99
            //print @tuna





            //            declare @a int , @b int
            //set @a = 13 set @b = 3

            //IF(@a > 10 AND @b < 10)
            //BEGIN
            //    PRINT @a + @b
            //END
            //ELSE
            //BEGIN
            //    PRINT @a - @b
            //END


            //select top(10) * from Customers
            //--expected result: Seeing 10 customers top of the table

            //select CustomerID, CONCAT(ContactName, ContactTitle, City) as concating From Customers
            //--expected result: Maria AndersSales RepresentativeBerlin in a row

            //select CustomerID, ContactName, Country, DATALENGTH(Country) FROM Customers
            //--expected result:   Germany 14               --it shows datas byte lengths
            //                     Mexico  12

            //select ContactName, LEN(ContactName) as [length],ContactTitle,Country,LEN(Country) as [length] from Customers
            //--expected result:     Germany 7
            //                       Mexico  6

            //select ContactName, REPLACE(ContactName, 'a', 'æ'), ContactTitle, Country  from Customers
            //--expected result:       Maria Anders --->Mæriæ ænders
            //                         Ana Trujillo  --->ænæ Trujillo

            //select Count(CustomerID) from Customers
            //--expected result: it shows amount of the customer

            //select AVG(UnitPrice) as[UnitPrice],MAX(UnitPrice) as[MaxPrice],MIN(UnitPrice) as [MinPrice] from Products
            //--expected result: it shows average price, maximum price and minimum price of products

            //Select ISNULL(ContactName,'empty') from Customers
            //--expected result: if contactname column is not empty it shows values else it types empty

            //Insert Into Customers(ContactName, City, CompanyName)
            //values('Tuna', 'Istanbul', 'Ttt')


            //Select OrderID, OrderDate, o.CustomerID,c.ContactName,c.ContactTitle from Orders as O
            //join Customers as C ON o.CustomerID = c.CustomerID


            //delete from Customers where CustomerID = 'ADSA'


            //Update Customers set Country = 'Turkey' where CustomerID = 'ATSF'


            //select c.CategoryName, p.CategoryID, sum(UnitPrice) as TotalPriceofCategory from Products as p
            // join Categories as C on p.CategoryID = C.CategoryID
            //   group by p.CategoryID,c.CategoryName


            //  CategoryID    CategoryName      TotalPriceofCategory
            //   1            Beverages         455,75
            //   2            Condiments        276,75
            //   3            Confections       327,08
            //   4            Dairy Products    287,3
            //   5            Grains / Cereals  141,75
            //   6            Meat / Poultry    324,04
            //   7            Produce           161,85
            //   8            Seafood           248,19



            //    select P.CategoryID,C.CategoryName, count(P.ProductID) as ProductperCategory FROM Products as P
            //    join Categories as C on P.CategoryID = C.CategoryID
            //     group by P.CategoryID,C.CategoryName



            //        CategoryID        CategoryName       ProductperCategory
            //            1              Beverages             12
            //            2              Condiments            12
            //            3              Confections           13
            //            4              Dairy Products        10
            //            5              Grains / Cereals      7
            //            6              Meat / Poultry        6
            //            7              Produce               5
            //            8              Seafood               12



            //select ShipCity, count(ShipCity) from[Orders] group by  ShipCity order by ShipCity


            //ShipCity        amount_of_orders
            //Aachen          6
            //Albuquerque     18
            //Anchorage       10
            //Århus           11
            //Barcelona       5
            //Barquisimeto    14
            //Bergamo         10
            //Berlin          6



            //select E.FirstName,e.LastName, ShipCity,count(ShipCity) from orders as O
            //    inner join Employees as E on O.EmployeeID = E.EmployeeID
            //        group by E.FirstName,e.LastName,ShipCity order by E.FirstName

            //FirstName      LastName    ShipCity     amount_of_orders
            //   Andrew       Fuller     Albuquerque       1
            //   Andrew       Fuller      Anchorage        1
            //   Anne         Dodsworth   Frankfurt a.M.   1
            //   Anne         Dodsworth   Genève           2
            //   Janet        Leverling   Genève           2
            //   Janet        Leverling   Graz             4
            //   Janet        Leverling   Helsinki         1
            //   Janet        Leverling   I.de Margarita   3
            //   Margaret     Peacock     Oulu             2
            //   Margaret     Peacock     Portland         2
            //   Robert       King        Århus            1
            //   Robert       King        Bergamo          1
            //   Robert       King        Bern             1


            //select E.FirstName, e.LastName , ShipCity,count(ShipCity) as amount_of_orders from orders as O
            //     inner join Employees as E on O.EmployeeID = E.EmployeeID
            //            group by e.LastName ,E.FirstName,ShipCity


            //FirstName       LastName        ShipCity        amount_of_orders
            //Steven          Buchanan         Albuquerque        2
            //Laura           Callahan         Colchester         1
            //Laura           Callahan            Cork            1
            //Laura            Callahan           Cowes           1
            //Nancy            Davolio          Berlin            2
            //Nancy            Davolio            Bern            1
            //Margaret         Peacock            Cunewalde       5
            //Michael          Suyama             Versailles      1
            //Michael          Suyama             Warszawa        1



            //select E.FirstName, e.LastName , ShipCity,count(ShipCity) as amount_of_orders from orders as O
            //     inner join Employees as E on O.EmployeeID = E.EmployeeID
            //          group by ShipCity,e.LastName ,E.FirstName



            //FirstName        LastName       ShipCity        amount_of_orders
            //Laura           Callahan            Aachen               1
            //Nancy           Davolio             Aachen               2
            //Andrew          Fuller              Albuquerque          1
            //Janet            Leverling          Albuquerque         4
            //Nancy             Davolio           Barcelona           1
            //Janet             Leverling        Barcelona             1
            //Margaret            Peacock         Barcelona            1
            //Steven              Buchanan         Barquisimeto       2
            //Laura               Callahan         Barquisimeto        3  
            //Nancy               Davolio         Warszawa            2
            //Margaret            Peacock         Warszawa            2
            //Michael             Suyama          Warszawa            1





            //select E.FirstName + ' ' + E.LastName AS Name_Surname, E.Title,o.ShipCity,S.CompanyName ,count(O.ShipCity) from Orders as O
            //    inner join Shippers as S on O.ShipVia = S.ShipperID
            //          inner join Employees as E on O.EmployeeID = E.EmployeeID
            //                group by O.ShipCity,S.CompanyName, E.Title, E.FirstName + ' ' + E.LastName





            //Name_Surname         Title                       ShipCity                 CompanyName         amount_of_orders
            //Laura Callahan      Inside Sales Coordinator    Aachen                  Federal Shipping    1
            //Janet Leverling     Sales Representative        Aachen                  Federal Shipping    1
            //Margaret Peacock    Sales Representative        Aachen                  Federal Shipping    1
            //Nancy Davolio       Sales Representative        Aachen                  Speedy Express      1
            //Nancy Davolio       Sales Representative        Aachen                  United Package      1
            //Robert King         Sales Representative        Aachen                  United Package      1
            //Laura Callahan      Inside Sales Coordinator    Albuquerque             Federal Shipping    1
            //Anne Dodsworth      Sales Representative        Albuquerque             Federal Shipping    1
            //Janet Leverling     Sales Representative        Albuquerque             Federal Shipping    2
            //Margaret Peacock    Sales Representative        Albuquerque             United Package      1
            //Michael Suyama      Sales Representative        Albuquerque             United Package      1
            //Nancy Davolio       Sales Representative        Albuquerque             United Package      2
            //Janet Leverling     Sales Representative        Anchorage              United Package       2
            //Laura Callahan      Inside Sales Coordinator    Århus                   Federal Shipping    1
            //Nancy Davolio       Sales Representative        Århus                   Federal Shipping    1
            //Robert King         Sales Representative        Århus                   Federal Shipping    1
            //Laura Callahan      Inside Sales Coordinator    Barcelona               Federal Shipping    1
            //Janet Leverling     Sales Representative        Barcelona               Federal Shipping    1
            //Margaret Peacock    Sales Representative        Barcelona               Speedy Express      1
            //Nancy Davolio       Sales Representative        Barcelona               Speedy Express      1
            //Laura Callahan      Inside Sales Coordinator    Barcelona               United Package      1
            //Steven Buchanan     Sales Manager               Barquisimeto            Federal Shipping    1
            //Janet Leverling     Sales Representative        Barquisimeto            Federal Shipping    2
            //Nancy Davolio       Sales Representative        Barquisimeto            Federal Shipping    2
            //Laura Callahan      Inside Sales Coordinator    Barquisimeto            Speedy Express      1
            //Janet Leverling     Sales Representative        Barquisimeto            Speedy Express      1











        }
    }
}
