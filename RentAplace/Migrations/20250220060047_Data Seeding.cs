using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RentAplace.Migrations
{
    /// <inheritdoc />
    public partial class DataSeeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                schema: "rentaplace",
                table: "Role",
                newName: "RoleName");

            migrationBuilder.InsertData(
                schema: "rentaplace",
                table: "Features",
                columns: new[] { "FeatureId", "CreatedAt", "FeatureName" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 2, 20, 6, 0, 45, 154, DateTimeKind.Utc).AddTicks(3313), "WiFi" },
                    { 2, new DateTime(2025, 2, 20, 6, 0, 45, 154, DateTimeKind.Utc).AddTicks(3316), "Parking" },
                    { 3, new DateTime(2025, 2, 20, 6, 0, 45, 154, DateTimeKind.Utc).AddTicks(3318), "Swimming Pool" },
                    { 4, new DateTime(2025, 2, 20, 6, 0, 45, 154, DateTimeKind.Utc).AddTicks(3319), "Gym" },
                    { 5, new DateTime(2025, 2, 20, 6, 0, 45, 154, DateTimeKind.Utc).AddTicks(3320), "Balcony" },
                    { 6, new DateTime(2025, 2, 20, 6, 0, 45, 154, DateTimeKind.Utc).AddTicks(3321), "Air Conditioning" },
                    { 7, new DateTime(2025, 2, 20, 6, 0, 45, 154, DateTimeKind.Utc).AddTicks(3321), "Heating" },
                    { 8, new DateTime(2025, 2, 20, 6, 0, 45, 154, DateTimeKind.Utc).AddTicks(3322), "Security System" },
                    { 9, new DateTime(2025, 2, 20, 6, 0, 45, 154, DateTimeKind.Utc).AddTicks(3323), "Elevator" },
                    { 10, new DateTime(2025, 2, 20, 6, 0, 45, 154, DateTimeKind.Utc).AddTicks(3324), "Fully Furnished" }
                });

            migrationBuilder.InsertData(
                schema: "rentaplace",
                table: "PropertyType",
                columns: new[] { "PropertyTypeId", "CreatedAt", "IsDeleted", "TypeName" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 2, 20, 6, 0, 45, 154, DateTimeKind.Utc).AddTicks(3254), false, "Apartment" },
                    { 2, new DateTime(2025, 2, 20, 6, 0, 45, 154, DateTimeKind.Utc).AddTicks(3257), false, "Villa" },
                    { 3, new DateTime(2025, 2, 20, 6, 0, 45, 154, DateTimeKind.Utc).AddTicks(3258), false, "Studio" },
                    { 4, new DateTime(2025, 2, 20, 6, 0, 45, 154, DateTimeKind.Utc).AddTicks(3260), false, "Townhouse" }
                });

            migrationBuilder.InsertData(
                schema: "rentaplace",
                table: "Role",
                columns: new[] { "RoleId", "CreatedAt", "IsDeleted", "RoleName" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 2, 20, 6, 0, 45, 154, DateTimeKind.Utc).AddTicks(3096), false, "Admin" },
                    { 2, new DateTime(2025, 2, 20, 6, 0, 45, 154, DateTimeKind.Utc).AddTicks(3101), false, "Owner" },
                    { 3, new DateTime(2025, 2, 20, 6, 0, 45, 154, DateTimeKind.Utc).AddTicks(3102), false, "Renter" }
                });

            migrationBuilder.InsertData(
                schema: "rentaplace",
                table: "Status",
                columns: new[] { "StatusId", "CreatedAt", "IsDeleted", "StatusName" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 2, 20, 6, 0, 45, 154, DateTimeKind.Utc).AddTicks(3283), false, "Pending" },
                    { 2, new DateTime(2025, 2, 20, 6, 0, 45, 154, DateTimeKind.Utc).AddTicks(3286), false, "Confirmed" },
                    { 3, new DateTime(2025, 2, 20, 6, 0, 45, 154, DateTimeKind.Utc).AddTicks(3287), false, "Cancelled" },
                    { 4, new DateTime(2025, 2, 20, 6, 0, 45, 154, DateTimeKind.Utc).AddTicks(3288), false, "Completed" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "rentaplace",
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                schema: "rentaplace",
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                schema: "rentaplace",
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                schema: "rentaplace",
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                schema: "rentaplace",
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                schema: "rentaplace",
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                schema: "rentaplace",
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                schema: "rentaplace",
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                schema: "rentaplace",
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                schema: "rentaplace",
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                schema: "rentaplace",
                table: "PropertyType",
                keyColumn: "PropertyTypeId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                schema: "rentaplace",
                table: "PropertyType",
                keyColumn: "PropertyTypeId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                schema: "rentaplace",
                table: "PropertyType",
                keyColumn: "PropertyTypeId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                schema: "rentaplace",
                table: "PropertyType",
                keyColumn: "PropertyTypeId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                schema: "rentaplace",
                table: "Role",
                keyColumn: "RoleId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                schema: "rentaplace",
                table: "Role",
                keyColumn: "RoleId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                schema: "rentaplace",
                table: "Role",
                keyColumn: "RoleId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                schema: "rentaplace",
                table: "Status",
                keyColumn: "StatusId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                schema: "rentaplace",
                table: "Status",
                keyColumn: "StatusId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                schema: "rentaplace",
                table: "Status",
                keyColumn: "StatusId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                schema: "rentaplace",
                table: "Status",
                keyColumn: "StatusId",
                keyValue: 4);

            migrationBuilder.RenameColumn(
                name: "RoleName",
                schema: "rentaplace",
                table: "Role",
                newName: "Name");
        }
    }
}
