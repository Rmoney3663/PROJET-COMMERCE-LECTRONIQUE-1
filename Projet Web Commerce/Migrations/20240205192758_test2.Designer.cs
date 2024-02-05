﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Projet_Web_Commerce.Data;

#nullable disable

namespace Projet_Web_Commerce.Migrations
{
    [DbContext(typeof(AuthDbContext))]
    [Migration("20240205192758_test2")]
    partial class test2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Projet_Web_Commerce.Areas.Identity.Data.Utilisateur", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Projet_Web_Commerce.Models.PPArticlesEnPanier", b =>
                {
                    b.Property<int>("NoPanier")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("NoPanier"));

                    b.Property<DateTime>("DateCreation")
                        .HasColumnType("datetime2");

                    b.Property<int>("NbItems")
                        .HasColumnType("int");

                    b.Property<int>("NoClient")
                        .HasColumnType("int");

                    b.Property<int>("NoProduit")
                        .HasColumnType("int");

                    b.Property<int>("NoVendeur")
                        .HasColumnType("int");

                    b.HasKey("NoPanier");

                    b.HasIndex("NoClient");

                    b.HasIndex("NoProduit");

                    b.HasIndex("NoVendeur");

                    b.ToTable("PPArticlesEnPanier");
                });

            modelBuilder.Entity("Projet_Web_Commerce.Models.PPCategories", b =>
                {
                    b.Property<int>("NoCategorie")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("NoCategorie"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Details")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("NoCategorie");

                    b.ToTable("PPCategories");
                });

            modelBuilder.Entity("Projet_Web_Commerce.Models.PPClients", b =>
                {
                    b.Property<int>("NoClient")
                        .HasColumnType("int");

                    b.Property<string>("AdresseEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CodePostal")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateCreation")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateDerniereConnexion")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateMAJ")
                        .HasColumnType("datetime2");

                    b.Property<string>("IdUtilisateur")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("MotDePasse")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("NbConnexions")
                        .HasColumnType("int");

                    b.Property<string>("NoProvince")
                        .HasColumnType("char(2)");

                    b.Property<string>("Nom")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pays")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Prenom")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Rue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Statut")
                        .HasColumnType("int");

                    b.Property<string>("Tel1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tel2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ville")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("NoClient");

                    b.HasIndex("IdUtilisateur");

                    b.HasIndex("NoProvince");

                    b.ToTable("PPClients");
                });

            modelBuilder.Entity("Projet_Web_Commerce.Models.PPCommandes", b =>
                {
                    b.Property<int>("NoCommande")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("NoCommande"));

                    b.Property<decimal>("CoutLivraison")
                        .HasColumnType("smallmoney");

                    b.Property<DateTime>("DateCommande")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("MontantTotAvantTaxes")
                        .HasColumnType("smallmoney");

                    b.Property<string>("NoAutorisation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NoClient")
                        .HasColumnType("int");

                    b.Property<int>("NoVendeur")
                        .HasColumnType("int");

                    b.Property<decimal>("PoidsTotal")
                        .HasColumnType("numeric(8,1)");

                    b.Property<string>("Statut")
                        .IsRequired()
                        .HasColumnType("char(1)");

                    b.Property<decimal>("TPS")
                        .HasColumnType("smallmoney");

                    b.Property<decimal>("TVQ")
                        .HasColumnType("smallmoney");

                    b.Property<int>("TypeLivraison")
                        .HasColumnType("int");

                    b.HasKey("NoCommande");

                    b.HasIndex("NoClient");

                    b.HasIndex("NoVendeur");

                    b.HasIndex("TypeLivraison");

                    b.ToTable("PPCommandes");
                });

            modelBuilder.Entity("Projet_Web_Commerce.Models.PPDetailsCommandes", b =>
                {
                    b.Property<int>("NoDetailsCommande")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("NoDetailsCommande"));

                    b.Property<int>("NoCommande")
                        .HasColumnType("int");

                    b.Property<int>("NoProduit")
                        .HasColumnType("int");

                    b.Property<decimal>("PrixVente")
                        .HasColumnType("smallmoney");

                    b.Property<int>("Quantité")
                        .HasColumnType("int");

                    b.HasKey("NoDetailsCommande");

                    b.HasIndex("NoCommande");

                    b.HasIndex("NoProduit");

                    b.ToTable("PPDetailsCommandes");
                });

            modelBuilder.Entity("Projet_Web_Commerce.Models.PPGestionnaire", b =>
                {
                    b.Property<int>("NoGestionnaire")
                        .HasColumnType("int");

                    b.Property<string>("AdresseEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateCreation")
                        .HasColumnType("datetime2");

                    b.Property<string>("IdUtilisateur")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("MotDePasse")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nom")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Prenom")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("NoGestionnaire");

                    b.HasIndex("IdUtilisateur");

                    b.ToTable("PPGestionnaire");
                });

            modelBuilder.Entity("Projet_Web_Commerce.Models.PPHistoriquePaiements", b =>
                {
                    b.Property<int>("NoHistorique")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("NoHistorique"));

                    b.Property<DateTime>("DateVente")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("FraisLesi")
                        .HasColumnType("smallmoney");

                    b.Property<decimal>("FraisLivraison")
                        .HasColumnType("smallmoney");

                    b.Property<decimal>("FraisTPS")
                        .HasColumnType("smallmoney");

                    b.Property<decimal>("FraisTVQ")
                        .HasColumnType("smallmoney");

                    b.Property<decimal>("MontantVenteAvantLivraison")
                        .HasColumnType("smallmoney");

                    b.Property<string>("NoAutorisation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NoClient")
                        .HasColumnType("int");

                    b.Property<int>("NoCommande")
                        .HasColumnType("int");

                    b.Property<int>("NoVendeur")
                        .HasColumnType("int");

                    b.Property<decimal>("Redevance")
                        .HasColumnType("smallmoney");

                    b.HasKey("NoHistorique");

                    b.ToTable("PPHistoriquePaiements");
                });

            modelBuilder.Entity("Projet_Web_Commerce.Models.PPPoidsLivraisons", b =>
                {
                    b.Property<int>("CodeLivraison")
                        .HasColumnType("int");

                    b.Property<int>("CodePoids")
                        .HasColumnType("int");

                    b.Property<decimal>("Tarif")
                        .HasColumnType("smallmoney");

                    b.HasKey("CodeLivraison", "CodePoids");

                    b.HasIndex("CodePoids");

                    b.ToTable("PPPoidsLivraisons");
                });

            modelBuilder.Entity("Projet_Web_Commerce.Models.PPProduits", b =>
                {
                    b.Property<int>("NoProduit")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateCreation")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateMAJ")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateVente")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Disponibilite")
                        .HasColumnType("bit");

                    b.Property<int>("NoCategorie")
                        .HasColumnType("int");

                    b.Property<int>("NoVendeur")
                        .HasColumnType("int");

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NombreItems")
                        .HasColumnType("int");

                    b.Property<string>("Photo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Poids")
                        .HasColumnType("numeric(8,1)");

                    b.Property<decimal>("PrixDemande")
                        .HasColumnType("smallmoney");

                    b.Property<decimal?>("PrixVente")
                        .HasColumnType("smallmoney");

                    b.HasKey("NoProduit");

                    b.HasIndex("NoCategorie");

                    b.HasIndex("NoVendeur");

                    b.ToTable("PPProduits");
                });

            modelBuilder.Entity("Projet_Web_Commerce.Models.PPTaxeFederale", b =>
                {
                    b.Property<int>("NoTPS")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("NoTPS"));

                    b.Property<DateTime>("DateEffectiveTPS")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("TauxTPS")
                        .HasColumnType("numeric(4,2)");

                    b.HasKey("NoTPS");

                    b.ToTable("PPTaxeFederale");
                });

            modelBuilder.Entity("Projet_Web_Commerce.Models.PPTaxeProvinciale", b =>
                {
                    b.Property<int>("NoTVQ")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("NoTVQ"));

                    b.Property<DateTime>("DateEffectiveTVQ")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("TauxTVQ")
                        .HasColumnType("numeric(5,3)");

                    b.HasKey("NoTVQ");

                    b.ToTable("PPTaxeProvinciale");
                });

            modelBuilder.Entity("Projet_Web_Commerce.Models.PPTypesLivraison", b =>
                {
                    b.Property<int>("CodeLivraison")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CodeLivraison"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CodeLivraison");

                    b.ToTable("PPTypesLivraison");
                });

            modelBuilder.Entity("Projet_Web_Commerce.Models.PPTypesPoids", b =>
                {
                    b.Property<int>("CodePoids")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CodePoids"));

                    b.Property<decimal>("PoidsMax")
                        .HasColumnType("numeric(8,1)");

                    b.Property<decimal>("PoidsMin")
                        .HasColumnType("numeric(8,1)");

                    b.HasKey("CodePoids");

                    b.ToTable("PPTypesPoids");
                });

            modelBuilder.Entity("Projet_Web_Commerce.Models.PPVendeurs", b =>
                {
                    b.Property<int>("NoVendeur")
                        .HasColumnType("int");

                    b.Property<string>("AdresseEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CodePostal")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Configuration")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateCreation")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateMAJ")
                        .HasColumnType("datetime2");

                    b.Property<string>("IdUtilisateur")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<decimal?>("LivraisonGratuite")
                        .HasColumnType("smallmoney");

                    b.Property<string>("MotDePasse")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NoProvince")
                        .IsRequired()
                        .HasColumnType("char(2)");

                    b.Property<string>("Nom")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NomAffaires")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Pays")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PoidsMaxLivraison")
                        .HasColumnType("int");

                    b.Property<decimal?>("Pourcentage")
                        .HasColumnType("decimal(4,2)");

                    b.Property<string>("Prenom")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Rue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Statut")
                        .HasColumnType("int");

                    b.Property<bool?>("Taxes")
                        .HasColumnType("bit");

                    b.Property<string>("Tel1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tel2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ville")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("NoVendeur");

                    b.HasIndex("IdUtilisateur");

                    b.HasIndex("NoProvince");

                    b.HasIndex("NomAffaires")
                        .IsUnique()
                        .HasFilter("[NomAffaires] IS NOT NULL");

                    b.ToTable("PPVendeurs");
                });

            modelBuilder.Entity("Projet_Web_Commerce.Models.PPVendeursClients", b =>
                {
                    b.Property<int>("NoVendeur")
                        .HasColumnType("int");

                    b.Property<int>("NoClient")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateVisite")
                        .HasColumnType("datetime2");

                    b.HasKey("NoVendeur", "NoClient", "DateVisite");

                    b.HasIndex("NoClient");

                    b.ToTable("PPVendeursClients");
                });

            modelBuilder.Entity("Projet_Web_Commerce.Models.Province", b =>
                {
                    b.Property<string>("ProvinceID")
                        .HasColumnType("char(2)");

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProvinceID");

                    b.ToTable("Province");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Projet_Web_Commerce.Areas.Identity.Data.Utilisateur", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Projet_Web_Commerce.Areas.Identity.Data.Utilisateur", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Projet_Web_Commerce.Areas.Identity.Data.Utilisateur", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Projet_Web_Commerce.Areas.Identity.Data.Utilisateur", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Projet_Web_Commerce.Models.PPArticlesEnPanier", b =>
                {
                    b.HasOne("Projet_Web_Commerce.Models.PPClients", "PPClients")
                        .WithMany("PPArticlesEnPanier")
                        .HasForeignKey("NoClient")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Projet_Web_Commerce.Models.PPProduits", "PPProduits")
                        .WithMany("PPArticlesEnPanier")
                        .HasForeignKey("NoProduit")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Projet_Web_Commerce.Models.PPVendeurs", "PPVendeurs")
                        .WithMany("PPArticlesEnPanier")
                        .HasForeignKey("NoVendeur")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("PPClients");

                    b.Navigation("PPProduits");

                    b.Navigation("PPVendeurs");
                });

            modelBuilder.Entity("Projet_Web_Commerce.Models.PPClients", b =>
                {
                    b.HasOne("Projet_Web_Commerce.Areas.Identity.Data.Utilisateur", "Utilisateur")
                        .WithMany("PPClients")
                        .HasForeignKey("IdUtilisateur")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Projet_Web_Commerce.Models.Province", "Province")
                        .WithMany("PPClients")
                        .HasForeignKey("NoProvince")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("Province");

                    b.Navigation("Utilisateur");
                });

            modelBuilder.Entity("Projet_Web_Commerce.Models.PPCommandes", b =>
                {
                    b.HasOne("Projet_Web_Commerce.Models.PPClients", "PPClients")
                        .WithMany("PPCommandes")
                        .HasForeignKey("NoClient")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Projet_Web_Commerce.Models.PPVendeurs", "PPVendeurs")
                        .WithMany("PPCommandes")
                        .HasForeignKey("NoVendeur")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Projet_Web_Commerce.Models.PPTypesLivraison", "PPTypesLivraison")
                        .WithMany("PPCommandes")
                        .HasForeignKey("TypeLivraison")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("PPClients");

                    b.Navigation("PPTypesLivraison");

                    b.Navigation("PPVendeurs");
                });

            modelBuilder.Entity("Projet_Web_Commerce.Models.PPDetailsCommandes", b =>
                {
                    b.HasOne("Projet_Web_Commerce.Models.PPCommandes", "PPCommandes")
                        .WithMany("PPDetailsCommandes")
                        .HasForeignKey("NoCommande")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Projet_Web_Commerce.Models.PPProduits", "PPProduits")
                        .WithMany("PPDetailsCommandes")
                        .HasForeignKey("NoProduit")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("PPCommandes");

                    b.Navigation("PPProduits");
                });

            modelBuilder.Entity("Projet_Web_Commerce.Models.PPGestionnaire", b =>
                {
                    b.HasOne("Projet_Web_Commerce.Areas.Identity.Data.Utilisateur", "Utilisateur")
                        .WithMany("PPGestionnaire")
                        .HasForeignKey("IdUtilisateur")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Utilisateur");
                });

            modelBuilder.Entity("Projet_Web_Commerce.Models.PPPoidsLivraisons", b =>
                {
                    b.HasOne("Projet_Web_Commerce.Models.PPTypesLivraison", "PPTypesLivraison")
                        .WithMany("PPPoidsLivraisons")
                        .HasForeignKey("CodeLivraison")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Projet_Web_Commerce.Models.PPTypesPoids", "PPTypesPoids")
                        .WithMany("PPPoidsLivraisons")
                        .HasForeignKey("CodePoids")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("PPTypesLivraison");

                    b.Navigation("PPTypesPoids");
                });

            modelBuilder.Entity("Projet_Web_Commerce.Models.PPProduits", b =>
                {
                    b.HasOne("Projet_Web_Commerce.Models.PPCategories", "PPCategories")
                        .WithMany("PPProduits")
                        .HasForeignKey("NoCategorie")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Projet_Web_Commerce.Models.PPVendeurs", "PPVendeurs")
                        .WithMany("PPProduits")
                        .HasForeignKey("NoVendeur")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("PPCategories");

                    b.Navigation("PPVendeurs");
                });

            modelBuilder.Entity("Projet_Web_Commerce.Models.PPVendeurs", b =>
                {
                    b.HasOne("Projet_Web_Commerce.Areas.Identity.Data.Utilisateur", "Utilisateur")
                        .WithMany("PPVendeurs")
                        .HasForeignKey("IdUtilisateur")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Projet_Web_Commerce.Models.Province", "Province")
                        .WithMany("PPVendeurs")
                        .HasForeignKey("NoProvince")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Province");

                    b.Navigation("Utilisateur");
                });

            modelBuilder.Entity("Projet_Web_Commerce.Models.PPVendeursClients", b =>
                {
                    b.HasOne("Projet_Web_Commerce.Models.PPClients", "PPClients")
                        .WithMany("PPVendeursClients")
                        .HasForeignKey("NoClient")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Projet_Web_Commerce.Models.PPVendeurs", "PPVendeurs")
                        .WithMany("PPVendeursClients")
                        .HasForeignKey("NoVendeur")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("PPClients");

                    b.Navigation("PPVendeurs");
                });

            modelBuilder.Entity("Projet_Web_Commerce.Areas.Identity.Data.Utilisateur", b =>
                {
                    b.Navigation("PPClients");

                    b.Navigation("PPGestionnaire");

                    b.Navigation("PPVendeurs");
                });

            modelBuilder.Entity("Projet_Web_Commerce.Models.PPCategories", b =>
                {
                    b.Navigation("PPProduits");
                });

            modelBuilder.Entity("Projet_Web_Commerce.Models.PPClients", b =>
                {
                    b.Navigation("PPArticlesEnPanier");

                    b.Navigation("PPCommandes");

                    b.Navigation("PPVendeursClients");
                });

            modelBuilder.Entity("Projet_Web_Commerce.Models.PPCommandes", b =>
                {
                    b.Navigation("PPDetailsCommandes");
                });

            modelBuilder.Entity("Projet_Web_Commerce.Models.PPProduits", b =>
                {
                    b.Navigation("PPArticlesEnPanier");

                    b.Navigation("PPDetailsCommandes");
                });

            modelBuilder.Entity("Projet_Web_Commerce.Models.PPTypesLivraison", b =>
                {
                    b.Navigation("PPCommandes");

                    b.Navigation("PPPoidsLivraisons");
                });

            modelBuilder.Entity("Projet_Web_Commerce.Models.PPTypesPoids", b =>
                {
                    b.Navigation("PPPoidsLivraisons");
                });

            modelBuilder.Entity("Projet_Web_Commerce.Models.PPVendeurs", b =>
                {
                    b.Navigation("PPArticlesEnPanier");

                    b.Navigation("PPCommandes");

                    b.Navigation("PPProduits");

                    b.Navigation("PPVendeursClients");
                });

            modelBuilder.Entity("Projet_Web_Commerce.Models.Province", b =>
                {
                    b.Navigation("PPClients");

                    b.Navigation("PPVendeurs");
                });
#pragma warning restore 612, 618
        }
    }
}
