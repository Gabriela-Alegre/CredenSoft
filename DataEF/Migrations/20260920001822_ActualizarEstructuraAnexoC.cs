using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataEF.Migrations
{
    /// <inheritdoc />
    public partial class ActualizarEstructuraAnexoC : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // Borramos la columna vieja de texto genérico que ya no va
            migrationBuilder.DropColumn(
                name: "datos_socorrista_conductor",
                table: "detalles_anexo_c");

            // Agregamos los datos de identidad y cargo
            migrationBuilder.AddColumn<string>(
                name: "apellido",
                table: "detalles_anexo_c",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "nombres",
                table: "detalles_anexo_c",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "dni_pasaporte",
                table: "detalles_anexo_c",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "lugar_nacimiento",
                table: "detalles_anexo_c",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "fecha_nacimiento",
                table: "detalles_anexo_c",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "cargo_funcion",
                table: "detalles_anexo_c",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            // Agregamos los booleanos de Socorrista y Conductor
            migrationBuilder.AddColumn<bool>(
                name: "socorrista",
                table: "detalles_anexo_c",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "conductor",
                table: "detalles_anexo_c",
                type: "bit",
                nullable: false,
                defaultValue: false);

            // Agregamos la matriz de sectores (1 al 7) con sus justificaciones
            migrationBuilder.AddColumn<bool>(
                name: "sector_1",
                table: "detalles_anexo_c",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "sector_1_justif",
                table: "detalles_anexo_c",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "sector_2",
                table: "detalles_anexo_c",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "sector_2_justif",
                table: "detalles_anexo_c",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "sector_3",
                table: "detalles_anexo_c",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "sector_3_justif",
                table: "detalles_anexo_c",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "sector_4",
                table: "detalles_anexo_c",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "sector_4_justif",
                table: "detalles_anexo_c",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "sector_5",
                table: "detalles_anexo_c",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "sector_5_justif",
                table: "detalles_anexo_c",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "sector_6",
                table: "detalles_anexo_c",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "sector_6_justif",
                table: "detalles_anexo_c",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "sector_7",
                table: "detalles_anexo_c",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "sector_7_justif",
                table: "detalles_anexo_c",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "justif_sna_regionales",
                table: "detalles_anexo_c",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "apellido",
                table: "detalles_anexo_c");

            migrationBuilder.DropColumn(
                name: "cargo_funcion",
                table: "detalles_anexo_c");

            migrationBuilder.DropColumn(
                name: "conductor",
                table: "detalles_anexo_c");

            migrationBuilder.DropColumn(
                name: "dni_pasaporte",
                table: "detalles_anexo_c");

            migrationBuilder.DropColumn(
                name: "fecha_nacimiento",
                table: "detalles_anexo_c");

            migrationBuilder.DropColumn(
                name: "justif_sna_regionales",
                table: "detalles_anexo_c");

            migrationBuilder.DropColumn(
                name: "lugar_nacimiento",
                table: "detalles_anexo_c");

            migrationBuilder.DropColumn(
                name: "nombres",
                table: "detalles_anexo_c");

            migrationBuilder.DropColumn(
                name: "sector_1",
                table: "detalles_anexo_c");

            migrationBuilder.DropColumn(
                name: "sector_1_justif",
                table: "detalles_anexo_c");

            migrationBuilder.DropColumn(
                name: "sector_2",
                table: "detalles_anexo_c");

            migrationBuilder.DropColumn(
                name: "sector_2_justif",
                table: "detalles_anexo_c");

            migrationBuilder.DropColumn(
                name: "sector_3",
                table: "detalles_anexo_c");

            migrationBuilder.DropColumn(
                name: "sector_3_justif",
                table: "detalles_anexo_c");

            migrationBuilder.DropColumn(
                name: "sector_4",
                table: "detalles_anexo_c");

            migrationBuilder.DropColumn(
                name: "sector_4_justif",
                table: "detalles_anexo_c");

            migrationBuilder.DropColumn(
                name: "sector_5",
                table: "detalles_anexo_c");

            migrationBuilder.DropColumn(
                name: "sector_5_justif",
                table: "detalles_anexo_c");

            migrationBuilder.DropColumn(
                name: "sector_6",
                table: "detalles_anexo_c");

            migrationBuilder.DropColumn(
                name: "sector_6_justif",
                table: "detalles_anexo_c");

            migrationBuilder.DropColumn(
                name: "sector_7",
                table: "detalles_anexo_c");

            migrationBuilder.DropColumn(
                name: "sector_7_justif",
                table: "detalles_anexo_c");

            migrationBuilder.DropColumn(
                name: "socorrista",
                table: "detalles_anexo_c");

            migrationBuilder.AddColumn<string>(
                name: "datos_socorrista_conductor",
                table: "detalles_anexo_c",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}