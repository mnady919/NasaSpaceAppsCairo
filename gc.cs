using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Microsoft.SqlServer.Server;
namespace launchOmatic.BL
{
    class gc
    {
        public void uh(DateTime date, string maker,string payload,string sor3tintlaq,string engine,string dest,string fuelsys,string live,string payloadratio,string bestplacetoview,string descreption)
        {
            LaunchOmatic.DAL.DataacsessLayer DAL = new LaunchOmatic.DAL.DataacsessLayer();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[11];

            param[0] = new SqlParameter("@date", SqlDbType.DateTime);
            param[0].Value = date;

            param[1] = new SqlParameter("@maker", SqlDbType.NVarChar,50);
            param[1].Value = maker;
            
            param[2] = new SqlParameter("@payload", SqlDbType.NVarChar,4000);
            param[2].Value = payload;

            param[3] = new SqlParameter("@sor3tintlaq", SqlDbType.NVarChar, 4000);
            param[3].Value = sor3tintlaq;

            param[4] = new SqlParameter("@engine", SqlDbType.NVarChar,4000);
            param[4].Value = engine;

            param[5] = new SqlParameter("@dest", SqlDbType.NVarChar,4000);
            param[5].Value = dest;

            param[6] = new SqlParameter("@fuelsys", SqlDbType.NVarChar, 4000);
            param[6].Value = fuelsys;

            param[7] = new SqlParameter("@live", SqlDbType.NVarChar,4000);
            param[7].Value = live;

            param[8] = new SqlParameter("@payloadratio", SqlDbType.NVarChar, 4000);
            param[8].Value = payloadratio;

            param[9] = new SqlParameter("@bestpkacetoview", SqlDbType.NVarChar, 4000);
            param[9].Value = bestplacetoview;

            param[10] = new SqlParameter("@descreption", SqlDbType.NVarChar,4000);
            param[10].Value = descreption;

            DAL.Executecommand("uh", param);
            DAL.Close();
        }
        public DataTable gcm()
        {
            LaunchOmatic.DAL.DataacsessLayer DAL = new LaunchOmatic.DAL.DataacsessLayer();
            DataTable dt = new DataTable();
            dt = DAL.selectdata("gcm", null);
            return dt;
        }
        //this function to send parameters to sql from add products
        public void addp(string idp, string labelp, int qt, string pr, byte[] img, int idc)
        {
            LaunchOmatic.DAL.DataacsessLayer DAL = new LaunchOmatic.DAL.DataacsessLayer();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[6];

            param[0] = new SqlParameter("@idp", SqlDbType.VarChar,50);
            param[0].Value = idp;

            param[1] = new SqlParameter("@labelp", SqlDbType.VarChar,50);
            param[1].Value = labelp;

            param[2] = new SqlParameter("@qt", SqlDbType.Int);
            param[2].Value = qt;

            param[3] = new SqlParameter("@pr", SqlDbType.VarChar,50);
            param[3].Value = pr;

            param[4] = new SqlParameter("@img", SqlDbType.Image);
            param[4].Value = img;

            param[5] = new SqlParameter("@idc", SqlDbType.Int);
            param[5].Value = idc;

            DAL.Executecommand("addp", param);
            DAL.Close();
        }
        public DataTable activate(string ID)
        {
            LaunchOmatic.DAL.DataacsessLayer DAL = new LaunchOmatic.DAL.DataacsessLayer();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@ID",SqlDbType.NVarChar,50);
            param[0].Value = ID;
            dt = DAL.selectdata("activate",param);
            return dt;
        }
        public DataTable Getac()
        {
            LaunchOmatic.DAL.DataacsessLayer DAL = new LaunchOmatic.DAL.DataacsessLayer();
            DataTable dt = new DataTable();
            dt = DAL.selectdata("Getac", null);
            return dt;
        }
        public DataTable Searchp(string s)
        {
            LaunchOmatic.DAL.DataacsessLayer DAL = new LaunchOmatic.DAL.DataacsessLayer();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@s", SqlDbType.NVarChar, 4000);
            param[0].Value = s;
            dt = DAL.selectdata("serachinallcolumns", param);
            return dt;
        }
            public void Deletep(string @ID)
        {
            LaunchOmatic.DAL.DataacsessLayer DAL = new LaunchOmatic.DAL.DataacsessLayer();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@ID", SqlDbType.VarChar, 50);
            param[0].Value = ID;
            DAL.Executecommand("Deletep", param);
            DAL.Close();
        }
        public DataTable Simg(string ID)
        {
            LaunchOmatic.DAL.DataacsessLayer DAL = new LaunchOmatic.DAL.DataacsessLayer();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@ID", SqlDbType.VarChar, 50);
            param[0].Value = ID;
            dt = DAL.selectdata("Simg", param);
            return dt;
        }
        public void UPP(string idp, string labelp, int qt, string pr, byte[] img, int idc)
        {
            LaunchOmatic.DAL.DataacsessLayer DAL = new LaunchOmatic.DAL.DataacsessLayer();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[6];

            param[0] = new SqlParameter("@idp", SqlDbType.VarChar, 50);
            param[0].Value = idp;

            param[1] = new SqlParameter("@labelp", SqlDbType.VarChar, 50);
            param[1].Value = labelp;

            param[2] = new SqlParameter("@qt", SqlDbType.Int);
            param[2].Value = qt;

            param[3] = new SqlParameter("@pr", SqlDbType.VarChar, 50);
            param[3].Value = pr;

            param[4] = new SqlParameter("@img", SqlDbType.Image);
            param[4].Value = img;

            param[5] = new SqlParameter("@idc", SqlDbType.Int);
            param[5].Value = idc;

            DAL.Executecommand("UPP", param);
            DAL.Close();
        }
    }
}
