﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProductsAndCategories.Models;

#nullable disable

namespace ProductsAndCategories.Migrations
{
    [DbContext(typeof(MyContext))]
    [Migration("20230831230716_FirstMigration")]
    partial class FirstMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("ProductsAndCategories.Models.Association", b =>
                {
                    b.Property<int>("AssociationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("CategoriesCategoryId")
                        .HasColumnType("int");

                    b.Property<int>("Category")
                        .HasColumnType("int");

                    b.Property<int>("Product")
                        .HasColumnType("int");

                    b.Property<int?>("ProductsProductId")
                        .HasColumnType("int");

                    b.HasKey("AssociationId");

                    b.HasIndex("CategoriesCategoryId");

                    b.HasIndex("ProductsProductId");

                    b.ToTable("Associations");
                });

            modelBuilder.Entity("ProductsAndCategories.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime(6)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("ProductsAndCategories.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<double>("Price")
                        .HasColumnType("double");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime(6)");

                    b.HasKey("ProductId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("ProductsAndCategories.Models.Association", b =>
                {
                    b.HasOne("ProductsAndCategories.Models.Category", "Categories")
                        .WithMany("Prod")
                        .HasForeignKey("CategoriesCategoryId");

                    b.HasOne("ProductsAndCategories.Models.Product", "Products")
                        .WithMany("Cats")
                        .HasForeignKey("ProductsProductId");

                    b.Navigation("Categories");

                    b.Navigation("Products");
                });

            modelBuilder.Entity("ProductsAndCategories.Models.Category", b =>
                {
                    b.Navigation("Prod");
                });

            modelBuilder.Entity("ProductsAndCategories.Models.Product", b =>
                {
                    b.Navigation("Cats");
                });
#pragma warning restore 612, 618
        }
    }
}
