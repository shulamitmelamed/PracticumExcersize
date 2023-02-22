using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _3Repository.Migrations
{
    /// <inheritdoc />
    public partial class m7 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Childrens_PersonalDetails_PersonalDetailsId",
                table: "Childrens");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PersonalDetails",
                table: "PersonalDetails");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Childrens",
                table: "Childrens");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "PersonalDetails");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Childrens");

            migrationBuilder.AddColumn<int>(
                name: "PersonalDetailsId",
                table: "PersonalDetails",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<string>(
                name: "IdNumber",
                table: "PersonalDetails",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<int>(
                name: "PersonalDetailsId",
                table: "Childrens",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<int>(
                name: "ChildrenId",
                table: "Childrens",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<string>(
                name: "IdNumber",
                table: "Childrens",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PersonalDetails",
                table: "PersonalDetails",
                column: "PersonalDetailsId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Childrens",
                table: "Childrens",
                column: "ChildrenId");

            migrationBuilder.AddForeignKey(
                name: "FK_Childrens_PersonalDetails_PersonalDetailsId",
                table: "Childrens",
                column: "PersonalDetailsId",
                principalTable: "PersonalDetails",
                principalColumn: "PersonalDetailsId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Childrens_PersonalDetails_PersonalDetailsId",
                table: "Childrens");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PersonalDetails",
                table: "PersonalDetails");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Childrens",
                table: "Childrens");

            migrationBuilder.DropColumn(
                name: "PersonalDetailsId",
                table: "PersonalDetails");

            migrationBuilder.DropColumn(
                name: "IdNumber",
                table: "PersonalDetails");

            migrationBuilder.DropColumn(
                name: "ChildrenId",
                table: "Childrens");

            migrationBuilder.DropColumn(
                name: "IdNumber",
                table: "Childrens");

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "PersonalDetails",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "PersonalDetailsId",
                table: "Childrens",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "Childrens",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PersonalDetails",
                table: "PersonalDetails",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Childrens",
                table: "Childrens",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Childrens_PersonalDetails_PersonalDetailsId",
                table: "Childrens",
                column: "PersonalDetailsId",
                principalTable: "PersonalDetails",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
