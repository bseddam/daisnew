namespace Dais.EntityModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("VesiqeTipi")]
    public partial class VesiqeTipi
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public VesiqeTipi()
        {
            VesiqeSeriyas = new HashSet<VesiqeSeriya>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public byte VesiqeTipiID { get; set; }

        [Required]
        [StringLength(30)]
        public string VesiqeAdi { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VesiqeSeriya> VesiqeSeriyas { get; set; }
    }
}
