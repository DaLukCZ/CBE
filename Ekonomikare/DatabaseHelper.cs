using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Configuration;
using Dapper;
using System.Data.SQLite;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Chcete_byt_EXPERTEM
{
    internal class DatabaseHelper
    {

        public static List<QuestionHelper> LoadQuestions()
        {
            using (IDbConnection conn = new SQLiteConnection(LoadConnectionString()))
            {
                try
                {
                    var result = conn.Query<QuestionHelper>("select * from Testy", new DynamicParameters());
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

        public static void saveQuestion(QuestionHelper helper)
        {
            using (SQLiteConnection conn = new SQLiteConnection(LoadConnectionString()))
            {
                try
                {
                    conn.Open();
                    SQLiteCommand cmd = new SQLiteCommand(conn);
                    cmd.CommandText = "INSERT INTO Testy (otazka, odpoved_1, odpoved_2, odpoved_3, odpoved_4, spravna_odpoved, obor, obtiznost) VALUES (@otazka, @odpoved_1, @odpoved_2, @odpoved_3, @odpoved_4, @spravna_odpoved, @obor, @obtiznost)";
                    cmd.Prepare();
                    cmd.Parameters.AddWithValue("@otazka", helper.otazka);
                    cmd.Parameters.AddWithValue("@odpoved_1", helper.odpoved_1);
                    cmd.Parameters.AddWithValue("@odpoved_2", helper.odpoved_2);
                    cmd.Parameters.AddWithValue("@odpoved_3", helper.odpoved_3);
                    cmd.Parameters.AddWithValue("@odpoved_4", helper.odpoved_4);
                    cmd.Parameters.AddWithValue("@spravna_odpoved", helper.spravna_odpoved);
                    cmd.Parameters.AddWithValue("@obor", helper.obor);
                    cmd.Parameters.AddWithValue("@obtiznost", helper.obtiznost);
                    cmd.ExecuteNonQuery();   
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        public static void UpdateQuestion(QuestionHelper helper)
        {
            using (SQLiteConnection conn = new SQLiteConnection(LoadConnectionString()))
            {
                try
                { 
                    conn.Open();

                    conn.Execute("update Testy set otazka = @otazka, odpoved_1 = @odpoved_1, odpoved_2 = @odpoved_2, odpoved_3 = @odpoved_3, odpoved_4 = @odpoved_4, spravna_odpoved = @spravna_odpoved, obor = @obor, obtiznost = @obtiznost", helper);

                } catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                } finally
                {
                    conn.Close();
                }
            }
        }

        public static QuestionHelper getQuestion(int id)
        {
            using (SQLiteConnection conn = new SQLiteConnection(LoadConnectionString()))
            {
                try
                {
                    conn.Open();
                    Console.WriteLine("ahoj");
                    string sql = "SELECT * FROM Testy WHERE id = @id";
                    SQLiteCommand cmd = new SQLiteCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@id", id);
                    SQLiteDataReader reader = cmd.ExecuteReader();
                    QuestionHelper ques = new QuestionHelper();
                    while (reader.Read())
                    {                        
                        ques.otazka = reader.GetString(1);
                        ques.odpoved_1 = reader.GetString(2);
                        ques.odpoved_2 = reader.GetString(3);
                        ques.odpoved_3 = reader.GetString(4);
                        ques.odpoved_4 = reader.GetString(5);
                        ques.spravna_odpoved = reader.GetInt32(6);
                        ques.obor = reader.GetString(7);
                        ques.obtiznost = reader.GetInt32(8);
                    }
                    return ques;
                }
                catch (Exception ex)
                {
                    //MessageBox.Show(ex.Message);
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
