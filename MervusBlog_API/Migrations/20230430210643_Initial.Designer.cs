﻿// <auto-generated />
using System;
using MervusBlog_API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace MervusBlog_API.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230430210643_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("MervusBlog_API.Models.Author", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("IsActive")
                        .HasColumnType("boolean");

                    b.Property<string>("Mobile")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("NickName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Profile")
                        .HasColumnType("text");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.ToTable("Authors");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "admin@alikaanturkmen.com",
                            IsActive = true,
                            Mobile = "+905542985313",
                            NickName = "Kaan",
                            Profile = "Engineer",
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 2,
                            Email = "admin@merveturkmen.com",
                            IsActive = true,
                            Mobile = "+905542985313",
                            NickName = "Mervus",
                            Profile = "Manager",
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("MervusBlog_API.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Context")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("IsActive")
                        .HasColumnType("boolean");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Context = "This category includes posts about science",
                            IsActive = true,
                            Title = "Science"
                        },
                        new
                        {
                            Id = 2,
                            Context = "This category includes posts about politics",
                            IsActive = true,
                            Title = "Politics"
                        },
                        new
                        {
                            Id = 3,
                            Context = "This category includes posts about Movies",
                            IsActive = true,
                            Title = "Movies"
                        });
                });

            modelBuilder.Entity("MervusBlog_API.Models.Post", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("AuthorId")
                        .HasColumnType("integer");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("IsActive")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsPublished")
                        .HasColumnType("boolean");

                    b.Property<DateTime>("PublishedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Summary")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.ToTable("Posts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AuthorId = 1,
                            Content = "Quantum physics is the study of the behavior of matter and energy at the subatomic level. It is a field that explores the strange and fascinating world of particles, waves, and probabilities. In this world, particles can exist in multiple places at once, and their behavior is influenced by the act of observation.\n\nOne of the most significant concepts in quantum physics is superposition, which describes how particles can exist in multiple states simultaneously. This phenomenon is demonstrated by the famous Schrödinger's cat thought experiment, which explores the idea of a cat being in a state of being both alive and dead at the same time.\n\nAnother crucial concept is entanglement, where particles become connected in such a way that the state of one particle is dependent on the state of the other, regardless of the distance between them. This phenomenon has the potential to revolutionize the way we communicate and process information.\n\nQuantum physics is a fascinating and rapidly evolving field that continues to challenge our understanding of the universe. Its applications have the potential to revolutionize the world of computing, communication, and energy.",
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsActive = true,
                            IsPublished = true,
                            PublishedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Summary = "This blog post is an introduction to the world of quantum physics, which explores the behavior of matter and energy at the subatomic level. The post discusses two of the most significant concepts in quantum physics: superposition and entanglement. It also highlights the potential applications of quantum physics, including revolutionizing the way we communicate, process information, and harness energy. The post concludes by emphasizing the importance of quantum physics in challenging our understanding of the universe and unlocking its mysteries. The title \"Exploring the Strange and Fascinating World of Quantum Physics\" captures the essence of the blog post, which aims to provide a brief yet engaging overview of this exciting field.",
                            Title = "Exploring the Strange and Fascinating World of Quantum Physics",
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("MervusBlog_API.Models.PostCategory", b =>
                {
                    b.Property<int>("CategoryId")
                        .HasColumnType("integer");

                    b.Property<int>("PostId")
                        .HasColumnType("integer");

                    b.ToTable("PostCategories");
                });

            modelBuilder.Entity("MervusBlog_API.Models.PostComment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("IsActive")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsPublished")
                        .HasColumnType("boolean");

                    b.Property<int>("PostId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("PublishedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("PostComments");
                });

            modelBuilder.Entity("MervusBlog_API.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("IsActive")
                        .HasColumnType("boolean");

                    b.Property<DateTime?>("LastLogin")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("MiddleName")
                        .HasColumnType("text");

                    b.Property<string>("Mobile")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Profile")
                        .HasColumnType("text");

                    b.Property<DateTime>("RegisteredDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "admin@merveturkmen.com",
                            FirstName = "Merve",
                            IsActive = true,
                            LastName = "TURKMEN",
                            Mobile = "+905063694208",
                            Password = "admin",
                            RegisteredDate = new DateTime(2023, 4, 30, 21, 6, 43, 205, DateTimeKind.Utc).AddTicks(5550),
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 2,
                            Email = "admin@alikaanturkmen.com",
                            FirstName = "Ali",
                            IsActive = true,
                            LastName = "TURKMEN",
                            MiddleName = "Kaan",
                            Mobile = "+905542985313",
                            Password = "admin",
                            RegisteredDate = new DateTime(2023, 4, 30, 21, 6, 43, 205, DateTimeKind.Utc).AddTicks(5570),
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
