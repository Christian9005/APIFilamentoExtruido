using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APIFilamentoExtruido.Migrations
{
    /// <inheritdoc />
    public partial class AddedEnableMotor : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "EnableMotor",
                table: "ExtrudedFilaments",
                type: "boolean",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EnableMotor",
                table: "ExtrudedFilaments");
        }
    }
}
