
namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tao = new System.Windows.Forms.Button();
            this.soPhanTu = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.sapXep = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // tao
            // 
            this.tao.Location = new System.Drawing.Point(197, 21);
            this.tao.Name = "tao";
            this.tao.Size = new System.Drawing.Size(94, 29);
            this.tao.TabIndex = 0;
            this.tao.Text = "Tao";
            this.tao.UseVisualStyleBackColor = true;
            this.tao.Click += new System.EventHandler(this.tao_Click);
            // 
            // soPhanTu
            // 
            this.soPhanTu.Location = new System.Drawing.Point(32, 21);
            this.soPhanTu.Name = "soPhanTu";
            this.soPhanTu.Size = new System.Drawing.Size(125, 27);
            this.soPhanTu.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(23, 135);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(733, 231);
            this.panel1.TabIndex = 2;
            // 
            // sapXep
            // 
            this.sapXep.Location = new System.Drawing.Point(339, 21);
            this.sapXep.Name = "sapXep";
            this.sapXep.Size = new System.Drawing.Size(94, 29);
            this.sapXep.TabIndex = 3;
            this.sapXep.Text = "Sap Xep";
            this.sapXep.UseVisualStyleBackColor = true;
            this.sapXep.Click += new System.EventHandler(this.sapXep_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.doWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.RunWorkerCompleted);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sapXep);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.soPhanTu);
            this.Controls.Add(this.tao);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button tao;
        private System.Windows.Forms.TextBox soPhanTu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button sapXep;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

