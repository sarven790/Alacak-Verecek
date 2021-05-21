﻿// <auto-generated />
using System;
using AlacakVerecekTakip.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AlacakVerecekTakip.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20210416210924_mymigration")]
    partial class mymigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AlacakVerecekTakip.Models.CariHesaplarTablosu", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Ad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Adres")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("AlacakMiktar")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("AlacakVerecek")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Durum")
                        .HasColumnType("bit");

                    b.Property<string>("Soyad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefon")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("VerecekMiktar")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("uyelerTablosuID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("uyelerTablosuID");

                    b.ToTable("cariHesaplarTablosu");
                });

            modelBuilder.Entity("AlacakVerecekTakip.Models.KasaTablosu", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Bakiye")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("CikisTutari")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("GirisTutari")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("IslemTuru")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("KisiAdSoyad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UyeID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("kasaTablosu");
                });

            modelBuilder.Entity("AlacakVerecekTakip.Models.UyelerTablosu", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Durum")
                        .HasColumnType("bit");

                    b.Property<string>("KulAdi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("KulSoyadi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sifre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefon")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("uyelerTablosu");
                });

            modelBuilder.Entity("AlacakVerecekTakip.Models.CariHesaplarTablosu", b =>
                {
                    b.HasOne("AlacakVerecekTakip.Models.UyelerTablosu", "uyelerTablosu")
                        .WithMany("cariHesaplarTablosus")
                        .HasForeignKey("uyelerTablosuID");

                    b.Navigation("uyelerTablosu");
                });

            modelBuilder.Entity("AlacakVerecekTakip.Models.UyelerTablosu", b =>
                {
                    b.Navigation("cariHesaplarTablosus");
                });
#pragma warning restore 612, 618
        }
    }
}
