namespace Dais.EntityModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("YashMenDaireMent")]
    public partial class YashMenDaireMent
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public YashMenDaireMent()
        {
            Daimis = new HashSet<Daimi>();
            Evs = new HashSet<Ev>();
            ProspKucheDaireMents = new HashSet<ProspKucheDaireMent>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short YashMenDaireMentID { get; set; }

        public short YashayishMenteqesiID { get; set; }

        public short MenteqeID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Daimi> Daimis { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Ev> Evs { get; set; }

        public virtual Menteqe Menteqe { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProspKucheDaireMent> ProspKucheDaireMents { get; set; }

        public virtual YashayishMenteqesi YashayishMenteqesi { get; set; }
    }
}
