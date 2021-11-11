using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Start_Up_Group.Entities
{
    public abstract class BaseEntity
    {
     
        public DateTime Created_at { get; set; }
        public string Created_by { get; set; }
        public DateTime Updated_at { get; set; }
        public string Updated_by { get; set; }
        public string Deleted_by { get; set; }
        public DateTime Deleted_at { get; set; }

        protected void CreateInfo(string adminName)
        {
            this.Created_at = DateTime.Now;
            this.Created_by = adminName;
        }

        protected void UpdatedInfo(string adminName)
        {
            this.Updated_at =  DateTime.Now;
            this.Updated_by = adminName;
        }

        protected void DeleteInfo(string adminName)
        {
            this.Deleted_at = DateTime.Now;
            this.Deleted_by = adminName;
        }

        public Object ResponseSuccess()
        {
            return this;
        }
    }

    public abstract class BaseEntityWithInfo : BaseEntity
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Contact { get; set; }

        public void CreatedInfo(string name, string address, string contact, string username)
        {
            //override createInfo in BaseEntity
            base.CreateInfo(username);
     
            this.Name = name;
            this.Address = address;
            this.Contact = contact;
        }

        public void UpdateInfo(string name , string address, string contact,string adminName)
        {
            base.UpdatedInfo(adminName);

            this.Name = name.Length>0 ? name : this.Name;
            this.Address = address.Length > 0 ? address : this.Address;
            this.Contact = contact.Length > 0 ? contact : this.Contact;
        }

        public void DeleteInfo(string adminName)
        {
            base.DeleteInfo(adminName);
        }
    }

}
