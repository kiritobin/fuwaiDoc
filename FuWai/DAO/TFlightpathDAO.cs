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
        public DataTable SelectFlightpathbyDroneid(string droneid,int status)
        {
            string sql = "select * from T_Flightpath where droneid=@droneid and status=@status";
            string[] param = { "@droneid","@status" };
            object[] value = { droneid ,status};
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
            string sql = "insert into T_Flightpath values(@droneid,@flighttime,@lat,@lng,@status)";

            string[] param = { "@droneid", "@flighttime", "@lat", "lng" ,"@status"};
            object[] value = { droneid, flighttime, lat, lng ,1};

            return db.ExecuteNoneQuery(sql, param, value);
        }
        
        /// <summary>
        /// 通过坐标改变已飞过状态
        /// </summary>
        /// <param name="lat"></param>
        /// <param name="lng"></param>
        /// <returns></returns>
        public int changestatus(double lat,double lng)
        {
            string sql = "update T_Flightpath set status=0 where lat=@lat and lng=@lng";
            string[] param = { "@lat", "lng" };
            object[] value = { lat, lng };
            return db.ExecuteNoneQuery(sql, param, value);
        }
    }
}