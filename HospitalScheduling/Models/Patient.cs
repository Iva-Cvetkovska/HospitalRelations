using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HospitalScheduling.Models
{
    public class Patient
    {
        public Patient()
        {
            Doctors = new HashSet<Doctor>();
        }

        [Key]
        public int Id { get; set; }
        [Display(Name = "Patient Code")]
        [RegularExpression(@"^\d{5}$", ErrorMessage = "Patient code must be exactly 5 digits.")]
        public int PatientCode { get; set; }
        [Required]
        public string Name { get; set; }
        public string Gender { get; set; }
        public virtual ICollection<Doctor> Doctors { get; set; }
    }
}