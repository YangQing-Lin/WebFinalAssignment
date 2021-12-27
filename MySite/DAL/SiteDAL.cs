using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;


namespace MySite
{
    // 数据库查询类，用于构建数据库查询语句
    public class SiteDAL
    {
        private SqlConnection sqlcon;
        private SqlCommand sqlcom;
        // 设置连接数据库名
        private string strCon = "Data Source=.;Initial Catalog=MyDB;Integrated Security=true";

        // 根据id、name、sex查询[UserInfo]表
        public DataSet GetUser(string id, string name ,string sex)
        {
            string sqlstr = "select * from UserInfo where 1=1 ";
            if (id != "" && id != null)
            {
                sqlstr = sqlstr + " And (Id = '" + id + "')";
            }
            else
            {
                if (name != "" && name != null)
                {
                    sqlstr = sqlstr + " And (Id like '%" + name + "%' Or Name like '%" + name + "%')";
                }
            }
            if (sex != "全部")
            {
                sqlstr = sqlstr + " And Sex='" + sex + "'";
            }
            sqlcon = new SqlConnection(strCon);
            SqlDataAdapter myda = new SqlDataAdapter(sqlstr, sqlcon);
            DataSet myds = new DataSet();
            sqlcon.Open();
            myda.Fill(myds, "user");
            sqlcon.Close();
            return myds;
        }

        internal int DeleteSafe(string Id)
        {
            string sqlstr = "delete from safeInfo where Id='" + Id + "'";
            sqlcon = new SqlConnection(strCon);
            sqlcom = new SqlCommand(sqlstr, sqlcon);
            sqlcon.Open();
            int result = sqlcom.ExecuteNonQuery();
            sqlcon.Close();
            return result;
        }

        internal DataSet GetSafe(string id ,string name, DateTime? jxrq)
        {
            string sqlstr = "select * from SafeInfo where 1=1 ";
            if (!string.IsNullOrEmpty(id))
            {
                sqlstr = sqlstr + " And (Id = " + id + ")";
            }
            else
            {
                if (name != "" && name != null)
                {
                    sqlstr = sqlstr + " And (Name like '%" + name + "%')";
                }
                if (jxrq!=null)
                {
                    sqlstr = sqlstr + " And (Jxrq = '" + jxrq.Value.ToString("yyyy-MM-dd") + "')";
                }
            }
            sqlcon = new SqlConnection(strCon);
            SqlDataAdapter myda = new SqlDataAdapter(sqlstr, sqlcon);
            DataSet myds = new DataSet();
            sqlcon.Open();
            myda.Fill(myds, "food");
            sqlcon.Close();
            return myds;
        }

        public int DeleteUser(string Id)
        {
            string sqlstr = "delete from UserInfo where Id='" + Id + "'";
            sqlcon = new SqlConnection(strCon);
            sqlcom = new SqlCommand(sqlstr, sqlcon);
            sqlcon.Open();
            int result= sqlcom.ExecuteNonQuery();
            sqlcon.Close();
            return result;
        }

        public int UpdateUser(string id, string name, string pwd ,string sex)
        {
            string sqlstr = "update UserInfo set Name='" + name + "',Pwd='" + pwd + "',Sex='" + sex + "' where Id='" + id + "'";
            sqlcon = new SqlConnection(strCon);
            sqlcom = new SqlCommand(sqlstr, sqlcon);
            sqlcon.Open();
            int result = sqlcom.ExecuteNonQuery();
            sqlcon.Close();
            return result;
        }
        public int AddUser(string id, string name, string pwd, string sex)
        {
            string sqlstr = "insert into UserInfo(Id,Name,Pwd,Sex)values('" + id + "','" + name + "','" + pwd + "','" + sex + "')";
            sqlcon = new SqlConnection(strCon);
            sqlcom = new SqlCommand(sqlstr, sqlcon);
            sqlcon.Open();
            int result = sqlcom.ExecuteNonQuery();
            sqlcon.Close();
            return result;
        }
        public int UpdateSafe(int id, string name, string jxnr, DateTime jxrq, string jxr)
        {
            string sqlstr = "update SafeInfo set Name='" + name + "',jxnr='" + jxnr + "',jxrq='" + jxrq.ToString("yyyy-MM-dd")+ "',jxr='" + jxr + "' where Id=" + id;
            sqlcon = new SqlConnection(strCon);
            sqlcom = new SqlCommand(sqlstr, sqlcon);
            sqlcon.Open();
            int result = sqlcom.ExecuteNonQuery();
            sqlcon.Close();
            return result;
        }


        public int AddSafe(string name, string jxnr, DateTime jxrq, string jxr)
        {
            string sqlstr = "insert into SafeInfo(name,jxnr,jxrq,jxr)values('" + name + "','" + jxnr + "','" + jxrq.ToString("yyyy-MM-dd") + "','" + jxr + "')";
            sqlcon = new SqlConnection(strCon);
            sqlcom = new SqlCommand(sqlstr, sqlcon);
            sqlcon.Open();
            int result = sqlcom.ExecuteNonQuery();
            sqlcon.Close();
            return result;
        }
    }
}