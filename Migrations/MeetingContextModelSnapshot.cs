﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SacramentPlanner.Data;

namespace SacramentPlanner.Migrations
{
    [DbContext(typeof(MeetingContext))]
    partial class MeetingContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SacramentPlanner.Models.Assignment", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("SpeakerID");

                    b.Property<DateTime>("SpeechDate");

                    b.Property<int>("TopicID");

                    b.HasKey("ID");

                    b.HasIndex("SpeakerID");

                    b.HasIndex("TopicID");

                    b.ToTable("Assignment");
                });

            modelBuilder.Entity("SacramentPlanner.Models.Speaker", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(60);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(60);

                    b.HasKey("ID");

                    b.ToTable("Speaker");
                });

            modelBuilder.Entity("SacramentPlanner.Models.Topic", b =>
                {
                    b.Property<int>("TopicID");

                    b.Property<string>("Subject");

                    b.HasKey("TopicID");

                    b.ToTable("Topic");
                });

            modelBuilder.Entity("SacramentPlanner.Models.Assignment", b =>
                {
                    b.HasOne("SacramentPlanner.Models.Speaker", "Speaker")
                        .WithMany("Assignments")
                        .HasForeignKey("SpeakerID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SacramentPlanner.Models.Topic", "Topic")
                        .WithMany("Assignments")
                        .HasForeignKey("TopicID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
