namespace Dais.EntityModel
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class EntityDataModels : DbContext
    {
        public EntityDataModels()
            : base("name=EntityDataModels")
        {
        }

        public virtual DbSet<Belediyye> Belediyyes { get; set; }
        public virtual DbSet<Daimi> Daimis { get; set; }
        public virtual DbSet<Daire> Daires { get; set; }
        public virtual DbSet<Ev> Evs { get; set; }
        public virtual DbSet<Istifadeciler> Istifadecilers { get; set; }
        public virtual DbSet<Menteqe> Menteqes { get; set; }
        public virtual DbSet<MenteqeBina> MenteqeBinas { get; set; }
        public virtual DbSet<MenteqeNov> MenteqeNovs { get; set; }
        public virtual DbSet<ProspektKuche> ProspektKuches { get; set; }
        public virtual DbSet<ProspKucheDaireMent> ProspKucheDaireMents { get; set; }
        public virtual DbSet<QeydiyyatSebeb> QeydiyyatSebebs { get; set; }
        public virtual DbSet<Rayon> Rayons { get; set; }
        public virtual DbSet<SeciciStatu> SeciciStatus { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<UnvanStatu> UnvanStatus { get; set; }
        public virtual DbSet<VesiqeSeriya> VesiqeSeriyas { get; set; }
        public virtual DbSet<VesiqeTipi> VesiqeTipis { get; set; }
        public virtual DbSet<YashayishMenteqesi> YashayishMenteqesis { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Belediyye>()
                .HasMany(e => e.Menteqes)
                .WithRequired(e => e.Belediyye)
                .HasForeignKey(e => e.BelediyyeKodu)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Daimi>()
                .Property(e => e.SeciciID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Daimi>()
                .Property(e => e.Giris)
                .IsUnicode(false);

            modelBuilder.Entity<Daimi>()
                .Property(e => e.Menzil)
                .IsUnicode(false);

            modelBuilder.Entity<Daimi>()
                .Property(e => e.VesiqeNomresi)
                .IsUnicode(false);

            modelBuilder.Entity<Daimi>()
                .Property(e => e.Pinkod)
                .IsUnicode(false);

            modelBuilder.Entity<Daire>()
                .Property(e => e.IPunvan)
                .IsUnicode(false);

            modelBuilder.Entity<Daire>()
                .HasMany(e => e.Menteqes)
                .WithRequired(e => e.Daire)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Istifadeciler>()
                .HasOptional(e => e.Daire)
                .WithRequired(e => e.Istifadeciler);

            modelBuilder.Entity<Menteqe>()
                .Property(e => e.XKoodinati)
                .IsUnicode(false);

            modelBuilder.Entity<Menteqe>()
                .Property(e => e.YKoodinati)
                .IsUnicode(false);

            modelBuilder.Entity<Menteqe>()
                .HasMany(e => e.Daimis)
                .WithRequired(e => e.Menteqe)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Menteqe>()
                .HasMany(e => e.ProspKucheDaireMents)
                .WithRequired(e => e.Menteqe)
                .HasForeignKey(e => e.MenteqeID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Menteqe>()
                .HasMany(e => e.ProspKucheDaireMents1)
                .WithRequired(e => e.Menteqe1)
                .HasForeignKey(e => e.MenteqeID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MenteqeNov>()
                .HasMany(e => e.Menteqes)
                .WithRequired(e => e.MenteqeNov)
                .HasForeignKey(e => e.MeneteqeNovID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ProspektKuche>()
                .HasOptional(e => e.ProspKucheDaireMent)
                .WithRequired(e => e.ProspektKuche);

            modelBuilder.Entity<ProspKucheDaireMent>()
                .HasMany(e => e.Evs)
                .WithRequired(e => e.ProspKucheDaireMent)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<QeydiyyatSebeb>()
                .HasMany(e => e.Daimis)
                .WithRequired(e => e.QeydiyyatSebeb)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Rayon>()
                .HasMany(e => e.Menteqes)
                .WithRequired(e => e.Rayon)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SeciciStatu>()
                .HasMany(e => e.Daimis)
                .WithRequired(e => e.SeciciStatu)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<UnvanStatu>()
                .HasMany(e => e.YashayishMenteqesis)
                .WithRequired(e => e.UnvanStatu)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<VesiqeSeriya>()
                .Property(e => e.VesiqeSeriyaAdi)
                .IsUnicode(false);

            modelBuilder.Entity<YashayishMenteqesi>()
                .HasMany(e => e.ProspektKuches)
                .WithRequired(e => e.YashayishMenteqesi)
                .WillCascadeOnDelete(false);
        }
    }
}
