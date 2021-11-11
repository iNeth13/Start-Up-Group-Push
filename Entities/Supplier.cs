using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Start_Up_Group.Entities
{
    public class Supplier : BaseEntityWithInfo
    {
        [Key]
        public int SupplierId { get; set; }
        public string Type { get; set; }
        public DateTime Supply_Since { get; set; }
        public bool Is_Delete { get; set; }
        //relationship with Product
        public virtual ICollection<Product> Products { get; set; }

        public static Supplier Create(string admin,string sName,string sType,string sContact,string sAddress,DateTime sSince)
        {
            Supplier supplier = new Supplier();
            supplier.CreateInfo(admin, sName, sType,sContact,sAddress ,sSince);

            return supplier;
        }

        public void CreateInfo(string admin,string sName,string sType,string sContact,string sAddress,DateTime sSince)
        {
            base.CreatedInfo(sName, sAddress, sContact, admin);
            this.Type = sType;
            this.Supply_Since = sSince;
            this.Is_Delete = false;
        }

        public void UpdateInfo(string admin, string sName, string sType, string sContact, string sAddress, DateTime sSince)
        {
            base.UpdateInfo(sName,sAddress,sContact,admin);
            this.Type = sType;
            this.Supply_Since = sSince;
        }

        public new void DeleteInfo(string admin)
        {
            base.DeleteInfo(admin);
            this.Is_Delete = true;
        }
    }
}
