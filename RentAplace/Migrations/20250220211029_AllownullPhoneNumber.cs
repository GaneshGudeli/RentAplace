using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RentAplace.Migrations
{
    /// <inheritdoc />
    public partial class AllownullPhoneNumber : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                schema: "rentaplace",
                table: "Users",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(15)",
                oldMaxLength: 15);

            migrationBuilder.UpdateData(
                schema: "rentaplace",
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 20, 21, 10, 26, 933, DateTimeKind.Utc).AddTicks(8596));

            migrationBuilder.UpdateData(
                schema: "rentaplace",
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 20, 21, 10, 26, 933, DateTimeKind.Utc).AddTicks(8599));

            migrationBuilder.UpdateData(
                schema: "rentaplace",
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 20, 21, 10, 26, 933, DateTimeKind.Utc).AddTicks(8600));

            migrationBuilder.UpdateData(
                schema: "rentaplace",
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 20, 21, 10, 26, 933, DateTimeKind.Utc).AddTicks(8601));

            migrationBuilder.UpdateData(
                schema: "rentaplace",
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 20, 21, 10, 26, 933, DateTimeKind.Utc).AddTicks(8601));

            migrationBuilder.UpdateData(
                schema: "rentaplace",
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 20, 21, 10, 26, 933, DateTimeKind.Utc).AddTicks(8602));

            migrationBuilder.UpdateData(
                schema: "rentaplace",
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 20, 21, 10, 26, 933, DateTimeKind.Utc).AddTicks(8603));

            migrationBuilder.UpdateData(
                schema: "rentaplace",
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 20, 21, 10, 26, 933, DateTimeKind.Utc).AddTicks(8604));

            migrationBuilder.UpdateData(
                schema: "rentaplace",
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 20, 21, 10, 26, 933, DateTimeKind.Utc).AddTicks(8604));

            migrationBuilder.UpdateData(
                schema: "rentaplace",
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 20, 21, 10, 26, 933, DateTimeKind.Utc).AddTicks(8605));

            migrationBuilder.UpdateData(
                schema: "rentaplace",
                table: "Properties",
                keyColumn: "PropertyId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 20, 21, 10, 26, 933, DateTimeKind.Utc).AddTicks(8657));

            migrationBuilder.UpdateData(
                schema: "rentaplace",
                table: "Properties",
                keyColumn: "PropertyId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 20, 21, 10, 26, 933, DateTimeKind.Utc).AddTicks(8664));

            migrationBuilder.UpdateData(
                schema: "rentaplace",
                table: "PropertyType",
                keyColumn: "PropertyTypeId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 20, 21, 10, 26, 933, DateTimeKind.Utc).AddTicks(8549));

            migrationBuilder.UpdateData(
                schema: "rentaplace",
                table: "PropertyType",
                keyColumn: "PropertyTypeId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 20, 21, 10, 26, 933, DateTimeKind.Utc).AddTicks(8552));

            migrationBuilder.UpdateData(
                schema: "rentaplace",
                table: "PropertyType",
                keyColumn: "PropertyTypeId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 20, 21, 10, 26, 933, DateTimeKind.Utc).AddTicks(8553));

            migrationBuilder.UpdateData(
                schema: "rentaplace",
                table: "PropertyType",
                keyColumn: "PropertyTypeId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 20, 21, 10, 26, 933, DateTimeKind.Utc).AddTicks(8554));

            migrationBuilder.UpdateData(
                schema: "rentaplace",
                table: "Role",
                keyColumn: "RoleId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 20, 21, 10, 26, 933, DateTimeKind.Utc).AddTicks(8424));

            migrationBuilder.UpdateData(
                schema: "rentaplace",
                table: "Role",
                keyColumn: "RoleId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 20, 21, 10, 26, 933, DateTimeKind.Utc).AddTicks(8429));

            migrationBuilder.UpdateData(
                schema: "rentaplace",
                table: "Role",
                keyColumn: "RoleId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 20, 21, 10, 26, 933, DateTimeKind.Utc).AddTicks(8430));

            migrationBuilder.UpdateData(
                schema: "rentaplace",
                table: "Status",
                keyColumn: "StatusId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 20, 21, 10, 26, 933, DateTimeKind.Utc).AddTicks(8574));

            migrationBuilder.UpdateData(
                schema: "rentaplace",
                table: "Status",
                keyColumn: "StatusId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 20, 21, 10, 26, 933, DateTimeKind.Utc).AddTicks(8576));

            migrationBuilder.UpdateData(
                schema: "rentaplace",
                table: "Status",
                keyColumn: "StatusId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 20, 21, 10, 26, 933, DateTimeKind.Utc).AddTicks(8577));

            migrationBuilder.UpdateData(
                schema: "rentaplace",
                table: "Status",
                keyColumn: "StatusId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 20, 21, 10, 26, 933, DateTimeKind.Utc).AddTicks(8577));

            migrationBuilder.UpdateData(
                schema: "rentaplace",
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 20, 21, 10, 26, 933, DateTimeKind.Utc).AddTicks(8630));

            migrationBuilder.UpdateData(
                schema: "rentaplace",
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 20, 21, 10, 26, 933, DateTimeKind.Utc).AddTicks(8636));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                schema: "rentaplace",
                table: "Users",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(15)",
                oldMaxLength: 15,
                oldNullable: true);

            migrationBuilder.UpdateData(
                schema: "rentaplace",
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 20, 7, 49, 5, 779, DateTimeKind.Utc).AddTicks(9027));

            migrationBuilder.UpdateData(
                schema: "rentaplace",
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 20, 7, 49, 5, 779, DateTimeKind.Utc).AddTicks(9034));

            migrationBuilder.UpdateData(
                schema: "rentaplace",
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 20, 7, 49, 5, 779, DateTimeKind.Utc).AddTicks(9036));

            migrationBuilder.UpdateData(
                schema: "rentaplace",
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 20, 7, 49, 5, 779, DateTimeKind.Utc).AddTicks(9037));

            migrationBuilder.UpdateData(
                schema: "rentaplace",
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 20, 7, 49, 5, 779, DateTimeKind.Utc).AddTicks(9039));

            migrationBuilder.UpdateData(
                schema: "rentaplace",
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 20, 7, 49, 5, 779, DateTimeKind.Utc).AddTicks(9041));

            migrationBuilder.UpdateData(
                schema: "rentaplace",
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 20, 7, 49, 5, 779, DateTimeKind.Utc).AddTicks(9042));

            migrationBuilder.UpdateData(
                schema: "rentaplace",
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 20, 7, 49, 5, 779, DateTimeKind.Utc).AddTicks(9044));

            migrationBuilder.UpdateData(
                schema: "rentaplace",
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 20, 7, 49, 5, 779, DateTimeKind.Utc).AddTicks(9045));

            migrationBuilder.UpdateData(
                schema: "rentaplace",
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 20, 7, 49, 5, 779, DateTimeKind.Utc).AddTicks(9047));

            migrationBuilder.UpdateData(
                schema: "rentaplace",
                table: "Properties",
                keyColumn: "PropertyId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 20, 7, 49, 5, 779, DateTimeKind.Utc).AddTicks(9281));

            migrationBuilder.UpdateData(
                schema: "rentaplace",
                table: "Properties",
                keyColumn: "PropertyId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 20, 7, 49, 5, 779, DateTimeKind.Utc).AddTicks(9297));

            migrationBuilder.UpdateData(
                schema: "rentaplace",
                table: "PropertyType",
                keyColumn: "PropertyTypeId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 20, 7, 49, 5, 779, DateTimeKind.Utc).AddTicks(8888));

            migrationBuilder.UpdateData(
                schema: "rentaplace",
                table: "PropertyType",
                keyColumn: "PropertyTypeId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 20, 7, 49, 5, 779, DateTimeKind.Utc).AddTicks(8896));

            migrationBuilder.UpdateData(
                schema: "rentaplace",
                table: "PropertyType",
                keyColumn: "PropertyTypeId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 20, 7, 49, 5, 779, DateTimeKind.Utc).AddTicks(8898));

            migrationBuilder.UpdateData(
                schema: "rentaplace",
                table: "PropertyType",
                keyColumn: "PropertyTypeId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 20, 7, 49, 5, 779, DateTimeKind.Utc).AddTicks(8900));

            migrationBuilder.UpdateData(
                schema: "rentaplace",
                table: "Role",
                keyColumn: "RoleId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 20, 7, 49, 5, 779, DateTimeKind.Utc).AddTicks(8532));

            migrationBuilder.UpdateData(
                schema: "rentaplace",
                table: "Role",
                keyColumn: "RoleId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 20, 7, 49, 5, 779, DateTimeKind.Utc).AddTicks(8545));

            migrationBuilder.UpdateData(
                schema: "rentaplace",
                table: "Role",
                keyColumn: "RoleId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 20, 7, 49, 5, 779, DateTimeKind.Utc).AddTicks(8547));

            migrationBuilder.UpdateData(
                schema: "rentaplace",
                table: "Status",
                keyColumn: "StatusId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 20, 7, 49, 5, 779, DateTimeKind.Utc).AddTicks(8963));

            migrationBuilder.UpdateData(
                schema: "rentaplace",
                table: "Status",
                keyColumn: "StatusId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 20, 7, 49, 5, 779, DateTimeKind.Utc).AddTicks(8968));

            migrationBuilder.UpdateData(
                schema: "rentaplace",
                table: "Status",
                keyColumn: "StatusId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 20, 7, 49, 5, 779, DateTimeKind.Utc).AddTicks(8970));

            migrationBuilder.UpdateData(
                schema: "rentaplace",
                table: "Status",
                keyColumn: "StatusId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 20, 7, 49, 5, 779, DateTimeKind.Utc).AddTicks(8972));

            migrationBuilder.UpdateData(
                schema: "rentaplace",
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 20, 7, 49, 5, 779, DateTimeKind.Utc).AddTicks(9114));

            migrationBuilder.UpdateData(
                schema: "rentaplace",
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 20, 7, 49, 5, 779, DateTimeKind.Utc).AddTicks(9130));
        }
    }
}
