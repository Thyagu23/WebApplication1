using Calpion.Artemis.Models;
using System;
using System.Collections.Generic;

namespace Calpion.Artemis.DataAccess
{
    public interface IMenuItemData
    {
        IEnumerable<MenuItem> GetAll();
        IEnumerable<MenuItem> GetAllSubMenu();
        PatientDetails PatientDetailsRegistration();
    }
}
