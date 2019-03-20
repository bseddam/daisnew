namespace Dais.EntityModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Rayon")]
    public partial class Rayon
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Rayon()
        {
            Menteqes = new HashSet<Menteqe>();
        }

        [Key]
        public byte RayonKodu { get; set; }

        [Required]
        [StringLength(50)]
        public string RayonAdi { get; set; }

        public byte? sira { get; set; }

        public bool aktiv { get; set; }

        public byte pa_sira { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Menteqe> Menteqes { get; set; }
    }
}
