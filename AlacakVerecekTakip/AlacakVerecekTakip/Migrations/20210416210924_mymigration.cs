using Microsoft.EntityFrameworkCore.Migrations;

namespace AlacakVerecekTakip.Migrations
{
    public partial class mymigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "kasaTablosu",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UyeID = table.Column<int>(type: "int", nullable: false),
                    IslemTuru = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KisiAdSoyad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GirisTutari = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CikisTutari = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Bakiye = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_kasaTablosu", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "uyelerTablosu",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KulAdi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KulSoyadi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sifre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Durum = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_uyelerTablosu", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "cariHesaplarTablosu",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Soyad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Adres = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AlacakMiktar = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    VerecekMiktar = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    AlacakVerecek = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Durum = table.Column<bool>(type: "bit", nullable: false),
                    uyelerTablosuID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cariHesaplarTablosu", x => x.ID);
                    table.ForeignKey(
                        name: "FK_cariHesaplarTablosu_uyelerTablosu_uyelerTablosuID",
                        column: x => x.uyelerTablosuID,
                        principalTable: "uyelerTablosu",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_cariHesaplarTablosu_uyelerTablosuID",
                table: "cariHesaplarTablosu",
                column: "uyelerTablosuID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "cariHesaplarTablosu");

            migrationBuilder.DropTable(
                name: "kasaTablosu");

            migrationBuilder.DropTable(
                name: "uyelerTablosu");
        }
    }
}
