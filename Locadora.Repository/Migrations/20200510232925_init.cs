using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Locadora.Repository.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ator",
                columns: table => new
                {
                    AtorId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ator", x => x.AtorId);
                });

            migrationBuilder.CreateTable(
                name: "Genero",
                columns: table => new
                {
                    GeneroId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descricao = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genero", x => x.GeneroId);
                });

            migrationBuilder.CreateTable(
                name: "Plano",
                columns: table => new
                {
                    PlanoId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tipo = table.Column<string>(nullable: true),
                    QtdAluguelSimultaneo = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Plano", x => x.PlanoId);
                });

            migrationBuilder.CreateTable(
                name: "Streaming",
                columns: table => new
                {
                    StreamingId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Sinopse = table.Column<string>(nullable: true),
                    Titulo = table.Column<string>(nullable: true),
                    ClassificacaoIndicativa = table.Column<int>(nullable: false),
                    ImagemURL = table.Column<string>(nullable: true),
                    DataLancamento = table.Column<DateTime>(nullable: false),
                    DataCadastro = table.Column<DateTime>(nullable: false),
                    DataModificado = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Streaming", x => x.StreamingId);
                });

            migrationBuilder.CreateTable(
                name: "Cliente",
                columns: table => new
                {
                    ClienteId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlanoId = table.Column<int>(nullable: false),
                    DataCadastro = table.Column<DateTime>(nullable: false),
                    DataModificado = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cliente", x => x.ClienteId);
                    table.ForeignKey(
                        name: "FK_Cliente_Plano_PlanoId",
                        column: x => x.PlanoId,
                        principalTable: "Plano",
                        principalColumn: "PlanoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GeneroStreaming",
                columns: table => new
                {
                    GeneroId = table.Column<int>(nullable: false),
                    StreamingId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GeneroStreaming", x => new { x.StreamingId, x.GeneroId });
                    table.ForeignKey(
                        name: "FK_GeneroStreaming_Genero_GeneroId",
                        column: x => x.GeneroId,
                        principalTable: "Genero",
                        principalColumn: "GeneroId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GeneroStreaming_Streaming_StreamingId",
                        column: x => x.StreamingId,
                        principalTable: "Streaming",
                        principalColumn: "StreamingId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StreamingAtor",
                columns: table => new
                {
                    AtorId = table.Column<int>(nullable: false),
                    StreamingId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StreamingAtor", x => new { x.StreamingId, x.AtorId });
                    table.ForeignKey(
                        name: "FK_StreamingAtor_Ator_AtorId",
                        column: x => x.AtorId,
                        principalTable: "Ator",
                        principalColumn: "AtorId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StreamingAtor_Streaming_StreamingId",
                        column: x => x.StreamingId,
                        principalTable: "Streaming",
                        principalColumn: "StreamingId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TipoStreaming",
                columns: table => new
                {
                    TipoStreamingId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tipo = table.Column<string>(nullable: true),
                    StreamingId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoStreaming", x => x.TipoStreamingId);
                    table.ForeignKey(
                        name: "FK_TipoStreaming_Streaming_StreamingId",
                        column: x => x.StreamingId,
                        principalTable: "Streaming",
                        principalColumn: "StreamingId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Aluguel",
                columns: table => new
                {
                    AluguelId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DataInicioContratacao = table.Column<DateTime>(nullable: false),
                    DataFimContratacao = table.Column<DateTime>(nullable: false),
                    ClienteId = table.Column<int>(nullable: false),
                    StreamingId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Aluguel", x => x.AluguelId);
                    table.ForeignKey(
                        name: "FK_Aluguel_Cliente_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Cliente",
                        principalColumn: "ClienteId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Aluguel_Streaming_StreamingId",
                        column: x => x.StreamingId,
                        principalTable: "Streaming",
                        principalColumn: "StreamingId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Aluguel_ClienteId",
                table: "Aluguel",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_Aluguel_StreamingId",
                table: "Aluguel",
                column: "StreamingId");

            migrationBuilder.CreateIndex(
                name: "IX_Cliente_PlanoId",
                table: "Cliente",
                column: "PlanoId");

            migrationBuilder.CreateIndex(
                name: "IX_GeneroStreaming_GeneroId",
                table: "GeneroStreaming",
                column: "GeneroId");

            migrationBuilder.CreateIndex(
                name: "IX_StreamingAtor_AtorId",
                table: "StreamingAtor",
                column: "AtorId");

            migrationBuilder.CreateIndex(
                name: "IX_TipoStreaming_StreamingId",
                table: "TipoStreaming",
                column: "StreamingId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Aluguel");

            migrationBuilder.DropTable(
                name: "GeneroStreaming");

            migrationBuilder.DropTable(
                name: "StreamingAtor");

            migrationBuilder.DropTable(
                name: "TipoStreaming");

            migrationBuilder.DropTable(
                name: "Cliente");

            migrationBuilder.DropTable(
                name: "Genero");

            migrationBuilder.DropTable(
                name: "Ator");

            migrationBuilder.DropTable(
                name: "Streaming");

            migrationBuilder.DropTable(
                name: "Plano");
        }
    }
}
