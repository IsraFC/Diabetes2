﻿// <auto-generated />
using System;
using Diabetes2.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Diabetes2.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Diabetes2.Data.Entities.Education", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("EducationalModules")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MultimediaLinks")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Educations");
                });

            modelBuilder.Entity("Diabetes2.Data.Entities.Exercise", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("DurationInMinutes")
                        .HasColumnType("int");

                    b.Property<string>("ExerciseRoutines")
                        .IsRequired()
                        .HasMaxLength(400)
                        .HasColumnType("nvarchar(400)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Exercises");
                });

            modelBuilder.Entity("Diabetes2.Data.Entities.GlucoseMonitoring", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("FoodReport")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<float?>("GlucoseIn")
                        .IsRequired()
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.ToTable("GlucoseMonitorings");
                });

            modelBuilder.Entity("Diabetes2.Data.Entities.HealthcareP", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PatientId")
                        .HasColumnType("int");

                    b.Property<string>("profession")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("PatientId");

                    b.ToTable("HealthcarePs");
                });

            modelBuilder.Entity("Diabetes2.Data.Entities.MealPlanning", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("PMealPlans")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<string>("Recipes")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.HasKey("Id");

                    b.ToTable("MealPlannings");
                });

            modelBuilder.Entity("Diabetes2.Data.Entities.Patient", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("Age")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)");

                    b.Property<double?>("Height")
                        .IsRequired()
                        .HasColumnType("float");

                    b.Property<int>("MealPlanningId")
                        .HasColumnType("int");

                    b.Property<float?>("Weight")
                        .IsRequired()
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.HasIndex("MealPlanningId");

                    b.ToTable("Patients");
                });

            modelBuilder.Entity("Diabetes2.Data.Entities.Progress", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Graphics")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HealthStadistics")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PatientId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PatientId");

                    b.HasIndex("UserId");

                    b.ToTable("Progresses");
                });

            modelBuilder.Entity("Diabetes2.Data.Entities.ReminderAlert", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("HoraRecordatorio")
                        .HasColumnType("datetime2");

                    b.Property<string>("SeguimientoDieta")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("reminderAlerts");
                });

            modelBuilder.Entity("Diabetes2.Data.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Diabetes2.Data.Entities.Education", b =>
                {
                    b.HasOne("Diabetes2.Data.Entities.User", "User")
                        .WithMany("Educations")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Diabetes2.Data.Entities.Exercise", b =>
                {
                    b.HasOne("Diabetes2.Data.Entities.User", "User")
                        .WithMany("Exercises")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Diabetes2.Data.Entities.GlucoseMonitoring", b =>
                {
                    b.HasOne("Diabetes2.Data.Entities.Patient", "Patient")
                        .WithOne("GlucoseMonitorings")
                        .HasForeignKey("Diabetes2.Data.Entities.GlucoseMonitoring", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Patient");
                });

            modelBuilder.Entity("Diabetes2.Data.Entities.HealthcareP", b =>
                {
                    b.HasOne("Diabetes2.Data.Entities.Patient", "Patient")
                        .WithMany("HealthcarePs")
                        .HasForeignKey("PatientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Patient");
                });

            modelBuilder.Entity("Diabetes2.Data.Entities.Patient", b =>
                {
                    b.HasOne("Diabetes2.Data.Entities.MealPlanning", "MealPlanning")
                        .WithMany("Patients")
                        .HasForeignKey("MealPlanningId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MealPlanning");
                });

            modelBuilder.Entity("Diabetes2.Data.Entities.Progress", b =>
                {
                    b.HasOne("Diabetes2.Data.Entities.Patient", "Patient")
                        .WithMany("Progresses")
                        .HasForeignKey("PatientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Diabetes2.Data.Entities.User", "User")
                        .WithMany("Progresses")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Patient");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Diabetes2.Data.Entities.ReminderAlert", b =>
                {
                    b.HasOne("Diabetes2.Data.Entities.User", "User")
                        .WithMany("ReminderAlerts")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Diabetes2.Data.Entities.User", b =>
                {
                    b.HasOne("Diabetes2.Data.Entities.Patient", "Patient")
                        .WithOne("User")
                        .HasForeignKey("Diabetes2.Data.Entities.User", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Patient");
                });

            modelBuilder.Entity("Diabetes2.Data.Entities.MealPlanning", b =>
                {
                    b.Navigation("Patients");
                });

            modelBuilder.Entity("Diabetes2.Data.Entities.Patient", b =>
                {
                    b.Navigation("GlucoseMonitorings")
                        .IsRequired();

                    b.Navigation("HealthcarePs");

                    b.Navigation("Progresses");

                    b.Navigation("User")
                        .IsRequired();
                });

            modelBuilder.Entity("Diabetes2.Data.Entities.User", b =>
                {
                    b.Navigation("Educations");

                    b.Navigation("Exercises");

                    b.Navigation("Progresses");

                    b.Navigation("ReminderAlerts");
                });
#pragma warning restore 612, 618
        }
    }
}