using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
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

            //TODO: pokusit se to spustit ve vlastnich vlaknech
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

        private void LoadQuestions()
        {
            string value = dropDown.Text;
            if (value == "" || value == "Všechny")
            {
                questions = DatabaseHelper.LoadQuestions();
                WireUpList();
            }
            else
            {
                questions = DatabaseHelper.FilterQuestions(value);
                WireUpList();
            }
        }

        private void WireUpList()
        {
            dataGridView1.Columns.Clear();
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Add("otazka", "Otázka");
            dataGridView1.Columns.Add("odpoved_1", "Odpověd 1");
            dataGridView1.Columns.Add("odpoved_2", "Odpověd 2");
            dataGridView1.Columns.Add("odpoved_3", "Odpověd 3");
            dataGridView1.Columns.Add("odpoved_4", "Odpověd 4");
            dataGridView1.Columns.Add("spravna_odpoved", "Správná odpověd");
            dataGridView1.Columns.Add("Obory.obor_nazev", "Název Oboru");
            dataGridView1.Columns.Add("obtiznost", "Obtížnost");
            dataGridView1.Columns.Add("obor", "ID Oboru");
            dataGridView1.Columns.Add("id", "ID");

            try
            {
                foreach(QuestionHelper questionHelper in questions)
                {
                    dataGridView1.Rows.Add(questionHelper.otazka, questionHelper.odpoved_1, questionHelper.odpoved_2, questionHelper.odpoved_3, questionHelper.odpoved_4, questionHelper.spravna_odpoved, questionHelper.obor, questionHelper.obtiznost, questionHelper.obor, questionHelper.id);
                }

            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormHandler.menu.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (checkOtazka(Otazka.Text) && checkOdpovedi(odpoved1.Text, 1) && checkOdpovedi(odpoved2.Text, 2) && checkOdpovedi(odpoved3.Text, 3) && checkOdpovedi(odpoved4.Text, 4) && checkObor(obor.Text) && checkObtiznost(obtiznost.Text) && checkBoxBool() && checkBox() != 0)
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

                if (quesId.Text == "")
                {                 
                    //DatabaseHelper.SaveQuestion(questionHelper);
                    LoadQuestions();
                    clear();
                }           
            }
    }

        private bool checkOtazka(string otazka)
        {
            if(otazka.Length > 0 && otazka.Length < 129)
            {
                return true;
            }
            else if(otazka == "")
            {
                MessageBox.Show("Zadejte otázku", "Nebyla zadána otázka!");
                return false;
            }
            else
            {
                MessageBox.Show("Musí být v rozmezí 1-128 znáků", "Špatná délka otázky!");
                return false;
            }
        }

        private bool checkOdpovedi(string odpovedText, int odpovedCislo)
        {
            if (odpovedText.Length > 0 && odpovedText.Length < 61)
            {
                return true;
                
            }
            else if (odpovedText == "")
            {
                MessageBox.Show("Zadejte odpověď", "Nebyla zadána odpověď číslo " + odpovedCislo + "!");
                return false;
            }
            else
            {
                MessageBox.Show("Musí být v rozmezí 1-60 znáků", "Špatná délká odpovědi číslo " + odpovedCislo + "!");
                return false;
            }
        }

        private bool checkObor(string obor)
        {
            if (obor.Length >= 15 && obor.Length < 16)
            {
                MessageBox.Show("Překročil jste název oboru o " + (obor.Length - 14) + " znak. Maximálně 14 znaků", "Příliš dlouhý název!");
                return false;
            }
            else if (obor.Length >= 16 && obor.Length < 19)
            {
                MessageBox.Show("Překročil jste název oboru o " + (obor.Length - 14) + " znaky. Maximálně 14 znaků", "Příliš dlouhý název!");
                return false;
            }
            else if (obor.Length >= 19)
            {
                MessageBox.Show("Překročil jste název oboru o " + (obor.Length - 14) + " znaků. Maximálně 14 znaků", "Příliš dlouhý název!");
                return false;
            }
            else if(obor == "")
            {
                MessageBox.Show("Zadejte název oboru", "Nebyl zadán název oboru!");
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool checkObtiznost(string ob)
        {
            int obt = 11;
            try
            {
                obt = Int32.Parse(ob);
            }
            catch (FormatException ex)
            {

            }
            if (obt > 0 && obt < 11)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Pouze v rozmezí 1-10", "Špatná obtížnost!");
                return false;
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
            quesId.Text = "";
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
        private bool checkBoxBool()
        {
            if (checkBox1.Checked || checkBox2.Checked || checkBox3.Checked || checkBox4.Checked)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Musíte vybrat správnou odpověď", "Není vybrána správná odpověď!");
                return false;
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
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            try
            {
                int id = Int32.Parse(quesId.Text);
                QuestionHelper helper = new QuestionHelper();
                helper.id = id;
                //DatabaseHelper.DeleteQuestion(helper);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Vyberte co chcete vymazat","Není co vymazat!");
            }
            finally
            {
                LoadQuestions();
                clear();
            }
        }

        private void dropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadQuestions();
        }
    }
}
