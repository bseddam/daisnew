namespace Dais.EntityModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Daimi")]
    public partial class Daimi
    {
        [Key]
        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal SeciciID { get; set; }

        public short MenteqeID { get; set; }

        public int? EvID { get; set; }

        public int? ProspKucheDaireMentID { get; set; }

       
        [Required(ErrorMessage = "Soyad boş ola bilməz.")]
        [StringLength(50)]
        public string Soyad { get; set; }

      
        [Required(ErrorMessage = "Ad boş ola bilməz.")]
        [StringLength(50)]
        public string Ad { get; set; }

        [Required(ErrorMessage = "Ata adı boş ola bilməz.")]
        [StringLength(50)]
        public string AtaAdi { get; set; }

        public byte DogumGunu { get; set; }

        public byte DogumAyi { get; set; }

        public short DogumIli { get; set; }

        public bool Cins { get; set; }

        public int UnvanKod { get; set; }

        public byte? Mertebe { get; set; }

        [StringLength(10)]
        public string Menzil { get; set; }

        public byte SeciciStatusID { get; set; }

        public byte QeydiyyatSebebID { get; set; }

        public byte? VesiqeSeriyaID { get; set; }

        [StringLength(11)]
        public string VesiqeNomresi { get; set; }

        public byte? VesiqeVerenQurum { get; set; }

        public DateTime? VesiqeVerilmeTarixi { get; set; }

        public DateTime? VesiqeEtibarliqTarixi { get; set; }

        [StringLength(7)]
        public string Pinkod { get; set; }

        public bool QeyCixmaVereqi { get; set; }

        public DateTime DaxiledilmeTarixi { get; set; }

        public DateTime? DeyismeTarixi { get; set; }

        public virtual Ev Ev { get; set; }

        public virtual Menteqe Menteqe { get; set; }

        public virtual QeydiyyatSebeb QeydiyyatSebeb { get; set; }

        public virtual SeciciStatu SeciciStatu { get; set; }

        public virtual VesiqeSeriya VesiqeSeriya { get; set; }
    }
}
