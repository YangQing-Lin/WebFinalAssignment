using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;


namespace MySite
{
    public class SiteBLL
    {
        SiteDAL DAL = new SiteDAL();
        public DataSet GetUser(string id, string name)
        {
            return DAL.GetUser(id,name);
        }

        internal int DeleteSafe(string Id)
        {
            return DAL.DeleteSafe(Id);
        }

        internal DataSet GetSafe(string id ,string name, DateTime? jxrq)
        {

            return DAL.GetSafe(id, name, jxrq);
        }

        public int DeleteUser(string Id)
        {
            return DAL.DeleteUser(Id);
        }

        public int UpdateUser(string id, string name, string pwd ,string sex)
        {
            return DAL.UpdateUser(id, name, pwd,sex);
        }
        public int AddUser(string id, string name, string pwd, string sex)
        {
            return DAL.AddUser(id, name, pwd, sex);
        }
        public int UpdateSafe(int id, string name, string jxnr, DateTime jxrq, string jxr)
        {
            return DAL.UpdateSafe(id, name, jxnr, jxrq, jxr);
        }


        public int AddSafe(string name, string jxnr, DateTime jxrq, string jxr)
        {
            return DAL.AddSafe(name, jxnr, jxrq, jxr);
        }
    }
}