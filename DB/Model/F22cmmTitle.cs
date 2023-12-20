namespace FtisHelperV2.DB.Model
{
    using Dou.Misc.Attr;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class F22cmmTitle
    {
        [Key]
        [Column(Order = 0)]
        [ColumnDef(Display = "Â¾ºÙ¥N½X", Filter = true, FilterAssign = FilterAssignType.Contains, Sortable = true)]
        [StringLength(2)]
        public string TCode { get; set; }

        [Required]
        [Column(Order = 1)]
        [ColumnDef(Display = "Â¾ºÙ(¤¤)", Filter = true, FilterAssign = FilterAssignType.Contains, Sortable = true)]
        [StringLength(20)]
        public string Title { get; set; }

        [ColumnDef(Display = "Â¾ºÙ(­^)", Filter = true, FilterAssign = FilterAssignType.Contains, Sortable = true)]
        [StringLength(50)]
        public string En_Title { get; set; }
    }
}
