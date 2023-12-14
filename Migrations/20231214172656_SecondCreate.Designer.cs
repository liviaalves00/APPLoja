﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using livia.Models;

#nullable disable

namespace livia.Migrations
{
    [DbContext(typeof(MyDbContext))]
    [Migration("20231214172656_SecondCreate")]
    partial class SecondCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("livia.Models.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .HasColumnType("longtext");

                    b.Property<int?>("NotaDeVendaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("NotaDeVendaId");

                    b.ToTable("Cliente");
                });

            modelBuilder.Entity("livia.Models.Item", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<double>("Preco")
                        .HasColumnType("double");

                    b.Property<int>("ProdutoId")
                        .HasColumnType("int");

                    b.Property<int>("Quantidade")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProdutoId");

                    b.ToTable("Item");
                });

            modelBuilder.Entity("livia.Models.Marca", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Descricao")
                        .HasColumnType("longtext");

                    b.Property<int?>("MarcaProdutoId")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("MarcaProdutoId");

                    b.ToTable("Marca");
                });

            modelBuilder.Entity("livia.Models.NotaDeVenda", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("Data")
                        .HasColumnType("datetime(6)");

                    b.Property<bool>("Tipo")
                        .HasColumnType("tinyint(1)");

                    b.Property<int?>("TipoDePagamentoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TipoDePagamentoId");

                    b.ToTable("NotaDeVenda");
                });

            modelBuilder.Entity("livia.Models.Pagamento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("DataLimite")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("NotaDeVendaId")
                        .HasColumnType("int");

                    b.Property<bool>("Pago")
                        .HasColumnType("tinyint(1)");

                    b.Property<double>("Valor")
                        .HasColumnType("double");

                    b.HasKey("Id");

                    b.HasIndex("NotaDeVendaId");

                    b.ToTable("Pagamento");
                });

            modelBuilder.Entity("livia.Models.Produto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Descricao")
                        .HasColumnType("longtext");

                    b.Property<string>("Nome")
                        .HasColumnType("longtext");

                    b.Property<double>("Preco")
                        .HasColumnType("double");

                    b.Property<int>("Quantidade")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Produto");
                });

            modelBuilder.Entity("livia.Models.TipoDePagamento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("InformacoesAdicionais")
                        .HasColumnType("longtext");

                    b.Property<string>("NomeDoCobrado")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("TipoDePagamento");

                    b.HasDiscriminator<string>("Discriminator").HasValue("TipoDePagamento");
                });

            modelBuilder.Entity("livia.Models.Transportadora", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .HasColumnType("longtext");

                    b.Property<int>("NotaDeVendaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("NotaDeVendaId");

                    b.ToTable("Transportadora");
                });

            modelBuilder.Entity("livia.Models.Vendedor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .HasColumnType("longtext");

                    b.Property<int>("NotaDeVendaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("NotaDeVendaId");

                    b.ToTable("Vendedor");
                });

            modelBuilder.Entity("MarcaProduto", b =>
                {
                    b.Property<int>("MarcaProdutoId")
                        .HasColumnType("int");

                    b.Property<int>("ProdutosId")
                        .HasColumnType("int");

                    b.HasKey("MarcaProdutoId", "ProdutosId");

                    b.HasIndex("ProdutosId");

                    b.ToTable("MarcaProduto");
                });

            modelBuilder.Entity("livia.Models.PagamentoComCartao", b =>
                {
                    b.HasBaseType("livia.Models.TipoDePagamento");

                    b.Property<string>("Bandeira")
                        .HasColumnType("longtext");

                    b.Property<int>("NumeroDoCartao")
                        .HasColumnType("int");

                    b.HasDiscriminator().HasValue("PagamentoComCartao");
                });

            modelBuilder.Entity("livia.Models.PagamentoComCheque", b =>
                {
                    b.HasBaseType("livia.Models.TipoDePagamento");

                    b.Property<int>("Banco")
                        .HasColumnType("int");

                    b.Property<string>("NomeDoBanco")
                        .HasColumnType("longtext");

                    b.HasDiscriminator().HasValue("PagamentoComCheque");
                });

            modelBuilder.Entity("livia.Models.Cliente", b =>
                {
                    b.HasOne("livia.Models.NotaDeVenda", "NotaDeVenda")
                        .WithMany("ClienteVenda")
                        .HasForeignKey("NotaDeVendaId");

                    b.Navigation("NotaDeVenda");
                });

            modelBuilder.Entity("livia.Models.Item", b =>
                {
                    b.HasOne("livia.Models.Produto", "Produto")
                        .WithMany("ItemProduto")
                        .HasForeignKey("ProdutoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Produto");
                });

            modelBuilder.Entity("livia.Models.Marca", b =>
                {
                    b.HasOne("livia.Models.Marca", "MarcaProduto")
                        .WithMany()
                        .HasForeignKey("MarcaProdutoId");

                    b.Navigation("MarcaProduto");
                });

            modelBuilder.Entity("livia.Models.NotaDeVenda", b =>
                {
                    b.HasOne("livia.Models.TipoDePagamento", "TipoDePagamento")
                        .WithMany("NotaDeVenda")
                        .HasForeignKey("TipoDePagamentoId");

                    b.Navigation("TipoDePagamento");
                });

            modelBuilder.Entity("livia.Models.Pagamento", b =>
                {
                    b.HasOne("livia.Models.NotaDeVenda", "NotaDeVenda")
                        .WithMany("PagamentoVenda")
                        .HasForeignKey("NotaDeVendaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("NotaDeVenda");
                });

            modelBuilder.Entity("livia.Models.Transportadora", b =>
                {
                    b.HasOne("livia.Models.NotaDeVenda", "NotaDeVenda")
                        .WithMany("TransportadoraVenda")
                        .HasForeignKey("NotaDeVendaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("NotaDeVenda");
                });

            modelBuilder.Entity("livia.Models.Vendedor", b =>
                {
                    b.HasOne("livia.Models.NotaDeVenda", "NotaDeVenda")
                        .WithMany("VendedorVenda")
                        .HasForeignKey("NotaDeVendaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("NotaDeVenda");
                });

            modelBuilder.Entity("MarcaProduto", b =>
                {
                    b.HasOne("livia.Models.Marca", null)
                        .WithMany()
                        .HasForeignKey("MarcaProdutoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("livia.Models.Produto", null)
                        .WithMany()
                        .HasForeignKey("ProdutosId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("livia.Models.NotaDeVenda", b =>
                {
                    b.Navigation("ClienteVenda");

                    b.Navigation("PagamentoVenda");

                    b.Navigation("TransportadoraVenda");

                    b.Navigation("VendedorVenda");
                });

            modelBuilder.Entity("livia.Models.Produto", b =>
                {
                    b.Navigation("ItemProduto");
                });

            modelBuilder.Entity("livia.Models.TipoDePagamento", b =>
                {
                    b.Navigation("NotaDeVenda");
                });
#pragma warning restore 612, 618
        }
    }
}
