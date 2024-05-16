using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HospitalScheduling.Models
{
    public class PatientAndDoctor
    {
        public PatientAndDoctor() 
        {
            Patients = new List<Patient>(); 
        }
        public int DoctorId { get; set; }
        public Doctor Doctor { get; set; }
        public int PatientId { get; set; }
        public List<Patient> Patients { get; set; }
    }
}