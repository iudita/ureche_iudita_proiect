using Microsoft.EntityFrameworkCore.Migrations;

namespace ureche_iudita_proiect.Migrations
{
    public partial class SecondCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ServiciuID",
                table: "Banca",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Serviciu",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    denumire_serviciu = table.Column<string>(nullable: true),
                    Descriere = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Serviciu", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Banca_ServiciuID",
                table: "Banca",
                column: "ServiciuID");

            migrationBuilder.AddForeignKey(
                name: "FK_Banca_Serviciu_ServiciuID",
                table: "Banca",
                column: "ServiciuID",
                principalTable: "Serviciu",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Banca_Serviciu_ServiciuID",
                table: "Banca");

            migrationBuilder.DropTable(
                name: "Serviciu");

            migrationBuilder.DropIndex(
                name: "IX_Banca_ServiciuID",
                table: "Banca");

            migrationBuilder.DropColumn(
                name: "ServiciuID",
                table: "Banca");
        }
    }
}
