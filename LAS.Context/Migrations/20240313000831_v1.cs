using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LAS.Context.Migrations
{
    /// <inheritdoc />
    public partial class v1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Kutuphaneler",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kutuphaneler", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Yazar",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Adi = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Yazar", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Uyeler",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Soyad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UyeNumarasi = table.Column<int>(type: "int", nullable: false),
                    KutuphaneID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Uyeler", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Uyeler_Kutuphaneler_KutuphaneID",
                        column: x => x.KutuphaneID,
                        principalTable: "Kutuphaneler",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Kitap",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ISBN = table.Column<int>(type: "int", nullable: false),
                    Baslik = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    YazarID = table.Column<int>(type: "int", nullable: false),
                    YayinYili = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Durum = table.Column<int>(type: "int", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KutuphaneID = table.Column<int>(type: "int", nullable: true),
                    UyeID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kitap", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Kitap_Kutuphaneler_KutuphaneID",
                        column: x => x.KutuphaneID,
                        principalTable: "Kutuphaneler",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Kitap_Uyeler_UyeID",
                        column: x => x.UyeID,
                        principalTable: "Uyeler",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Kitap_Yazar_YazarID",
                        column: x => x.YazarID,
                        principalTable: "Yazar",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Kitap_KutuphaneID",
                table: "Kitap",
                column: "KutuphaneID");

            migrationBuilder.CreateIndex(
                name: "IX_Kitap_UyeID",
                table: "Kitap",
                column: "UyeID");

            migrationBuilder.CreateIndex(
                name: "IX_Kitap_YazarID",
                table: "Kitap",
                column: "YazarID");

            migrationBuilder.CreateIndex(
                name: "IX_Uyeler_KutuphaneID",
                table: "Uyeler",
                column: "KutuphaneID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Kitap");

            migrationBuilder.DropTable(
                name: "Uyeler");

            migrationBuilder.DropTable(
                name: "Yazar");

            migrationBuilder.DropTable(
                name: "Kutuphaneler");
        }
    }
}
