using Calpion.Artemis.DataAccess;
using Calpion.Artemis.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Calpion.Artemis.Business
{
    public class MenuRepository : IMenuRepository
    {
        private IMenuItemData _menuItemData;

        public MenuRepository(IMenuItemData menuItemData)
        {
            _menuItemData = menuItemData;
        }

        public IEnumerable<MenuItem> GetAll()
        {
            return _menuItemData.GetAll();
        }

        public IEnumerable<MenuItem> GetAllSubMenu()
        {
            return _menuItemData.GetAllSubMenu();
        }

        public PatientDetails PatientDetailsRegistration()
        {
            return _menuItemData.PatientDetailsRegistration();
        }
    }
}
