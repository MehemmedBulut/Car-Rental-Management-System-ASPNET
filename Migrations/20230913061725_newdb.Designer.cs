﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RentalFinal.DAL;

namespace RentalFinal.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230913061725_newdb")]
    partial class newdb
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("RentalFinal.Models.Brand", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("İsDeactive")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Brands");
                });

            modelBuilder.Entity("RentalFinal.Models.Car", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BrandId")
                        .HasColumnType("int");

                    b.Property<string>("Color")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("DailyPrice")
                        .HasColumnType("real");

                    b.Property<int>("FuelId")
                        .HasColumnType("int");

                    b.Property<int>("PassYear")
                        .HasColumnType("int");

                    b.Property<int>("TransmissionId")
                        .HasColumnType("int");

                    b.Property<int>("TypeId")
                        .HasColumnType("int");

                    b.Property<bool>("İsDeactive")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("BrandId");

                    b.HasIndex("FuelId");

                    b.HasIndex("TransmissionId");

                    b.HasIndex("TypeId");

                    b.ToTable("Cars");
                });

            modelBuilder.Entity("RentalFinal.Models.Ctype", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BrandId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("İsDeactive")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("BrandId");

                    b.ToTable("Types");
                });

            modelBuilder.Entity("RentalFinal.Models.Fuel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Fuels");
                });

            modelBuilder.Entity("RentalFinal.Models.Transmission", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Transmissions");
                });

            modelBuilder.Entity("RentalFinal.Models.Car", b =>
                {
                    b.HasOne("RentalFinal.Models.Brand", "Brand")
                        .WithMany("Cars")
                        .HasForeignKey("BrandId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RentalFinal.Models.Fuel", "Fuel")
                        .WithMany("Cars")
                        .HasForeignKey("FuelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RentalFinal.Models.Transmission", "Transmission")
                        .WithMany("Cars")
                        .HasForeignKey("TransmissionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RentalFinal.Models.Ctype", "Type")
                        .WithMany("Cars")
                        .HasForeignKey("TypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Brand");

                    b.Navigation("Fuel");

                    b.Navigation("Transmission");

                    b.Navigation("Type");
                });

            modelBuilder.Entity("RentalFinal.Models.Ctype", b =>
                {
                    b.HasOne("RentalFinal.Models.Brand", "Brand")
                        .WithMany("Types")
                        .HasForeignKey("BrandId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Brand");
                });

            modelBuilder.Entity("RentalFinal.Models.Brand", b =>
                {
                    b.Navigation("Cars");

                    b.Navigation("Types");
                });

            modelBuilder.Entity("RentalFinal.Models.Ctype", b =>
                {
                    b.Navigation("Cars");
                });

            modelBuilder.Entity("RentalFinal.Models.Fuel", b =>
                {
                    b.Navigation("Cars");
                });

            modelBuilder.Entity("RentalFinal.Models.Transmission", b =>
                {
                    b.Navigation("Cars");
                });
#pragma warning restore 612, 618
        }
    }
}
