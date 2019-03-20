namespace Dais.EntityModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SeciciStatu
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SeciciStatu()
        {
            Daimis = new HashSet<Daimi>();
        }

        [Key]
        public byte SeciciStatusID { get; set; }

        [Required]
        [StringLength(50)]
        public string SeciciStatusAdi { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Daimi> Daimis { get; set; }
    }
}
