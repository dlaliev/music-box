﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OnlineShop.Db;

#nullable disable

namespace OnlineShop.Db.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    partial class DatabaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("OnlineShop.Db.Models.Product", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImagePath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = new Guid("45a7e4b9-94e3-4b1e-aa34-abcde1234567"),
                            Description = "Label: Interscope Records, Polydor – B0030285-01\r\nFormat: Vinyl, LP, Album, Limited Edition, Reissue, Red Opaque\r\nCountry: US\r\nReleased: Feb 7, 2020\r\nGenre: Rock, Pop\r\nStyle: Dream Pop, Indie Pop, Trip Hop",
                            ImagePath = "/images/image1.jpg",
                            Name = "Lana Del Rey - Born To Die",
                            Price = 5000m
                        },
                        new
                        {
                            Id = new Guid("5fb4b0bb-765d-4b9a-b5de-c34567890123"),
                            Description = "Label: Polydor – 3859014, Interscope Records – 00602438590148\r\nFormat: 2xVinyl, LP, Album\r\nCountry: USA & Europe\r\nReleased: Oct 22, 2021\r\nGenre: Pop",
                            ImagePath = "/images/image2.webp",
                            Name = "Lana Del Rey – Blue Banisters",
                            Price = 5500m
                        },
                        new
                        {
                            Id = new Guid("6a8ca2f1-6e45-4b0f-a5ed-dcba09876543"),
                            Description = "Label: Geffen Records – 5597742\r\nFormat: Vinyl, LP, Album, Limited Edition, Magenta, Alternative Artwork\r\nCountry: USA & Canada\r\nReleased: Sep 8, 2023\r\nGenre: Rock, Pop\r\nStyle: Alt-Pop, Pop Rock, Pop Punk, Alternative Rock",
                            ImagePath = "/images/image3.jpg",
                            Name = "Olivia Rodrigo – Guts (Limited Magenta Vinyl)",
                            Price = 5000m
                        },
                        new
                        {
                            Id = new Guid("7b9d48f3-8c6b-473a-a5f8-efbc12345678"),
                            Description = "Label: United Music Group – CDVP 4026577\r\nFormat: Vinyl, LP\r\nCountry: Russia\r\nReleased: Dec 21, 2023\r\nGenre: Rock\r\nStyle: Punk",
                            ImagePath = "/images/image4.jpg",
                            Name = "Король и Шут – Акустический альбом",
                            Price = 5500m
                        },
                        new
                        {
                            Id = new Guid("8cad89f2-9f7c-4c9e-a1f5-fe9876543210"),
                            Description = "Label: Kemosabe Records, RCA, Sony Music – 19439-45681-1\r\nFormat: 2xVinyl, LP, Album, Deluxe Edition, Stereo\r\nCountry: Europe\r\nReleased: May 27, 2022\r\nGenre: Hip Hop, Funk / Soul, Pop\r\nStyle: Pop Rap, Contemporary R&B, Dance-pop, Trap",
                            ImagePath = "/images/image5.jpg",
                            Name = "Doja Cat – Planet Her (Deluxe Edition)",
                            Price = 5500m
                        },
                        new
                        {
                            Id = new Guid("9dbeaafb-a068-4c7b-a123-fecba0987654"),
                            Description = "Label: Republic Records – B0032823-01, B0032754-01, B0032752-01\r\nFormat: 2xVinyl, LP, Album, Red \"Meet Me Behind The Mall\"\r\nCountry: US\r\nReleased: Nov 20, 2020\r\nGenre: Rock, Pop, Folk, World, & Country\r\nStyle: Vocal, Indie Pop, Indie Rock, Ballad",
                            ImagePath = "/images/image6.jpg",
                            Name = "Taylor Swift – Folklore (Limited Red Vinyl)",
                            Price = 5500m
                        },
                        new
                        {
                            Id = new Guid("aeb4c6ad-ba89-4e4b-a234-fedcba987656"),
                            Description = "Label: Republic Records – 0245554218\r\nFormat: 2xVinyl, LP, Album, Special Edition, Tangerine, MPO Pressing\r\nCountry: Worldwide\r\nReleased: Oct 27, 2023\r\nGenre: Electronic, Pop\r\nStyle: Synth-pop, Ballad, Pop Rock",
                            ImagePath = "/images/image7.jpeg",
                            Name = "Taylor Swift – 1989 (Taylor's Version) (Tangerine Vinyl)",
                            Price = 5500m
                        },
                        new
                        {
                            Id = new Guid("b1a2c3d4-e5f6-4a7b-8c9d-0abcdef12345"),
                            Description = "Label: Aftermath Entertainment, Shady Records, Interscope Records, Web Entertainment – 602537645879\r\nFormat: 2xVinyl, LP, Album\r\nCountry: Europe\r\nReleased: 2013\r\nGenre: Hip Hop\r\nStyle: Pop Rap",
                            ImagePath = "/images/image8.jpg",
                            Name = "Eminem – The Marshall Mathers LP 2",
                            Price = 5500m
                        });
                });

            modelBuilder.Entity("OnlineShopWebApp.Models.Cart", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Carts");
                });

            modelBuilder.Entity("OnlineShopWebApp.Models.CartItem", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<Guid?>("CartId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("OrderId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<Guid>("ProductId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("CartId");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId");

                    b.ToTable("CartItems");
                });

            modelBuilder.Entity("OnlineShopWebApp.Models.Order", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<Guid>("UserOrderInfoId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserOrderInfoId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("OnlineShopWebApp.Models.UserOrderInfo", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("UserOrderInfo");
                });

            modelBuilder.Entity("OnlineShopWebApp.Models.CartItem", b =>
                {
                    b.HasOne("OnlineShopWebApp.Models.Cart", null)
                        .WithMany("Items")
                        .HasForeignKey("CartId");

                    b.HasOne("OnlineShopWebApp.Models.Order", null)
                        .WithMany("Items")
                        .HasForeignKey("OrderId");

                    b.HasOne("OnlineShop.Db.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("OnlineShopWebApp.Models.Order", b =>
                {
                    b.HasOne("OnlineShopWebApp.Models.UserOrderInfo", "UserOrderInfo")
                        .WithMany()
                        .HasForeignKey("UserOrderInfoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("UserOrderInfo");
                });

            modelBuilder.Entity("OnlineShopWebApp.Models.Cart", b =>
                {
                    b.Navigation("Items");
                });

            modelBuilder.Entity("OnlineShopWebApp.Models.Order", b =>
                {
                    b.Navigation("Items");
                });
#pragma warning restore 612, 618
        }
    }
}
