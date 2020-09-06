using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EricShop.Models
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) :
            base(options)
        {
        }

        public static object Aesop { get; internal set; }
        public DbSet<Aesop> Aesops { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ShopCartItem> ShopCartItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 1, CategoryName = "Cleanse" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 2, CategoryName = "Treat" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 3, CategoryName = "Hydrate" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 4, CategoryName = "Sun Care" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 5, CategoryName = "Body" });

            modelBuilder.Entity<Aesop>().HasData(new Aesop
            {
                AesopId = 1,
                Name = "Purifying Facial Cream Cleanser",
                Price = 37.00M,
                Description = "A mild preparation enhanced with White Clay and fatty-acid rich botanicals to gently cleanse and effortlessly remove surface impurities.",
                CategoryId = 1,
                ImageUrl = "\\images\\cleanser.jpg",
                ImageThumbnailUrl = "\\images\\thumbnails\\cleanser-small.jpg",
                IsInStock = true,
                IsOnSale = false
            });
            modelBuilder.Entity<Aesop>().HasData(new Aesop
            {
                AesopId = 2,
                Name = "Amazing Face Cleanser",
                Price = 35.00M,
                Description = "A non-drying daily cleanser enhanced with purifying Mandarin Rind to effectively cleanse the skin without disturbing its natural balance.",
                CategoryId = 1,
                ImageUrl = "\\images\\cleanser2.jpg",
                ImageThumbnailUrl = "\\images\\thumbnails\\cleanser2-small.jpg",
                IsInStock = true,
                IsOnSale = true
            });
            modelBuilder.Entity<Aesop>().HasData(new Aesop
            {
                AesopId = 3,
                Name = "Gentle Facial Cleansing Milk",
                Price = 37.00M,
                Description = "An exceptionally gentle cleanser for daily use, enhanced with botanicals renowned for their soothing properties. Removes makeup effortlessly and rinses with ease.",
                CategoryId = 1,
                ImageUrl = "\\Images\\cleanser3.jpg",
                ImageThumbnailUrl = "\\images\\thumbnails\\cleanser3-small.jpg",
                IsInStock = true,
                IsOnSale = false
            });
            modelBuilder.Entity<Aesop>().HasData(new Aesop
            {
                AesopId = 4,
                Name = "Primrose Facial Cleansing Masque",
                Price = 43.00M,
                Description = "A clarifying, clay-based formulation that cleanses skin of residual impurities, decongests and refreshes while delivering replenishing vegetable oils.",
                CategoryId = 2,
                ImageUrl = "\\images\\treat.jpg",
                ImageThumbnailUrl = "\\images\\thumbnails\\treat-small.jpg",
                IsInStock = true,
                IsOnSale = false
            });
            modelBuilder.Entity<Aesop>().HasData(new Aesop
            {
                AesopId = 5,
                Name = "Blue Chamomile Facial Hydrating Masque",
                Price = 57.00M,
                Description = "An intensely hydrating masque designed to refresh, replenish and soften skin. A discreet finish makes it an ideal companion for long-haul flights.",
                CategoryId = 2,
                ImageUrl = "\\images\\treat2.jpg",
                ImageThumbnailUrl = "\\images\\thumbnails\\treat2-small.jpg",
                IsInStock = true,
                IsOnSale = true
            });
            modelBuilder.Entity<Aesop>().HasData(new Aesop
            {
                AesopId = 6,
                Name = "Control",
                Price = 25.00M,
                Description = "This gel formulation contains an impressive list of ingredients known for their astringent and soothing properties. Effective without stripping or dehydrating the skin.",
                CategoryId = 2,
                ImageUrl = "\\images\\treat3.jpg",
                ImageThumbnailUrl = "\\images\\thumbnails\\treat3-small.jpg",
                IsInStock = true,
                IsOnSale = true
            });
            modelBuilder.Entity<Aesop>().HasData(new Aesop
            {
                AesopId = 7,
                Name = "Sage & Zinc Facial Hydrating Cream SPF15",
                Price = 45.00M,
                Description = "A hydrating SPF15 formulation enhanced with calming botanicals and mineral-based Zinc Oxide, which forms a barrier to reflect sunlight without clogging pores.",
                CategoryId = 3,
                ImageUrl = "\\images\\hydrate.jpg",
                ImageThumbnailUrl = "\\images\\thumbnails\\hydrate-small.jpg",
                IsInStock = true,
                IsOnSale = true
            });
            modelBuilder.Entity<Aesop>().HasData(new Aesop
            {
                AesopId = 8,
                Name = "Protective Facial Lotion SPF25",
                Price = 60.00M,
                Description = "A lightweight, rapidly absorbed SPF25 hydrator that provides broad-spectrum protection against the damaging effects of UVA and UVB radiation.",
                CategoryId = 3,
                ImageUrl = "\\images\\hydrate2.jpg",
                ImageThumbnailUrl = "\\images\\thumbnails\\hydrate2-small.jpg",
                IsInStock = true,
                IsOnSale = false
            });
            modelBuilder.Entity<Aesop>().HasData(new Aesop
            {
                AesopId = 9,
                Name = "Fabulous Face Oil",
                Price = 59.00M,
                Description = "A concentrated hydrating formulation boosted with botanicals renowned for their purifying, balancing and skin-softening properties.",
                CategoryId = 3,
                ImageUrl = "\\images\\hydrate3.jpg",
                ImageThumbnailUrl = "\\images\\thumbnails\\hydrate3-small.jpg",
                IsInStock = true,
                IsOnSale = false
            });
            modelBuilder.Entity<Aesop>().HasData(new Aesop
            {
                AesopId = 10,
                Name = "Protective Lip Balm SPF30",
                Price = 20.00M,
                Description = "A hydrating balm enhanced with UVA and UVB filters to shield lips from the sun's damaging rays, while botanical oils soften, hydrate and nourish. Formulated without silicone, paraffin, beeswax or other animal-derived ingredients.",
                CategoryId = 4,
                ImageUrl = "\\images\\suncare.jpg",
                ImageThumbnailUrl = "\\images\\thumbnails\\suncare-small.jpg",
                IsInStock = true,
                IsOnSale = true
            });
            modelBuilder.Entity<Aesop>().HasData(new Aesop
            {
                AesopId = 11,
                Name = "Protective Body Lotion SPF50",
                Price = 45.00M,
                Description = "Broad-spectrum moisturising sunscreen with high SPF50 protection—formulated to provide up to four hours’ water resistance—with a lightweight skin feel and refreshing aroma.",
                CategoryId = 4,
                ImageUrl = "\\images\\suncare2.jpg",
                ImageThumbnailUrl = "\\images\\thumbnails\\suncare2-small.jpg",
                IsInStock = true,
                IsOnSale = true
            });
            modelBuilder.Entity<Aesop>().HasData(new Aesop
            {
                AesopId = 12,
                Name = "Petitgrain Reviving Body Gel",
                Price = 45.00M,
                Description = "An after-sun hydrator enhanced with Aloe Vera and Panthenol to soften and soothe, and extracts of Petitgrain, Grapefruit and Lemon to cool, balance and refresh the skin.",
                CategoryId = 4,
                ImageUrl = "\\images\\suncare3.jpg",
                ImageThumbnailUrl = "\\images\\thumbnails\\suncare3-small.jpg",
                IsInStock = true,
                IsOnSale = true
            });
            modelBuilder.Entity<Aesop>().HasData(new Aesop
            {
                AesopId = 13,
                Name = "Resolute Hydrating Body Balm",
                Price = 105.00M,
                Description = "A richly emollient balm with a distinctively spicy aroma. Formulated with Shea Butter and oils of Wheat Germ and Sweet Almond to hydrate and nourish the skin.",
                CategoryId = 5,
                ImageUrl = "\\images\\body.jpg",
                ImageThumbnailUrl = "\\images\\thumbnails\\body-small.jpg",
                IsInStock = true,
                IsOnSale = false
            });
            modelBuilder.Entity<Aesop>().HasData(new Aesop
            {
                AesopId = 14,
                Name = "Geranium Leaf Body Cleanser",
                Price = 49.00M,
                Description = "An invigorating gentle gel cleanser formulated with oils of Mandarin and Bergamot Rind to banish grime and thoroughly refresh the skin.",
                CategoryId = 5,
                ImageUrl = "\\images\\body2.jpg",
                ImageThumbnailUrl = "\\images\\thumbnails\\body2-small.jpg",
                IsInStock = true,
                IsOnSale = true
            });
            modelBuilder.Entity<Aesop>().HasData(new Aesop
            {
                AesopId = 15,
                Name = "Geranium Leaf Body Scrub",
                Price = 40.00M,
                Description = "An invigorating blend of Pumice, Bamboo Stem, and purifying botanical oils that sloughs away tired cells and leaves skin cleansed and smooth, perfectly prepared for hydration.",
                CategoryId = 5,
                ImageUrl = "\\images\\body3.jpg",
                ImageThumbnailUrl = "\\images\\thumbnails\\body3-small.jpg",
                IsInStock = true,
                IsOnSale = false
            });
        }
    }
}