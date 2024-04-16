namespace Bai2
{
    partial class frmPhanCong
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
            this.listGV = new System.Windows.Forms.ListBox();
            this.listLop = new System.Windows.Forms.ListBox();
            this.listPC = new System.Windows.Forms.ListBox();
            this.btnPhanCong = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listGV
            // 
            this.listGV.FormattingEnabled = true;
            this.listGV.ItemHeight = 16;
            this.listGV.Location = new System.Drawing.Point(16, 57);
            this.listGV.Margin = new System.Windows.Forms.Padding(4);
            this.listGV.Name = "listGV";
            this.listGV.Size = new System.Drawing.Size(181, 292);
            this.listGV.TabIndex = 0;
            // 
            // listLop
            // 
            this.listLop.FormattingEnabled = true;
            this.listLop.ItemHeight = 16;
            this.listLop.Location = new System.Drawing.Point(214, 57);
            this.listLop.Margin = new System.Windows.Forms.Padding(4);
            this.listLop.Name = "listLop";
            this.listLop.Size = new System.Drawing.Size(117, 292);
            this.listLop.TabIndex = 1;
            // 
            // listPC
            // 
            this.listPC.FormattingEnabled = true;
            this.listPC.ItemHeight = 16;
            this.listPC.Location = new System.Drawing.Point(449, 57);
            this.listPC.Margin = new System.Windows.Forms.Padding(4);
            this.listPC.Name = "listPC";
            this.listPC.Size = new System.Drawing.Size(305, 292);
            this.listPC.TabIndex = 2;
            // 
            // btnPhanCong
            // 
            this.btnPhanCong.Location = new System.Drawing.Point(339, 177);
            this.btnPhanCong.Margin = new System.Windows.Forms.Padding(4);
            this.btnPhanCong.Name = "btnPhanCong";
            this.btnPhanCong.Size = new System.Drawing.Size(102, 39);
            this.btnPhanCong.TabIndex = 3;
            this.btnPhanCong.Text = "Phân công";
            this.btnPhanCong.UseVisualStyleBackColor = true;
            this.btnPhanCong.Click += new System.EventHandler(this.btnPhanCong_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(547, 357);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(121, 31);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(63, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Giáo viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(253, 25);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Lớp";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(561, 25);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Phân công";
            // 
            // frmPhanCong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 402);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnPhanCong);
            this.Controls.Add(this.listPC);
            this.Controls.Add(this.listLop);
            this.Controls.Add(this.listGV);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmPhanCong";
            this.Text = "Phân công Giáo viên";
            this.Load += new System.EventHandler(this.frmPhanCong_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listGV;
        private System.Windows.Forms.ListBox listLop;
        private System.Windows.Forms.ListBox listPC;
        private System.Windows.Forms.Button btnPhanCong;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

