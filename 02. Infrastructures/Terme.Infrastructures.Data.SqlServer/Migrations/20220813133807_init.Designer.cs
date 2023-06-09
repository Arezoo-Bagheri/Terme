﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Terme.Infrastructures.Data.SqlServer;

#nullable disable

namespace Terme.Infrastructures.Data.SqlServer.Migrations
{
    [DbContext(typeof(TermeDbContext))]
    [Migration("20220813133807_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Terme.Core.Domain.Categories.Entities.Category", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<long?>("ParentId")
                        .HasColumnType("bigint");

                    b.Property<long>("PhotoId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("ParentId");

                    b.HasIndex("PhotoId")
                        .IsUnique();

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("Terme.Core.Domain.Customers.Entities.Customer", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("NationalCode")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("Id");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("Terme.Core.Domain.Customers.Entities.CustomerContact", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<string>("Address")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("City")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<long>("CustomerId")
                        .HasColumnType("bigint");

                    b.Property<string>("Phone")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Provience")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.ToTable("CustomerContacts");
                });

            modelBuilder.Entity("Terme.Core.Domain.Customers.Entities.Payment", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<long>("CustomerId")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("PaymentDate")
                        .HasColumnType("datetime2");

                    b.Property<long>("PaymentValue")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.ToTable("Payments");
                });

            modelBuilder.Entity("Terme.Core.Domain.Masters.Entities.Master", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("MembershipDate")
                        .HasColumnType("datetime2");

                    b.Property<long>("PhotoId")
                        .HasColumnType("bigint");

                    b.Property<string>("ShortDescription")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.ToTable("Masters");
                });

            modelBuilder.Entity("Terme.Core.Domain.Masters.Entities.MasterProduct", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<long>("CategoryId")
                        .HasColumnType("bigint");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("Discount")
                        .HasColumnType("bigint");

                    b.Property<long>("MasterId")
                        .HasColumnType("bigint");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<long>("Price")
                        .HasColumnType("bigint");

                    b.Property<string>("ShortDescription")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("MasterId");

                    b.ToTable("MasterProducts");
                });

            modelBuilder.Entity("Terme.Core.Domain.Masters.Entities.MasterProductPhoto", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<long>("MasterProductsId")
                        .HasColumnType("bigint");

                    b.Property<long>("PhotoId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("MasterProductsId");

                    b.HasIndex("PhotoId");

                    b.ToTable("MasterProductPhotos");
                });

            modelBuilder.Entity("Terme.Core.Domain.Orders.Entities.Order", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<long>("CustomerId")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("OrderStatus")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("Terme.Core.Domain.Orders.Entities.OrderLine", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<int>("Count")
                        .HasColumnType("int");

                    b.Property<long>("Discount")
                        .HasColumnType("bigint");

                    b.Property<long?>("MasterProductId")
                        .HasColumnType("bigint");

                    b.Property<long>("MasterProductsId")
                        .HasColumnType("bigint");

                    b.Property<long>("OrderId")
                        .HasColumnType("bigint");

                    b.Property<long>("Price")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("MasterProductId");

                    b.HasIndex("OrderId");

                    b.ToTable("OrderLines");
                });

            modelBuilder.Entity("Terme.Core.Domain.Photos.Entities.Photo", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<long?>("PhotoId")
                        .HasColumnType("bigint");

                    b.Property<int>("Size")
                        .HasColumnType("int");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(1000)");

                    b.HasKey("Id");

                    b.HasIndex("PhotoId")
                        .IsUnique()
                        .HasFilter("[PhotoId] IS NOT NULL");

                    b.ToTable("Photos");
                });

            modelBuilder.Entity("Terme.Core.Domain.Categories.Entities.Category", b =>
                {
                    b.HasOne("Terme.Core.Domain.Categories.Entities.Category", "Parent")
                        .WithMany("Children")
                        .HasForeignKey("ParentId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Terme.Core.Domain.Photos.Entities.Photo", "Photo")
                        .WithOne()
                        .HasForeignKey("Terme.Core.Domain.Categories.Entities.Category", "PhotoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Parent");

                    b.Navigation("Photo");
                });

            modelBuilder.Entity("Terme.Core.Domain.Customers.Entities.CustomerContact", b =>
                {
                    b.HasOne("Terme.Core.Domain.Customers.Entities.Customer", "Customer")
                        .WithMany("CustomerContacts")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("Terme.Core.Domain.Customers.Entities.Payment", b =>
                {
                    b.HasOne("Terme.Core.Domain.Customers.Entities.Customer", "Customer")
                        .WithMany("Payments")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("Terme.Core.Domain.Masters.Entities.MasterProduct", b =>
                {
                    b.HasOne("Terme.Core.Domain.Categories.Entities.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Terme.Core.Domain.Masters.Entities.Master", "Master")
                        .WithMany()
                        .HasForeignKey("MasterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Master");
                });

            modelBuilder.Entity("Terme.Core.Domain.Masters.Entities.MasterProductPhoto", b =>
                {
                    b.HasOne("Terme.Core.Domain.Masters.Entities.MasterProduct", "MasterProducts")
                        .WithMany()
                        .HasForeignKey("MasterProductsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Terme.Core.Domain.Photos.Entities.Photo", "Photo")
                        .WithMany()
                        .HasForeignKey("PhotoId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("MasterProducts");

                    b.Navigation("Photo");
                });

            modelBuilder.Entity("Terme.Core.Domain.Orders.Entities.Order", b =>
                {
                    b.HasOne("Terme.Core.Domain.Customers.Entities.Customer", "Customer")
                        .WithMany("Orders")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("Terme.Core.Domain.Orders.Entities.OrderLine", b =>
                {
                    b.HasOne("Terme.Core.Domain.Masters.Entities.MasterProduct", "MasterProduct")
                        .WithMany()
                        .HasForeignKey("MasterProductId");

                    b.HasOne("Terme.Core.Domain.Orders.Entities.Order", "Order")
                        .WithMany()
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MasterProduct");

                    b.Navigation("Order");
                });

            modelBuilder.Entity("Terme.Core.Domain.Photos.Entities.Photo", b =>
                {
                    b.HasOne("Terme.Core.Domain.Masters.Entities.Master", null)
                        .WithOne("Photo")
                        .HasForeignKey("Terme.Core.Domain.Photos.Entities.Photo", "PhotoId");
                });

            modelBuilder.Entity("Terme.Core.Domain.Categories.Entities.Category", b =>
                {
                    b.Navigation("Children");
                });

            modelBuilder.Entity("Terme.Core.Domain.Customers.Entities.Customer", b =>
                {
                    b.Navigation("CustomerContacts");

                    b.Navigation("Orders");

                    b.Navigation("Payments");
                });

            modelBuilder.Entity("Terme.Core.Domain.Masters.Entities.Master", b =>
                {
                    b.Navigation("Photo");
                });
#pragma warning restore 612, 618
        }
    }
}
