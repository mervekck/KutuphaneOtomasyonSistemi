﻿// <auto-generated />
using System;
using LAS.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LAS.Context.Migrations
{
    [DbContext(typeof(LasDbContext))]
    partial class LasDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.17")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("LAS.Model.Entities.Abstract.Kitap", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Baslik")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Durum")
                        .HasColumnType("int");

                    b.Property<int>("ISBN")
                        .HasColumnType("int");

                    b.Property<int?>("KutuphaneID")
                        .HasColumnType("int");

                    b.Property<int?>("UyeID")
                        .HasColumnType("int");

                    b.Property<DateTime>("YayinYili")
                        .HasColumnType("datetime2");

                    b.Property<int>("YazarID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("KutuphaneID");

                    b.HasIndex("UyeID");

                    b.HasIndex("YazarID");

                    b.ToTable("Kitap");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Kitap");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("LAS.Model.Entities.Abstract.Yazar", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Adi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Yazar");
                });

            modelBuilder.Entity("LAS.Model.Entities.Concrete.Kutuphane", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.HasKey("ID");

                    b.ToTable("Kutuphaneler");
                });

            modelBuilder.Entity("LAS.Model.Entities.Concrete.Uye", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Ad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("KutuphaneID")
                        .HasColumnType("int");

                    b.Property<string>("Soyad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UyeNumarasi")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("KutuphaneID");

                    b.ToTable("Uyeler");
                });

            modelBuilder.Entity("LAS.Model.Entities.Concrete.Kitap.Bilim", b =>
                {
                    b.HasBaseType("LAS.Model.Entities.Abstract.Kitap");

                    b.HasDiscriminator().HasValue("Bilim");
                });

            modelBuilder.Entity("LAS.Model.Entities.Concrete.Kitap.Roman", b =>
                {
                    b.HasBaseType("LAS.Model.Entities.Abstract.Kitap");

                    b.HasDiscriminator().HasValue("Roman");
                });

            modelBuilder.Entity("LAS.Model.Entities.Concrete.Kitap.Tarih", b =>
                {
                    b.HasBaseType("LAS.Model.Entities.Abstract.Kitap");

                    b.HasDiscriminator().HasValue("Tarih");
                });

            modelBuilder.Entity("LAS.Model.Entities.Abstract.Kitap", b =>
                {
                    b.HasOne("LAS.Model.Entities.Concrete.Kutuphane", null)
                        .WithMany("Kitaplar")
                        .HasForeignKey("KutuphaneID");

                    b.HasOne("LAS.Model.Entities.Concrete.Uye", null)
                        .WithMany("OduncAlinanKitaplar")
                        .HasForeignKey("UyeID");

                    b.HasOne("LAS.Model.Entities.Abstract.Yazar", "Yazar")
                        .WithMany()
                        .HasForeignKey("YazarID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Yazar");
                });

            modelBuilder.Entity("LAS.Model.Entities.Concrete.Uye", b =>
                {
                    b.HasOne("LAS.Model.Entities.Concrete.Kutuphane", null)
                        .WithMany("Uyeler")
                        .HasForeignKey("KutuphaneID");
                });

            modelBuilder.Entity("LAS.Model.Entities.Concrete.Kutuphane", b =>
                {
                    b.Navigation("Kitaplar");

                    b.Navigation("Uyeler");
                });

            modelBuilder.Entity("LAS.Model.Entities.Concrete.Uye", b =>
                {
                    b.Navigation("OduncAlinanKitaplar");
                });
#pragma warning restore 612, 618
        }
    }
}
