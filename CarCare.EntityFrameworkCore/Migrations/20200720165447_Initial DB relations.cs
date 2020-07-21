using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarCare.EntityFrameworkCore.Migrations
{
    public partial class InitialDBrelations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CarModels",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Brand = table.Column<string>(nullable: true),
                    Model = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarModels", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CarOwners",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarOwners", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MaintainceCategories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaintainceCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cars",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ChassisNo = table.Column<string>(nullable: true),
                    Plate = table.Column<string>(nullable: true),
                    CarModelId = table.Column<int>(nullable: false),
                    CarOwnerId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cars", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cars_CarModels_CarModelId",
                        column: x => x.CarModelId,
                        principalTable: "CarModels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Cars_CarOwners_CarOwnerId",
                        column: x => x.CarOwnerId,
                        principalTable: "CarOwners",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MaintainceSubCategories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    MaintainceCategoryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaintainceSubCategories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MaintainceSubCategories_MaintainceCategories_MaintainceCategoryId",
                        column: x => x.MaintainceCategoryId,
                        principalTable: "MaintainceCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CarMaintainces",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KM = table.Column<int>(nullable: false),
                    CarId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarMaintainces", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CarMaintainces_Cars_CarId",
                        column: x => x.CarId,
                        principalTable: "Cars",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MaintainceAndCategories",
                columns: table => new
                {
                    MaintainceCategoryId = table.Column<int>(nullable: false),
                    CarMaintainceId = table.Column<int>(nullable: false),
                    MaintainceDate = table.Column<DateTime>(nullable: false),
                    NextMaintainceDate = table.Column<DateTime>(nullable: false),
                    MaintainceKM = table.Column<int>(nullable: false),
                    NextMiantainceKM = table.Column<int>(nullable: false),
                    MaintainceDescription = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaintainceAndCategories", x => new { x.CarMaintainceId, x.MaintainceCategoryId });
                    table.ForeignKey(
                        name: "FK_MaintainceAndCategories_CarMaintainces_CarMaintainceId",
                        column: x => x.CarMaintainceId,
                        principalTable: "CarMaintainces",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MaintainceAndCategories_MaintainceCategories_MaintainceCategoryId",
                        column: x => x.MaintainceCategoryId,
                        principalTable: "MaintainceCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CarMaintainces_CarId",
                table: "CarMaintainces",
                column: "CarId");

            migrationBuilder.CreateIndex(
                name: "IX_Cars_CarModelId",
                table: "Cars",
                column: "CarModelId");

            migrationBuilder.CreateIndex(
                name: "IX_Cars_CarOwnerId",
                table: "Cars",
                column: "CarOwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_MaintainceAndCategories_MaintainceCategoryId",
                table: "MaintainceAndCategories",
                column: "MaintainceCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_MaintainceSubCategories_MaintainceCategoryId",
                table: "MaintainceSubCategories",
                column: "MaintainceCategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MaintainceAndCategories");

            migrationBuilder.DropTable(
                name: "MaintainceSubCategories");

            migrationBuilder.DropTable(
                name: "CarMaintainces");

            migrationBuilder.DropTable(
                name: "MaintainceCategories");

            migrationBuilder.DropTable(
                name: "Cars");

            migrationBuilder.DropTable(
                name: "CarModels");

            migrationBuilder.DropTable(
                name: "CarOwners");
        }
    }
}
