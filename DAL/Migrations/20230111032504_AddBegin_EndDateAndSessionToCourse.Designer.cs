﻿// <auto-generated />
using System;
using DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DAL.Migrations
{
    [DbContext(typeof(RepositoryContext))]
    [Migration("20230111032504_AddBegin_EndDateAndSessionToCourse")]
    partial class AddBegin_EndDateAndSessionToCourse
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("DAL.Aggregates.Block", b =>
                {
                    b.Property<Guid?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("id");

                    b.Property<Guid?>("CourseId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("course_id");

                    b.Property<string>("MarkdownDocument")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("markdown_document");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("block_name");

                    b.HasKey("Id");

                    b.ToTable("block");
                });

            modelBuilder.Entity("DAL.Aggregates.Course", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("id");

                    b.Property<DateTime?>("BeginDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("begin_date");

                    b.Property<string>("Coursecode")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("course_code");

                    b.Property<string>("Coursename")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("coursename");

                    b.Property<DateTime?>("EndDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("end_date");

                    b.Property<Guid?>("LecturerId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("lecture_id");

                    b.Property<bool?>("Session")
                        .HasColumnType("bit")
                        .HasColumnName("session");

                    b.HasKey("Id");

                    b.ToTable("course");
                });

            modelBuilder.Entity("DAL.Aggregates.CourseUser", b =>
                {
                    b.Property<Guid?>("CourseId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("course_ref");

                    b.Property<Guid?>("UserId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("user_ref");

                    b.HasKey("CourseId", "UserId");

                    b.ToTable("course_user");
                });

            modelBuilder.Entity("DAL.Aggregates.MarkdownDocument", b =>
                {
                    b.Property<Guid?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("id");

                    b.Property<Guid?>("BlockId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("block_id");

                    b.Property<string>("Markdown")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("markdown");

                    b.HasKey("Id");

                    b.ToTable("markdown_document");
                });

            modelBuilder.Entity("DAL.Aggregates.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("id");

                    b.Property<string>("Avatar")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("avatar");

                    b.Property<DateTime?>("DateOfBirth")
                        .HasColumnType("datetime2")
                        .HasColumnName("date_of_birth");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("email");

                    b.Property<string>("FullName")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("full_name");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("password");

                    b.Property<string>("Role")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("role");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("username");

                    b.HasKey("Id");

                    b.ToTable("users");

                    b.HasData(
                        new
                        {
                            Id = new Guid("d965a870-1888-48ac-a872-aba2939c693c"),
                            Email = "admin@pro.org",
                            FullName = "Super User Admin",
                            Password = "$2a$11$nEmhpH6YxEBdCsfBJTdyT.22WqJlfH8oYmyBNiAkcHdQ.LrD4G77m",
                            Role = "admin",
                            Username = "sudo"
                        },
                        new
                        {
                            Id = new Guid("10815fc8-38f1-4305-89e8-c0638e1e58a0"),
                            Email = "sample4@sample.sample",
                            FullName = "Sample User Four",
                            Password = "$2a$11$YDO5BSgjzN5ta8yjHk.xcefYGE4OKG3Y5Mzkvo74skTFFDBJpGHDe",
                            Username = "sample4"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
