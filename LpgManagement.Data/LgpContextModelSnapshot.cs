﻿// <auto-generated />
using System;
using LpgManagement.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LpgManagement.Data.Migrations
{
    [DbContext(typeof(LgpContext))]
    partial class LgpContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("LpgManagement.Data.Entity.Brand", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Desc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ModifyEntity")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(35)")
                        .HasMaxLength(35);

                    b.HasKey("Id");

                    b.ToTable("Brands");
                });

            modelBuilder.Entity("LpgManagement.Data.Entity.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Desc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ModifyEntity")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categorys");
                });

            modelBuilder.Entity("LpgManagement.Data.Entity.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ModifyEntity")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Provice")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("LpgManagement.Data.Entity.LpgCylinder", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("BrandId")
                        .HasColumnType("int");

                    b.Property<string>("Desc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ModifyEntity")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Size")
                        .HasColumnType("int");

                    b.Property<float>("Weight")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.HasIndex("BrandId");

                    b.ToTable("LpgCylinders");
                });

            modelBuilder.Entity("LpgManagement.Data.Entity.LpgCylinderStock", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CategoryId")
                        .HasColumnType("int");

                    b.Property<int?>("LpgCylinderId")
                        .HasColumnType("int");

                    b.Property<DateTime>("ModifyEntity")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Quantity")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("StockDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("StockNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("SupplierId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("LpgCylinderId");

                    b.HasIndex("SupplierId");

                    b.ToTable("LpgCylinderStocks");
                });

            modelBuilder.Entity("LpgManagement.Data.Entity.Supplier", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ModifyEntity")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Provice")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SupllierType")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Suppliers");
                });

            modelBuilder.Entity("LpgManagement.Data.Entity.LpgCylinder", b =>
                {
                    b.HasOne("LpgManagement.Data.Entity.Brand", "Brand")
                        .WithMany()
                        .HasForeignKey("BrandId");
                });

            modelBuilder.Entity("LpgManagement.Data.Entity.LpgCylinderStock", b =>
                {
                    b.HasOne("LpgManagement.Data.Entity.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId");

                    b.HasOne("LpgManagement.Data.Entity.LpgCylinder", "LpgCylinder")
                        .WithMany()
                        .HasForeignKey("LpgCylinderId");

                    b.HasOne("LpgManagement.Data.Entity.Supplier", "Supplier")
                        .WithMany()
                        .HasForeignKey("SupplierId");
                });
#pragma warning restore 612, 618
        }
    }
}
