using System;
using Medicorum.Core.Interactors.Interfaces;

namespace Medicorum.Core.Interactors.Patients
{
    class PatientHistoryItemViewModel : IMedicalHistoryItem
    {
        public int PatientHistoryItemId { get; set; }
        public int PatientHistoryId { get; set; }
        public DateTime Date { get; set; }
        public string Label { get; set; }
        public string Description { get; set; }
        public string MeasurementString { get; set; }
    }
}
