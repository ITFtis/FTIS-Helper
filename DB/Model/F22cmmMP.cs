namespace FtisHelperV2.DB.Model
{
    using Dou.Misc.Attr;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class F22cmmMP
    {
        [Key]
        [ColumnDef(Display = "人力分布代碼", Filter = true, FilterAssign = FilterAssignType.Contains, Sortable = true)]
        [StringLength(2)]
        public string MPCode { get; set; }

        [ColumnDef(Display = "人力分布名稱", Filter = true, FilterAssign = FilterAssignType.Contains, Sortable = true)]
        [StringLength(20)]
        public string MPName { get; set; }
    }
}
