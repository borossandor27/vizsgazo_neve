
namespace GUI
{
    partial class Form1
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
            this.listBox_dolgozok = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_Nev = new System.Windows.Forms.TextBox();
            this.textBox_Reszleg = new System.Windows.Forms.TextBox();
            this.textBox_Nem = new System.Windows.Forms.TextBox();
            this.numericUpDown_BelepesEve = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_Ber = new System.Windows.Forms.NumericUpDown();
            this.button_Insert = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_BelepesEve)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Ber)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox_dolgozok
            // 
            this.listBox_dolgozok.Dock = System.Windows.Forms.DockStyle.Left;
            this.listBox_dolgozok.FormattingEnabled = true;
            this.listBox_dolgozok.ItemHeight = 24;
            this.listBox_dolgozok.Location = new System.Drawing.Point(0, 0);
            this.listBox_dolgozok.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.listBox_dolgozok.Name = "listBox_dolgozok";
            this.listBox_dolgozok.Size = new System.Drawing.Size(301, 586);
            this.listBox_dolgozok.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(338, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Név:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(338, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Részleg:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(338, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nem:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(338, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 24);
            this.label4.TabIndex = 2;
            this.label4.Text = "Belépés éve:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(338, 238);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 24);
            this.label5.TabIndex = 2;
            this.label5.Text = "Fizetés:";
            // 
            // textBox_Nev
            // 
            this.textBox_Nev.Location = new System.Drawing.Point(509, 34);
            this.textBox_Nev.Name = "textBox_Nev";
            this.textBox_Nev.Size = new System.Drawing.Size(252, 29);
            this.textBox_Nev.TabIndex = 3;
            // 
            // textBox_Reszleg
            // 
            this.textBox_Reszleg.Location = new System.Drawing.Point(509, 85);
            this.textBox_Reszleg.Name = "textBox_Reszleg";
            this.textBox_Reszleg.Size = new System.Drawing.Size(252, 29);
            this.textBox_Reszleg.TabIndex = 3;
            // 
            // textBox_Nem
            // 
            this.textBox_Nem.Location = new System.Drawing.Point(509, 131);
            this.textBox_Nem.Name = "textBox_Nem";
            this.textBox_Nem.Size = new System.Drawing.Size(252, 29);
            this.textBox_Nem.TabIndex = 3;
            // 
            // numericUpDown_BelepesEve
            // 
            this.numericUpDown_BelepesEve.Location = new System.Drawing.Point(509, 185);
            this.numericUpDown_BelepesEve.Name = "numericUpDown_BelepesEve";
            this.numericUpDown_BelepesEve.Size = new System.Drawing.Size(120, 29);
            this.numericUpDown_BelepesEve.TabIndex = 4;
            this.numericUpDown_BelepesEve.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // numericUpDown_Ber
            // 
            this.numericUpDown_Ber.Location = new System.Drawing.Point(509, 233);
            this.numericUpDown_Ber.Name = "numericUpDown_Ber";
            this.numericUpDown_Ber.Size = new System.Drawing.Size(252, 29);
            this.numericUpDown_Ber.TabIndex = 4;
            this.numericUpDown_Ber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDown_Ber.ThousandsSeparator = true;
            // 
            // button_Insert
            // 
            this.button_Insert.Location = new System.Drawing.Point(342, 328);
            this.button_Insert.Name = "button_Insert";
            this.button_Insert.Size = new System.Drawing.Size(419, 60);
            this.button_Insert.TabIndex = 5;
            this.button_Insert.Text = "Rögzítés";
            this.button_Insert.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 586);
            this.Controls.Add(this.button_Insert);
            this.Controls.Add(this.numericUpDown_Ber);
            this.Controls.Add(this.numericUpDown_BelepesEve);
            this.Controls.Add(this.textBox_Nem);
            this.Controls.Add(this.textBox_Reszleg);
            this.Controls.Add(this.textBox_Nev);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox_dolgozok);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_BelepesEve)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Ber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_dolgozok;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_Nev;
        private System.Windows.Forms.TextBox textBox_Reszleg;
        private System.Windows.Forms.TextBox textBox_Nem;
        private System.Windows.Forms.NumericUpDown numericUpDown_BelepesEve;
        private System.Windows.Forms.NumericUpDown numericUpDown_Ber;
        private System.Windows.Forms.Button button_Insert;
    }
}

