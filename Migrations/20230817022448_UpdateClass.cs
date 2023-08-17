using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APIFilamentoExtruido.Migrations
{
    /// <inheritdoc />
    public partial class UpdateClass : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<float>(
                name: "SetPointTemperature",
                table: "ExtrudedFilaments",
                type: "real",
                nullable: false,
                defaultValue: 0f);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SetPointTemperature",
                table: "ExtrudedFilaments");
        }
    }
}
