using FtisHelperV2.DB.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FtisHelperV2.DB.Helpe
{
    public class Department
    {
        /// <summary>
        /// 取所有部門資料
        /// </summary>
        /// <param name="cachetimer">資料快取時間(毫秒),預設30分</param>
        /// <returns>IEnumerable<Department></returns>
        public static IEnumerable<F22cmmDep> GetAllDepartment(int cachetimer = Helper.longcacheduration)
        {
            return Helper.GetAllDepartment(cachetimer); 
        }

        public static F22cmmDep GetDepartment(string DCode, int cachetimer = Helper.shortcacheduration)
        {
            return Helper.GetDepartment(DCode, cachetimer);
        }
    }
}
