﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace TradeLens.Server.Migrations
{
    [DbContext(typeof(TradeLensDbContext))]
    [Migration("20250104023224_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Trade", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CloseDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("Currency")
                        .HasColumnType("integer");

                    b.Property<bool?>("DailyBreakAndRetest")
                        .HasColumnType("boolean");

                    b.Property<int>("DailyConfirmation")
                        .HasColumnType("integer");

                    b.Property<string>("DailyImage")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool?>("DailyNewActionFakeout")
                        .HasColumnType("boolean");

                    b.Property<bool?>("DailySupplyAndDemand")
                        .HasColumnType("boolean");

                    b.Property<DateTime>("EntryDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("H4Confirmation")
                        .HasColumnType("integer");

                    b.Property<string>("H4Image")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("Missed")
                        .HasColumnType("boolean");

                    b.Property<string>("Note")
                        .HasColumnType("text");

                    b.Property<int?>("Result")
                        .HasColumnType("integer");

                    b.Property<double>("RiskReward")
                        .HasColumnType("double precision");

                    b.Property<int>("Type")
                        .HasColumnType("integer");

                    b.Property<bool>("WeeklyCandleClose")
                        .HasColumnType("boolean");

                    b.Property<bool?>("WeeklyFibCompletion")
                        .HasColumnType("boolean");

                    b.Property<bool>("WeeklyFibonacci")
                        .HasColumnType("boolean");

                    b.Property<bool?>("WeeklyHighLow")
                        .HasColumnType("boolean");

                    b.Property<bool?>("WeeklyIC")
                        .HasColumnType("boolean");

                    b.Property<string>("WeeklyImage")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("WeeklyMarketStructure")
                        .HasColumnType("boolean");

                    b.Property<bool?>("WeeklyPattern")
                        .HasColumnType("boolean");

                    b.Property<bool>("WeeklySupplyAndDemand")
                        .HasColumnType("boolean");

                    b.HasKey("Id");

                    b.ToTable("Trades");
                });
#pragma warning restore 612, 618
        }
    }
}