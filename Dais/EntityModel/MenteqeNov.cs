namespace Dais.EntityModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MenteqeNov")]
    public partial class MenteqeNov
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MenteqeNov()
        {
            Menteqes = new HashSet<Menteqe>();
        }

        public byte MenteqeNovID { get; set; }

        [StringLength(50)]
        public string MenteqeNovAdi { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Menteqe> Menteqes { get; set; }
    }
}
