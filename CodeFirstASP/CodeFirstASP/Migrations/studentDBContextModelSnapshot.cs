﻿// <auto-generated />
using CodeFirstASP.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CodeFirstASP.Migrations
{
    [DbContext(typeof(studentDBContext))]
    partial class studentDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CodeFirstASP.Models.student", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<int>("age")
                        .HasColumnType("int");

                    b.Property<string>("gender")
                        .IsRequired()
                        .HasColumnType("varchar(20)")
                        .HasColumnName("StudentGender");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("varchar(100)")
                        .HasColumnName("StudentName");

                    b.Property<int>("standard")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("students");
                });
#pragma warning restore 612, 618
        }
    }
}