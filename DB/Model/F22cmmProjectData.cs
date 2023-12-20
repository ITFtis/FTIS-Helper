using Dou.Misc.Attr;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Core.Metadata.Edm;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FtisHelperV2.DB.Model
{
    [Table("F22cmmProjectData")]
    public class F22cmmProjectData
    {
        //20230516, add by markhong
        [ColumnDef(Display = "年度", Filter = true, FilterAssign = FilterAssignType.Equal, Sortable = true)]
        public virtual int PrjYear { get; set; }

        [Key]
        [StringLength(9)]
        [ColumnDef(Display ="專案編號", Filter = true, FilterAssign = FilterAssignType.Contains, ColSize = 3)]
        public string PrjID { get; set; }

        [Required]
        [StringLength(10)]
        [ColumnDef(Display = "舊專案編號", Filter =true, FilterAssign = FilterAssignType.Contains, ColSize = 3)]
        public string PjNo { get; set; }

        [Required]
        [StringLength(100)]
        [ColumnDef(Display = "專案名稱(全名)",Filter = true, FilterAssign = FilterAssignType.Contains, ColSize = 3)]
        public string PrjName { get; set; }

        [StringLength(20)]
        [ColumnDef(Display = "專案名稱(簡稱)", ColSize = 3)]
        public string BriefName { get; set; }

        //[StringLength(1)]
        //[ColumnDef(Filter = true, Display = "狀態", EditType = EditType.Select //備案中、未得標、執行中
        //public string Status { get; set; }

        [Required]
        [StringLength(50)]
        [ColumnDef(Display = "委辦單位(業主)", ColSize = 3)]
        public string OwnerA { get; set; }

        [StringLength(50)]
        [ColumnDef(Display = "簽約單位(上包)", ColSize = 3)]
        public string OwnerB { get; set; }

        [Required]
        [ColumnDef(Display = "專案執行狀態", EditType = EditType.Select, SelectItems = "{\"1\":\"備案中\",\"2\":\"未得標\",\"3\":\"執行中\"}", ColSize = 3)]//備案中、未得標、執行中
        public int PrjStatus { get; set; }

        [Required]
        [ColumnDef(Display = "是否有備標作業", EditType = EditType.Radio, SelectItems = "{\"true\":\"是\",\"false\":\"否\"}", DefaultValue = "true", ColSize = 3)]
        public bool IsPre { get; set; }

        //20230511, add by markhong
        [Column(TypeName = "date")]
        [ColumnDef(Display = "備標起始日期", EditType = EditType.Date, Sortable = true, ColSize = 3)]
        public DateTime? PreStartdate { get; set; }

        //20230511, add by markhong
        [Column(TypeName = "date")]
        [ColumnDef(Display = "備標終止日期", EditType = EditType.Date, Sortable = true, ColSize = 3)]
        public DateTime? PreEnddate { get; set; }

        //20230511, edit by markhong
        [Column(TypeName = "date")]
        [ColumnDef(Display = "專案起始日期", EditType = EditType.Date, Sortable =true, ColSize = 3)]
        public DateTime? PrjStartDate { get; set; }

        //20230511, edit by markhong
        [Column(TypeName = "date")]
        [ColumnDef(Display = "專案終止日期", EditType = EditType.Date, Sortable = true, ColSize = 3)]
        public DateTime? PrjEndDate { get; set; }

        [ColumnDef(Display = "部門1", Visible = false, VisibleEdit = true, 
            EditType = EditType.Select, SelectGearingWith = "CkNo1,Dcode", 
            SelectItemsClassNamespace = DepartmentSelectItemsClassImp.AssemblyQualifiedName, ColSize = 3)]
        public string Dep1
        {
            get
            {
                if (String.IsNullOrEmpty(CkNo1))
                    return null;
                var emp = FtisHelperV2.DB.Helper.GetEmployee(this.CkNo1);
                return emp?.DCode;
            }
        }

        [Required]
        [StringLength(6)]
        [ColumnDef(Display = "審核人1", Filter =true, EditType = EditType.TextList, 
            SelectItemsClassNamespace = EmpSelectItemsClassImp.AssemblyQualifiedName, ColSize = 3)]
        public string CkNo1 { get; set; }

        //[Required]
        [StringLength(10)]
        [ColumnDef(Visible = false, VisibleEdit = false)]
        public string CkName1 { get; set; }

        [ColumnDef(Display = "部門2", Visible = false, VisibleEdit = true, 
            EditType = EditType.Select, SelectGearingWith = "CkNo2,Dcode", 
            SelectItemsClassNamespace = DepartmentSelectItemsClassImp.AssemblyQualifiedName, ColSize = 3)]
        public string Dep2
        {
            get
            {
                if (String.IsNullOrEmpty(CkNo2))
                    return null;
                var emp = FtisHelperV2.DB.Helper.GetEmployee(this.CkNo2);
                return emp?.DCode;
            }
        }

        [StringLength(6)]
        [ColumnDef(Display = "審核人2", EditType = EditType.TextList, 
            SelectItemsClassNamespace = EmpSelectItemsClassImp.AssemblyQualifiedName, ColSize = 3)]
        public string CkNo2 { get; set; }

        [StringLength(10)]
        [ColumnDef(Visible =false, VisibleEdit =false)]
        public string CkName2 { get; set; }


        [ColumnDef(Display = "部門3", Visible = false, VisibleEdit = true, 
            EditType = EditType.Select, SelectGearingWith = "CkNo3,Dcode", 
            SelectItemsClassNamespace = DepartmentSelectItemsClassImp.AssemblyQualifiedName, ColSize = 3)]
        public string Dep3
        {
            get
            {
                if (String.IsNullOrEmpty(CkNo3))
                    return null;
                var emp = FtisHelperV2.DB.Helper.GetEmployee(this.CkNo3);
                return emp?.DCode;
            }
        }

        [StringLength(6)]
        [ColumnDef(Display = "審核人3", EditType = EditType.TextList, 
            SelectItemsClassNamespace = EmpSelectItemsClassImp.AssemblyQualifiedName, ColSize = 3)]
        public string CkNo3 { get; set; }

        [StringLength(10)]
        [ColumnDef(Visible = false, VisibleEdit = false)]
        public string CkName3 { get; set; }

        [ColumnDef(Display = "部門4", Visible = false, VisibleEdit = true, 
            EditType = EditType.Select, SelectGearingWith = "CkNo4,Dcode", 
            SelectItemsClassNamespace = DepartmentSelectItemsClassImp.AssemblyQualifiedName, ColSize = 3)]
        public string Dep4
        {
            get
            {
                if (String.IsNullOrEmpty(CkNo4))
                    return null;
                var emp = FtisHelperV2.DB.Helper.GetEmployee(this.CkNo4);
                return emp?.DCode;
            }
        }

        [StringLength(6)]
        [ColumnDef(Display = "審核人4", EditType = EditType.TextList, 
            SelectItemsClassNamespace = EmpSelectItemsClassImp.AssemblyQualifiedName, ColSize = 3)]
        public string CkNo4 { get; set; }

        [StringLength(10)]
        [ColumnDef(Visible = false, VisibleEdit = false)]
        public string CkName4 { get; set; }

        [ColumnDef(Display = "部門5", Visible = false, VisibleEdit = true, 
            EditType = EditType.Select, SelectGearingWith = "CkNo5,Dcode", 
            SelectItemsClassNamespace = DepartmentSelectItemsClassImp.AssemblyQualifiedName, ColSize = 3)]
        public string Dep5
        {
            get
            {
                if (String.IsNullOrEmpty(CkNo5))
                    return null;
                var emp = FtisHelperV2.DB.Helper.GetEmployee(this.CkNo5);
                return emp?.DCode;
            }
        }

        [StringLength(6)]
        [ColumnDef(Display = "審核人5", EditType = EditType.TextList, 
            SelectItemsClassNamespace = EmpSelectItemsClassImp.AssemblyQualifiedName, ColSize = 3)]
        public string CkNo5 { get; set; }

        [StringLength(10)]
        [ColumnDef(Visible = false, VisibleEdit = false)]
        public string CkName5 { get; set; }

        [Required]
        [ColumnDef(Display = "是否加班費用報銷", EditType = EditType.Radio, SelectItems = "{\"true\":\"是\",\"false\":\"否\"}", DefaultValue = "false", ColSize = 3)]
        public bool IsOnOT { get; set; }

        [Required]
        [ColumnDef(Display = "是否業務費用報銷", EditType = EditType.Radio, SelectItems = "{\"true\":\"是\",\"false\":\"否\"}", DefaultValue = "false", ColSize = 3)]
        public bool IsOnSale { get; set; }

        [StringLength(1)]
        [ColumnDef(Filter = true, Display = "結案狀態", Visible = false, VisibleEdit = false, EditType = EditType.Select, SelectItems = "{\"Y\":\"結案\",\"N\":\"未結案\"}", ColSize = 3)]
        public string FilterIsClosed
        {
            get
            {
                return this.IsClosed;
            }
        }

        [Required]
        [StringLength(1)]
        [ColumnDef(Filter =true, Display = "結案狀態", EditType = EditType.Radio, SelectItems = "{\"Y\":\"結案\",\"N\":\"未結案\"}", DefaultValue = "N", ColSize = 3)]
        public string IsClosed { get; set; }

        [Required]
        [ColumnDef(Display = "結案狀態(舊)", EditType = EditType.Radio, SelectItems = "{\"true\":\"結案\",\"false\":\"未結案\"}", DefaultValue = "false", ColSize = 3)]
        public bool PjClose { get; set; }

        [Required]
        [StringLength(1)]
        [ColumnDef(Display = "環資月報移轉專案", EditType = EditType.Radio, SelectItems = "{\"Y\":\"是\",\"N\":\"否\"}", DefaultValue = "N", ColSize = 3)]
        public string PCheck { get; set; }

        [StringLength(1)]
        //[ColumnDef(Visible = false, VisibleEdit = false)]
        [ColumnDef(Display = "特定專案對假日工時控制欄位", ColSize = 3)]
        public string HDYOT { get; set; }

        [Required]
        [StringLength(1)]
        [ColumnDef(Display = "報表含括指標欄位", EditType = EditType.Radio, SelectItems = "{\"Y\":\"是\",\"N\":\"否\"}", DefaultValue = "N", ColSize = 3)]
        public string ckrpt { get; set; }

        [StringLength(20)]
        [ColumnDef(Display = "財務專案編號", ColSize = 6)]
        public string PjNoM { get; set; }

        [StringLength(100)]
        [ColumnDef(Display = "財務專案名稱",EditType = EditType.TextArea)]
        public string PjNameM { get; set; }

        [Required]
        [StringLength(1)]
        [ColumnDef(Display = "公出報帳是否啟用", EditType = EditType.Radio, SelectItems = "{\"Y\":\"是\",\"N\":\"否\"}", DefaultValue = "N", ColSize = 3)]
        public string PjUseM { get; set; }

        [StringLength(200)]
        [ColumnDef(Display = "公出報帳是否啟用備註", ColSize = 3)]
        public string PjUseMRemark { get; set; }
    }
}
