using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SolosoftUniversity.Models
{
    public class Enrollment
    {
        public int Id { get; set; }
        public int CourseId { get; set; }
        public int StudentId { get; set; }
        public Grade? Grade { get; set; }

        //Navigation Properties
        public virtual Student Student { get; set; }
        public virtual Course Course { get; set; }
    }
}