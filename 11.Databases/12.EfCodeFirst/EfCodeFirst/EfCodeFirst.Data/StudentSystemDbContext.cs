namespace EfCodeFirst.Data
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    using EfCodeFirst.Models;

    public class StudentSystemDbContext : DbContext
    {
        public StudentSystemDbContext() : base("StudentSystemCF")
        {
        }

        public virtual IDbSet<Student> Students { get; set; }

        public virtual IDbSet<Course> Courses { get; set; }

        public virtual IDbSet<Homework> Homeworks { get; set; }
    }
}
