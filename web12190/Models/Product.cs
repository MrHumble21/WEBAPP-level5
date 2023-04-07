using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace web12190.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Price { get; set; }

        public ICollection<Delivery> Assignments { get; set; }
        public ICollection<Department> Departments { get; set; }
    }
}
