namespace Dais.EntityModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("YashayishMenteqesi")]
    public partial class YashayishMenteqesi
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public YashayishMenteqesi()
        {
            ProspektKuches = new HashSet<ProspektKuche>();
            YashMenDaireMents = new HashSet<YashMenDaireMent>();
        }

        public short YashayishMenteqesiID { get; set; }

        [Required]
        [StringLength(50)]
        public string YashayishMenteqesiAdi { get; set; }

        public byte UnvanStatusID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProspektKuche> ProspektKuches { get; set; }

        public virtual UnvanStatu UnvanStatu { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<YashMenDaireMent> YashMenDaireMents { get; set; }
    }
}
