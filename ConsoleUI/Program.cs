using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using System;

namespace ConsoleUI
{
    //SOLID
    //Open Closed Principle - Yazılıma yeni bir özellik ekliyorsak, mevcuttaki koduna dokunamazsın
    internal class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new EfProductDal());

            foreach (var product in productManager.GetAllByCategory(2))
            {
                Console.WriteLine(product.ProductName);
            }

            Console.ReadLine();
        }
    }
}
