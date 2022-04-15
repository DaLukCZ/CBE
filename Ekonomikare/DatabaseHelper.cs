using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SQLite;
using System.Linq;
using System.Windows.Forms;

namespace Chcete_byt_EXPERTEM
{
    internal class DatabaseHelper
    {

        public static List<QuestionHelper> LoadQuestions()
        {
            using (SQLiteConnection conn = new SQLiteConnection(LoadConnectionString()))
            {
                try
                {
                    var result = conn.Query<QuestionHelper>("select Testy.id,Testy.otazka,Testy.odpoved_1,Testy.odpoved_2,Testy.odpoved_3,Testy.odpoved_4,Testy.spravna_odpoved, Testy.obor,Testy.obtiznost, Obory.obor_nazev from Testy INNER JOIN Obory ON Testy.obor = Obory.obor_id", new DynamicParameters());
                    conn.Close();
                    return result.ToList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return null;
                }
            }
        }

        public static void SaveQuestion()
        {
            using (SQLiteConnection conn = new SQLiteConnection(LoadConnectionString()))
            {

            }
        }

        public static List<QuestionHelper> FilterQuestions(string obor_nazev)
        {
            using (SQLiteConnection conn = new SQLiteConnection(LoadConnectionString()))
            {
                try
                {
                    conn.Open();
                    string sql = "select Testy.id,Testy.otazka,Testy.odpoved_1,Testy.odpoved_2,Testy.odpoved_3,Testy.odpoved_4,Testy.spravna_odpoved, Testy.obor,Testy.obtiznost, Obory.obor_nazev from Testy INNER JOIN Obory ON Testy.obor = Obory.obor_id WHERE Obory.obor_nazev = @obor_nazev";
                    SQLiteCommand cmd = new SQLiteCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@obor_nazev", obor_nazev);

                    SQLiteDataReader reader = cmd.ExecuteReader();
                    List<QuestionHelper> qesHelper = new List<QuestionHelper>();
                    while(reader.Read())
                    {
                        QuestionHelper questoins = new QuestionHelper();
                        questoins.id = Int32.Parse(reader["id"].ToString());
                        questoins.otazka = reader["otazka"].ToString();
                        questoins.odpoved_1 = reader["odpoved_1"].ToString();
                        questoins.odpoved_2 = reader["odpoved_2"].ToString();
                        questoins.odpoved_3 = reader["odpoved_3"].ToString();
                        questoins.odpoved_4 = reader["odpoved_4"].ToString();
                        questoins.spravna_odpoved = Int32.Parse(reader["spravna_odpoved"].ToString());
                        questoins.obor = reader["obor"].ToString();
                        questoins.obtiznost = Int32.Parse(reader["obtiznost"].ToString());

                        qesHelper.Add(questoins);
                    }

                    return qesHelper;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return null;
                }
            }
        }


      
        private static string LoadConnectionString(string id = "App")
        {   
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
