namespace Dais.EntityModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class UnvanStatu
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public UnvanStatu()
        {
            YashayishMenteqesis = new HashSet<YashayishMenteqesi>();
        }

        [Key]
        public byte UnvanStatusID { get; set; }

        [StringLength(50)]
        public string UnvanStatusAdi { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<YashayishMenteqesi> YashayishMenteqesis { get; set; }
    }
}
