namespace FtisHelperV2.DB.Model
{
    using Dou.Misc.Attr;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using System.Web;

    public partial class F22cmmDep
    {
        [Key]
        [Column(Order = 0)]
        [ColumnDef(Display = "场絏", Filter = true, FilterAssign = FilterAssignType.Contains, Sortable = true, ColSize = 12)]
        [StringLength(2)]
        public string DCode { get; set; }

        [Required]
        [Column(Order = 1)]
        [ColumnDef(Display = "场嘿", Filter = true, FilterAssign = FilterAssignType.Contains, Sortable = true, ColSize = 6)]
        [StringLength(20)]
        public string DName { get; set; }

        [Required]
        [Column(Order = 2)]
        [ColumnDef(Display = "场虏嘿", ColSize = 6)]
        [StringLength(20)]
        public string Dnickname { get; set; }

        [ColumnDef(Display = "场嘿(璣)", ColSize = 12)]
        [StringLength(50)]
        public string En_DName { get; set; }

        [ColumnDef(Display = "服旧1-场", EditType = EditType.Select, SelectGearingWith = "DCkNo1,Dcode", SelectItemsClassNamespace = DepartmentSelectItemsClassImp.AssemblyQualifiedName, Visible = false, ColSize = 6)]
        [StringLength(6)]
        public string DCkNo1_Dep
        { 
            get
            {
                var emp = FtisHelperV2.DB.Helper.GetEmployee(this.DCkNo1);
                return emp?.DCode;
            }
        }

        [ColumnDef(Display = "服旧1", EditType = EditType.TextList, SelectItemsClassNamespace = EmpSelectItemsClassImp.AssemblyQualifiedName, ColSize = 6)]
        [StringLength(6)]
        public string DCkNo1 { get; set; }

        [ColumnDef(Display = "服旧2-场", EditType = EditType.Select, SelectGearingWith = "DCkNo2,Dcode", SelectItemsClassNamespace = DepartmentSelectItemsClassImp.AssemblyQualifiedName, Visible = false, ColSize = 6)]
        [StringLength(6)]
        public string DCkNo2_Dep { get
            {
                var emp = FtisHelperV2.DB.Helper.GetEmployee(this.DCkNo2);
                return emp?.DCode;
            }
        }

        [ColumnDef(Display = "服旧2", EditType = EditType.TextList, SelectItemsClassNamespace = EmpSelectItemsClassImp.AssemblyQualifiedName, ColSize = 6)]
        [StringLength(6)]
        public string DCkNo2 { get; set; }

        [ColumnDef(Display = "服旧3-场", EditType = EditType.Select, SelectGearingWith = "DCkNo3,Dcode", SelectItemsClassNamespace = DepartmentSelectItemsClassImp.AssemblyQualifiedName, Visible = false, ColSize = 6)]
        [StringLength(6)]
        public string DCkNo3_Dep { get {
                var emp = FtisHelperV2.DB.Helper.GetEmployee(this.DCkNo3);
                return emp?.DCode;
            } }

        [ColumnDef(Display = "服旧3", EditType = EditType.TextList, SelectItemsClassNamespace = EmpSelectItemsClassImp.AssemblyQualifiedName, ColSize = 6)]
        [StringLength(6)]
        public string DCkNo3 { get; set; }

        [ColumnDef(Display = "恨瞶畍-场", EditType = EditType.Select, SelectGearingWith = "DAdmino,Dcode", SelectItemsClassNamespace = DepartmentSelectItemsClassImp.AssemblyQualifiedName, Visible = false, ColSize = 6)]
        [StringLength(6)]
        public string DAdmino_Dep { get
            {
                var emp = FtisHelperV2.DB.Helper.GetEmployee(this.DAdmino);
                return emp?.DCode;
            }
        }

        [ColumnDef(Display = "恨瞶畍", EditType = EditType.TextList, SelectItemsClassNamespace = EmpSelectItemsClassImp.AssemblyQualifiedName, ColSize = 6)]
        [StringLength(6)]
        public string DAdmino { get; set; }

        [ColumnDef(Display = "程蔼恨-场", EditType = EditType.Select, SelectGearingWith = "DCkTopNo,Dcode", SelectItemsClassNamespace = DepartmentSelectItemsClassImp.AssemblyQualifiedName, Visible = false, ColSize = 6)]
        [StringLength(6)]
        public string DCkTopNo_Dep { get
            {
                var emp = FtisHelperV2.DB.Helper.GetEmployee(this.DCkTopNo);
                return emp?.DCode;
            }
        }

        [ColumnDef(Display = "程蔼恨", EditType = EditType.TextList, SelectItemsClassNamespace = EmpSelectItemsClassImp.AssemblyQualifiedName, ColSize = 6)]
        [StringLength(6)]
        public string DCkTopNo { get; set; }

        [Required]
        [Column(Order = 3)]
        [ColumnDef(Display = "币ノ籔", EditType = EditType.Select, SelectItems = "{'Y':'琌','N':''}", DefaultValue = "N", Filter = true, Sortable = true, ColSize = 6)]
        [StringLength(1)]
        public string IsUsed { get; set; }

        [Column(Order = 4)]
        [ColumnDef(Display = "场絏(侣)", Visible = false, VisibleEdit = false, ColSize = 6)]
        [StringLength(2)]
        public string DCode_ { get; set; }

        public List<F22cmmEmpData> EmpDatas { get; set; }
    }
}
