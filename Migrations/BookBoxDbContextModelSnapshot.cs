﻿// <auto-generated />
using System;
using Bookbox.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Bookbox.Migrations
{
    [DbContext(typeof(BookBoxDbContext))]
    partial class BookBoxDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Bookbox.Models.Author", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nationality")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Authors");

                    b.HasData(
                        new
                        {
                            Id = new Guid("a2bb4edf-0d1d-4ce9-bb8e-4eaf9ff55cda"),
                            Name = "Chinua Achebe",
                            Nationality = "Nigerian"
                        },
                        new
                        {
                            Id = new Guid("96be4f0e-0880-40ad-a837-76e1cd73ab6e"),
                            Name = "Stephen Hawking",
                            Nationality = "British"
                        },
                        new
                        {
                            Id = new Guid("6a845b75-8595-4073-8160-8e52118de055"),
                            Name = "Yuval Noah",
                            Nationality = "Israeli"
                        },
                        new
                        {
                            Id = new Guid("af2dbcf9-721a-4184-9267-7d1a8a277174"),
                            Name = "Robert C Martin",
                            Nationality = "American"
                        });
                });

            modelBuilder.Entity("Bookbox.Models.Book", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("AuthorId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("AuthorName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("CategoryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("ISBN")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            Id = new Guid("211891b1-80d9-46ec-84cb-c0e89bcede5a"),
                            AuthorId = new Guid("a2bb4edf-0d1d-4ce9-bb8e-4eaf9ff55cda"),
                            AuthorName = "Chinua Achebe",
                            CategoryId = new Guid("b10f6364-aebc-49ed-8ce5-343aed2b783d"),
                            CategoryName = "Fiction",
                            CreatedAt = new DateTime(2024, 4, 11, 23, 33, 11, 722, DateTimeKind.Utc).AddTicks(1728),
                            ISBN = "978-3-16-148410-0",
                            Price = 1000.0,
                            Title = "Things Fall Apart",
                            UpdatedAt = new DateTime(2024, 4, 11, 23, 33, 11, 722, DateTimeKind.Utc).AddTicks(1729)
                        },
                        new
                        {
                            Id = new Guid("c63b1c62-5ece-4aa8-b4ff-97dcf2908d9b"),
                            AuthorId = new Guid("6a845b75-8595-4073-8160-8e52118de055"),
                            AuthorName = "Yuval Noah",
                            CategoryId = new Guid("1555e61f-b2b7-4519-a7f4-93757881d682"),
                            CategoryName = "Science",
                            CreatedAt = new DateTime(2024, 4, 11, 23, 33, 11, 722, DateTimeKind.Utc).AddTicks(1879),
                            ISBN = "978-3-16-148410-1",
                            Price = 1200.0,
                            Title = "Sapiens",
                            UpdatedAt = new DateTime(2024, 4, 11, 23, 33, 11, 722, DateTimeKind.Utc).AddTicks(1880)
                        },
                        new
                        {
                            Id = new Guid("24da42a7-ef1f-4a90-bc18-ad1adbeedd76"),
                            AuthorId = new Guid("96be4f0e-0880-40ad-a837-76e1cd73ab6e"),
                            AuthorName = "Stephen Hawking",
                            CategoryId = new Guid("c42fd143-0c1f-4e10-8fb2-b420ae179282"),
                            CategoryName = "History",
                            CreatedAt = new DateTime(2024, 4, 11, 23, 33, 11, 722, DateTimeKind.Utc).AddTicks(1891),
                            ISBN = "978-3-16-148410-2",
                            Price = 1500.0,
                            Title = "A Brief History of Time",
                            UpdatedAt = new DateTime(2024, 4, 11, 23, 33, 11, 722, DateTimeKind.Utc).AddTicks(1891)
                        },
                        new
                        {
                            Id = new Guid("beba5dd7-504f-4edc-9e99-2ed8068dacf5"),
                            AuthorId = new Guid("af2dbcf9-721a-4184-9267-7d1a8a277174"),
                            AuthorName = "Robert C Martin",
                            CategoryId = new Guid("74fa4e60-3b0f-42db-bf16-35083dd4d108"),
                            CategoryName = "Programming",
                            CreatedAt = new DateTime(2024, 4, 11, 23, 33, 11, 722, DateTimeKind.Utc).AddTicks(1899),
                            ISBN = "978-3-16-148410-3",
                            Price = 2000.0,
                            Title = "Clean Code",
                            UpdatedAt = new DateTime(2024, 4, 11, 23, 33, 11, 722, DateTimeKind.Utc).AddTicks(1899)
                        });
                });

            modelBuilder.Entity("Bookbox.Models.Category", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = new Guid("b10f6364-aebc-49ed-8ce5-343aed2b783d"),
                            CreatedAt = new DateTime(2024, 4, 11, 23, 33, 11, 722, DateTimeKind.Utc).AddTicks(1255),
                            Description = "Fiction books",
                            Name = "Fiction",
                            UpdatedAt = new DateTime(2024, 4, 11, 23, 33, 11, 722, DateTimeKind.Utc).AddTicks(1262)
                        },
                        new
                        {
                            Id = new Guid("c42fd143-0c1f-4e10-8fb2-b420ae179282"),
                            CreatedAt = new DateTime(2024, 4, 11, 23, 33, 11, 722, DateTimeKind.Utc).AddTicks(1287),
                            Description = "History books",
                            Name = "History",
                            UpdatedAt = new DateTime(2024, 4, 11, 23, 33, 11, 722, DateTimeKind.Utc).AddTicks(1288)
                        },
                        new
                        {
                            Id = new Guid("1555e61f-b2b7-4519-a7f4-93757881d682"),
                            CreatedAt = new DateTime(2024, 4, 11, 23, 33, 11, 722, DateTimeKind.Utc).AddTicks(1292),
                            Description = "Science books",
                            Name = "Science",
                            UpdatedAt = new DateTime(2024, 4, 11, 23, 33, 11, 722, DateTimeKind.Utc).AddTicks(1293)
                        },
                        new
                        {
                            Id = new Guid("74fa4e60-3b0f-42db-bf16-35083dd4d108"),
                            CreatedAt = new DateTime(2024, 4, 11, 23, 33, 11, 722, DateTimeKind.Utc).AddTicks(1296),
                            Description = "Programming books",
                            Name = "Programming",
                            UpdatedAt = new DateTime(2024, 4, 11, 23, 33, 11, 722, DateTimeKind.Utc).AddTicks(1297)
                        });
                });

            modelBuilder.Entity("Bookbox.Models.Customer", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ShippingAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Customers");

                    b.HasData(
                        new
                        {
                            Id = new Guid("5dba7a38-a3bb-426c-8783-bd94e6f3ed91"),
                            FirstName = "John",
                            LastName = "Doe",
                            ShippingAddress = "123 Main St, Lagos"
                        },
                        new
                        {
                            Id = new Guid("db6d528f-24fb-4c71-b111-5c75f001028e"),
                            FirstName = "Jane",
                            LastName = "Smith",
                            ShippingAddress = "123 Main St, UK"
                        },
                        new
                        {
                            Id = new Guid("43d1b3c1-f27e-4b89-ad15-92de0f73507f"),
                            FirstName = "Tunde",
                            LastName = "Akinkunmi",
                            ShippingAddress = "123 Main St, Ibadan"
                        },
                        new
                        {
                            Id = new Guid("030dc7da-1017-4042-9d69-bd645339d425"),
                            FirstName = "Kim",
                            LastName = "Yun",
                            ShippingAddress = "123 Main St, North Korea"
                        });
                });

            modelBuilder.Entity("Bookbox.Models.Order", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("BookId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CustomerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CustomerName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ShippingAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("TotalAmount")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("BookId");

                    b.HasIndex("CustomerId");

                    b.ToTable("Orders");

                    b.HasData(
                        new
                        {
                            Id = new Guid("200b0e05-980f-468c-835b-55f0481d03ae"),
                            BookId = new Guid("211891b1-80d9-46ec-84cb-c0e89bcede5a"),
                            CustomerId = new Guid("5dba7a38-a3bb-426c-8783-bd94e6f3ed91"),
                            CustomerName = "John Doe",
                            OrderDate = new DateTime(2024, 4, 11, 23, 33, 11, 722, DateTimeKind.Utc).AddTicks(2029),
                            ShippingAddress = "123 Main St, Lagos",
                            TotalAmount = 1000.0
                        },
                        new
                        {
                            Id = new Guid("6dd829f1-cc00-4581-b09b-e9ce5e14b656"),
                            BookId = new Guid("c63b1c62-5ece-4aa8-b4ff-97dcf2908d9b"),
                            CustomerId = new Guid("db6d528f-24fb-4c71-b111-5c75f001028e"),
                            CustomerName = "Jane Smith",
                            OrderDate = new DateTime(2024, 4, 11, 23, 33, 11, 722, DateTimeKind.Utc).AddTicks(2041),
                            ShippingAddress = "123 Main St, UK",
                            TotalAmount = 1200.0
                        },
                        new
                        {
                            Id = new Guid("4f6f9661-2468-4988-86a4-2bbdb8656a68"),
                            BookId = new Guid("24da42a7-ef1f-4a90-bc18-ad1adbeedd76"),
                            CustomerId = new Guid("43d1b3c1-f27e-4b89-ad15-92de0f73507f"),
                            CustomerName = "Tunde Akinkunmi",
                            OrderDate = new DateTime(2024, 4, 11, 23, 33, 11, 722, DateTimeKind.Utc).AddTicks(2048),
                            ShippingAddress = "123 Main St, Ibadan",
                            TotalAmount = 1500.0
                        },
                        new
                        {
                            Id = new Guid("64f7e1df-0267-4426-ae90-a48871ae967b"),
                            BookId = new Guid("beba5dd7-504f-4edc-9e99-2ed8068dacf5"),
                            CustomerId = new Guid("030dc7da-1017-4042-9d69-bd645339d425"),
                            CustomerName = "Kim Yun",
                            OrderDate = new DateTime(2024, 4, 11, 23, 33, 11, 722, DateTimeKind.Utc).AddTicks(2055),
                            ShippingAddress = "123 Main St, North Korea",
                            TotalAmount = 2000.0
                        });
                });

            modelBuilder.Entity("Bookbox.Models.Book", b =>
                {
                    b.HasOne("Bookbox.Models.Author", "Author")
                        .WithMany()
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Bookbox.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Author");

                    b.Navigation("Category");
                });

            modelBuilder.Entity("Bookbox.Models.Order", b =>
                {
                    b.HasOne("Bookbox.Models.Book", "Book")
                        .WithMany()
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Bookbox.Models.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Book");

                    b.Navigation("Customer");
                });
#pragma warning restore 612, 618
        }
    }
}