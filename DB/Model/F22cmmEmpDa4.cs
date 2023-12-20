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
    [Table("F22cmmEmpDa4")]
    public class F22cmmEmpDa4
    {
        [Key]
        [Column(Order = 0)]
        [ColumnDef(Display = "員工編號")]
        [StringLength(6)]
        public string Fno { get; set; }

        [ColumnDef(Display = "員工編號(舊)")]
        [StringLength(6)]
        public string mno { get; set; }

        [Key]
        [Column(Order = 1)]
        [ColumnDef(Display = "學位編號")]
        public byte sno { get; set; }

        [ColumnDef(Display = "學校")]
        [StringLength(50)]
        public string da401 { get; set; }

        [ColumnDef(Display = "學院")]
        [StringLength(20)]
        public string da402 { get; set; }

        [ColumnDef(Display = "科系")]
        [StringLength(50)]
        public string da403 { get; set; }

        [ColumnDef(Display = "入學年月")]
        [StringLength(6)]
        public string da404 { get; set; }

        [ColumnDef(Display = "畢業年月")]
        [StringLength(6)]
        public string da405 { get; set; }

        [ColumnDef(Display = "學位", EditType = EditType.Select,
            //SelectItems = "{\"1\":\"博士\",\"2\":\"碩士\",\"3\":\"學士\",\"4\":\"專科\",\"5\":\"高中\"}")]
            SelectItems = "{\"博士\":\"博士\",\"碩士\":\"碩士\",\"學士\":\"學士\",\"專科\":\"專科\",\"高中\":\"高中\"}")]
        [StringLength(6)]
        public string da406 { get; set; }

        [ColumnDef(Display = "指導教授")]
        [StringLength(20)]
        public string da407 { get; set; }

        [Column(TypeName = "smalldatetime")]
        [ColumnDef(Display = "異動時間")]
        public DateTime? UpdateTime { get; set; }

        [ColumnDef(Display = "異動人員")]
        [StringLength(6)]
        public string UpdateMan { get; set; }
    }
}
