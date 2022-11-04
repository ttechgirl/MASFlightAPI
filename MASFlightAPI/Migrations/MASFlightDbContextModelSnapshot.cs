﻿// <auto-generated />
using System;
using MASFlightAPI;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MASFlightAPI.Migrations
{
    [DbContext(typeof(MASFlightDbContext))]
    partial class MASFlightDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MASFlightAPI.Models.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phonenumber")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Customer");
                });

            modelBuilder.Entity("MASFlightAPI.Models.FlightPaymentModel", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Currency")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CustomerId")
                        .HasColumnType("int");

                    b.Property<string>("Payment_options")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Purpose")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Redirect_url")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tx_ref")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.ToTable("flightPayments");
                });

            modelBuilder.Entity("MASFlightAPI.Models.Location", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Airport")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("State")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Location");
                });

            modelBuilder.Entity("MASFlightAPI.Models.MASFlightAdmin", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Location")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OneWay")
                        .HasColumnType("int");

                    b.Property<int>("RoundTrip")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("MASFlightAdmins");
                });

            modelBuilder.Entity("MASFlightAPI.Models.MASFlightBooking", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long?>("AgeId")
                        .HasColumnType("bigint");

                    b.Property<long>("BookingId")
                        .HasColumnType("bigint");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("PaymentStatus")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TicketDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TicketName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Trip_Type")
                        .HasColumnType("int");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("dateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("departure")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("destination")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("flightCategories")
                        .HasColumnType("int");

                    b.Property<long?>("locationId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("AgeId");

                    b.HasIndex("locationId");

                    b.ToTable("MASFlights");
                });

            modelBuilder.Entity("MASFlightAPI.Models.TravelerAge", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Adult")
                        .HasColumnType("int");

                    b.Property<int>("Children")
                        .HasColumnType("int");

                    b.Property<int>("Infant")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("TravelerAges");
                });

            modelBuilder.Entity("MASFlightAPI.Models.Users", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("MASFlightAPI.Models.FlightPaymentModel", b =>
                {
                    b.HasOne("MASFlightAPI.Models.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerId");
                });

            modelBuilder.Entity("MASFlightAPI.Models.MASFlightBooking", b =>
                {
                    b.HasOne("MASFlightAPI.Models.TravelerAge", "Age")
                        .WithMany()
                        .HasForeignKey("AgeId");

                    b.HasOne("MASFlightAPI.Models.Location", "location")
                        .WithMany()
                        .HasForeignKey("locationId");
                });
#pragma warning restore 612, 618
        }
    }
}
