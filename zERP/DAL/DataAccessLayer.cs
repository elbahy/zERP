using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace zERP.DAL
{
    internal class DataAccessLayer
    {
        SqlConnection cn;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt = new DataTable();


        public  DataAccessLayer()
        {
            cn = new SqlConnection("Server = vB-PC; Database = ZERP_DB; Integrated Security = true");
        }

        public void OpenConnection()
        {
            if(cn.State != ConnectionState.Open)
            {
                cn.Open();
            }
            
        }
        public void CloseConnection()
        {
            if(cn.State != ConnectionState.Closed)
            {
                cn.Close();
            }
        }

        public DataTable GetData(string stringProcedure, SqlParameter[] pars )
        {
            try
            {
cmd = new SqlCommand(stringProcedure, cn);
            cmd.CommandType = CommandType.StoredProcedure;
            if (pars!=null) cmd.Parameters.AddRange(pars);
            this.OpenConnection();
            da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            
            return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                return dt;
            }
            finally
            {
                this.CloseConnection();
            }

        }

        public void WriteData(string stringProcedure, SqlParameter[] pars)
        {
            try
            {
                cmd = new SqlCommand(stringProcedure, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddRange(pars);
                this.OpenConnection();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message.ToString());
            }
            finally
            {
                this.CloseConnection();
            }
            
        }
    }
}
