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
        [ColumnDef(Display = "�����N�X", Filter = true, FilterAssign = FilterAssignType.Contains, Sortable = true, ColSize = 12)]
        [StringLength(2)]
        public string DCode { get; set; }

        [Required]
        [Column(Order = 1)]
        [ColumnDef(Display = "�����W��", Filter = true, FilterAssign = FilterAssignType.Contains, Sortable = true, ColSize = 6)]
        [StringLength(20)]
        public string DName { get; set; }

        [Required]
        [Column(Order = 2)]
        [ColumnDef(Display = "����²��", ColSize = 6)]
        [StringLength(20)]
        public string Dnickname { get; set; }

        [ColumnDef(Display = "�����W��(�^)", ColSize = 12)]
        [StringLength(50)]
        public string En_DName { get; set; }

        [ColumnDef(Display = "���ɤH1-����", EditType = EditType.Select, SelectGearingWith = "DCkNo1,Dcode", SelectItemsClassNamespace = DepartmentSelectItemsClassImp.AssemblyQualifiedName, Visible = false, ColSize = 6)]
        [StringLength(6)]
        public string DCkNo1_Dep
        { 
            get
            {
                var emp = FtisHelperV2.DB.Helper.GetEmployee(this.DCkNo1);
                return emp?.DCode;
            }
        }

        [ColumnDef(Display = "���ɤH1", EditType = EditType.TextList, SelectItemsClassNamespace = EmpSelectItemsClassImp.AssemblyQualifiedName, ColSize = 6)]
        [StringLength(6)]
        public string DCkNo1 { get; set; }

        [ColumnDef(Display = "���ɤH2-����", EditType = EditType.Select, SelectGearingWith = "DCkNo2,Dcode", SelectItemsClassNamespace = DepartmentSelectItemsClassImp.AssemblyQualifiedName, Visible = false, ColSize = 6)]
        [StringLength(6)]
        public string DCkNo2_Dep { get
            {
                var emp = FtisHelperV2.DB.Helper.GetEmployee(this.DCkNo2);
                return emp?.DCode;
            }
        }

        [ColumnDef(Display = "���ɤH2", EditType = EditType.TextList, SelectItemsClassNamespace = EmpSelectItemsClassImp.AssemblyQualifiedName, ColSize = 6)]
        [StringLength(6)]
        public string DCkNo2 { get; set; }

        [ColumnDef(Display = "���ɤH3-����", EditType = EditType.Select, SelectGearingWith = "DCkNo3,Dcode", SelectItemsClassNamespace = DepartmentSelectItemsClassImp.AssemblyQualifiedName, Visible = false, ColSize = 6)]
        [StringLength(6)]
        public string DCkNo3_Dep { get {
                var emp = FtisHelperV2.DB.Helper.GetEmployee(this.DCkNo3);
                return emp?.DCode;
            } }

        [ColumnDef(Display = "���ɤH3", EditType = EditType.TextList, SelectItemsClassNamespace = EmpSelectItemsClassImp.AssemblyQualifiedName, ColSize = 6)]
        [StringLength(6)]
        public string DCkNo3 { get; set; }

        [ColumnDef(Display = "�޲z�v-����", EditType = EditType.Select, SelectGearingWith = "DAdmino,Dcode", SelectItemsClassNamespace = DepartmentSelectItemsClassImp.AssemblyQualifiedName, Visible = false, ColSize = 6)]
        [StringLength(6)]
        public string DAdmino_Dep { get
            {
                var emp = FtisHelperV2.DB.Helper.GetEmployee(this.DAdmino);
                return emp?.DCode;
            }
        }

        [ColumnDef(Display = "�޲z�v", EditType = EditType.TextList, SelectItemsClassNamespace = EmpSelectItemsClassImp.AssemblyQualifiedName, ColSize = 6)]
        [StringLength(6)]
        public string DAdmino { get; set; }

        [ColumnDef(Display = "�̰��D��-����", EditType = EditType.Select, SelectGearingWith = "DCkTopNo,Dcode", SelectItemsClassNamespace = DepartmentSelectItemsClassImp.AssemblyQualifiedName, Visible = false, ColSize = 6)]
        [StringLength(6)]
        public string DCkTopNo_Dep { get
            {
                var emp = FtisHelperV2.DB.Helper.GetEmployee(this.DCkTopNo);
                return emp?.DCode;
            }
        }

        [ColumnDef(Display = "�̰��D��", EditType = EditType.TextList, SelectItemsClassNamespace = EmpSelectItemsClassImp.AssemblyQualifiedName, ColSize = 6)]
        [StringLength(6)]
        public string DCkTopNo { get; set; }

        [Required]
        [Column(Order = 3)]
        [ColumnDef(Display = "�ҥλP�_", EditType = EditType.Select, SelectItems = "{'Y':'�O','N':'�_'}", DefaultValue = "N", Filter = true, Sortable = true, ColSize = 6)]
        [StringLength(1)]
        public string IsUsed { get; set; }

        [Column(Order = 4)]
        [ColumnDef(Display = "�����N�X(��)", Visible = false, VisibleEdit = false, ColSize = 6)]
        [StringLength(2)]
        public string DCode_ { get; set; }

        public List<F22cmmEmpData> EmpDatas { get; set; }
    }
}
