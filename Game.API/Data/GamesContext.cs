using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Game.API.Data
{
    public partial class GamesContext : DbContext
    {
        public GamesContext()
        {
        }

        public GamesContext(DbContextOptions<GamesContext> options)
            : base(options)
        {
        }

        public virtual DbSet<GameRatings> GameRatings { get; set; }
        public virtual DbSet<Games> Games { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<GameRatings>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Rating)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Games>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Description)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.GameRatingsId).HasColumnName("GameRatingsID");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
