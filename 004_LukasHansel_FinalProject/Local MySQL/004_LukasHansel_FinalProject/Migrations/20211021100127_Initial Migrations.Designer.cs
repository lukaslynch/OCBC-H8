﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using _004_LukasHansel_FinalProject.Data;

namespace _004_LukasHansel_FinalProject.Migrations
{
    [DbContext(typeof(ApiDbContext))]
    [Migration("20211021100127_Initial Migrations")]
    partial class InitialMigrations
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.11");

            modelBuilder.Entity("_004_LukasHansel_FinalProject.Models.ItemData", b =>
                {
                    b.Property<int>("paymentDetailId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("cardNumber")
                        .HasColumnType("text");

                    b.Property<string>("cardOwnerName")
                        .HasColumnType("text");

                    b.Property<string>("expirationDate")
                        .HasColumnType("text");

                    b.Property<string>("securityCode")
                        .HasColumnType("text");

                    b.HasKey("paymentDetailId");

                    b.ToTable("paymentdetail");
                });
#pragma warning restore 612, 618
        }
    }
}
