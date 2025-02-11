﻿// <auto-generated />
using System;
using Contacts.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Contacts.Migrations
{
    [DbContext(typeof(ContactContext))]
    [Migration("20250211074525_Organization")]
    partial class Organization
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Contacts.Models.Category", b =>
                {
                    b.Property<string>("CategoryId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = "A",
                            Name = "Friend"
                        },
                        new
                        {
                            CategoryId = "B",
                            Name = "Work"
                        },
                        new
                        {
                            CategoryId = "C",
                            Name = "Family"
                        },
                        new
                        {
                            CategoryId = "D",
                            Name = "Acquaintance"
                        });
                });

            modelBuilder.Entity("Contacts.Models.Contact", b =>
                {
                    b.Property<int>("ContactId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ContactId"));

                    b.Property<string>("CategoryId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("DateAdded")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Organization")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ContactId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Contacts");

                    b.HasData(
                        new
                        {
                            ContactId = 1,
                            CategoryId = "A",
                            DateAdded = new DateTime(2025, 2, 11, 0, 45, 23, 835, DateTimeKind.Local).AddTicks(5336),
                            Email = "joaquin@gmail.com",
                            FName = "Joaquin",
                            LName = "Remulla",
                            Organization = " ",
                            PNumber = "825-841-1779"
                        },
                        new
                        {
                            ContactId = 2,
                            CategoryId = "B",
                            DateAdded = new DateTime(2025, 2, 11, 0, 45, 23, 837, DateTimeKind.Local).AddTicks(4877),
                            Email = "charles@gmail.com",
                            FName = "Charles",
                            LName = "Omagap",
                            Organization = " ",
                            PNumber = "825-914-4912"
                        },
                        new
                        {
                            ContactId = 3,
                            CategoryId = "C",
                            DateAdded = new DateTime(2025, 2, 11, 0, 45, 23, 837, DateTimeKind.Local).AddTicks(4895),
                            Email = "hanni@gmail.com",
                            FName = "Hanni",
                            LName = "Pham",
                            Organization = " ",
                            PNumber = "825-514-5015"
                        });
                });

            modelBuilder.Entity("Contacts.Models.Contact", b =>
                {
                    b.HasOne("Contacts.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });
#pragma warning restore 612, 618
        }
    }
}
