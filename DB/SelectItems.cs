using Dou.Misc.Attr;
using FtisHelperV2.DB.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace FtisHelperV2.DB
{
    public class EmpSelectItemsClassImp : SelectItemsClass
    {
        public const string AssemblyQualifiedName = "FtisHelperV2.DB.EmpSelectItemsClassImp, FtisHelperV2";

        protected static IEnumerable<F22cmmEmpData> _emps;
        protected static new IEnumerable<F22cmmEmpData> EMPS
        {
            get
            {
                _emps = DouHelper.Misc.GetCache<IEnumerable<F22cmmEmpData>>(2 * 60 * 1000, AssemblyQualifiedName);
                if (_emps == null)
                {
                    _emps = FtisHelperV2.DB.Helper.GetAllEmployee().Where(s => s.Quit == false);// && s.Fno=="F01721");
                    DouHelper.Misc.AddCache(_emps, AssemblyQualifiedName);
                }
                return _emps;
            }
        }
        public override IEnumerable<KeyValuePair<string, object>> GetSelectItems()
        {
            return EMPS.Select(s => new KeyValuePair<string, object>(s.Fno, "{\"v\":\"" + s.Name + "\",\"dcode\":\"" + s.DCode + "\"}"));
        }
    }
    public class NameSelectItemsClassImp : SelectItemsClass
    {
        public const string AssemblyQualifiedName = "FtisHelperV2.DB.NameSelectItemsClassImp, FtisHelperV2";

        protected static IEnumerable<F22cmmEmpData> _emps;
        protected static new IEnumerable<F22cmmEmpData> EMPS
        {
            get
            {
                _emps = DouHelper.Misc.GetCache<IEnumerable<F22cmmEmpData>>(2 * 60 * 1000, AssemblyQualifiedName);
                if (_emps == null)
                {
                    _emps = FtisHelperV2.DB.Helper.GetAllEmployee().Where(s => s.Quit == false);// && s.Fno=="F01721");
                    DouHelper.Misc.AddCache(_emps, AssemblyQualifiedName);
                }
                return _emps;
            }
        }
        public override IEnumerable<KeyValuePair<string, object>> GetSelectItems()
        {
            return EMPS.Select(s => new KeyValuePair<string, object>(s.Name, s.Name));
        }
    }
    public class FnoSelectItemsClassImp : SelectItemsClass
    {
        public const string AssemblyQualifiedName = "FtisHelperV2.DB.FnoSelectItemsClassImp, FtisHelperV2";

        protected static IEnumerable<F22cmmEmpData> _emps;
        protected static new IEnumerable<F22cmmEmpData> EMPS
        {
            get
            {
                _emps = DouHelper.Misc.GetCache<IEnumerable<F22cmmEmpData>>(2 * 60 * 1000, AssemblyQualifiedName);
                if (_emps == null)
                {
                    _emps = Helpe.Employee.GetAllEmployee().Where(s => s.Quit == false);// && s.Fno=="F01721");
                    DouHelper.Misc.AddCache(_emps, AssemblyQualifiedName);
                }
                return _emps;
            }
        }
        public override IEnumerable<KeyValuePair<string, object>> GetSelectItems()
        {
            return EMPS.Select(s => new KeyValuePair<string, object>(s.Fno, s.Fno));
        }
    }
    public class EmpSelectAllItemsClassImp : SelectItemsClass
    {
        public const string AssemblyQualifiedName = "FtisHelperV2.DB.EmpSelectItemsClassImp, FtisHelperV2";

        protected static IEnumerable<F22cmmEmpData> _emps;
        protected static new IEnumerable<F22cmmEmpData> EMPS
        {
            get
            {
                _emps = DouHelper.Misc.GetCache<IEnumerable<F22cmmEmpData>>(2 * 60 * 1000, AssemblyQualifiedName);
                if (_emps == null)
                {
                    _emps = FtisHelperV2.DB.Helper.GetAllEmployee();// && s.Fno=="F01721");
                    DouHelper.Misc.AddCache(_emps, AssemblyQualifiedName);
                }
                return _emps;
            }
        }
        public override IEnumerable<KeyValuePair<string, object>> GetSelectItems()
        {
            return EMPS.Select(s => new KeyValuePair<string, object>(s.Fno, "{\"v\":\"" + s.Name + "\",\"dcode\":\"" + s.DCode + "\"}"));
        }
    }
    public class DepartmentSelectItemsClassImp : SelectItemsClass
    {
        public const string AssemblyQualifiedName = "FtisHelperV2.DB.DepartmentSelectItemsClassImp, FtisHelperV2";

        protected static IEnumerable<F22cmmDep> _deps;
        protected static new IEnumerable<FtisHelperV2.DB.Model.F22cmmDep> DEPS
        {
            get
            {
                _deps = DouHelper.Misc.GetCache<IEnumerable<F22cmmDep>>(2 * 60 * 1000, AssemblyQualifiedName);
                if (_deps == null)
                {
                    _deps = FtisHelperV2.DB.Helper.GetAllDepartment().Where(s => s.IsUsed == "Y");
                    DouHelper.Misc.AddCache(_deps, AssemblyQualifiedName);
                }
                return _deps;
            }
        }
        public override IEnumerable<KeyValuePair<string, object>> GetSelectItems()
        {
            return DEPS.Select(s => new KeyValuePair<string, object>(s.DCode, s.DName));
        }
    }
    public class TitleSelectItemsClassImp : SelectItemsClass
    {
        public const string AssemblyQualifiedName = "FtisHelperV2.DB.TitleSelectItemsClassImp, FtisHelperV2";

        protected static IEnumerable<F22cmmTitle> _title;
        protected static new IEnumerable<FtisHelperV2.DB.Model.F22cmmTitle> TITLES
        {
            get
            {
                _title = DouHelper.Misc.GetCache<IEnumerable<F22cmmTitle>>(2 * 60 * 1000, AssemblyQualifiedName);
                if (_title == null)
                {
                    _title = FtisHelperV2.DB.Helpe.Employee.GetAllTitle();
                    DouHelper.Misc.AddCache(_title, AssemblyQualifiedName);
                }
                return _title;
            }
        }
        public override IEnumerable<KeyValuePair<string, object>> GetSelectItems()
        {
            return TITLES.Select(s => new KeyValuePair<string, object>(s.TCode, s.Title));
        }
    }
    public class MpSelectItemsClassImp : SelectItemsClass
    {
        public const string AssemblyQualifiedName = "FtisHelperV2.DB.MpSelectItemsClassImp, FtisHelperV2";

        protected static IEnumerable<F22cmmMP> _mp;
        protected static new IEnumerable<FtisHelperV2.DB.Model.F22cmmMP> MP
        {
            get
            {
                _mp = DouHelper.Misc.GetCache<IEnumerable<F22cmmMP>>(2 * 60 * 1000, AssemblyQualifiedName);
                if (_mp == null)
                {
                    _mp = FtisHelperV2.DB.Helper.GetAllMP();
                    DouHelper.Misc.AddCache(_mp, AssemblyQualifiedName);
                }
                return _mp;
            }
        }
        public override IEnumerable<KeyValuePair<string, object>> GetSelectItems()
        {
            return MP.Select(s => new KeyValuePair<string, object>(s.MPCode, s.MPName));
        }
    }
    public class GradeSelectItemsClassImp : SelectItemsClass
    {
        public const string AssemblyQualifiedName = "FtisHelperV2.DB.GradeSelectItemsClassImp, FtisHelperV2";

        protected static IEnumerable<F22cmmGrade> _grade;
        protected static new IEnumerable<FtisHelperV2.DB.Model.F22cmmGrade> GRADE
        {
            get
            {
                _grade = DouHelper.Misc.GetCache<IEnumerable<F22cmmGrade>>(2 * 60 * 1000, AssemblyQualifiedName);
                if (_grade == null)
                {
                    _grade = FtisHelperV2.DB.Helper.GetAllGrade();
                    DouHelper.Misc.AddCache(_grade, AssemblyQualifiedName);
                }
                return _grade;
            }
        }
        public override IEnumerable<KeyValuePair<string, object>> GetSelectItems()
        {
            return GRADE.Select(s => new KeyValuePair<string, object>(s.GCode, s.Grade));
        }
    }
    public class PjSelectItemsClassImp : SelectItemsClass
    {
        public const string AssemblyQualifiedName = "FtisHelperV2.DB.PjSelectItemsClassImp, FtisHelperV2";

        protected static IEnumerable<F22cmmProjectData> _pjms;
        protected static new IEnumerable<F22cmmProjectData> PJMS
        {
            get
            {
                _pjms = DouHelper.Misc.GetCache<IEnumerable<F22cmmProjectData>>(2 * 60 * 1000, AssemblyQualifiedName);
                if (_pjms == null)
                {
                    _pjms = Helpe.Project.GetAllProject();
                    DouHelper.Misc.AddCache(_pjms, AssemblyQualifiedName);
                }
                return _pjms;
            }
        }
        public override IEnumerable<KeyValuePair<string, object>> GetSelectItems()
        {
            //return PJMS.Select(s => new KeyValuePair<string, object>(s.PrjID, "{\"v\":\"" + s.PrjName + "\"}"));
            return PJMS.Select(s => new KeyValuePair<string, object>(s.PrjID, s.PrjID));
        }
    }
}
