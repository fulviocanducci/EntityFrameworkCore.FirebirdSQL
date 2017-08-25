﻿// <auto-generated />
using EFCore.FirebirdSqlSQL.Test;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace EFCore.FirebirdSQL.Test.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20170825163632_AlterColumnName")]
    partial class AlterColumnName
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("FirebirdSql:ValueGenerationStrategy", FirebirdSqlValueGenerationStrategy.IdentityColumn)
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452");

            modelBuilder.Entity("EFCore.FirebirdSqlSQL.Test.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<bool>("Locked");

                    b.Property<string>("Name")
                        .HasMaxLength(150);

                    b.Property<decimal>("Price");

                    b.Property<double>("Quant");

                    b.Property<DateTime>("Update");

                    b.HasKey("Id");

                    b.HasIndex("Id")
                        .HasName("Id");

                    b.ToTable("Products");
                });
#pragma warning restore 612, 618
        }
    }
}