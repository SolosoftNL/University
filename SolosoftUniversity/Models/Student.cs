using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SolosoftUniversity.Models
{
    public class Student
    {
        public Student()
        {
            Enrollments = new List<Enrollment>();
        }
        public int Id { get; set; }
        public string LastName { get; set; }
        public string FirstMidName { get; set; }
        public DateTime EnrollmentDate { get; set; }
        public string Email { get; set; }

        //Navigation Properties
        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}