﻿// <auto-generated />
using ContactIdentityList.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ContactIdentityList.Migrations
{
    [DbContext(typeof(ContactIdentityListContext))]
    [Migration("20230802202827_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("ContactGroup", b =>
                {
                    b.Property<int>("ContactGroupId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("ContactId")
                        .HasColumnType("int");

                    b.Property<int>("GroupId")
                        .HasColumnType("int");

                    b.HasKey("ContactGroupId");

                    b.HasIndex("ContactId");

                    b.HasIndex("GroupId");

                    b.ToTable("ContactGroups");
                });

            modelBuilder.Entity("ContactIdentityList.Models.Contact", b =>
                {
                    b.Property<int>("ContactId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("ShortName")
                        .HasColumnType("longtext");

                    b.HasKey("ContactId");

                    b.ToTable("Contacts");
                });

            modelBuilder.Entity("ContactIdentityList.Models.Group", b =>
                {
                    b.Property<int>("GroupId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("GroupId");

                    b.ToTable("Groups");
                });

            modelBuilder.Entity("ContactIdentityList.Models.Identity", b =>
                {
                    b.Property<int>("IdentityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("ContactId")
                        .HasColumnType("int");

                    b.Property<string>("Identifier")
                        .HasColumnType("longtext");

                    b.Property<string>("Notes")
                        .HasColumnType("longtext");

                    b.Property<string>("ProfileURL")
                        .HasColumnType("longtext");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("IdentityId");

                    b.HasIndex("ContactId");

                    b.ToTable("Identities");
                });

            modelBuilder.Entity("ContactGroup", b =>
                {
                    b.HasOne("ContactIdentityList.Models.Contact", "Contact")
                        .WithMany("JoinEntities")
                        .HasForeignKey("ContactId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ContactIdentityList.Models.Group", "Group")
                        .WithMany("JoinEntities")
                        .HasForeignKey("GroupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Contact");

                    b.Navigation("Group");
                });

            modelBuilder.Entity("ContactIdentityList.Models.Identity", b =>
                {
                    b.HasOne("ContactIdentityList.Models.Contact", "Contact")
                        .WithMany("Identities")
                        .HasForeignKey("ContactId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Contact");
                });

            modelBuilder.Entity("ContactIdentityList.Models.Contact", b =>
                {
                    b.Navigation("Identities");

                    b.Navigation("JoinEntities");
                });

            modelBuilder.Entity("ContactIdentityList.Models.Group", b =>
                {
                    b.Navigation("JoinEntities");
                });
#pragma warning restore 612, 618
        }
    }
}