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
    [Table("F22cmmEmpDa5")]
    public class F22cmmEmpDa5
    {
        [Key]
        [Column(Order = 0)]
        [ColumnDef(Display = "員工編號", ColSize = 3)]
        [StringLength(6)]
        public string Fno { get; set; }

        [ColumnDef(Display = "員工編號", ColSize = 3)]
        [StringLength(10)]
        public string mno { get; set; }

        [Key]
        [Column(Order = 1)]
        [ColumnDef(Display = "經歷編號", ColSize = 3)]
        public byte sno { get; set; }

        [ColumnDef(Display = "服務單位", ColSize = 3)]
        [StringLength(80)]
        public string da501 { get; set; }

        [ColumnDef(Display = "職務", ColSize = 3)]
        [StringLength(50)]
        public string da502 { get; set; }

        [ColumnDef(Display = "月薪", ColSize = 3)]
        public int? da503 { get; set; }

        [ColumnDef(Display = "起始年月", ColSize = 3)]
        [StringLength(6)]
        public string da504 { get; set; }

        [ColumnDef(Display = "結束年月", ColSize = 3)]
        [StringLength(6)]
        public string da505 { get; set; }

        [ColumnDef(Display = "離職原因", ColSize = 3)]
        [StringLength(50)]
        public string da506 { get; set; }

        [Column(TypeName = "text")]
        [ColumnDef(Display = "工作內容", ColSize = 3)]
        public string da507 { get; set; }

        [Column(TypeName = "smalldatetime")]
        [ColumnDef(Display = "異動時間", ColSize = 3)]
        public DateTime? UpdateTime { get; set; }

        [ColumnDef(Display = "異動人員", ColSize = 3)]
        [StringLength(6)]
        public string UpdateMan { get; set; }
    }
}
