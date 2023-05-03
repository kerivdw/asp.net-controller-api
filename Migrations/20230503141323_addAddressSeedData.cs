using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace asp.net_controller_api.Migrations
{
    /// <inheritdoc />
    public partial class addAddressSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Address",
                columns: new[] { "Id", "Addressline1", "Addressline2", "City", "Country", "PostCode", "Suburb" },
                values: new object[] { 1, "1 Main Street", "This building", "Lower Hutt", "New Zealand", "5010", "Avalon" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
