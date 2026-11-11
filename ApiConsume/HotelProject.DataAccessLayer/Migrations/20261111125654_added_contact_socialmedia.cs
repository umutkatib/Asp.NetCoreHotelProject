using Microsoft.EntityFrameworkCore.Migrations;

namespace HotelProject.DataAccessLayer.Migrations
{
    public partial class added_contact_socialmedia : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    ContactID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ContactAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactCity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactDistrict = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactCountry = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactPhone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactMail = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.ContactID);
                });

            migrationBuilder.CreateTable(
                name: "SocialMedias",
                columns: table => new
                {
                    SocialMediaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SocialMediaTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SocialMediaIcon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SocialMediaLink = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SocialMedias", x => x.SocialMediaID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contacts");

            migrationBuilder.DropTable(
                name: "SocialMedias");
        }
    }
}
