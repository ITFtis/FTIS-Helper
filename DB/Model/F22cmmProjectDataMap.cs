namespace FtisHelperV2.DB.Model
{
    using Dou.Misc.Attr;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class F22cmmProjectDataMap
    {
        [Key]
        [ColumnDef(Display = "專案編號", EditType = EditType.TextList, SelectItemsClassNamespace = PjSelectItemsClassImp.AssemblyQualifiedName,
            Filter = true, FilterAssign = FilterAssignType.Contains, Sortable = true)]
        [StringLength(9)]
        public string PrjID { get; set; }

        [ColumnDef(Display = "財務專案編號", Filter = true, FilterAssign = FilterAssignType.Contains, Sortable = true)]
        [StringLength(100)]
        public string PjNoM { get; set; }

        [ColumnDef(Display = "對應財務專案編號", EditType = EditType.TextList, SelectItemsClassNamespace = PjSelectItemsClassImp.AssemblyQualifiedName)]
        [StringLength(9)]
        public string MapPrjID { get; set; }
    }
}
