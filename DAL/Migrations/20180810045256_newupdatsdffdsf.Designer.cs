﻿// <auto-generated />
using System;
using DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DAL.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20180810045256_newupdatsdffdsf")]
    partial class newupdatsdffdsf
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.1-rtm-30846")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DAL.CancelItemReason", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("RatedAt");

                    b.Property<double>("Rating");

                    b.Property<string>("Reason");

                    b.Property<int?>("ReportProblemMessage_Id");

                    b.Property<int>("RequestItem_Id");

                    b.HasKey("Id");

                    b.HasIndex("ReportProblemMessage_Id");

                    b.HasIndex("RequestItem_Id");

                    b.ToTable("CancelItemReason");
                });

            modelBuilder.Entity("DAL.Cuisine", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Cuisine");
                });

            modelBuilder.Entity("DAL.Driver", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedDate");

                    b.Property<string>("DateOfBirth");

                    b.Property<string>("Email");

                    b.Property<bool>("IsAvailable");

                    b.Property<bool>("IsDeleted");

                    b.Property<bool>("IsNotificationsOn");

                    b.Property<double>("Latitude");

                    b.Property<string>("LicenseNo");

                    b.Property<double>("Longitude");

                    b.Property<DateTime?>("ModifiedDate");

                    b.Property<string>("Password");

                    b.Property<string>("PhoneNo");

                    b.Property<string>("ProfilePictureUrl");

                    b.Property<int>("SignInType");

                    b.HasKey("Id");

                    b.ToTable("Drivers");
                });

            modelBuilder.Entity("DAL.DriverML", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BriefInfo");

                    b.Property<int>("Culture");

                    b.Property<int>("Driver_Id");

                    b.Property<string>("FullName");

                    b.Property<string>("HomeAddress");

                    b.Property<string>("WorkHistory");

                    b.HasKey("Id");

                    b.HasIndex("Driver_Id");

                    b.ToTable("DriverML");
                });

            modelBuilder.Entity("DAL.DriverRating", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Driver_Id");

                    b.Property<DateTime>("RatedAt");

                    b.Property<double>("Rating");

                    b.Property<string>("Reason");

                    b.Property<int?>("ReportProblemMessage_Id");

                    b.Property<int?>("User_Id");

                    b.HasKey("Id");

                    b.HasIndex("Driver_Id");

                    b.HasIndex("ReportProblemMessage_Id");

                    b.HasIndex("User_Id");

                    b.ToTable("DriverRating");
                });

            modelBuilder.Entity("DAL.ReportProblemMessage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Culture");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("Reason");

                    b.Property<int>("Type");

                    b.HasKey("Id");

                    b.ToTable("ReportProblemMessage");
                });

            modelBuilder.Entity("DAL.RequestItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DeliveryDate");

                    b.Property<TimeSpan>("DeliveryTime");

                    b.Property<int?>("Driver_Id");

                    b.Property<double?>("DropOffLatitude");

                    b.Property<double?>("DropOffLongitude");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("ItemDescription");

                    b.Property<int>("PaymentMethod");

                    b.Property<double?>("PickUpLatitude");

                    b.Property<double?>("PickUpLongitude");

                    b.Property<double?>("Price");

                    b.Property<double>("PriceRangeFrom");

                    b.Property<double>("PriceRangeTo");

                    b.Property<int>("Quantity");

                    b.Property<short>("Status");

                    b.Property<int>("User_Id");

                    b.HasKey("Id");

                    b.HasIndex("Driver_Id");

                    b.HasIndex("User_Id");

                    b.ToTable("RequestItem");
                });

            modelBuilder.Entity("DAL.RequestItemImages", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ImageUrl");

                    b.Property<int>("RequestItem_Id");

                    b.HasKey("Id");

                    b.HasIndex("RequestItem_Id");

                    b.ToTable("RequestItemImages");
                });

            modelBuilder.Entity("DAL.RequestItemML", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Culture");

                    b.Property<string>("DropOffLocation");

                    b.Property<string>("ItemDescription");

                    b.Property<string>("Name");

                    b.Property<string>("PickUpLocation");

                    b.Property<int>("RequestItem_Id");

                    b.HasKey("Id");

                    b.HasIndex("RequestItem_Id");

                    b.ToTable("RequestItemML");
                });

            modelBuilder.Entity("DAL.Settings", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("IsDeleted");

                    b.HasKey("Id");

                    b.ToTable("Settings");
                });

            modelBuilder.Entity("DAL.SettingsML", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AboutUs");

                    b.Property<int>("Culture");

                    b.Property<string>("PrivacyPolicy");

                    b.Property<int>("Setting_Id");

                    b.Property<string>("TermsOfUse");

                    b.HasKey("Id");

                    b.HasIndex("Setting_Id");

                    b.ToTable("SettingsML");
                });

            modelBuilder.Entity("DAL.Store", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("About");

                    b.Property<string>("Address");

                    b.Property<int>("AverageDeliveryTime");

                    b.Property<string>("ContactNumber");

                    b.Property<double>("DeliveryFee");

                    b.Property<string>("Description");

                    b.Property<string>("ImageUrl");

                    b.Property<bool>("IsDeleted");

                    b.Property<bool>("IsFeature");

                    b.Property<float?>("MinOrder");

                    b.Property<string>("Name");

                    b.Property<TimeSpan>("Open_From");

                    b.Property<TimeSpan>("Open_To");

                    b.Property<string>("PaymentMethod");

                    b.HasKey("Id");

                    b.ToTable("Store");
                });

            modelBuilder.Entity("DAL.StoreCuisine", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Cuisine_Id");

                    b.Property<int>("Store_Id");

                    b.HasKey("Id");

                    b.HasIndex("Cuisine_Id");

                    b.HasIndex("Store_Id");

                    b.ToTable("StoreCuisine");
                });

            modelBuilder.Entity("DAL.StoreRating", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Feedback");

                    b.Property<double>("Rating");

                    b.Property<int>("Store_Id");

                    b.HasKey("Id");

                    b.HasIndex("Store_Id");

                    b.ToTable("StoreRating");
                });

            modelBuilder.Entity("DAL.StoreTiming", b =>
                {
                    b.Property<int?>("Id");

                    b.Property<TimeSpan>("Friday_From");

                    b.Property<TimeSpan>("Friday_To");

                    b.Property<TimeSpan>("Monday_From");

                    b.Property<TimeSpan>("Monday_To");

                    b.Property<TimeSpan>("Saturday_From");

                    b.Property<TimeSpan>("Saturday_To");

                    b.Property<TimeSpan>("Sunday_From");

                    b.Property<TimeSpan>("Sunday_To");

                    b.Property<TimeSpan>("Thursday_From");

                    b.Property<TimeSpan>("Thursday_To");

                    b.Property<TimeSpan>("Tuesday_From");

                    b.Property<TimeSpan>("Tuesday_To");

                    b.Property<TimeSpan>("Wednesday_From");

                    b.Property<TimeSpan>("Wednesday_To");

                    b.HasKey("Id");

                    b.ToTable("StoreTiming");
                });

            modelBuilder.Entity("DAL.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedDate");

                    b.Property<DateTime>("DateofBirth");

                    b.Property<string>("Email");

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("IsNotificationsOn");

                    b.Property<DateTime?>("ModifiedDate");

                    b.Property<string>("Password");

                    b.Property<bool>("PhoneConfirmed");

                    b.Property<string>("PhoneNo");

                    b.Property<string>("ProfilePictureUrl");

                    b.Property<int?>("SignInType");

                    b.Property<short?>("Status");

                    b.Property<string>("ZipCode");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("DAL.UserDevice", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AuthToken");

                    b.Property<string>("DeviceName");

                    b.Property<bool>("IsActive");

                    b.Property<bool>("Platform");

                    b.Property<string>("UDID");

                    b.Property<int?>("UserId");

                    b.Property<int?>("User_Id");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("UserDevice");
                });

            modelBuilder.Entity("DAL.UserML", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Culture");

                    b.Property<string>("FullName");

                    b.Property<string>("Location");

                    b.Property<int>("User_Id");

                    b.HasKey("Id");

                    b.HasIndex("User_Id");

                    b.ToTable("UserML");
                });

            modelBuilder.Entity("DAL.CancelItemReason", b =>
                {
                    b.HasOne("DAL.ReportProblemMessage", "ReportProblemMessage")
                        .WithMany()
                        .HasForeignKey("ReportProblemMessage_Id");

                    b.HasOne("DAL.RequestItem", "RequestItem")
                        .WithMany()
                        .HasForeignKey("RequestItem_Id")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DAL.DriverML", b =>
                {
                    b.HasOne("DAL.Driver", "Driver")
                        .WithMany("DriverML")
                        .HasForeignKey("Driver_Id")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DAL.DriverRating", b =>
                {
                    b.HasOne("DAL.Driver", "Driver")
                        .WithMany("DriverRating")
                        .HasForeignKey("Driver_Id")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DAL.ReportProblemMessage", "ReportProblemMessage")
                        .WithMany()
                        .HasForeignKey("ReportProblemMessage_Id");

                    b.HasOne("DAL.User", "User")
                        .WithMany("DriverRating")
                        .HasForeignKey("User_Id")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DAL.RequestItem", b =>
                {
                    b.HasOne("DAL.Driver", "Driver")
                        .WithMany("RequestItem")
                        .HasForeignKey("Driver_Id")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DAL.User", "User")
                        .WithMany("RequestItem")
                        .HasForeignKey("User_Id")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DAL.RequestItemImages", b =>
                {
                    b.HasOne("DAL.RequestItem", "RequestItem")
                        .WithMany("RequestItemImages")
                        .HasForeignKey("RequestItem_Id")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DAL.RequestItemML", b =>
                {
                    b.HasOne("DAL.RequestItem", "RequestItem")
                        .WithMany("RequestItemML")
                        .HasForeignKey("RequestItem_Id")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DAL.SettingsML", b =>
                {
                    b.HasOne("DAL.Settings", "Settings")
                        .WithMany("SettingsML")
                        .HasForeignKey("Setting_Id")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DAL.Store", b =>
                {
                    b.OwnsOne("DAL.Location", "Location", b1 =>
                        {
                            b1.Property<int?>("StoreId")
                                .ValueGeneratedOnAdd()
                                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                            b1.Property<double>("Latitude");

                            b1.Property<double>("Longitude");

                            b1.ToTable("Store");

                            b1.HasOne("DAL.Store")
                                .WithOne("Location")
                                .HasForeignKey("DAL.Location", "StoreId")
                                .OnDelete(DeleteBehavior.Cascade);
                        });
                });

            modelBuilder.Entity("DAL.StoreCuisine", b =>
                {
                    b.HasOne("DAL.Cuisine", "Cuisine")
                        .WithMany("StoreCuisine")
                        .HasForeignKey("Cuisine_Id")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DAL.Store", "Store")
                        .WithMany("StoreCuisines")
                        .HasForeignKey("Store_Id")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DAL.StoreRating", b =>
                {
                    b.HasOne("DAL.Store", "Store")
                        .WithMany("StoreRatings")
                        .HasForeignKey("Store_Id")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DAL.StoreTiming", b =>
                {
                    b.HasOne("DAL.Store", "Store")
                        .WithOne("StoreTiming")
                        .HasForeignKey("DAL.StoreTiming", "Id")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DAL.UserDevice", b =>
                {
                    b.HasOne("DAL.User", "User")
                        .WithMany("UserDevices")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("DAL.UserML", b =>
                {
                    b.HasOne("DAL.User", "User")
                        .WithMany("UserML")
                        .HasForeignKey("User_Id")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
