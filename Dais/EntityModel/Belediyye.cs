namespace Dais.EntityModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Belediyye")]
    public partial class Belediyye
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Belediyye()
        {
            Menteqes = new HashSet<Menteqe>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short BelediyyeKod { get; set; }

        [Required]
        [StringLength(50)]
        public string BelediyyeAdi { get; set; }

        public int EhaliSayi { get; set; }

        public byte UzvSayi { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Menteqe> Menteqes { get; set; }
    }
}
