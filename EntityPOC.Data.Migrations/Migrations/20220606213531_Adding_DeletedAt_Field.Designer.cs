﻿// <auto-generated />
using System;
using EntityPOC.Data.DatabaseContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EntityPOC.Data.Migrations
{
    [DbContext(typeof(KanbanDatabaseContext))]
    [Migration("20220606213531_Adding_DeletedAt_Field")]
    partial class Adding_DeletedAt_Field
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.17");

            modelBuilder.Entity("EntityPOC.Domain.Entities.Board", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Description")
                        .HasColumnType("longtext");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(95)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.HasIndex("Name");

                    b.ToTable("Boards");

                    b.HasData(
                        new
                        {
                            Id = 1500,
                            CreatedAt = new DateTime(2022, 6, 6, 21, 35, 30, 146, DateTimeKind.Utc).AddTicks(6910),
                            Description = "Default board created by data seeds",
                            Image = "https://docs.microsoft.com/en-us/ef/core/managing-schemas/migrations/projects?tabs=dotnet-core-cli",
                            Name = "Default - Board",
                            UpdatedAt = new DateTime(2022, 6, 6, 21, 35, 30, 146, DateTimeKind.Utc).AddTicks(7471)
                        });
                });

            modelBuilder.Entity("EntityPOC.Domain.Entities.BoardColumn", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("BoardId")
                        .HasColumnType("int");

                    b.Property<string>("Color")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Description")
                        .HasColumnType("longtext");

                    b.Property<string>("Header")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(95)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.HasIndex("BoardId");

                    b.HasIndex("Name");

                    b.ToTable("BoardColumns");

                    b.HasData(
                        new
                        {
                            Id = 1500,
                            BoardId = 1500,
                            Color = "Red",
                            CreatedAt = new DateTime(2022, 6, 6, 21, 35, 30, 149, DateTimeKind.Utc).AddTicks(1254),
                            Description = "Default backlog column",
                            Header = "Backlog",
                            Name = "To-Dos",
                            UpdatedAt = new DateTime(2022, 6, 6, 21, 35, 30, 149, DateTimeKind.Utc).AddTicks(1269)
                        },
                        new
                        {
                            Id = 1501,
                            BoardId = 1500,
                            Color = "Blue",
                            CreatedAt = new DateTime(2022, 6, 6, 21, 35, 30, 149, DateTimeKind.Utc).AddTicks(1592),
                            Description = "Default Current column",
                            Header = "Current",
                            Name = "Working on",
                            UpdatedAt = new DateTime(2022, 6, 6, 21, 35, 30, 149, DateTimeKind.Utc).AddTicks(1595)
                        },
                        new
                        {
                            Id = 1502,
                            BoardId = 1500,
                            Color = "Green",
                            CreatedAt = new DateTime(2022, 6, 6, 21, 35, 30, 149, DateTimeKind.Utc).AddTicks(1597),
                            Description = "Default Done column",
                            Header = "Done",
                            Name = "Completed",
                            UpdatedAt = new DateTime(2022, 6, 6, 21, 35, 30, 149, DateTimeKind.Utc).AddTicks(1598)
                        });
                });

            modelBuilder.Entity("EntityPOC.Domain.Entities.Card", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Attachment")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("BoardColumnId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Description")
                        .HasColumnType("longtext");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(95)");

                    b.Property<string>("Owner")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.HasIndex("BoardColumnId");

                    b.HasIndex("Name");

                    b.ToTable("Cards");

                    b.HasData(
                        new
                        {
                            Id = 1000,
                            Attachment = "https://futbollibre.net/inicio/?tv",
                            BoardColumnId = 1500,
                            CreatedAt = new DateTime(2022, 6, 6, 21, 35, 30, 149, DateTimeKind.Utc).AddTicks(9937),
                            Description = "Test Description",
                            Image = "https://futbollibre.net/inicio/?tv",
                            Name = "Backog card 1",
                            Owner = "Reynaldo",
                            UpdatedAt = new DateTime(2022, 6, 6, 21, 35, 30, 149, DateTimeKind.Utc).AddTicks(9937)
                        },
                        new
                        {
                            Id = 1001,
                            Attachment = "https://futbollibre.net/inicio/?tv",
                            BoardColumnId = 1500,
                            CreatedAt = new DateTime(2022, 6, 6, 21, 35, 30, 149, DateTimeKind.Utc).AddTicks(9937),
                            Description = "Test Description 2",
                            Image = "https://futbollibre.net/inicio/?tv",
                            Name = "Backog card 2",
                            Owner = "Reynaldo",
                            UpdatedAt = new DateTime(2022, 6, 6, 21, 35, 30, 149, DateTimeKind.Utc).AddTicks(9937)
                        },
                        new
                        {
                            Id = 1002,
                            Attachment = "https://futbollibre.net/inicio/?tv",
                            BoardColumnId = 1500,
                            CreatedAt = new DateTime(2022, 6, 6, 21, 35, 30, 149, DateTimeKind.Utc).AddTicks(9937),
                            Description = "Test Description 3",
                            Image = "https://futbollibre.net/inicio/?tv",
                            Name = "Backog card 3",
                            Owner = "Reynaldo",
                            UpdatedAt = new DateTime(2022, 6, 6, 21, 35, 30, 149, DateTimeKind.Utc).AddTicks(9937)
                        },
                        new
                        {
                            Id = 1003,
                            Attachment = "https://futbollibre.net/inicio/?tv",
                            BoardColumnId = 1501,
                            CreatedAt = new DateTime(2022, 6, 6, 21, 35, 30, 149, DateTimeKind.Utc).AddTicks(9937),
                            Description = "Test Description for Current",
                            Image = "https://futbollibre.net/inicio/?tv",
                            Name = "Current card 1",
                            Owner = "Reynaldo",
                            UpdatedAt = new DateTime(2022, 6, 6, 21, 35, 30, 149, DateTimeKind.Utc).AddTicks(9937)
                        },
                        new
                        {
                            Id = 1004,
                            Attachment = "https://futbollibre.net/inicio/?tv",
                            BoardColumnId = 1501,
                            CreatedAt = new DateTime(2022, 6, 6, 21, 35, 30, 149, DateTimeKind.Utc).AddTicks(9937),
                            Description = "Test Description for Current 2",
                            Image = "https://futbollibre.net/inicio/?tv",
                            Name = "Current card 2",
                            Owner = "Reynaldo",
                            UpdatedAt = new DateTime(2022, 6, 6, 21, 35, 30, 149, DateTimeKind.Utc).AddTicks(9937)
                        },
                        new
                        {
                            Id = 1005,
                            Attachment = "https://futbollibre.net/inicio/?tv",
                            BoardColumnId = 1501,
                            CreatedAt = new DateTime(2022, 6, 6, 21, 35, 30, 149, DateTimeKind.Utc).AddTicks(9937),
                            Description = "Test Description for Current 3",
                            Image = "https://futbollibre.net/inicio/?tv",
                            Name = "Current card 3",
                            Owner = "Reynaldo",
                            UpdatedAt = new DateTime(2022, 6, 6, 21, 35, 30, 149, DateTimeKind.Utc).AddTicks(9937)
                        },
                        new
                        {
                            Id = 1006,
                            Attachment = "https://futbollibre.net/inicio/?tv",
                            BoardColumnId = 1502,
                            CreatedAt = new DateTime(2022, 6, 6, 21, 35, 30, 149, DateTimeKind.Utc).AddTicks(9937),
                            Description = "Test Description for Done",
                            Image = "https://futbollibre.net/inicio/?tv",
                            Name = "Done card 1",
                            Owner = "Reynaldo",
                            UpdatedAt = new DateTime(2022, 6, 6, 21, 35, 30, 149, DateTimeKind.Utc).AddTicks(9937)
                        },
                        new
                        {
                            Id = 1007,
                            Attachment = "https://futbollibre.net/inicio/?tv",
                            BoardColumnId = 1502,
                            CreatedAt = new DateTime(2022, 6, 6, 21, 35, 30, 149, DateTimeKind.Utc).AddTicks(9937),
                            Description = "Test Description for Done 2",
                            Image = "https://futbollibre.net/inicio/?tv",
                            Name = "Done card 2",
                            Owner = "Reynaldo",
                            UpdatedAt = new DateTime(2022, 6, 6, 21, 35, 30, 149, DateTimeKind.Utc).AddTicks(9937)
                        },
                        new
                        {
                            Id = 1008,
                            Attachment = "https://futbollibre.net/inicio/?tv",
                            BoardColumnId = 1502,
                            CreatedAt = new DateTime(2022, 6, 6, 21, 35, 30, 149, DateTimeKind.Utc).AddTicks(9937),
                            Description = "Test Description for Done 3",
                            Image = "https://futbollibre.net/inicio/?tv",
                            Name = "Done card 3",
                            Owner = "Reynaldo",
                            UpdatedAt = new DateTime(2022, 6, 6, 21, 35, 30, 149, DateTimeKind.Utc).AddTicks(9937)
                        });
                });

            modelBuilder.Entity("EntityPOC.Domain.Entities.BoardColumn", b =>
                {
                    b.HasOne("EntityPOC.Domain.Entities.Board", "Board")
                        .WithMany("BoardColumns")
                        .HasForeignKey("BoardId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Board");
                });

            modelBuilder.Entity("EntityPOC.Domain.Entities.Card", b =>
                {
                    b.HasOne("EntityPOC.Domain.Entities.BoardColumn", "BoardColumn")
                        .WithMany("Cards")
                        .HasForeignKey("BoardColumnId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BoardColumn");
                });

            modelBuilder.Entity("EntityPOC.Domain.Entities.Board", b =>
                {
                    b.Navigation("BoardColumns");
                });

            modelBuilder.Entity("EntityPOC.Domain.Entities.BoardColumn", b =>
                {
                    b.Navigation("Cards");
                });
#pragma warning restore 612, 618
        }
    }
}
