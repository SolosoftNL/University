using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SolosoftUniversity.Models
{
    public class Course
    {
        public Course()
        {
            Enrollments = new List<Enrollment>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        public string Title { get; set; }
        public int Credits { get; set; }

        //Navigation Properties
        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}