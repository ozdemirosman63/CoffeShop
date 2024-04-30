﻿// <auto-generated />
using CoffeeShop.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CoffeeShop.Migrations
{
    [DbContext(typeof(RepositoryContext))]
    [Migration("20231218172959_ChangeDataType")]
    partial class ChangeDataType
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("CoffeeShop.Models.Coffee", b =>
                {
                    b.Property<int>("CoffeeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CoffeeId"), 1L, 1);

                    b.Property<string>("Category")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CoffeeName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Count")
                        .HasColumnType("int");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.HasKey("CoffeeId");

                    b.ToTable("Coffees");
                });

            modelBuilder.Entity("CoffeeShop.Models.CoffeeMenu", b =>
                {
                    b.Property<int>("CoffeeMenuId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CoffeeMenuId"), 1L, 1);

                    b.Property<int>("CoffeeMenuCount")
                        .HasColumnType("int");

                    b.Property<string>("CoffeeMenuDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CoffeeMenuName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("CoffeeMenuPrice")
                        .HasColumnType("float");

                    b.Property<string>("CoffeeMenuUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CoffeeMenuId");

                    b.ToTable("CoffeeMenus");

                    b.HasData(
                        new
                        {
                            CoffeeMenuId = 1,
                            CoffeeMenuCount = 0,
                            CoffeeMenuDescription = "Espresso with lots of steamed milk and a light foam.",
                            CoffeeMenuName = "LATTE",
                            CoffeeMenuPrice = 17.5,
                            CoffeeMenuUrl = "/image/latte.jpg"
                        },
                        new
                        {
                            CoffeeMenuId = 2,
                            CoffeeMenuCount = 0,
                            CoffeeMenuDescription = "Intense and quickly brewed concentrated coffee",
                            CoffeeMenuName = "ESPRESSO",
                            CoffeeMenuPrice = 15.99,
                            CoffeeMenuUrl = "/image/espresso.jpg"
                        },
                        new
                        {
                            CoffeeMenuId = 3,
                            CoffeeMenuCount = 0,
                            CoffeeMenuDescription = "Espresso with steamed milk and a frothy layer.",
                            CoffeeMenuName = "CAPPUCINO",
                            CoffeeMenuPrice = 9.9900000000000002,
                            CoffeeMenuUrl = "/image/cappucino.jpg"
                        },
                        new
                        {
                            CoffeeMenuId = 4,
                            CoffeeMenuCount = 0,
                            CoffeeMenuDescription = "Espresso combined with steamed milk and chocolate.",
                            CoffeeMenuName = "MOCHA",
                            CoffeeMenuPrice = 10.75,
                            CoffeeMenuUrl = "/image/mocha.jpg"
                        },
                        new
                        {
                            CoffeeMenuId = 5,
                            CoffeeMenuCount = 0,
                            CoffeeMenuDescription = "Espresso stained with a dollop of frothy milk.",
                            CoffeeMenuName = "MACCHIATO",
                            CoffeeMenuPrice = 11.99,
                            CoffeeMenuUrl = "/image/macchiato.jpg"
                        },
                        new
                        {
                            CoffeeMenuId = 6,
                            CoffeeMenuCount = 0,
                            CoffeeMenuDescription = "A strong espresso diluted with hot water.",
                            CoffeeMenuName = "AMERICANO",
                            CoffeeMenuPrice = 12.5,
                            CoffeeMenuUrl = "/image/americano.jpg"
                        });
                });

            modelBuilder.Entity("CoffeeShop.Models.Login", b =>
                {
                    b.Property<int>("LoginID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LoginID"), 1L, 1);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("LoginID");

                    b.ToTable("Logins");
                });

            modelBuilder.Entity("CoffeeShop.Models.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OrderId"), 1L, 1);

                    b.Property<int>("OrderCount")
                        .HasColumnType("int");

                    b.Property<string>("OrderName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("OrderPrice")
                        .HasColumnType("float");

                    b.Property<string>("OrderUrl")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("OrderId");

                    b.ToTable("Orders");
                });
#pragma warning restore 612, 618
        }
    }
}
