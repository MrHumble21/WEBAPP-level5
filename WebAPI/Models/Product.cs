using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Models;

namespace WebAPI.Models
{
    public class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal  Price { get; set; }
        public decimal Quantity { get; set; }
        public Category ProductCategory { get; set; }
        public Department ProductDepartment { get; set; }
    }
}
