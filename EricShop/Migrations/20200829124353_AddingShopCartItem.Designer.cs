﻿// <auto-generated />
using System;
using EricShop.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EricShop.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20200829124353_AddingShopCartItem")]
    partial class AddingShopCartItem
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EricShop.Models.Aesop", b =>
                {
                    b.Property<int>("AesopId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageThumbnailUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsInStock")
                        .HasColumnType("bit");

                    b.Property<bool>("IsOnSale")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("AesopId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Aesops");

                    b.HasData(
                        new
                        {
                            AesopId = 1,
                            CategoryId = 1,
                            Description = "A mild preparation enhanced with White Clay and fatty-acid rich botanicals to gently cleanse and effortlessly remove surface impurities.",
                            ImageThumbnailUrl = "\\images\\thumbnails\\cleanser-small.jpg",
                            ImageUrl = "\\images\\cleanser.jpg",
                            IsInStock = true,
                            IsOnSale = false,
                            Name = "Purifying Facial Cream Cleanser",
                            Price = 37.00m
                        },
                        new
                        {
                            AesopId = 2,
                            CategoryId = 1,
                            Description = "A non-drying daily cleanser enhanced with purifying Mandarin Rind to effectively cleanse the skin without disturbing its natural balance.",
                            ImageThumbnailUrl = "\\images\\thumbnails\\cleanser2-small.jpg",
                            ImageUrl = "\\images\\cleanser2.jpg",
                            IsInStock = true,
                            IsOnSale = true,
                            Name = "Amazing Face Cleanser",
                            Price = 35.00m
                        },
                        new
                        {
                            AesopId = 3,
                            CategoryId = 1,
                            Description = "An exceptionally gentle cleanser for daily use, enhanced with botanicals renowned for their soothing properties. Removes makeup effortlessly and rinses with ease.",
                            ImageThumbnailUrl = "\\images\\thumbnails\\cleanser3-small.jpg",
                            ImageUrl = "\\Images\\cleanser3.jpg",
                            IsInStock = true,
                            IsOnSale = false,
                            Name = "Gentle Facial Cleansing Milk",
                            Price = 37.00m
                        },
                        new
                        {
                            AesopId = 4,
                            CategoryId = 2,
                            Description = "A clarifying, clay-based formulation that cleanses skin of residual impurities, decongests and refreshes while delivering replenishing vegetable oils.",
                            ImageThumbnailUrl = "\\images\\thumbnails\\treat-small.jpg",
                            ImageUrl = "\\images\\treat.jpg",
                            IsInStock = true,
                            IsOnSale = false,
                            Name = "Primrose Facial Cleansing Masque",
                            Price = 43.00m
                        },
                        new
                        {
                            AesopId = 5,
                            CategoryId = 2,
                            Description = "An intensely hydrating masque designed to refresh, replenish and soften skin. A discreet finish makes it an ideal companion for long-haul flights.",
                            ImageThumbnailUrl = "\\images\\thumbnails\\treat2-small.jpg",
                            ImageUrl = "\\images\\treat2.jpg",
                            IsInStock = true,
                            IsOnSale = true,
                            Name = "Blue Chamomile Facial Hydrating Masque",
                            Price = 57.00m
                        },
                        new
                        {
                            AesopId = 6,
                            CategoryId = 2,
                            Description = "This gel formulation contains an impressive list of ingredients known for their astringent and soothing properties. Effective without stripping or dehydrating the skin.",
                            ImageThumbnailUrl = "\\images\\thumbnails\\treat3-small.jpg",
                            ImageUrl = "\\images\\treat3.jpg",
                            IsInStock = true,
                            IsOnSale = true,
                            Name = "Control",
                            Price = 25.00m
                        },
                        new
                        {
                            AesopId = 7,
                            CategoryId = 3,
                            Description = "A hydrating SPF15 formulation enhanced with calming botanicals and mineral-based Zinc Oxide, which forms a barrier to reflect sunlight without clogging pores.",
                            ImageThumbnailUrl = "\\images\\thumbnails\\hydrate-small.jpg",
                            ImageUrl = "\\images\\hydrate.jpg",
                            IsInStock = true,
                            IsOnSale = true,
                            Name = "Sage & Zinc Facial Hydrating Cream SPF15",
                            Price = 45.00m
                        },
                        new
                        {
                            AesopId = 8,
                            CategoryId = 3,
                            Description = "A lightweight, rapidly absorbed SPF25 hydrator that provides broad-spectrum protection against the damaging effects of UVA and UVB radiation.",
                            ImageThumbnailUrl = "\\images\\thumbnails\\hydrate2-small.jpg",
                            ImageUrl = "\\images\\hydrate2.jpg",
                            IsInStock = true,
                            IsOnSale = false,
                            Name = "Protective Facial Lotion SPF25",
                            Price = 60.00m
                        },
                        new
                        {
                            AesopId = 9,
                            CategoryId = 3,
                            Description = "A concentrated hydrating formulation boosted with botanicals renowned for their purifying, balancing and skin-softening properties.",
                            ImageThumbnailUrl = "\\images\\thumbnails\\hydrate3-small.jpg",
                            ImageUrl = "\\images\\hydrate3.jpg",
                            IsInStock = true,
                            IsOnSale = false,
                            Name = "Fabulous Face Oil",
                            Price = 59.00m
                        },
                        new
                        {
                            AesopId = 10,
                            CategoryId = 4,
                            Description = "A hydrating balm enhanced with UVA and UVB filters to shield lips from the sun's damaging rays, while botanical oils soften, hydrate and nourish. Formulated without silicone, paraffin, beeswax or other animal-derived ingredients.",
                            ImageThumbnailUrl = "\\images\\thumbnails\\suncare-small.jpg",
                            ImageUrl = "\\images\\suncare.jpg",
                            IsInStock = true,
                            IsOnSale = true,
                            Name = "Protective Lip Balm SPF30",
                            Price = 20.00m
                        },
                        new
                        {
                            AesopId = 11,
                            CategoryId = 4,
                            Description = "Broad-spectrum moisturising sunscreen with high SPF50 protection—formulated to provide up to four hours’ water resistance—with a lightweight skin feel and refreshing aroma.",
                            ImageThumbnailUrl = "\\images\\thumbnails\\suncare2-small.jpg",
                            ImageUrl = "\\images\\suncare2.jpg",
                            IsInStock = true,
                            IsOnSale = true,
                            Name = "Protective Body Lotion SPF50",
                            Price = 45.00m
                        },
                        new
                        {
                            AesopId = 12,
                            CategoryId = 4,
                            Description = "An after-sun hydrator enhanced with Aloe Vera and Panthenol to soften and soothe, and extracts of Petitgrain, Grapefruit and Lemon to cool, balance and refresh the skin.",
                            ImageThumbnailUrl = "\\images\\thumbnails\\suncare3-small.jpg",
                            ImageUrl = "\\images\\suncare3.jpg",
                            IsInStock = true,
                            IsOnSale = true,
                            Name = "Petitgrain Reviving Body Gel",
                            Price = 45.00m
                        },
                        new
                        {
                            AesopId = 13,
                            CategoryId = 5,
                            Description = "A richly emollient balm with a distinctively spicy aroma. Formulated with Shea Butter and oils of Wheat Germ and Sweet Almond to hydrate and nourish the skin.",
                            ImageThumbnailUrl = "\\images\\thumbnails\\body-small.jpg",
                            ImageUrl = "\\images\\body.jpg",
                            IsInStock = true,
                            IsOnSale = false,
                            Name = "Resolute Hydrating Body Balm",
                            Price = 105.00m
                        },
                        new
                        {
                            AesopId = 14,
                            CategoryId = 5,
                            Description = "An invigorating gentle gel cleanser formulated with oils of Mandarin and Bergamot Rind to banish grime and thoroughly refresh the skin.",
                            ImageThumbnailUrl = "\\images\\thumbnails\\body2-small.jpg",
                            ImageUrl = "\\images\\body2.jpg",
                            IsInStock = true,
                            IsOnSale = true,
                            Name = "Geranium Leaf Body Cleanser",
                            Price = 49.00m
                        },
                        new
                        {
                            AesopId = 15,
                            CategoryId = 5,
                            Description = "An invigorating blend of Pumice, Bamboo Stem, and purifying botanical oils that sloughs away tired cells and leaves skin cleansed and smooth, perfectly prepared for hydration.",
                            ImageThumbnailUrl = "\\images\\thumbnails\\body3-small.jpg",
                            ImageUrl = "\\images\\body3.jpg",
                            IsInStock = true,
                            IsOnSale = false,
                            Name = "Geranium Leaf Body Scrub",
                            Price = 40.00m
                        });
                });

            modelBuilder.Entity("EricShop.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            CategoryName = "Cleanse"
                        },
                        new
                        {
                            CategoryId = 2,
                            CategoryName = "Treat"
                        },
                        new
                        {
                            CategoryId = 3,
                            CategoryName = "Hydrate"
                        },
                        new
                        {
                            CategoryId = 4,
                            CategoryName = "Sun Care"
                        },
                        new
                        {
                            CategoryId = 5,
                            CategoryName = "Body"
                        });
                });

            modelBuilder.Entity("EricShop.Models.ShopCartItem", b =>
                {
                    b.Property<int>("ShopCartItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AesopId")
                        .HasColumnType("int");

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<string>("ShopCartId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ShopCartItemId");

                    b.HasIndex("AesopId");

                    b.ToTable("ShopCartItems");
                });

            modelBuilder.Entity("EricShop.Models.Aesop", b =>
                {
                    b.HasOne("EricShop.Models.Category", "Category")
                        .WithMany("Aesops")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EricShop.Models.ShopCartItem", b =>
                {
                    b.HasOne("EricShop.Models.Aesop", "Aesop")
                        .WithMany()
                        .HasForeignKey("AesopId");
                });
#pragma warning restore 612, 618
        }
    }
}
