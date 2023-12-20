namespace FtisHelperV2.DB.Model
{
    using Dou.Misc.Attr;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using System.Data.Entity.Spatial;


    public partial class F22cmmSeat
    {
        [Key]
        [Column(Order = 0)]
        [ColumnDef(Display = "®y¦ì½s¸¹", Filter = true, FilterAssign = FilterAssignType.Contains, Sortable = true)]
        [StringLength(9)]
        public string SeatNo { get; set; }

        [ColumnDef(Display = "X", Filter = true, FilterAssign = FilterAssignType.Contains, Sortable = true)]
        public double X { get; set; }

        [ColumnDef(Display = "Y", Filter = true, FilterAssign = FilterAssignType.Contains, Sortable = true)]
        public double Y { get; set; }

        [ColumnDef(Display = "Length", Filter = true, FilterAssign = FilterAssignType.Contains, Sortable = true)]
        public double Length { get; set; }

        [ColumnDef(Display = "Weight", Filter = true, FilterAssign = FilterAssignType.Contains, Sortable = true)]
        public double Weight { get; set; }

        [ColumnDef(Display = "¼Ó¼h", Filter = true, FilterAssign = FilterAssignType.Contains, Sortable = true)]
        [StringLength(2)]
        public string Floor { get; set; }

        public List<F22cmmEmpData> EmpTmp { get; set; }
        [NotMapped]
        public F22cmmEmpData Emp
        {
            get
            {
                return EmpTmp == null ? null : EmpTmp.FirstOrDefault();
            }
        }
    }
}
