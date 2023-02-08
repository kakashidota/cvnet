﻿// <auto-generated />
using System;
using CVNET.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CVNET.Migrations
{
    [DbContext(typeof(MeDbContext))]
    partial class MeDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.2");

            modelBuilder.Entity("CVNET.Models.Education", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Degree")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("GraduationYear")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Institution")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int?>("MeId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("MeId");

                    b.ToTable("Education");
                });

            modelBuilder.Entity("CVNET.Models.Me", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("_robin");
                });

            modelBuilder.Entity("CVNET.Models.Skills", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Level")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("MeId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("SkillName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("MeId");

                    b.ToTable("Skills");
                });

            modelBuilder.Entity("CVNET.Models.WorkExperience", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Company")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Duration")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int?>("MeId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Responsibilities")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("MeId");

                    b.ToTable("WorkExperience");
                });

            modelBuilder.Entity("CVNET.Models.Education", b =>
                {
                    b.HasOne("CVNET.Models.Me", null)
                        .WithMany("Education")
                        .HasForeignKey("MeId");
                });

            modelBuilder.Entity("CVNET.Models.Skills", b =>
                {
                    b.HasOne("CVNET.Models.Me", null)
                        .WithMany("Skills")
                        .HasForeignKey("MeId");
                });

            modelBuilder.Entity("CVNET.Models.WorkExperience", b =>
                {
                    b.HasOne("CVNET.Models.Me", null)
                        .WithMany("WorkExperience")
                        .HasForeignKey("MeId");
                });

            modelBuilder.Entity("CVNET.Models.Me", b =>
                {
                    b.Navigation("Education");

                    b.Navigation("Skills");

                    b.Navigation("WorkExperience");
                });
#pragma warning restore 612, 618
        }
    }
}
