using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using RoutingSample.Models;

namespace RoutingSample.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20170227_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.0-rtm-21431");

            modelBuilder.Entity("RoutingSample.Models.StoredValue", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Value");

                    b.HasKey("Id");

                    b.ToTable("StoredValues");
                });
        }
    }
}