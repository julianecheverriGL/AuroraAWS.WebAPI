using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AuroraAWS.WebApi.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Applications",
                columns: table => new
                {
                    ApplicationId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ApplicationCode = table.Column<byte>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Applications", x => x.ApplicationId);
                });

            migrationBuilder.CreateTable(
                name: "ExternalUsersMap",
                columns: table => new
                {
                    ExternalUserMapId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ExternalUserId = table.Column<int>(nullable: false),
                    ExternalUserType = table.Column<byte>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExternalUsersMap", x => x.ExternalUserMapId);
                });

            migrationBuilder.CreateTable(
                name: "ExternalUsersApplicationMap",
                columns: table => new
                {
                    ExternalUserApplicationMapId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ExternalUserMapId = table.Column<int>(nullable: false),
                    ApplicationId = table.Column<int>(nullable: false),
                    MetaData = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExternalUsersApplicationMap", x => x.ExternalUserApplicationMapId);
                    table.ForeignKey(
                        name: "FK_ExternalUsersApplicationMap_Applications_ApplicationId",
                        column: x => x.ApplicationId,
                        principalTable: "Applications",
                        principalColumn: "ApplicationId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ExternalUsersApplicationMap_ExternalUsersMap_ExternalUserMap~",
                        column: x => x.ExternalUserMapId,
                        principalTable: "ExternalUsersMap",
                        principalColumn: "ExternalUserMapId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ExternalUsersApplicationMap_ApplicationId",
                table: "ExternalUsersApplicationMap",
                column: "ApplicationId");

            migrationBuilder.CreateIndex(
                name: "IX_ExternalUsersApplicationMap_ExternalUserMapId",
                table: "ExternalUsersApplicationMap",
                column: "ExternalUserMapId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ExternalUsersApplicationMap");

            migrationBuilder.DropTable(
                name: "Applications");

            migrationBuilder.DropTable(
                name: "ExternalUsersMap");
        }
    }
}
