using Calpion.Artemis.Models;
using Calpion.Artemis.Models.ViewModels;
using System.Collections.Generic;

namespace Calpion.Artemis.Business.Managers
{
    public interface IAccountManager
    {
        IEnumerable<MenuItem> GetAll();
        IEnumerable<MenuItem> GetAllSubMenu();
        //PatientDetailsVM PatientDetailsRegistration();
        //PatientDetails PatientDetailsRegistration();
    }
}