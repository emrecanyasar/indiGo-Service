﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using indiGo.Data.EntityFramework;

#nullable disable

namespace indiGo.Data.Migrations
{
    [DbContext(typeof(MyContext))]
    [Migration("20220609105841_DbUpdated")]
    partial class DbUpdated
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("indiGo.Core.Entities.Address", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("AddressInfo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AddressName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ApartmentNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("District")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("FlatNo")
                        .HasColumnType("int");

                    b.Property<string>("Neighborhood")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("indiGo.Core.Entities.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)");

                    b.Property<decimal>("Price")
                        .HasPrecision(8, 2)
                        .HasColumnType("decimal(8,2)");

                    b.HasKey("Id");

                    b.HasIndex("Id");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("indiGo.Core.Entities.Receipt", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("DemandId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("DemandId1")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DemandId1");

                    b.HasIndex("Id");

                    b.ToTable("Receipts");
                });

            modelBuilder.Entity("indiGo.Core.Entities.ReceiptDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int?>("ProductId1")
                        .HasColumnType("int");

                    b.Property<int>("ReceiptId")
                        .HasColumnType("int");

                    b.Property<int?>("ReceiptId1")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Id");

                    b.HasIndex("ProductId");

                    b.HasIndex("ProductId1");

                    b.HasIndex("ReceiptId");

                    b.HasIndex("ReceiptId1");

                    b.ToTable("ReceiptDetail");
                });

            modelBuilder.Entity("indiGo.Core.Entities.ServiceDemand", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<bool>("Accepted")
                        .HasColumnType("bit");

                    b.Property<int>("AddressId")
                        .HasColumnType("int");

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Completed")
                        .HasColumnType("bit");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(13)
                        .HasColumnType("nvarchar(13)");

                    b.Property<string>("Problem")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<string>("ServiceId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TCKN")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("nchar(11)")
                        .IsFixedLength();

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("AddressId");

                    b.HasIndex("Id");

                    b.HasIndex("UserId");

                    b.ToTable("ServiceDemands");
                });

            modelBuilder.Entity("indiGo.Data.Identity.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<DateTime>("RegisterDate")
                        .HasColumnType("datetime");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "8e552862-a24d-4548-a6c6-9443d048cdb9",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "cb51e1a8-bdd5-490e-b4c5-0931b078da19",
                            Email = "admin@gmail.com",
                            EmailConfirmed = false,
                            FirstName = "Admin",
                            LastName = "Admin",
                            LockoutEnabled = false,
                            NormalizedUserName = "ADMIN",
                            PasswordHash = "AQAAAAEAACcQAAAAEDIr1pNwx4KjdO//H+OQWbYSjlvIH5VUjhjMKLjiXDliVdZtsAeOLmVd6xuyuCVlug==",
                            PhoneNumberConfirmed = false,
                            RegisterDate = new DateTime(2022, 6, 9, 10, 58, 41, 354, DateTimeKind.Utc).AddTicks(5708),
                            SecurityStamp = "d27bf5dc-e942-4b05-9ca3-601a249b0522",
                            TwoFactorEnabled = false,
                            UserName = "admin"
                        },
                        new
                        {
                            Id = "8e445865-a24d-4543-a6c6-9443d048cdb9",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "34a70ba7-0821-42fe-872f-3d5dd74b6d41",
                            Email = "operator@gmail.com",
                            EmailConfirmed = false,
                            FirstName = "Operator",
                            LastName = "Operator",
                            LockoutEnabled = false,
                            NormalizedUserName = "OPERATOR",
                            PasswordHash = "AQAAAAEAACcQAAAAEEaoCKpJrZBKnXoCQCZO3vXVBnpKsM+yG9QgVSGxI6xR5opHwGvCY4IbnEFzWZOaCg==",
                            PhoneNumberConfirmed = false,
                            RegisterDate = new DateTime(2022, 6, 9, 10, 58, 41, 360, DateTimeKind.Utc).AddTicks(2779),
                            SecurityStamp = "d880874b-a678-49fe-ae64-364496276669",
                            TwoFactorEnabled = false,
                            UserName = "operator"
                        },
                        new
                        {
                            Id = "8e443125-a24d-4543-a6c6-9443d048cdb9",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "c05c413a-326b-4c8e-ab72-0cdf12478e2a",
                            Email = "mandosi@gmail.com",
                            EmailConfirmed = false,
                            FirstName = "Mandosi",
                            LastName = "Paki",
                            LockoutEnabled = false,
                            NormalizedUserName = "MANDOSI",
                            PasswordHash = "AQAAAAEAACcQAAAAENrAGEoqTv5uVbDvWrZj6tZlYbsXWF93bsoV9sAqmtZRIx/8TbkEKETc9hvCZ3qzxA==",
                            PhoneNumberConfirmed = false,
                            RegisterDate = new DateTime(2022, 6, 9, 10, 58, 41, 366, DateTimeKind.Utc).AddTicks(391),
                            SecurityStamp = "7fa71813-b365-4c1c-90de-56845c8d045f",
                            TwoFactorEnabled = false,
                            UserName = "mandosi"
                        },
                        new
                        {
                            Id = "8e443125-a24d-4543-a6c6-8223d048cdb9",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "06137bb7-4a41-4c7b-9809-9ede38133df1",
                            Email = "bewar@gmail.com",
                            EmailConfirmed = false,
                            FirstName = "Bewar",
                            LastName = "Dılbixhin",
                            LockoutEnabled = false,
                            NormalizedUserName = "BEWAR",
                            PasswordHash = "AQAAAAEAACcQAAAAEORj9BNIAcKBnHxFvBxskJ8Z3awOgrKlrNLI5Q+CDLOgQQpLNvuROmHlNoDjwQpgHQ==",
                            PhoneNumberConfirmed = false,
                            RegisterDate = new DateTime(2022, 6, 9, 10, 58, 41, 371, DateTimeKind.Utc).AddTicks(5543),
                            SecurityStamp = "dca57772-747c-4cb5-9240-7ac9b632129c",
                            TwoFactorEnabled = false,
                            UserName = "bewar"
                        },
                        new
                        {
                            Id = "8e443125-a24d-4543-a5g5-8223d048cdb9",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "32969044-1fe3-4d6b-b5cf-a7697aecdb1b",
                            Email = "cumali@gmail.com",
                            EmailConfirmed = false,
                            FirstName = "Cumali",
                            LastName = "Cemalikızık",
                            LockoutEnabled = false,
                            NormalizedUserName = "CUMALI",
                            PasswordHash = "AQAAAAEAACcQAAAAEBBOPi+h3X6j+H3Elg6NZ6pFl9lFxUKCUUcjFUCPcn1iVz2IZUAv5VTZSOtslXyb0w==",
                            PhoneNumberConfirmed = false,
                            RegisterDate = new DateTime(2022, 6, 9, 10, 58, 41, 377, DateTimeKind.Utc).AddTicks(454),
                            SecurityStamp = "1b692377-c048-4eee-8ba7-7917f9a8bc1e",
                            TwoFactorEnabled = false,
                            UserName = "cumali"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "1",
                            ConcurrencyStamp = "ded163df-d8c6-4d68-8aaa-612856d88c82",
                            Name = "ADMIN",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "2",
                            ConcurrencyStamp = "2b8c9a70-a6d1-4d68-8fe1-4d36f69a32d3",
                            Name = "CUSTOMER",
                            NormalizedName = "CUSTOMER"
                        },
                        new
                        {
                            Id = "3",
                            ConcurrencyStamp = "fdc9c330-42ca-4a20-8b0e-66988e95bf16",
                            Name = "OPERATOR",
                            NormalizedName = "OPERATOR"
                        },
                        new
                        {
                            Id = "4",
                            ConcurrencyStamp = "7726f99d-bea7-4415-b5db-c8cf7e641897",
                            Name = "PASSIVE",
                            NormalizedName = "PASSIVE"
                        },
                        new
                        {
                            Id = "5",
                            ConcurrencyStamp = "2c27783e-98d0-410f-bbaa-509d04b093fe",
                            Name = "ELECTRICALSERVICE",
                            NormalizedName = "ELECTRICALSERVICE"
                        },
                        new
                        {
                            Id = "6",
                            ConcurrencyStamp = "5abf22fa-5f66-4c46-b449-0548655689e9",
                            Name = "GASSERVICE",
                            NormalizedName = "GASSERVICE"
                        },
                        new
                        {
                            Id = "7",
                            ConcurrencyStamp = "cea387e5-7164-45d6-84b0-83516ba14279",
                            Name = "PLUMBINGSERVICE",
                            NormalizedName = "PLUMBINGSERVICE"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = "8e552862-a24d-4548-a6c6-9443d048cdb9",
                            RoleId = "1"
                        },
                        new
                        {
                            UserId = "8e445865-a24d-4543-a6c6-9443d048cdb9",
                            RoleId = "3"
                        },
                        new
                        {
                            UserId = "8e443125-a24d-4543-a6c6-9443d048cdb9",
                            RoleId = "5"
                        },
                        new
                        {
                            UserId = "8e443125-a24d-4543-a6c6-8223d048cdb9",
                            RoleId = "6"
                        },
                        new
                        {
                            UserId = "8e443125-a24d-4543-a5g5-8223d048cdb9",
                            RoleId = "7"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("indiGo.Core.Entities.Address", b =>
                {
                    b.HasOne("indiGo.Data.Identity.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("indiGo.Core.Entities.Receipt", b =>
                {
                    b.HasOne("indiGo.Core.Entities.ServiceDemand", "Demand")
                        .WithMany()
                        .HasForeignKey("DemandId1");

                    b.Navigation("Demand");
                });

            modelBuilder.Entity("indiGo.Core.Entities.ReceiptDetail", b =>
                {
                    b.HasOne("indiGo.Core.Entities.Product", null)
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("indiGo.Core.Entities.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId1");

                    b.HasOne("indiGo.Core.Entities.Receipt", null)
                        .WithMany()
                        .HasForeignKey("ReceiptId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("indiGo.Core.Entities.Receipt", "Receipt")
                        .WithMany()
                        .HasForeignKey("ReceiptId1");

                    b.Navigation("Product");

                    b.Navigation("Receipt");
                });

            modelBuilder.Entity("indiGo.Core.Entities.ServiceDemand", b =>
                {
                    b.HasOne("indiGo.Core.Entities.Address", null)
                        .WithMany()
                        .HasForeignKey("AddressId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("indiGo.Data.Identity.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("indiGo.Data.Identity.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("indiGo.Data.Identity.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("indiGo.Data.Identity.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("indiGo.Data.Identity.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
