using FuWai.DBHelper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace FuWai.DAO
{
    public class TFlightpathDAO
    {
        SQLHelper db = new SQLHelper();

        /// <summary>
        /// 通过无人机id查询飞行路径
        /// </summary>
        /// <param name="droneid">无人机id</param>
        /// <returns>DataTable</returns>
        public DataTable SelectFlightpathbyDroneid(string droneid)
        {
            string sql = "select * from T_Flightpath where droneid=@droneid";
            string[] param = { "@droneid" };
            object[] value = { droneid };
            return db.FillDataSet(sql, param, value).Tables[0];
        }

        /// <summary>
        /// 通过时间查询飞行路径
        /// </summary>
        /// <param name="flighttime">飞行时间</param>
        /// <returns>DataTable</returns>
        public DataTable SelectFlightpathbytime(string flighttime,string droneid)
        {
            string sql = "select * from T_Flightpath where droneid=@droneid and flighttime=@flighttime";
            string[] param = { "@flighttime" , "@droneid" };
            object[] value = { flighttime,droneid };
            return db.FillDataSet(sql, param, value).Tables[0];
        }

        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="droneid">无人机id</param>
        /// <param name="flighttime">飞行时间</param>
        /// <param name="lat">经度</param>
        /// <param name="lng">纬度</param>
        /// <returns>int</returns>
        public int insert(string droneid,string flighttime, double lat , double lng)
        {
            string sql = "insert into T_Flightpath values(@droneid,@flighttime,@lat,@lng)";

            string[] param = { "@droneid", "@flighttime", "@lat", "lng" };
            object[] value = { droneid, flighttime, lat, lng };

            return db.ExecuteNoneQuery(sql, param, value);
        }
        
    }
}