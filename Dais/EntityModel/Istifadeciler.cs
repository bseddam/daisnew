namespace Dais.EntityModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Istifadeciler")]
    public partial class Istifadeciler
    {
        [Key]
        public byte DaireKodu { get; set; }

        [Required]
        [StringLength(50)]
        public string Ist_ad { get; set; }

        [Required]
        [StringLength(50)]
        public string Ip_unvan { get; set; }

        [Required]
        [StringLength(50)]
        public string Parol { get; set; }

        [Required]
        [StringLength(50)]
        public string Dogum_tarixi { get; set; }

        [Required]
        [StringLength(50)]
        public string Vezifesi { get; set; }

        [Required]
        [StringLength(50)]
        public string Is_telefonu { get; set; }

        [Required]
        [StringLength(50)]
        public string Ev_telefonu { get; set; }

        [Required]
        [StringLength(50)]
        public string Mobil_telefon { get; set; }

        [Required]
        [StringLength(50)]
        public string Mail { get; set; }

        public int td_gun { get; set; }

        public int td_ay { get; set; }

        public int td_il { get; set; }

        [Required]
        [StringLength(50)]
        public string Soyad { get; set; }

        [Required]
        [StringLength(50)]
        public string Ad { get; set; }

        [Required]
        [StringLength(50)]
        public string Ata { get; set; }

        [Required]
        [StringLength(50)]
        public string Ixtisas { get; set; }

        [Required]
        [StringLength(50)]
        public string Tehsili { get; set; }

        [Required]
        [StringLength(50)]
        public string Cinsi { get; set; }

        [Required]
        [StringLength(50)]
        public string Compmacadres { get; set; }

        public virtual Daire Daire { get; set; }
    }
}
