using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BackendNet.Migrations
{
    /// <inheritdoc />
    public partial class DatabaseV2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Couse",
                table: "Docente");

            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "Docente",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "FirstName",
                table: "Docente",
                newName: "Code");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Docente",
                newName: "LastName");

            migrationBuilder.RenameColumn(
                name: "Code",
                table: "Docente",
                newName: "FirstName");

            migrationBuilder.AddColumn<string>(
                name: "Couse",
                table: "Docente",
                type: "text",
                nullable: false,
                defaultValue: "");
        }
    }
}
