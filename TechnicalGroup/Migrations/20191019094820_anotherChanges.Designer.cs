﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TechnicalGroup.Data;

namespace TechnicalGroup.Migrations
{
    [DbContext(typeof(TechnicalGroupDbContext))]
    [Migration("20191019094820_anotherChanges")]
    partial class anotherChanges
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TechnicalGroup.Areas.TechnicalGroupAdmin.Models.Admin", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Password");

                    b.Property<string>("Roles");

                    b.Property<string>("UserName");

                    b.HasKey("ID");

                    b.ToTable("Admin");
                });

            modelBuilder.Entity("TechnicalGroup.Models.AboutItems", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Content")
                        .IsRequired();

                    b.Property<string>("Content_Az")
                        .IsRequired();

                    b.Property<string>("Content_Ru")
                        .IsRequired();

                    b.Property<string>("Title")
                        .IsRequired();

                    b.Property<string>("Title_Az")
                        .IsRequired();

                    b.Property<string>("Title_Ru")
                        .IsRequired();

                    b.HasKey("ID");

                    b.ToTable("AboutItems");
                });

            modelBuilder.Entity("TechnicalGroup.Models.Comments", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("OwnerEmail");

                    b.Property<string>("OwnerFullname");

                    b.Property<int>("PostID");

                    b.Property<string>("Text")
                        .HasColumnType("ntext");

                    b.HasKey("ID");

                    b.HasIndex("PostID");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("TechnicalGroup.Models.Facts", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Key");

                    b.Property<string>("Value")
                        .IsRequired();

                    b.Property<string>("Value_Az");

                    b.Property<string>("Value_Ru");

                    b.HasKey("ID");

                    b.ToTable("Facts");
                });

            modelBuilder.Entity("TechnicalGroup.Models.HomeAboutItems", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Item");

                    b.Property<string>("Item_Az");

                    b.Property<string>("Item_Ru");

                    b.HasKey("ID");

                    b.ToTable("HomeAboutItems");
                });

            modelBuilder.Entity("TechnicalGroup.Models.Post", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedDate");

                    b.Property<string>("Image");

                    b.Property<string>("InstagramURL");

                    b.Property<int>("PostWriterID");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("ntext");

                    b.Property<string>("Text_Az");

                    b.Property<string>("Text_Ru");

                    b.Property<string>("Title")
                        .IsRequired();

                    b.Property<string>("Title_Az");

                    b.Property<string>("Title_Ru");

                    b.HasKey("ID");

                    b.HasIndex("PostWriterID");

                    b.ToTable("Posts");
                });

            modelBuilder.Entity("TechnicalGroup.Models.PostWriter", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Fullname");

                    b.HasKey("ID");

                    b.ToTable("PostWriters");
                });

            modelBuilder.Entity("TechnicalGroup.Models.ProductCategory", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryName")
                        .IsRequired();

                    b.Property<string>("CategoryName_Az");

                    b.Property<string>("CategoryName_Ru");

                    b.HasKey("ID");

                    b.ToTable("ProductCategories");
                });

            modelBuilder.Entity("TechnicalGroup.Models.ProductPhotos", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Photo");

                    b.Property<int>("ProductID");

                    b.HasKey("ID");

                    b.HasIndex("ProductID");

                    b.ToTable("ProductPhotos");
                });

            modelBuilder.Entity("TechnicalGroup.Models.Products", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("ntext");

                    b.Property<string>("Description_Az");

                    b.Property<string>("Description_Ru");

                    b.Property<int?>("Discount");

                    b.Property<string>("Info")
                        .IsRequired();

                    b.Property<string>("Info_Az");

                    b.Property<string>("Info_Ru");

                    b.Property<bool>("IsActive");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<int>("Price");

                    b.Property<int>("ProductCategoryID");

                    b.HasKey("ID");

                    b.HasIndex("ProductCategoryID");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("TechnicalGroup.Models.ProjectPhotos", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Photo");

                    b.Property<int>("ProjectID");

                    b.HasKey("ID");

                    b.HasIndex("ProjectID");

                    b.ToTable("ProjectPhotos");
                });

            modelBuilder.Entity("TechnicalGroup.Models.Projects", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("ntext");

                    b.Property<string>("Description_Az");

                    b.Property<string>("Description_Ru");

                    b.Property<string>("LittleContent")
                        .IsRequired();

                    b.Property<string>("LittleContent_Az");

                    b.Property<string>("LittleContent_Ru");

                    b.HasKey("ID");

                    b.ToTable("Projects");
                });

            modelBuilder.Entity("TechnicalGroup.Models.ServiceItems", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Content")
                        .IsRequired();

                    b.Property<string>("Content_Az");

                    b.Property<string>("Content_Ru");

                    b.Property<string>("Title")
                        .IsRequired();

                    b.Property<string>("Title_Az");

                    b.Property<string>("Title_Ru");

                    b.HasKey("ID");

                    b.ToTable("ServiceItems");
                });

            modelBuilder.Entity("TechnicalGroup.Models.Settings", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AboutDesc")
                        .IsRequired()
                        .HasColumnType("ntext");

                    b.Property<string>("AboutDesc_Az");

                    b.Property<string>("AboutDesc_Ru");

                    b.Property<string>("ContactAddress")
                        .HasMaxLength(200);

                    b.Property<string>("ContactEmail");

                    b.Property<string>("ContactPhone");

                    b.Property<string>("MainBannerTitle")
                        .IsRequired()
                        .HasMaxLength(65);

                    b.Property<string>("MainBannerTitle_Az");

                    b.Property<string>("MainBannerTitle_Ru");

                    b.Property<string>("SiteLogo");

                    b.HasKey("ID");

                    b.ToTable("Settings");
                });

            modelBuilder.Entity("TechnicalGroup.Models.WhyChooseUsItems", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Info");

                    b.Property<string>("Info_Az");

                    b.Property<string>("Info_Ru");

                    b.Property<string>("Title")
                        .IsRequired();

                    b.Property<string>("Title_Az");

                    b.Property<string>("Title_Ru");

                    b.HasKey("ID");

                    b.ToTable("WhyChooseUsItems");
                });

            modelBuilder.Entity("TechnicalGroup.Models.Comments", b =>
                {
                    b.HasOne("TechnicalGroup.Models.Post", "Post")
                        .WithMany("Comments")
                        .HasForeignKey("PostID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("TechnicalGroup.Models.Post", b =>
                {
                    b.HasOne("TechnicalGroup.Models.PostWriter", "PostWriter")
                        .WithMany("Posts")
                        .HasForeignKey("PostWriterID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("TechnicalGroup.Models.ProductPhotos", b =>
                {
                    b.HasOne("TechnicalGroup.Models.Products", "Product")
                        .WithMany("ProductPhotos")
                        .HasForeignKey("ProductID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("TechnicalGroup.Models.Products", b =>
                {
                    b.HasOne("TechnicalGroup.Models.ProductCategory", "ProductCategory")
                        .WithMany("Products")
                        .HasForeignKey("ProductCategoryID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("TechnicalGroup.Models.ProjectPhotos", b =>
                {
                    b.HasOne("TechnicalGroup.Models.Projects", "Project")
                        .WithMany("ProjectPhotos")
                        .HasForeignKey("ProjectID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
