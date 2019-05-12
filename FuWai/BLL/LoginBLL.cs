using FuWai.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FuWai.BLL
{
    public class LoginBLL
    {
        LoginDAO login = new LoginDAO();
            /**
             * 登陆判断
             * @param user
             * @param pwd
             * @return
             */
        public Boolean userLogin(String user, String pwd)
        {
            int row = login.userLogin(user, pwd);
            if (row > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}