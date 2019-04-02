namespace Dais.EntityModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Menteqe")]
    public partial class Menteqe
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Menteqe()
        {
            Daimis = new HashSet<Daimi>();
            ProspKucheDaireMents = new HashSet<ProspKucheDaireMent>();
            ProspKucheDaireMents1 = new HashSet<ProspKucheDaireMent>();
        }

        public short MenteqeID { get; set; }

        public byte DaireKodu { get; set; }

        public byte MenteqeKodu { get; set; }

        [Required]
        [StringLength(1024)]
        public string Unvan { get; set; }

        public byte MeneteqeNovID { get; set; }

        public byte? MenteqeBinaID { get; set; }

        [Required]
        [StringLength(10)]
        public string XKoodinati { get; set; }

        [Required]
        [StringLength(10)]
        public string YKoodinati { get; set; }

        public byte RayonKodu { get; set; }

        public short BelediyyeKodu { get; set; }

        public short? mnt_kqs { get; set; }

        public short? mnt_sqk { get; set; }

        public short? mnt_kt { get; set; }

        [StringLength(50)]
        public string mail { get; set; }

        [StringLength(50)]
        public string tel { get; set; }

        public virtual Belediyye Belediyye { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Daimi> Daimis { get; set; }

        public virtual Daire Daire { get; set; }

        public virtual MenteqeBina MenteqeBina { get; set; }

        public virtual MenteqeNov MenteqeNov { get; set; }

        public virtual Rayon Rayon { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProspKucheDaireMent> ProspKucheDaireMents { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProspKucheDaireMent> ProspKucheDaireMents1 { get; set; }
    }
}
