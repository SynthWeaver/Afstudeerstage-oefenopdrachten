using System;
using System.Collections.Generic;

namespace ContosoUniversity.Models
{
    public class Teacher
    {
        public int TeacherId { get; set; }
        public string EmailAddress { get; set; }
        public string LastName { get; set; }
        public string FirstMidName { get; set; }

        public virtual ICollection<Student> Students { get; set; }
    }
}