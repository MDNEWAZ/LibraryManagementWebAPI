﻿// <auto-generated />
using System;
using LibraryManagementWebAPI;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LibraryManagementWebAPI.Migrations
{
    [DbContext(typeof(LibraryContext))]
    [Migration("20191003155606_CreatedAllTable")]
    partial class CreatedAllTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("LibraryManagementWebAPI.Model.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Author");

                    b.Property<string>("BarCode");

                    b.Property<int>("CopyCount");

                    b.Property<string>("Edition");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("LibraryManagementWebAPI.Model.IssueBook", b =>
                {
                    b.Property<int>("StudentId");

                    b.Property<int>("bookId");

                    b.Property<string>("BookBarCode");

                    b.Property<DateTime>("IssueDate");

                    b.HasKey("StudentId", "bookId");

                    b.HasIndex("bookId");

                    b.ToTable("IssueBook");
                });

            modelBuilder.Entity("LibraryManagementWebAPI.Model.ReturnBook", b =>
                {
                    b.Property<int>("StudentId");

                    b.Property<int>("BookId");

                    b.Property<string>("BookBarCode");

                    b.Property<DateTime>("ReturnDate");

                    b.HasKey("StudentId", "BookId");

                    b.HasIndex("BookId");

                    b.ToTable("ReturnBooks");
                });

            modelBuilder.Entity("LibraryManagementWebAPI.Model.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("FineAmount");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("LibraryManagementWebAPI.Model.IssueBook", b =>
                {
                    b.HasOne("LibraryManagementWebAPI.Model.Student", "Student")
                        .WithMany("BookIssues")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("LibraryManagementWebAPI.Model.Book", "book")
                        .WithMany()
                        .HasForeignKey("bookId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("LibraryManagementWebAPI.Model.ReturnBook", b =>
                {
                    b.HasOne("LibraryManagementWebAPI.Model.Book", "Book")
                        .WithMany()
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("LibraryManagementWebAPI.Model.Student", "Student")
                        .WithMany("BookReturns")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
