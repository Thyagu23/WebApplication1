using Calpion.Artemis.Business.Business_Extenders;
using Calpion.Artemis.Models;
using Calpion.Artemis.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Calpion.Artemis.Business.Managers
{
    public class AccountManager : IAccountManager
    {
        private IMenuRepository _menuRepository;

        public AccountManager(IMenuRepository menuRepository)
        {
            _menuRepository = menuRepository;
        }

        public IEnumerable<MenuItem> GetAll()
        {
            return _menuRepository.GetAll();    
        }

        public IEnumerable<MenuItem> GetAllSubMenu()
        {
            return _menuRepository.GetAllSubMenu();
        }

        public PatientDetailsVM PatientDetailsRegistration()
        {
            return _menuRepository.PatientDetailsRegistration().AsPatientDetailsVM();
        }
    }
}
