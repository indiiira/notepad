
namespace notepad
{
    partial class Menu
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.FormMenu = new System.Windows.Forms.MenuStrip();
            this.File = new System.Windows.Forms.ToolStripMenuItem();
            this.FileNew = new System.Windows.Forms.ToolStripMenuItem();
            this.FileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.FileSave = new System.Windows.Forms.ToolStripMenuItem();
            this.FileSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.FilePageParam = new System.Windows.Forms.ToolStripMenuItem();
            this.FilePrint = new System.Windows.Forms.ToolStripMenuItem();
            this.FileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.Pravka = new System.Windows.Forms.ToolStripMenuItem();
            this.EditCansel = new System.Windows.Forms.ToolStripMenuItem();
            this.EditCut = new System.Windows.Forms.ToolStripMenuItem();
            this.EditCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.EditPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.EditDel = new System.Windows.Forms.ToolStripMenuItem();
            this.EditFind = new System.Windows.Forms.ToolStripMenuItem();
            this.EditGo = new System.Windows.Forms.ToolStripMenuItem();
            this.EditGiveAll = new System.Windows.Forms.ToolStripMenuItem();
            this.EditTime = new System.Windows.Forms.ToolStripMenuItem();
            this.Format = new System.Windows.Forms.ToolStripMenuItem();
            this.Transfer = new System.Windows.Forms.ToolStripMenuItem();
            this.Font = new System.Windows.Forms.ToolStripMenuItem();
            this.View = new System.Windows.Forms.ToolStripMenuItem();
            this.StatusStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.Spravka = new System.Windows.Forms.ToolStripMenuItem();
            this.Help = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusLines = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusLinesCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusWord = new System.Windows.Forms.ToolStripStatusLabel();
            this.WordCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusSpace = new System.Windows.Forms.ToolStripStatusLabel();
            this.SpaceCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusNotSpace = new System.Windows.Forms.ToolStripStatusLabel();
            this.CountNotSpace = new System.Windows.Forms.ToolStripStatusLabel();
            this.textBox = new System.Windows.Forms.TextBox();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            this.printDialog = new System.Windows.Forms.PrintDialog();
            this.pageSetupDialog = new System.Windows.Forms.PageSetupDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.contextMenuStrip3 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.FormMenu.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // FormMenu
            // 
            this.FormMenu.BackColor = System.Drawing.Color.LightCoral;
            this.FormMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.File,
            this.Pravka,
            this.Format,
            this.View,
            this.Spravka});
            this.FormMenu.Location = new System.Drawing.Point(0, 0);
            this.FormMenu.Name = "FormMenu";
            this.FormMenu.Size = new System.Drawing.Size(800, 24);
            this.FormMenu.TabIndex = 0;
            this.FormMenu.Text = "Блокнот";
            this.FormMenu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.FormMenu_ItemClicked);
            // 
            // File
            // 
            this.File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileNew,
            this.FileOpen,
            this.FileSave,
            this.FileSaveAs,
            this.FilePageParam,
            this.FilePrint,
            this.FileExit});
            this.File.Name = "File";
            this.File.Size = new System.Drawing.Size(48, 20);
            this.File.Text = "Файл";
            this.File.Click += new System.EventHandler(this.файлToolStripMenuItem_Click);
            // 
            // FileNew
            // 
            this.FileNew.BackColor = System.Drawing.Color.LightCoral;
            this.FileNew.Name = "FileNew";
            this.FileNew.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.FileNew.Size = new System.Drawing.Size(226, 22);
            this.FileNew.Text = "Создать";
            this.FileNew.Click += new System.EventHandler(this.создатьToolStripMenuItem_Click);
            // 
            // FileOpen
            // 
            this.FileOpen.BackColor = System.Drawing.Color.LightCoral;
            this.FileOpen.Name = "FileOpen";
            this.FileOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.FileOpen.Size = new System.Drawing.Size(226, 22);
            this.FileOpen.Text = "Открыть";
            this.FileOpen.Click += new System.EventHandler(this.FileOpen_Click);
            // 
            // FileSave
            // 
            this.FileSave.BackColor = System.Drawing.Color.LightCoral;
            this.FileSave.Name = "FileSave";
            this.FileSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.FileSave.Size = new System.Drawing.Size(226, 22);
            this.FileSave.Text = "Сохранить";
            this.FileSave.Click += new System.EventHandler(this.FileSave_Click);
            // 
            // FileSaveAs
            // 
            this.FileSaveAs.BackColor = System.Drawing.Color.LightCoral;
            this.FileSaveAs.Name = "FileSaveAs";
            this.FileSaveAs.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.S)));
            this.FileSaveAs.Size = new System.Drawing.Size(226, 22);
            this.FileSaveAs.Text = "Сохранить как...";
            this.FileSaveAs.Click += new System.EventHandler(this.FileSaveAs_Click);
            // 
            // FilePageParam
            // 
            this.FilePageParam.BackColor = System.Drawing.Color.LightCoral;
            this.FilePageParam.Name = "FilePageParam";
            this.FilePageParam.Size = new System.Drawing.Size(226, 22);
            this.FilePageParam.Text = "Параметры страницы";
            this.FilePageParam.Click += new System.EventHandler(this.FilePageParam_Click);
            // 
            // FilePrint
            // 
            this.FilePrint.BackColor = System.Drawing.Color.LightCoral;
            this.FilePrint.Name = "FilePrint";
            this.FilePrint.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.FilePrint.Size = new System.Drawing.Size(226, 22);
            this.FilePrint.Text = "Печать...";
            this.FilePrint.Click += new System.EventHandler(this.FilePrint_Click);
            // 
            // FileExit
            // 
            this.FileExit.BackColor = System.Drawing.Color.LightCoral;
            this.FileExit.Name = "FileExit";
            this.FileExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.FileExit.Size = new System.Drawing.Size(226, 22);
            this.FileExit.Text = "Выход";
            this.FileExit.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // Pravka
            // 
            this.Pravka.BackColor = System.Drawing.Color.LightCoral;
            this.Pravka.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EditCansel,
            this.EditCut,
            this.EditCopy,
            this.EditPaste,
            this.EditDel,
            this.EditFind,
            this.EditGo,
            this.EditGiveAll,
            this.EditTime});
            this.Pravka.Name = "Pravka";
            this.Pravka.Size = new System.Drawing.Size(59, 20);
            this.Pravka.Text = "Правка";
            this.Pravka.Click += new System.EventHandler(this.Pravka_Click);
            // 
            // EditCansel
            // 
            this.EditCansel.BackColor = System.Drawing.Color.LightCoral;
            this.EditCansel.Name = "EditCansel";
            this.EditCansel.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.EditCansel.Size = new System.Drawing.Size(212, 22);
            this.EditCansel.Text = "Отменить";
            this.EditCansel.Click += new System.EventHandler(this.EditCansel_Click);
            // 
            // EditCut
            // 
            this.EditCut.BackColor = System.Drawing.Color.LightCoral;
            this.EditCut.Name = "EditCut";
            this.EditCut.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.EditCut.Size = new System.Drawing.Size(212, 22);
            this.EditCut.Text = "Вырезать";
            this.EditCut.Click += new System.EventHandler(this.EditCut_Click);
            // 
            // EditCopy
            // 
            this.EditCopy.BackColor = System.Drawing.Color.LightCoral;
            this.EditCopy.Name = "EditCopy";
            this.EditCopy.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.EditCopy.Size = new System.Drawing.Size(212, 22);
            this.EditCopy.Text = "Копировать";
            this.EditCopy.Click += new System.EventHandler(this.EditCopy_Click);
            // 
            // EditPaste
            // 
            this.EditPaste.BackColor = System.Drawing.Color.LightCoral;
            this.EditPaste.ForeColor = System.Drawing.SystemColors.ControlText;
            this.EditPaste.Name = "EditPaste";
            this.EditPaste.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.EditPaste.Size = new System.Drawing.Size(212, 22);
            this.EditPaste.Text = "Вставить";
            this.EditPaste.Click += new System.EventHandler(this.EditPaste_Click);
            // 
            // EditDel
            // 
            this.EditDel.BackColor = System.Drawing.Color.LightCoral;
            this.EditDel.Name = "EditDel";
            this.EditDel.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.EditDel.Size = new System.Drawing.Size(212, 22);
            this.EditDel.Text = "Удалить";
            this.EditDel.Click += new System.EventHandler(this.EditDel_Click);
            // 
            // EditFind
            // 
            this.EditFind.BackColor = System.Drawing.Color.LightCoral;
            this.EditFind.Name = "EditFind";
            this.EditFind.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.EditFind.Size = new System.Drawing.Size(212, 22);
            this.EditFind.Text = "Найти и заменить";
            this.EditFind.Click += new System.EventHandler(this.EditFind_Click);
            // 
            // EditGo
            // 
            this.EditGo.BackColor = System.Drawing.Color.LightCoral;
            this.EditGo.Name = "EditGo";
            this.EditGo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
            this.EditGo.Size = new System.Drawing.Size(212, 22);
            this.EditGo.Text = "Перейти";
            this.EditGo.Click += new System.EventHandler(this.EditGo_Click);
            this.EditGo.TextChanged += new System.EventHandler(this.EditGo_TextChanged);
            // 
            // EditGiveAll
            // 
            this.EditGiveAll.BackColor = System.Drawing.Color.LightCoral;
            this.EditGiveAll.Name = "EditGiveAll";
            this.EditGiveAll.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.EditGiveAll.Size = new System.Drawing.Size(212, 22);
            this.EditGiveAll.Text = "Выделить всё";
            this.EditGiveAll.Click += new System.EventHandler(this.EditGiveAll_Click);
            // 
            // EditTime
            // 
            this.EditTime.BackColor = System.Drawing.Color.LightCoral;
            this.EditTime.Name = "EditTime";
            this.EditTime.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.EditTime.Size = new System.Drawing.Size(212, 22);
            this.EditTime.Text = "Время и дата";
            this.EditTime.Click += new System.EventHandler(this.времяИДатаToolStripMenuItem_Click);
            // 
            // Format
            // 
            this.Format.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Transfer,
            this.Font});
            this.Format.Name = "Format";
            this.Format.Size = new System.Drawing.Size(62, 20);
            this.Format.Text = "Формат";
            // 
            // Transfer
            // 
            this.Transfer.BackColor = System.Drawing.Color.LightCoral;
            this.Transfer.CheckOnClick = true;
            this.Transfer.Name = "Transfer";
            this.Transfer.Size = new System.Drawing.Size(183, 22);
            this.Transfer.Text = "Перенос по словам";
            this.Transfer.CheckStateChanged += new System.EventHandler(this.Transfer_CheckStateChanged);
            this.Transfer.Click += new System.EventHandler(this.Transfer_Click);
            // 
            // Font
            // 
            this.Font.BackColor = System.Drawing.Color.LightCoral;
            this.Font.Name = "Font";
            this.Font.Size = new System.Drawing.Size(183, 22);
            this.Font.Text = "Шрифт";
            this.Font.Click += new System.EventHandler(this.Font_Click);
            // 
            // View
            // 
            this.View.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusStrip});
            this.View.Name = "View";
            this.View.Size = new System.Drawing.Size(39, 20);
            this.View.Text = "Вид";
            // 
            // StatusStrip
            // 
            this.StatusStrip.BackColor = System.Drawing.Color.LightCoral;
            this.StatusStrip.Checked = true;
            this.StatusStrip.CheckOnClick = true;
            this.StatusStrip.CheckState = System.Windows.Forms.CheckState.Checked;
            this.StatusStrip.Name = "StatusStrip";
            this.StatusStrip.Size = new System.Drawing.Size(180, 22);
            this.StatusStrip.Text = "Строка состояния ";
            this.StatusStrip.Click += new System.EventHandler(this.StatusStrip_Click);
            // 
            // Spravka
            // 
            this.Spravka.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Help});
            this.Spravka.Name = "Spravka";
            this.Spravka.Size = new System.Drawing.Size(65, 20);
            this.Spravka.Text = "Справка";
            this.Spravka.Click += new System.EventHandler(this.справкаToolStripMenuItem_Click);
            // 
            // Help
            // 
            this.Help.BackColor = System.Drawing.Color.LightCoral;
            this.Help.Name = "Help";
            this.Help.Size = new System.Drawing.Size(180, 22);
            this.Help.Text = "О программе";
            this.Help.Click += new System.EventHandler(this.Help_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.LightCoral;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.StatusLines,
            this.StatusLinesCount,
            this.StatusWord,
            this.WordCount,
            this.StatusSpace,
            this.SpaceCount,
            this.StatusNotSpace,
            this.CountNotSpace});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // StatusLines
            // 
            this.StatusLines.BackColor = System.Drawing.Color.LightCoral;
            this.StatusLines.Name = "StatusLines";
            this.StatusLines.Size = new System.Drawing.Size(106, 17);
            this.StatusLines.Text = "Количество строк";
            this.StatusLines.Click += new System.EventHandler(this.времяИДатаToolStripMenuItem_Click);
            // 
            // StatusLinesCount
            // 
            this.StatusLinesCount.BackColor = System.Drawing.Color.LightCoral;
            this.StatusLinesCount.Name = "StatusLinesCount";
            this.StatusLinesCount.Size = new System.Drawing.Size(13, 17);
            this.StatusLinesCount.Text = "0";
            // 
            // StatusWord
            // 
            this.StatusWord.BackColor = System.Drawing.Color.LightCoral;
            this.StatusWord.Name = "StatusWord";
            this.StatusWord.Size = new System.Drawing.Size(104, 17);
            this.StatusWord.Text = "Количество слов:";
            this.StatusWord.Click += new System.EventHandler(this.toolStripStatusLabel3_Click);
            // 
            // WordCount
            // 
            this.WordCount.BackColor = System.Drawing.Color.LightCoral;
            this.WordCount.Name = "WordCount";
            this.WordCount.Size = new System.Drawing.Size(13, 17);
            this.WordCount.Text = "0";
            this.WordCount.Click += new System.EventHandler(this.WordCount_Click);
            // 
            // StatusSpace
            // 
            this.StatusSpace.BackColor = System.Drawing.Color.LightCoral;
            this.StatusSpace.Name = "StatusSpace";
            this.StatusSpace.Size = new System.Drawing.Size(142, 17);
            this.StatusSpace.Text = "Символов с пробелами:";
            // 
            // SpaceCount
            // 
            this.SpaceCount.BackColor = System.Drawing.Color.LightCoral;
            this.SpaceCount.Name = "SpaceCount";
            this.SpaceCount.Size = new System.Drawing.Size(13, 17);
            this.SpaceCount.Text = "0";
            // 
            // StatusNotSpace
            // 
            this.StatusNotSpace.BackColor = System.Drawing.Color.LightCoral;
            this.StatusNotSpace.Name = "StatusNotSpace";
            this.StatusNotSpace.Size = new System.Drawing.Size(145, 17);
            this.StatusNotSpace.Text = "Символов без пробелов:";
            // 
            // CountNotSpace
            // 
            this.CountNotSpace.BackColor = System.Drawing.Color.LightCoral;
            this.CountNotSpace.Name = "CountNotSpace";
            this.CountNotSpace.Size = new System.Drawing.Size(13, 17);
            this.CountNotSpace.Text = "0";
            // 
            // textBox
            // 
            this.textBox.BackColor = System.Drawing.Color.RosyBrown;
            this.textBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox.Location = new System.Drawing.Point(0, 24);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox.Size = new System.Drawing.Size(800, 404);
            this.textBox.TabIndex = 3;
            this.textBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // printDialog
            // 
            this.printDialog.Document = this.printDocument;
            this.printDialog.UseEXDialog = true;
            // 
            // pageSetupDialog
            // 
            this.pageSetupDialog.Document = this.printDocument;
            // 
            // fontDialog1
            // 
            this.fontDialog1.Apply += new System.EventHandler(this.fontDialog1_Apply);
            // 
            // contextMenuStrip3
            // 
            this.contextMenuStrip3.Name = "contextMenuStrip3";
            this.contextMenuStrip3.Size = new System.Drawing.Size(61, 4);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.FormMenu);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.FormMenu;
            this.Name = "Menu";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Menu_FormClosing);
            this.Load += new System.EventHandler(this.Menu_Load);
            this.FormMenu.ResumeLayout(false);
            this.FormMenu.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip FormMenu;
        private System.Windows.Forms.ToolStripMenuItem File;
        private System.Windows.Forms.ToolStripMenuItem FileNew;
        private System.Windows.Forms.ToolStripMenuItem FileOpen;
        private System.Windows.Forms.ToolStripMenuItem FileSave;
        private System.Windows.Forms.ToolStripMenuItem FileSaveAs;
        private System.Windows.Forms.ToolStripMenuItem FilePageParam;
        private System.Windows.Forms.ToolStripMenuItem FilePrint;
        private System.Windows.Forms.ToolStripMenuItem FileExit;
        private System.Windows.Forms.ToolStripMenuItem Pravka;
        private System.Windows.Forms.ToolStripMenuItem EditCansel;
        private System.Windows.Forms.ToolStripMenuItem EditCut;
        private System.Windows.Forms.ToolStripMenuItem EditCopy;
        private System.Windows.Forms.ToolStripMenuItem EditPaste;
        private System.Windows.Forms.ToolStripMenuItem EditDel;
        private System.Windows.Forms.ToolStripMenuItem EditFind;
        private System.Windows.Forms.ToolStripMenuItem EditGiveAll;
        private System.Windows.Forms.ToolStripMenuItem EditTime;
        private System.Windows.Forms.ToolStripMenuItem Format;
        private System.Windows.Forms.ToolStripMenuItem Transfer;
        private System.Windows.Forms.ToolStripMenuItem Font;
        private System.Windows.Forms.ToolStripMenuItem View;
        private System.Windows.Forms.ToolStripMenuItem StatusStrip;
        private System.Windows.Forms.ToolStripMenuItem Spravka;
        private System.Windows.Forms.ToolStripMenuItem Help;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel StatusLines;
        private System.Windows.Forms.ToolStripStatusLabel StatusLinesCount;
        private System.Windows.Forms.ToolStripStatusLabel StatusWord;
        private System.Windows.Forms.ToolStripStatusLabel WordCount;
        private System.Windows.Forms.ToolStripStatusLabel StatusSpace;
        private System.Windows.Forms.ToolStripStatusLabel SpaceCount;
        private System.Windows.Forms.ToolStripStatusLabel StatusNotSpace;
        private System.Windows.Forms.ToolStripStatusLabel CountNotSpace;
        public System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Drawing.Printing.PrintDocument printDocument;
        private System.Windows.Forms.PrintDialog printDialog;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog;
        internal System.Windows.Forms.ToolStripMenuItem EditGo;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip3;
    }
}

