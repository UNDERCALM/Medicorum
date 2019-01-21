using System;
using System.Collections.Generic;
using Medicorum.Core.Interactors.Interfaces;

namespace Medicorum.Core.Interactors.MedicalHistory.Models
{
    public class MedicalHistoryModel
    {

        public int PatientId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string SSID { get; set; }
        public string DriverLicenseNumber { get; set; }
        public DateTime BirthDate { get; set; }
        public string Gender { get; set; }
        public List<IMedicalHistoryItem> MedicalHistoryItems { get; set; }
       
    }
}
