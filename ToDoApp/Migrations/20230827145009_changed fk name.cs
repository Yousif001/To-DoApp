using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ToDoApp.Migrations
{
    /// <inheritdoc />
    public partial class changedfkname : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_KanbanTaskItems_KanBanSections_KanBanSectionID",
                table: "KanbanTaskItems");

            migrationBuilder.RenameColumn(
                name: "KanBanSectionID",
                table: "KanbanTaskItems",
                newName: "KanBanSectionFKID");

            migrationBuilder.RenameIndex(
                name: "IX_KanbanTaskItems_KanBanSectionID",
                table: "KanbanTaskItems",
                newName: "IX_KanbanTaskItems_KanBanSectionFKID");

            migrationBuilder.AddForeignKey(
                name: "FK_KanbanTaskItems_KanBanSections_KanBanSectionFKID",
                table: "KanbanTaskItems",
                column: "KanBanSectionFKID",
                principalTable: "KanBanSections",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_KanbanTaskItems_KanBanSections_KanBanSectionFKID",
                table: "KanbanTaskItems");

            migrationBuilder.RenameColumn(
                name: "KanBanSectionFKID",
                table: "KanbanTaskItems",
                newName: "KanBanSectionID");

            migrationBuilder.RenameIndex(
                name: "IX_KanbanTaskItems_KanBanSectionFKID",
                table: "KanbanTaskItems",
                newName: "IX_KanbanTaskItems_KanBanSectionID");

            migrationBuilder.AddForeignKey(
                name: "FK_KanbanTaskItems_KanBanSections_KanBanSectionID",
                table: "KanbanTaskItems",
                column: "KanBanSectionID",
                principalTable: "KanBanSections",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
