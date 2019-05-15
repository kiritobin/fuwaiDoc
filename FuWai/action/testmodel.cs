using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FuWai.action
{
    public class testmodel
    {
        private string patientid;   //病人id
        private string level;       //等级
        private string x;          //坐标
        private string y;          //坐标


        public string Patientid
        {
            get
            {
                return patientid;
            }

            set
            {
                patientid = value;
            }
        }

        public string Level
        {
            get
            {
                return level;
            }

            set
            {
                level = value;
            }
        }

        public string X
        {
            get
            {
                return x;
            }

            set
            {
                x = value;
            }
        }

        public string Y
        {
            get
            {
                return y;
            }

            set
            {
                y = value;
            }
        }

    }
}