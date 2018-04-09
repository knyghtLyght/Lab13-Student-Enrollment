﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using StudentEnrolment.Data;
using StudentEnrolment.Models;
using System;

namespace StudentEnrolment.Migrations
{
    [DbContext(typeof(StudentEnrolmentDbContext))]
    partial class StudentEnrolmentDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.2-rtm-10011")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("StudentEnrolment.Models.Course", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Element");

                    b.Property<string>("Name");

                    b.HasKey("ID");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("StudentEnrolment.Models.Student", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("CourseID");

                    b.Property<string>("Name");

                    b.HasKey("ID");

                    b.HasIndex("CourseID");

                    b.ToTable("Student");
                });

            modelBuilder.Entity("StudentEnrolment.Models.Student", b =>
                {
                    b.HasOne("StudentEnrolment.Models.Course", "Course")
                        .WithMany()
                        .HasForeignKey("CourseID");
                });
#pragma warning restore 612, 618
        }
    }
}
