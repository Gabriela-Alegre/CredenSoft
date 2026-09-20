using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataEF.Migrations
{
    /// <inheritdoc />
    public partial class AmpliarDetalleAnexoE : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "resp2_apenom",
                table: "detalles_anexo_e",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "resp2_cargo",
                table: "detalles_anexo_e",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "resp2_nro_permiso",
                table: "detalles_anexo_e",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "sol1_apenom",
                table: "detalles_anexo_e",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "sol1_cargo",
                table: "detalles_anexo_e",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "sol1_docnro",
                table: "detalles_anexo_e",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "sol1_tipodoc",
                table: "detalles_anexo_e",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "sol2_apenom",
                table: "detalles_anexo_e",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "sol2_cargo",
                table: "detalles_anexo_e",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "sol2_docnro",
                table: "detalles_anexo_e",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "sol2_tipodoc",
                table: "detalles_anexo_e",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "sol3_apenom",
                table: "detalles_anexo_e",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable:true);

            migrationBuilder.AddColumn<string>(
                name: "sol3_cargo",
                table: "detalles_anexo_e",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "sol3_docnro",
                table: "detalles_anexo_e",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "sol3_tipodoc",
                table: "detalles_anexo_e",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "sol4_apenom",
                table: "detalles_anexo_e",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "sol4_cargo",
                table: "detalles_anexo_e",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "sol4_docnro",
                table: "detalles_anexo_e",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable:true);

            migrationBuilder.AddColumn<string>(
                name: "sol4_tipodoc",
                table: "detalles_anexo_e",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "sol5_apenom",
                table: "detalles_anexo_e",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "sol5_cargo",
                table: "detalles_anexo_e",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "sol5_docnro",
                table: "detalles_anexo_e",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "sol5_tipodoc",
                table: "detalles_anexo_e",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable:true);

            migrationBuilder.AddColumn<string>(
                name: "tareas",
                table: "detalles_anexo_e",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "resp2_apenom",
                table: "detalles_anexo_e");

            migrationBuilder.DropColumn(
                name: "resp2_cargo",
                table: "detalles_anexo_e");

            migrationBuilder.DropColumn(
                name: "resp2_nro_permiso",
                table: "detalles_anexo_e");

            migrationBuilder.DropColumn(
                name: "sol1_apenom",
                table: "detalles_anexo_e");

            migrationBuilder.DropColumn(
                name: "sol1_cargo",
                table: "detalles_anexo_e");

            migrationBuilder.DropColumn(
                name: "sol1_docnro",
                table: "detalles_anexo_e");

            migrationBuilder.DropColumn(
                name: "sol1_tipodoc",
                table: "detalles_anexo_e");

            migrationBuilder.DropColumn(
                name: "sol2_apenom",
                table: "detalles_anexo_e");

            migrationBuilder.DropColumn(
                name: "sol2_cargo",
                table: "detalles_anexo_e");

            migrationBuilder.DropColumn(
                name: "sol2_docnro",
                table: "detalles_anexo_e");

            migrationBuilder.DropColumn(
                name: "sol2_tipodoc",
                table: "detalles_anexo_e");

            migrationBuilder.DropColumn(
                name: "sol3_apenom",
                table: "detalles_anexo_e");

            migrationBuilder.DropColumn(
                name: "sol3_cargo",
                table: "detalles_anexo_e");

            migrationBuilder.DropColumn(
                name: "sol3_docnro",
                table: "detalles_anexo_e");

            migrationBuilder.DropColumn(
                name: "sol3_tipodoc",
                table: "detalles_anexo_e");

            migrationBuilder.DropColumn(
                name: "sol4_apenom",
                table: "detalles_anexo_e");

            migrationBuilder.DropColumn(
                name: "sol4_cargo",
                table: "detalles_anexo_e");

            migrationBuilder.DropColumn(
                name: "sol4_docnro",
                table: "detalles_anexo_e");

            migrationBuilder.DropColumn(
                name: "sol4_tipodoc",
                table: "detalles_anexo_e");

            migrationBuilder.DropColumn(
                name: "sol5_apenom",
                table: "detalles_anexo_e");

            migrationBuilder.DropColumn(
                name: "sol5_cargo",
                table: "detalles_anexo_e");

            migrationBuilder.DropColumn(
                name: "sol5_docnro",
                table: "detalles_anexo_e");

            migrationBuilder.DropColumn(
                name: "sol5_tipodoc",
                table: "detalles_anexo_e");

            migrationBuilder.DropColumn(
                name: "tareas",
                table: "detalles_anexo_e");
        }
    }
}
