﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MyApp.Database;

#nullable disable

namespace MyApp.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20241221153243_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "9.0.0");

            modelBuilder.Entity("MyApp.Models.Theme", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Themes");
                });

            modelBuilder.Entity("MyApp.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("Username")
                        .IsUnique();

                    b.ToTable("Users");
                });

            modelBuilder.Entity("MyApp.Models.Word", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("EnglishWord")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ExampleSentence")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ExampleSentenceTranslation")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("ThemeId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Translation")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("ThemeId");

                    b.ToTable("Words");
                });

            modelBuilder.Entity("MyApp.Models.Word", b =>
                {
                    b.HasOne("MyApp.Models.Theme", "Theme")
                        .WithMany("Words")
                        .HasForeignKey("ThemeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Theme");
                });

            modelBuilder.Entity("MyApp.Models.Theme", b =>
                {
                    b.Navigation("Words");
                });
#pragma warning restore 612, 618
        }
    }
}
