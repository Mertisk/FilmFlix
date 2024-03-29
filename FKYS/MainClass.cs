
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using FKYS.Utils;
using FKYS.Core.Models;
using FKYS.Core.Enums;
using FKYS.Core.Interfaces;

namespace FKYS
{
    class MainClass
    {
        public static readonly string con_string = ConfigurationManager.ConnectionStrings["MyConn"].ConnectionString;
        public static SqlConnection con = new SqlConnection(con_string);

        public static bool IsValidUser(string username,string password)
        {
            bool isValid = false;

            string query = @"Select * From Kullanici Where Ad='" + username + "' and Sifre='" + password + "' and Aktif=1";
            SqlCommand cmd = new SqlCommand(query,con);
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);

            if(dt.Rows.Count > 0 )
            {
                isValid= true;
                if(Convert.ToInt32(dt.Rows[0]["KullaniciTurID"].ToString()) == (int)KullaniciTurEnum.Admin)
                {
                    Kullanici = dt.Rows[0].ToObject<Kullanici>();
                }
                else if (Convert.ToInt32(dt.Rows[0]["UyelikTurID"].ToString()) == (int)UyelikTurEnum.Premium)
                {
                    Kullanici = dt.Rows[0].ToObject<PremiumKullanici>();
                }
                else if (Convert.ToInt32(dt.Rows[0]["UyelikTurID"].ToString()) == (int)UyelikTurEnum.Standart)
                {
                    Kullanici = dt.Rows[0].ToObject<StandartKullanici>();
                }
            }
            return isValid;
        }
        
        public static bool isAdmin()
        {
            
            if(Kullanici.KullaniciTurID == (int)KullaniciTurEnum.Admin)
                return true;
            return false;
        }

        public static dynamic Kullanici { get; set; }
    }
}
