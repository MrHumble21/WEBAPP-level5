using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace web12190.Models
{
    public class Department
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }

        public string Description { get; set; }

        [DataType(DataType.Date)]
        public DateTime CreatedAt { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public int ProductId { get; set; }
        public Product Product { get; set; }

        public Validation Submission { get; set; }
    }
}
