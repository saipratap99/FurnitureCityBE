using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FurnitureCityBE.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreatenow : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CategorySubCategoryMappings_Categories_CategoryId",
                table: "CategorySubCategoryMappings");

            migrationBuilder.DropForeignKey(
                name: "FK_CategorySubCategoryMappings_SubCategories_SubCategoryId",
                table: "CategorySubCategoryMappings");

            migrationBuilder.DropForeignKey(
                name: "FK_Invoices_Orders_OrderId",
                table: "Invoices");

            migrationBuilder.DropForeignKey(
                name: "FK_LeadHistories_Leads_LeadId",
                table: "LeadHistories");

            migrationBuilder.DropForeignKey(
                name: "FK_Leads_ContactUs_ContactUsId",
                table: "Leads");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderItems_Orders_OrderId",
                table: "OrderItems");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Users_UserId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductImages_Products_ProductId",
                table: "ProductImages");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductReviews_Products_ProductId",
                table: "ProductReviews");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductReviews_Users_UserId",
                table: "ProductReviews");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_SubCategories_SubCategoryId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductTagsMappings_ProductTags_ProductTagId",
                table: "ProductTagsMappings");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductTagsMappings_Products_ProductId",
                table: "ProductTagsMappings");

            migrationBuilder.DropForeignKey(
                name: "FK_SavedAddresses_Addresses_AddressId",
                table: "SavedAddresses");

            migrationBuilder.DropForeignKey(
                name: "FK_SavedAddresses_Users_UserId",
                table: "SavedAddresses");

            migrationBuilder.DropForeignKey(
                name: "FK_ShipmentStatuses_Orders_OrderId",
                table: "ShipmentStatuses");

            migrationBuilder.DropForeignKey(
                name: "FK_StoreLocations_Addresses_AddressId",
                table: "StoreLocations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Testimonials",
                table: "Testimonials");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ShipmentStatuses",
                table: "ShipmentStatuses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductTags",
                table: "ProductTags");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Products",
                table: "Products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Orders",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_UserId",
                table: "Orders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OrderItems",
                table: "OrderItems");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ContactUs",
                table: "ContactUs");

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

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "LeadStartDate",
                table: "Leads");

            migrationBuilder.DropColumn(
                name: "NetAmount",
                table: "Invoices");

            migrationBuilder.RenameColumn(
                name: "Role",
                table: "Users",
                newName: "role");

            migrationBuilder.RenameColumn(
                name: "Password",
                table: "Users",
                newName: "password");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Users",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Mobile",
                table: "Users",
                newName: "mobile");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "Users",
                newName: "email");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Users",
                newName: "user_id");

            migrationBuilder.RenameColumn(
                name: "TestimonialText",
                table: "Testimonials",
                newName: "testimonialText");

            migrationBuilder.RenameColumn(
                name: "Role",
                table: "Testimonials",
                newName: "role");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Testimonials",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Date",
                table: "Testimonials",
                newName: "date");

            migrationBuilder.RenameColumn(
                name: "Company",
                table: "Testimonials",
                newName: "company");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Testimonials",
                newName: "user_id");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "SubCategories",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "SubCategories",
                newName: "subcategory_id");

            migrationBuilder.RenameColumn(
                name: "StoreStartDate",
                table: "StoreLocations",
                newName: "storeStartDate");

            migrationBuilder.RenameColumn(
                name: "AddressId",
                table: "StoreLocations",
                newName: "address_id");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "StoreLocations",
                newName: "store_location_id");

            migrationBuilder.RenameIndex(
                name: "IX_StoreLocations_AddressId",
                table: "StoreLocations",
                newName: "IX_StoreLocations_address_id");

            migrationBuilder.RenameColumn(
                name: "Status",
                table: "ShipmentStatuses",
                newName: "status");

            migrationBuilder.RenameColumn(
                name: "OrderId",
                table: "ShipmentStatuses",
                newName: "order_id");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "ShipmentStatuses",
                newName: "address_id");

            migrationBuilder.RenameIndex(
                name: "IX_ShipmentStatuses_OrderId",
                table: "ShipmentStatuses",
                newName: "IX_ShipmentStatuses_order_id");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "SavedAddresses",
                newName: "user_id");

            migrationBuilder.RenameColumn(
                name: "AddressId",
                table: "SavedAddresses",
                newName: "address_id");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "SavedAddresses",
                newName: "saved_address_id");

            migrationBuilder.RenameIndex(
                name: "IX_SavedAddresses_UserId",
                table: "SavedAddresses",
                newName: "IX_SavedAddresses_user_id");

            migrationBuilder.RenameIndex(
                name: "IX_SavedAddresses_AddressId",
                table: "SavedAddresses",
                newName: "IX_SavedAddresses_address_id");

            migrationBuilder.RenameColumn(
                name: "ProductTagId",
                table: "ProductTagsMappings",
                newName: "product_tag_id");

            migrationBuilder.RenameColumn(
                name: "ProductId",
                table: "ProductTagsMappings",
                newName: "product_id");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "ProductTagsMappings",
                newName: "prod_prodTag_id");

            migrationBuilder.RenameIndex(
                name: "IX_ProductTagsMappings_ProductTagId",
                table: "ProductTagsMappings",
                newName: "IX_ProductTagsMappings_product_tag_id");

            migrationBuilder.RenameIndex(
                name: "IX_ProductTagsMappings_ProductId",
                table: "ProductTagsMappings",
                newName: "IX_ProductTagsMappings_product_id");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "ProductTags",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "ProductTags",
                newName: "retailer_id");

            migrationBuilder.RenameColumn(
                name: "Quantity",
                table: "Products",
                newName: "quantity");

            migrationBuilder.RenameColumn(
                name: "Price",
                table: "Products",
                newName: "price");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Products",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "IsActive",
                table: "Products",
                newName: "isActive");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Products",
                newName: "description");

            migrationBuilder.RenameColumn(
                name: "SubCategoryId",
                table: "Products",
                newName: "subcategory_id");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Products",
                newName: "retailer_id");

            migrationBuilder.RenameIndex(
                name: "IX_Products_SubCategoryId",
                table: "Products",
                newName: "IX_Products_subcategory_id");

            migrationBuilder.RenameColumn(
                name: "Rating",
                table: "ProductReviews",
                newName: "rating");

            migrationBuilder.RenameColumn(
                name: "Comments",
                table: "ProductReviews",
                newName: "comments");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "ProductReviews",
                newName: "user_id");

            migrationBuilder.RenameColumn(
                name: "ProductId",
                table: "ProductReviews",
                newName: "product_id");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "ProductReviews",
                newName: "review_id");

            migrationBuilder.RenameIndex(
                name: "IX_ProductReviews_UserId",
                table: "ProductReviews",
                newName: "IX_ProductReviews_user_id");

            migrationBuilder.RenameIndex(
                name: "IX_ProductReviews_ProductId",
                table: "ProductReviews",
                newName: "IX_ProductReviews_product_id");

            migrationBuilder.RenameColumn(
                name: "ImageUrl",
                table: "ProductImages",
                newName: "imageUrl");

            migrationBuilder.RenameColumn(
                name: "AltText",
                table: "ProductImages",
                newName: "altText");

            migrationBuilder.RenameColumn(
                name: "ProductId",
                table: "ProductImages",
                newName: "product_id");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "ProductImages",
                newName: "p_image_id");

            migrationBuilder.RenameIndex(
                name: "IX_ProductImages_ProductId",
                table: "ProductImages",
                newName: "IX_ProductImages_product_id");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Orders",
                newName: "order_id");

            migrationBuilder.RenameColumn(
                name: "Status",
                table: "Orders",
                newName: "orderStatus");

            migrationBuilder.RenameColumn(
                name: "OrderId",
                table: "Orders",
                newName: "deliveryMethod");

            migrationBuilder.RenameColumn(
                name: "Quantity",
                table: "OrderItems",
                newName: "quantity");

            migrationBuilder.RenameColumn(
                name: "OrderId",
                table: "OrderItems",
                newName: "product_id");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "OrderItems",
                newName: "order_id");

            migrationBuilder.RenameIndex(
                name: "IX_OrderItems_OrderId",
                table: "OrderItems",
                newName: "IX_OrderItems_product_id");

            migrationBuilder.RenameColumn(
                name: "NextEnquiryDate",
                table: "Leads",
                newName: "nextEnquiryDate");

            migrationBuilder.RenameColumn(
                name: "LeadStatus",
                table: "Leads",
                newName: "leadStatus");

            migrationBuilder.RenameColumn(
                name: "ContactUsId",
                table: "Leads",
                newName: "contact_id");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Leads",
                newName: "leads_id");

            migrationBuilder.RenameIndex(
                name: "IX_Leads_ContactUsId",
                table: "Leads",
                newName: "IX_Leads_contact_id");

            migrationBuilder.RenameColumn(
                name: "Date",
                table: "LeadHistories",
                newName: "date");

            migrationBuilder.RenameColumn(
                name: "LeadId",
                table: "LeadHistories",
                newName: "leads_id");

            migrationBuilder.RenameColumn(
                name: "Comments",
                table: "LeadHistories",
                newName: "comment");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "LeadHistories",
                newName: "lead_history_id");

            migrationBuilder.RenameIndex(
                name: "IX_LeadHistories_LeadId",
                table: "LeadHistories",
                newName: "IX_LeadHistories_leads_id");

            migrationBuilder.RenameColumn(
                name: "TotalAmount",
                table: "Invoices",
                newName: "totalAmount");

            migrationBuilder.RenameColumn(
                name: "Date",
                table: "Invoices",
                newName: "date");

            migrationBuilder.RenameColumn(
                name: "TaxAmount",
                table: "Invoices",
                newName: "tax");

            migrationBuilder.RenameColumn(
                name: "OrderId",
                table: "Invoices",
                newName: "order_id");

            migrationBuilder.RenameColumn(
                name: "InvoiceNumber",
                table: "Invoices",
                newName: "number");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Invoices",
                newName: "invoice_id");

            migrationBuilder.RenameIndex(
                name: "IX_Invoices_OrderId",
                table: "Invoices",
                newName: "IX_Invoices_order_id");

            migrationBuilder.RenameColumn(
                name: "Subject",
                table: "ContactUs",
                newName: "subject");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "ContactUs",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "ContactUs",
                newName: "email");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "ContactUs",
                newName: "description");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "ContactUs",
                newName: "user_id");

            migrationBuilder.RenameColumn(
                name: "SubCategoryId",
                table: "CategorySubCategoryMappings",
                newName: "subcategory_id");

            migrationBuilder.RenameColumn(
                name: "CategoryId",
                table: "CategorySubCategoryMappings",
                newName: "category_id");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "CategorySubCategoryMappings",
                newName: "sub_cat_id");

            migrationBuilder.RenameIndex(
                name: "IX_CategorySubCategoryMappings_SubCategoryId",
                table: "CategorySubCategoryMappings",
                newName: "IX_CategorySubCategoryMappings_subcategory_id");

            migrationBuilder.RenameIndex(
                name: "IX_CategorySubCategoryMappings_CategoryId",
                table: "CategorySubCategoryMappings",
                newName: "IX_CategorySubCategoryMappings_category_id");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Categories",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Categories",
                newName: "category_id");

            migrationBuilder.RenameColumn(
                name: "Zipcode",
                table: "Addresses",
                newName: "zipcode");

            migrationBuilder.RenameColumn(
                name: "State",
                table: "Addresses",
                newName: "state");

            migrationBuilder.RenameColumn(
                name: "Road",
                table: "Addresses",
                newName: "road");

            migrationBuilder.RenameColumn(
                name: "City",
                table: "Addresses",
                newName: "city");

            migrationBuilder.RenameColumn(
                name: "AppartmentNo",
                table: "Addresses",
                newName: "aptNo");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Addresses",
                newName: "address_id");

            migrationBuilder.AddColumn<Guid>(
                name: "testimonial_id",
                table: "Testimonials",
                type: "char(36)",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "shipment_id",
                table: "ShipmentStatuses",
                type: "char(36)",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "product_tag_id",
                table: "ProductTags",
                type: "char(36)",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "product_id",
                table: "Products",
                type: "char(36)",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<DateTime>(
                name: "orderDate",
                table: "Orders",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "user_id",
                table: "Orders",
                type: "char(36)",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "order_item_id",
                table: "OrderItems",
                type: "char(36)",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "contact_id",
                table: "ContactUs",
                type: "char(36)",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddPrimaryKey(
                name: "PK_Testimonials",
                table: "Testimonials",
                column: "testimonial_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ShipmentStatuses",
                table: "ShipmentStatuses",
                column: "shipment_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductTags",
                table: "ProductTags",
                column: "product_tag_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Products",
                table: "Products",
                column: "product_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Orders",
                table: "Orders",
                column: "order_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrderItems",
                table: "OrderItems",
                column: "order_item_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ContactUs",
                table: "ContactUs",
                column: "contact_id");

            migrationBuilder.CreateTable(
                name: "Retailer",
                columns: table => new
                {
                    retailer_id = table.Column<Guid>(type: "char(36)", nullable: false),
                    name = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    contact_information = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Retailer", x => x.retailer_id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.InsertData(
                table: "CategorySubCategoryMappings",
                columns: new[] { "sub_cat_id", "category_id", "subcategory_id" },
                values: new object[,]
                {
                    { new Guid("22887437-d5f0-48e4-94d7-215c2bde5654"), new Guid("94d4fdb7-b1b7-4b42-aea4-08dc058baf26"), new Guid("91cc1981-42f6-4176-854b-c06a6f12fd31") },
                    { new Guid("40cff688-e8b2-43e3-9b6a-958c8df73a12"), new Guid("44a1f781-0906-45a0-888f-041790c7603f"), new Guid("f106601e-296d-4c77-a7f3-522015498e3c") },
                    { new Guid("563722c7-9ef0-47d8-a7d6-f03ab44187c8"), new Guid("e06629eb-de6b-41e1-b4e9-01d6bac0a3c0"), new Guid("f106601e-296d-4c77-a7f3-522015498e3c") },
                    { new Guid("e6dca120-9826-4ed4-a8a5-4d41b5a41816"), new Guid("94d4fdb7-b1b7-4b42-aea4-08dc058baf26"), new Guid("f106601e-296d-4c77-a7f3-522015498e3c") },
                    { new Guid("e9baa0ef-578b-46d4-9809-b2a9515033f4"), new Guid("44a1f781-0906-45a0-888f-041790c7603f"), new Guid("91cc1981-42f6-4176-854b-c06a6f12fd31") }
                });

            migrationBuilder.InsertData(
                table: "ProductTags",
                columns: new[] { "product_tag_id", "name", "retailer_id" },
                values: new object[,]
                {
                    { new Guid("03d18622-5b29-4e67-b38f-4689596c0b4d"), "Modern", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("d388b291-3104-4766-a595-d018a265f18b"), "Ergonomic", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("dae98516-53af-44b8-bb8e-3b72d2599fa4"), "Luxury", new Guid("00000000-0000-0000-0000-000000000000") }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "product_id", "description", "isActive", "name", "price", "quantity", "retailer_id", "subcategory_id" },
                values: new object[,]
                {
                    { new Guid("10b77aaa-9049-4b93-999c-489702d4383e"), "A sleek leather sofa that adds sophistication to any living room.", true, "Modern Leather Sofa", 799.99m, 15, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("f106601e-296d-4c77-a7f3-522015498e3c") },
                    { new Guid("402dd236-ed31-48a2-ab7f-59094a84a1b7"), "A height-adjustable ergonomic desk for your office.", true, "Ergonomic Office Desk", 299.99m, 8, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("91cc1981-42f6-4176-854b-c06a6f12fd31") },
                    { new Guid("652be6fb-3491-46b9-b13d-cab1636c2904"), "A spacious executive desk with a rich mahogany finish.", true, "Executive Wooden Desk", 899.99m, 7, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("91cc1981-42f6-4176-854b-c06a6f12fd31") },
                    { new Guid("7c874e54-8389-4fae-b103-66d60998313b"), "A multi-functional sofa bed with a contemporary design.", true, "Convertible Sofa Bed", 499.99m, 8, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("f106601e-296d-4c77-a7f3-522015498e3c") },
                    { new Guid("87baad24-b19f-47ba-a811-41f933c8c8ae"), "A minimalist computer desk with a sleek design.", true, "Compact Computer Desk", 199.99m, 20, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("91cc1981-42f6-4176-854b-c06a6f12fd31") },
                    { new Guid("9db1be38-b7d4-4158-ac8b-63a34ba72086"), "A stylish modern sofa for your living room.", true, "Modern Sofa", 599.99m, 10, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("f106601e-296d-4c77-a7f3-522015498e3c") },
                    { new Guid("b5027170-1409-4149-8355-1bd473263dad"), "A height-adjustable desk designed for ergonomic office setups.", true, "Adjustable Standing Desk", 399.99m, 12, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("91cc1981-42f6-4176-854b-c06a6f12fd31") },
                    { new Guid("c3bfe301-8dd5-4b71-a305-f7bd331cef33"), "A spacious and comfortable sectional sofa perfect for family gatherings.", true, "Sectional Fabric Sofa", 899.99m, 10, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("f106601e-296d-4c77-a7f3-522015498e3c") }
                });

            migrationBuilder.InsertData(
                table: "SubCategories",
                columns: new[] { "subcategory_id", "name" },
                values: new object[] { new Guid("836856cc-e6bc-4acd-9dcb-eb18da4f2b10"), "Beds" });

            migrationBuilder.InsertData(
                table: "CategorySubCategoryMappings",
                columns: new[] { "sub_cat_id", "category_id", "subcategory_id" },
                values: new object[] { new Guid("9dc3a5d3-0266-4485-ab65-9c55d95e1125"), new Guid("94d4fdb7-b1b7-4b42-aea4-08dc058baf26"), new Guid("836856cc-e6bc-4acd-9dcb-eb18da4f2b10") });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "product_id", "description", "isActive", "name", "price", "quantity", "retailer_id", "subcategory_id" },
                values: new object[,]
                {
                    { new Guid("0eaf08db-7561-4a34-8339-cf7a37ec7263"), "A solid wooden bed frame with a classic finish.", true, "Queen Size Wooden Bed", 699.99m, 20, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("836856cc-e6bc-4acd-9dcb-eb18da4f2b10") },
                    { new Guid("477eb6cf-b316-4320-b2e4-ee9f9bf5514f"), "Perfect for kids, this bunk bed includes under-bed storage drawers.", true, "Bunk Bed with Storage", 799.99m, 5, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("836856cc-e6bc-4acd-9dcb-eb18da4f2b10") },
                    { new Guid("bc5d166e-6adb-4552-981d-ff823d9d924c"), "A spacious and comfortable king-size bed.", true, "King Size Bed", 799.99m, 5, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("836856cc-e6bc-4acd-9dcb-eb18da4f2b10") },
                    { new Guid("dd83ca61-f6d4-4a1b-90dd-b4455424fc18"), "A luxurious bed with a tufted headboard and sturdy build.", true, "King Size Upholstered Bed", 999.99m, 10, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("836856cc-e6bc-4acd-9dcb-eb18da4f2b10") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Testimonials_user_id",
                table: "Testimonials",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "IX_ShipmentStatuses_address_id",
                table: "ShipmentStatuses",
                column: "address_id");

            migrationBuilder.CreateIndex(
                name: "IX_ProductTags_retailer_id",
                table: "ProductTags",
                column: "retailer_id");

            migrationBuilder.CreateIndex(
                name: "IX_Products_retailer_id",
                table: "Products",
                column: "retailer_id");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_user_id",
                table: "Orders",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_order_id",
                table: "OrderItems",
                column: "order_id");

            migrationBuilder.CreateIndex(
                name: "IX_ContactUs_user_id",
                table: "ContactUs",
                column: "user_id");

            migrationBuilder.AddForeignKey(
                name: "FK_CategorySubCategoryMappings_Categories_category_id",
                table: "CategorySubCategoryMappings",
                column: "category_id",
                principalTable: "Categories",
                principalColumn: "category_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CategorySubCategoryMappings_SubCategories_subcategory_id",
                table: "CategorySubCategoryMappings",
                column: "subcategory_id",
                principalTable: "SubCategories",
                principalColumn: "subcategory_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ContactUs_Orders_user_id",
                table: "ContactUs",
                column: "user_id",
                principalTable: "Orders",
                principalColumn: "order_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Invoices_Orders_order_id",
                table: "Invoices",
                column: "order_id",
                principalTable: "Orders",
                principalColumn: "order_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_LeadHistories_Leads_leads_id",
                table: "LeadHistories",
                column: "leads_id",
                principalTable: "Leads",
                principalColumn: "leads_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Leads_ContactUs_contact_id",
                table: "Leads",
                column: "contact_id",
                principalTable: "ContactUs",
                principalColumn: "contact_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItems_Orders_order_id",
                table: "OrderItems",
                column: "order_id",
                principalTable: "Orders",
                principalColumn: "order_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItems_Products_product_id",
                table: "OrderItems",
                column: "product_id",
                principalTable: "Products",
                principalColumn: "product_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Users_user_id",
                table: "Orders",
                column: "user_id",
                principalTable: "Users",
                principalColumn: "user_id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductImages_Products_product_id",
                table: "ProductImages",
                column: "product_id",
                principalTable: "Products",
                principalColumn: "product_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductReviews_Products_product_id",
                table: "ProductReviews",
                column: "product_id",
                principalTable: "Products",
                principalColumn: "product_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductReviews_Users_user_id",
                table: "ProductReviews",
                column: "user_id",
                principalTable: "Users",
                principalColumn: "user_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Retailer_retailer_id",
                table: "Products",
                column: "retailer_id",
                principalTable: "Retailer",
                principalColumn: "retailer_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_SubCategories_subcategory_id",
                table: "Products",
                column: "subcategory_id",
                principalTable: "SubCategories",
                principalColumn: "subcategory_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductTags_Retailer_retailer_id",
                table: "ProductTags",
                column: "retailer_id",
                principalTable: "Retailer",
                principalColumn: "retailer_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductTagsMappings_ProductTags_product_tag_id",
                table: "ProductTagsMappings",
                column: "product_tag_id",
                principalTable: "ProductTags",
                principalColumn: "product_tag_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductTagsMappings_Products_product_id",
                table: "ProductTagsMappings",
                column: "product_id",
                principalTable: "Products",
                principalColumn: "product_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SavedAddresses_Addresses_address_id",
                table: "SavedAddresses",
                column: "address_id",
                principalTable: "Addresses",
                principalColumn: "address_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SavedAddresses_Users_user_id",
                table: "SavedAddresses",
                column: "user_id",
                principalTable: "Users",
                principalColumn: "user_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ShipmentStatuses_Orders_address_id",
                table: "ShipmentStatuses",
                column: "address_id",
                principalTable: "Orders",
                principalColumn: "order_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ShipmentStatuses_Orders_order_id",
                table: "ShipmentStatuses",
                column: "order_id",
                principalTable: "Orders",
                principalColumn: "order_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StoreLocations_Addresses_address_id",
                table: "StoreLocations",
                column: "address_id",
                principalTable: "Addresses",
                principalColumn: "address_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Testimonials_Users_user_id",
                table: "Testimonials",
                column: "user_id",
                principalTable: "Users",
                principalColumn: "user_id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CategorySubCategoryMappings_Categories_category_id",
                table: "CategorySubCategoryMappings");

            migrationBuilder.DropForeignKey(
                name: "FK_CategorySubCategoryMappings_SubCategories_subcategory_id",
                table: "CategorySubCategoryMappings");

            migrationBuilder.DropForeignKey(
                name: "FK_ContactUs_Orders_user_id",
                table: "ContactUs");

            migrationBuilder.DropForeignKey(
                name: "FK_Invoices_Orders_order_id",
                table: "Invoices");

            migrationBuilder.DropForeignKey(
                name: "FK_LeadHistories_Leads_leads_id",
                table: "LeadHistories");

            migrationBuilder.DropForeignKey(
                name: "FK_Leads_ContactUs_contact_id",
                table: "Leads");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderItems_Orders_order_id",
                table: "OrderItems");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderItems_Products_product_id",
                table: "OrderItems");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Users_user_id",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductImages_Products_product_id",
                table: "ProductImages");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductReviews_Products_product_id",
                table: "ProductReviews");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductReviews_Users_user_id",
                table: "ProductReviews");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Retailer_retailer_id",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_SubCategories_subcategory_id",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductTags_Retailer_retailer_id",
                table: "ProductTags");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductTagsMappings_ProductTags_product_tag_id",
                table: "ProductTagsMappings");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductTagsMappings_Products_product_id",
                table: "ProductTagsMappings");

            migrationBuilder.DropForeignKey(
                name: "FK_SavedAddresses_Addresses_address_id",
                table: "SavedAddresses");

            migrationBuilder.DropForeignKey(
                name: "FK_SavedAddresses_Users_user_id",
                table: "SavedAddresses");

            migrationBuilder.DropForeignKey(
                name: "FK_ShipmentStatuses_Orders_address_id",
                table: "ShipmentStatuses");

            migrationBuilder.DropForeignKey(
                name: "FK_ShipmentStatuses_Orders_order_id",
                table: "ShipmentStatuses");

            migrationBuilder.DropForeignKey(
                name: "FK_StoreLocations_Addresses_address_id",
                table: "StoreLocations");

            migrationBuilder.DropForeignKey(
                name: "FK_Testimonials_Users_user_id",
                table: "Testimonials");

            migrationBuilder.DropTable(
                name: "Retailer");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Testimonials",
                table: "Testimonials");

            migrationBuilder.DropIndex(
                name: "IX_Testimonials_user_id",
                table: "Testimonials");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ShipmentStatuses",
                table: "ShipmentStatuses");

            migrationBuilder.DropIndex(
                name: "IX_ShipmentStatuses_address_id",
                table: "ShipmentStatuses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductTags",
                table: "ProductTags");

            migrationBuilder.DropIndex(
                name: "IX_ProductTags_retailer_id",
                table: "ProductTags");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Products",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_retailer_id",
                table: "Products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Orders",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_user_id",
                table: "Orders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OrderItems",
                table: "OrderItems");

            migrationBuilder.DropIndex(
                name: "IX_OrderItems_order_id",
                table: "OrderItems");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ContactUs",
                table: "ContactUs");

            migrationBuilder.DropIndex(
                name: "IX_ContactUs_user_id",
                table: "ContactUs");

            migrationBuilder.DeleteData(
                table: "CategorySubCategoryMappings",
                keyColumn: "sub_cat_id",
                keyValue: new Guid("22887437-d5f0-48e4-94d7-215c2bde5654"));

            migrationBuilder.DeleteData(
                table: "CategorySubCategoryMappings",
                keyColumn: "sub_cat_id",
                keyValue: new Guid("40cff688-e8b2-43e3-9b6a-958c8df73a12"));

            migrationBuilder.DeleteData(
                table: "CategorySubCategoryMappings",
                keyColumn: "sub_cat_id",
                keyValue: new Guid("563722c7-9ef0-47d8-a7d6-f03ab44187c8"));

            migrationBuilder.DeleteData(
                table: "CategorySubCategoryMappings",
                keyColumn: "sub_cat_id",
                keyValue: new Guid("9dc3a5d3-0266-4485-ab65-9c55d95e1125"));

            migrationBuilder.DeleteData(
                table: "CategorySubCategoryMappings",
                keyColumn: "sub_cat_id",
                keyValue: new Guid("e6dca120-9826-4ed4-a8a5-4d41b5a41816"));

            migrationBuilder.DeleteData(
                table: "CategorySubCategoryMappings",
                keyColumn: "sub_cat_id",
                keyValue: new Guid("e9baa0ef-578b-46d4-9809-b2a9515033f4"));

            migrationBuilder.DeleteData(
                table: "ProductTags",
                keyColumn: "product_tag_id",
                keyColumnType: "char(36)",
                keyValue: new Guid("03d18622-5b29-4e67-b38f-4689596c0b4d"));

            migrationBuilder.DeleteData(
                table: "ProductTags",
                keyColumn: "product_tag_id",
                keyColumnType: "char(36)",
                keyValue: new Guid("d388b291-3104-4766-a595-d018a265f18b"));

            migrationBuilder.DeleteData(
                table: "ProductTags",
                keyColumn: "product_tag_id",
                keyColumnType: "char(36)",
                keyValue: new Guid("dae98516-53af-44b8-bb8e-3b72d2599fa4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "product_id",
                keyColumnType: "char(36)",
                keyValue: new Guid("0eaf08db-7561-4a34-8339-cf7a37ec7263"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "product_id",
                keyColumnType: "char(36)",
                keyValue: new Guid("10b77aaa-9049-4b93-999c-489702d4383e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "product_id",
                keyColumnType: "char(36)",
                keyValue: new Guid("402dd236-ed31-48a2-ab7f-59094a84a1b7"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "product_id",
                keyColumnType: "char(36)",
                keyValue: new Guid("477eb6cf-b316-4320-b2e4-ee9f9bf5514f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "product_id",
                keyColumnType: "char(36)",
                keyValue: new Guid("652be6fb-3491-46b9-b13d-cab1636c2904"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "product_id",
                keyColumnType: "char(36)",
                keyValue: new Guid("7c874e54-8389-4fae-b103-66d60998313b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "product_id",
                keyColumnType: "char(36)",
                keyValue: new Guid("87baad24-b19f-47ba-a811-41f933c8c8ae"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "product_id",
                keyColumnType: "char(36)",
                keyValue: new Guid("9db1be38-b7d4-4158-ac8b-63a34ba72086"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "product_id",
                keyColumnType: "char(36)",
                keyValue: new Guid("b5027170-1409-4149-8355-1bd473263dad"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "product_id",
                keyColumnType: "char(36)",
                keyValue: new Guid("bc5d166e-6adb-4552-981d-ff823d9d924c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "product_id",
                keyColumnType: "char(36)",
                keyValue: new Guid("c3bfe301-8dd5-4b71-a305-f7bd331cef33"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "product_id",
                keyColumnType: "char(36)",
                keyValue: new Guid("dd83ca61-f6d4-4a1b-90dd-b4455424fc18"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "subcategory_id",
                keyValue: new Guid("836856cc-e6bc-4acd-9dcb-eb18da4f2b10"));

            migrationBuilder.DropColumn(
                name: "testimonial_id",
                table: "Testimonials");

            migrationBuilder.DropColumn(
                name: "shipment_id",
                table: "ShipmentStatuses");

            migrationBuilder.DropColumn(
                name: "product_tag_id",
                table: "ProductTags");

            migrationBuilder.DropColumn(
                name: "product_id",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "orderDate",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "user_id",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "order_item_id",
                table: "OrderItems");

            migrationBuilder.DropColumn(
                name: "contact_id",
                table: "ContactUs");

            migrationBuilder.RenameColumn(
                name: "role",
                table: "Users",
                newName: "Role");

            migrationBuilder.RenameColumn(
                name: "password",
                table: "Users",
                newName: "Password");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "Users",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "mobile",
                table: "Users",
                newName: "Mobile");

            migrationBuilder.RenameColumn(
                name: "email",
                table: "Users",
                newName: "Email");

            migrationBuilder.RenameColumn(
                name: "user_id",
                table: "Users",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "testimonialText",
                table: "Testimonials",
                newName: "TestimonialText");

            migrationBuilder.RenameColumn(
                name: "role",
                table: "Testimonials",
                newName: "Role");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "Testimonials",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "date",
                table: "Testimonials",
                newName: "Date");

            migrationBuilder.RenameColumn(
                name: "company",
                table: "Testimonials",
                newName: "Company");

            migrationBuilder.RenameColumn(
                name: "user_id",
                table: "Testimonials",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "SubCategories",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "subcategory_id",
                table: "SubCategories",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "storeStartDate",
                table: "StoreLocations",
                newName: "StoreStartDate");

            migrationBuilder.RenameColumn(
                name: "address_id",
                table: "StoreLocations",
                newName: "AddressId");

            migrationBuilder.RenameColumn(
                name: "store_location_id",
                table: "StoreLocations",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_StoreLocations_address_id",
                table: "StoreLocations",
                newName: "IX_StoreLocations_AddressId");

            migrationBuilder.RenameColumn(
                name: "status",
                table: "ShipmentStatuses",
                newName: "Status");

            migrationBuilder.RenameColumn(
                name: "order_id",
                table: "ShipmentStatuses",
                newName: "OrderId");

            migrationBuilder.RenameColumn(
                name: "address_id",
                table: "ShipmentStatuses",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_ShipmentStatuses_order_id",
                table: "ShipmentStatuses",
                newName: "IX_ShipmentStatuses_OrderId");

            migrationBuilder.RenameColumn(
                name: "user_id",
                table: "SavedAddresses",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "address_id",
                table: "SavedAddresses",
                newName: "AddressId");

            migrationBuilder.RenameColumn(
                name: "saved_address_id",
                table: "SavedAddresses",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_SavedAddresses_user_id",
                table: "SavedAddresses",
                newName: "IX_SavedAddresses_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_SavedAddresses_address_id",
                table: "SavedAddresses",
                newName: "IX_SavedAddresses_AddressId");

            migrationBuilder.RenameColumn(
                name: "product_tag_id",
                table: "ProductTagsMappings",
                newName: "ProductTagId");

            migrationBuilder.RenameColumn(
                name: "product_id",
                table: "ProductTagsMappings",
                newName: "ProductId");

            migrationBuilder.RenameColumn(
                name: "prod_prodTag_id",
                table: "ProductTagsMappings",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_ProductTagsMappings_product_tag_id",
                table: "ProductTagsMappings",
                newName: "IX_ProductTagsMappings_ProductTagId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductTagsMappings_product_id",
                table: "ProductTagsMappings",
                newName: "IX_ProductTagsMappings_ProductId");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "ProductTags",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "retailer_id",
                table: "ProductTags",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "quantity",
                table: "Products",
                newName: "Quantity");

            migrationBuilder.RenameColumn(
                name: "price",
                table: "Products",
                newName: "Price");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "Products",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "isActive",
                table: "Products",
                newName: "IsActive");

            migrationBuilder.RenameColumn(
                name: "description",
                table: "Products",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "subcategory_id",
                table: "Products",
                newName: "SubCategoryId");

            migrationBuilder.RenameColumn(
                name: "retailer_id",
                table: "Products",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_Products_subcategory_id",
                table: "Products",
                newName: "IX_Products_SubCategoryId");

            migrationBuilder.RenameColumn(
                name: "rating",
                table: "ProductReviews",
                newName: "Rating");

            migrationBuilder.RenameColumn(
                name: "comments",
                table: "ProductReviews",
                newName: "Comments");

            migrationBuilder.RenameColumn(
                name: "user_id",
                table: "ProductReviews",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "product_id",
                table: "ProductReviews",
                newName: "ProductId");

            migrationBuilder.RenameColumn(
                name: "review_id",
                table: "ProductReviews",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_ProductReviews_user_id",
                table: "ProductReviews",
                newName: "IX_ProductReviews_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductReviews_product_id",
                table: "ProductReviews",
                newName: "IX_ProductReviews_ProductId");

            migrationBuilder.RenameColumn(
                name: "imageUrl",
                table: "ProductImages",
                newName: "ImageUrl");

            migrationBuilder.RenameColumn(
                name: "altText",
                table: "ProductImages",
                newName: "AltText");

            migrationBuilder.RenameColumn(
                name: "product_id",
                table: "ProductImages",
                newName: "ProductId");

            migrationBuilder.RenameColumn(
                name: "p_image_id",
                table: "ProductImages",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_ProductImages_product_id",
                table: "ProductImages",
                newName: "IX_ProductImages_ProductId");

            migrationBuilder.RenameColumn(
                name: "orderStatus",
                table: "Orders",
                newName: "Status");

            migrationBuilder.RenameColumn(
                name: "deliveryMethod",
                table: "Orders",
                newName: "OrderId");

            migrationBuilder.RenameColumn(
                name: "order_id",
                table: "Orders",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "quantity",
                table: "OrderItems",
                newName: "Quantity");

            migrationBuilder.RenameColumn(
                name: "product_id",
                table: "OrderItems",
                newName: "OrderId");

            migrationBuilder.RenameColumn(
                name: "order_id",
                table: "OrderItems",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_OrderItems_product_id",
                table: "OrderItems",
                newName: "IX_OrderItems_OrderId");

            migrationBuilder.RenameColumn(
                name: "nextEnquiryDate",
                table: "Leads",
                newName: "NextEnquiryDate");

            migrationBuilder.RenameColumn(
                name: "leadStatus",
                table: "Leads",
                newName: "LeadStatus");

            migrationBuilder.RenameColumn(
                name: "contact_id",
                table: "Leads",
                newName: "ContactUsId");

            migrationBuilder.RenameColumn(
                name: "leads_id",
                table: "Leads",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_Leads_contact_id",
                table: "Leads",
                newName: "IX_Leads_ContactUsId");

            migrationBuilder.RenameColumn(
                name: "date",
                table: "LeadHistories",
                newName: "Date");

            migrationBuilder.RenameColumn(
                name: "leads_id",
                table: "LeadHistories",
                newName: "LeadId");

            migrationBuilder.RenameColumn(
                name: "comment",
                table: "LeadHistories",
                newName: "Comments");

            migrationBuilder.RenameColumn(
                name: "lead_history_id",
                table: "LeadHistories",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_LeadHistories_leads_id",
                table: "LeadHistories",
                newName: "IX_LeadHistories_LeadId");

            migrationBuilder.RenameColumn(
                name: "totalAmount",
                table: "Invoices",
                newName: "TotalAmount");

            migrationBuilder.RenameColumn(
                name: "date",
                table: "Invoices",
                newName: "Date");

            migrationBuilder.RenameColumn(
                name: "tax",
                table: "Invoices",
                newName: "TaxAmount");

            migrationBuilder.RenameColumn(
                name: "order_id",
                table: "Invoices",
                newName: "OrderId");

            migrationBuilder.RenameColumn(
                name: "number",
                table: "Invoices",
                newName: "InvoiceNumber");

            migrationBuilder.RenameColumn(
                name: "invoice_id",
                table: "Invoices",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_Invoices_order_id",
                table: "Invoices",
                newName: "IX_Invoices_OrderId");

            migrationBuilder.RenameColumn(
                name: "subject",
                table: "ContactUs",
                newName: "Subject");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "ContactUs",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "email",
                table: "ContactUs",
                newName: "Email");

            migrationBuilder.RenameColumn(
                name: "description",
                table: "ContactUs",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "user_id",
                table: "ContactUs",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "subcategory_id",
                table: "CategorySubCategoryMappings",
                newName: "SubCategoryId");

            migrationBuilder.RenameColumn(
                name: "category_id",
                table: "CategorySubCategoryMappings",
                newName: "CategoryId");

            migrationBuilder.RenameColumn(
                name: "sub_cat_id",
                table: "CategorySubCategoryMappings",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_CategorySubCategoryMappings_subcategory_id",
                table: "CategorySubCategoryMappings",
                newName: "IX_CategorySubCategoryMappings_SubCategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_CategorySubCategoryMappings_category_id",
                table: "CategorySubCategoryMappings",
                newName: "IX_CategorySubCategoryMappings_CategoryId");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "Categories",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "category_id",
                table: "Categories",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "zipcode",
                table: "Addresses",
                newName: "Zipcode");

            migrationBuilder.RenameColumn(
                name: "state",
                table: "Addresses",
                newName: "State");

            migrationBuilder.RenameColumn(
                name: "road",
                table: "Addresses",
                newName: "Road");

            migrationBuilder.RenameColumn(
                name: "city",
                table: "Addresses",
                newName: "City");

            migrationBuilder.RenameColumn(
                name: "aptNo",
                table: "Addresses",
                newName: "AppartmentNo");

            migrationBuilder.RenameColumn(
                name: "address_id",
                table: "Addresses",
                newName: "Id");

            migrationBuilder.AddColumn<Guid>(
                name: "Id",
                table: "Orders",
                type: "char(36)",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<DateTime>(
                name: "LeadStartDate",
                table: "Leads",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<decimal>(
                name: "NetAmount",
                table: "Invoices",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Testimonials",
                table: "Testimonials",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ShipmentStatuses",
                table: "ShipmentStatuses",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductTags",
                table: "ProductTags",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Products",
                table: "Products",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Orders",
                table: "Orders",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrderItems",
                table: "OrderItems",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ContactUs",
                table: "ContactUs",
                column: "Id");

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
                    { new Guid("0970b6bd-8ac1-4d61-93d6-b58439b49892"), "A spacious executive desk with a rich mahogany finish.", true, "Executive Wooden Desk", 899.99m, 7, new Guid("91cc1981-42f6-4176-854b-c06a6f12fd31") },
                    { new Guid("1435a859-24e6-4def-a1a9-f4f0ae3e26fc"), "A height-adjustable ergonomic desk for your office.", true, "Ergonomic Office Desk", 299.99m, 8, new Guid("91cc1981-42f6-4176-854b-c06a6f12fd31") },
                    { new Guid("229447be-26b1-4a27-bb41-0c1486a9ea1d"), "A spacious and comfortable sectional sofa perfect for family gatherings.", true, "Sectional Fabric Sofa", 899.99m, 10, new Guid("f106601e-296d-4c77-a7f3-522015498e3c") },
                    { new Guid("25b2463a-66f1-4ad7-aab4-b76ed06d0010"), "Perfect for kids, this bunk bed includes under-bed storage drawers.", true, "Bunk Bed with Storage", 799.99m, 5, new Guid("836856cc-e6bc-4acd-9dcb-eb18da4f2b10") },
                    { new Guid("3b94a910-ea37-48ea-93b6-5e937360e9fc"), "A sleek leather sofa that adds sophistication to any living room.", true, "Modern Leather Sofa", 799.99m, 15, new Guid("f106601e-296d-4c77-a7f3-522015498e3c") },
                    { new Guid("512127a0-4501-4b21-af06-0f390183eade"), "A multi-functional sofa bed with a contemporary design.", true, "Convertible Sofa Bed", 499.99m, 8, new Guid("f106601e-296d-4c77-a7f3-522015498e3c") },
                    { new Guid("6075317b-3e06-4210-a0e0-78dd50ff9e60"), "A minimalist computer desk with a sleek design.", true, "Compact Computer Desk", 199.99m, 20, new Guid("91cc1981-42f6-4176-854b-c06a6f12fd31") },
                    { new Guid("8a7dc4f1-0cd7-4656-ab2b-5f16c02e79dc"), "A solid wooden bed frame with a classic finish.", true, "Queen Size Wooden Bed", 699.99m, 20, new Guid("836856cc-e6bc-4acd-9dcb-eb18da4f2b10") },
                    { new Guid("972f1963-e72b-4614-b0ba-237a16c21161"), "A stylish modern sofa for your living room.", true, "Modern Sofa", 599.99m, 10, new Guid("f106601e-296d-4c77-a7f3-522015498e3c") },
                    { new Guid("b04c2804-d56b-4ae8-b5df-560d3eb1d587"), "A luxurious bed with a tufted headboard and sturdy build.", true, "King Size Upholstered Bed", 999.99m, 10, new Guid("836856cc-e6bc-4acd-9dcb-eb18da4f2b10") },
                    { new Guid("b05f69f3-6a0d-45de-9df4-254636f13161"), "A height-adjustable desk designed for ergonomic office setups.", true, "Adjustable Standing Desk", 399.99m, 12, new Guid("91cc1981-42f6-4176-854b-c06a6f12fd31") },
                    { new Guid("b86211f6-b630-4d59-8985-af355f118fec"), "A spacious and comfortable king-size bed.", true, "King Size Bed", 799.99m, 5, new Guid("836856cc-e6bc-4acd-9dcb-eb18da4f2b10") }
                });

            migrationBuilder.InsertData(
                table: "SubCategories",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("94d4fdb7-b1b7-4b42-aea4-08dc058baf26"), "Bedroom" });

            migrationBuilder.CreateIndex(
                name: "IX_Orders_UserId",
                table: "Orders",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_CategorySubCategoryMappings_Categories_CategoryId",
                table: "CategorySubCategoryMappings",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CategorySubCategoryMappings_SubCategories_SubCategoryId",
                table: "CategorySubCategoryMappings",
                column: "SubCategoryId",
                principalTable: "SubCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Invoices_Orders_OrderId",
                table: "Invoices",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_LeadHistories_Leads_LeadId",
                table: "LeadHistories",
                column: "LeadId",
                principalTable: "Leads",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Leads_ContactUs_ContactUsId",
                table: "Leads",
                column: "ContactUsId",
                principalTable: "ContactUs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItems_Orders_OrderId",
                table: "OrderItems",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Users_UserId",
                table: "Orders",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductImages_Products_ProductId",
                table: "ProductImages",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductReviews_Products_ProductId",
                table: "ProductReviews",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductReviews_Users_UserId",
                table: "ProductReviews",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_SubCategories_SubCategoryId",
                table: "Products",
                column: "SubCategoryId",
                principalTable: "SubCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductTagsMappings_ProductTags_ProductTagId",
                table: "ProductTagsMappings",
                column: "ProductTagId",
                principalTable: "ProductTags",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductTagsMappings_Products_ProductId",
                table: "ProductTagsMappings",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SavedAddresses_Addresses_AddressId",
                table: "SavedAddresses",
                column: "AddressId",
                principalTable: "Addresses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SavedAddresses_Users_UserId",
                table: "SavedAddresses",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ShipmentStatuses_Orders_OrderId",
                table: "ShipmentStatuses",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StoreLocations_Addresses_AddressId",
                table: "StoreLocations",
                column: "AddressId",
                principalTable: "Addresses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
