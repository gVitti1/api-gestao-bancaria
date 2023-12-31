﻿// <auto-generated />
using System;
using Gestao_API.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Gestao_API.Migrations
{
    [DbContext(typeof(GestaoDbContext))]
    [Migration("20230913172942_primeira-migration")]
    partial class primeiramigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Gestao_API.Models.Transacao", b =>
                {
                    b.Property<Guid>("TransacaoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("HoraLancamento")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid>("TransferenciaId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("UsuarioId")
                        .HasColumnType("uuid");

                    b.Property<decimal>("Valor")
                        .HasColumnType("numeric");

                    b.HasKey("TransacaoId");

                    b.ToTable("Transacoes");
                });

            modelBuilder.Entity("Gestao_API.Models.Usuario", b =>
                {
                    b.Property<Guid>("UsuarioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("UsuarioId");

                    b.ToTable("Usuarios");
                });
#pragma warning restore 612, 618
        }
    }
}
