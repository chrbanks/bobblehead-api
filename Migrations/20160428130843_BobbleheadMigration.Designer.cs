using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Infrastructure;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations;
using BobbleheadApi.Models;

namespace BobbleheadApi.Migrations
{
    [DbContext(typeof(BobbleheadContext))]
    [Migration("20160428130843_BobbleheadMigration")]
    partial class BobbleheadMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0-rc1-16348");

            modelBuilder.Entity("BobbleheadApi.Models.Bobblehead", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Owner");

                    b.Property<DateTime>("StartDate");

                    b.Property<DateTime>("Timestamp");

                    b.Property<string>("Type");

                    b.HasKey("Id");
                });
        }
    }
}
