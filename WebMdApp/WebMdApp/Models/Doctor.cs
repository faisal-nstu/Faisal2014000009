using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebMdApp.Models
{
    public class Doctor
    {
        public int DoctorId { get; set; }
        [Display(Name = "Name")]
        [Required(ErrorMessage = "Name Required...")]
        public string DoctorName { get; set; }
        [Display(Name = "Designation")]
        public string DoctorDesignation { get; set; }

        public List<Article> Articles { get; set; }

    }
}