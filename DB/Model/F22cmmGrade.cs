namespace FtisHelperV2.DB.Model
{
    using Dou.Misc.Attr;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class F22cmmGrade
    {
        [Key]
        [Column(Order = 0)]
        [ColumnDef(Display = "Â¾¯Å¥N½X", Filter = true, FilterAssign = FilterAssignType.Contains, Sortable = true)]
        [StringLength(2)]
        public string GCode { get; set; }

        [Required]
        [Column(Order = 1)]
        [ColumnDef(Display = "Â¾¯Å", Filter = true, FilterAssign = FilterAssignType.Contains, Sortable = true)]
        [StringLength(20)]
        public string Grade { get; set; }
    }
}
