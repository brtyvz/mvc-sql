namespace Ornek.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Satis Detaylari")]
    public partial class Satis_Detaylari
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SatisID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int UrunID { get; set; }

        [Column(TypeName = "money")]
        public decimal BirimFiyati { get; set; }

        public short Miktar { get; set; }

        public float İndirim { get; set; }

        public virtual Satislar Satislar { get; set; }

        public virtual Urunler Urunler { get; set; }
    }
}
