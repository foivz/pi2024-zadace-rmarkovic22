using DBLayer;
using MyDocDesktopApp.models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDocDesktopApp.Repositories
{
    public class PacijentRepository
    {
        public static Pacijent GetPacijent(int id)
        {
            Pacijent pacijent = null;
            string sql = $"SELECT * FROM Pacijent WHERE Id = {id}";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            if (reader.HasRows)
            {
                reader.Read();
                pacijent = CreateObject(reader);
                reader.Close();
            }
            DB.CloseConnection();
            return pacijent;
        }

        private static Pacijent CreateObject(SqlDataReader reader)
        {
            int id = int.Parse(reader["Id"].ToString());
            string Ime = reader["Ime"].ToString();
            string Prezime = reader["Prezime"].ToString();
            string Email = reader["email"].ToString();
            string Kontakt = reader["kontakt"].ToString();    
            var pacijent = new Pacijent
            {
                Id = id,
                Ime = Ime,
                Prezime = Prezime,
                Email = Email,
                Kontakt = Kontakt
                
            };
            return pacijent;
        }

    }

}
