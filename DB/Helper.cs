using FtisHelperV2.DB.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FtisHelperV2.DB
{
    public class Helper
    {
        internal const int longcacheduration = 30 * 60 * 1000;
        internal const int shortcacheduration = 5 * 60 * 1000;
        internal const int onemincacheduration = 1 * 60 * 1000;

        static object lockGetAllEmployee = new object();
        static object lockGetAllMP = new object();
        static object lockGetAllGrade = new object();
        static object lockGetAllDepartment = new object();
        static object lockGetAllPrj = new object();
        static object lockGetAllF22cmmEmpDa4 = new object();

        /// <summary>
        /// 建立DBContext-FtisModelContext
        /// </summary>
        /// <param name="printlog">是否debug視窗輸出T-SQL</param>
        /// <returns>FtisModelContext</returns>
        public static FtisModelContext CreateFtisModelContext(bool printlog = false)
        {
            return FtisHelperV2.DB.FtisModelContext.Create(printlog);
        }

        /// <summary>
        /// 取所有員工資料
        /// </summary>
        /// <param name="cachetimer">資料快取時間(毫秒),預設30分</param>
        /// <returns>IEnumerable<Employee></returns>
        public static IEnumerable<F22cmmEmpData> GetAllEmployee(int cachetimer = shortcacheduration)
        {
            string key = "FTIS_ALL_F22cmmEmpData";
            var allEmployee = DouHelper.Misc.GetCache<IEnumerable<F22cmmEmpData>>(cachetimer, key);
            lock (lockGetAllEmployee)
            {
                if (allEmployee == null)
                {
                    using (var cxt = CreateFtisModelContext())
                    {
                        allEmployee = cxt.F22cmmEmpData.ToArray();
                        DouHelper.Misc.AddCache(allEmployee, key);
                    }
                }
            }
            return allEmployee;
        }

        public static void ResetGetAllEmployee()
        {
            string key = "FTIS_ALL_F22cmmEmpData";
            DouHelper.Misc.ClearCache(key);
        }

        /// <summary>
        /// 依Mno取Employee最高學歷
        /// </summary>
        /// <param name="uid">員工編號</param>
        /// <param name="cachetimer">資料快取時間(毫秒),預設30分</param>
        /// <returns>Employee</returns>
        public static F22cmmEmpDa4 GetEmployeeMaxDa4(string Fno, int cachetimer = shortcacheduration)
        {
            if (string.IsNullOrEmpty(Fno))
                return null;
            string key = "AllF22cmmEmpDa4";
            var all = DouHelper.Misc.GetCache<IEnumerable<F22cmmEmpDa4>>(cachetimer, key);
            if (all == null)
            {
                all = CreateFtisModelContext().F22cmmEmpDa4.ToArray();
                DouHelper.Misc.AddCache(all, key);
            }
            return all.FirstOrDefault(m => m.Fno == Fno && m.sno ==1);
        }

        /// <summary>
        /// 依Fno取F22cmmTitle職稱
        /// </summary>
        /// <param name="uid">員工編號</param>
        /// <param name="cachetimer">資料快取時間(毫秒),預設30分</param>
        /// <returns>Employee</returns>
        public static F22cmmTitle GetEmployeeTitle(string Fno, int cachetimer = shortcacheduration)
        {
            if (string.IsNullOrEmpty(Fno))
                return null;
            string key = "AllF22cmmTitle";
            var all = DouHelper.Misc.GetCache<IEnumerable<F22cmmTitle>>(cachetimer, key);
            if (all == null)
            {
                all = CreateFtisModelContext().F22cmmTitle.ToArray();
                DouHelper.Misc.AddCache(all, key);
            }
            var e = GetEmployee(Fno);
            if (e == null) return null;
            return all.FirstOrDefault(m => m.TCode == e.TCode);
        }

        /// <summary>
        /// 取全部F22cmmMP人力分布
        /// </summary>
        /// <param name="cachetimer">資料快取時間(毫秒),預設30分</param>
        /// <returns>Employee</returns>
        public static IEnumerable<F22cmmMP> GetAllMP(int cachetimer = shortcacheduration)
        {
            string key = "All_F22cmmMP";
            var allMP = DouHelper.Misc.GetCache<IEnumerable<F22cmmMP>>(cachetimer, key);
            lock (lockGetAllMP)
            {
                if (allMP == null)
                {
                    using (var cxt = CreateFtisModelContext())
                    {
                        allMP = cxt.F22cmmMP.ToArray();
                        DouHelper.Misc.AddCache(allMP, key);
                    }
                }
            }
            return allMP;
        }

        /// <summary>
        /// 取全部F22cmmGrade職等
        /// </summary>
        /// <param name="cachetimer">資料快取時間(毫秒),預設30分</param>
        /// <returns>Employee</returns>
        public static IEnumerable<F22cmmGrade> GetAllGrade(int cachetimer = shortcacheduration)
        {
            string key = "All_F22cmmGrade";
            var allGrade = DouHelper.Misc.GetCache<IEnumerable<F22cmmGrade>>(cachetimer, key);
            lock (lockGetAllGrade)
            {
                if (allGrade == null)
                {
                    using (var cxt = CreateFtisModelContext())
                    {
                        allGrade = cxt.F22cmmGrade.ToArray();
                        DouHelper.Misc.AddCache(allGrade, key);
                    }
                }
            }
            return allGrade;
        }

        /// <summary>
        /// 依Fno取Employee
        /// </summary>
        /// <param name="Fno">員工編號</param>
        /// <param name="cachetimer">資料快取時間(毫秒),預設30分</param>
        /// <returns>Employee</returns>
        public static F22cmmEmpData GetEmployee(string Fno, int cachetimer = shortcacheduration)
        {
            if (string.IsNullOrEmpty(Fno))
                return null;
            return GetAllEmployee(cachetimer).FirstOrDefault(m => m.Fno == Fno);
        }

        /// <summary>
        /// 取所有部門資料
        /// </summary>
        /// <param name="cachetimer">資料快取時間(毫秒),預設30分</param>
        /// <returns>IEnumerable<Department></returns>
        public static IEnumerable<F22cmmDep> GetAllDepartment(int cachetimer = longcacheduration)
        {

            string key = "FTIS_ALL_Department";
            var alllDepartment = DouHelper.Misc.GetCache<IEnumerable<F22cmmDep>>(cachetimer, key);
            //alllDepartment = null;
            lock (lockGetAllDepartment)
            {
                if (alllDepartment == null)
                {
                    using (var cxt = CreateFtisModelContext())
                    {
                        alllDepartment = cxt.F22cmmDep.ToArray();
                        DouHelper.Misc.AddCache(alllDepartment, key);
                    }
                }
            }
            return alllDepartment;
        }

        /// <summary>
        /// 依部門編號取部門資料
        /// </summary>
        /// <param name="DCode"></param>
        /// <param name="cachetimer"></param>
        /// <returns></returns>
        public static F22cmmDep GetDepartment(string DCode, int cachetimer = shortcacheduration)
        {
            if (string.IsNullOrEmpty(DCode))
                return null;
            return GetAllDepartment(cachetimer).FirstOrDefault(m => m.DCode == DCode);
        }

        /// <summary>
        /// 取所有專案資料
        /// </summary>
        /// <param name="cachetimer">資料快取時間(毫秒),預設30分</param>
        /// <returns>IEnumerable<F22cmmProjectData></returns>
        public static IEnumerable<F22cmmProjectData> GetAllProject(int cachetimer = shortcacheduration)
        {

            string key = "FTIS_ALL_ProjectData";
            var allDatas = DouHelper.Misc.GetCache<IEnumerable<F22cmmProjectData>>(cachetimer, key);
            lock (lockGetAllPrj)
            {
                if (allDatas == null)
                {
                    using (var cxt = CreateFtisModelContext())
                    {
                        allDatas = cxt.F22cmmProjectData.Where(s=>s.PrjID != null).ToArray();
                        DouHelper.Misc.AddCache(allDatas, key);
                    }
                }
            }
            return allDatas;
        }

        /// <summary>
        /// 依PrjID取ProjectData資料
        /// </summary>
        /// <param name="PrjID">員工標號</param>
        /// <param name="cachetimer"></param>
        /// <returns></returns>
        public static F22cmmProjectData GetProject(string PrjID, int cachetimer = shortcacheduration)
        {
            if (string.IsNullOrEmpty(PrjID))
                return null;
            return GetAllProject(cachetimer).FirstOrDefault(m => m.PrjID == PrjID);
        }
    }
}
