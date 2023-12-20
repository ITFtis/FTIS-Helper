using Dou.Misc.Attr;
using DouHelper;
using FtisHelperV2.DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;

namespace FtisHelperV2.DB.Model
{
    public partial class F22cmmEmpDataLog
    {
        [Key]
        [Column(Order = 0)]
        [ColumnDef(Display = "員工編號", EditType = EditType.TextList, SelectItemsClassNamespace = FnoSelectItemsClassImp.AssemblyQualifiedName
            , Filter = true, FilterAssign = FilterAssignType.Contains, Sortable = true, ColSize = 3)]
        [StringLength(6)]
        public string Fno { get; set; }

        [Column(Order = 1)]
        [ColumnDef(Display = "員工編號(舊)", Visible = false, VisibleEdit = false, ColSize = 3)]
        [StringLength(6)]
        public string Mno { get; set; }

        [Required]
        [Column(Order = 2)]
        [ColumnDef(Display = "員工姓名(中)", EditType = EditType.TextList, SelectItemsClassNamespace = NameSelectItemsClassImp.AssemblyQualifiedName
            , Filter = true, FilterAssign = FilterAssignType.Contains, Sortable = true, ColSize = 3)]
        [StringLength(20)]
        public string Name { get; set; }

        [ColumnDef(Display = "員工姓名(英)", ColSize = 3)]
        [StringLength(50)]
        public string En_Name { get; set; }

        [ColumnDef(EditType = EditType.Select, Display = "性別", SelectItems = "{'女':'女','男':'男'}", DefaultValue = "", ColSize = 3)]
        [StringLength(2)]
        public string Sex { get; set; }

        [Column(Order = 3, TypeName = "smalldatetime")]
        [ColumnDef(EditType = EditType.Date, Display = "到職日", Filter = true, FilterAssign = FilterAssignType.Between, ColSize = 3)]
        public DateTime AD { get; set; }

        [Column(Order = 4, TypeName = "smalldatetime")]
        [ColumnDef(EditType = EditType.Date, Display = "特休起算日", ColSize = 3)]
        public DateTime ADRest { get; set; }

        [Column(Order = 5, TypeName = "smalldatetime")]
        [ColumnDef(EditType = EditType.Date, Display = "最新年資結算日", ColSize = 3)]
        public DateTime AD_Vacation { get; set; }

        [Column(TypeName = "smalldatetime")]
        [ColumnDef(EditType = EditType.Date, Display = "試用期結束日", ColSize = 3)]
        public DateTime? TEnddate { get; set; }

        [Column(Order = 6)]
        [ColumnDef(Display = "是否離職", EditType = EditType.Select, SelectItems = "{\"Y\":\"是\",\"N\":\"否\"}"
            , Required = true, Filter = true, DefaultValue = "N", ColSize = 3)]
        [StringLength(1)]
        public string IsQuit { get; set; }

        [Column(Order = 7)]
        [ColumnDef(Display = "是否離職", EditType = EditType.Select, Visible = false, VisibleEdit = false
            , SelectItems = "{\"true\":\"是\",\"false\":\"否\"}", DefaultValue = "false", ColSize = 3)]
        public bool Quit { get; set; }

        [Column(TypeName = "smalldatetime")]
        [ColumnDef(EditType = EditType.Date, Display = "離職日", ColSize = 3)]
        public DateTime? QuitDate { get; set; }

        [Column(Order = 8)]
        [ColumnDef(Display = "部門", EditType = EditType.Select, SelectItemsClassNamespace = DepartmentSelectItemsClassImp.AssemblyQualifiedName, Filter = true, ColSize = 3)]
        [StringLength(2)]
        public string DCode { get; set; }

        [Column(Order = 9)]
        [ColumnDef(Display = "職稱", EditType = EditType.Select, SelectItemsClassNamespace = TitleSelectItemsClassImp.AssemblyQualifiedName, ColSize = 3)]
        [StringLength(2)]
        public string TCode { get; set; }

        [ColumnDef(Display = "職稱(名片)", EditType = EditType.Select, SelectItemsClassNamespace = TitleSelectItemsClassImp.AssemblyQualifiedName, ColSize = 3)]
        [StringLength(2)]
        public string TCode_Display { get; set; }

        [Column(Order = 10)]
        [ColumnDef(Display = "職等", EditType = EditType.Select, SelectItemsClassNamespace = GradeSelectItemsClassImp.AssemblyQualifiedName, ColSize = 3)]
        [StringLength(2)]
        public string GCode { get; set; }

        [ColumnDef(Display = "人力分布", EditType = EditType.Select, SelectItemsClassNamespace = MpSelectItemsClassImp.AssemblyQualifiedName, ColSize = 3)]
        [StringLength(1)]
        public string MpCode { get; set; }

        [Column(Order = 11)]
        [ColumnDef(Display = "電子郵件", ColSize = 3)]
        [StringLength(150)]
        public string EMail { get; set; }

        [Column(Order = 12)]
        [ColumnDef(Display = "一審人", EditType = EditType.TextList, SelectItemsClassNamespace = EmpSelectItemsClassImp.AssemblyQualifiedName, ColSize = 3)]
        [StringLength(6)]
        public string CkNo1 { get; set; }

        [ColumnDef(Display = "二審人", EditType = EditType.TextList, SelectItemsClassNamespace = EmpSelectItemsClassImp.AssemblyQualifiedName, ColSize = 3)]
        [StringLength(6)]
        public string CkNo2 { get; set; }

        [ColumnDef(Display = "三審人", EditType = EditType.TextList, SelectItemsClassNamespace = EmpSelectItemsClassImp.AssemblyQualifiedName, ColSize = 3)]
        [StringLength(6)]
        public string CkNo3 { get; set; }

        [ColumnDef(Display = "四審人", EditType = EditType.TextList, SelectItemsClassNamespace = EmpSelectItemsClassImp.AssemblyQualifiedName, ColSize = 3)]
        [StringLength(6)]
        public string CkNo4 { get; set; }

        [ColumnDef(Display = "五審人", EditType = EditType.TextList, SelectItemsClassNamespace = EmpSelectItemsClassImp.AssemblyQualifiedName, ColSize = 3)]
        [StringLength(6)]
        public string CkNo5 { get; set; }

        [ColumnDef(Display = "預設代理人", EditType = EditType.TextList, SelectItemsClassNamespace = EmpSelectItemsClassImp.AssemblyQualifiedName, ColSize = 3)]
        [StringLength(6)]
        public string AgentNo { get; set; }

        [Column(Order = 13)]
        [ColumnDef(Display = "KPI一審人", EditType = EditType.TextList, SelectItemsClassNamespace = EmpSelectItemsClassImp.AssemblyQualifiedName, ColSize = 3)]
        [StringLength(6)]
        public string kpino1 { get; set; }

        [ColumnDef(Display = "KPI二審人", EditType = EditType.TextList, SelectItemsClassNamespace = EmpSelectItemsClassImp.AssemblyQualifiedName, ColSize = 3)]
        [StringLength(6)]
        public string kpino2 { get; set; }

        [ColumnDef(Display = "KPI三審人", EditType = EditType.TextList, SelectItemsClassNamespace = EmpSelectItemsClassImp.AssemblyQualifiedName, ColSize = 3)]
        [StringLength(6)]
        public string kpino3 { get; set; }

        [ColumnDef(Display = "KPI四審人", EditType = EditType.TextList, SelectItemsClassNamespace = EmpSelectItemsClassImp.AssemblyQualifiedName, ColSize = 3)]
        [StringLength(6)]
        public string kpino4 { get; set; }


        [ColumnDef(Display = "KPI五審人", EditType = EditType.TextList, SelectItemsClassNamespace = EmpSelectItemsClassImp.AssemblyQualifiedName, ColSize = 3)]
        [StringLength(6)]
        public string kpino5 { get; set; }

        [ColumnDef(EditType = EditType.Select, Display = "是否可填 離職申請", SelectItems = "{'Y':'是','N':'否'}", DefaultValue = "N", ColSize = 3)]
        [StringLength(1)]
        public string UseQuit { get; set; }

        [ColumnDef(EditType = EditType.Select, Display = "是否可填 離職申請", Visible = false, VisibleEdit = false
            , Sortable = true, SelectItems = "{\"true\":\"是\",\"false\":\"否\"}", DefaultValue = "false", ColSize = 3)]
        public bool? QuitYN { get; set; }

        [ColumnDef(Display = "離職單編號", ColSize = 3)]
        [StringLength(7)]
        public string QuitNo { get; set; }

        [Column(Order = 14)]
        [ColumnDef(EditType = EditType.Select, Display = "是否需要線上學習", SelectItems = "{'Y':'是','N':'否'}", DefaultValue = "N", ColSize = 3)]
        [StringLength(1)]
        public string UseTrainning { get; set; }

        [ColumnDef(EditType = EditType.Select, Display = "是否需要線上學習", Visible = false, VisibleEdit = false
           , Sortable = true, SelectItems = "{\"true\":\"是\",\"false\":\"否\"}", DefaultValue = "false", ColSize = 3)]
        public bool? eryn { get; set; }

        [ColumnDef(EditType = EditType.Select, Display = "加班是否可報補休", SelectItems = "{'Y':'是','N':'否'}", DefaultValue = "N", ColSize = 3)]
        [StringLength(1)]
        public string IsOT2V { get; set; }

        [ColumnDef(Display = "電話", ColSize = 3)]
        [StringLength(20)]
        public string Tel { get; set; }

        [ColumnDef(Display = "分機", ColSize = 3)]
        [StringLength(10)]
        public string Telext { get; set; }

        [ColumnDef(Display = "傳真", ColSize = 3)]
        [StringLength(20)]
        public string Fax { get; set; }

        [ColumnDef(Display = "行動電話", ColSize = 3)]
        [StringLength(20)]
        public string Mobile { get; set; }

        [ColumnDef(Display = "專線", ColSize = 3)]
        [StringLength(20)]
        public string Hotline { get; set; }

        [Column(TypeName = "image")]
        [ColumnDef(Display = "名片圖像", Visible =false, VisibleEdit = false)]
        public byte[] Headshot { get; set; }

        [ColumnDef(Display = "大頭照", EditType = EditType.Image,
            ImageMaxWidth = 150, ImageMaxHeight = 210, Sortable = true)]
        public string ProfilePhoto { get; set; }

        [Column(TypeName = "smalldatetime")]
        [ColumnDef(Display = "異動時間", ColSize = 3)]
        public DateTime? UpdateTime { get; set; }

        [ColumnDef(Display = "異動人員", VisibleEdit = false, EditType = EditType.Select, SelectItemsClassNamespace = EmpSelectItemsClassImp.AssemblyQualifiedName, ColSize = 3)]
        [StringLength(6)]
        public string UpdateMan { get; set; }

        [ColumnDef(Display = "部門(舊)", Visible = false, VisibleEdit = false, EditType = EditType.Select,
            SelectSourceDbContextNamespace = "FtisHelperV2.DB.FtisModelContext, FtisHelperV2",
            SelectSourceModelNamespace = "FtisHelperV2.DB.Model.F22cmmDep, FtisHelperV2",
            SelectSourceModelValueField = "DCode_",
            SelectSourceModelDisplayField = "DName", ColSize = 3)]
        [StringLength(2)]
        public string DCode_ { get; set; }

        [ColumnDef(Display = "座位編號", Filter = true, FilterAssign = FilterAssignType.Contains, Sortable = true, ColSize = 3)]
        [StringLength(9)]
        public string SeatNo { get; set; }

        //[ColumnDef(Display = "Azure AD Account", ColSize = 3, Visible = false, VisibleEdit = false)]
        //[StringLength(150)]
        //public string Azure_AD_Account { get; set; }

        [Column(TypeName = "smalldatetime")]
        [ColumnDef(EditType = EditType.Datetime, Display = "紀錄時間", ColSize = 3)]
        public DateTime? LogDate { get; set; }
    }
}

