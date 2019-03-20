namespace Dais.EntityModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Daire")]
    public partial class Daire
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Daire()
        {
            Menteqes = new HashSet<Menteqe>();
        }

        [Key]
        public byte DaireKodu { get; set; }

        [Required]
        [StringLength(50)]
        public string DaireAdi { get; set; }

        [Required]
        [StringLength(1024)]
        public string Unvan { get; set; }

        [Required]
        [StringLength(50)]
        public string Telefon { get; set; }

        [Required]
        [StringLength(50)]
        public string IPunvan { get; set; }

        [Required]
        [StringLength(50)]
        public string XKoordinat { get; set; }

        [Required]
        [StringLength(50)]
        public string YKoordinat { get; set; }

        [Required]
        [StringLength(50)]
        public string Email { get; set; }

        public bool AktivPassiv { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? DeyismeTarixi { get; set; }

        public virtual Istifadeciler Istifadeciler { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Menteqe> Menteqes { get; set; }
    }
}
