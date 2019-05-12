using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using FuWai.DAO;
using FuWai.DBHelper;

namespace FuWai.BLL
{
    public class VCheckBLL
    {
        VCheckDAO dao = new VCheckDAO();
        public string selectVCheck()
        {
            DataTable dt = dao.selectVCheck();
            string jsonString = string.Empty;
            jsonString = JsonHelper.ToJson(dt);
            return jsonString;
        }
    }
}