﻿using FuWai.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using FuWai.DBHelper;

namespace FuWai.BLL
{
    public class TDroneBLL
    {
        TDroneDAO td = new TDroneDAO();
        /// <summary>
        /// 无人机信息查询
        /// </summary>
        /// <returns>返回json</returns>
        public String getDroneinfo()
        {
            return JsonHelper.ToJson(td.SelectDrone());
        }

        /// <summary>
        /// 通过无人机编号查询
        /// </summary>
        /// <param name="droneid">无人机编号</param>
        /// <returns>返回json</returns>
        public String getDroneinfobydroneid(string droneid)
        {
            return JsonHelper.ToJson(td.SelectDronebydroneid(droneid));
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
        /// <returns>成功返回true失败返回fasle</returns>
        public Boolean insert(string droneid, string dronemodel, string position, int flycount, int status, double lat, double lng) {
            int row = td.insert( droneid, dronemodel, position, flycount, status, lat, lng);
            if (row > 0) {
                return true;
            }
            return false;
        }
        /// <summary>
        /// 修改无人机信息
        /// </summary>
        /// <param name="droneid">编号</param>
        /// <param name="dronemodel">型号</param>
        /// <param name="position">停落位置</param>
        /// <param name="flycount">飞行次数</param>
        /// <param name="status">状态</param>
        /// <returns>成功返回true失败返回fasle</returns>
        public Boolean update(string droneid, string dronemodel, string position, int flycount, int status, double lat, double lng) {
            int row = td.update(droneid, dronemodel, position, flycount, status, lat, lng);
            if (row > 0)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// 通过无人机编号删除无人机
        /// </summary>
        /// <param name="droneid">无人机编号</param>
        /// <returns>成功返回true失败返回fasle</returns>
        public Boolean delete(string droneid) {
            int row = td.delete(droneid);
            if (row > 0)
            {
                return true;
            }
            return false;
        }


    }
}