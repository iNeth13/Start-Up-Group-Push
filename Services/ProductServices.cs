using Start_Up_Group.Entities;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace Start_Up_Group.Services
{
    public interface IProductServices
    {
        public Product CreateProduct(int sId, string adminName, string pName, double pBuyIn, double pSellOut, string pCategory, DateTime pExpirationDate);
        public List<Product> GetAllProducts(string searchValue);
        public Product UpdateProduct(int pId, string admin, string pName, double pBuyIn, double pSellOut, string pCategory, DateTime pExpirationDate);
        public bool DeleteProduct(int pId, string adminName);
    }

    public class ProductServices : IProductServices
    {
        private StoreContext storeContext;

        public ProductServices()
        {
            this.storeContext = new StoreContext();
        }

        public Product CreateProduct(int sId,string adminName,string pName,double pBuyIn,double pSellOut,string pCategory,DateTime pExpirationDate)
        {
            Product product = Product.Create(adminName,pName,pBuyIn,pSellOut,pCategory,pExpirationDate,sId);
            var supplier = this.storeContext.Suppliers.Find(sId);
            this.storeContext.Products.Add(product);
            this.storeContext.SaveChanges();

            supplier.Products.Add(product);
            this.storeContext.SaveChanges();

            return product;
        }

        public List<Product> GetAllProducts(string searchValue)
        {
            var result = this.storeContext.Products.Where(p => p.ProductName.Contains(searchValue)).Where(p => p.Is_Delete == false).ToList();

            return result;
        }

        public Product UpdateProduct(int pId,string admin,string pName,double pBuyIn,double pSellOut,string pCategory,DateTime pExpirationDate)
        {
            var current = this.storeContext.Products.Find(pId);
            current.UpdateInfo(admin,pName,pBuyIn,pSellOut,pCategory,pExpirationDate);
            this.storeContext.SaveChanges();
            return current;
        }

        public bool DeleteProduct(int pId,string adminName)
        {
            var current = this.storeContext.Products.Find(pId);
            current.DeleteInfo(adminName);
            return true;
        }
    }
}
