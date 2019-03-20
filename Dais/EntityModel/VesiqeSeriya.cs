namespace Dais.EntityModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("VesiqeSeriya")]
    public partial class VesiqeSeriya
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public VesiqeSeriya()
        {
            Daimis = new HashSet<Daimi>();
        }

        public byte VesiqeSeriyaID { get; set; }

        [StringLength(3)]
        public string VesiqeSeriyaAdi { get; set; }

        public byte? VesiqeTipiID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Daimi> Daimis { get; set; }

        public virtual VesiqeTipi VesiqeTipi { get; set; }
    }
}
