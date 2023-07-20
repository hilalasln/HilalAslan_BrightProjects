﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanatEvi.Entity.Concrete
{
    public class CourseUser
    {
        public int CourseId { get; set; }
        public Course Course { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public DateTime DateRegistration { get; set; } //Kayıt Tarihi 
    }
}
