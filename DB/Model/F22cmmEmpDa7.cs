namespace FtisHelperV2.DB.Model
{
    using Dou.Misc.Attr;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class F22cmmEmpDa7
    {
        [Key]
        [Column(Order = 0)]
        [ColumnDef(Display = "員工編號", ColSize = 3)]
        [StringLength(6)]
        public string Fno { get; set; }

        [ColumnDef(Display = "員工編號(舊)", ColSize = 3)]
        [StringLength(6)]
        public string mno { get; set; }

        [Key]
        [Column(Order = 1)]
        [ColumnDef(Display = "編號", ColSize = 3)]
        public byte sno { get; set; }

        [ColumnDef(Display = "名稱", ColSize = 3)]
        [StringLength(20)]
        public string da701 { get; set; }

        [ColumnDef(Display = "取得年月", ColSize = 3)]
        [StringLength(6)]
        public string da702 { get; set; }

        [ColumnDef(Display = "成績", ColSize = 3)]
        [StringLength(50)]
        public string da703 { get; set; }

        [Column(TypeName = "smalldatetime")]
        [ColumnDef(Display = "異動時間", ColSize = 3)]
        public DateTime? UpdateTime { get; set; }

        [ColumnDef(Display = "異動人員", ColSize = 3)]
        [StringLength(6)]
        public string UpdateMan { get; set; }
    }
}
