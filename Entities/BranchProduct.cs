using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Start_Up_Group.Entities
{
    public class BranchProduct
    {
        [Key]
        public int BranchProductId { get; set; }

        [ForeignKey("Product")]
        public int ProductId { get; set; }
        public virtual ICollection<Product> Products { get; set; }

        public int BranchId { get; set; }
        public virtual Branch Branch { get; set; }

        public int Amount { get; set; }

        public static BranchProduct Create(int pId, int bId,int pbAmount)
        {
            BranchProduct branchProduct = new BranchProduct();
            branchProduct.Amount = pbAmount;
            branchProduct.BranchId = bId;
            branchProduct.ProductId = pId;

            return branchProduct;
        }
    }
}
