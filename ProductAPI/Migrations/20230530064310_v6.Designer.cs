﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProductAPI.Entity;

#nullable disable

namespace ProductAPI.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230530064310_v6")]
    partial class v6
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ProductAPI.Entity.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductId"));

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProductId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("ProductAPI.Entity.ProductDetail", b =>
                {
                    b.Property<int>("ProductDetailId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductDetailId"));

                    b.Property<int>("ParentId")
                        .HasColumnType("int");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<string>("ProductPropertyName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<double>("SellPrice")
                        .HasColumnType("float");

                    b.HasKey("ProductDetailId");

                    b.ToTable("ProductDetails");
                });

            modelBuilder.Entity("ProductAPI.Entity.ProductDetailPropertyDetails", b =>
                {
                    b.Property<int>("ProductDetailPropertyDetailId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductDetailPropertyDetailId"));

                    b.Property<int?>("ProductDetailId")
                        .HasColumnType("int");

                    b.Property<int?>("ProductId")
                        .HasColumnType("int");

                    b.Property<int?>("PropertyDetailId")
                        .HasColumnType("int");

                    b.HasKey("ProductDetailPropertyDetailId");

                    b.HasIndex("ProductDetailId");

                    b.HasIndex("ProductId");

                    b.HasIndex("PropertyDetailId");

                    b.ToTable("ProductDetailPropertyDetails");
                });

            modelBuilder.Entity("ProductAPI.Entity.Properties", b =>
                {
                    b.Property<int>("PropertyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PropertyId"));

                    b.Property<int?>("ProductId")
                        .HasColumnType("int");

                    b.Property<string>("PropertyName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PropertySort")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PropertyId");

                    b.HasIndex("ProductId");

                    b.ToTable("Properties");
                });

            modelBuilder.Entity("ProductAPI.Entity.PropertyDetails", b =>
                {
                    b.Property<int>("PropertyDetailId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PropertyDetailId"));

                    b.Property<string>("PropertyDetailCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PropertyDetailName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PropertyId")
                        .HasColumnType("int");

                    b.HasKey("PropertyDetailId");

                    b.HasIndex("PropertyId");

                    b.ToTable("PropertyDetails");
                });

            modelBuilder.Entity("ProductAPI.Entity.ProductDetailPropertyDetails", b =>
                {
                    b.HasOne("ProductAPI.Entity.ProductDetail", "ProductDetails")
                        .WithMany("ProductDetailPropertyDetails")
                        .HasForeignKey("ProductDetailId");

                    b.HasOne("ProductAPI.Entity.Product", "Products")
                        .WithMany("ProductDetailPropertyDetails")
                        .HasForeignKey("ProductId");

                    b.HasOne("ProductAPI.Entity.PropertyDetails", "PropertyDetails")
                        .WithMany("ProductDetailPropertyDetails")
                        .HasForeignKey("PropertyDetailId");

                    b.Navigation("ProductDetails");

                    b.Navigation("Products");

                    b.Navigation("PropertyDetails");
                });

            modelBuilder.Entity("ProductAPI.Entity.Properties", b =>
                {
                    b.HasOne("ProductAPI.Entity.Product", "Products")
                        .WithMany("Properties")
                        .HasForeignKey("ProductId");

                    b.Navigation("Products");
                });

            modelBuilder.Entity("ProductAPI.Entity.PropertyDetails", b =>
                {
                    b.HasOne("ProductAPI.Entity.Properties", "Properties")
                        .WithMany()
                        .HasForeignKey("PropertyId");

                    b.Navigation("Properties");
                });

            modelBuilder.Entity("ProductAPI.Entity.Product", b =>
                {
                    b.Navigation("ProductDetailPropertyDetails");

                    b.Navigation("Properties");
                });

            modelBuilder.Entity("ProductAPI.Entity.ProductDetail", b =>
                {
                    b.Navigation("ProductDetailPropertyDetails");
                });

            modelBuilder.Entity("ProductAPI.Entity.PropertyDetails", b =>
                {
                    b.Navigation("ProductDetailPropertyDetails");
                });
#pragma warning restore 612, 618
        }
    }
}
