using Dou.Misc.Attr;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FtisHelperV2.DB.Model
{
    [Table("F22cmmEmpDa6")]
    public class F22cmmEmpDa6
    {
        [Key]
        [Column(Order = 0)]
        [ColumnDef(Display = "員工編號", ColSize = 3)]
        [StringLength(6)]
        public string Fno { get; set; }

        [ColumnDef(Display = "員工編號", ColSize = 3)]
        [StringLength(6)]
        public string mno { get; set; }

        [Key]
        [Column(Order = 1)]
        [ColumnDef(Display = "編號", ColSize = 3)]
        public byte sno { get; set; }

        [ColumnDef(Display = "稱謂", ColSize = 3)]
        [StringLength(20)]
        public string da601 { get; set; }

        [ColumnDef(Display = "姓名", ColSize = 3)]
        [StringLength(20)]
        public string da602 { get; set; }

        [ColumnDef(Display = "生日", ColSize = 3)]
        [StringLength(8)]
        public string da603 { get; set; }

        [ColumnDef(Display = "職務", ColSize = 3)]
        [StringLength(50)]
        public string da604 { get; set; }

        [ColumnDef(Display = "任職單位/在學學校", ColSize = 3)]
        [StringLength(100)]
        public string da605 { get; set; }

        [Column(TypeName = "smalldatetime")]
        [ColumnDef(Display = "異動時間", ColSize = 3)]
        public DateTime? UpdateTime { get; set; }

        [ColumnDef(Display = "異動人員", ColSize = 3)]
        [StringLength(20)]
        public string UpdateMan { get; set; }
    }
}
