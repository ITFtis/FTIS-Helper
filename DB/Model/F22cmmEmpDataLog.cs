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
        [ColumnDef(Display = "���u�s��", EditType = EditType.TextList, SelectItemsClassNamespace = FnoSelectItemsClassImp.AssemblyQualifiedName
            , Filter = true, FilterAssign = FilterAssignType.Contains, Sortable = true, ColSize = 3)]
        [StringLength(6)]
        public string Fno { get; set; }

        [Column(Order = 1)]
        [ColumnDef(Display = "���u�s��(��)", Visible = false, VisibleEdit = false, ColSize = 3)]
        [StringLength(6)]
        public string Mno { get; set; }

        [Required]
        [Column(Order = 2)]
        [ColumnDef(Display = "���u�m�W(��)", EditType = EditType.TextList, SelectItemsClassNamespace = NameSelectItemsClassImp.AssemblyQualifiedName
            , Filter = true, FilterAssign = FilterAssignType.Contains, Sortable = true, ColSize = 3)]
        [StringLength(20)]
        public string Name { get; set; }

        [ColumnDef(Display = "���u�m�W(�^)", ColSize = 3)]
        [StringLength(50)]
        public string En_Name { get; set; }

        [ColumnDef(EditType = EditType.Select, Display = "�ʧO", SelectItems = "{'�k':'�k','�k':'�k'}", DefaultValue = "", ColSize = 3)]
        [StringLength(2)]
        public string Sex { get; set; }

        [Column(Order = 3, TypeName = "smalldatetime")]
        [ColumnDef(EditType = EditType.Date, Display = "��¾��", Filter = true, FilterAssign = FilterAssignType.Between, ColSize = 3)]
        public DateTime AD { get; set; }

        [Column(Order = 4, TypeName = "smalldatetime")]
        [ColumnDef(EditType = EditType.Date, Display = "�S��_���", ColSize = 3)]
        public DateTime ADRest { get; set; }

        [Column(Order = 5, TypeName = "smalldatetime")]
        [ColumnDef(EditType = EditType.Date, Display = "�̷s�~�굲���", ColSize = 3)]
        public DateTime AD_Vacation { get; set; }

        [Column(TypeName = "smalldatetime")]
        [ColumnDef(EditType = EditType.Date, Display = "�եδ�������", ColSize = 3)]
        public DateTime? TEnddate { get; set; }

        [Column(Order = 6)]
        [ColumnDef(Display = "�O�_��¾", EditType = EditType.Select, SelectItems = "{\"Y\":\"�O\",\"N\":\"�_\"}"
            , Required = true, Filter = true, DefaultValue = "N", ColSize = 3)]
        [StringLength(1)]
        public string IsQuit { get; set; }

        [Column(Order = 7)]
        [ColumnDef(Display = "�O�_��¾", EditType = EditType.Select, Visible = false, VisibleEdit = false
            , SelectItems = "{\"true\":\"�O\",\"false\":\"�_\"}", DefaultValue = "false", ColSize = 3)]
        public bool Quit { get; set; }

        [Column(TypeName = "smalldatetime")]
        [ColumnDef(EditType = EditType.Date, Display = "��¾��", ColSize = 3)]
        public DateTime? QuitDate { get; set; }

        [Column(Order = 8)]
        [ColumnDef(Display = "����", EditType = EditType.Select, SelectItemsClassNamespace = DepartmentSelectItemsClassImp.AssemblyQualifiedName, Filter = true, ColSize = 3)]
        [StringLength(2)]
        public string DCode { get; set; }

        [Column(Order = 9)]
        [ColumnDef(Display = "¾��", EditType = EditType.Select, SelectItemsClassNamespace = TitleSelectItemsClassImp.AssemblyQualifiedName, ColSize = 3)]
        [StringLength(2)]
        public string TCode { get; set; }

        [ColumnDef(Display = "¾��(�W��)", EditType = EditType.Select, SelectItemsClassNamespace = TitleSelectItemsClassImp.AssemblyQualifiedName, ColSize = 3)]
        [StringLength(2)]
        public string TCode_Display { get; set; }

        [Column(Order = 10)]
        [ColumnDef(Display = "¾��", EditType = EditType.Select, SelectItemsClassNamespace = GradeSelectItemsClassImp.AssemblyQualifiedName, ColSize = 3)]
        [StringLength(2)]
        public string GCode { get; set; }

        [ColumnDef(Display = "�H�O����", EditType = EditType.Select, SelectItemsClassNamespace = MpSelectItemsClassImp.AssemblyQualifiedName, ColSize = 3)]
        [StringLength(1)]
        public string MpCode { get; set; }

        [Column(Order = 11)]
        [ColumnDef(Display = "�q�l�l��", ColSize = 3)]
        [StringLength(150)]
        public string EMail { get; set; }

        [Column(Order = 12)]
        [ColumnDef(Display = "�@�f�H", EditType = EditType.TextList, SelectItemsClassNamespace = EmpSelectItemsClassImp.AssemblyQualifiedName, ColSize = 3)]
        [StringLength(6)]
        public string CkNo1 { get; set; }

        [ColumnDef(Display = "�G�f�H", EditType = EditType.TextList, SelectItemsClassNamespace = EmpSelectItemsClassImp.AssemblyQualifiedName, ColSize = 3)]
        [StringLength(6)]
        public string CkNo2 { get; set; }

        [ColumnDef(Display = "�T�f�H", EditType = EditType.TextList, SelectItemsClassNamespace = EmpSelectItemsClassImp.AssemblyQualifiedName, ColSize = 3)]
        [StringLength(6)]
        public string CkNo3 { get; set; }

        [ColumnDef(Display = "�|�f�H", EditType = EditType.TextList, SelectItemsClassNamespace = EmpSelectItemsClassImp.AssemblyQualifiedName, ColSize = 3)]
        [StringLength(6)]
        public string CkNo4 { get; set; }

        [ColumnDef(Display = "���f�H", EditType = EditType.TextList, SelectItemsClassNamespace = EmpSelectItemsClassImp.AssemblyQualifiedName, ColSize = 3)]
        [StringLength(6)]
        public string CkNo5 { get; set; }

        [ColumnDef(Display = "�w�]�N�z�H", EditType = EditType.TextList, SelectItemsClassNamespace = EmpSelectItemsClassImp.AssemblyQualifiedName, ColSize = 3)]
        [StringLength(6)]
        public string AgentNo { get; set; }

        [Column(Order = 13)]
        [ColumnDef(Display = "KPI�@�f�H", EditType = EditType.TextList, SelectItemsClassNamespace = EmpSelectItemsClassImp.AssemblyQualifiedName, ColSize = 3)]
        [StringLength(6)]
        public string kpino1 { get; set; }

        [ColumnDef(Display = "KPI�G�f�H", EditType = EditType.TextList, SelectItemsClassNamespace = EmpSelectItemsClassImp.AssemblyQualifiedName, ColSize = 3)]
        [StringLength(6)]
        public string kpino2 { get; set; }

        [ColumnDef(Display = "KPI�T�f�H", EditType = EditType.TextList, SelectItemsClassNamespace = EmpSelectItemsClassImp.AssemblyQualifiedName, ColSize = 3)]
        [StringLength(6)]
        public string kpino3 { get; set; }

        [ColumnDef(Display = "KPI�|�f�H", EditType = EditType.TextList, SelectItemsClassNamespace = EmpSelectItemsClassImp.AssemblyQualifiedName, ColSize = 3)]
        [StringLength(6)]
        public string kpino4 { get; set; }


        [ColumnDef(Display = "KPI���f�H", EditType = EditType.TextList, SelectItemsClassNamespace = EmpSelectItemsClassImp.AssemblyQualifiedName, ColSize = 3)]
        [StringLength(6)]
        public string kpino5 { get; set; }

        [ColumnDef(EditType = EditType.Select, Display = "�O�_�i�� ��¾�ӽ�", SelectItems = "{'Y':'�O','N':'�_'}", DefaultValue = "N", ColSize = 3)]
        [StringLength(1)]
        public string UseQuit { get; set; }

        [ColumnDef(EditType = EditType.Select, Display = "�O�_�i�� ��¾�ӽ�", Visible = false, VisibleEdit = false
            , Sortable = true, SelectItems = "{\"true\":\"�O\",\"false\":\"�_\"}", DefaultValue = "false", ColSize = 3)]
        public bool? QuitYN { get; set; }

        [ColumnDef(Display = "��¾��s��", ColSize = 3)]
        [StringLength(7)]
        public string QuitNo { get; set; }

        [Column(Order = 14)]
        [ColumnDef(EditType = EditType.Select, Display = "�O�_�ݭn�u�W�ǲ�", SelectItems = "{'Y':'�O','N':'�_'}", DefaultValue = "N", ColSize = 3)]
        [StringLength(1)]
        public string UseTrainning { get; set; }

        [ColumnDef(EditType = EditType.Select, Display = "�O�_�ݭn�u�W�ǲ�", Visible = false, VisibleEdit = false
           , Sortable = true, SelectItems = "{\"true\":\"�O\",\"false\":\"�_\"}", DefaultValue = "false", ColSize = 3)]
        public bool? eryn { get; set; }

        [ColumnDef(EditType = EditType.Select, Display = "�[�Z�O�_�i���ɥ�", SelectItems = "{'Y':'�O','N':'�_'}", DefaultValue = "N", ColSize = 3)]
        [StringLength(1)]
        public string IsOT2V { get; set; }

        [ColumnDef(Display = "�q��", ColSize = 3)]
        [StringLength(20)]
        public string Tel { get; set; }

        [ColumnDef(Display = "����", ColSize = 3)]
        [StringLength(10)]
        public string Telext { get; set; }

        [ColumnDef(Display = "�ǯu", ColSize = 3)]
        [StringLength(20)]
        public string Fax { get; set; }

        [ColumnDef(Display = "��ʹq��", ColSize = 3)]
        [StringLength(20)]
        public string Mobile { get; set; }

        [ColumnDef(Display = "�M�u", ColSize = 3)]
        [StringLength(20)]
        public string Hotline { get; set; }

        [Column(TypeName = "image")]
        [ColumnDef(Display = "�W���Ϲ�", Visible =false, VisibleEdit = false)]
        public byte[] Headshot { get; set; }

        [ColumnDef(Display = "�j�Y��", EditType = EditType.Image,
            ImageMaxWidth = 150, ImageMaxHeight = 210, Sortable = true)]
        public string ProfilePhoto { get; set; }

        [Column(TypeName = "smalldatetime")]
        [ColumnDef(Display = "���ʮɶ�", ColSize = 3)]
        public DateTime? UpdateTime { get; set; }

        [ColumnDef(Display = "���ʤH��", VisibleEdit = false, EditType = EditType.Select, SelectItemsClassNamespace = EmpSelectItemsClassImp.AssemblyQualifiedName, ColSize = 3)]
        [StringLength(6)]
        public string UpdateMan { get; set; }

        [ColumnDef(Display = "����(��)", Visible = false, VisibleEdit = false, EditType = EditType.Select,
            SelectSourceDbContextNamespace = "FtisHelperV2.DB.FtisModelContext, FtisHelperV2",
            SelectSourceModelNamespace = "FtisHelperV2.DB.Model.F22cmmDep, FtisHelperV2",
            SelectSourceModelValueField = "DCode_",
            SelectSourceModelDisplayField = "DName", ColSize = 3)]
        [StringLength(2)]
        public string DCode_ { get; set; }

        [ColumnDef(Display = "�y��s��", Filter = true, FilterAssign = FilterAssignType.Contains, Sortable = true, ColSize = 3)]
        [StringLength(9)]
        public string SeatNo { get; set; }

        //[ColumnDef(Display = "Azure AD Account", ColSize = 3, Visible = false, VisibleEdit = false)]
        //[StringLength(150)]
        //public string Azure_AD_Account { get; set; }

        [Column(TypeName = "smalldatetime")]
        [ColumnDef(EditType = EditType.Datetime, Display = "�����ɶ�", ColSize = 3)]
        public DateTime? LogDate { get; set; }
    }
}
