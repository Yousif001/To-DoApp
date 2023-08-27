using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ToDoApp.Migrations
{
    /// <inheritdoc />
    public partial class changedfktype : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_KanbanTaskItems_KanBanSections_KanBanSectionFKID",
                table: "KanbanTaskItems");

            migrationBuilder.DropIndex(
                name: "IX_KanbanTaskItems_KanBanSectionFKID",
                table: "KanbanTaskItems");

            migrationBuilder.RenameColumn(
                name: "KanBanSectionFKID",
                table: "KanbanTaskItems",
                newName: "KanBanSectionFK");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "KanBanSectionFK",
                table: "KanbanTaskItems",
                newName: "KanBanSectionFKID");

            migrationBuilder.CreateIndex(
                name: "IX_KanbanTaskItems_KanBanSectionFKID",
                table: "KanbanTaskItems",
                column: "KanBanSectionFKID");

            migrationBuilder.AddForeignKey(
                name: "FK_KanbanTaskItems_KanBanSections_KanBanSectionFKID",
                table: "KanbanTaskItems",
                column: "KanBanSectionFKID",
                principalTable: "KanBanSections",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
