﻿// <auto-generated />
using System;
using HospitalManagement.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HospitalManagement.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("HospitalManagement.Models.Appointment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("AppointmentDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("AppointmentTypeId")
                        .HasColumnType("int");

                    b.Property<int?>("AppointmentTypeId1")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DoctorUsername")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("PatientHSN")
                        .HasColumnType("int");

                    b.Property<int?>("PatientHSN1")
                        .HasColumnType("int");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("AppointmentTypeId");

                    b.HasIndex("AppointmentTypeId1");

                    b.HasIndex("DoctorUsername");

                    b.HasIndex("PatientHSN");

                    b.HasIndex("PatientHSN1");

                    b.HasIndex("Username");

                    b.ToTable("Appointments");
                });

            modelBuilder.Entity("HospitalManagement.Models.AppointmentType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("AppointmentTypes");
                });

            modelBuilder.Entity("HospitalManagement.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("HospitalManagement.Models.Patient", b =>
                {
                    b.Property<int>("HSN")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("HSN"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DoctorUsername")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Postal")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("HSN");

                    b.HasIndex("DoctorUsername");

                    b.HasIndex("Username");

                    b.ToTable("Patients");
                });

            modelBuilder.Entity("HospitalManagement.Models.Tasks", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DoctorUsername")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PatientId")
                        .HasColumnType("int");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("DoctorUsername");

                    b.HasIndex("PatientId");

                    b.HasIndex("Username");

                    b.ToTable("Tasks");
                });

            modelBuilder.Entity("HospitalManagement.Models.User", b =>
                {
                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserLevelId")
                        .HasColumnType("int");

                    b.HasKey("Username");

                    b.HasIndex("UserLevelId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("HospitalManagement.Models.UserLevel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Level")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("UserLevels");
                });

            modelBuilder.Entity("HospitalManagement.Models.Appointment", b =>
                {
                    b.HasOne("HospitalManagement.Models.AppointmentType", "AppointmentType")
                        .WithMany()
                        .HasForeignKey("AppointmentTypeId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("HospitalManagement.Models.AppointmentType", null)
                        .WithMany("Appointments")
                        .HasForeignKey("AppointmentTypeId1");

                    b.HasOne("HospitalManagement.Models.User", "Doctor")
                        .WithMany()
                        .HasForeignKey("DoctorUsername")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HospitalManagement.Models.Patient", "Patient")
                        .WithMany()
                        .HasForeignKey("PatientHSN")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("HospitalManagement.Models.Patient", null)
                        .WithMany("Appointments")
                        .HasForeignKey("PatientHSN1");

                    b.HasOne("HospitalManagement.Models.User", null)
                        .WithMany("Appointments")
                        .HasForeignKey("Username");

                    b.Navigation("AppointmentType");

                    b.Navigation("Doctor");

                    b.Navigation("Patient");
                });

            modelBuilder.Entity("HospitalManagement.Models.Patient", b =>
                {
                    b.HasOne("HospitalManagement.Models.User", "Doctor")
                        .WithMany()
                        .HasForeignKey("DoctorUsername")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HospitalManagement.Models.User", null)
                        .WithMany("Patients")
                        .HasForeignKey("Username");

                    b.Navigation("Doctor");
                });

            modelBuilder.Entity("HospitalManagement.Models.Tasks", b =>
                {
                    b.HasOne("HospitalManagement.Models.Category", "Category")
                        .WithMany("Tasks")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HospitalManagement.Models.User", "Doctor")
                        .WithMany()
                        .HasForeignKey("DoctorUsername")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("HospitalManagement.Models.Patient", "Patient")
                        .WithMany("Tasks")
                        .HasForeignKey("PatientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HospitalManagement.Models.User", null)
                        .WithMany("Tasks")
                        .HasForeignKey("Username");

                    b.Navigation("Category");

                    b.Navigation("Doctor");

                    b.Navigation("Patient");
                });

            modelBuilder.Entity("HospitalManagement.Models.User", b =>
                {
                    b.HasOne("HospitalManagement.Models.UserLevel", "UserLevel")
                        .WithMany()
                        .HasForeignKey("UserLevelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("UserLevel");
                });

            modelBuilder.Entity("HospitalManagement.Models.AppointmentType", b =>
                {
                    b.Navigation("Appointments");
                });

            modelBuilder.Entity("HospitalManagement.Models.Category", b =>
                {
                    b.Navigation("Tasks");
                });

            modelBuilder.Entity("HospitalManagement.Models.Patient", b =>
                {
                    b.Navigation("Appointments");

                    b.Navigation("Tasks");
                });

            modelBuilder.Entity("HospitalManagement.Models.User", b =>
                {
                    b.Navigation("Appointments");

                    b.Navigation("Patients");

                    b.Navigation("Tasks");
                });
#pragma warning restore 612, 618
        }
    }
}
