using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MarcasAut.Infraestructure.Data.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Marcas",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Toyota" },
                    { 2, "Ford" },
                    { 3, "Chevrolet" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Marcas",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Marcas",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Marcas",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
