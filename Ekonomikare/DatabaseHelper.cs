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

        public static void SaveQuestion(QuestionHelper helper)
        {
            using (SQLiteConnection conn = new SQLiteConnection(LoadConnectionString()))
            {
                try
                {
                    conn.Open();
                    string sql = "INSERT INTO Testy (otazka,odpoved_1,odpoved_2,odpoved_3,odpoved_4,spravna_odpoved,obor,obtiznost) VALUES (@otazka,@odpoved_1,@odpoved_2,@odpoved_3,@odpoved_4,@spravna_odpoved,@obor,@obtiznost)";
                    SQLiteCommand cmd = new SQLiteCommand(sql, conn);
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

                    if(oborExists(helper))
                    {
                        Console.WriteLine("obor existuje");
                    }else
                    {
                        string sql2 = "INSERT INTO Obory (obor_nazev) VALUES (@obor_nazev)";
                        SQLiteCommand cmd2 = new SQLiteCommand(sql2, conn);
                        cmd2.Prepare();
                        cmd2.Parameters.AddWithValue("@obor_nazev", helper.obor);
                        cmd2.ExecuteNonQuery();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }finally
                {
                    conn.Close();
                }
            }
        }

        private static bool oborExists(QuestionHelper helper)
        {

            using (SQLiteConnection conn = new SQLiteConnection(LoadConnectionString()))
            {
                try
                {
                    Console.WriteLine(helper.obor);
                    conn.Open();
                    string sql = "SELECT * FROM Obory WHERE obor_nazev = @obor";
                    SQLiteCommand command = new SQLiteCommand(sql, conn);
                    command.Prepare();
                    command.Parameters.AddWithValue("@obor", helper.obor);
                    
                    SQLiteDataReader reader = command.ExecuteReader();
                    if(reader.Read())
                    {
                        return true;
                    } else
                    {
                        return false;
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return false;
                }
                finally
                {
                    conn.Close();
                }
                
            }
        }

        /**
         *Function for question update 
         */
        public static void UpdateQuestion(QuestionHelper helper)
        {
            using (SQLiteConnection conn = new SQLiteConnection(LoadConnectionString()))
            {
                try
                {
                    conn.Open();

                    conn.Execute("update Testy set otazka = @otazka, odpoved_1 = @odpoved_1, odpoved_2 = @odpoved_2, odpoved_3 = @odpoved_3, odpoved_4 = @odpoved_4, spravna_odpoved = @spravna_odpoved, obor = @obor, obtiznost = @obtiznost WHERE id = @id", helper);

                    if (oborExists(helper))
                    {
                        Console.WriteLine("obor existuje");
                    }
                    else
                    {
                        string sql2 = "INSERT INTO Obory (obor_nazev) VALUES (@obor_nazev)";
                        SQLiteCommand cmd2 = new SQLiteCommand(sql2, conn);
                        cmd2.Prepare();
                        cmd2.Parameters.AddWithValue("@obor_nazev", helper.obor);
                        cmd2.ExecuteNonQuery();
                    }
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

        public static void DeleteQuestion(QuestionHelper helper)
        {
            using (SQLiteConnection conn = new SQLiteConnection(LoadConnectionString()))
            {
                try
                {
                    conn.Open();
                    conn.Execute("DELETE FROM Testy WHERE id = @id", helper);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }finally
                {
                    conn.Close();
                }
            }
        }

        public static List<QuestionHelper> FilterQuestions(string obor_nazev)
        {
            using (SQLiteConnection conn = new SQLiteConnection(LoadConnectionString()))
            {
                try
                {
                    conn.Open();
                    string sql = "SELECT * FROM Testy WHERE obor = @obor_nazev";
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

        public static QuestionHelper getQuestion(int id)
        {
            using (SQLiteConnection conn = new SQLiteConnection(LoadConnectionString()))
            {
                try
                {
                    conn.Open();
                    string sql = "SELECT * FROM Testy WHERE id = @id";
                    SQLiteCommand cmd = new SQLiteCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@id", id);
                    SQLiteDataReader reader = cmd.ExecuteReader();
                    QuestionHelper ques = new QuestionHelper();
                    while (reader.Read())
                    {
                        ques.id = reader.GetInt32(0);
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
                    MessageBox.Show(ex.Message);
                    return null;
                }
            }
        }

        public static List<ScopesHelper> getScopes()
        {
            using (SQLiteConnection conn = new SQLiteConnection(LoadConnectionString()))
            {
                try
                {
                    var result = conn.Query<ScopesHelper>("select * from Obory", new DynamicParameters());
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

        private static string LoadConnectionString(string id = "App")
        {   
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
