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
    [Table("F22cmmEmpDa6a")]
    public class F22cmmEmpDa6a
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

       
        public byte times { get; set; }

        [Column(TypeName = "smalldatetime")]
        [ColumnDef(Display = "啟保時間", ColSize = 3)]
        public DateTime? StartDate { get; set; }

        [Column(TypeName = "smalldatetime")]
        [ColumnDef(Display = "結束時間", ColSize = 3)]
        public DateTime? EndDate { get; set; }

        [Column(TypeName = "smalldatetime")]
        [ColumnDef(Display = "異動時間", ColSize = 3)]
        public DateTime? UpdateTime { get; set; }

        [ColumnDef(Display = "異動人員", ColSize = 3)]
        [StringLength(20)]
        public string UpdateMan { get; set; }
    }
}
