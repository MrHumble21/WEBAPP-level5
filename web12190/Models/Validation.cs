using System;
using System.ComponentModel.DataAnnotations;

namespace web12190.Models
{
    public class Validation
    {
        public int Id { get; set; }
        [Required]
        public string FileName { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime SubmittedAt { get; set; }

        public int DepartmentId { get; set; }
        public Department Department { get; set; }
    }
}
