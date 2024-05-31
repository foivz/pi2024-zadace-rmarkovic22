using DBLayer;
using MyDocDesktopApp.models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyDocDesktopApp.Repositories
{
    internal class PacijentiRepository
    {
        public static List<Pacijent> GetPacijenti()
        {
            List<Pacijent> pacijents = new List<Pacijent>();
            string sql = "SELECT * FROM Pacijenti";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            while (reader.Read())
            {
                Pacijent pacijent = CreateObject(reader);
                pacijents.Add(pacijent);
            }
            reader.Close();
            DB.CloseConnection();
            return pacijents;
        }
        private static Pacijent CreateObject(SqlDataReader reader)
        {
            int id = int.Parse(reader["Id"].ToString());
            string Ime = reader["Ime"].ToString();
            string Prezime = reader["Prezime"].ToString();
            string Email = reader["Email"].ToString();
            string Kontakt = reader["Kontakt"].ToString();
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
        public static void InsertPacijent(string ime, string prezime, string email, string kontakt)
        {
            string sql = $"INSERT INTO Pacijenti (Ime, Prezime, Email, KOntakt) VALUES ('{ime}','{prezime}', '{email}','{kontakt}')";
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }
        public static void DeletePacijent(string ime, string prezime, string email, string kontakt)
        {
            string sql = $"DELETE Pacijenti  (Ime, Prezime, Email, KOntakt) VALUES ('{ime}','{prezime}', '{email}','{kontakt}')";
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }

    }
}
