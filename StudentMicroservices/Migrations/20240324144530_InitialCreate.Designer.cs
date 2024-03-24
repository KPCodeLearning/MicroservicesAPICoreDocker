﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StudentMicroservices.DBContext;

namespace StudentMicroservices.Migrations
{
    [DbContext(typeof(StudentContext))]
    [Migration("20240324144530_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("StudentMicroservices.Models.StudentID", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("StudentID");

                    b.HasDiscriminator<string>("Discriminator").HasValue("StudentID");
                });

            modelBuilder.Entity("StudentMicroservices.Models.Student", b =>
                {
                    b.HasBaseType("StudentMicroservices.Models.StudentID");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<int>("Class")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Roll")
                        .HasColumnType("int");

                    b.Property<string>("Section")
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("Student");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Age = 30,
                            Class = 34,
                            Name = "K P and team",
                            Roll = 234,
                            Section = ".NET Core API"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}