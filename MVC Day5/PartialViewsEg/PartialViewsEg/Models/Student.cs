using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PartialViewsEg.Models
{
    public partial class Student
    {
        public string Name { get; set; }
        public int Marks { get; set; }
        public string Stream { get; set; }

        public List<Student> st { get; set; }
    }
}