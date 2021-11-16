using Microsoft.EntityFrameworkCore;
using Start_Up_Group.Entities;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace Start_Up_Group.Services
{
    public interface IBranchProduct
    {
        public BranchProduct CreateOrUpdateBranchProduct(int pId, int bId, int amount);

        public List<BranchProduct> GetBranchProducts(int bId);
    }
    public class BranchProductServices : IBranchProduct
    {
        private StoreContext storeContext;

        public BranchProductServices()
        {
            this.storeContext = new StoreContext();
        }

        public BranchProductServices(int pId,int bId)
        {
            
        }
        
        public BranchProduct CreateOrUpdateBranchProduct(int pId , int bId , int amount)
        {
            try
            {
                BranchProduct branchProduct = this.storeContext.BranchProducts.Where(b=>b.ProductId == pId).Where(b=>b.BranchId==bId).SingleOrDefault();
                if(branchProduct == null)
                {
                    Debug.WriteLine("Create new");
                    BranchProduct newBranchProduct = BranchProduct.Create(pId, bId, amount);

                    storeContext.BranchProducts.Add(newBranchProduct);

                    this.storeContext.SaveChanges();

                    return newBranchProduct;
                }
                else
                {
                    int newAmount = branchProduct.Amount + amount;
                    Debug.WriteLine("Update"+newAmount+ "Info" + branchProduct.Amount);
                    branchProduct.UpdateInfo(amount);
                    this.storeContext.SaveChanges();
                    return branchProduct;
                }
            }
            catch (Exception error)
            {
                Debug.WriteLine(error);
                throw new Exception();
            }
        }

        public List<BranchProduct> GetBranchProducts(int bId)
        {
            var branchProducts = this.storeContext.BranchProducts.Where(b => b.BranchId==bId).Include(p=>p.Product).ToList();
            return branchProducts;
        }

    }
}
