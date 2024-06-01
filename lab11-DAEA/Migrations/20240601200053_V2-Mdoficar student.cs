using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace lab11_DAEA.Migrations
{
    /// <inheritdoc />
    public partial class V2Mdoficarstudent : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "activo",
                table: "Students",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "activo",
                table: "Students");
        }
    }
}
