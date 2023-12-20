namespace FtisHelperV2.DB.Model
{
    using Dou.Misc.Attr;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class F22cmmCounty
    {
        public F22cmmCounty() { }
        [Key]
        [Column(Order = 0)]
        [ColumnDef(Display = "�����^��N�X", Filter = true, FilterAssign = FilterAssignType.Contains, Sortable = true)]
        [StringLength(3)]
        public string CountyID { get; set; }

        [Required]
        [Column(Order = 1)]
        [ColumnDef(Display = "�����^��s��", Filter = true, FilterAssign = FilterAssignType.Contains, Sortable = true)]
        [StringLength(1)]
        public string CID { get; set; }

        [Required]
        [Column(Order = 2)]
        [ColumnDef(Display = "�����N�X", Filter = true, FilterAssign = FilterAssignType.Contains, Sortable = true)]
        [StringLength(5)]
        public string CountyCode { get; set; }

        [Required]
        [Column(Order = 3)]
        [ColumnDef(Display = "�����W��", Filter = true, FilterAssign = FilterAssignType.Contains, Sortable = true)]
        [StringLength(6)]
        public string CountyName { get; set; }
    }
}
