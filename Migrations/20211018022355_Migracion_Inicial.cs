using Microsoft.EntityFrameworkCore.Migrations;

namespace RolDetalle_II.Migrations
{
    public partial class Migracion_Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Permiso",
                columns: table => new
                {
                    PermisoId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombre = table.Column<string>(type: "TEXT", nullable: true),
                    Descripcion = table.Column<string>(type: "TEXT", nullable: true),
                    VecesAsignado = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Permiso", x => x.PermisoId);
                });

            migrationBuilder.CreateTable(
                name: "Rol",
                columns: table => new
                {
                    RolId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Descripcion = table.Column<string>(type: "TEXT", nullable: true),
                    esActivo = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rol", x => x.RolId);
                });

            migrationBuilder.CreateTable(
                name: "RolDetalle",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    RolId = table.Column<int>(type: "INTEGER", nullable: false),
                    PermisoId = table.Column<int>(type: "INTEGER", nullable: false),
                    esAsignado = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RolDetalle", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RolDetalle_Rol_RolId",
                        column: x => x.RolId,
                        principalTable: "Rol",
                        principalColumn: "RolId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Permiso",
                columns: new[] { "PermisoId", "Descripcion", "Nombre", "VecesAsignado" },
                values: new object[] { 1, "Permiso para que el trabajador pueda estudiar", "Permiso para estudios", 0 });

            migrationBuilder.InsertData(
                table: "Permiso",
                columns: new[] { "PermisoId", "Descripcion", "Nombre", "VecesAsignado" },
                values: new object[] { 2, "Permiso para que el trabajador descanse", "Permiso por Vacaiones", 0 });

            migrationBuilder.InsertData(
                table: "Permiso",
                columns: new[] { "PermisoId", "Descripcion", "Nombre", "VecesAsignado" },
                values: new object[] { 3, "Permiso para que el trbajador salga en caso de emergencia", "Permiso de emergencia", 0 });

            migrationBuilder.InsertData(
                table: "Permiso",
                columns: new[] { "PermisoId", "Descripcion", "Nombre", "VecesAsignado" },
                values: new object[] { 4, "Permiso para que el trabajador visite a medico en caso de enfermedad", "Permiso de salud", 0 });

            migrationBuilder.CreateIndex(
                name: "IX_RolDetalle_RolId",
                table: "RolDetalle",
                column: "RolId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Permiso");

            migrationBuilder.DropTable(
                name: "RolDetalle");

            migrationBuilder.DropTable(
                name: "Rol");
        }
    }
}
