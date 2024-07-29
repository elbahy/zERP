using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zERP.BL
{
    internal class BussinessLayer
    {
        DataTable dt = new DataTable();
        public DataTable Login(string userID,string pass)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();

            SqlParameter[] pars =  {
                new SqlParameter("userID",userID),
                new SqlParameter("pass",pass)
            };

            dt = dal.GetData("Login_SP", pars);
            return dt;
        }
    }
}
