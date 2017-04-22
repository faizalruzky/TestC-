namespace WindowsFormsApplication3
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
            this.dg1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button4Hapus = new System.Windows.Forms.Button();
            this.button3Edit = new System.Windows.Forms.Button();
            this.button2Batal = new System.Windows.Forms.Button();
            this.button1tambah = new System.Windows.Forms.Button();
            this.textBoxGaji = new System.Windows.Forms.TextBox();
            this.textBoxJabatan = new System.Windows.Forms.TextBox();
            this.textBoxNama = new System.Windows.Forms.TextBox();
            this.textBoxNIP = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dg1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dg1
            // 
            this.dg1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg1.Location = new System.Drawing.Point(269, 23);
            this.dg1.Name = "dg1";
            this.dg1.Size = new System.Drawing.Size(381, 266);
            this.dg1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button4Hapus);
            this.groupBox1.Controls.Add(this.button3Edit);
            this.groupBox1.Controls.Add(this.button2Batal);
            this.groupBox1.Controls.Add(this.button1tambah);
            this.groupBox1.Controls.Add(this.textBoxGaji);
            this.groupBox1.Controls.Add(this.textBoxJabatan);
            this.groupBox1.Controls.Add(this.textBoxNama);
            this.groupBox1.Controls.Add(this.textBoxNIP);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(28, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(218, 266);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Data Pegawai";
            // 
            // button4Hapus
            // 
            this.button4Hapus.Location = new System.Drawing.Point(121, 222);
            this.button4Hapus.Name = "button4Hapus";
            this.button4Hapus.Size = new System.Drawing.Size(75, 23);
            this.button4Hapus.TabIndex = 11;
            this.button4Hapus.Text = "Hapus";
            this.button4Hapus.UseVisualStyleBackColor = true;
            // 
            // button3Edit
            // 
            this.button3Edit.Location = new System.Drawing.Point(10, 222);
            this.button3Edit.Name = "button3Edit";
            this.button3Edit.Size = new System.Drawing.Size(75, 23);
            this.button3Edit.TabIndex = 10;
            this.button3Edit.Text = "Edit";
            this.button3Edit.UseVisualStyleBackColor = true;
            // 
            // button2Batal
            // 
            this.button2Batal.Location = new System.Drawing.Point(121, 176);
            this.button2Batal.Name = "button2Batal";
            this.button2Batal.Size = new System.Drawing.Size(75, 23);
            this.button2Batal.TabIndex = 9;
            this.button2Batal.Text = "Batal";
            this.button2Batal.UseVisualStyleBackColor = true;
            // 
            // button1tambah
            // 
            this.button1tambah.Location = new System.Drawing.Point(10, 176);
            this.button1tambah.Name = "button1tambah";
            this.button1tambah.Size = new System.Drawing.Size(75, 23);
            this.button1tambah.TabIndex = 8;
            this.button1tambah.Text = "Tambah";
            this.button1tambah.UseVisualStyleBackColor = true;
            // 
            // textBoxGaji
            // 
            this.textBoxGaji.Location = new System.Drawing.Point(96, 124);
            this.textBoxGaji.Name = "textBoxGaji";
            this.textBoxGaji.Size = new System.Drawing.Size(100, 20);
            this.textBoxGaji.TabIndex = 7;
            // 
            // textBoxJabatan
            // 
            this.textBoxJabatan.Location = new System.Drawing.Point(96, 92);
            this.textBoxJabatan.Name = "textBoxJabatan";
            this.textBoxJabatan.Size = new System.Drawing.Size(100, 20);
            this.textBoxJabatan.TabIndex = 6;
            // 
            // textBoxNama
            // 
            this.textBoxNama.Location = new System.Drawing.Point(96, 61);
            this.textBoxNama.Name = "textBoxNama";
            this.textBoxNama.Size = new System.Drawing.Size(100, 20);
            this.textBoxNama.TabIndex = 5;
            // 
            // textBoxNIP
            // 
            this.textBoxNIP.Location = new System.Drawing.Point(96, 34);
            this.textBoxNIP.Name = "textBoxNIP";
            this.textBoxNIP.Size = new System.Drawing.Size(100, 20);
            this.textBoxNIP.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Gaji Pokok";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Jabatan";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nama";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "NIP";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 316);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dg1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dg1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button4Hapus;
        private System.Windows.Forms.Button button3Edit;
        private System.Windows.Forms.Button button2Batal;
        private System.Windows.Forms.Button button1tambah;
        private System.Windows.Forms.TextBox textBoxGaji;
        private System.Windows.Forms.TextBox textBoxJabatan;
        private System.Windows.Forms.TextBox textBoxNama;
        private System.Windows.Forms.TextBox textBoxNIP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

