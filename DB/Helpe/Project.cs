using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FtisHelperV2.DB.Model;

namespace FtisHelperV2.DB.Helpe
{
    public class Project
    {
        /// <summary>
        /// 取所有專案資料
        /// </summary>
        /// <param name="cachetimer">資料快取時間(毫秒),預設30分</param>
        /// <returns>IEnumerable<F22cmmProjectData></returns>
        public static IEnumerable<F22cmmProjectData> GetAllProject(int cachetimer = Helper.shortcacheduration)
        {

            return Helper.GetAllProject(cachetimer);
        }

        /// <summary>
        /// 依專案編號取專案資料
        /// </summary>
        /// <param name="PrjID">專案編號</param>
        /// <param name="cachetimer">快取時間</param>
        /// <returns></returns>
        public static F22cmmProjectData GetProject(string PrjID, int cachetimer = Helper.shortcacheduration)
        {
            return Helper.GetProject(PrjID,cachetimer);
        }
    }
}
