namespace Dais.EntityModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Ev")]
    public partial class Ev
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Ev()
        {
            Daimis = new HashSet<Daimi>();
        }

        public int EvID { get; set; }

        [Required]
        [StringLength(10)]
        public string EvAdi { get; set; }

        public int ProspKucheDaireMentID { get; set; }

        public short? YashayishMenteqesiID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Daimi> Daimis { get; set; }

        public virtual ProspKucheDaireMent ProspKucheDaireMent { get; set; }

        public virtual YashayishMenteqesi YashayishMenteqesi { get; set; }
    }
}
