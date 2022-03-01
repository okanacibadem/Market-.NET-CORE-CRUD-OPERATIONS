using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Market.Migrations
{
    public partial class MarketDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Personels",
                columns: table => new
                {
                    personelNo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    adi = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    soyadi = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Cinsiyet = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    maas = table.Column<int>(type: "int", nullable: false),
                    reyonNo = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personels", x => x.personelNo);
                });

            migrationBuilder.CreateTable(
                name: "Reyonlars",
                columns: table => new
                {
                    reyonNo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    reyonAdi = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reyonlars", x => x.reyonNo);
                });

            migrationBuilder.CreateTable(
                name: "Urunlers",
                columns: table => new
                {
                    urunNo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    urunAd = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    alisFiyati = table.Column<int>(type: "int", nullable: false),
                    satisFiyati = table.Column<int>(type: "int", nullable: false),
                    gelisTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    miktar = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Urunlers", x => x.urunNo);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Personels");

            migrationBuilder.DropTable(
                name: "Reyonlars");

            migrationBuilder.DropTable(
                name: "Urunlers");
        }
    }
}
