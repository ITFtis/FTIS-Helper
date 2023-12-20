using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FtisHelperV2.DB.Model;

namespace FtisHelperV2.DB.Helpe
{
    public class Employee
    {
        static object lockGetAllF22cmmEmpDa1 = new object();
        static object lockGetAllF22cmmEmpDa4 = new object();
        static object lockGetAllF22cmmEmpDa5 = new object();
        static object lockGetAllF22cmmEmpDa6 = new object();
        static object lockGetAllF22cmmEmpDa6a = new object();
        static object lockGetAllF22cmmEmpDa7 = new object();
        static object lockGetAllF22cmmEmpDa8 = new object();
        static object lockGetAllF22cmmEmpDa9 = new object();
        static object lockGetAllTitle = new object();
        static object lockGetAllCounty = new object();
        static object lockGetAllTown = new object();
        static object lockGetAllEmpCheckTime = new object();
        static object lockGetAllEmpDataLog = new object();

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
        public static IEnumerable<F22cmmEmpData> GetAllEmployee(int cachetimer = Helper.shortcacheduration)
        {
            return Helper.GetAllEmployee(cachetimer);
        }
        /// <summary>
        /// 依Fno取Employee
        /// </summary>
        /// <param name="Fno">員工編號</param>
        /// <param name="cachetimer">資料快取時間(毫秒),預設30分</param>
        /// <returns>Employee</returns>
        public static F22cmmEmpData GetEmployee(string Fno, int cachetimer = Helper.shortcacheduration)
        {
            return Helper.GetEmployee(Fno,cachetimer);
        }
        /// <summary>
        /// 取Empolyee所有通訊資料
        /// </summary>
        /// <param name="cachetimer"></param>
        /// <returns></returns>
        public static IEnumerable<F22cmmEmpDa1> GetAllF22cmmEmpDa1(int cachetimer = Helper.shortcacheduration)
        {
            string key = "FtisHelperV2.DB.Model.GetAllF22cmmEmpDa1";
            var allDatas = DouHelper.Misc.GetCache<IEnumerable<F22cmmEmpDa1>>(cachetimer, key);
            lock (lockGetAllF22cmmEmpDa1)
            {
                if (allDatas == null)
                {
                    using (var cxt = CreateFtisModelContext())
                    {
                        allDatas = cxt.F22cmmEmpDa1.ToArray();
                        DouHelper.Misc.AddCache(allDatas, key);
                    }
                }
            }
            return allDatas;
        }
        /// <summary>
        /// 虛擬欄位員工通訊資料(Da1)
        /// </summary>
        public static void ResetGetAllF22cmmEmpDa1()
        {
            string key = "FtisHelperV2.DB.Model.GetAllF22cmmEmpDa1";
            DouHelper.Misc.ClearCache(key);
        }

        /// <summary>
        /// 依Fno取Employee最高學歷
        /// </summary>
        /// <param name="Fno">員工編號</param>
        /// <param name="cachetimer">資料快取時間(毫秒),預設30分</param>
        /// <returns>Employee</returns>
        public static F22cmmEmpDa4 GetEmployeeMaxDa4(string Fno, int cachetimer = Helper.shortcacheduration)
        {
            return Helper.GetEmployeeMaxDa4(Fno, cachetimer);
        }
        /// <summary>
        /// 取Empolyee所有學歷
        /// </summary>
        /// <param name="cachetimer"></param>
        /// <returns></returns>
        public static IEnumerable<F22cmmEmpDa4> GetAllF22cmmEmpDa4(int cachetimer = Helper.shortcacheduration)
        {
            string key = "FtisHelperV2.DB.Model.GetAllF22cmmEmpDa4";
            var allDatas = DouHelper.Misc.GetCache<IEnumerable<F22cmmEmpDa4>>(cachetimer, key);
            lock (lockGetAllF22cmmEmpDa4)
            {
                if (allDatas == null)
                {
                    using (var cxt = CreateFtisModelContext())
                    {
                        allDatas = cxt.F22cmmEmpDa4.ToArray();
                        DouHelper.Misc.AddCache(allDatas, key);
                    }
                }
            }
            return allDatas;
        }
        /// <summary>
        /// 虛擬欄位員工主表學歷(Da4)
        /// </summary>
        public static void ResetGetAllF22cmmEmpDa4()
        {
            string key = "FtisHelperV2.DB.Model.GetAllF22cmmEmpDa4";
            DouHelper.Misc.ClearCache(key);
        }
        /// <summary>
        /// 取Empolyee所有經歷
        /// </summary>
        /// <param name="cachetimer"></param>
        /// <returns></returns>
        public static IEnumerable<F22cmmEmpDa5> GetAllF22cmmEmpDa5(int cachetimer = Helper.shortcacheduration)
        {
            string key = "FtisHelperV2.DB.Model.GetAllF22cmmEmpDa5";
            var allDatas = DouHelper.Misc.GetCache<IEnumerable<F22cmmEmpDa5>>(cachetimer, key);
            lock (lockGetAllF22cmmEmpDa5)
            {
                if (allDatas == null)
                {
                    using (var cxt = CreateFtisModelContext())
                    {
                        allDatas = cxt.F22cmmEmpDa5.ToArray();
                        DouHelper.Misc.AddCache(allDatas, key);
                    }
                }
            }
            return allDatas;
        }
        /// <summary>
        /// 虛擬欄位員工主表經歷(Da5)
        /// </summary>
        public static void ResetGetAllF22cmmEmpDa5()
        {
            string key = "FtisHelperV2.DB.Model.GetAllF22cmmEmpDa5";
            DouHelper.Misc.ClearCache(key);
        }
        /// <summary>
        /// 取Empolyee所有家庭狀況
        /// </summary>
        /// <param name="cachetimer"></param>
        /// <returns></returns>
        public static IEnumerable<F22cmmEmpDa6> GetAllF22cmmEmpDa6(int cachetimer = Helper.shortcacheduration)
        {
            string key = "FtisHelperV2.DB.Model.GetAllF22cmmEmpDa6";
            var allDatas = DouHelper.Misc.GetCache<IEnumerable<F22cmmEmpDa6>>(cachetimer, key);
            lock (lockGetAllF22cmmEmpDa6)
            {
                if (allDatas == null)
                {
                    using (var cxt = CreateFtisModelContext())
                    {
                        allDatas = cxt.F22cmmEmpDa6.ToArray();
                        DouHelper.Misc.AddCache(allDatas, key);
                    }
                }
            }
            return allDatas;
        }
        /// <summary>
        /// 虛擬欄位員工主表家庭狀況(Da6)
        /// </summary>
        public static void ResetGetAllF22cmmEmpDa6()
        {
            string key = "FtisHelperV2.DB.Model.GetAllF22cmmEmpDa6";
            DouHelper.Misc.ClearCache(key);
        }
        /// <summary>
        /// 取Empolyeer眷屬投保健保狀況
        /// </summary>
        /// <param name="cachetimer"></param>
        /// <returns></returns>
        public static IEnumerable<F22cmmEmpDa6a> GetAllF22cmmEmpDa6a(int cachetimer = Helper.shortcacheduration)
        {
            string key = "FtisHelperV2.DB.Model.GetAllF22cmmEmpDa6a";
            var allDatas = DouHelper.Misc.GetCache<IEnumerable<F22cmmEmpDa6a>>(cachetimer, key);
            lock (lockGetAllF22cmmEmpDa6a)
            {
                if (allDatas == null)
                {
                    using (var cxt = CreateFtisModelContext())
                    {
                        allDatas = cxt.F22cmmEmpDa6a.ToArray();
                        DouHelper.Misc.AddCache(allDatas, key);
                    }
                }
            }
            return allDatas;
        }
        /// <summary>
        /// 虛擬欄位員工主表家庭狀況(Da6a)
        /// </summary>
        public static void ResetGetAllF22cmmEmpDa6a()
        {
            string key = "FtisHelperV2.DB.Model.GetAllF22cmmEmpDa6a";
            DouHelper.Misc.ClearCache(key);
        }
        /// <summary>
        /// 取Empolyee所有外語檢定
        /// </summary>
        /// <param name="cachetimer"></param>
        /// <returns></returns>
        public static IEnumerable<F22cmmEmpDa7> GetAllF22cmmEmpDa7(int cachetimer = Helper.shortcacheduration)
        {
            string key = "FtisHelperV2.DB.Model.GetAllF22cmmEmpDa7";
            var allDatas = DouHelper.Misc.GetCache<IEnumerable<F22cmmEmpDa7>>(cachetimer, key);
            lock (lockGetAllF22cmmEmpDa7)
            {
                if (allDatas == null)
                {
                    using (var cxt = CreateFtisModelContext())
                    {
                        allDatas = cxt.F22cmmEmpDa7.ToArray();
                        DouHelper.Misc.AddCache(allDatas, key);
                    }
                }
            }
            return allDatas;
        }
        /// <summary>
        /// 虛擬欄位員工主表外語檢定(Da7)
        /// </summary>
        public static void ResetGetAllF22cmmEmpDa7()
        {
            string key = "FtisHelperV2.DB.Model.GetAllF22cmmEmpDa7";
            DouHelper.Misc.ClearCache(key);
        }
        /// <summary>
        /// 取Empolyee所有專業資格
        /// </summary>
        /// <param name="cachetimer"></param>
        /// <returns></returns>
        public static IEnumerable<F22cmmEmpDa8> GetAllF22cmmEmpDa8(int cachetimer = Helper.shortcacheduration)
        {
            string key = "FtisHelperV2.DB.Model.GetAllF22cmmEmpDa8";
            var allDatas = DouHelper.Misc.GetCache<IEnumerable<F22cmmEmpDa8>>(cachetimer, key);
            lock (lockGetAllF22cmmEmpDa8)
            {
                if (allDatas == null)
                {
                    using (var cxt = CreateFtisModelContext())
                    {
                        allDatas = cxt.F22cmmEmpDa8.ToArray();
                        DouHelper.Misc.AddCache(allDatas, key);
                    }
                }
            }
            return allDatas;
        }
        /// <summary>
        /// 虛擬欄位員工主表專業資格(Da8)
        /// </summary>
        public static void ResetGetAllF22cmmEmpDa8()
        {
            string key = "FtisHelperV2.DB.Model.GetAllF22cmmEmpDa8";
            DouHelper.Misc.ClearCache(key);
        }
        /// <summary>
        /// 取Empolyee所有著作
        /// </summary>
        /// <param name="cachetimer"></param>
        /// <returns></returns>
        public static IEnumerable<F22cmmEmpDa9> GetAllF22cmmEmpDa9(int cachetimer = Helper.shortcacheduration)
        {
            string key = "FtisHelperV2.DB.Model.GetAllF22cmmEmpDa9";
            var allDatas = DouHelper.Misc.GetCache<IEnumerable<F22cmmEmpDa9>>(cachetimer, key);
            lock (lockGetAllF22cmmEmpDa9)
            {
                if (allDatas == null)
                {
                    using (var cxt = CreateFtisModelContext())
                    {
                        allDatas = cxt.F22cmmEmpDa9.ToArray();
                        DouHelper.Misc.AddCache(allDatas, key);
                    }
                }
            }
            return allDatas;
        }
        /// <summary>
        /// 虛擬欄位員工主表著作(Da9)
        /// </summary>
        public static void ResetGetAllF22cmmEmpDa9()
        {
            string key = "FtisHelperV2.DB.Model.GetAllF22cmmEmpDa9";
            DouHelper.Misc.ClearCache(key);
        }
        /// <summary>
        /// 依Fno取F22cmmTitle職稱
        /// </summary>
        /// <param name="uid">員工編號</param>
        /// <param name="cachetimer">資料快取時間(毫秒),預設30分</param>
        /// <returns>Employee</returns>
        public static F22cmmTitle GetEmployeeTitle(string Fno, int cachetimer = Helper.shortcacheduration)
        {
            return Helper.GetEmployeeTitle(Fno, cachetimer);
        }
        /// <summary>
        /// 取全部F22cmmTitle職稱
        /// </summary>
        /// <param name="cachetimer">資料快取時間(毫秒),預設30分</param>
        /// <returns>Employee</returns>
        public static IEnumerable<F22cmmTitle> GetAllTitle(int cachetimer = Helper.shortcacheduration)
        {
            string key = "FtisHelperV2.DB.Model.GetAllTitle";
            var allDatas = DouHelper.Misc.GetCache<IEnumerable<F22cmmTitle>>(cachetimer, key);
            lock (lockGetAllTitle)
            {
                if (allDatas == null)
                {
                    using (var cxt = CreateFtisModelContext())
                    {
                        allDatas = cxt.F22cmmTitle.ToArray();
                        DouHelper.Misc.AddCache(allDatas, key);
                    }
                }
            }
            return allDatas;
        }
        public static void ResetGetAllTitle()
        {
            string key = "FtisHelperV2.DB.Model.GetAllTitle";
            DouHelper.Misc.ClearCache(key);
        }

        /// <summary>
        /// 取全部F22cmmMP人力分布
        /// </summary>
        /// <param name="cachetimer">資料快取時間(毫秒),預設30分</param>
        /// <returns>Employee</returns>
        public static IEnumerable<F22cmmMP> GetAllMP(int cachetimer = Helper.shortcacheduration)
        {
            return Helper.GetAllMP(cachetimer);
        }

        /// <summary>
        /// 取全部F22cmmGrade職等
        /// </summary>
        /// <param name="cachetimer">資料快取時間(毫秒),預設30分</param>
        /// <returns>Employee</returns>
        public static IEnumerable<F22cmmGrade> GetAllGrade(int cachetimer = Helper.shortcacheduration)
        {
            return Helper.GetAllGrade(cachetimer);
        }

        /// <summary>
        /// 取全部F22cmmCounty縣市
        /// </summary>
        /// <param name="cachetimer">資料快取時間(毫秒),預設30分</param>
        /// <returns>Employee</returns>
        public static IEnumerable<F22cmmCounty> GetAllCounty(int cachetimer = Helper.shortcacheduration)
        {
            string key = "FtisHelperV2.DB.Model.GetAllCounty";
            var allDatas = DouHelper.Misc.GetCache<IEnumerable<F22cmmCounty>>(cachetimer, key);
            lock (lockGetAllCounty)
            {
                if (allDatas == null)
                {
                    using (var cxt = CreateFtisModelContext())
                    {
                        allDatas = cxt.F22cmmCounty.ToArray();
                        DouHelper.Misc.AddCache(allDatas, key);
                    }
                }
            }
            return allDatas;
        }
        public static void ResetGetAllCounty()
        {
            string key = "FtisHelperV2.DB.Model.GetAllCounty";
            DouHelper.Misc.ClearCache(key);
        }
        /// <summary>
        /// 依CountyCode取F22cmmCounty縣市
        /// </summary>
        /// <param name="CountyCode">縣市代碼</param>
        /// <param name="cachetimer">資料快取時間(毫秒),預設30分</param>
        /// <returns>Employee</returns>
        public static F22cmmCounty GetCountyByCountyCode(string CountyCode, int cachetimer = Helper.shortcacheduration)
        {
            if (string.IsNullOrEmpty(CountyCode))
                return null;
            return GetAllCounty(cachetimer).FirstOrDefault(m => m.CountyCode == CountyCode);
        }
        /// <summary>
        /// 取全部F22cmmCounty鄉鎮
        /// </summary>
        /// <param name="cachetimer">資料快取時間(毫秒),預設30分</param>
        /// <returns>Employee</returns>
        public static IEnumerable<F22cmmTown> GetAllTown(int cachetimer = Helper.shortcacheduration)
        {
            string key = "FtisHelperV2.DB.Model.GetAllTown";
            var allDatas = DouHelper.Misc.GetCache<IEnumerable<F22cmmTown>>(cachetimer, key);
            lock (lockGetAllTown)
            {
                if (allDatas == null)
                {
                    using (var cxt = CreateFtisModelContext())
                    {
                        allDatas = cxt.F22cmmTown.ToArray();
                        DouHelper.Misc.AddCache(allDatas, key);
                    }
                }
            }
            return allDatas;
        }
        public static void ResetGetAllTown()
        {
            string key = "FtisHelperV2.DB.Model.GetAllTown";
            DouHelper.Misc.ClearCache(key);
        }
        /// <summary>
        /// 依ZipCode取F22cmmTown
        /// </summary>
        /// <param name="ZipCode">鄉鎮代碼</param>
        /// <param name="cachetimer">資料快取時間(毫秒),預設30分</param>
        /// <returns>Employee</returns>
        public static F22cmmTown GetTownByZipCode(string ZipCode, int cachetimer = Helper.shortcacheduration)
        {
            if (string.IsNullOrEmpty(ZipCode))
                return null;
            return GetAllTown(cachetimer).FirstOrDefault(m => m.ZipCode == ZipCode);
        }
        /// <summary>
        /// 取全部F22EmpCheckTime刷卡時間
        /// </summary>
        /// <param name="cachetimer">資料快取時間(毫秒),預設30分</param>
        /// <returns>Employee</returns>
        public static IEnumerable<F22EmpCheckTime> GetAllEmpCheckTime(int cachetimer = Helper.shortcacheduration)
        {
            string key = "FtisHelperV2.DB.Model.GetAllEmpCheckTime";
            var allDatas = DouHelper.Misc.GetCache<IEnumerable<F22EmpCheckTime>>(cachetimer, key);
            lock (lockGetAllEmpCheckTime)
            {
                if (allDatas == null)
                {
                    using (var cxt = CreateFtisModelContext())
                    {
                        allDatas = cxt.F22EmpCheckTime.ToArray();
                        DouHelper.Misc.AddCache(allDatas, key);
                    }
                }
            }
            return allDatas;
        }
        public static void ResetGetAllEmpCheckTime()
        {
            string key = "FtisHelperV2.DB.Model.GetAllEmpCheckTime";
            DouHelper.Misc.ClearCache(key);
        }
        /// <summary>
        /// 依Fno取F22EmpCheckTime刷卡時間
        /// </summary>
        /// <param name="cachetimer">資料快取時間(毫秒),預設30分</param>
        /// <returns>Employee</returns>
        public static IEnumerable<F22EmpCheckTime> GetEmpCheckTime(string Fno, int cachetimer = Helper.shortcacheduration)
        {
            string key = "FtisHelperV2.DB.Model.GetEmpCheckTime";
            var allDatas = DouHelper.Misc.GetCache<IEnumerable<F22EmpCheckTime>>(cachetimer, key);
            lock (lockGetAllEmpCheckTime)
            {
                if (allDatas == null)
                {
                    using (var cxt = CreateFtisModelContext())
                    {
                        allDatas = cxt.F22EmpCheckTime.Where(s=>s.Fno == Fno).ToArray();
                        DouHelper.Misc.AddCache(allDatas, key);
                    }
                }
            }
            return allDatas;
        }
        public static void ResetGetEmpCheckTime()
        {
            string key = "FtisHelperV2.DB.Model.GetEmpCheckTime";
            DouHelper.Misc.ClearCache(key);
        }
        /// <summary>
        /// 取全部F22cmmEmpDataLog紀錄
        /// </summary>
        /// <param name="cachetimer">資料快取時間(毫秒),預設30分</param>
        /// <returns>Employee</returns>
        public static IEnumerable<F22cmmEmpDataLog> GetAllEmpDataLog(int cachetimer = Helper.shortcacheduration)
        {
            string key = "FtisHelperV2.DB.Model.GetAllEmpDataLog";
            var allDatas = DouHelper.Misc.GetCache<IEnumerable<F22cmmEmpDataLog>>(cachetimer, key);
            lock (lockGetAllEmpDataLog)
            {
                if (allDatas == null)
                {
                    using (var cxt = CreateFtisModelContext())
                    {
                        allDatas = cxt.F22cmmEmpDataLog.ToArray();
                        DouHelper.Misc.AddCache(allDatas, key);
                    }
                }
            }
            return allDatas;
        }
        public static void ResetGetAllEmpDataLog()
        {
            string key = "FtisHelperV2.DB.Model.GetAllEmpDataLog";
            DouHelper.Misc.ClearCache(key);
        }
    }
}
