using Calpion.Artemis.Models;
using Calpion.Artemis.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Calpion.Artemis.Business.Business_Extenders
{
    public static class PatientDetailsExtenders
    {
        public static PatientDetailsVM AsPatientDetailsVM(this PatientDetails patientDetails)
        {
            return new PatientDetailsVM()
            {
                Id = patientDetails.Id,
                Name = patientDetails.Name,
                Address = patientDetails.Address
            };
        }
    }
}
