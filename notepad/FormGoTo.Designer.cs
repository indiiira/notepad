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
    partial class FormGoTo : Form
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.ButtonGo = new System.Windows.Forms.Button();
            this.ButtonCansel = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDown
            // 
            this.numericUpDown.Location = new System.Drawing.Point(56, 38);
            this.numericUpDown.Name = "numericUpDown";
            this.numericUpDown.Size = new System.Drawing.Size(138, 20);
            this.numericUpDown.TabIndex = 0;
            this.numericUpDown.ThousandsSeparator = true;
            this.numericUpDown.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Введите номер строки:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ButtonGo
            // 
            this.ButtonGo.Location = new System.Drawing.Point(12, 77);
            this.ButtonGo.Name = "ButtonGo";
            this.ButtonGo.Size = new System.Drawing.Size(93, 22);
            this.ButtonGo.TabIndex = 2;
            this.ButtonGo.Text = "Перейти";
            this.ButtonGo.UseVisualStyleBackColor = true;
            // 
            // ButtonCansel
            // 
            this.ButtonCansel.Location = new System.Drawing.Point(144, 77);
            this.ButtonCansel.Name = "ButtonCansel";
            this.ButtonCansel.Size = new System.Drawing.Size(95, 22);
            this.ButtonCansel.TabIndex = 3;
            this.ButtonCansel.Text = "Отмена";
            this.ButtonCansel.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(262, 111);
            this.textBox1.TabIndex = 4;
            // 
            // FormGoTo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 111);
            this.Controls.Add(this.ButtonCansel);
            this.Controls.Add(this.ButtonGo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDown);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormGoTo";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Перейти";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ButtonGo;
        private System.Windows.Forms.Button ButtonCansel;
        public System.Windows.Forms.TextBox textBox1;
        internal System.Windows.Forms.NumericUpDown numericUpDown;
        private void butGo_Click(object sender, EventArgs e) // Кнопка "Перейти к строке"
        {
            Menu main = this.Owner as Menu;
            if (main != null)
            {
                int lineNumber = Convert.ToInt32(numericUpDown.Text);
                if (lineNumber > 0 && lineNumber <= main.textBox.Lines.Count())
                {
                    main.textBox.SelectionStart = main.textBox.GetFirstCharIndexFromLine(Convert.ToInt32(numericUpDown.Text) - 1);
                    main.textBox.ScrollToCaret();
                    this.Close();
                }
            }
        }

        private void butCancel_Click(object sender, EventArgs e) // Кнопка "Отменить"
        {
            this.Close();
        }
    }
}

    
