using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Start_Up_Group.Entities
{
    public class Branch : BaseEntityWithInfo
    {
        [Key]
        public int BranchId { get; set; }
        public DateTime Open_date { get; set; }
        public bool Is_delete { get; set; }
        public double Total_Income { get; set; }
        public int ManagerId { get; set; }
        public virtual Manager Manager { get; set; }

        public int BranchProductId { get; set; }
        public virtual ICollection<BranchProduct> BranchProducts { get; set; }


        //create new branch
        public static Branch CreateBranch(DateTime open_date,string name ,string address,string contact ,string adminName,int managerId)
        {
            var branch = new Branch();
            branch.CreatedInfo(name ,address,contact,adminName);
            branch.Open_date = open_date;
            branch.Total_Income = 0;
            branch.Is_delete = false;
            branch.ManagerId = managerId;
  
            return branch;
        }

        public void UpdateInfo(string branchName,string branchAddress,string branchContact,DateTime openDate,string adminName)
        {
            base.UpdateInfo(branchName,branchAddress,branchContact,adminName);
            this.Open_date = openDate;
            this.Total_Income = 1000;

        }

        public void DeleteInfo(string adminName)
        {
            base.DeleteInfo(adminName);
            this.Is_delete = true;
        }
    }
}
