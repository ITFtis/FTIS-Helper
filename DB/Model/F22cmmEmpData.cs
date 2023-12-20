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
    public partial class F22cmmEmpData
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

        [ColumnDef(Display = "一審人-部門", EditType = EditType.Select, SelectGearingWith = "CkNo1,Dcode", SelectItemsClassNamespace = DepartmentSelectItemsClassImp.AssemblyQualifiedName, Visible = false, ColSize = 3)]
        [StringLength(6)]
        public string CkNo1_Dep
        {
            get
            {
                var emp = FtisHelperV2.DB.Helpe.Employee.GetEmployee(this.CkNo1);
                return emp?.DCode;
            }
        }

        [Column(Order = 12)]
        [ColumnDef(Display = "一審人", EditType = EditType.TextList, SelectItemsClassNamespace = EmpSelectItemsClassImp.AssemblyQualifiedName, ColSize = 3)]
        [StringLength(6)]
        public string CkNo1 { get; set; }

        [ColumnDef(Display = "二審人-部門", EditType = EditType.Select, SelectGearingWith = "CkNo2,Dcode", SelectItemsClassNamespace = DepartmentSelectItemsClassImp.AssemblyQualifiedName, Visible = false, ColSize = 3)]
        [StringLength(6)]
        public string CkNo2_Dep
        {
            get
            {
                var emp = FtisHelperV2.DB.Helper.GetEmployee(this.CkNo2);
                return emp?.DCode;
            }
        }

        [ColumnDef(Display = "二審人", EditType = EditType.TextList, SelectItemsClassNamespace = EmpSelectItemsClassImp.AssemblyQualifiedName, ColSize = 3)]
        [StringLength(6)]
        public string CkNo2 { get; set; }

        [ColumnDef(Display = "三審人-部門", EditType = EditType.Select, SelectGearingWith = "CkNo3,Dcode", SelectItemsClassNamespace = DepartmentSelectItemsClassImp.AssemblyQualifiedName, Visible = false, ColSize = 3)]
        [StringLength(6)]
        public string CkNo3_Dep
        {
            get
            {
                var emp = FtisHelperV2.DB.Helper.GetEmployee(this.CkNo3);
                return emp?.DCode;
            }
        }

        [ColumnDef(Display = "三審人", EditType = EditType.TextList, SelectItemsClassNamespace = EmpSelectItemsClassImp.AssemblyQualifiedName, ColSize = 3)]
        [StringLength(6)]
        public string CkNo3 { get; set; }

        [ColumnDef(Display = "四審人-部門", EditType = EditType.Select, SelectGearingWith = "CkNo4,Dcode", SelectItemsClassNamespace = DepartmentSelectItemsClassImp.AssemblyQualifiedName, Visible = false, ColSize = 3)]
        [StringLength(6)]
        public string CkNo4_Dep
        {
            get
            {
                var emp = FtisHelperV2.DB.Helper.GetEmployee(this.CkNo4);
                return emp?.DCode;
            }
        }

        [ColumnDef(Display = "四審人", EditType = EditType.TextList, SelectItemsClassNamespace = EmpSelectItemsClassImp.AssemblyQualifiedName, ColSize = 3)]
        [StringLength(6)]
        public string CkNo4 { get; set; }

        [ColumnDef(Display = "五審人-部門", EditType = EditType.Select, SelectGearingWith = "CkNo5,Dcode", SelectItemsClassNamespace = DepartmentSelectItemsClassImp.AssemblyQualifiedName, Visible = false, ColSize = 3)]
        [StringLength(6)]
        public string CkNo5_Dep
        {
            get
            {
                var emp = FtisHelperV2.DB.Helper.GetEmployee(this.CkNo5);
                return emp?.DCode;
            }
        }

        [ColumnDef(Display = "五審人", EditType = EditType.TextList, SelectItemsClassNamespace = EmpSelectItemsClassImp.AssemblyQualifiedName, ColSize = 3)]
        [StringLength(6)]
        public string CkNo5 { get; set; }

        [ColumnDef(Display = "預設代理人-部門", EditType = EditType.Select, SelectGearingWith = "AgentNo,Dcode", SelectItemsClassNamespace = DepartmentSelectItemsClassImp.AssemblyQualifiedName, Visible = false, ColSize = 3)]
        [StringLength(6)]
        public string AgentNo_Dep
        {
            get
            {
                var emp = FtisHelperV2.DB.Helper.GetEmployee(this.AgentNo);
                return emp?.DCode;
            }
        }

        [ColumnDef(Display = "預設代理人", EditType = EditType.TextList, SelectItemsClassNamespace = EmpSelectItemsClassImp.AssemblyQualifiedName, ColSize = 3)]
        [StringLength(6)]
        public string AgentNo { get; set; }

        [ColumnDef(Display = "KPI一審人-部門", EditType = EditType.Select, SelectGearingWith = "kpino1,Dcode", SelectItemsClassNamespace = DepartmentSelectItemsClassImp.AssemblyQualifiedName, Visible = false, ColSize = 3)]
        [StringLength(6)]
        public string kpino1_Dep
        {
            get
            {
                var emp = FtisHelperV2.DB.Helper.GetEmployee(this.kpino1);
                return emp?.DCode;
            }
        }

        [Column(Order = 13)]
        [ColumnDef(Display = "KPI一審人", EditType = EditType.TextList, SelectItemsClassNamespace = EmpSelectItemsClassImp.AssemblyQualifiedName, ColSize = 3)]
        [StringLength(6)]
        public string kpino1 { get; set; }

        [ColumnDef(Display = "KPI二審人-部門", EditType = EditType.Select, SelectGearingWith = "kpino2,Dcode", SelectItemsClassNamespace = DepartmentSelectItemsClassImp.AssemblyQualifiedName, Visible = false, ColSize = 3)]
        [StringLength(6)]
        public string kpino2_Dep
        {
            get
            {
                var emp = FtisHelperV2.DB.Helper.GetEmployee(this.kpino2);
                return emp?.DCode;
            }
        }

        [ColumnDef(Display = "KPI二審人", EditType = EditType.TextList, SelectItemsClassNamespace = EmpSelectItemsClassImp.AssemblyQualifiedName, ColSize = 3)]
        [StringLength(6)]
        public string kpino2 { get; set; }

        [ColumnDef(Display = "KPI三審人-部門", EditType = EditType.Select, SelectGearingWith = "kpino3,Dcode", SelectItemsClassNamespace = DepartmentSelectItemsClassImp.AssemblyQualifiedName, Visible = false, ColSize = 3)]
        [StringLength(6)]
        public string kpino3_Dep
        {
            get
            {
                var emp = FtisHelperV2.DB.Helper.GetEmployee(this.kpino3);
                return emp?.DCode;
            }
        }

        [ColumnDef(Display = "KPI三審人", EditType = EditType.TextList, SelectItemsClassNamespace = EmpSelectItemsClassImp.AssemblyQualifiedName, ColSize = 3)]
        [StringLength(6)]
        public string kpino3 { get; set; }

        [ColumnDef(Display = "KPI四審人-部門", EditType = EditType.Select, SelectGearingWith = "kpino4,Dcode", SelectItemsClassNamespace = DepartmentSelectItemsClassImp.AssemblyQualifiedName, Visible = false, ColSize = 3)]
        [StringLength(6)]
        public string kpino4_Dep
        {
            get
            {
                var emp = FtisHelperV2.DB.Helper.GetEmployee(this.kpino4);
                return emp?.DCode;
            }
        }

        [ColumnDef(Display = "KPI四審人", EditType = EditType.TextList, SelectItemsClassNamespace = EmpSelectItemsClassImp.AssemblyQualifiedName, ColSize = 3)]
        [StringLength(6)]
        public string kpino4 { get; set; }

        [ColumnDef(Display = "KPI五審人-部門", EditType = EditType.Select, SelectGearingWith = "kpino5,Dcode", SelectItemsClassNamespace = DepartmentSelectItemsClassImp.AssemblyQualifiedName, Visible = false, ColSize = 3)]
        [StringLength(6)]
        public string kpino5_Dep
        {
            get
            {
                var emp = FtisHelperV2.DB.Helper.GetEmployee(this.kpino5);
                return emp?.DCode;
            }
        }

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

        [ColumnDef(EditType = EditType.Select, Display = "是否需繳勞保費", SelectItems = "{'Y':'是','N':'否'}", DefaultValue = "Y", ColSize = 3)]
        [StringLength(1)]
        public string InsuranceYN { set; get; }

        [StringLength(1)]
        public string Insurance01 { set; get; }

        [ColumnDef(EditType = EditType.Select, Display = "是否自提退休金", SelectItems = "{'Y':'是','N':'否'}", DefaultValue = "N", ColSize = 3)]
        [StringLength(1)]
        public string PensionYN { set; get; }

        [ColumnDef(Display = "自提退休金比例", DefaultValue = "0", ColSize = 3)]
        public Nullable<byte> PensionRate { set; get; }


        //[ColumnDef(Display = "Azure AD Account", ColSize = 3, Visible = false, VisibleEdit = false)]
        //[StringLength(150)]
        //public string Azure_AD_Account { get; set; }

        public virtual F22cmmEmpDa1 Da1s
        {
            get
            {
                var EmpDa1 = Helpe.Employee.GetAllF22cmmEmpDa1().Where(a => a.Fno == this.Fno).FirstOrDefault();
                return EmpDa1;
            }
        }
        public virtual ICollection<F22cmmEmpDa4> Da4s
        {
            get
            {
                var EmpDa4 = Helpe.Employee.GetAllF22cmmEmpDa4().Where(a => a.Fno == this.Fno).ToList();
                return EmpDa4;
            }
        }
        public virtual ICollection<F22cmmEmpDa5> Da5s
        {
            get
            {
                var EmpDa5 = Helpe.Employee.GetAllF22cmmEmpDa5().Where(a => a.Fno == this.Fno).ToList();
                return EmpDa5;
            }
        }
        public virtual ICollection<F22cmmEmpDa6> Da6s
        {
            get
            {
                var EmpDa6 = Helpe.Employee.GetAllF22cmmEmpDa6().Where(a => a.Fno == this.Fno).ToList();
                return EmpDa6;
            }
        }
        public virtual ICollection<F22cmmEmpDa7> Da7s
        {
            get
            {
                var EmpDa7 = Helpe.Employee.GetAllF22cmmEmpDa7().Where(a => a.Fno == this.Fno).ToList();
                return EmpDa7;
            }
        }
        public virtual ICollection<F22cmmEmpDa8> Da8s
        {
            get
            {
                var EmpDa8 = Helpe.Employee.GetAllF22cmmEmpDa8().Where(a => a.Fno == this.Fno).ToList();
                return EmpDa8;
            }
        }
        public virtual ICollection<F22cmmEmpDa9> Da9s
        {
            get
            {
                var EmpDa9 = Helpe.Employee.GetAllF22cmmEmpDa9().Where(a => a.Fno == this.Fno).ToList();
                return EmpDa9;
            }
        }
        //public List<F22cmmEmpDa4> Da4s { get; set; }

        /**
         * 為符合現在Schema設計Detail已有Fno，
         * 位於1-1的detail,F22cmmEmpData1不在增加欄位,
         * 全部detail接用1-多方式定義,如需要介面再多一個僅get屬性回傳單一detail(如Seat)
        **/

        //public List<F22cmmEmpDa1> Da1Tmp { get; set; }
        //public F22cmmEmpDa1 Da1
        //{
        //    get
        //    {
        //        return Da1Tmp.FirstOrDefault();
        //    }
        //}
        //public List<F22cmmEmpDa4> Da4 { get; set; }
        //[ForeignKey("Fno")] 
        //public  List<F22cmmSeat> SeatsTmp { get; set; }
        //[NotMapped]
        //public F22cmmSeat Seat
        //{
        //    get
        //    {
        //        return SeatsTmp == null ? null : SeatsTmp.FirstOrDefault();
        //    }
        //}

    }
}

