using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HospitalScheduling.Models
{
    public class Doctor
    {
        public Doctor()
        {
            Patients = new HashSet<Patient>();
        }

        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public virtual ICollection<Patient> Patients { get; set; }
        public int HospitalId { get; set; }
        public virtual Hospital Hospital { get; set; }
    }
}