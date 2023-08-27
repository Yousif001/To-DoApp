using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ToDoApp.Migrations
{
    /// <inheritdoc />
    public partial class addedforeignkey : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "KanBanSectionID",
                table: "KanbanTaskItems",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateIndex(
                name: "IX_KanbanTaskItems_KanBanSectionID",
                table: "KanbanTaskItems",
                column: "KanBanSectionID");

            migrationBuilder.AddForeignKey(
                name: "FK_KanbanTaskItems_KanBanSections_KanBanSectionID",
                table: "KanbanTaskItems",
                column: "KanBanSectionID",
                principalTable: "KanBanSections",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_KanbanTaskItems_KanBanSections_KanBanSectionID",
                table: "KanbanTaskItems");

            migrationBuilder.DropIndex(
                name: "IX_KanbanTaskItems_KanBanSectionID",
                table: "KanbanTaskItems");

            migrationBuilder.DropColumn(
                name: "KanBanSectionID",
                table: "KanbanTaskItems");
        }
    }
}
