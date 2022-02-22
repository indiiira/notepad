using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace notepad
{
    partial class FormSearch:Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        public FormSearch()
        {
            InitializeComponent();
        }
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Find = new System.Windows.Forms.TextBox();
            this.Replace = new System.Windows.Forms.TextBox();
            this.Reg = new System.Windows.Forms.CheckBox();
            this.BFind = new System.Windows.Forms.Button();
            this.BReplace = new System.Windows.Forms.Button();
            this.BReplaceAll = new System.Windows.Forms.Button();
            this.BCansel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Найти:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Заменить на:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Find
            // 
            this.Find.Location = new System.Drawing.Point(110, 27);
            this.Find.Name = "Find";
            this.Find.Size = new System.Drawing.Size(312, 20);
            this.Find.TabIndex = 2;
            // 
            // Replace
            // 
            this.Replace.Location = new System.Drawing.Point(110, 56);
            this.Replace.Name = "Replace";
            this.Replace.Size = new System.Drawing.Size(312, 20);
            this.Replace.TabIndex = 3;
            // 
            // Reg
            // 
            this.Reg.AutoSize = true;
            this.Reg.Location = new System.Drawing.Point(4, 82);
            this.Reg.Name = "Reg";
            this.Reg.Size = new System.Drawing.Size(124, 17);
            this.Reg.TabIndex = 4;
            this.Reg.Text = "Учитывать регистр";
            this.Reg.UseVisualStyleBackColor = true;
            // 
            // BFind
            // 
            this.BFind.Location = new System.Drawing.Point(12, 117);
            this.BFind.Name = "BFind";
            this.BFind.Size = new System.Drawing.Size(101, 28);
            this.BFind.TabIndex = 5;
            this.BFind.Text = "Найти далее";
            this.BFind.UseVisualStyleBackColor = true;
            // 
            // BReplace
            // 
            this.BReplace.Location = new System.Drawing.Point(119, 117);
            this.BReplace.Name = "BReplace";
            this.BReplace.Size = new System.Drawing.Size(103, 28);
            this.BReplace.TabIndex = 6;
            this.BReplace.Text = "Заменить";
            this.BReplace.UseVisualStyleBackColor = true;
            // 
            // BReplaceAll
            // 
            this.BReplaceAll.Location = new System.Drawing.Point(228, 117);
            this.BReplaceAll.Name = "BReplaceAll";
            this.BReplaceAll.Size = new System.Drawing.Size(97, 28);
            this.BReplaceAll.TabIndex = 7;
            this.BReplaceAll.Text = "Заменить всё";
            this.BReplaceAll.UseVisualStyleBackColor = true;
            // 
            // BCansel
            // 
            this.BCansel.Location = new System.Drawing.Point(331, 117);
            this.BCansel.Name = "BCansel";
            this.BCansel.Size = new System.Drawing.Size(91, 28);
            this.BCansel.TabIndex = 8;
            this.BCansel.Text = "Отмена";
            this.BCansel.UseVisualStyleBackColor = true;
            // 
            // FormSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 157);
            this.Controls.Add(this.BCansel);
            this.Controls.Add(this.BReplaceAll);
            this.Controls.Add(this.BReplace);
            this.Controls.Add(this.BFind);
            this.Controls.Add(this.Reg);
            this.Controls.Add(this.Replace);
            this.Controls.Add(this.Find);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSearch";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Найти и заменить...";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox Reg;
        private System.Windows.Forms.Button BFind;
        private System.Windows.Forms.Button BReplace;
        private System.Windows.Forms.Button BReplaceAll;
        private System.Windows.Forms.Button BCansel;
        public System.Windows.Forms.TextBox Find;
        public System.Windows.Forms.TextBox Replace;
        private void SearchForm_Shown(object sender, EventArgs e) // Событие при открытии формы поиска и замены
        {
            Find.Focus();
        }

        int findCutLength = 0; // На сколько символов обрезаем текст для поиска

        private void tbFind_TextChanged(object sender, EventArgs e) // Cобытие при изменении текста в tbFind
        {
            findCutLength = 0;
        }

        private void tbReplace_TextChanged(object sender, EventArgs e) // Событие при изменении текста в tbReplace
        {
            findCutLength = 0;
        }

        private void cbReg_CheckStateChanged(object sender, EventArgs e) // Событие при изменении статуса cbReg
        {
            findCutLength = 0;
        }

        private void SearchForm_FormClosing(object sender, FormClosingEventArgs e) // Событие при закрытии формы (до закрытия)
        {
            findCutLength = 0;
        }

        private void butFind_Click(object sender, EventArgs e) // Кнопка "Найти"
        {
            Menu main = this.Owner as Menu;
            if (main != null)
            {
                if (Reg.CheckState == CheckState.Checked)
                {
                    TextWork.FindTextBox(ref main.textBox, Find.Text, ref findCutLength, true);
                }
                else
                {
                    TextWork.FindTextBox(ref main.textBox, Find.Text, ref findCutLength, false);
                }
            }
        }

        private void butReplace_Click(object sender, EventArgs e) // Кнопка "Заменить"
        {
            Menu main = this.Owner as Menu;
            if (main != null)
            {
                if (Reg.CheckState == CheckState.Checked)
                {
                    TextWork.ReplaceTextBox(ref main.textBox, Find.Text, Replace.Text, ref findCutLength, true);
                }
                else
                {
                    TextWork.ReplaceTextBox(ref main.textBox, Find.Text, Replace.Text, ref findCutLength, false);
                }
            }
        }

        private void butReplaceAll_Click(object sender, EventArgs e) // Кнопка "Заменить всё"
        {
            Menu main = this.Owner as Menu;
            if (main != null)
            {
                if (Reg.CheckState == CheckState.Checked)
                {
                    TextWork.ReplaceAllTextBox(ref main.textBox, Find.Text, Replace.Text, true);
                }
                else
                {
                    TextWork.ReplaceAllTextBox(ref main.textBox, Find.Text, Replace.Text, false);
                }
            }
        }

        private void butCancel_Click(object sender, EventArgs e) // Кнопка "Отмена"
        {
            this.Close();
        }
    }
}
    