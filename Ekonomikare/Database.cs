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
        List<ScopesHelper> scopes = new List<ScopesHelper>();


        public Database()
        {
            InitializeComponent();
            //transparent();
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            Calibration();
            LoadQuestions();
            fillComboBox();
        }

        public int getSizeW()
        {
            int screenWidth = Screen.PrimaryScreen.Bounds.Width;
            decimal screenWidthPercent = (decimal)screenWidth / 1920 * 100;
            return (int)screenWidthPercent;
        }

        public int getSizeH()
        {
            int screenHeight = Screen.PrimaryScreen.Bounds.Height;
            decimal screenHeightPercent = (decimal)screenHeight / 1080 * 100;
            return (int)screenHeightPercent;
        }

        public void Calibration()
        {
            int Width = getSizeW();
            int Height = getSizeH();

            quesId.Size = new Size((54 * Width) / 100, (20 * Height) / 100);
            quesId.Location = new Point((754 * Width) / 100, (12 * Height) / 100);
            quesId.Font = new Font(quesId.Font.Name, (8 * Width) / 100, quesId.Font.Style);

            label6.Size = new Size((375 * Width) / 100, (43 * Height) / 100);
            label6.Location = new Point((12 * Width) / 100, (31 * Height) / 100);
            label6.Font = new Font(label6.Font.Name, (19 * Width) / 100, label6.Font.Style);

            Otazka.Size = new Size((926 * Width) / 100, (150 * Height) / 100);
            Otazka.Location = new Point((10 * Width) / 100, (77 * Height) / 100);
            Otazka.Font = new Font(Otazka.Font.Name, (28 * Width) / 100, Otazka.Font.Style);

            label5.Size = new Size((375 * Width) / 100, (35 * Height) / 100);
            label5.Location = new Point((10 * Width) / 100, (230 * Height) / 100);
            label5.Font = new Font(label5.Font.Name, (19 * Width) / 100, label5.Font.Style);

            odpoved1.Size = new Size((800 * Width) / 100, (100 * Height) / 100);
            odpoved1.Location = new Point((10 * Width) / 100, (268 * Height) / 100);
            odpoved1.Font = new Font(odpoved1.Font.Name, (28 * Width) / 100, odpoved1.Font.Style);

            label1.Size = new Size((375 * Width) / 100, (35 * Height) / 100);
            label1.Location = new Point((12 * Width) / 100, (371 * Height) / 100);
            label1.Font = new Font(label1.Font.Name, (19 * Width) / 100, label1.Font.Style);

            odpoved4.Size = new Size((800 * Width) / 100, (100 * Height) / 100);
            odpoved4.Location = new Point((8 * Width) / 100, (692 * Height) / 100);
            odpoved4.Font = new Font(odpoved4.Font.Name, (28 * Width) / 100, odpoved4.Font.Style);

            label2.Size = new Size((375 * Width) / 100, (35 * Height) / 100);
            label2.Location = new Point((12 * Width) / 100, (512 * Height) / 100);
            label2.Font = new Font(label2.Font.Name, (19 * Width) / 100, label2.Font.Style);

            odpoved2.Size = new Size((800 * Width) / 100, (100 * Height) / 100);
            odpoved2.Location = new Point((10 * Width) / 100, (409 * Height) / 100);
            odpoved2.Font = new Font(odpoved2.Font.Name, (28 * Width) / 100, odpoved2.Font.Style);

            label3.Size = new Size((375 * Width) / 100, (35 * Height) / 100);
            label3.Location = new Point((10 * Width) / 100, (654 * Height) / 100);
            label3.Font = new Font(label3.Font.Name, (19 * Width) / 100, label3.Font.Style);

            odpoved3.Size = new Size((800 * Width) / 100, (100 * Height) / 100);
            odpoved3.Location = new Point((8 * Width) / 100, (551 * Height) / 100);
            odpoved3.Font = new Font(odpoved3.Font.Name, (28 * Width) / 100, odpoved3.Font.Style);

            label4.Size = new Size((375 * Width) / 100, (35 * Height) / 100);
            label4.Location = new Point((10 * Width) / 100, (795 * Height) / 100);
            label4.Font = new Font(label4.Font.Name, (19 * Width) / 100, label4.Font.Style);

            obor.Size = new Size((650 * Width) / 100, (50 * Height) / 100);
            obor.Location = new Point((8 * Width) / 100, (833 * Height) / 100);
            obor.Font = new Font(obor.Font.Name, (28 * Width) / 100, obor.Font.Style);

            obtiznost.Size = new Size((200 * Width) / 100, (50 * Height) / 100);
            obtiznost.Location = new Point((763 * Width) / 100, (833 * Height) / 100);
            obtiznost.Font = new Font(obtiznost.Font.Name, (28 * Width) / 100, obtiznost.Font.Style);


            label7.Size = new Size((206 * Width) / 100, (35 * Height) / 100);
            label7.Location = new Point((730 * Width) / 100, (795 * Height) / 100);
            label7.Font = new Font(label7.Font.Name, (19 * Width) / 100, label7.Font.Style);

            checkBox1.Size = new Size((100 * Width) / 100, (100 * Height) / 100);
            checkBox1.Location = new Point((836 * Width) / 100, (268 * Height) / 100);
            checkBox1.Font = new Font(checkBox1.Font.Name, (8 * Width) / 100, checkBox1.Font.Style);

            checkBox2.Size = new Size((100 * Width) / 100, (100 * Height) / 100);
            checkBox2.Location = new Point((836 * Width) / 100, (409 * Height) / 100);
            checkBox2.Font = new Font(checkBox2.Font.Name, (8 * Width) / 100, checkBox2.Font.Style);

            checkBox3.Size = new Size((100 * Width) / 100, (100 * Height) / 100);
            checkBox3.Location = new Point((836 * Width) / 100, (551 * Height) / 100);
            checkBox3.Font = new Font(checkBox3.Font.Name, (8 * Width) / 100, checkBox3.Font.Style);

            checkBox4.Size = new Size((100 * Width) / 100, (100 * Height) / 100);
            checkBox4.Location = new Point((836 * Width) / 100, (692 * Height) / 100);
            checkBox4.Font = new Font(checkBox4.Font.Name, (8 * Width) / 100, checkBox4.Font.Style);

            button3.Size = new Size((390 * Width) / 100, (38 * Height) / 100);
            button3.Location = new Point((971 * Width) / 100, (60 * Height) / 100);
            button3.Font = new Font(button3.Font.Name, (17 * Width) / 100, button3.Font.Style);

            dataGridView1.Size = new Size((904 * Width) / 100, (642 * Height) / 100);
            dataGridView1.Location = new Point((977 * Width) / 100, (137 * Height) / 100);
            dataGridView1.Font = new Font(dataGridView1.Font.Name, (8 * Width) / 100, dataGridView1.Font.Style);

            textBox3.Size = new Size((926 * Width) / 100, (664 * Height) / 100);
            textBox3.Location = new Point((966 * Width) / 100, (128 * Height) / 100);
            textBox3.Font = new Font(textBox3.Font.Name, (24 * Width) / 100, textBox3.Font.Style);

            button1.Size = new Size((440 * Width) / 100, (42 * Height) / 100);
            button1.Location = new Point((971 * Width) / 100, (836 * Height) / 100);
            button1.Font = new Font(button1.Font.Name, (19 * Width) / 100, button1.Font.Style);

            button2.Size = new Size((440 * Width) / 100, (42 * Height) / 100);
            button2.Location = new Point((1447 * Width) / 100, (836 * Height) / 100);
            button2.Font = new Font(button2.Font.Name, (17 * Width) / 100, button2.Font.Style);

            dropDown.Font = new Font(dropDown.Font.Name, (24 * Width) / 100, dropDown.Font.Style);
            dropDown.Size = new Size((400 * Width) / 100, (47 * Height) / 100);
            dropDown.Location = new Point((1492 * Width) / 100, (54 * Height) / 100);

            textBox1.Size = new Size((450 * Width) / 100, (50 * Height) / 100);
            textBox1.Location = new Point((966 * Width) / 100, (833 * Height) / 100);
            textBox1.Font = new Font(textBox1.Font.Name, (28 * Width) / 100, textBox1.Font.Style);

            textBox2.Size = new Size((450 * Width) / 100, (50 * Height) / 100);
            textBox2.Location = new Point((1442 * Width) / 100, (833 * Height) / 100);
            textBox2.Font = new Font(textBox2.Font.Name, (28 * Width) / 100, textBox2.Font.Style);

            textBox4.Size = new Size((400 * Width) / 100, (47 * Height) / 100);
            textBox4.Location = new Point((966 * Width) / 100, (54 * Height) / 100);
            textBox4.Font = new Font(textBox4.Font.Name, (28 * Width) / 100, textBox4.Font.Style);

            button_save.Size = new Size((930 * Width) / 100, (137 * Height) / 100);
            button_save.Location = new Point((12 * Width) / 100, (931 * Height) / 100);
            button_save.Font = new Font(button_save.Font.Name, (28 * Width) / 100, button_save.Font.Style);

            button_back.Size = new Size((930 * Width) / 100, (137 * Height) / 100);
            button_back.Location = new Point((982 * Width) / 100, (931 * Height) / 100);
            button_back.Font = new Font(button_back.Font.Name, (28 * Width) / 100, button_back.Font.Style);

            this.Size = new Size((1920 * Width) / 100, (1080 * Height) / 100);
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
            dataGridView1.Columns.Add("id", "ID");

            try
            {
                foreach(QuestionHelper questionHelper in questions)
                {
                    dataGridView1.Rows.Add(questionHelper.otazka, questionHelper.odpoved_1, questionHelper.odpoved_2, questionHelper.odpoved_3, questionHelper.odpoved_4, questionHelper.spravna_odpoved, questionHelper.obor, questionHelper.obtiznost, questionHelper.id);
                }

            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void fillComboBox()
        {
            var selectedItem = obor.Text;
            try
            {
                scopes = DatabaseHelper.getScopes();

                dropDown.Items.Clear();
                foreach (ScopesHelper scHelper in scopes)
                {
                    dropDown.Items.Add(scHelper.obor_nazev);
                }
                dropDown.Items.Add("Všechny");
                dropDown.Update();
                try
                {
                    dropDown.SelectedItem = selectedItem;
                } catch {}
            }
            catch (ArgumentNullException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormHandler.register.Hide();
            FormHandler.menu.Calibration();
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
                    DatabaseHelper.SaveQuestion(questionHelper);
                    LoadQuestions();
                    smallClear();
                    fillComboBox();
                }
                else
                {
                    questionHelper.id = Int32.Parse(quesId.Text);
                    DatabaseHelper.UpdateQuestion(questionHelper);
                    LoadQuestions();
                    fullClear();
                    fillComboBox();
                }           
            }
            FormHandler.settings.fillComboBox();
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


        public void fullClear()
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
        private void smallClear()
        {
            Otazka.Text = "";
            odpoved1.Text = "";
            odpoved2.Text = "";
            odpoved3.Text = "";
            odpoved4.Text = "";
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

            if (e.RowIndex >= 0 && dataGridView1.Rows[e.RowIndex].Cells[8].Value != null)
            {
                try
                {
                    int id = Int32.Parse(dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString());
                    var quest = DatabaseHelper.getQuestion(id);
                    fullClear();
                    quesId.Text = quest.id.ToString();
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

        private void button1_Click(object sender, EventArgs e)
        {
            fullClear();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            try
            {
                int id = Int32.Parse(quesId.Text);

                QuestionHelper helper = DatabaseHelper.getQuestion(id);
                DatabaseHelper.DeleteQuestion(helper);
                fillComboBox();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Vyberte co chcete vymazat","Není co vymazat!");
            }
            finally
            {
                LoadQuestions();
                fullClear();
            }
        }

        private void dropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dropDown.SelectedItem != "Všechny")
            {
                obor.Text = dropDown.SelectedItem + "";
            }
            else
            {
                obor.Text = "";
            }
            LoadQuestions();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            FormHandler.register.Calibration();
            FormHandler.register.clearPass();
            FormHandler.register.Show();
        }
    }
}
