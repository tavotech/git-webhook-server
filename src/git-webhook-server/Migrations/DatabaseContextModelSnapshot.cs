﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using git_webhook_server.Models;

namespace git_webhook_server.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    partial class DatabaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("git_webhook_server.Models.EventLog", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("EventReceivedOn")
                        .HasColumnType("TEXT");

                    b.Property<string>("ExecutionResult")
                        .HasColumnType("TEXT");

                    b.Property<string>("Headers")
                        .HasColumnType("TEXT");

                    b.Property<string>("MatchedRule")
                        .HasColumnType("TEXT");

                    b.Property<string>("Payload")
                        .HasColumnType("TEXT");

                    b.Property<string>("StatusMessage")
                        .HasColumnType("TEXT");

                    b.Property<bool?>("Succeeded")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("EventLogs");
                });

            modelBuilder.Entity("git_webhook_server.Models.ExecutionRequest", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Command")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("EventLogId")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("ProcessedOn")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("StartedOn")
                        .HasColumnType("TEXT");

                    b.Property<int>("Status")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("EventLogId")
                        .IsUnique();

                    b.ToTable("ExecutionRequests");
                });

            modelBuilder.Entity("git_webhook_server.Models.ExecutionRequest", b =>
                {
                    b.HasOne("git_webhook_server.Models.EventLog", "EventLog")
                        .WithOne("ExecutionRequest")
                        .HasForeignKey("git_webhook_server.Models.ExecutionRequest", "EventLogId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("EventLog");
                });

            modelBuilder.Entity("git_webhook_server.Models.EventLog", b =>
                {
                    b.Navigation("ExecutionRequest");
                });
#pragma warning restore 612, 618
        }
    }
}
