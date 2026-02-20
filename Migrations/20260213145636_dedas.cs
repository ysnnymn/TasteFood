using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TasteFoodIt.Migrations
{
    /// <inheritdoc />
    public partial class dedas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "IconCircleColor",
                table: "Notifications",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IconCircleColor",
                table: "Notifications");
        }
    }
}
