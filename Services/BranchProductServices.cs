using Microsoft.EntityFrameworkCore;
using Start_Up_Group.Entities;
using System;
using System.Collections.Generic;
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
            BranchProduct branchProduct = BranchProduct.Create(pId, bId, amount);

            storeContext.BranchProducts.Add(branchProduct);
            
            this.storeContext.SaveChanges();

            return branchProduct;
        }

        public List<BranchProduct> GetBranchProducts(int bId)
        {
            var branchProducts = this.storeContext.BranchProducts.Where(b => b.BranchId==bId).Include(p=>p.Product).ToList();
            return branchProducts;
        }

    }
}
