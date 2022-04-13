using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chcete_byt_EXPERTEM
{
    public partial class Database : Form
    {
        List<QuestionHelper> questions = new List<QuestionHelper>();

        public Database()
        {
            InitializeComponent();
            //transparent();
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;

            LoadQuestions();
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handleParams = base.CreateParams;
                handleParams.ExStyle |= 0x02000000;
                return handleParams;
            }
        }

        private void loadBase()
        {
            questions.Add(new QuestionHelper { otazka = "Otazka1", odpoved_1 = "odpoved_1", odpoved_2 = "odpoved_2", odpoved_3 = "odpoved_3", odpoved_4 = "odpoved_4", spravna_odpoved = 1 ,obor = "kokot", obtiznost = 1 });
        }

        private void transparent()
        {
            
        }

        private void LoadQuestions()
        {
            questions = DatabaseHelper.LoadQuestions();

            WireUpList();
        }

        private void WireUpList()
        {
            dataGridView1.Columns.Clear();
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Add("id", "Řádek");
            dataGridView1.Columns.Add("otazka", "Otázka");
            dataGridView1.Columns.Add("odpoved_1", "Odpověd 1");
            dataGridView1.Columns.Add("odpoved_2", "Odpověd 2");
            dataGridView1.Columns.Add("odpoved_3", "Odpověd 3");
            dataGridView1.Columns.Add("odpoved_4", "Odpověd 4");
            dataGridView1.Columns.Add("spravna_odpoved", "Správná odpověd");
            dataGridView1.Columns.Add("obor", "Obor");
            dataGridView1.Columns.Add("obtiznost", "Obtížnost");

            try
            {
                foreach(QuestionHelper questionHelper in questions)
                {
                    dataGridView1.Rows.Add(questionHelper.id, questionHelper.otazka, questionHelper.odpoved_1, questionHelper.odpoved_2, questionHelper.odpoved_3, questionHelper.odpoved_4, questionHelper.spravna_odpoved, questionHelper.obor, questionHelper.obtiznost);
                }
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (checkBox() != 0)
            {
                int obt = 11;

                try
                {
                    obt = Int32.Parse(obtiznost.Text);
                }
                catch (FormatException ex)
                {
                }

                if (obt > 0 && obt < 11)
                {
                    QuestionHelper questionHelper = new QuestionHelper();
                    questionHelper.otazka = Otazka.Text;
                    questionHelper.odpoved_1 = odpoved1.Text;
                    questionHelper.odpoved_2 = odpoved2.Text;
                    questionHelper.odpoved_3 = odpoved3.Text;
                    questionHelper.odpoved_4 = odpoved4.Text;
                    questionHelper.spravna_odpoved = checkBox();
                    questionHelper.obor = obor.Text;
                    questionHelper.obtiznost = Int32.Parse(obtiznost.Text);
                    DatabaseHelper.saveQuestion(questionHelper);

                    LoadQuestions();
                    
                    clear();
                }
                else
                {
                    MessageBox.Show("Špatná obtížnost", "Pouze 1-10");
                }
            }
            else
            {
                MessageBox.Show("Není vybrána správná odpověď");
            }
        }


        private void clear()
        {
            Otazka.Text = "";
            odpoved1.Text = "";
            odpoved2.Text = "";
            odpoved3.Text = "";
            odpoved4.Text = "";
            obor.Text = "";
            obtiznost.Text = "";
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
        }

        private void unCheck(int button)
        {
            if (button == 1)
            {
                checkBox2.Checked = false;
                checkBox3.Checked = false;
                checkBox4.Checked = false;
            }
            if (button == 2)
            {
                checkBox1.Checked = false;
                checkBox3.Checked = false;
                checkBox4.Checked = false;
            }
            if (button == 3)
            {
                checkBox1.Checked = false;
                checkBox2.Checked = false;
                checkBox4.Checked = false;
            }
            if (button == 4)
            {
                checkBox1.Checked = false;
                checkBox2.Checked = false;
                checkBox3.Checked = false;
            }
        }

        private int checkBox()
        {
            if (checkBox1.Checked)
            {
                return 1;
            }
            else if (checkBox2.Checked)
            {
                return 2;
            }
            else if (checkBox3.Checked)
            {
                return 3;
            }
            else if (checkBox4.Checked)
            {
                return 4;
            }
            else
            {
                return 0;
            }
        }

        private void checkBox1_Click(object sender, EventArgs e)
        {
            checkBox1.Checked = true;
            unCheck(1);
        }

        private void checkBox2_Click(object sender, EventArgs e)
        {
            checkBox2.Checked = true;
            unCheck(2);
        }

        private void checkBox3_Click(object sender, EventArgs e)
        {
            checkBox3.Checked = true;
            unCheck(3);
        }

        private void checkBox4_Click(object sender, EventArgs e)
        {
            checkBox4.Checked = true;
            unCheck(4);
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            List<Guna2CustomCheckBox> boxy = new List<Guna2CustomCheckBox>(new Guna2CustomCheckBox[] { checkBox1, checkBox2, checkBox3, checkBox4 });
            
            if (e.RowIndex >= 0 && dataGridView1.Rows[e.RowIndex].Cells[0].Value != null)
            {
                try
                {
                    int id = Int32.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                    var quest = DatabaseHelper.getQuestion(id);
                    clear();
                    Otazka.Text = quest.otazka;
                    odpoved1.Text = quest.odpoved_1;
                    odpoved2.Text = quest.odpoved_2;
                    odpoved3.Text = quest.odpoved_3;
                    odpoved4.Text = quest.odpoved_4;
                    obor.Text = quest.obor;
                    obtiznost.Text = quest.obtiznost.ToString();
                    boxy[quest.spravna_odpoved - 1].Checked = true;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
