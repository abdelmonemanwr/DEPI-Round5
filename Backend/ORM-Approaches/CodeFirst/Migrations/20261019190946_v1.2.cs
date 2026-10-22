using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CodeFirst.Migrations
{
    /// <inheritdoc />
    public partial class v12 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "FName",
                table: "Students",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Students",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "DeptId",
                table: "Students",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MgrId",
                table: "Deprtments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Students_DeptId",
                table: "Students",
                column: "DeptId");

            migrationBuilder.CreateIndex(
                name: "IX_Deprtments_MgrId",
                table: "Deprtments",
                column: "MgrId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Deprtments_Students_MgrId",
                table: "Deprtments",
                column: "MgrId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Deprtments_DeptId",
                table: "Students",
                column: "DeptId",
                principalTable: "Deprtments",
                principalColumn: "Did",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Deprtments_Students_MgrId",
                table: "Deprtments");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_Deprtments_DeptId",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Students_DeptId",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Deprtments_MgrId",
                table: "Deprtments");

            migrationBuilder.DropColumn(
                name: "DeptId",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "MgrId",
                table: "Deprtments");

            migrationBuilder.AlterColumn<string>(
                name: "FName",
                table: "Students",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Students",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");
        }
    }
}
