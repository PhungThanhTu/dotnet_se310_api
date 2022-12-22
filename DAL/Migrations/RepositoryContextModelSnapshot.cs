﻿// <auto-generated />
using System;
using DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DAL.Migrations
{
    [DbContext(typeof(RepositoryContext))]
    partial class RepositoryContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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

                    b.HasKey("Id");

                    b.ToTable("block");
                });

            modelBuilder.Entity("DAL.Aggregates.Course", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("id");

                    b.Property<string>("Coursecode")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("course_code");

                    b.Property<string>("Coursename")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("coursename");

                    b.Property<Guid?>("LecturerId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("lecture_id");

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

                    b.HasIndex("BlockId");

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
                            Id = new Guid("13230ecb-c59c-42e3-8edc-9a7354a02e9b"),
                            Email = "admin@pro.org",
                            FullName = "Super User Admin",
                            Password = "$2a$11$v3c7Dso9AIy1cQYPIaG29uIv7uAaGUL/BW6eVdzEUH1WMLvrwueea",
                            Role = "admin",
                            Username = "sudo"
                        },
                        new
                        {
                            Id = new Guid("2aa0400d-bd4b-4157-b070-e6015cba513a"),
                            Email = "sample4@sample.sample",
                            FullName = "Sample User Four",
                            Password = "$2a$11$O95vhhUDuqPd4g18OBz0mejh7QMbS6gf8Y98TvVpFBc.uhkoSNEjG",
                            Username = "sample4"
                        });
                });

            modelBuilder.Entity("DAL.Aggregates.MarkdownDocument", b =>
                {
                    b.HasOne("DAL.Aggregates.Block", null)
                        .WithMany("Documents")
                        .HasForeignKey("BlockId");
                });

            modelBuilder.Entity("DAL.Aggregates.Block", b =>
                {
                    b.Navigation("Documents");
                });
#pragma warning restore 612, 618
        }
    }
}
