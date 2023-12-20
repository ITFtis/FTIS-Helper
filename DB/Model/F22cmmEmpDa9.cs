namespace FtisHelperV2.DB.Model
{
    using Dou.Misc.Attr;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class F22cmmEmpDa9
    {
        [Key]
        [Column(Order = 0)]
        [ColumnDef(Display = "���u�s��", ColSize = 3)]
        [StringLength(6)]
        public string Fno { get; set; }

        [ColumnDef(Display = "���u�s��(��)", ColSize = 3)]
        [StringLength(6)]
        public string mno { get; set; }

        [Key]
        [Column(Order = 1)]
        [ColumnDef(Display = "�s��", ColSize = 3)]
        public byte sno { get; set; }

        [ColumnDef(Display = "�ۧ@�W��", ColSize = 3)]
        [StringLength(20)]
        public string da901 { get; set; }

        [ColumnDef(Display = "�ۧ@²��", ColSize = 3)]
        [StringLength(400)]
        public string da902 { get; set; }

        [Column(TypeName = "smalldatetime")]
        [ColumnDef(Display = "���ʮɶ�", ColSize = 3)]
        public DateTime? UpdateTime { get; set; }

        [ColumnDef(Display = "���ʤH��", ColSize = 3)]
        [StringLength(6)]
        public string UpdateMan { get; set; }
    }
}
