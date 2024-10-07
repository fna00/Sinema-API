﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using myfirstapi.Models;

#nullable disable

namespace myfirstapi.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20230820103004_roldenemesi")]
    partial class roldenemesi
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("myfirstapi.Models.Bilet", b =>
                {
                    b.Property<int>("BiletId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BiletId"));

                    b.Property<int>("KullaniciId")
                        .HasColumnType("int");

                    b.Property<int>("SeansId")
                        .HasColumnType("int");

                    b.HasKey("BiletId");

                    b.ToTable("Bilets");
                });

            modelBuilder.Entity("myfirstapi.Models.Film", b =>
                {
                    b.Property<int>("FilmId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FilmId"));

                    b.Property<string>("Filmad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Filmsüre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Filmvizyondurumu")
                        .HasColumnType("bit");

                    b.Property<DateTime>("Filmvizyontarihi")
                        .HasColumnType("datetime2");

                    b.Property<int>("TurId")
                        .HasColumnType("int");

                    b.Property<int>("YonetmenId")
                        .HasColumnType("int");

                    b.HasKey("FilmId");

                    b.ToTable("Films");
                });

            modelBuilder.Entity("myfirstapi.Models.Kullanici", b =>
                {
                    b.Property<int>("KullaniciId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("KullaniciId"));

                    b.Property<string>("KullaniciTC")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Kullaniciad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Kullaniciadres")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Kullanicicinsiyet")
                        .HasColumnType("bit");

                    b.Property<string>("Kullanicid_tarihi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Kullanicimail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Kullanicisifre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Kullanicisoyad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Kullanicitelefon")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RolId")
                        .HasColumnType("int");

                    b.HasKey("KullaniciId");

                    b.ToTable("Kullanicis");
                });

            modelBuilder.Entity("myfirstapi.Models.Rol", b =>
                {
                    b.Property<int>("RolId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RolId"));

                    b.Property<string>("Rolad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RolId");

                    b.ToTable("Rols");
                });

            modelBuilder.Entity("myfirstapi.Models.Seans", b =>
                {
                    b.Property<int>("SeansId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SeansId"));

                    b.Property<int>("FilmId")
                        .HasColumnType("int");

                    b.Property<string>("Seanssaat")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SeansId");

                    b.ToTable("Seanss");
                });

            modelBuilder.Entity("myfirstapi.Models.Tur", b =>
                {
                    b.Property<int>("TurId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TurId"));

                    b.Property<string>("Turad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TurId");

                    b.ToTable("Turs");
                });

            modelBuilder.Entity("myfirstapi.Models.Yonetmen", b =>
                {
                    b.Property<int>("YonetmenId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("YonetmenId"));

                    b.Property<string>("Yonetmenad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Yonetmensoyad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("YonetmenId");

                    b.ToTable("Yonetmens");
                });
#pragma warning restore 612, 618
        }
    }
}
