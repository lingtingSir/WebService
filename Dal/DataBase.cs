using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Dal
{
    public class DataBase
    {
        private SqlConnection Con()
        {
            return new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ToString());
        }
        public int ExecuteSql(string sql)
        {
            SqlConnection con = this.Con();
            SqlCommand com = new SqlCommand(sql, con);
            int result;
            try
            {
                con.Open();
                com.ExecuteNonQuery();
                result = 1;
            }
            catch (SqlException e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                com.Dispose();
                con.Close();
            }
            return result;
        }
        public int ExecuteSql(string sql, SqlParameter[] p)
        {
            SqlConnection con = this.Con();
            SqlCommand com = new SqlCommand(sql, con);
            for (int i = 0; i < p.Length; i++)
            {
                com.Parameters.Add(p[i]);
            }
            int result;
            try
            {
                con.Open();
                com.ExecuteNonQuery();
                result = 1;
            }
            catch (SqlException e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                com.Parameters.Clear();
                com.Dispose();
                con.Close();
            }
            return result;
        }
        public int ExecuteSqls(string[] sql)
        {
            SqlConnection con = this.Con();
            SqlCommand com = new SqlCommand();
            int i = sql.Length;
            con.Open();
            SqlTransaction tran = con.BeginTransaction();
            int result;
            try
            {
                com.Connection = con;
                com.Transaction = tran;
                for (int j = 0; j < sql.Length; j++)
                {
                    string str = sql[j];
                    com.CommandText = str;
                    com.ExecuteNonQuery();
                }
                tran.Commit();
                result = 1;
            }
            catch (SqlException e)
            {
                tran.Rollback();
                throw new Exception(e.Message);
            }
            finally
            {
                com.Dispose();
                con.Close();
            }
            return result;
        }
        public int ExecuteSqls(string[] sql, SqlParameter[] p)
        {
            SqlConnection con = this.Con();
            SqlCommand com = new SqlCommand();
            int i = sql.Length;
            int j = p.Length;
            for (int k = 0; k < j; k++)
            {
                com.Parameters.Add(p[k]);
            }
            con.Open();
            SqlTransaction tran = con.BeginTransaction();
            int result;
            try
            {
                com.Connection = con;
                com.Transaction = tran;
                for (int l = 0; l < sql.Length; l++)
                {
                    string str = sql[l];
                    com.CommandText = str;
                    com.ExecuteNonQuery();
                }
                tran.Commit();
                result = 1;
            }
            catch (SqlException e)
            {
                tran.Rollback();
                throw new Exception(e.Message);
            }
            finally
            {
                com.Parameters.Clear();
                com.Dispose();
                con.Close();
            }
            return result;
        }
        public string ExecuteValue(string sql)
        {
            SqlConnection con = this.Con();
            SqlCommand com = new SqlCommand(sql, con);
            string result;
            try
            {
                con.Open();
                object ob = com.ExecuteScalar();
                if (ob != null)
                {
                    result = ob.ToString();

                }
                else
                {
                    result = null;
                }
            }
            catch (SqlException e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                com.Dispose();
                con.Dispose();
            }
            return result;
        }
        public string ExecuteValue(string sql, SqlParameter[] p)
        {
            SqlConnection con = this.Con();
            SqlCommand com = new SqlCommand(sql, con);
            for (int i = 0; i < p.Length; i++)
            {
                com.Parameters.Add(p[i]);
            }
            string result;
            try
            {
                con.Open();
                object ob = com.ExecuteScalar();
                if (ob != null)
                {
                    result = ob.ToString();
                }
                else
                {
                    result = null;
                }
            }
            catch (SqlException e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                com.Parameters.Clear();
                com.Dispose();
                con.Close();
            }
            return result;
        }
        public DataTable GetDataTable(string sql)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sql, this.Con());
            da.Fill(dt);
            return dt;
        }
        public DataSet GetDataSet(string sql,string DataTableName)
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(sql, this.Con());
            da.Fill(ds, DataTableName);
            return ds;
        }

      
        public DataTable GetDataTable(string sql, SqlParameter[] param)
        {
            DataTable dt = new DataTable();
            SqlConnection conn = this.Con();
            SqlCommand cmd = new SqlCommand(sql, conn);
            for (int i = 0; i < param.Length; i++)
            {
                cmd.Parameters.Add(param[i]);
            }
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }
        public DataTable GetDataTableproc(string proc, SqlParameter[] param)
        {
            DataTable dt = new DataTable();
            SqlConnection conn = this.Con();
            SqlCommand cmd = new SqlCommand(proc, conn);
            cmd.CommandType = CommandType.StoredProcedure;
            for (int i = 0; i < param.Length; i++)
            {
                cmd.Parameters.Add(param[i]);
            }
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }
        public string ExecuteValueProc(string sql, SqlParameter[] p)
        {
            SqlConnection con = this.Con();
            SqlCommand com = new SqlCommand(sql, con);
            com.CommandType = CommandType.StoredProcedure;
            for (int i = 0; i < p.Length; i++)
            {
                com.Parameters.Add(p[i]);
            }
            string result;
            try
            {
                con.Open();
                object ob = com.ExecuteScalar();
                if (ob != null)
                {
                    result = ob.ToString();
                }
                else
                {
                    result = null;
                }
            }
            catch (SqlException e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                com.Parameters.Clear();
                com.Dispose();
                con.Close();
            }
            return result;
        }
        public SqlDataReader getdr(string sql)
        {
            SqlConnection con = Con();
            con.Open();
            SqlCommand com = new SqlCommand(sql, con);
            SqlDataReader dr = com.ExecuteReader();
            return dr;
        }

    }
}
