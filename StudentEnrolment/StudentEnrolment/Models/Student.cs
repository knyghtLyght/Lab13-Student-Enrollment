﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentEnrolment.Models
{
    public class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public Course Course { get; set; }
    }
}
