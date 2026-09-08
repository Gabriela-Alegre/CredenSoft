using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataEF.Migrations
{
    /// <inheritdoc />
    public partial class AgregarAnexos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "detalles_anexo_c",
                columns: table => new
                {
                    id_detalle_c = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    id_solicitud = table.Column<int>(type: "int", nullable: false),
                    aeropuerto = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    numero_nota_permiso = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    estado_civil = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    calle = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    nro = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    piso = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    depto = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    cp = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    localidad = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    tel_particular = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    tel_laboral = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    mail = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    grupo_sanguineo = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    factor_rh = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    enfermedades_alergias = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    datos_socorrista_conductor = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_detalles_anexo_c", x => x.id_detalle_c);
                    table.ForeignKey(
                        name: "FK_detalles_anexo_c_solicitudes_id_solicitud",
                        column: x => x.id_solicitud,
                        principalTable: "solicitudes",
                        principalColumn: "id_solicitud",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "detalles_anexo_e",
                columns: table => new
                {
                    id_detalle_e = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    id_solicitud = table.Column<int>(type: "int", nullable: false),
                    dias_autorizados = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    horarios_desde = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    horarios_hasta = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    sector_1 = table.Column<bool>(type: "bit", nullable: false),
                    justificacion_sector_1 = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    sector_2 = table.Column<bool>(type: "bit", nullable: false),
                    justificacion_sector_2 = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    sector_3 = table.Column<bool>(type: "bit", nullable: false),
                    justificacion_sector_3 = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    sector_4 = table.Column<bool>(type: "bit", nullable: false),
                    justificacion_sector_4 = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    sector_5 = table.Column<bool>(type: "bit", nullable: false),
                    justificacion_sector_5 = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    sector_6 = table.Column<bool>(type: "bit", nullable: false),
                    justificacion_sector_6 = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    sector_7 = table.Column<bool>(type: "bit", nullable: false),
                    justificacion_sector_7 = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    responsable_ap_nombre = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    responsable_nro_permiso = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    responsable_cargo = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_detalles_anexo_e", x => x.id_detalle_e);
                    table.ForeignKey(
                        name: "FK_detalles_anexo_e_solicitudes_id_solicitud",
                        column: x => x.id_solicitud,
                        principalTable: "solicitudes",
                        principalColumn: "id_solicitud",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_detalles_anexo_c_id_solicitud",
                table: "detalles_anexo_c",
                column: "id_solicitud",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_detalles_anexo_e_id_solicitud",
                table: "detalles_anexo_e",
                column: "id_solicitud",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "detalles_anexo_c");

            migrationBuilder.DropTable(
                name: "detalles_anexo_e");
        }
    }
}
