using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace MoviESWeb.Models.DB;

public partial class MoviesContext : DbContext
{
    public MoviesContext()
    {
    }

    public MoviesContext(DbContextOptions<MoviesContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Admin> Admins { get; set; }

    public virtual DbSet<Documentary> Documentaries { get; set; }

    public virtual DbSet<Film> Films { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Admin>(entity =>
        {
            entity.HasKey(e => e.IdAdmin).HasName("PK__admins__89472E952E6EAD3C");

            entity.ToTable("admins");

            entity.Property(e => e.IdAdmin).HasColumnName("id_admin");
            entity.Property(e => e.EmailAdmin)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("email_admin");
            entity.Property(e => e.NameAdmin)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("name_admin");
            entity.Property(e => e.PasswordAdmin)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("password_admin");
        });

        modelBuilder.Entity<Documentary>(entity =>
        {
            entity.HasKey(e => e.IdDocumentary).HasName("PK__document__9983BBAD06384CF0");

            entity.ToTable("documentaries");

            entity.Property(e => e.IdDocumentary).HasColumnName("id_Documentary");
            entity.Property(e => e.Category)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("category");
            entity.Property(e => e.Img).HasColumnName("img");
            entity.Property(e => e.Title)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("title");
            entity.Property(e => e.TvProducer)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("tv_Producer");
            entity.Property(e => e.Voiceover).HasColumnName("voiceover");
        });

        modelBuilder.Entity<Film>(entity =>
        {
            entity.HasKey(e => e.IdFilm).HasName("PK__films__648EA6D73CA0332C");

            entity.ToTable("films");

            entity.Property(e => e.IdFilm).HasColumnName("id_film");
            entity.Property(e => e.Category)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("category");
            entity.Property(e => e.Director)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("director");
            entity.Property(e => e.Img).HasColumnName("img");
            entity.Property(e => e.MainActor)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("main_Actor");
            entity.Property(e => e.Producer)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("producer");
            entity.Property(e => e.Title)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("title");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.IdUser).HasName("PK__users__D2D1463771C203D4");

            entity.ToTable("users");

            entity.Property(e => e.IdUser).HasColumnName("id_user");
            entity.Property(e => e.EmailUser)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("email_user");
            entity.Property(e => e.NameUser)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("name_user");
            entity.Property(e => e.PasswordUser)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("password_user");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
