using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Start_Up_Group.Entities
{
    public class Manager : BaseEntityWithInfo
    {
        public int ManagerId { get; set; }
        public string Email { get; set; }
        public double Salary { get; set; }
        public DateTime Hired_date {get;set;}
        public bool Is_deleted { get; set; }

        [ForeignKey("Branch")]
        public int BranchId { get; set; }
        public virtual ICollection<Branch> Branches { get; set; }

        public void UpdateInfo(string name,string address,string contact,string email,double salary,DateTime hired_date,string adminName)
        {
            base.UpdateInfo(name,address,contact,adminName);
            this.Email = email.Length > 0 ? email : this.Email;
            this.Salary = salary;
            this.Hired_date = hired_date;
        }

        public void DeleteInfo(string adminName)
        {
            base.DeleteInfo(adminName);
            this.Is_deleted = true;
        }

        public static Manager CreateManager(string email, double salary, DateTime hired_date, string name, string address,string contact,string adminName)
        {
            var manager = new Manager();
            manager.CreatedInfo(name , address,contact,adminName);

            manager.Email = email;
            manager.Salary = salary;
            manager.Hired_date = hired_date;
            manager.Is_deleted = false;

            return manager;
        }
    }
}
