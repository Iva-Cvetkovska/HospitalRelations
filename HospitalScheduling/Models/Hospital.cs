using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HospitalScheduling.Models
{
    public class Hospital
    {
        [Key]
        public int HospitalId { get; set; }
        [Required]
        [Display(Name = "Hospital Name")]
        public string Name { get; set; }
        public string Image { get; set; }
        public string Address { get; set; }
        public ICollection<Doctor> Doctors { get; set; }
    }
}