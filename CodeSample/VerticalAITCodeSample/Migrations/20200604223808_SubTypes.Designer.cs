﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using VerticalAITCodeSample;

namespace VerticalAITCodeSample.Migrations
{
    [DbContext(typeof(SiteContext))]
    [Migration("20200604223808_SubTypes")]
    partial class SubTypes
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("VerticalAITCodeSample.Models.Widget", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("WidgetName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("WidgetSubTypeId")
                        .HasColumnType("int");

                    b.Property<int>("WidgetTypeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("WidgetTypeId");

                    b.ToTable("Widgets");
                });

            modelBuilder.Entity("VerticalAITCodeSample.Models.WidgetSubType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("SubType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("WidgetTypeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("WidgetSubTypes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            SubType = "Apple",
                            WidgetTypeId = 1
                        },
                        new
                        {
                            Id = 2,
                            SubType = "Aardvark",
                            WidgetTypeId = 1
                        },
                        new
                        {
                            Id = 3,
                            SubType = "Astronaut",
                            WidgetTypeId = 1
                        },
                        new
                        {
                            Id = 4,
                            SubType = "Bear",
                            WidgetTypeId = 2
                        },
                        new
                        {
                            Id = 5,
                            SubType = "Bobcat",
                            WidgetTypeId = 2
                        },
                        new
                        {
                            Id = 6,
                            SubType = "Beaver",
                            WidgetTypeId = 2
                        },
                        new
                        {
                            Id = 7,
                            SubType = "First",
                            WidgetTypeId = 3
                        },
                        new
                        {
                            Id = 8,
                            SubType = "One",
                            WidgetTypeId = 3
                        },
                        new
                        {
                            Id = 9,
                            SubType = "Primary",
                            WidgetTypeId = 3
                        },
                        new
                        {
                            Id = 10,
                            SubType = "Uno",
                            WidgetTypeId = 3
                        },
                        new
                        {
                            Id = 11,
                            SubType = "Second",
                            WidgetTypeId = 4
                        },
                        new
                        {
                            Id = 12,
                            SubType = "Two",
                            WidgetTypeId = 4
                        },
                        new
                        {
                            Id = 13,
                            SubType = "Secondary",
                            WidgetTypeId = 4
                        },
                        new
                        {
                            Id = 14,
                            SubType = "Dos",
                            WidgetTypeId = 4
                        });
                });

            modelBuilder.Entity("VerticalAITCodeSample.Models.WidgetType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("WidgetTypes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Type = "A"
                        },
                        new
                        {
                            Id = 2,
                            Type = "B"
                        },
                        new
                        {
                            Id = 3,
                            Type = "1"
                        },
                        new
                        {
                            Id = 4,
                            Type = "2"
                        });
                });

            modelBuilder.Entity("VerticalAITCodeSample.Models.Widget", b =>
                {
                    b.HasOne("VerticalAITCodeSample.Models.WidgetType", null)
                        .WithMany("Widgets")
                        .HasForeignKey("WidgetTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
