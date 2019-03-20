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
        public short YashayishMenteqesiID { get; set; }

        [Required]
        [StringLength(50)]
        public string YashayishMenteqesiAdi { get; set; }

        public byte UnvanStatusID { get; set; }

        public virtual UnvanStatu UnvanStatu { get; set; }
    }
}
