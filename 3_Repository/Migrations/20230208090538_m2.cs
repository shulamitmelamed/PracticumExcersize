using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _3Repository.Migrations
{
    /// <inheritdoc />
    public partial class m2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PersonalDetails",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gender = table.Column<int>(type: "int", nullable: false),
                    HMO = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonalDetails", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Childrens",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PersonalDetailsId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Childrens", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Childrens_PersonalDetails_PersonalDetailsId",
                        column: x => x.PersonalDetailsId,
                        principalTable: "PersonalDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Childrens_PersonalDetailsId",
                table: "Childrens",
                column: "PersonalDetailsId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Childrens");

            migrationBuilder.DropTable(
                name: "PersonalDetails");
        }
    }
}
