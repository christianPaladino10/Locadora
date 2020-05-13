using Microsoft.EntityFrameworkCore.Migrations;

namespace Locadora.Repository.Migrations
{
    public partial class tipo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TipoStreaming_Streaming_StreamingId",
                table: "TipoStreaming");

            migrationBuilder.DropIndex(
                name: "IX_TipoStreaming_StreamingId",
                table: "TipoStreaming");

            migrationBuilder.DropColumn(
                name: "StreamingId",
                table: "TipoStreaming");

            migrationBuilder.AddColumn<int>(
                name: "TipoStreamingId",
                table: "Streaming",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Streaming_TipoStreamingId",
                table: "Streaming",
                column: "TipoStreamingId");

            migrationBuilder.AddForeignKey(
                name: "FK_Streaming_TipoStreaming_TipoStreamingId",
                table: "Streaming",
                column: "TipoStreamingId",
                principalTable: "TipoStreaming",
                principalColumn: "TipoStreamingId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Streaming_TipoStreaming_TipoStreamingId",
                table: "Streaming");

            migrationBuilder.DropIndex(
                name: "IX_Streaming_TipoStreamingId",
                table: "Streaming");

            migrationBuilder.DropColumn(
                name: "TipoStreamingId",
                table: "Streaming");

            migrationBuilder.AddColumn<int>(
                name: "StreamingId",
                table: "TipoStreaming",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_TipoStreaming_StreamingId",
                table: "TipoStreaming",
                column: "StreamingId");

            migrationBuilder.AddForeignKey(
                name: "FK_TipoStreaming_Streaming_StreamingId",
                table: "TipoStreaming",
                column: "StreamingId",
                principalTable: "Streaming",
                principalColumn: "StreamingId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
