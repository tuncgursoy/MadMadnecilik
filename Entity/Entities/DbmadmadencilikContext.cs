using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Entity.Entities
{
    public partial class DbmadmadencilikContext : DbContext
    {
        public DbmadmadencilikContext()
        {
        }

        public DbmadmadencilikContext(DbContextOptions<DbmadmadencilikContext> options)
            : base(options)
        {
        }

        public virtual DbSet<tblBilgiler> TblBilgiler { get; set; }
        public virtual DbSet<TblDuyuru> TblDuyuru { get; set; }
        public virtual DbSet<tblKanun> TblKanun { get; set; }
        public virtual DbSet<tblKullanicilar> TblKullanicilar { get; set; }
        public virtual DbSet<tblPdf> TblPdf { get; set; }
        public virtual DbSet<tblPdfDuyuru> TblPdfDuyuru { get; set; }
        public virtual DbSet<tblPdfProje> TblPdfProje { get; set; }
        public virtual DbSet<tblProjeler> TblProjeler { get; set; }
        public virtual DbSet<tblResim> TblResim { get; set; }
        public virtual DbSet<tblResimDuyuru> TblResimDuyuru { get; set; }
        public virtual DbSet<tblResimProje> TblResimProje { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=DbMadMadencilik;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<tblBilgiler>(entity =>
            {
                entity.ToTable("tblBilgiler");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Adres)
                    .IsRequired()
                    .HasColumnName("adres")
                    .HasMaxLength(1000);

                entity.Property(e => e.Mail)
                    .IsRequired()
                    .HasColumnName("mail")
                    .HasMaxLength(50);

                entity.Property(e => e.Telefon1)
                    .IsRequired()
                    .HasColumnName("telefon1")
                    .HasMaxLength(20);

                entity.Property(e => e.Telefon2)
                    .IsRequired()
                    .HasColumnName("telefon2")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<TblDuyuru>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Baslik)
                    .IsRequired()
                    .HasColumnName("baslik")
                    .HasMaxLength(50);

                entity.Property(e => e.UploadTime)
                    .HasColumnName("uploadTime")
                    .HasColumnType("date");

                entity.Property(e => e.İcerik).IsRequired();
            });

            modelBuilder.Entity<tblKanun>(entity =>
            {
                entity.ToTable("tblKanun");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Adi)
                    .IsRequired()
                    .HasColumnName("adi")
                    .HasMaxLength(100);

                entity.Property(e => e.Url)
                    .IsRequired()
                    .HasColumnName("url");
            });

            modelBuilder.Entity<tblKullanicilar>(entity =>
            {
                entity.ToTable("tblKullanicilar");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Isim)
                    .IsRequired()
                    .HasColumnName("isim")
                    .HasMaxLength(100);

                entity.Property(e => e.Mail)
                    .IsRequired()
                    .HasColumnName("mail")
                    .HasMaxLength(100);

                entity.Property(e => e.Sifre)
                    .IsRequired()
                    .HasColumnName("sifre")
                    .HasMaxLength(100);

                entity.Property(e => e.Soyisim)
                    .IsRequired()
                    .HasColumnName("soyisim")
                    .HasMaxLength(100);

                entity.Property(e => e.rol)
                    .IsRequired()
                    .HasColumnName("rol")
                    .HasMaxLength(200);

            });

            modelBuilder.Entity<tblPdf>(entity =>
            {
                entity.ToTable("tblPdf");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.PdfUrl)
                    .IsRequired()
                    .HasColumnName("pdfUrl");
            });

            modelBuilder.Entity<tblPdfDuyuru>(entity =>
            {
                entity.HasKey(e => new { e.PdfId, e.DuyuruId });

                entity.ToTable("tblPdfDuyuru");

                entity.Property(e => e.PdfId).HasColumnName("pdfID");

                entity.Property(e => e.DuyuruId).HasColumnName("duyuruID");

                entity.HasOne(d => d.Duyuru)
                    .WithMany(p => p.TblPdfDuyuru)
                    .HasForeignKey(d => d.DuyuruId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblPdfDuyuru_TblDuyuru");

                entity.HasOne(d => d.Pdf)
                    .WithMany(p => p.TblPdfDuyuru)
                    .HasForeignKey(d => d.PdfId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblPdfDuyuru_tblPdf");
            });

            modelBuilder.Entity<tblPdfProje>(entity =>
            {
                entity.HasKey(e => new { e.PdfId, e.ProjeId });

                entity.ToTable("tblPdfProje");

                entity.HasOne(d => d.Pdf)
                    .WithMany(p => p.TblPdfProje)
                    .HasForeignKey(d => d.PdfId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblPdfProje_tblPdf");

                entity.HasOne(d => d.Proje)
                    .WithMany(p => p.TblPdfProje)
                    .HasForeignKey(d => d.ProjeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblPdfProje_tblProjeler");
            });

            modelBuilder.Entity<tblProjeler>(entity =>
            {
                entity.ToTable("tblProjeler");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Aciklama)
                    .IsRequired()
                    .HasColumnName("aciklama");

                entity.Property(e => e.Baslik)
                    .IsRequired()
                    .HasColumnName("baslik")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<tblResim>(entity =>
            {
                entity.ToTable("tblResim");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.ResimUrl)
                    .IsRequired()
                    .HasColumnName("resimURl")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<tblResimDuyuru>(entity =>
            {
                entity.HasKey(e => new { e.ResimId, e.DuyuruId });

                entity.ToTable("tblResimDuyuru");

                entity.Property(e => e.ResimId).HasColumnName("resimId");

                entity.Property(e => e.DuyuruId).HasColumnName("duyuruId");

                entity.HasOne(d => d.Duyuru)
                    .WithMany(p => p.TblResimDuyuru)
                    .HasForeignKey(d => d.DuyuruId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblResimDuyuru_TblDuyuru");

                entity.HasOne(d => d.Resim)
                    .WithMany(p => p.TblResimDuyuru)
                    .HasForeignKey(d => d.ResimId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblResimDuyuru_tblResim");
            });

            modelBuilder.Entity<tblResimProje>(entity =>
            {
                entity.HasKey(e => new { e.ResimId, e.ProjeId });

                entity.ToTable("tblResimProje");

                entity.Property(e => e.ResimId).HasColumnName("resimId");

                entity.Property(e => e.ProjeId).HasColumnName("projeId");

                entity.HasOne(d => d.Proje)
                    .WithMany(p => p.TblResimProje)
                    .HasForeignKey(d => d.ProjeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblResimProje_tblProjeler");

                entity.HasOne(d => d.Resim)
                    .WithMany(p => p.TblResimProje)
                    .HasForeignKey(d => d.ResimId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblResimProje_tblResim");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
