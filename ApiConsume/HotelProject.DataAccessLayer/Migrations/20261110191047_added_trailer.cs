using Microsoft.EntityFrameworkCore.Migrations;

namespace HotelProject.DataAccessLayer.Migrations
{
    public partial class added_trailer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Trailers",
                columns: table => new
                {
                    TrailerID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TrailerTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TrailerSubTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TrailerDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TrailerVideoFrame = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trailers", x => x.TrailerID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Trailers");
        }
    }
}
