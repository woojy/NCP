using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace metoo.Models
{
    public class CInstance
    {
        public static CUserManager theUserMananger;
        private static int bInit;

        public static void initialize()
        {
            if (bInit == 0)
            {
                theUserMananger = new CUserManager();
            }
            bInit = 1;
        }
    }
}