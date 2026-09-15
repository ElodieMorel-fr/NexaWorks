using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace NexaWorks.Migrations
{
    /// <inheritdoc />
    public partial class AddInitialSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "OperatingSystems",
                columns: new[] { "OSId", "Name" },
                values: new object[,]
                {
                    { 1, "Linux" },
                    { 2, "MacOS" },
                    { 3, "Windows" },
                    { 4, "Android" },
                    { 5, "iOS" },
                    { 6, "Windows Mobile" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "Name" },
                values: new object[,]
                {
                    { 1, "Trader en Herbe" },
                    { 2, "Maître des Investissements" },
                    { 3, "Planificateur d’Entraînement" },
                    { 4, "Planificateur d’Anxiété Sociale" }
                });

            migrationBuilder.InsertData(
                table: "Statuses",
                columns: new[] { "StatusId", "Name" },
                values: new object[,]
                {
                    { 1, "Résolu" },
                    { 2, "En cours" }
                });

            migrationBuilder.InsertData(
                table: "ProductVersions",
                columns: new[] { "ProductVersionId", "ProductId", "VersionNumber" },
                values: new object[,]
                {
                    { 1, 1, "1.0" },
                    { 2, 1, "1.1" },
                    { 3, 1, "1.2" },
                    { 4, 1, "1.3" },
                    { 5, 2, "1.0" },
                    { 6, 2, "2.0" },
                    { 7, 2, "2.1" },
                    { 8, 3, "1.0" },
                    { 9, 3, "1.1" },
                    { 10, 3, "2.0" },
                    { 11, 4, "1.0" },
                    { 12, 4, "1.1" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "OperatingSystems",
                keyColumn: "OSId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "OperatingSystems",
                keyColumn: "OSId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "OperatingSystems",
                keyColumn: "OSId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "OperatingSystems",
                keyColumn: "OSId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "OperatingSystems",
                keyColumn: "OSId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "OperatingSystems",
                keyColumn: "OSId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "ProductVersions",
                keyColumn: "ProductVersionId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ProductVersions",
                keyColumn: "ProductVersionId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ProductVersions",
                keyColumn: "ProductVersionId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ProductVersions",
                keyColumn: "ProductVersionId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ProductVersions",
                keyColumn: "ProductVersionId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ProductVersions",
                keyColumn: "ProductVersionId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "ProductVersions",
                keyColumn: "ProductVersionId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "ProductVersions",
                keyColumn: "ProductVersionId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "ProductVersions",
                keyColumn: "ProductVersionId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "ProductVersions",
                keyColumn: "ProductVersionId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "ProductVersions",
                keyColumn: "ProductVersionId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "ProductVersions",
                keyColumn: "ProductVersionId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Statuses",
                keyColumn: "StatusId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Statuses",
                keyColumn: "StatusId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4);
        }
    }
}
