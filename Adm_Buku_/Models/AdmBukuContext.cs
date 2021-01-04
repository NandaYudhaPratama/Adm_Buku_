using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Adm_Buku_.Models
{
    public partial class AdmBukuContext : DbContext
    {
        public AdmBukuContext()
        {
        }

        public AdmBukuContext(DbContextOptions<AdmBukuContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Buku> Buku { get; set; }

        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Buku>(entity =>
            {
                entity.HasKey(e => e.Isbn);

                entity.Property(e => e.Isbn)
                    .HasColumnName("ISBN")
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.JudulBuku)
                    .IsRequired()
                    .HasColumnName("Judul_Buku")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Penerbit)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Pengarang)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.TahunTerbit)
                    .HasColumnName("Tahun_Terbit")
                    .HasMaxLength(4)
                    .IsUnicode(false);
            });
        }
    }
}
