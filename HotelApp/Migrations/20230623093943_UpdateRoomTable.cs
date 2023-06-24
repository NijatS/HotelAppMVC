using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelApp.Migrations
{
    /// <inheritdoc />
    public partial class UpdateRoomTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DayCounts_RoomDayCounts_RoomDayCountId",
                table: "DayCounts");

            migrationBuilder.DropForeignKey(
                name: "FK_Rooms_RoomDayCounts_RoomDayCountId",
                table: "Rooms");

            migrationBuilder.DropIndex(
                name: "IX_Rooms_RoomDayCountId",
                table: "Rooms");

            migrationBuilder.DropIndex(
                name: "IX_DayCounts_RoomDayCountId",
                table: "DayCounts");

            migrationBuilder.DropColumn(
                name: "RoomDayCountId",
                table: "Rooms");

            migrationBuilder.DropColumn(
                name: "RoomDayCountId",
                table: "DayCounts");

            migrationBuilder.AddColumn<int>(
                name: "DayCountId",
                table: "RoomDayCounts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "RoomId",
                table: "RoomDayCounts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Specifications",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Icon = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Specifications", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RoomSpecifications",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoomId = table.Column<int>(type: "int", nullable: false),
                    SpecificationId = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoomSpecifications", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RoomSpecifications_Rooms_RoomId",
                        column: x => x.RoomId,
                        principalTable: "Rooms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RoomSpecifications_Specifications_SpecificationId",
                        column: x => x.SpecificationId,
                        principalTable: "Specifications",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_RoomDayCounts_DayCountId",
                table: "RoomDayCounts",
                column: "DayCountId");

            migrationBuilder.CreateIndex(
                name: "IX_RoomDayCounts_RoomId",
                table: "RoomDayCounts",
                column: "RoomId");

            migrationBuilder.CreateIndex(
                name: "IX_RoomSpecifications_RoomId",
                table: "RoomSpecifications",
                column: "RoomId");

            migrationBuilder.CreateIndex(
                name: "IX_RoomSpecifications_SpecificationId",
                table: "RoomSpecifications",
                column: "SpecificationId");

            migrationBuilder.AddForeignKey(
                name: "FK_RoomDayCounts_DayCounts_DayCountId",
                table: "RoomDayCounts",
                column: "DayCountId",
                principalTable: "DayCounts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RoomDayCounts_Rooms_RoomId",
                table: "RoomDayCounts",
                column: "RoomId",
                principalTable: "Rooms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RoomDayCounts_DayCounts_DayCountId",
                table: "RoomDayCounts");

            migrationBuilder.DropForeignKey(
                name: "FK_RoomDayCounts_Rooms_RoomId",
                table: "RoomDayCounts");

            migrationBuilder.DropTable(
                name: "RoomSpecifications");

            migrationBuilder.DropTable(
                name: "Specifications");

            migrationBuilder.DropIndex(
                name: "IX_RoomDayCounts_DayCountId",
                table: "RoomDayCounts");

            migrationBuilder.DropIndex(
                name: "IX_RoomDayCounts_RoomId",
                table: "RoomDayCounts");

            migrationBuilder.DropColumn(
                name: "DayCountId",
                table: "RoomDayCounts");

            migrationBuilder.DropColumn(
                name: "RoomId",
                table: "RoomDayCounts");

            migrationBuilder.AddColumn<int>(
                name: "RoomDayCountId",
                table: "Rooms",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "RoomDayCountId",
                table: "DayCounts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Rooms_RoomDayCountId",
                table: "Rooms",
                column: "RoomDayCountId");

            migrationBuilder.CreateIndex(
                name: "IX_DayCounts_RoomDayCountId",
                table: "DayCounts",
                column: "RoomDayCountId");

            migrationBuilder.AddForeignKey(
                name: "FK_DayCounts_RoomDayCounts_RoomDayCountId",
                table: "DayCounts",
                column: "RoomDayCountId",
                principalTable: "RoomDayCounts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Rooms_RoomDayCounts_RoomDayCountId",
                table: "Rooms",
                column: "RoomDayCountId",
                principalTable: "RoomDayCounts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
