using Calpion.Artemis.Models;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Calpion.Artemis.DataAccess
{
    public class MenuData : IMenuItemData
    {
        public IEnumerable<MenuItem> GetAll()
        {
            List<MenuItem> menuItems = new List<MenuItem>();

            using (IDbConnection con = new SqlConnection("server=BLR-THYAGARAJAR;database=ArtemisDB;User ID =sa;password=Welcome@123;"))
            {
                //    menuItems = con.Query<MenuItem>("select * from MenuItem", commandType: CommandType.Text).ToList();
                //    menuItems = con.Query<MenuItem>("select * from MenuItem").ToList();
             menuItems= con.Query<MenuItem>("select * from Menutbl A inner join MenuAssoctbl B on A.MenuId = B.ParentId and ChildId is null").ToList();
            }

            return menuItems;
        }

        public IEnumerable<MenuItem> GetAllSubMenu()
        {
            List<MenuItem> menuItems = new List<MenuItem>();

            using (IDbConnection con = new SqlConnection("server=BLR-THYAGARAJAR;database=ArtemisDB;User ID =sa;password=Welcome@123;"))
            {
                   menuItems = con.Query<MenuItem>("select * from Menutbl A inner join (select ParentId, ChildId from MenuAssoctbl) B on A.MenuId = B.ParentId left join(select ParentId, ChildId from MenuAssoctbl) C on B.ChildId = C.ParentId where C.ChildId = 1 or B.ParentId = 1").ToList();
            }
            return menuItems;
        }

        //public PatientDetails PatientDetailsRegistration(int ID, string Name,string Address)
        //{
        //    PatientDetails abc = new PatientDetails();
        //    abc.Id = ID;
        //    abc.Name = Name;
        //    abc.Address = Address;
        //}

        public PatientDetails PatientDetailsRegistration()
        {
            throw new NotImplementedException();
        }
    }
}
