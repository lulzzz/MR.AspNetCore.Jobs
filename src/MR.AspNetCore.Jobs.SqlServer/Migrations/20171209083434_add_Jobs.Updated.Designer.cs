﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using MR.AspNetCore.Jobs.Models;
using System;

namespace MR.AspNetCore.Jobs.SqlServer.Migrations
{
    [DbContext(typeof(JobsDbContext))]
    [Migration("20171209083434_add_Jobs.Updated")]
    partial class add_JobsUpdated
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("Jobs")
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MR.AspNetCore.Jobs.Models.CronJob", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Cron");

                    b.Property<DateTime>("LastRun");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<string>("TypeName");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("CronJobs");
                });

            modelBuilder.Entity("MR.AspNetCore.Jobs.Models.Job", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Added");

                    b.Property<string>("Data");

                    b.Property<DateTime?>("Due");

                    b.Property<DateTime?>("ExpiresAt");

                    b.Property<int>("Retries");

                    b.Property<string>("StateName")
                        .IsRequired();

                    b.Property<DateTime?>("Updated");

                    b.HasKey("Id");

                    b.HasIndex("Added");

                    b.HasIndex("StateName");

                    b.HasIndex("Updated");

                    b.HasIndex("Due", "StateName");

                    b.ToTable("Jobs");
                });

            modelBuilder.Entity("MR.AspNetCore.Jobs.Models.JobQueue", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("JobId");

                    b.HasKey("Id");

                    b.HasIndex("JobId");

                    b.ToTable("JobQueue");
                });

            modelBuilder.Entity("MR.AspNetCore.Jobs.Models.JobQueue", b =>
                {
                    b.HasOne("MR.AspNetCore.Jobs.Models.Job", "Job")
                        .WithMany()
                        .HasForeignKey("JobId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
