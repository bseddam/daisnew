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
        public int ProspektKucheID { get; set; }

        [Required]
        [StringLength(50)]
        public string ProspektKucheAdi { get; set; }

        public short YashayishMenteqesiID { get; set; }

        public virtual YashayishMenteqesi YashayishMenteqesi { get; set; }

        public virtual ProspKucheDaireMent ProspKucheDaireMent { get; set; }
    }
}
