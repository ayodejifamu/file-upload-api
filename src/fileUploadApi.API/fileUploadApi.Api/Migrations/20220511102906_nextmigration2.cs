using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace fileUploadApi.Api.Migrations
{
    public partial class nextmigration2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "fileInfo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    fileTypeId = table.Column<int>(type: "int", nullable: false),
                    filename = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    fileTypeExtension = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    updatedFileName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    fileDataBS64 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    fileDataBS641 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    fileUniqueId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    userUniqueId = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_fileInfo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "fileTypeInfo",
                columns: table => new
                {
                    baseId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    fileType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    fileTypeAcceptableExtensions = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    maxFileSizeToLetSaveInDb = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("baseId", x => x.baseId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "fileInfo");

            migrationBuilder.DropTable(
                name: "fileTypeInfo");
        }
    }
}
