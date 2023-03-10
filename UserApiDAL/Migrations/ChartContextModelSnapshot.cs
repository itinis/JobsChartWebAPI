// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using UserApiDAL;

#nullable disable

namespace UserApiDAL.Migrations
{
    [DbContext(typeof(ChartContext))]
    partial class ChartContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.2");

            modelBuilder.Entity("UserApiDAL.ChartJobs", b =>
                {
                    b.Property<int>("chartJobId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("date")
                        .HasColumnType("TEXT");

                    b.Property<int>("jobsPerDay")
                        .HasColumnType("INTEGER");

                    b.Property<int>("jobsViews")
                        .HasColumnType("INTEGER");

                    b.Property<int>("predictedJobsViews")
                        .HasColumnType("INTEGER");

                    b.HasKey("chartJobId");

                    b.ToTable("chartJobs");
                });
#pragma warning restore 612, 618
        }
    }
}
