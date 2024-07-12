using Restoran.Models.Base;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restoran.Models
{
    public class Order:BaseClass
    {
        public int Id { get; set; }
        public List<Dish> Dishes { get; set; }
        public double TotalAmount { get; set; }
        public Order(int id)
        {
            Id = id;
            CreatedTime = DateTime.Now;
        }

    }
}
