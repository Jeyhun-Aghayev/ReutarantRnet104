using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Restoran;
using Restoran.Models.Base;
namespace Restoran.Models
{
    public class Category:BaseClass
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Dish> Dishes { get; set; }

        public Category(int id, string name)
        {
            Id = id;
            Name = name;
            CreatedTime = DateTime.Now;
        }
    }
}
