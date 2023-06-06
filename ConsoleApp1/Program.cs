using InventoryDBWPFCore.Domain.Models;
using InventoryDBWPFCore.Domain.Services;
using InventoryDBWPFCore.EntityFramework;
using InventoryDBWPFCore.EntityFramework.Services;
using System;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            IDataServices<UserDB> userService = new GenericDataService<UserDB>(new InventoryDbContextFactory());
            Console.WriteLine(userService.Delete(1).Result);

            Console.ReadLine();
            Console.ReadLine();
        }
    }
}
