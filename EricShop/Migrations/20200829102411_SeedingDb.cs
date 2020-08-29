using Microsoft.EntityFrameworkCore.Migrations;

namespace EricShop.Migrations
{
    public partial class SeedingDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryDescription", "CategoryName" },
                values: new object[,]
                {
                    { 1, null, "Cleanse" },
                    { 2, null, "Treat" },
                    { 3, null, "Hydrate" },
                    { 4, null, "Sun Care" },
                    { 5, null, "Body" }
                });

            migrationBuilder.InsertData(
                table: "Aesops",
                columns: new[] { "AesopId", "CategoryId", "Description", "ImageThumbnailUrl", "ImageUrl", "IsInStock", "IsOnSale", "Name", "Price" },
                values: new object[,]
                {
                    { 1, 1, "A mild preparation enhanced with White Clay and fatty-acid rich botanicals to gently cleanse and effortlessly remove surface impurities.", "\\images\\thumbnails\\cleanser-small.jpg", "\\images\\cleanser.jpg", true, false, "Purifying Facial Cream Cleanser", 37.00m },
                    { 2, 1, "A non-drying daily cleanser enhanced with purifying Mandarin Rind to effectively cleanse the skin without disturbing its natural balance.", "\\images\\thumbnails\\cleanser2-small.jpg", "\\images\\cleanser2.jpg", true, true, "Amazing Face Cleanser", 35.00m },
                    { 3, 1, "An exceptionally gentle cleanser for daily use, enhanced with botanicals renowned for their soothing properties. Removes makeup effortlessly and rinses with ease.", "\\images\\thumbnails\\cleanser3-small.jpg", "\\Images\\cleanser3.jpg", true, false, "Gentle Facial Cleansing Milk", 37.00m },
                    { 4, 2, "A clarifying, clay-based formulation that cleanses skin of residual impurities, decongests and refreshes while delivering replenishing vegetable oils.", "\\images\\thumbnails\\treat-small.jpg", "\\images\\treat.jpg", true, false, "Primrose Facial Cleansing Masque", 43.00m },
                    { 5, 2, "An intensely hydrating masque designed to refresh, replenish and soften skin. A discreet finish makes it an ideal companion for long-haul flights.", "\\images\\thumbnails\\treat2-small.jpg", "\\images\\treat2.jpg", true, true, "Blue Chamomile Facial Hydrating Masque", 57.00m },
                    { 6, 2, "This gel formulation contains an impressive list of ingredients known for their astringent and soothing properties. Effective without stripping or dehydrating the skin.", "\\images\\thumbnails\\treat3-small.jpg", "\\images\\treat3.jpg", true, true, "Control", 25.00m },
                    { 7, 3, "A hydrating SPF15 formulation enhanced with calming botanicals and mineral-based Zinc Oxide, which forms a barrier to reflect sunlight without clogging pores.", "\\images\\thumbnails\\hydrate-small.jpg", "\\images\\hydrate.jpg", true, true, "Sage & Zinc Facial Hydrating Cream SPF15", 45.00m },
                    { 8, 3, "A lightweight, rapidly absorbed SPF25 hydrator that provides broad-spectrum protection against the damaging effects of UVA and UVB radiation.", "\\images\\thumbnails\\hydrate2-small.jpg", "\\images\\hydrate2.jpg", true, false, "Protective Facial Lotion SPF25", 60.00m },
                    { 9, 3, "A concentrated hydrating formulation boosted with botanicals renowned for their purifying, balancing and skin-softening properties.", "\\images\\thumbnails\\hydrate3-small.jpg", "\\images\\hydrate3.jpg", true, false, "Fabulous Face Oil", 59.00m },
                    { 10, 4, "A hydrating balm enhanced with UVA and UVB filters to shield lips from the sun's damaging rays, while botanical oils soften, hydrate and nourish. Formulated without silicone, paraffin, beeswax or other animal-derived ingredients.", "\\images\\thumbnails\\suncare-small.jpg", "\\images\\suncare.jpg", true, true, "Protective Lip Balm SPF30", 20.00m },
                    { 11, 4, "Broad-spectrum moisturising sunscreen with high SPF50 protection—formulated to provide up to four hours’ water resistance—with a lightweight skin feel and refreshing aroma.", "\\images\\thumbnails\\suncare2-small.jpg", "\\images\\suncare2.jpg", true, true, "Protective Body Lotion SPF50", 45.00m },
                    { 12, 4, "An after-sun hydrator enhanced with Aloe Vera and Panthenol to soften and soothe, and extracts of Petitgrain, Grapefruit and Lemon to cool, balance and refresh the skin.", "\\images\\thumbnails\\suncare3-small.jpg", "\\images\\suncare3.jpg", true, true, "Petitgrain Reviving Body Gel", 45.00m },
                    { 13, 5, "A richly emollient balm with a distinctively spicy aroma. Formulated with Shea Butter and oils of Wheat Germ and Sweet Almond to hydrate and nourish the skin.", "\\images\\thumbnails\\body-small.jpg", "\\images\\body.jpg", true, false, "Resolute Hydrating Body Balm", 105.00m },
                    { 14, 5, "An invigorating gentle gel cleanser formulated with oils of Mandarin and Bergamot Rind to banish grime and thoroughly refresh the skin.", "\\images\\thumbnails\\body2-small.jpg", "\\images\\body2.jpg", true, true, "Geranium Leaf Body Cleanser", 49.00m },
                    { 15, 5, "An invigorating blend of Pumice, Bamboo Stem, and purifying botanical oils that sloughs away tired cells and leaves skin cleansed and smooth, perfectly prepared for hydration.", "\\images\\thumbnails\\body3-small.jpg", "\\images\\body3.jpg", true, false, "Geranium Leaf Body Scrub", 40.00m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Aesops",
                keyColumn: "AesopId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Aesops",
                keyColumn: "AesopId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Aesops",
                keyColumn: "AesopId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Aesops",
                keyColumn: "AesopId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Aesops",
                keyColumn: "AesopId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Aesops",
                keyColumn: "AesopId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Aesops",
                keyColumn: "AesopId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Aesops",
                keyColumn: "AesopId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Aesops",
                keyColumn: "AesopId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Aesops",
                keyColumn: "AesopId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Aesops",
                keyColumn: "AesopId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Aesops",
                keyColumn: "AesopId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Aesops",
                keyColumn: "AesopId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Aesops",
                keyColumn: "AesopId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Aesops",
                keyColumn: "AesopId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 5);
        }
    }
}
