using Restoran.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restoran.Models
{
    public class Restaurant:BaseClass
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public List<Dish> Menyu { get; set; }
        public Restaurant(string name)
        {
            Name = name;
            CreatedTime = DateTime.Now;
        }
        public void AddDish(Dish dish)
        {
            Menyu.Add(dish);
        }
        public void AddOrder(ref List<Order> Orders,Order order) 
        {
            Orders.Add(order);
        }
        public Order FindOrder(List<Order> Orders, int id)
        {
            return Orders.Where(o => o.Id == id).FirstOrDefault();
        }

    }
}
