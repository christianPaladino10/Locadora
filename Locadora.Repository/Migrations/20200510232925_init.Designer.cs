﻿// <auto-generated />
using System;
using Locadora.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Locadora.Repository.Migrations
{
    [DbContext(typeof(LocadoraContext))]
    [Migration("20200510232925_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Locadora.Domain.Aluguel", b =>
                {
                    b.Property<int>("AluguelId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ClienteId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DataFimContratacao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataInicioContratacao")
                        .HasColumnType("datetime2");

                    b.Property<int>("StreamingId")
                        .HasColumnType("int");

                    b.HasKey("AluguelId");

                    b.HasIndex("ClienteId");

                    b.HasIndex("StreamingId");

                    b.ToTable("Aluguel");
                });

            modelBuilder.Entity("Locadora.Domain.Ator", b =>
                {
                    b.Property<int>("AtorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AtorId");

                    b.ToTable("Ator");
                });

            modelBuilder.Entity("Locadora.Domain.Cliente", b =>
                {
                    b.Property<int>("ClienteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DataCadastro")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataModificado")
                        .HasColumnType("datetime2");

                    b.Property<int>("PlanoId")
                        .HasColumnType("int");

                    b.HasKey("ClienteId");

                    b.HasIndex("PlanoId");

                    b.ToTable("Cliente");
                });

            modelBuilder.Entity("Locadora.Domain.Genero", b =>
                {
                    b.Property<int>("GeneroId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descricao")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GeneroId");

                    b.ToTable("Genero");
                });

            modelBuilder.Entity("Locadora.Domain.GeneroStreaming", b =>
                {
                    b.Property<int>("StreamingId")
                        .HasColumnType("int");

                    b.Property<int>("GeneroId")
                        .HasColumnType("int");

                    b.HasKey("StreamingId", "GeneroId");

                    b.HasIndex("GeneroId");

                    b.ToTable("GeneroStreaming");
                });

            modelBuilder.Entity("Locadora.Domain.Plano", b =>
                {
                    b.Property<int>("PlanoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("QtdAluguelSimultaneo")
                        .HasColumnType("int");

                    b.Property<string>("Tipo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PlanoId");

                    b.ToTable("Plano");
                });

            modelBuilder.Entity("Locadora.Domain.Streaming", b =>
                {
                    b.Property<int>("StreamingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ClassificacaoIndicativa")
                        .HasColumnType("int");

                    b.Property<DateTime>("DataCadastro")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataLancamento")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataModificado")
                        .HasColumnType("datetime2");

                    b.Property<string>("ImagemURL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sinopse")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Titulo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StreamingId");

                    b.ToTable("Streaming");
                });

            modelBuilder.Entity("Locadora.Domain.StreamingAtor", b =>
                {
                    b.Property<int>("StreamingId")
                        .HasColumnType("int");

                    b.Property<int>("AtorId")
                        .HasColumnType("int");

                    b.HasKey("StreamingId", "AtorId");

                    b.HasIndex("AtorId");

                    b.ToTable("StreamingAtor");
                });

            modelBuilder.Entity("Locadora.Domain.TipoStreaming", b =>
                {
                    b.Property<int>("TipoStreamingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("StreamingId")
                        .HasColumnType("int");

                    b.Property<string>("Tipo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TipoStreamingId");

                    b.HasIndex("StreamingId");

                    b.ToTable("TipoStreaming");
                });

            modelBuilder.Entity("Locadora.Domain.Aluguel", b =>
                {
                    b.HasOne("Locadora.Domain.Cliente", "Cliente")
                        .WithMany()
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Locadora.Domain.Streaming", "Streaming")
                        .WithMany()
                        .HasForeignKey("StreamingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Locadora.Domain.Cliente", b =>
                {
                    b.HasOne("Locadora.Domain.Plano", "Plano")
                        .WithMany()
                        .HasForeignKey("PlanoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Locadora.Domain.GeneroStreaming", b =>
                {
                    b.HasOne("Locadora.Domain.Genero", "Genero")
                        .WithMany()
                        .HasForeignKey("GeneroId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Locadora.Domain.Streaming", "Streaming")
                        .WithMany("GeneroStreaming")
                        .HasForeignKey("StreamingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Locadora.Domain.StreamingAtor", b =>
                {
                    b.HasOne("Locadora.Domain.Ator", "Ator")
                        .WithMany("StreamingAtor")
                        .HasForeignKey("AtorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Locadora.Domain.Streaming", "Streaming")
                        .WithMany("StreamingElenco")
                        .HasForeignKey("StreamingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Locadora.Domain.TipoStreaming", b =>
                {
                    b.HasOne("Locadora.Domain.Streaming", null)
                        .WithMany("TipoStreaming")
                        .HasForeignKey("StreamingId");
                });
#pragma warning restore 612, 618
        }
    }
}
