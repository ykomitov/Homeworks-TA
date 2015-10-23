namespace EfCodeFirst.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;

    public class Course
    {
        private ICollection<Student> students;

        public Course()
        {
            this.Students = new HashSet<Student>();
        }

        public int CourseId { get; set; }

        [Required]
        [MinLength(5)]
        [MaxLength(30)]
        public string Name { get; set; }

        [Required]
        [MinLength(5)]
        [MaxLength(30)]
        public string Description { get; set; }

        [MaxLength(20)]
        public string Materials { get; set; }

        public virtual ICollection<Student> Students
        {
            get { return this.students; }
            set { this.students = value; }
        }
    }
}
