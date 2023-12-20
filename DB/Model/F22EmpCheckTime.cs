namespace FtisHelperV2.DB.Model
{
    using Dou.Misc.Attr;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class F22EmpCheckTime
    {
        [Key]
        [Column(Order = 0)]
        public int RID { get; set; }

        [StringLength(10)]
        public string CardNumber { get; set; }

        [Key]
        [Column(Order = 1)]
        public DateTime CheckTime { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(6)]
        public string Fno { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Temperature { get; set; }

        [Key]
        [Column(Order = 3)]
        public byte OutSource { get; set; }

        public byte? DoorNumber { get; set; }

        [StringLength(50)]
        public string Remark { get; set; }
    }
}
