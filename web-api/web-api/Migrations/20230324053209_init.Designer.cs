﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using web_api.EFs;

#nullable disable

namespace web_api.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20230324053209_init")]
    partial class init
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("web_api.Entities.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("user_id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("UserId"));

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasColumnName("user_name");

                    b.HasKey("UserId");

                    b.ToTable("users");

                    b.HasData(
                        new
                        {
                            UserId = 1,
                            UserName = "chin"
                        },
                        new
                        {
                            UserId = 2,
                            UserName = "reset"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}