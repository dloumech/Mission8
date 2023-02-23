using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission8.Models
{
    // setting up the connection between our database and our program
    public class TaskSubmissionContext : DbContext
    {
        //constructor
        //inheriting all the base options
        public TaskSubmissionContext (DbContextOptions<TaskSubmissionContext> options) : base (options)
        {

        }

        public DbSet<TaskResponse> Responses { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Category>().HasData(
                new Category { CategoryId = 1, CategoryName = "Home" },
                new Category { CategoryId = 2, CategoryName = "School" },
                new Category { CategoryId = 3, CategoryName = "Work" },
                new Category { CategoryId = 4, CategoryName = "Church" }
                );

            mb.Entity<Quadrant>().HasData(
                new Quadrant { QuadrantId = 1, QuadrantName = "Important/Urgent" },
                new Quadrant { QuadrantId = 2, QuadrantName = "Important/Not Urgent" },
                new Quadrant { QuadrantId = 3, QuadrantName = "Not Important/Urgent" },
                new Quadrant { QuadrantId = 4, QuadrantName = "Not Important/Not Urgent" }
                );
        }
    }
}
