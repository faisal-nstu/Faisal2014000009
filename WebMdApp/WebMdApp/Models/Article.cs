using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Linq;
using System.Web;

namespace WebMdApp.Models
{
    public class Article
    {
        public int ArticleId { get; set; }
        [Display(Name = "Title")]
        [Required(ErrorMessage = "Title Required...")]
        public string ArticleTitle { get; set; }
        [Display(Name = "Article Content")]
        [DataType(DataType.MultilineText)]
        public string ArticleBody { get; set; }
        //[Display(Name = "Image")]
        //public Image ArticleImage { get; set; }
        public int DoctorId { get; set; }
        public Doctor Doctor { get; set; }


    }
}