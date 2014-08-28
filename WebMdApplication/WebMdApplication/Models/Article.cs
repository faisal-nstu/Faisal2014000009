using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebMdApplication.Models
{
    public class Article
    {
        public int ArticleId { get; set; }
        public string ArticleTitle { get; set; }
        public string ArticleContent { get; set; }
        public string ImagePath { get; set; }
        public int DoctorId { get; set; }

        public virtual Doctor Doctor { get; set; }

    }
}