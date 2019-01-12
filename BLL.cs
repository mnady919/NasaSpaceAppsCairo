using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace launchOmatic.BL
{
    class BLL
    {
        public void addnewaccount(string cname, string PWD, string uname, string country, string email, Byte[] img)
        {
            LaunchOmatic.DAL.DataacsessLayer DAL = new LaunchOmatic.DAL.DataacsessLayer();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[6];

            param[0] = new SqlParameter("@cname", SqlDbType.NVarChar, 50);
            param[0].Value = cname;

            param[1] = new SqlParameter("@PWD", SqlDbType.NVarChar, 50);
            param[1].Value = PWD;

            param[2] = new SqlParameter("@uname", SqlDbType.NVarChar, 50);
            param[2].Value = uname;

            param[3] = new SqlParameter("@country", SqlDbType.NVarChar, 50);
            param[3].Value = country;

            param[4] = new SqlParameter("@email", SqlDbType.NVarChar, 50);
            param[4].Value = country;

            param[5] = new SqlParameter("@img", SqlDbType.Image);
            param[5].Value = img;

            DAL.Executecommand("addnewaccount", param);
            DAL.Close();
        }
        public DataTable Login(string uname, String PWD)
        {
            LaunchOmatic.DAL.DataacsessLayer DAL = new LaunchOmatic.DAL.DataacsessLayer();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter(@"uname", SqlDbType.NVarChar, 50);
            param[0].Value = uname;
            param[1] = new SqlParameter(@"PWD", SqlDbType.NVarChar, 50);
            param[1].Value = PWD;
            DataTable dt = new DataTable();
            dt = DAL.selectdata("confirmlog",param);
            return dt;
        }
        public void addu(string cname, string PWD, string uname, string country , string email,byte[] img)
        {
            LaunchOmatic.DAL.DataacsessLayer DAL = new LaunchOmatic.DAL.DataacsessLayer();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[6];

            param[0] = new SqlParameter("@cname", SqlDbType.NVarChar, 50);
            param[0].Value = cname;

            param[1] = new SqlParameter("@pwd", SqlDbType.NVarChar, 50);
            param[1].Value = PWD;

            param[2] = new SqlParameter("@uname", SqlDbType.NVarChar, 50);
            param[2].Value = uname;

            param[3] = new SqlParameter("@country", SqlDbType.NVarChar, 50);
            param[3].Value = country; 
            
            param[4] = new SqlParameter("@email", SqlDbType.NVarChar, 50);
            param[4].Value = email;

            param[5] = new SqlParameter("@img", SqlDbType.Image);
            param[5].Value = img;

            DAL.Executecommand("addnewaccount", param);
            DAL.Close();
        }
        public void editu(string ID, string PWD, string ACSESS, string FN)
        {
            LaunchOmatic.DAL.DataacsessLayer DAL = new LaunchOmatic.DAL.DataacsessLayer();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[4];

            param[0] = new SqlParameter("@ID", SqlDbType.NVarChar, 50);
            param[0].Value = ID;

            param[1] = new SqlParameter("@PWD", SqlDbType.NVarChar, 50);
            param[1].Value = PWD;

            param[2] = new SqlParameter("@ACSESS", SqlDbType.NVarChar,50);
            param[2].Value = ACSESS;

            param[3] = new SqlParameter("@FN", SqlDbType.NVarChar, 50);
            param[3].Value = FN;

            DAL.Executecommand("editu", param);
            DAL.Close();
        }
        public DataTable searchu(string habd)
        {
            LaunchOmatic.DAL.DataacsessLayer DAL = new LaunchOmatic.DAL.DataacsessLayer();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@habd", SqlDbType.NVarChar, 50);
            param[0].Value = habd;
            DataTable dt = new DataTable();
            dt = DAL.selectdata("searchu", param);
            return dt;
        }
        public DataTable deleteu(string ID)
        {
            LaunchOmatic.DAL.DataacsessLayer DAL = new LaunchOmatic.DAL.DataacsessLayer();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ID", SqlDbType.NVarChar, 50);
            param[0].Value = ID;
            DataTable dt = new DataTable();
            dt = DAL.selectdata("deleteu", param);
            return dt;
        }
    }
}