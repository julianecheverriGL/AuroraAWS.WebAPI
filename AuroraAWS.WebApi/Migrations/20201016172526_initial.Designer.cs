﻿// <auto-generated />
using AuroraAWS.WebApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AuroraAWS.WebApi.Migrations
{
    [DbContext(typeof(MetaDataDBContext))]
    [Migration("20201016172526_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("AuroraAWS.WebApi.Models.Application", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ApplicationId")
                        .HasColumnType("int");

                    b.Property<byte>("ApplicationCode")
                        .HasColumnType("tinyint unsigned");

                    b.HasKey("Id");

                    b.ToTable("Applications");
                });

            modelBuilder.Entity("AuroraAWS.WebApi.Models.ExternalUserApplicationMap", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ExternalUserApplicationMapId")
                        .HasColumnType("int");

                    b.Property<int>("ApplicationId")
                        .HasColumnType("int");

                    b.Property<int>("ExternalUserMapId")
                        .HasColumnType("int");

                    b.Property<string>("MetaData")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.HasIndex("ApplicationId");

                    b.HasIndex("ExternalUserMapId");

                    b.ToTable("ExternalUsersApplicationMap");
                });

            modelBuilder.Entity("AuroraAWS.WebApi.Models.ExternalUserMap", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ExternalUserMapId")
                        .HasColumnType("int");

                    b.Property<int>("ExternalUserId")
                        .HasColumnType("int");

                    b.Property<byte>("ExternalUserType")
                        .HasColumnType("tinyint unsigned");

                    b.HasKey("Id");

                    b.ToTable("ExternalUsersMap");
                });

            modelBuilder.Entity("AuroraAWS.WebApi.Models.ExternalUserApplicationMap", b =>
                {
                    b.HasOne("AuroraAWS.WebApi.Models.Application", "Application")
                        .WithMany()
                        .HasForeignKey("ApplicationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AuroraAWS.WebApi.Models.ExternalUserMap", "ExternalUserMap")
                        .WithMany()
                        .HasForeignKey("ExternalUserMapId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
