namespace ClientProxy_P4_074_Form
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
            this.tambah = new System.Windows.Forms.Label();
            this.jawaban1 = new System.Windows.Forms.Label();
            this.kurang = new System.Windows.Forms.Label();
            this.jawaban2 = new System.Windows.Forms.Label();
            this.jawaban4 = new System.Windows.Forms.Label();
            this.bagi = new System.Windows.Forms.Label();
            this.jawaban3 = new System.Windows.Forms.Label();
            this.kali = new System.Windows.Forms.Label();
            this.koor = new System.Windows.Forms.Label();
            this.jawaban5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tambah
            // 
            this.tambah.AutoSize = true;
            this.tambah.Location = new System.Drawing.Point(104, 68);
            this.tambah.Name = "tambah";
            this.tambah.Size = new System.Drawing.Size(46, 17);
            this.tambah.TabIndex = 0;
            this.tambah.Text = "label1";
            this.tambah.Click += new System.EventHandler(this.soal_Click);
            // 
            // jawaban1
            // 
            this.jawaban1.AutoSize = true;
            this.jawaban1.Location = new System.Drawing.Point(249, 68);
            this.jawaban1.Name = "jawaban1";
            this.jawaban1.Size = new System.Drawing.Size(46, 17);
            this.jawaban1.TabIndex = 1;
            this.jawaban1.Text = "label2";
            // 
            // kurang
            // 
            this.kurang.AutoSize = true;
            this.kurang.Location = new System.Drawing.Point(104, 109);
            this.kurang.Name = "kurang";
            this.kurang.Size = new System.Drawing.Size(46, 17);
            this.kurang.TabIndex = 2;
            this.kurang.Text = "label1";
            // 
            // jawaban2
            // 
            this.jawaban2.AutoSize = true;
            this.jawaban2.Location = new System.Drawing.Point(249, 109);
            this.jawaban2.Name = "jawaban2";
            this.jawaban2.Size = new System.Drawing.Size(46, 17);
            this.jawaban2.TabIndex = 3;
            this.jawaban2.Text = "label2";
            // 
            // jawaban4
            // 
            this.jawaban4.AutoSize = true;
            this.jawaban4.Location = new System.Drawing.Point(249, 185);
            this.jawaban4.Name = "jawaban4";
            this.jawaban4.Size = new System.Drawing.Size(46, 17);
            this.jawaban4.TabIndex = 7;
            this.jawaban4.Text = "label3";
            // 
            // bagi
            // 
            this.bagi.AutoSize = true;
            this.bagi.Location = new System.Drawing.Point(104, 185);
            this.bagi.Name = "bagi";
            this.bagi.Size = new System.Drawing.Size(46, 17);
            this.bagi.TabIndex = 6;
            this.bagi.Text = "label4";
            // 
            // jawaban3
            // 
            this.jawaban3.AutoSize = true;
            this.jawaban3.Location = new System.Drawing.Point(249, 144);
            this.jawaban3.Name = "jawaban3";
            this.jawaban3.Size = new System.Drawing.Size(46, 17);
            this.jawaban3.TabIndex = 5;
            this.jawaban3.Text = "label2";
            // 
            // kali
            // 
            this.kali.AutoSize = true;
            this.kali.Location = new System.Drawing.Point(104, 144);
            this.kali.Name = "kali";
            this.kali.Size = new System.Drawing.Size(46, 17);
            this.kali.TabIndex = 4;
            this.kali.Text = "label1";
            // 
            // koor
            // 
            this.koor.AutoSize = true;
            this.koor.Location = new System.Drawing.Point(104, 224);
            this.koor.Name = "koor";
            this.koor.Size = new System.Drawing.Size(46, 17);
            this.koor.TabIndex = 8;
            this.koor.Text = "label1";
            // 
            // jawaban5
            // 
            this.jawaban5.AutoSize = true;
            this.jawaban5.Location = new System.Drawing.Point(249, 224);
            this.jawaban5.Name = "jawaban5";
            this.jawaban5.Size = new System.Drawing.Size(46, 17);
            this.jawaban5.TabIndex = 9;
            this.jawaban5.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(104, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Soal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(240, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Jawaban";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.jawaban5);
            this.Controls.Add(this.koor);
            this.Controls.Add(this.jawaban4);
            this.Controls.Add(this.bagi);
            this.Controls.Add(this.jawaban3);
            this.Controls.Add(this.kali);
            this.Controls.Add(this.jawaban2);
            this.Controls.Add(this.kurang);
            this.Controls.Add(this.jawaban1);
            this.Controls.Add(this.tambah);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tambah;
        private System.Windows.Forms.Label jawaban1;
        private System.Windows.Forms.Label kurang;
        private System.Windows.Forms.Label jawaban2;
        private System.Windows.Forms.Label jawaban4;
        private System.Windows.Forms.Label bagi;
        private System.Windows.Forms.Label jawaban3;
        private System.Windows.Forms.Label kali;
        private System.Windows.Forms.Label koor;
        private System.Windows.Forms.Label jawaban5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

