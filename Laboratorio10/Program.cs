using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio10
{
    class Program
    {
        static void Main(string[] args)
        {
            // Origen de datos
            DataClasses1DataContext context = new DataClasses1DataContext();

            /*/ Creación de consulta
            Products p = new Products();
            p.ProductName = "Peruvian Coffe";
            p.SupplierID = 20;
            p.CategoryID = 1;
            p.QuantityPerUnit = "10 pkgs";
            p.UnitPrice = 25;

            // Ejecución de consulta
            context.Products.InsertOnSubmit(p);
            context.SubmitChanges();*/

            /*/ Creación de consulta
            Categories c = new Categories();
            c.CategoryName = "StreamersFood";
            c.Description = "Comida que comen los streamers";

            // Ejecución de consulta
            context.Categories.InsertOnSubmit(c);
            context.SubmitChanges();*/

            //Insertar
            /*/ Creación de consulta
            Categories c = new Categories();
            c.CategoryName = "StreamersFood";
            c.Description = "Comida que comen los streamers";

            // Ejecución de consulta
            context.Categories.InsertOnSubmit(c);
            context.SubmitChanges();*/

            //Update
            /*/ Creación de consulta
            var product = (from p in context.Products
                           where p.ProductName == "Tofu"
                           select p).FirstOrDefault();
            product.UnitPrice = 100;
            product.UnitsInStock = 15;
            product.Discontinued = true;
            // Ejecución de consulta
            context.SubmitChanges();*/

            //Eliminar
            /*/ Creación de consulta
            var product = (from p in context.Products
                            where p.ProductID == 78
                            select p).FirstOrDefault();
            // Ejecución de consulta
            context.Products.DeleteOnSubmit(product);
            context.SubmitChanges();*/

            //ejercicio 1
            /* var product = (from p in context.Products
                            where p.ProductName.Contains("Queso")
                            select p);

             foreach ( var i in product)
             {
                 Console.WriteLine("Producto ID ={0} \t NombreProduct ={1}", i.ProductID, i.ProductName);
             }*/

            //Ejerccios 2
            /*
            var product = (from p in context.Products
                           where p.QuantityPerUnit.Contains("pkg") || p.QuantityPerUnit.Contains("pkgs")
                           select p);

            foreach (var i in product)
            {
                Console.WriteLine("Producto ID ={0} \t NombreProduct ={1} \t QueantyPerunit ={2}", i.ProductID, i.ProductName,i.QuantityPerUnit);
            }*/

            //Ejercicio 3 
            /*
            var product = (from p in context.Products
                           where p.ProductName.StartsWith("A")
                           select p);

            foreach (var i in product)
            {
                Console.WriteLine("Producto ID ={0} \t NombreProduct ={1}", i.ProductID, i.ProductName);
            }
            */
            //ejercicio 4
            /*
            var product = (from p in context.Products
                           where p.UnitsInStock == 0
                           select p);

            foreach (var i in product)
            {
                Console.WriteLine("Producto ID ={0} \t NombreProduct ={1} \t Stock = {2}", i.ProductID, i.ProductName,i.UnitsInStock);
            }*/

            //Ejercicio 5
            /*
            var product = (from p in context.Products
                           where p.Discontinued == true
                           select p);

            foreach (var i in product)
            {
                Console.WriteLine("Producto ID ={0} \t NombreProduct ={1} \t Descontinuado = {2}", i.ProductID, i.ProductName, i.Discontinued);
            }*/
            //Tarea 1 
            /*
            var product = from p in context.Products
                          join s in context.Suppliers on p.SupplierID equals s.SupplierID
                          join c in context.Categories on p.CategoryID equals c.CategoryID
                          where c.CategoryName == "Dairy Products"
                          select new
                          {
                              ProductID = p.ProductID,
                              CategoryName = c.CategoryName,
                              Nproduct = p.ProductName,
                              Nprooverdor = s.CompanyName,
                          };

            foreach (var i in product)
            {
                Console.WriteLine("Producto ID ={0} \t Nombre de Categoria ={1} \t  NombreProduct ={2} \t Nombre de Proovedor = {3}", i.ProductID,i.CategoryName, i.Nproduct, i.Nprooverdor);
            }*/
            /*
            //Tarea 2 
            var product = from p in context.Products
                          join s in context.Suppliers on p.SupplierID equals s.SupplierID
                          where s.Country == "USA"
                          select new
                          {
                              ProductID = p.ProductID,
                              Country = s.Country,
                              Nproduct = p.ProductName,
                              Nprooverdor = s.CompanyName,
                          };

            foreach (var i in product)
            {
                Console.WriteLine("Producto ID ={0} \t Country ={1} \t  NombreProduct ={2} \t Nombre de Proovedor = {3}", i.ProductID, i.Country, i.Nproduct, i.Nprooverdor);
            }*/


            Console.ReadKey();


        }
    }
}
