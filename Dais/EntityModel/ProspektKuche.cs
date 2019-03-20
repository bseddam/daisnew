namespace Dais.EntityModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ProspektKuche")]
    public partial class ProspektKuche
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ProspektKuche()
        {
            ProspKucheDaireMents = new HashSet<ProspKucheDaireMent>();
        }

        public int ProspektKucheID { get; set; }

        [Required]
        [StringLength(50)]
        public string ProspektKucheAdi { get; set; }

        public short YashayishMenteqesiID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProspKucheDaireMent> ProspKucheDaireMents { get; set; }
    }
}
