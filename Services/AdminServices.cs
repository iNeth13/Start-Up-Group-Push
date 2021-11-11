using Microsoft.EntityFrameworkCore;
using Start_Up_Group.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Start_Up_Group.Services
{
    public interface IAdminServices
    {
        public Admin GetAdmin(string username, string password);
    }

    public class AdminServices : IAdminServices
    {
        private StoreContext context;

        public AdminServices()
        {
            this.context = new StoreContext();
        }

        public Admin GetAdmin(string username, string password)
        {
            var current = this.context.Admins
                .Where(a=>a.Is_delete == false && a.Password==password && a.Username == username)
                .FirstOrDefault<Admin>();
            
            return current;
        }
    }
}
