using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace notepad
{
    public partial class Menu : Form
    {

        public Menu()
        {
            InitializeComponent();
            this.Text = Properties.Settings.Default.newDocName + " - " + Properties.Settings.Default.programmName;
        }
        public Menu(string fileName) // Открытие программы документом
        {
            InitializeComponent();
            if (!string.IsNullOrEmpty(fileName) && File.Exists(fileName))
            {
                try
                {
                    string programmName = Properties.Settings.Default.programmName;
                    FileStream file = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                    StreamReader reader = new StreamReader(file, Encoding.Default);
                    textBox.Text = reader.ReadToEnd();
                    reader.Close();
                    docPath = fileName;
                    tbChange = false;
                    this.Text = Path.GetFileName(fileName) + " — " + programmName;
                    textBox.Select(0, 0);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        bool tbChange = false;//индикатор изменения текста
        string docPath = "";
        private void создатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tbChange == true)
{
    DialogResult message = MessageBox.Show("Сохранить текущий документ перед созданием нового?", "Создание документа", MessageBoxButtons.YesNoCancel);
    if (message == DialogResult.Yes)
    {
        if (docPath != "")
        {
            FileWorks.SaveFile(ref textBox, ref tbChange, ref docPath);
            FileWorks.CreateFile(ref textBox, ref tbChange, ref docPath);
        }
        else if (docPath == "")
        {
            FileWorks.SaveAsFile(ref textBox, ref tbChange, ref docPath);
            FileWorks.CreateFile(ref textBox, ref tbChange, ref docPath);
        }
    }
    else if (message == DialogResult.No)
    {
        FileWorks.CreateFile(ref textBox, ref tbChange, ref docPath);
    }
}
else
{
    FileWorks.CreateFile(ref textBox, ref tbChange, ref docPath);
}
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void времяИДатаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox.AppendText(Environment.NewLine + Convert.ToString(System.DateTime.Now));
        }

        private void Transfer_Click(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            tbChange = true;
            TextWork.StatusAnalize(ref textBox, ref StatusLinesCount, ref WordCount, ref SpaceCount, ref CountNotSpace);

            TextWork.mEditEnableds(ref textBox, ref EditCopy, ref EditCut, ref EditDel, ref EditFind, ref EditGo);
        }

        private void FormMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Menu_Load(object sender, EventArgs e)
        {
            this.Width = Properties.Settings.Default.formWidth;
            this.Height = Properties.Settings.Default.formHeight;
            textBox.Font = Properties.Settings.Default.textFont;
            if (Properties.Settings.Default.statusStripVisible == true)
            { StatusStrip.CheckState = CheckState.Checked; }
            else
            { StatusStrip.CheckState = CheckState.Unchecked; }
            if (Properties.Settings.Default.textTransfer == true)
            { Transfer.CheckState = CheckState.Checked; }
            else
            { Transfer.CheckState = CheckState.Unchecked; }
        }

        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.formWidth = this.Width;
            Properties.Settings.Default.formHeight = this.Height;
            Properties.Settings.Default.textTransfer = textBox.WordWrap;
            Properties.Settings.Default.textFont = textBox.Font;
            Properties.Settings.Default.statusStripVisible = textBox.Visible;
            Properties.Settings.Default.Save();
            if (tbChange == true)
            {
                DialogResult message = MessageBox.Show("Сохранить текущий документ перед выходом?", "Выход из программы", MessageBoxButtons.YesNoCancel);
                if (message == DialogResult.Yes)
                {
                    if (docPath != "")
                    {
                        FileWorks.SaveFile(ref textBox, ref tbChange, ref docPath);
                        Application.Exit();
                    }
                    else if (docPath == "")
                    {
                        FileWorks.SaveAsFile(ref textBox, ref tbChange, ref docPath);
                        Application.Exit();
                    }
                }
                else if (message == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }

        }

        private void файлToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void FileOpen_Click(object sender, EventArgs e)
        {
            if (tbChange == true)
            {
                DialogResult message = MessageBox.Show("Сохранить текущий документ перед открытием нового?", "Открытие документа", MessageBoxButtons.YesNoCancel);
                if (message == DialogResult.Yes)
                {
                    if (docPath != "")
                    {
                        FileWorks.SaveFile(ref textBox, ref tbChange, ref docPath);
                        FileWorks.OpenFile(ref textBox, ref tbChange, ref docPath);
                    }
                    else if (docPath == "")
                    {
                        FileWorks.SaveAsFile(ref textBox, ref tbChange, ref docPath);
                        FileWorks.OpenFile(ref textBox, ref tbChange, ref docPath);
                    }
                }
                else if (message == DialogResult.No)
                {
                    FileWorks.OpenFile(ref textBox, ref tbChange, ref docPath);
                }
                else
                {
                    return;
                }
            }
            else
            {
                FileWorks.OpenFile(ref textBox, ref tbChange, ref docPath);
            }
        }

        private void FileSave_Click(object sender, EventArgs e)
        {
            if (docPath != "")
            {
                FileWorks.SaveFile(ref textBox, ref tbChange, ref docPath);
            }
            else
            {
                FileWorks.SaveAsFile(ref textBox, ref tbChange, ref docPath);
            }
        }

        private void FileSaveAs_Click(object sender, EventArgs e)
        {
            FileWorks.SaveAsFile(ref textBox, ref tbChange, ref docPath);
        }

        private void FilePageParam_Click(object sender, EventArgs e)
        {
            if (pageSetupDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument.DefaultPageSettings = pageSetupDialog.PageSettings;
            }
        }

        private void FilePrint_Click(object sender, EventArgs e)
        {
            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    printDocument.Print();
                }
                catch (Exception)
                {
                    MessageBox.Show("Ошибка параметров печати.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void EditCansel_Click(object sender, EventArgs e)
        {
            textBox.Undo();
        }

        private void EditCut_Click(object sender, EventArgs e)
        {
            if (textBox.SelectionLength > 0)
            {
                textBox.Cut();
            }

        }

        private void EditCopy_Click(object sender, EventArgs e)
        {
            if (textBox.SelectionLength > 0)
            {
                textBox.Copy();
            }

        }

        private void EditPaste_Click(object sender, EventArgs e)
        {
            textBox.Paste();
        }

        private void EditDel_Click(object sender, EventArgs e)
        {
            if (textBox.SelectionLength > 0)
            {
                textBox.SelectedText = "";
            }

        }

        private void EditGiveAll_Click(object sender, EventArgs e)
        {
            textBox.SelectAll();
        }

        private void EditFind_Click(object sender, EventArgs e)
        {
            FormSearch findText = new FormSearch();
            findText.Owner = this;
            findText.Show();
        }

        private void EditGo_Click(object sender, EventArgs e)
        {
            FormGoTo gotoform = new FormGoTo();
            gotoform.Owner = this;
            gotoform.numericUpDown.Minimum = 0;
            gotoform.numericUpDown.Maximum = textBox.Lines.Count();
            gotoform.ShowDialog();
        }

        private void EditGo_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void Font_Click(object sender, EventArgs e)
        {

            fontDialog1.Font = textBox.Font;
            DialogResult = fontDialog1.ShowDialog();
            if (DialogResult == DialogResult.OK)
            {
                textBox.Font = fontDialog1.Font;
            }
        }

        private void Transfer_CheckStateChanged(object sender, EventArgs e)
        {
            if (Transfer.CheckState == CheckState.Checked)
            {
                textBox.WordWrap = true;
                textBox.ScrollBars = ScrollBars.Vertical;
                EditGo.Enabled = false;
                StatusLines.Visible = false;
                StatusLinesCount.Visible = false;
            }
            else
            {
                textBox.WordWrap = false;
                textBox.ScrollBars = ScrollBars.Both;
                EditGo.Enabled = true;
                StatusLines.Visible = true;
                StatusLinesCount.Visible = true;
            }
        }

        private void StatusStrip_Click(object sender, EventArgs e)
        {
            if (StatusStrip.CheckState == CheckState.Checked)
            {
                statusStrip1.Visible = true;
            }
            else
            {
                statusStrip1.Visible = false;
            }
        }

        private void Help_Click(object sender, EventArgs e)
        {

            AboutForm about = new AboutForm();
            about.Show();
        }

        private void fontDialog1_Apply(object sender, EventArgs e)
        {

        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
