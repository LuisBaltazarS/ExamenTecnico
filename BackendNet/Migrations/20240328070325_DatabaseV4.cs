using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BackendNet.Migrations
{
    /// <inheritdoc />
    public partial class DatabaseV4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Evento_Campus_CampusId",
                table: "Evento");

            migrationBuilder.DropIndex(
                name: "IX_Evento_CampusId",
                table: "Evento");

            migrationBuilder.DropColumn(
                name: "CampusId",
                table: "Evento");

            migrationBuilder.CreateTable(
                name: "EventoCampus",
                columns: table => new
                {
                    EventoId = table.Column<int>(type: "integer", nullable: false),
                    CampusId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventoCampus", x => new { x.EventoId, x.CampusId });
                    table.ForeignKey(
                        name: "FK_EventoCampus_Campus_CampusId",
                        column: x => x.CampusId,
                        principalTable: "Campus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EventoCampus_Evento_EventoId",
                        column: x => x.EventoId,
                        principalTable: "Evento",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EventoCampus_CampusId",
                table: "EventoCampus",
                column: "CampusId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EventoCampus");

            migrationBuilder.AddColumn<int>(
                name: "CampusId",
                table: "Evento",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Evento_CampusId",
                table: "Evento",
                column: "CampusId");

            migrationBuilder.AddForeignKey(
                name: "FK_Evento_Campus_CampusId",
                table: "Evento",
                column: "CampusId",
                principalTable: "Campus",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
