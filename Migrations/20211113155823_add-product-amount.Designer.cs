﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Start_Up_Group;

namespace Start_Up_Group.Migrations
{
    [DbContext(typeof(StoreContext))]
    [Migration("20211113155823_add-product-amount")]
    partial class addproductamount
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.11");

            modelBuilder.Entity("Start_Up_Group.Entities.Admin", b =>
                {
                    b.Property<int>("AdminId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<bool>("Is_delete")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.Property<string>("Password")
                        .HasColumnType("longtext");

                    b.Property<string>("Position")
                        .HasColumnType("longtext");

                    b.Property<string>("Username")
                        .HasColumnType("longtext");

                    b.HasKey("AdminId");

                    b.ToTable("Admins");
                });

            modelBuilder.Entity("Start_Up_Group.Entities.Branch", b =>
                {
                    b.Property<int>("BranchId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .HasColumnType("longtext");

                    b.Property<string>("Contact")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("Created_at")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Created_by")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("Deleted_at")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Deleted_by")
                        .HasColumnType("longtext");

                    b.Property<bool>("Is_delete")
                        .HasColumnType("tinyint(1)");

                    b.Property<int>("ManagerId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("Open_date")
                        .HasColumnType("datetime(6)");

                    b.Property<double>("Total_Income")
                        .HasColumnType("double");

                    b.Property<DateTime>("Updated_at")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Updated_by")
                        .HasColumnType("longtext");

                    b.HasKey("BranchId");

                    b.HasIndex("ManagerId");

                    b.ToTable("Branches");
                });

            modelBuilder.Entity("Start_Up_Group.Entities.Manager", b =>
                {
                    b.Property<int>("ManagerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .HasColumnType("longtext");

                    b.Property<int>("BranchId")
                        .HasColumnType("int");

                    b.Property<string>("Contact")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("Created_at")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Created_by")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("Deleted_at")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Deleted_by")
                        .HasColumnType("longtext");

                    b.Property<string>("Email")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("Hired_date")
                        .HasColumnType("datetime(6)");

                    b.Property<bool>("Is_deleted")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.Property<double>("Salary")
                        .HasColumnType("double");

                    b.Property<DateTime>("Updated_at")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Updated_by")
                        .HasColumnType("longtext");

                    b.HasKey("ManagerId");

                    b.ToTable("Managers");
                });

            modelBuilder.Entity("Start_Up_Group.Entities.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("Created_at")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Created_by")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("Deleted_at")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Deleted_by")
                        .HasColumnType("longtext");

                    b.Property<bool>("Is_Delete")
                        .HasColumnType("tinyint(1)");

                    b.Property<int>("ProductAmount")
                        .HasColumnType("int");

                    b.Property<double>("ProductBuyIn_Price")
                        .HasColumnType("double");

                    b.Property<string>("ProductCategory")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("ProductExpirationDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("ProductName")
                        .HasColumnType("longtext");

                    b.Property<double>("ProductSellOut_Price")
                        .HasColumnType("double");

                    b.Property<int>("SupplierId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Updated_at")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Updated_by")
                        .HasColumnType("longtext");

                    b.HasKey("ProductId");

                    b.HasIndex("SupplierId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("Start_Up_Group.Entities.Supplier", b =>
                {
                    b.Property<int>("SupplierId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .HasColumnType("longtext");

                    b.Property<string>("Contact")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("Created_at")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Created_by")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("Deleted_at")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Deleted_by")
                        .HasColumnType("longtext");

                    b.Property<bool>("Is_Delete")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("Supply_Since")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Type")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("Updated_at")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Updated_by")
                        .HasColumnType("longtext");

                    b.HasKey("SupplierId");

                    b.ToTable("Suppliers");
                });

            modelBuilder.Entity("Start_Up_Group.Entities.Branch", b =>
                {
                    b.HasOne("Start_Up_Group.Entities.Manager", "Manager")
                        .WithMany("Branches")
                        .HasForeignKey("ManagerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Manager");
                });

            modelBuilder.Entity("Start_Up_Group.Entities.Product", b =>
                {
                    b.HasOne("Start_Up_Group.Entities.Supplier", "Supplier")
                        .WithMany("Products")
                        .HasForeignKey("SupplierId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Supplier");
                });

            modelBuilder.Entity("Start_Up_Group.Entities.Manager", b =>
                {
                    b.Navigation("Branches");
                });

            modelBuilder.Entity("Start_Up_Group.Entities.Supplier", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
