namespace Dais.EntityModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("QeydiyyatSebeb")]
    public partial class QeydiyyatSebeb
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public QeydiyyatSebeb()
        {
            Daimis = new HashSet<Daimi>();
        }

        public byte QeydiyyatSebebID { get; set; }

        [Required]
        [StringLength(50)]
        public string QeydiyyatSebebAdi { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Daimi> Daimis { get; set; }
    }
}
