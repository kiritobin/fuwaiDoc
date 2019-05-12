using FuWai.DBHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;


namespace FuWai.DAO
{
    public class LoginDAO
    {
        SQLHelper db = new SQLHelper();
        /*
         * 登录查询
         */
        public int userLogin(String user, String pwd)
        {
            int row = 0;
            String sql = "select count(id) from T_Admin where Adminid=@Adminid and pwd=@pwd";
            string[] param = {"@Adminid", "@pwd" };
            object[] value = { user , pwd };
            row = db.ExecuteNoneQuery(sql, param, value);
           
            return row;
        }
    }
}