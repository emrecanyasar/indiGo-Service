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
    [Migration("20220610100438_ReceiptFix")]
    partial class ReceiptFix
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

                    b.Property<int>("DemandId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DemandId");

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
                            ConcurrencyStamp = "79aeb4f0-fa7b-473b-b27d-5d6bfa9355e7",
                            Email = "admin@gmail.com",
                            EmailConfirmed = false,
                            FirstName = "Admin",
                            LastName = "Admin",
                            LockoutEnabled = false,
                            NormalizedUserName = "ADMIN",
                            PasswordHash = "AQAAAAEAACcQAAAAEGPQAWKkbxAR6aO8IgFmjStQXZCwN2EyfOiPY8U0aog2uKzHKUEcyIeUPBspPHjJJQ==",
                            PhoneNumberConfirmed = false,
                            RegisterDate = new DateTime(2022, 6, 10, 10, 4, 38, 479, DateTimeKind.Utc).AddTicks(7291),
                            SecurityStamp = "794751c6-4b6e-4b7b-b303-dc2832f473b6",
                            TwoFactorEnabled = false,
                            UserName = "admin"
                        },
                        new
                        {
                            Id = "8e445865-a24d-4543-a6c6-9443d048cdb9",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "4804bb55-4c20-41f2-8905-966be1301860",
                            Email = "operator@gmail.com",
                            EmailConfirmed = false,
                            FirstName = "Operator",
                            LastName = "Operator",
                            LockoutEnabled = false,
                            NormalizedUserName = "OPERATOR",
                            PasswordHash = "AQAAAAEAACcQAAAAEE7cnsRDeg007cBKdts0S1GC10ouOHmu+vgTLIUEvMuj/PVaTsaOpPqsrC0k5FRY2A==",
                            PhoneNumberConfirmed = false,
                            RegisterDate = new DateTime(2022, 6, 10, 10, 4, 38, 485, DateTimeKind.Utc).AddTicks(1022),
                            SecurityStamp = "e4bfb32d-a8d4-4d6b-ac26-2e070305b204",
                            TwoFactorEnabled = false,
                            UserName = "operator"
                        },
                        new
                        {
                            Id = "8e443125-a24d-4543-a6c6-9443d048cdb9",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "36f23e13-7a8f-4e7f-aaaa-edf7520203e2",
                            Email = "mandosi@gmail.com",
                            EmailConfirmed = false,
                            FirstName = "Mandosi",
                            LastName = "Paki",
                            LockoutEnabled = false,
                            NormalizedUserName = "MANDOSI",
                            PasswordHash = "AQAAAAEAACcQAAAAEGTKmMtXGgc35vbuBsKmj0k0zU5f/fc8DO73dTwvksIsuPRNjv2a9M8XjqEMQ/EtMw==",
                            PhoneNumberConfirmed = false,
                            RegisterDate = new DateTime(2022, 6, 10, 10, 4, 38, 490, DateTimeKind.Utc).AddTicks(4048),
                            SecurityStamp = "fd93e426-780a-4a1c-94df-a261128af2f2",
                            TwoFactorEnabled = false,
                            UserName = "mandosi"
                        },
                        new
                        {
                            Id = "8e443125-a24d-4543-a6c6-8223d048cdb9",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "d91a5721-71f0-4d1c-a26c-82b6454d32fa",
                            Email = "bewar@gmail.com",
                            EmailConfirmed = false,
                            FirstName = "Bewar",
                            LastName = "Dılbixhin",
                            LockoutEnabled = false,
                            NormalizedUserName = "BEWAR",
                            PasswordHash = "AQAAAAEAACcQAAAAEHPWSD/5ocxS3K+sniyxnzmnIwUkYLZTPns8qCITbBMw6Uq3fBybJMnNfpPo/l2NZg==",
                            PhoneNumberConfirmed = false,
                            RegisterDate = new DateTime(2022, 6, 10, 10, 4, 38, 495, DateTimeKind.Utc).AddTicks(7161),
                            SecurityStamp = "9dd7dd1d-cb55-4eb5-afbe-6c0ac8cadc9c",
                            TwoFactorEnabled = false,
                            UserName = "bewar"
                        },
                        new
                        {
                            Id = "8e443125-a24d-4543-a5g5-8223d048cdb9",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "e0daa841-cfef-432d-b735-1f1b7b773ab1",
                            Email = "cumali@gmail.com",
                            EmailConfirmed = false,
                            FirstName = "Cumali",
                            LastName = "Cemalikızık",
                            LockoutEnabled = false,
                            NormalizedUserName = "CUMALI",
                            PasswordHash = "AQAAAAEAACcQAAAAEJleElGfBMKNd3kGoWUfjlWp2lpuFmzXSPvoLEDcBz63LbFsGKD2K/NtIZF2ZGs5tQ==",
                            PhoneNumberConfirmed = false,
                            RegisterDate = new DateTime(2022, 6, 10, 10, 4, 38, 501, DateTimeKind.Utc).AddTicks(2116),
                            SecurityStamp = "7f30b9c6-d6c5-4c0d-98ff-4e39f706c92f",
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
                            ConcurrencyStamp = "8d97bad1-f72e-46be-97c0-235d76710098",
                            Name = "ADMIN",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "2",
                            ConcurrencyStamp = "663b6d70-7c72-46cb-95bc-51d1e637e3e2",
                            Name = "CUSTOMER",
                            NormalizedName = "CUSTOMER"
                        },
                        new
                        {
                            Id = "3",
                            ConcurrencyStamp = "0d575423-c7a0-43a9-bd1a-e1c14294aebe",
                            Name = "OPERATOR",
                            NormalizedName = "OPERATOR"
                        },
                        new
                        {
                            Id = "4",
                            ConcurrencyStamp = "f4853fcc-2289-43d2-8543-47eb6b3a7b58",
                            Name = "PASSIVE",
                            NormalizedName = "PASSIVE"
                        },
                        new
                        {
                            Id = "5",
                            ConcurrencyStamp = "9b17035d-e10f-4a04-be52-9673ff952c16",
                            Name = "ELECTRICALSERVICE",
                            NormalizedName = "ELECTRICALSERVICE"
                        },
                        new
                        {
                            Id = "6",
                            ConcurrencyStamp = "d29fa513-8c0b-49a5-84e9-304299c54238",
                            Name = "GASSERVICE",
                            NormalizedName = "GASSERVICE"
                        },
                        new
                        {
                            Id = "7",
                            ConcurrencyStamp = "15c6ada4-5c32-4a97-9c73-036f6a174301",
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
                        .HasForeignKey("DemandId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

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