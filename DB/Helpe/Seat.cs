using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using FtisHelperV2.DB.Model;
using DouHelper;

namespace FtisHelperV2.DB.Helpe
{
    public class Seat
    {
        //static string GetEmployeeIncludeSeat_Cache_Key = "GetEmployeeIncludeSeat";
        ///// <summary>
        ///// Employee含F22cmmSeat座位
        ///// </summary>
        ///// <param name="cachetimer">資料快取時間(毫秒),預設30分</param>
        ///// <returns>Employee</returns>
        //public static IEnumerable<F22cmmEmpData> GetEmployeeIncludeSeat(int cachetimer = Helper.shortcacheduration)
        //{
        //    var allEmp = DouHelper.Misc.GetCache<IEnumerable<F22cmmEmpData>>(cachetimer, GetEmployeeIncludeSeat_Cache_Key);
        //    if (allEmp == null)
        //    {
        //        using (var cxt = Helper.CreateFtisModelContext())
        //        {
        //            allEmp = cxt.F22cmmEmpData.Where(s => !s.Quit).Include(s => s.SeatsTmp).ToArray();
        //            DouHelper.Misc.AddCache(allEmp, GetEmployeeIncludeSeat_Cache_Key);
        //        }
        //    }
        //    return allEmp;
        //}


        static string GetSeatIncludeEmployee_Cache_Key = "GetSeatIncludeEmployee";
        /// <summary>
        /// Seat含F22cmmEmpData員工
        /// </summary>
        /// <param name="cachetimer">資料快取時間(毫秒),預設30分</param>
        /// <returns>Employee</returns>
        public static IEnumerable<F22cmmSeat> GetSeatIncludeEmployee(int cachetimer = Helper.shortcacheduration)
        {
            var allSeat = DouHelper.Misc.GetCache<IEnumerable<F22cmmSeat>>(cachetimer, GetSeatIncludeEmployee_Cache_Key);
            if (allSeat == null)
            {
                using (var cxt = Helper.CreateFtisModelContext())
                {
                    allSeat = cxt.F22cmmSeat.Include(s => s.EmpTmp).ToArray();
                    DouHelper.Misc.AddCache(allSeat, GetSeatIncludeEmployee_Cache_Key);
                }
            }
            return allSeat;
        }

        /// <summary>
        /// 新增或更新EmployeeSeat
        /// </summary>
        /// <param name="seat"></param>
        public static void UpdateEmployeeSeat(F22cmmEmpData emp)
        {
            using (var cxt = Helper.CreateFtisModelContext())
            {
                var me = new Dou.Models.DB.ModelEntity<F22cmmEmpData>(cxt);
                var meData = me.FirstOrDefault(s => s.Fno == emp.Fno);
                if (meData != null)
                {
                    meData.SeatNo = emp.SeatNo;
                    me.Update(meData);
                }
            }
            DouHelper.Misc.ClearCache(GetAllSeats_Cache_Key);
            DouHelper.Misc.ClearCache(GetSeatIncludeEmployee_Cache_Key);
            //DouHelper.Misc.ClearCache(GetEmployeeIncludeSeat_Cache_Key);
        }

        /// <summary>
        /// 新增或更新Seat
        /// </summary>
        /// <param name="seat"></param>
        public static void AddOrUpdateSeat(F22cmmSeat seat)
        {
            using (var cxt = Helper.CreateFtisModelContext())
            {
                var me = new Dou.Models.DB.ModelEntity<F22cmmSeat>(cxt);//
                if (me.FirstOrDefault(s => s.SeatNo == seat.SeatNo) == null)
                    me.Add(seat);
                else
                    me.Update(seat);
            }
            DouHelper.Misc.ClearCache(GetAllSeats_Cache_Key);
            DouHelper.Misc.ClearCache(GetSeatIncludeEmployee_Cache_Key);
            //DouHelper.Misc.ClearCache(GetEmployeeIncludeSeat_Cache_Key);
        }

        /// <summary>
        /// 刪除Seat
        /// </summary>
        /// <param name="seat"></param>
        public static void DeleteSeat(F22cmmSeat seat)
        {
            using (var cxt = Helper.CreateFtisModelContext())
            {
                var me = new Dou.Models.DB.ModelEntity<F22cmmSeat>(cxt);//
                if (me.FirstOrDefault(s => s.SeatNo == seat.SeatNo) != null)
                    me.Delete(seat);
            }
            DouHelper.Misc.ClearCache(GetAllSeats_Cache_Key);
            DouHelper.Misc.ClearCache(GetSeatIncludeEmployee_Cache_Key);
            //DouHelper.Misc.ClearCache(GetEmployeeIncludeSeat_Cache_Key);
        }

        static string GetAllSeats_Cache_Key = "GetAllSeat";
        /// <summary>
        /// 取全部F22cmmSeat座位
        /// </summary>
        /// <param name="cachetimer">資料快取時間(毫秒),預設30分</param>
        /// <returns>Employee</returns>
        public static IEnumerable<F22cmmSeat> GetAllSeats(int cachetimer = Helper.shortcacheduration)
        {
            var allSeats = DouHelper.Misc.GetCache<IEnumerable<F22cmmSeat>>(cachetimer, GetAllSeats_Cache_Key);
            if (allSeats == null)
            {
                using (var cxt = Helper.CreateFtisModelContext())
                {
                    allSeats = cxt.F22cmmSeat.ToArray();
                    DouHelper.Misc.AddCache(allSeats, GetAllSeats_Cache_Key);
                }
            }
            return allSeats;
        }
    }
}
