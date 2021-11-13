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
        public Product CreateProduct(int sId, string adminName, string pName, double pBuyIn, double pSellOut, string pCategory, DateTime pExpirationDate, string pAmount);
        public List<Product> GetAllProducts(string searchValue);
        public Product UpdateProduct(int pId, string admin, string pName, double pBuyIn, double pSellOut, string pCategory, DateTime pExpirationDate,string pAmount);
        public bool DeleteProduct(int pId, string adminName);
        public List<Product> Test(List<int> pIds);
    }

    public class ProductServices : IProductServices
    {
        private StoreContext storeContext;

        public ProductServices()
        {
            this.storeContext = new StoreContext();
        }

        public List<Product> Test(List<int> pIds) {
            var products = this.storeContext.Products.Where(p => pIds.Contains(p.ProductId)).ToList();
            return products;
        }

        public Product CreateProduct(int sId,string adminName,string pName,double pBuyIn,double pSellOut,string pCategory,DateTime pExpirationDate,string pAmount)
        {
            Product product = Product.Create(adminName,pName,pBuyIn,pSellOut,pCategory,pExpirationDate,sId,pAmount);
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

        public Product UpdateProduct(int pId,string admin,string pName,double pBuyIn,double pSellOut,string pCategory,DateTime pExpirationDate,string pAmount)
        {
            var current = this.storeContext.Products.Find(pId);
            current.UpdateInfo(admin,pName,pBuyIn,pSellOut,pCategory,pExpirationDate,pAmount);
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
