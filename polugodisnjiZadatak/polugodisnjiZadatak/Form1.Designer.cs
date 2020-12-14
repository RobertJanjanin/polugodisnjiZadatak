
namespace polugodisnjiZadatak
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxIme = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxPrezime = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxGodiste = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxSpol = new System.Windows.Forms.ComboBox();
            this.buttonUnesi = new System.Windows.Forms.Button();
            this.buttonObradi = new System.Windows.Forms.Button();
            this.buttonIspisi = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ime";
            // 
            // textBoxIme
            // 
            this.textBoxIme.Location = new System.Drawing.Point(12, 50);
            this.textBoxIme.Name = "textBoxIme";
            this.textBoxIme.Size = new System.Drawing.Size(100, 20);
            this.textBoxIme.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Prezime";
            // 
            // textBoxPrezime
            // 
            this.textBoxPrezime.Location = new System.Drawing.Point(12, 89);
            this.textBoxPrezime.Name = "textBoxPrezime";
            this.textBoxPrezime.Size = new System.Drawing.Size(100, 20);
            this.textBoxPrezime.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Godiste";
            // 
            // textBoxGodiste
            // 
            this.textBoxGodiste.Location = new System.Drawing.Point(12, 128);
            this.textBoxGodiste.Name = "textBoxGodiste";
            this.textBoxGodiste.Size = new System.Drawing.Size(100, 20);
            this.textBoxGodiste.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Spol";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // comboBoxSpol
            // 
            this.comboBoxSpol.FormattingEnabled = true;
            this.comboBoxSpol.Location = new System.Drawing.Point(12, 167);
            this.comboBoxSpol.Name = "comboBoxSpol";
            this.comboBoxSpol.Size = new System.Drawing.Size(100, 21);
            this.comboBoxSpol.TabIndex = 8;
            // 
            // buttonUnesi
            // 
            this.buttonUnesi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.buttonUnesi.Location = new System.Drawing.Point(164, 50);
            this.buttonUnesi.Name = "buttonUnesi";
            this.buttonUnesi.Size = new System.Drawing.Size(122, 123);
            this.buttonUnesi.TabIndex = 9;
            this.buttonUnesi.Text = "Unesi";
            this.buttonUnesi.UseVisualStyleBackColor = true;
            this.buttonUnesi.Click += new System.EventHandler(this.buttonUnesi_Click);
            // 
            // buttonObradi
            // 
            this.buttonObradi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.buttonObradi.Location = new System.Drawing.Point(308, 49);
            this.buttonObradi.Name = "buttonObradi";
            this.buttonObradi.Size = new System.Drawing.Size(124, 124);
            this.buttonObradi.TabIndex = 10;
            this.buttonObradi.Text = "Obradi";
            this.buttonObradi.UseVisualStyleBackColor = true;
            this.buttonObradi.Click += new System.EventHandler(this.buttonObradi_Click);
            // 
            // buttonIspisi
            // 
            this.buttonIspisi.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonIspisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.buttonIspisi.Location = new System.Drawing.Point(454, 49);
            this.buttonIspisi.Name = "buttonIspisi";
            this.buttonIspisi.Size = new System.Drawing.Size(130, 124);
            this.buttonIspisi.TabIndex = 11;
            this.buttonIspisi.Text = "Ispisi";
            this.buttonIspisi.UseVisualStyleBackColor = true;
            this.buttonIspisi.Click += new System.EventHandler(this.buttonIspisi_Click);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 205);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(572, 238);
            this.listBox1.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(591, 449);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.buttonIspisi);
            this.Controls.Add(this.buttonObradi);
            this.Controls.Add(this.buttonUnesi);
            this.Controls.Add(this.comboBoxSpol);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxGodiste);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxPrezime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxIme);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxIme;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxPrezime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxGodiste;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxSpol;
        private System.Windows.Forms.Button buttonUnesi;
        private System.Windows.Forms.Button buttonObradi;
        private System.Windows.Forms.Button buttonIspisi;
        private System.Windows.Forms.ListBox listBox1;
    }
}

