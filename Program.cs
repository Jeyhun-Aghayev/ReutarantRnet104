using Restoran.Models;
using System.Security.Cryptography.X509Certificates;

namespace Restoran
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dish d = new Dish(1,"qwd",342.2);
            Dish a = new Dish(2,"asddas",1124.1);
            double c = d + a;
        }
        public static List<Order> Orders = new List<Order>();
        public static List<Category> Categories = new List<Category>();
        public static List<Dish> Dishes = new List<Dish>();
    }
}
    