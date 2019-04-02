namespace Dais.EntityModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ProspKucheDaireMent")]
    public partial class ProspKucheDaireMent
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ProspKucheDaireMent()
        {
            Evs = new HashSet<Ev>();
        }

        public int ProspKucheDaireMentID { get; set; }

        public int ProspektKucheID { get; set; }

        public short MenteqeID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Ev> Evs { get; set; }

        public virtual Menteqe Menteqe { get; set; }

        public virtual Menteqe Menteqe1 { get; set; }

        public virtual ProspektKuche ProspektKuche { get; set; }
    }
}
