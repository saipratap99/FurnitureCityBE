using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FurnitureCityBE.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("44a1f781-0906-45a0-888f-041790c7603f"), "Office" },
                    { new Guid("94d4fdb7-b1b7-4b42-aea4-08dc058baf26"), "Bedroom" },
                    { new Guid("e06629eb-de6b-41e1-b4e9-01d6bac0a3c0"), "Living Room" }
                });

            migrationBuilder.InsertData(
                table: "ProductTags",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("06a2a48e-7b25-4f81-a16c-673a8568d133"), "Ergonomic" },
                    { new Guid("c318fb93-4a9c-4548-ae4a-b84fea9c848a"), "Modern" },
                    { new Guid("f9fdba4d-7b4a-4e0f-b878-c35dbff9d0c4"), "Luxury" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "IsActive", "Name", "Price", "Quantity", "SubCategoryId" },
                values: new object[,]
                {
                    { new Guid("25b2463a-66f1-4ad7-aab4-b76ed06d0010"), "Perfect for kids, this bunk bed includes under-bed storage drawers.", true, "Bunk Bed with Storage", 799.99m, 5, new Guid("836856cc-e6bc-4acd-9dcb-eb18da4f2b10") },
                    { new Guid("8a7dc4f1-0cd7-4656-ab2b-5f16c02e79dc"), "A solid wooden bed frame with a classic finish.", true, "Queen Size Wooden Bed", 699.99m, 20, new Guid("836856cc-e6bc-4acd-9dcb-eb18da4f2b10") },
                    { new Guid("b04c2804-d56b-4ae8-b5df-560d3eb1d587"), "A luxurious bed with a tufted headboard and sturdy build.", true, "King Size Upholstered Bed", 999.99m, 10, new Guid("836856cc-e6bc-4acd-9dcb-eb18da4f2b10") },
                    { new Guid("b86211f6-b630-4d59-8985-af355f118fec"), "A spacious and comfortable king-size bed.", true, "King Size Bed", 799.99m, 5, new Guid("836856cc-e6bc-4acd-9dcb-eb18da4f2b10") }
                });

            migrationBuilder.InsertData(
                table: "SubCategories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("91cc1981-42f6-4176-854b-c06a6f12fd31"), "Desks" },
                    { new Guid("94d4fdb7-b1b7-4b42-aea4-08dc058baf26"), "Bedroom" },
                    { new Guid("f106601e-296d-4c77-a7f3-522015498e3c"), "Sofas" }
                });

            migrationBuilder.InsertData(
                table: "CategorySubCategoryMappings",
                columns: new[] { "Id", "CategoryId", "SubCategoryId" },
                values: new object[,]
                {
                    { new Guid("517f0459-1a82-45e3-8081-b759d1d48d21"), new Guid("e06629eb-de6b-41e1-b4e9-01d6bac0a3c0"), new Guid("f106601e-296d-4c77-a7f3-522015498e3c") },
                    { new Guid("6ea2bf9b-b619-4de9-b162-2b65d4a15d12"), new Guid("836856cc-e6bc-4acd-9dcb-eb18da4f2b10"), new Guid("91cc1981-42f6-4176-854b-c06a6f12fd31") },
                    { new Guid("a124cd66-0db9-4f24-a6e3-89d5c7c07211"), new Guid("94d4fdb7-b1b7-4b42-aea4-08dc058baf26"), new Guid("836856cc-e6bc-4acd-9dcb-eb18da4f2b10") },
                    { new Guid("a15376b5-dc61-422c-9317-d0b69e719569"), new Guid("836856cc-e6bc-4acd-9dcb-eb18da4f2b10"), new Guid("f106601e-296d-4c77-a7f3-522015498e3c") },
                    { new Guid("b92fde30-b3f4-40ff-a4da-49a3cd0dcd91"), new Guid("44a1f781-0906-45a0-888f-041790c7603f"), new Guid("f106601e-296d-4c77-a7f3-522015498e3c") },
                    { new Guid("d68a2856-4f82-4a2a-8b74-4d5fdd5d3187"), new Guid("44a1f781-0906-45a0-888f-041790c7603f"), new Guid("91cc1981-42f6-4176-854b-c06a6f12fd31") }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "IsActive", "Name", "Price", "Quantity", "SubCategoryId" },
                values: new object[,]
                {
                    { new Guid("0970b6bd-8ac1-4d61-93d6-b58439b49892"), "A spacious executive desk with a rich mahogany finish.", true, "Executive Wooden Desk", 899.99m, 7, new Guid("91cc1981-42f6-4176-854b-c06a6f12fd31") },
                    { new Guid("1435a859-24e6-4def-a1a9-f4f0ae3e26fc"), "A height-adjustable ergonomic desk for your office.", true, "Ergonomic Office Desk", 299.99m, 8, new Guid("91cc1981-42f6-4176-854b-c06a6f12fd31") },
                    { new Guid("229447be-26b1-4a27-bb41-0c1486a9ea1d"), "A spacious and comfortable sectional sofa perfect for family gatherings.", true, "Sectional Fabric Sofa", 899.99m, 10, new Guid("f106601e-296d-4c77-a7f3-522015498e3c") },
                    { new Guid("3b94a910-ea37-48ea-93b6-5e937360e9fc"), "A sleek leather sofa that adds sophistication to any living room.", true, "Modern Leather Sofa", 799.99m, 15, new Guid("f106601e-296d-4c77-a7f3-522015498e3c") },
                    { new Guid("512127a0-4501-4b21-af06-0f390183eade"), "A multi-functional sofa bed with a contemporary design.", true, "Convertible Sofa Bed", 499.99m, 8, new Guid("f106601e-296d-4c77-a7f3-522015498e3c") },
                    { new Guid("6075317b-3e06-4210-a0e0-78dd50ff9e60"), "A minimalist computer desk with a sleek design.", true, "Compact Computer Desk", 199.99m, 20, new Guid("91cc1981-42f6-4176-854b-c06a6f12fd31") },
                    { new Guid("972f1963-e72b-4614-b0ba-237a16c21161"), "A stylish modern sofa for your living room.", true, "Modern Sofa", 599.99m, 10, new Guid("f106601e-296d-4c77-a7f3-522015498e3c") },
                    { new Guid("b05f69f3-6a0d-45de-9df4-254636f13161"), "A height-adjustable desk designed for ergonomic office setups.", true, "Adjustable Standing Desk", 399.99m, 12, new Guid("91cc1981-42f6-4176-854b-c06a6f12fd31") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CategorySubCategoryMappings",
                keyColumn: "Id",
                keyValue: new Guid("517f0459-1a82-45e3-8081-b759d1d48d21"));

            migrationBuilder.DeleteData(
                table: "CategorySubCategoryMappings",
                keyColumn: "Id",
                keyValue: new Guid("6ea2bf9b-b619-4de9-b162-2b65d4a15d12"));

            migrationBuilder.DeleteData(
                table: "CategorySubCategoryMappings",
                keyColumn: "Id",
                keyValue: new Guid("a124cd66-0db9-4f24-a6e3-89d5c7c07211"));

            migrationBuilder.DeleteData(
                table: "CategorySubCategoryMappings",
                keyColumn: "Id",
                keyValue: new Guid("a15376b5-dc61-422c-9317-d0b69e719569"));

            migrationBuilder.DeleteData(
                table: "CategorySubCategoryMappings",
                keyColumn: "Id",
                keyValue: new Guid("b92fde30-b3f4-40ff-a4da-49a3cd0dcd91"));

            migrationBuilder.DeleteData(
                table: "CategorySubCategoryMappings",
                keyColumn: "Id",
                keyValue: new Guid("d68a2856-4f82-4a2a-8b74-4d5fdd5d3187"));

            migrationBuilder.DeleteData(
                table: "ProductTags",
                keyColumn: "Id",
                keyValue: new Guid("06a2a48e-7b25-4f81-a16c-673a8568d133"));

            migrationBuilder.DeleteData(
                table: "ProductTags",
                keyColumn: "Id",
                keyValue: new Guid("c318fb93-4a9c-4548-ae4a-b84fea9c848a"));

            migrationBuilder.DeleteData(
                table: "ProductTags",
                keyColumn: "Id",
                keyValue: new Guid("f9fdba4d-7b4a-4e0f-b878-c35dbff9d0c4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0970b6bd-8ac1-4d61-93d6-b58439b49892"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1435a859-24e6-4def-a1a9-f4f0ae3e26fc"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("229447be-26b1-4a27-bb41-0c1486a9ea1d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("25b2463a-66f1-4ad7-aab4-b76ed06d0010"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3b94a910-ea37-48ea-93b6-5e937360e9fc"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("512127a0-4501-4b21-af06-0f390183eade"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6075317b-3e06-4210-a0e0-78dd50ff9e60"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8a7dc4f1-0cd7-4656-ab2b-5f16c02e79dc"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("972f1963-e72b-4614-b0ba-237a16c21161"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b04c2804-d56b-4ae8-b5df-560d3eb1d587"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b05f69f3-6a0d-45de-9df4-254636f13161"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b86211f6-b630-4d59-8985-af355f118fec"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("94d4fdb7-b1b7-4b42-aea4-08dc058baf26"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("44a1f781-0906-45a0-888f-041790c7603f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("94d4fdb7-b1b7-4b42-aea4-08dc058baf26"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e06629eb-de6b-41e1-b4e9-01d6bac0a3c0"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("91cc1981-42f6-4176-854b-c06a6f12fd31"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("f106601e-296d-4c77-a7f3-522015498e3c"));
        }
    }
}
