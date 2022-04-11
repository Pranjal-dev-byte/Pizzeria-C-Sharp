﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using PizzeriaApp.Data;

namespace PizzeriaBackend.Migrations
{
    [DbContext(typeof(PizzeriaDbContext))]
    [Migration("20220319092730_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.15")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("PizzeriaApp.Data.CartItem", b =>
                {
                    b.Property<int>("CartItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int?>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("CartItemId");

                    b.HasIndex("UserId");

                    b.ToTable("CartItem");
                });

            modelBuilder.Entity("PizzeriaApp.Data.Ingredients", b =>
                {
                    b.Property<int>("IngredientsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int?>("CartItemId")
                        .HasColumnType("integer");

                    b.Property<string>("Img")
                        .HasColumnType("text");

                    b.Property<int>("Price")
                        .HasColumnType("integer");

                    b.Property<string>("Type")
                        .HasColumnType("text");

                    b.HasKey("IngredientsId");

                    b.HasIndex("CartItemId");

                    b.ToTable("Ingredients");
                });

            modelBuilder.Entity("PizzeriaApp.Data.Pizza", b =>
                {
                    b.Property<int>("PizzaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int?>("CartItemId")
                        .HasColumnType("integer");

                    b.Property<string>("Desc")
                        .HasColumnType("text");

                    b.Property<string>("Img")
                        .HasColumnType("text");

                    b.Property<string>("Ingredients")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<int>("Price")
                        .HasColumnType("integer");

                    b.Property<string>("Toppings")
                        .HasColumnType("text");

                    b.Property<string>("Type")
                        .HasColumnType("text");

                    b.HasKey("PizzaId");

                    b.HasIndex("CartItemId");

                    b.ToTable("Pizza");
                });

            modelBuilder.Entity("PizzeriaApp.Data.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<string>("Password")
                        .HasColumnType("text");

                    b.Property<string>("Token")
                        .HasColumnType("text");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("UserId");

                    b.ToTable("User");
                });

            modelBuilder.Entity("PizzeriaApp.Data.CartItem", b =>
                {
                    b.HasOne("PizzeriaApp.Data.User", null)
                        .WithMany("Cart")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("PizzeriaApp.Data.Ingredients", b =>
                {
                    b.HasOne("PizzeriaApp.Data.CartItem", null)
                        .WithMany("PizzaIngredients")
                        .HasForeignKey("CartItemId");
                });

            modelBuilder.Entity("PizzeriaApp.Data.Pizza", b =>
                {
                    b.HasOne("PizzeriaApp.Data.CartItem", null)
                        .WithMany("PizzaOption")
                        .HasForeignKey("CartItemId");
                });

            modelBuilder.Entity("PizzeriaApp.Data.CartItem", b =>
                {
                    b.Navigation("PizzaIngredients");

                    b.Navigation("PizzaOption");
                });

            modelBuilder.Entity("PizzeriaApp.Data.User", b =>
                {
                    b.Navigation("Cart");
                });
#pragma warning restore 612, 618
        }
    }
}