﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PJ_webservice_CRUD.Models;

namespace PJ_webservice_CRUD.Migrations
{
    [DbContext(typeof(ProductContext))]
    partial class ProductContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.3-servicing-35854")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PJ_webservice_CRUD.Models.Category", b =>
                {
                    b.Property<string>("CategoryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("varchar(10)");

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.HasKey("CategoryID");

                    b.ToTable("Category");
                });

            modelBuilder.Entity("PJ_webservice_CRUD.Models.Product", b =>
                {
                    b.Property<string>("ProductID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("varchar(10)");

                    b.Property<int>("Amount");

                    b.Property<string>("CategoryID");

                    b.Property<string>("ImgURL");

                    b.Property<int>("Price");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.HasKey("ProductID");

                    b.HasIndex("CategoryID");

                    b.ToTable("Product");
                });

            modelBuilder.Entity("PJ_webservice_CRUD.Models.Product", b =>
                {
                    b.HasOne("PJ_webservice_CRUD.Models.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryID");
                });
#pragma warning restore 612, 618
        }
    }
}
