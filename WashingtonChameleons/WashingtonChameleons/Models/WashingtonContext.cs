﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Configuration;

namespace WashingtonChameleons.Models
{
    public partial class WashingtonContext : DbContext
    {
        public WashingtonContext()
        {
        }

        public WashingtonContext(DbContextOptions<WashingtonContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ActiveCarriers> ActiveCarriers { get; set; }
        public virtual DbSet<Carriers> Carriers { get; set; }
        public virtual DbSet<ChameleonTable> ChameleonTable { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                IConfigurationRoot configuration = new ConfigurationBuilder().SetBasePath(AppDomain.CurrentDomain.BaseDirectory).AddJsonFile("appsettings.json").Build();

                optionsBuilder.UseSqlServer(configuration.GetConnectionString("WashingtonDatabase"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity<ActiveCarriers>(entity =>
            {
                entity.HasKey(e => e.DotNumber);

                entity.ToTable("active_carriers");

                entity.Property(e => e.DotNumber).ValueGeneratedNever();

                entity.Property(e => e.CarrierOperation).HasMaxLength(200);

                entity.Property(e => e.Dbaname)
                    .HasColumnName("DBAName")
                    .HasMaxLength(200);

                entity.Property(e => e.DriverTotal).HasMaxLength(200);

                entity.Property(e => e.EmailAddress).HasMaxLength(200);

                entity.Property(e => e.Fax).HasMaxLength(200);

                entity.Property(e => e.Hmflag)
                    .HasColumnName("HMFlag")
                    .HasMaxLength(200);

                entity.Property(e => e.Latitude)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LegalName).HasMaxLength(200);

                entity.Property(e => e.Longitude)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MailingCity).HasMaxLength(200);

                entity.Property(e => e.MailingCountry).HasMaxLength(200);

                entity.Property(e => e.MailingStreet).HasMaxLength(200);

                entity.Property(e => e.MailingZip).HasMaxLength(200);

                entity.Property(e => e.MainlingState).HasMaxLength(200);

                entity.Property(e => e.Mcs150date).HasColumnName("MCS150Date");

                entity.Property(e => e.Mcs150mileage)
                    .HasColumnName("MCS150Mileage")
                    .HasMaxLength(200);

                entity.Property(e => e.Mcs150mileageYear).HasColumnName("MCS150MileageYear");

                entity.Property(e => e.NbrpowerUnit)
                    .HasColumnName("NBRPowerUnit")
                    .HasMaxLength(200);

                entity.Property(e => e.Number).ValueGeneratedOnAdd();

                entity.Property(e => e.Oicstate)
                    .HasColumnName("OICState")
                    .HasMaxLength(200);

                entity.Property(e => e.Pcflag)
                    .HasColumnName("PCFlag")
                    .HasMaxLength(200);

                entity.Property(e => e.Phycity)
                    .HasColumnName("PHYCity")
                    .HasMaxLength(200);

                entity.Property(e => e.Phycountry)
                    .HasColumnName("PHYCountry")
                    .HasMaxLength(200);

                entity.Property(e => e.Phystate)
                    .HasColumnName("PHYState")
                    .HasMaxLength(200);

                entity.Property(e => e.Phystreet)
                    .HasColumnName("PHYStreet")
                    .HasMaxLength(200);

                entity.Property(e => e.Phyzip)
                    .HasColumnName("PHYZip")
                    .HasMaxLength(200);

                entity.Property(e => e.Telephone).HasMaxLength(200);
            });

            modelBuilder.Entity<Carriers>(entity =>
            {
                entity.HasKey(e => e.Number)
                    .HasName("PK__carriers__78A1A19CB5D8285D");

                entity.ToTable("carriers");

                entity.Property(e => e.CarrierName)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Latitude)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Longitude)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.OosDate)
                    .IsRequired()
                    .HasColumnName("OOS_Date")
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.OosReason)
                    .IsRequired()
                    .HasColumnName("OOS_Reason")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.StateAddress)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.StreetAddress)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Zipcode)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ChameleonTable>(entity =>
            {
                entity.HasKey(e => e.ChameleonId)
                    .HasName("PK__chameleo__9B70000D183698AF");

                entity.ToTable("chameleon_table");

                entity.Property(e => e.ChameleonId).HasColumnName("ChameleonID");

                entity.Property(e => e.City).HasMaxLength(200);

                entity.Property(e => e.ConfidenceLevel).HasColumnName("Confidence_Level");

                entity.Property(e => e.ContactEmail)
                    .HasColumnName("Contact_Email")
                    .HasMaxLength(200);

                entity.Property(e => e.ContactNumber)
                    .HasColumnName("Contact_Number")
                    .HasMaxLength(200);

                entity.Property(e => e.CurrentName)
                    .IsRequired()
                    .HasColumnName("Current_Name")
                    .HasMaxLength(200);

                entity.Property(e => e.DateOoS)
                    .HasColumnName("Date_OoS")
                    .HasColumnType("date");

                entity.Property(e => e.DateRegistered)
                    .HasColumnName("Date_Registered")
                    .HasColumnType("date");

                entity.Property(e => e.FormerName)
                    .IsRequired()
                    .HasColumnName("Former_Name")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Latitude)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Longitude)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.State).HasMaxLength(200);

                entity.Property(e => e.StreetAddress)
                    .HasColumnName("Street_Address")
                    .HasMaxLength(200);

                entity.Property(e => e.ZipCode).HasMaxLength(200);
            });
        }
    }
}
