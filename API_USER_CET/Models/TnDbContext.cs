using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace API_USER_CET.Models;

public partial class TnDbContext : DbContext
{
    public TnDbContext():base()
    {
    }

    public TnDbContext(DbContextOptions<TnDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Acount> Acounts { get; set; }

    public virtual DbSet<Brand> Brands { get; set; }

    public virtual DbSet<Category> Categories { get; set; }

    public virtual DbSet<Comment> Comments { get; set; }

    public virtual DbSet<Hotline> Hotlines { get; set; }

    public virtual DbSet<Introduce> Introduces { get; set; }

    public virtual DbSet<Menu> Menus { get; set; }

    public virtual DbSet<MoreImage> MoreImages { get; set; }

    public virtual DbSet<NewsArticle> NewsArticles { get; set; }

    public virtual DbSet<Slider> Sliders { get; set; }

    public virtual DbSet<TbProduct> TbProducts { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseSqlServer("Server=TRAN-QUANG-HAU\\SQLEXPRESS;Database=TN_Db;Trusted_Connection=True;TrustServerCertificate=true");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Acount>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ACOUNT__3214EC2756149102");

            entity.ToTable("ACOUNT");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Address)
                .HasMaxLength(250)
                .HasColumnName("ADDRESS");
            entity.Property(e => e.Dateofbirth)
                .HasColumnType("date")
                .HasColumnName("DATEOFBIRTH");
            entity.Property(e => e.Email)
                .HasMaxLength(250)
                .HasColumnName("EMAIL");
            entity.Property(e => e.Name)
                .HasMaxLength(250)
                .HasColumnName("NAME");
            entity.Property(e => e.Password)
                .HasMaxLength(250)
                .HasColumnName("PASSWORD");
            entity.Property(e => e.Username)
                .HasMaxLength(250)
                .HasColumnName("USERNAME");
        });

        modelBuilder.Entity<Brand>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__BRAND__3214EC2726FB427B");

            entity.ToTable("BRAND");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Content).HasColumnName("CONTENT");
            entity.Property(e => e.Dated)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("DATED");
            entity.Property(e => e.Image).HasColumnName("IMAGE");
            entity.Property(e => e.Name)
                .HasMaxLength(250)
                .HasColumnName("NAME");
        });

        modelBuilder.Entity<Category>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__CATEGORI__3214EC2704D2A882");

            entity.ToTable("CATEGORIES");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Created)
                .HasMaxLength(250)
                .HasColumnName("CREATED");
            entity.Property(e => e.Dated)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("DATED");
            entity.Property(e => e.Description).HasColumnName("DESCRIPTION");
            entity.Property(e => e.Name)
                .HasMaxLength(250)
                .HasColumnName("NAME");
        });

        modelBuilder.Entity<Comment>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__COMMENT__3214EC273120DB3C");

            entity.ToTable("COMMENT");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Content).HasColumnName("CONTENT");
            entity.Property(e => e.Dated)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("DATED");
            entity.Property(e => e.Email)
                .HasMaxLength(250)
                .HasColumnName("EMAIL");
            entity.Property(e => e.Name)
                .HasMaxLength(250)
                .HasColumnName("NAME");
        });

        modelBuilder.Entity<Hotline>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__HOTLINE__3214EC2766ED0F03");

            entity.ToTable("HOTLINE");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Content).HasColumnName("CONTENT");
            entity.Property(e => e.Dated)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("DATED");
            entity.Property(e => e.Email)
                .HasMaxLength(250)
                .HasColumnName("EMAIL");
            entity.Property(e => e.Tel)
                .HasMaxLength(10)
                .HasColumnName("TEL");
        });

        modelBuilder.Entity<Introduce>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__INTRODUC__3214EC27921909CF");

            entity.ToTable("INTRODUCE");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Content).HasColumnName("CONTENT");
            entity.Property(e => e.Creator)
                .HasMaxLength(250)
                .HasColumnName("CREATOR");
            entity.Property(e => e.Dated)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("DATED");
            entity.Property(e => e.Description).HasColumnName("DESCRIPTION");
            entity.Property(e => e.Image).HasColumnName("IMAGE");
            entity.Property(e => e.Name)
                .HasMaxLength(250)
                .HasColumnName("NAME");
        });

        modelBuilder.Entity<Menu>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__MENU__3214EC27567753C9");

            entity.ToTable("MENU");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Creator)
                .HasMaxLength(250)
                .HasColumnName("CREATOR");
            entity.Property(e => e.Dated)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("DATED");
            entity.Property(e => e.Description).HasColumnName("DESCRIPTION");
            entity.Property(e => e.Name)
                .HasMaxLength(250)
                .HasColumnName("NAME");
        });

        modelBuilder.Entity<MoreImage>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__MORE_IMA__3214EC2706A2E0D6");

            entity.ToTable("MORE_IMAGE");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Dated)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("DATED");
            entity.Property(e => e.Image).HasColumnName("IMAGE");
            entity.Property(e => e.NameImg)
                .HasMaxLength(250)
                .HasColumnName("NAME_IMG");
            entity.Property(e => e.NewId).HasColumnName("NEW_ID");

            entity.HasOne(d => d.New).WithMany(p => p.MoreImages)
                .HasForeignKey(d => d.NewId)
                .HasConstraintName("FK__MORE_IMAG__NEW_I__0C85DE4D");
        });

        modelBuilder.Entity<NewsArticle>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__NEWS_ART__3214EC27F7D9A551");

            entity.ToTable("NEWS_ARTICLE");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CategoriesId).HasColumnName("CATEGORIES_ID");
            entity.Property(e => e.Content).HasColumnName("CONTENT");
            entity.Property(e => e.Created)
                .HasMaxLength(250)
                .HasColumnName("CREATED");
            entity.Property(e => e.Dated)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("DATED");
            entity.Property(e => e.Description).HasColumnName("DESCRIPTION");
            entity.Property(e => e.Image).HasColumnName("IMAGE");
            entity.Property(e => e.Name)
                .HasMaxLength(250)
                .HasColumnName("NAME");

            entity.HasOne(d => d.Categories).WithMany(p => p.NewsArticles)
                .HasForeignKey(d => d.CategoriesId)
                .HasConstraintName("FK__NEWS_ARTI__CATEG__07C12930");
        });

        modelBuilder.Entity<Slider>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__SLIDER__3214EC270F7DA6D8");

            entity.ToTable("SLIDER");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Content).HasColumnName("CONTENT");
            entity.Property(e => e.Dated)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("DATED");
            entity.Property(e => e.Image).HasColumnName("IMAGE");
            entity.Property(e => e.Name)
                .HasMaxLength(250)
                .HasColumnName("NAME");
        });

        modelBuilder.Entity<TbProduct>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__tb_produ__3214EC07D2D466DB");

            entity.ToTable("tb_products");

            entity.Property(e => e.Name).HasMaxLength(255);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
