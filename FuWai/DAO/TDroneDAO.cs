﻿using FuWai.DBHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

namespace FuWai.DAO
{
    public class TDroneDAO
    {
        SQLHelper db = new SQLHelper();

        /// <summary>
        /// 无人机信息查询
        /// </summary>
        /// <returns>返回所有数据集合DataTable</returns>
        public DataTable SelectDrone() {
            string sql = "select * from T_Drone";
            return db.FillDataSet(sql, null, null).Tables[0];
        }

        /// <summary>
        /// 通过无人机编号（id）查询
        /// </summary>
        /// <param name="droneid">无人机编号</param>
        /// <returns>返回数据集合DataTable</returns>
        public DataTable SelectDronebydroneid(string droneid)
        {
            string sql = "select * from T_Drone where droneid=@droneid";
            string[] param = { "@droneid" };
            object[] value = { droneid };
            return db.FillDataSet(sql, param, value).Tables[0];
        }

        /// <summary>
        /// 添加无人机信息
        /// </summary>
        /// <param name="droneid">编号</param>
        /// <param name="dronemodel">型号</param>
        /// <param name="position">停落位置</param>
        /// <param name="flycount">飞行次数</param>
        /// <param name="status">状态</param>
        /// <param name="lat">x</param>
        /// <param name="lng">y</param>
        /// <returns>返回int</returns>
        public int insert(string droneid,string dronemodel, string position,int flycount,int status,double lat, double lng) {
            string sql = "insert into T_Drone values(@droneid,@dronemodel,@position,@flycount,@status,@lat,@lng)";

            string[] param = { "@droneid", "@dronemodel", "@position", "@flycount", "@status" , "@lat", "@lng" };
            object[] value = { droneid, dronemodel, position, flycount, status , lat , lng };

            return db.ExecuteNoneQuery(sql, param, value);
        }
        /// <summary>
        /// 修改无人机信息
        /// </summary>
        /// <param name="droneid">编号</param>
        /// <param name="dronemodel">型号</param>
        /// <param name="position">停落位置</param>
        /// <param name="flycount">飞行次数</param>
        /// <param name="status">状态</param>
        /// <param name="lat">x</param>
        /// <param name="lng">y</param>
        /// <returns>返回int</returns>
        public int update(string droneid, string dronemodel, string position, int flycount, int status, double lat, double lng) {
            string sql = "update T_Drone set droneid=@droneid ,dronemodel=@dronemodel,position=@position,flycount=@flycount,status=@status,lat=@lat,lng=@lng where droneid=@droneid ";

            string[] param = { "@droneid", "@dronemodel", "@position", "@flycount", "@status", "@lat", "@lng" };
            object[] value = { droneid, dronemodel, position, flycount, status , lat, lng };

            return db.ExecuteNoneQuery(sql, param, value);
        }
        /// <summary>
        /// 删除无人机信息
        /// </summary>
        /// <param name="droneid">编号</param>
        /// <returns>返回int</returns>
        public int delete(string droneid) {
            string sql = "delete from T_Drone where droneid=@droneid ";

            string[] param = { "@droneid" };
            object[] value = { droneid };

            return db.ExecuteNoneQuery(sql, param, value);
        }

    }
}