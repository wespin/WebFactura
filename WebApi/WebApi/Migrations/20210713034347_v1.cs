using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApi.Migrations
{
    public partial class v1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Facturas",
                columns: table => new
                {
                    idFactura = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fecha = table.Column<DateTime>(nullable: false),
                    TipodePago = table.Column<string>(nullable: true),
                    DocumentoCliente = table.Column<string>(nullable: true),
                    NombreCliente = table.Column<string>(nullable: true),
                    Subtotal = table.Column<decimal>(nullable: false),
                    Descuento = table.Column<decimal>(nullable: false),
                    IVA = table.Column<decimal>(nullable: false),
                    TotalDescuento = table.Column<decimal>(nullable: false),
                    TotalImpuesto = table.Column<decimal>(nullable: false),
                    Total = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Facturas", x => x.idFactura);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Facturas");
        }
    }
}
