using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mission8.Models
{
    public class TaskResponse
    {
        //primary key created and hidden
        [Key]
        [Required]
        public int TaskId { get; set; }

        [Required(ErrorMessage = "Specific Task Required")]
        public string Task { get; set; }
        public DateTime DueDate { get; set; }
        [Required(ErrorMessage ="Must select a Category")]
        public bool Completed { get; set; }

        [Required]
        //foreign key relationships
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public int QuadrantId { get; set; }
        public Quadrant Quadrant { get; set; }
    }
}
