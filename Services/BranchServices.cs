﻿using Microsoft.EntityFrameworkCore;
using Start_Up_Group.Entities;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace Start_Up_Group.Services
{
    public interface IBranchServices
    {
        public Branch CreateNewBranch(string BranchName,string BranchAddress,string BranchContact,DateTime BranchOpenDate,string adminName,int managerId);
        public Branch UpdateBranch(int id,string branchName,string branchAddress,string branchContact,DateTime openSince,string adminName);
        public bool DeleteBranch(int id,string adminName);
        public Branch GetBranchDetailWithManager(int id);
        public List<Branch> GetBranches(string searchValue);
    }

    public class BranchServices : IBranchServices
    {
        private StoreContext context;

        public BranchServices()
        {
            this.context = new StoreContext();
        }

        public Branch CreateNewBranch(string name, string address, string contact, DateTime open_date,string adminName,int managerId)
        {
            var branch = Branch.CreateBranch(open_date,name,address ,contact,adminName,managerId);
            var manager = context.Managers.Find(managerId);
            context.Branches.Add(branch);
            context.SaveChanges();

            manager.Branches.Add(branch);
            context.SaveChanges();

            return branch;
        }

        public Branch UpdateBranch(int id,string branchName,string branchAddress, string branchContact,DateTime openSince,string adminName)
        {
            var currentBranch = context.Branches.Find(id);
            if (currentBranch == null)
            {
                throw new Exception(string.Format("Branch Not Found"));   
            }
            currentBranch.UpdateInfo(branchName,branchAddress,branchContact,openSince,adminName);
            
            context.Entry(currentBranch).State = EntityState.Modified;
            context.SaveChanges();
            return currentBranch;
        }

        public bool DeleteBranch(int id,string adminName)
        {
            var current = context.Branches.Find(id);
            if(current == null)
            {
                throw new Exception(String.Format("Branch Not Found,delete"));
            }
            current.DeleteInfo(adminName);
            context.Entry(current).State = EntityState.Modified;
            context.SaveChanges();
            return true;
        }

        public Branch GetBranchDetailWithManager(int id)
        {
          
                Branch branch = context.Branches.Where(b => b.BranchId == id).Where(b => b.Is_delete == false).Include("Manager").Single();
                return branch;
        }

        public List<Branch> GetBranches(string searchValue)
        {
            var result = this.context.Branches.Where(b => b.Name.Contains(searchValue)).Where(b=>b.Is_delete == false).ToList();

            return result;
        }
    }
}
