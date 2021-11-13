using Microsoft.EntityFrameworkCore;
using Start_Up_Group.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Start_Up_Group.Services
{

    public interface IManagerServices
    {
        public Manager CreateNewManager(string email,double salary,DateTime hired_date,string name,string address,string contact, string adminName);
        public bool DeleteManager(int id,string admin);
        public Manager UpdateManager(int id, string name, string address, string contact, string email, DateTime hired_date, double salary, string admin);
        public List<Manager> GetAllManagers(string searchValue);
        public Manager GetManagerDetailWithBranches(int id);
    }

    public class ManagerServies : IManagerServices
    {

        private StoreContext storeContext;

        public ManagerServies()
        {
            this.storeContext = new StoreContext();
        }

        public Manager CreateNewManager(string email,double salary,DateTime hired_date,string name,string address,string contact,string adminName)
        {
            var manager = Manager.CreateManager(email,salary,hired_date,name,address,contact,adminName);
            this.storeContext.Managers.Add(manager);
            storeContext.SaveChanges();
            return manager;
        }

        public Manager UpdateManager(int id, string name, string address, string contact, string email,DateTime hired_date,double salary,string admin)
        {
            var current = this.storeContext.Managers.Find(id);
            current.UpdateInfo(name,address,contact,email,salary,hired_date,admin);
            this.storeContext.SaveChanges();
            return current;
        }

        public bool DeleteManager(int id,string admin)
        {
            var manager = this.storeContext.Managers.Find(id);
            manager.DeleteInfo(admin);
            this.storeContext.SaveChanges();

            return true;
        }

        public Manager GetManagerDetailWithBranches(int id)
        {
            var current = storeContext.Managers.Where(m=>m.ManagerId == id).Where(m=>m.Is_deleted == false).Include(b=>b.Branches.Where(b=>b.Is_delete==false)).Single();
            if(current == null)
            {
                throw new Exception();
            }
            return current;
        }

        public List<Manager> GetAllManagers(string searchValue)
        {
            var result = this.storeContext.Managers.Where(m => m.Name.Contains(searchValue)).Where(m=>m.Is_deleted == false).ToList();

            return result;
        }
    }
}
