namespace TugasTiga1
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.hNIM = new System.Windows.Forms.Label();
            this.hNAMA = new System.Windows.Forms.Label();
            this.hKELAS = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "NIM   :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nama :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kelas  :";
            // 
            // hNIM
            // 
            this.hNIM.AutoSize = true;
            this.hNIM.Location = new System.Drawing.Point(91, 35);
            this.hNIM.Name = "hNIM";
            this.hNIM.Size = new System.Drawing.Size(10, 13);
            this.hNIM.TabIndex = 3;
            this.hNIM.Text = "-";
            this.hNIM.Click += new System.EventHandler(this.label4_Click);
            // 
            // hNAMA
            // 
            this.hNAMA.AutoSize = true;
            this.hNAMA.Location = new System.Drawing.Point(91, 66);
            this.hNAMA.Name = "hNAMA";
            this.hNAMA.Size = new System.Drawing.Size(10, 13);
            this.hNAMA.TabIndex = 4;
            this.hNAMA.Text = "-";
            this.hNAMA.Click += new System.EventHandler(this.label5_Click);
            // 
            // hKELAS
            // 
            this.hKELAS.AutoSize = true;
            this.hKELAS.Location = new System.Drawing.Point(91, 99);
            this.hKELAS.Name = "hKELAS";
            this.hKELAS.Size = new System.Drawing.Size(10, 13);
            this.hKELAS.TabIndex = 5;
            this.hKELAS.Text = "-";
            this.hKELAS.Click += new System.EventHandler(this.label6_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(45, 166);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 26);
            this.button1.TabIndex = 6;
            this.button1.Text = "Show";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(132, 166);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(81, 26);
            this.button2.TabIndex = 7;
            this.button2.Text = "Hide";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 249);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.hKELAS);
            this.Controls.Add(this.hNAMA);
            this.Controls.Add(this.hNIM);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Tugas 3.1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label hNIM;
        private System.Windows.Forms.Label hNAMA;
        private System.Windows.Forms.Label hKELAS;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

