namespace Dais.EntityModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MenteqeBina")]
    public partial class MenteqeBina
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MenteqeBina()
        {
            Menteqes = new HashSet<Menteqe>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public byte MenteqeBinaID { get; set; }

        [StringLength(50)]
        public string MenteqeBinaAdi { get; set; }

        public byte? MenteqeBinaKodu { get; set; }

        public byte? MenteqeBinaNovu { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Menteqe> Menteqes { get; set; }
    }
}
