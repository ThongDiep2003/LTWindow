using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace QLThietBi
{
    public partial class Context : DbContext
    {
        public Context()
            : base("name=Context")
        {
        }

        public virtual DbSet<Phong> Phong { get; set; }
        public virtual DbSet<TB_Phong> TB_Phong { get; set; }
        public virtual DbSet<ThietBi> ThietBi { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Phong>()
                .HasMany(e => e.TB_Phong)
                .WithRequired(e => e.Phong)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ThietBi>()
                .HasMany(e => e.TB_Phong)
                .WithRequired(e => e.ThietBi)
                .WillCascadeOnDelete(false);
        }
    }
}
