using Calpion.Artemis.Models;
using System.Collections.Generic;

namespace Calpion.Artemis.Business
{
    public interface IMenuRepository
    {
        IEnumerable<MenuItem> GetAll();
        IEnumerable<MenuItem> GetAllSubMenu();
        PatientDetails PatientDetailsRegistration();
    }
}
