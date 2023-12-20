namespace FtisHelperV2.DB.Model
{
    using Dou.Misc.Attr;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class F22cmmTown
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(8)]
        public string TownCode { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(6)]
        public string CountyName { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(5)]
        public string CountyCode { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(6)]
        public string TownName { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(3)]
        public string ZipCode { get; set; }
    }
}
