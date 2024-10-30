﻿// <auto-generated />
using DavidBlissett.Test.WebAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DavidBlissett.Test.WebAPI.Migrations
{
    [DbContext(typeof(AppDBContext))]
    [Migration("20241030192644_init_1000")]
    partial class init_1000
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DavidBlissett.Test.Shared.Customer", b =>
                {
                    b.Property<int>("CustomerID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CustomerID"));

                    b.Property<string>("Address1")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("Address2")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("PostCode")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("TelephoneNumber")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("CustomerID");

                    b.ToTable("Customers");

                    b.HasData(
                        new
                        {
                            CustomerID = 1,
                            Address1 = "10 Downing Street",
                            Address2 = "Westminster",
                            FirstName = "John",
                            LastName = "Doe",
                            PostCode = "SW1A 2AA",
                            TelephoneNumber = "020-7123-4567"
                        },
                        new
                        {
                            CustomerID = 2,
                            Address1 = "1 King Street",
                            Address2 = "St. James's",
                            FirstName = "Jane",
                            LastName = "Smith",
                            PostCode = "SW1Y 6QW",
                            TelephoneNumber = "020-7890-1234"
                        },
                        new
                        {
                            CustomerID = 3,
                            Address1 = "15 Queen Square",
                            Address2 = "",
                            FirstName = "Mike",
                            LastName = "Brown",
                            PostCode = "BS1 4NT",
                            TelephoneNumber = "0117-9876-5432"
                        },
                        new
                        {
                            CustomerID = 4,
                            Address1 = "3 Great George Street",
                            Address2 = "",
                            FirstName = "Lucy",
                            LastName = "Williams",
                            PostCode = "BS1 5RH",
                            TelephoneNumber = "0117-6543-2109"
                        },
                        new
                        {
                            CustomerID = 5,
                            Address1 = "2 Broad Street",
                            Address2 = "",
                            FirstName = "Chris",
                            LastName = "Johnson",
                            PostCode = "OX1 3AZ",
                            TelephoneNumber = "01865-987-654"
                        },
                        new
                        {
                            CustomerID = 6,
                            Address1 = "5 Magdalen Street",
                            Address2 = "",
                            FirstName = "Anna",
                            LastName = "Davis",
                            PostCode = "OX1 3AD",
                            TelephoneNumber = "01865-876-543"
                        },
                        new
                        {
                            CustomerID = 7,
                            Address1 = "1 Albert Square",
                            Address2 = "",
                            FirstName = "Tom",
                            LastName = "Clark",
                            PostCode = "M2 5DB",
                            TelephoneNumber = "0161-234-5000"
                        },
                        new
                        {
                            CustomerID = 8,
                            Address1 = "3 Saint Peter's Square",
                            Address2 = "",
                            FirstName = "Sara",
                            LastName = "Miller",
                            PostCode = "M2 3AE",
                            TelephoneNumber = "0161-234-6000"
                        },
                        new
                        {
                            CustomerID = 9,
                            Address1 = "30 Dean Street",
                            Address2 = "",
                            FirstName = "Ben",
                            LastName = "Garcia",
                            PostCode = "W1D 3RF",
                            TelephoneNumber = "020-7323-4400"
                        },
                        new
                        {
                            CustomerID = 10,
                            Address1 = "1 Oxford Street",
                            Address2 = "",
                            FirstName = "Emily",
                            LastName = "Martinez",
                            PostCode = "W1D 2DJ",
                            TelephoneNumber = "020-7450-1234"
                        },
                        new
                        {
                            CustomerID = 11,
                            Address1 = "12 Abbey Road",
                            Address2 = "",
                            FirstName = "Oliver",
                            LastName = "Hughes",
                            PostCode = "NW8 9AY",
                            TelephoneNumber = "020-7231-7654"
                        },
                        new
                        {
                            CustomerID = 12,
                            Address1 = "25 College Green",
                            Address2 = "",
                            FirstName = "Charlotte",
                            LastName = "Wilson",
                            PostCode = "BS1 5TB",
                            TelephoneNumber = "0117-123-4567"
                        },
                        new
                        {
                            CustomerID = 13,
                            Address1 = "7 Oxford Road",
                            Address2 = "",
                            FirstName = "George",
                            LastName = "Robinson",
                            PostCode = "OX1 3PF",
                            TelephoneNumber = "01865-456-789"
                        },
                        new
                        {
                            CustomerID = 14,
                            Address1 = "18 Portland Street",
                            Address2 = "",
                            FirstName = "Sophie",
                            LastName = "Walker",
                            PostCode = "M1 3LA",
                            TelephoneNumber = "0161-456-7890"
                        },
                        new
                        {
                            CustomerID = 15,
                            Address1 = "9 Baker Street",
                            Address2 = "",
                            FirstName = "James",
                            LastName = "Hall",
                            PostCode = "W1U 3AA",
                            TelephoneNumber = "020-3456-7890"
                        },
                        new
                        {
                            CustomerID = 16,
                            Address1 = "21 Park Row",
                            Address2 = "",
                            FirstName = "Amelia",
                            LastName = "Green",
                            PostCode = "BS1 5LJ",
                            TelephoneNumber = "0117-234-5678"
                        },
                        new
                        {
                            CustomerID = 17,
                            Address1 = "17 Cornmarket Street",
                            Address2 = "",
                            FirstName = "Henry",
                            LastName = "Allen",
                            PostCode = "OX1 3HL",
                            TelephoneNumber = "01865-321-987"
                        },
                        new
                        {
                            CustomerID = 18,
                            Address1 = "45 King Street",
                            Address2 = "",
                            FirstName = "Isabella",
                            LastName = "Young",
                            PostCode = "M2 7AY",
                            TelephoneNumber = "0161-567-4321"
                        },
                        new
                        {
                            CustomerID = 19,
                            Address1 = "62 Charing Cross Road",
                            Address2 = "",
                            FirstName = "Jack",
                            LastName = "Harris",
                            PostCode = "WC2H 0BB",
                            TelephoneNumber = "020-9876-5432"
                        },
                        new
                        {
                            CustomerID = 20,
                            Address1 = "14 George Street",
                            Address2 = "",
                            FirstName = "Lily",
                            LastName = "Martin",
                            PostCode = "BS1 5TP",
                            TelephoneNumber = "0117-345-6789"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
