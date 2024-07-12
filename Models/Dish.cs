using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Restoran.Models.Base;
namespace Restoran.Models;

public class Dish:BaseClass
{
    public string Name { get; set; }
    public double Price { get; set; }
    public Category category { get; set; }

    public static double operator +(Dish obj1, Dish obj2)
    {
        return obj1.Price + obj2.Price;

    }

    public Dish(int id, string name, double price)
    {
        Id = id;
        Name = name;
        Price = price;
        CreatedTime = DateTime.Now; 
    }
    public List<Dish> FindDishesByCategory(List<Dish> Dishes, int id)
    {
        return Dishes.Where(d => d.category.Id == id).ToList();
    }
}
