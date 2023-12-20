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
    [Table("F22cmmEmpDa1")]
    public class F22cmmEmpDa1
    {
        [Key]
        [ColumnDef(Display = "員工編號", ColSize = 3)]
        [StringLength(6)]
        public string Fno { get; set; }

        [ColumnDef(Display = "員工編號(舊)", ColSize = 3)]
        [StringLength(10)]
        public string mno { get; set; }

        [ColumnDef(Display = "英文姓名", Visible = false, VisibleEdit = false, ColSize = 3)]
        [StringLength(40)]
        public string da01 { get; set; }

        [Column(TypeName = "smalldatetime")]
        [ColumnDef(Display = "生日", EditType = EditType.Date, ColSize = 3)]
        public DateTime? da03 { get; set; }

        [ColumnDef(Display = "出生地", ColSize = 3)]
        [StringLength(10)]
        public string da04 { get; set; }

        [ColumnDef(Display = "身分證字號", ColSize = 3)]
        [StringLength(10)]
        public string da05 { get; set; }

        [ColumnDef(Display = "待補", Visible = false, VisibleEdit = false, ColSize = 3)]
        [StringLength(1)]
        public string da05a { get; set; }

        [Column(TypeName = "numeric")]
        [ColumnDef(Display = "身高", ColSize = 3)]
        public decimal? da06 { get; set; }

        [ColumnDef(Display = "婚姻", ColSize = 3)]
        public string da06a { get; set; }

        [Column(TypeName = "numeric")]
        [ColumnDef(Display = "體重", ColSize = 3)]
        public decimal? da07 { get; set; }

        [ColumnDef(Display = "血型", ColSize = 3)]
        [StringLength(2)]
        public string da08 { get; set; }

        [ColumnDef(Display = "戶籍地址郵遞區號", ColSize = 3)]
        [StringLength(3)]
        public string da09 { get; set; }

        [ColumnDef(Display = "戶籍地址", ColSize = 3)]
        [StringLength(100)]
        public string da10 { get; set; }

        [ColumnDef(Display = "戶籍電話區碼", ColSize = 3)]
        [StringLength(3)]
        public string da11a { get; set; }

        [ColumnDef(Display = "戶籍電話", ColSize = 3)]
        [StringLength(8)]
        public string da11 { get; set; }

        [ColumnDef(Display = "通訊地址郵遞區號", ColSize = 3)]
        [StringLength(3)]
        public string da12 { get; set; }

        [ColumnDef(Display = "通訊地址", ColSize = 3)]
        [StringLength(100)]
        public string da13 { get; set; }

        [ColumnDef(Display = "住家電話區碼", ColSize = 3)]
        [StringLength(3)]
        public string da14a { get; set; }

        [ColumnDef(Display = "住家電話", ColSize = 3)]
        [StringLength(8)]
        public string da14 { get; set; }

        [ColumnDef(Display = "行動電話", ColSize = 3)]
        [StringLength(10)]
        public string da15 { get; set; }

        [ColumnDef(Display = "緊急聯絡人1", ColSize = 3)]
        [StringLength(20)]
        public string da17 { get; set; }

        [ColumnDef(Display = "緊急聯絡人1關係", ColSize = 3)]
        [StringLength(6)]
        public string da18 { get; set; }

        [ColumnDef(Display = "緊急聯絡人1手機", ColSize = 3)]
        [StringLength(10)]
        public string da19 { get; set; }

        [ColumnDef(Display = "緊急聯絡人2", ColSize = 3)]
        [StringLength(20)]
        public string da20 { get; set; }

        [ColumnDef(Display = "緊急聯絡人2關係", ColSize = 3)]
        [StringLength(6)]
        public string da21 { get; set; }

        [ColumnDef(Display = "緊急聯絡人2手機", ColSize = 3)]
        [StringLength(10)]
        public string da22 { get; set; }

        [ColumnDef(Display = "照片", Visible = false, VisibleEdit = false, ColSize = 3)]
        [StringLength(50)]
        public string da23 { get; set; }

        [ColumnDef(Display = "專長", ColSize = 3)]
        [StringLength(500)]
        public string da24 { get; set; }

        [Column(TypeName = "smalldatetime")]
        [ColumnDef(Display = "異動時間", ColSize = 3)]
        public DateTime? UpdateTime { get; set; }

        [ColumnDef(Display = "異動人員", ColSize = 3)]
        [StringLength(6)]
        public string Updateman { get; set; }
    }
}
