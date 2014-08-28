﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebMdApplication.Models
{
    public class Doctor
    {
        public int DoctorId { get; set; }
        public string DoctorName { get; set; }
        public string DoctorDesignation { get; set; }
        public List<Article> ArticleList { get; set; } 
    }
}