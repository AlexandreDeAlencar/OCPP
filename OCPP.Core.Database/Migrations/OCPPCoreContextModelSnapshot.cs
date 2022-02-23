﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using OCPP.Core.Database;

namespace OCPP.Core.Database.Migrations
{
    [DbContext(typeof(OCPPCoreContext))]
    partial class OCPPCoreContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("public")
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("OCPP.Core.Database.ChargePoint", b =>
                {
                    b.Property<string>("ChargePointId")
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<string>("ClientCertThumb")
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<string>("Comment")
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)");

                    b.Property<string>("Name")
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<string>("Password")
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<string>("Username")
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.HasKey("ChargePointId");

                    b.HasIndex(new[] { "ChargePointId" }, "ChargePoint_Identifier")
                        .IsUnique();

                    b.ToTable("ChargePoint");
                });

            modelBuilder.Entity("OCPP.Core.Database.ChargeTag", b =>
                {
                    b.Property<string>("TagId")
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<bool?>("Blocked")
                        .HasColumnType("boolean");

                    b.Property<DateTime?>("ExpiryDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("ParentTagId")
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<string>("TagName")
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)");

                    b.HasKey("TagId")
                        .HasName("PK_ChargeKeys");

                    b.ToTable("ChargeTags");
                });

            modelBuilder.Entity("OCPP.Core.Database.ConnectorStatus", b =>
                {
                    b.Property<string>("ChargePointId")
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<int>("ConnectorId")
                        .HasColumnType("integer");

                    b.Property<string>("ConnectorName")
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<double?>("LastMeter")
                        .HasColumnType("double precision");

                    b.Property<DateTime?>("LastMeterTime")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("LastStatus")
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<DateTime?>("LastStatusTime")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("ChargePointId", "ConnectorId");

                    b.ToTable("ConnectorStatus");
                });

            modelBuilder.Entity("OCPP.Core.Database.ConnectorStatusView", b =>
                {
                    b.Property<string>("ChargePointId")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<int>("ConnectorId")
                        .HasColumnType("integer");

                    b.Property<string>("ConnectorName")
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<double?>("LastMeter")
                        .HasColumnType("double precision");

                    b.Property<DateTime?>("LastMeterTime")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("LastStatus")
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<DateTime?>("LastStatusTime")
                        .HasColumnType("timestamp without time zone");

                    b.Property<double?>("MeterStart")
                        .HasColumnType("double precision");

                    b.Property<double?>("MeterStop")
                        .HasColumnType("double precision");

                    b.Property<string>("StartResult")
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<string>("StartTagId")
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<DateTime?>("StartTime")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("StopReason")
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<string>("StopTagId")
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<DateTime?>("StopTime")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int?>("TransactionId")
                        .HasColumnType("integer");

                    b.ToView("ConnectorStatusView");
                });

            modelBuilder.Entity("OCPP.Core.Database.MessageLog", b =>
                {
                    b.Property<int>("LogId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("ChargePointId")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<int?>("ConnectorId")
                        .HasColumnType("integer");

                    b.Property<string>("ErrorCode")
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<DateTime>("LogTime")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Message")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<string>("Result")
                        .HasColumnType("text");

                    b.HasKey("LogId");

                    b.HasIndex(new[] { "LogTime" }, "IX_MessageLog_ChargePointId");

                    b.ToTable("MessageLog");
                });

            modelBuilder.Entity("OCPP.Core.Database.Transaction", b =>
                {
                    b.Property<int>("TransactionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("ChargePointId")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<int>("ConnectorId")
                        .HasColumnType("integer");

                    b.Property<double>("MeterStart")
                        .HasColumnType("double precision");

                    b.Property<double?>("MeterStop")
                        .HasColumnType("double precision");

                    b.Property<string>("StartResult")
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<string>("StartTagId")
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("StopReason")
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<string>("StopTagId")
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<DateTime?>("StopTime")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Uid")
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.HasKey("TransactionId");

                    b.HasIndex("ChargePointId");

                    b.ToTable("Transactions");
                });

            modelBuilder.Entity("OCPP.Core.Database.Transaction", b =>
                {
                    b.HasOne("OCPP.Core.Database.ChargePoint", "ChargePoint")
                        .WithMany("Transactions")
                        .HasForeignKey("ChargePointId")
                        .HasConstraintName("FK_Transactions_ChargePoint")
                        .IsRequired();

                    b.Navigation("ChargePoint");
                });

            modelBuilder.Entity("OCPP.Core.Database.ChargePoint", b =>
                {
                    b.Navigation("Transactions");
                });
#pragma warning restore 612, 618
        }
    }
}
