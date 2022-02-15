using PrsLibrary.Controllers;
using PrsLibrary.Models;
using System;
using System.Linq;

namespace PrsDbPractice
{
    class Program
    {
        
        static void Main(string[] args)
        {

            var context = new PrsDbContext();

            var userCtrl = new UsersController(context);

            var user = userCtrl.Login("gdoud", "passwordx");

            if(user is null)
            {
                Console.WriteLine("User not found");
            }
            else
            {
                Console.WriteLine(user.Username);
            }
            
            /*
            var username = "gpdoud";
            var password = "password";
            var user1 = context.Users.SingleOrDefault(x => x.Username == username && x.Password == password);

            var user = from u in context.Users
                       where u.Username == username && u.Password == password
                       select u;
            */

            /*
            var context = new PrsDbContext();

            var prodCtrl = new ProductsController(context);

            var products = prodCtrl.GetAll();


            foreach(var p in products)
            {
                Console.WriteLine($"{p.ID,-5} {p.PartNbr,-12} {p.Name,-12} {p.Price,10:c} {p.Vendor.Name,-15}");
            }

            var product = prodCtrl.GetByPk(2);

            if(product is not null)
            {
                Console.WriteLine($"{product.ID,-5} {product.PartNbr,-12} {product.Name,-12} " +
                    $"{product.Price,10:c} {product.Vendor.Name,-15}");
            }
            */
            /*
            var context = new PrsDbContext();
            var userCtrl = new UsersController(context);
            

            var user3 = userCtrl.GetByPk(3);
            if(user3 is null)
            {
                Console.WriteLine("User not found.");
            }
            else
            {
                Console.WriteLine($"User3: {user3.Firstname} {user3.Lastname}");
            }
            user3.Lastname = "User 3";
            userCtrl.Change(user3);

            var newUser = new User()
            {
                ID = 0,
                Username = "xxbx",
                Password = "yy",
                Firstname = "User",
                Lastname = "XX",
                Phone = "211",
                Email = "xx@user.com",
                IsReviewer = false,
                IsAdmin = false
            };

            
            userCtrl.Create(newUser);
            
            var users = userCtrl.GetAll();

            


            foreach(var user in users)
            {
                Console.WriteLine($"{user.Firstname} {user.Lastname}");
            }

        */
        }
    }
}
