﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;
using Yvadev.Domain.Entities;
using Yvadev.Infrastructure.EF.Contexts;

namespace Yvadev.Infrastructure.EF.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20180330183148_AddUserEntity")]
    partial class AddUserEntity
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Yvadev.Domain.Entities.Category", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreationDate");

                    b.Property<DateTime>("ModificationDate");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Category");
                });

            modelBuilder.Entity("Yvadev.Domain.Entities.Post", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<long?>("AuthorId");

                    b.Property<string>("Content");

                    b.Property<DateTime>("CreationDate");

                    b.Property<int>("IsPublished");

                    b.Property<DateTime>("ModificationDate");

                    b.Property<DateTime>("PublicationDate");

                    b.Property<long?>("SeoId");

                    b.Property<string>("Tags");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.HasIndex("SeoId");

                    b.ToTable("Post");
                });

            modelBuilder.Entity("Yvadev.Domain.Entities.SEO", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreationDate");

                    b.Property<string>("MetaDescription");

                    b.Property<string>("MetaTitle");

                    b.Property<DateTime>("ModificationDate");

                    b.HasKey("Id");

                    b.ToTable("SEO");
                });

            modelBuilder.Entity("Yvadev.Domain.Entities.User", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address");

                    b.Property<DateTime>("CreationDate");

                    b.Property<string>("Email");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<DateTime>("ModificationDate");

                    b.Property<string>("PhoneNumber");

                    b.Property<string>("PostalCode");

                    b.Property<string>("UserName");

                    b.Property<string>("UserNameId");

                    b.HasKey("Id");

                    b.HasIndex("UserName")
                        .IsUnique()
                        .HasFilter("[UserName] IS NOT NULL");

                    b.HasIndex("UserNameId")
                        .IsUnique()
                        .HasFilter("[UserNameId] IS NOT NULL");

                    b.ToTable("User");
                });

            modelBuilder.Entity("Yvadev.Domain.Entities.Post", b =>
                {
                    b.HasOne("Yvadev.Domain.Entities.User", "Author")
                        .WithMany()
                        .HasForeignKey("AuthorId");

                    b.HasOne("Yvadev.Domain.Entities.SEO", "Seo")
                        .WithMany()
                        .HasForeignKey("SeoId");
                });
#pragma warning restore 612, 618
        }
    }
}
