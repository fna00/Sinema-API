﻿// <auto-generated />
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
    [Migration("20230727085203_seans")]
    partial class seans
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("myfirstapi.Models.BiletFiyat", b =>
                {
                    b.Property<int>("BiletFiyatId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BiletFiyatId"));

                    b.Property<double>("Biletfiyat")
                        .HasColumnType("float");

                    b.Property<string>("Bilettur")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IndirimId")
                        .HasColumnType("int");

                    b.HasKey("BiletFiyatId");

                    b.HasIndex("IndirimId");

                    b.ToTable("BiletFiyats");
                });

            modelBuilder.Entity("myfirstapi.Models.Indirim", b =>
                {
                    b.Property<int>("IndirimId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IndirimId"));

                    b.Property<string>("Indirimad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Indirimgun")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Indirimiçecek")
                        .HasColumnType("bit");

                    b.Property<bool>("Indirimmisir")
                        .HasColumnType("bit");

                    b.HasKey("IndirimId");

                    b.ToTable("Indirims");
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

                    b.Property<int>("Kullanicid_tarihi")
                        .HasColumnType("int");

                    b.Property<string>("Kullanicimail")
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

                    b.HasIndex("RolId");

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

            modelBuilder.Entity("myfirstapi.Models.Salon", b =>
                {
                    b.Property<int>("SalonId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SalonId"));

                    b.Property<int>("SalonNo")
                        .HasColumnType("int");

                    b.Property<int>("Salonkapasite")
                        .HasColumnType("int");

                    b.HasKey("SalonId");

                    b.ToTable("Salons");
                });

            modelBuilder.Entity("myfirstapi.Models.Seans", b =>
                {
                    b.Property<int>("SeansId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SeansId"));

                    b.Property<int>("SalomId")
                        .HasColumnType("int");

                    b.Property<string>("Seanssaat")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SeansId");

                    b.HasIndex("SalomId");

                    b.ToTable("Seans");
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

            modelBuilder.Entity("myfirstapi.Models.BiletFiyat", b =>
                {
                    b.HasOne("myfirstapi.Models.Indirim", "Indirims")
                        .WithMany()
                        .HasForeignKey("IndirimId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Indirims");
                });

            modelBuilder.Entity("myfirstapi.Models.Kullanici", b =>
                {
                    b.HasOne("myfirstapi.Models.Rol", "Rols")
                        .WithMany()
                        .HasForeignKey("RolId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Rols");
                });

            modelBuilder.Entity("myfirstapi.Models.Seans", b =>
                {
                    b.HasOne("myfirstapi.Models.Salon", "Salons")
                        .WithMany()
                        .HasForeignKey("SalomId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Salons");
                });
#pragma warning restore 612, 618
        }
    }
}
