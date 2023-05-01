using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProyectoClase5Review.Migrations
{
    /// <inheritdoc />
    public partial class MotivoReparacion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "motivoReparacion",
                table: "Car",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "motivoReparacion",
                table: "Car");
        }
    }
}
