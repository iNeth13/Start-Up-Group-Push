using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Start_Up_Group.Entities
{
    public class Product : BaseEntity
    {
        [Key]
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public double ProductBuyIn_Price { get; set; }
        public double ProductSellOut_Price { get; set; }
        public bool Is_Delete { get; set; }
        public string ProductCategory { get; set; }
        public DateTime ProductExpirationDate { get; set; }
        //relationship with Supplier
        public int SupplierId { get; set; }
        public virtual Supplier Supplier { get; set; }

        public static Product Create(string adminName,string pName,double pBuyIn_Price,double pSellOut_price,string pCategory,DateTime pExpirationDate,int sId)
        {
            
            Product product = new Product();
            product.CreateInfo(adminName,pName,pBuyIn_Price,pSellOut_price,pCategory,pExpirationDate,sId);

            return product;
        }

        public void CreateInfo(string adminName,string pName, double pBuyIn_Price, double pSellOut_price, string pCategory, DateTime pExpirationDate, int sId)
        {
            base.CreateInfo(adminName);
            this.ProductName = pName;
            this.ProductSellOut_Price = pSellOut_price;
            this.ProductBuyIn_Price = pBuyIn_Price;
            this.ProductCategory = pCategory;
            this.ProductExpirationDate = pExpirationDate;
            this.SupplierId = sId;
            this.Is_Delete = false;
        }

        public void UpdateInfo(string admin,string pName, double pBuyIn_Price, double pSellOut_price, string pCategory, DateTime pExpirationDate)
        {
            base.UpdatedInfo(admin);
            this.ProductName = pName;
            this.ProductBuyIn_Price = pBuyIn_Price;
            this.ProductSellOut_Price = pSellOut_price;
            this.ProductCategory = pCategory;
            this.ProductExpirationDate = pExpirationDate;
        }

        public new void DeleteInfo(string adminName)
        {
            base.DeleteInfo(adminName);
            this.Is_Delete = true;
        }
    }
}
