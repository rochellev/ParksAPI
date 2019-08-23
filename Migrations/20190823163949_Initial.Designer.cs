﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ParksAPI.Models;

namespace ParksAPI.Migrations
{
    [DbContext(typeof(ParksAPIContext))]
    [Migration("20190823163949_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("ParksAPI.Models.Park", b =>
                {
                    b.Property<int>("ParkId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("City");

                    b.Property<bool>("IsNational");

                    b.Property<string>("Name");

                    b.HasKey("ParkId");

                    b.ToTable("parks");
                });
#pragma warning restore 612, 618
        }
    }
}
