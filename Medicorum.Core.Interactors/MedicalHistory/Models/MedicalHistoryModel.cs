using Medicorum.Core.Interactors.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Medicorum.Core.Interactors.Patients.Models
{
    public class MedicalHistoryModel
    {

        public int PatientId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string SSID { get; set; }
        public string DriverLicenseNumber { get; set; }
        public DateTime BithDate { get; set; }
        public string Gender { get; set; }
        IQueryable<IMedicalHistoryItem> MedicalHistoryItems { get; set; }
       
    }
}
