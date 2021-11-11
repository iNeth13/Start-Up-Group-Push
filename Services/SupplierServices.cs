using Start_Up_Group.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Start_Up_Group.Services
{
    public interface ISupplierServices
    {
        public Supplier CreateSupplier(string admin, string sName, string sAddress, string sContact, string sType, DateTime sSince);
        public Supplier UpdateSupplier(int sId, string admin, string sName, string sType, string sContact, string sAddress, DateTime sSince);
        public bool DeleteSupplier(int sId, string admin);
        public List<Supplier> GetAllSuppliers();
    }

    public class SupplierServices : ISupplierServices
    {
        private StoreContext storeContext;
        public SupplierServices()
        {
            this.storeContext = new StoreContext();
        }

        public Supplier CreateSupplier(string admin,string sName,string sAddress, string sContact,string sType,DateTime sSince)
        {
            Supplier supplier = Supplier.Create(admin,sName,sType,sContact,sAddress,sSince);
            this.storeContext.Suppliers.Add(supplier);
            this.storeContext.SaveChanges();
            return supplier;
        }

        public Supplier UpdateSupplier(int sId,string admin,string sName,string sType,string sContact,string sAddress, DateTime sSince)
        {
            var current = this.storeContext.Suppliers.Find(sId);
            current.UpdateInfo(admin,sName,sType,sContact,sAddress,sSince);
            this.storeContext.SaveChanges();
            return current;
        }

        public bool DeleteSupplier(int sId,string admin)
        {
            var current = this.storeContext.Suppliers.Find(sId);
            current.DeleteInfo(admin);
            this.storeContext.SaveChanges();
            return true;
        }

        public List<Supplier> GetAllSuppliers()
        {
            var suppliers = this.storeContext.Suppliers.Where(s => s.Is_Delete == false).ToList();
            return suppliers;
        }
    }
}
