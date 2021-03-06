﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace HTMLHelperEg.Models
{
    public class Student
    {
        [Display(Name="Student Roll No:")]
        public int RollNo { get; set; }
        [Display(Name="Student Name:")]
        public string Name { get; set; }
        public string Gender { get; set; }
        public string City { get; set; }
        [DataType(DataType.MultilineText)]
        public string Address { get; set; }
    }
}