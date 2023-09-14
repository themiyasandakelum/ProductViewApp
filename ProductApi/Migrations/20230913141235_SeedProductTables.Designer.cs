﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProductApi.Database;

#nullable disable

namespace ProductApi.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230913141235_SeedProductTables")]
    partial class SeedProductTables
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0-rc.1.23419.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ProductApi.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductId"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<double>("LowestPrice")
                        .HasColumnType("float");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("RetailPrice")
                        .HasColumnType("float");

                    b.Property<string>("SKU")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("SalePrice")
                        .HasColumnType("float");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("ProductId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            CreatedDate = new DateTime(2023, 9, 13, 19, 42, 34, 795, DateTimeKind.Local).AddTicks(6798),
                            LowestPrice = 50.0,
                            ProductName = "apple",
                            RetailPrice = 20.0,
                            SKU = "abcd123",
                            SalePrice = 30.0,
                            Status = 1
                        },
                        new
                        {
                            ProductId = 2,
                            CreatedDate = new DateTime(2023, 9, 13, 19, 42, 34, 795, DateTimeKind.Local).AddTicks(6843),
                            LowestPrice = 50.0,
                            ProductName = "samsung",
                            RetailPrice = 20.0,
                            SKU = "abcd124",
                            SalePrice = 30.0,
                            Status = 1
                        });
                });
#pragma warning restore 612, 618
        }
    }
}