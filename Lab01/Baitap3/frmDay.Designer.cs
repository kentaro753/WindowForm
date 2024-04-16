namespace Baitap3
{
    partial class frmDay
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
            this.txtMonth = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAgain = new System.Windows.Forms.Button();
            this.btnCal = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lbDay = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(70, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Month:";
            // 
            // txtMonth
            // 
            this.txtMonth.Location = new System.Drawing.Point(145, 46);
            this.txtMonth.Name = "txtMonth";
            this.txtMonth.Size = new System.Drawing.Size(187, 22);
            this.txtMonth.TabIndex = 0;
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(145, 93);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(187, 22);
            this.txtYear.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(70, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Year:";
            // 
            // btnAgain
            // 
            this.btnAgain.Location = new System.Drawing.Point(59, 239);
            this.btnAgain.Name = "btnAgain";
            this.btnAgain.Size = new System.Drawing.Size(83, 72);
            this.btnAgain.TabIndex = 3;
            this.btnAgain.Text = "Again";
            this.btnAgain.UseVisualStyleBackColor = true;
            this.btnAgain.Click += new System.EventHandler(this.btnAgain_Click);
            // 
            // btnCal
            // 
            this.btnCal.Location = new System.Drawing.Point(188, 239);
            this.btnCal.Name = "btnCal";
            this.btnCal.Size = new System.Drawing.Size(94, 72);
            this.btnCal.TabIndex = 2;
            this.btnCal.Text = "Calculate";
            this.btnCal.UseVisualStyleBackColor = true;
            this.btnCal.Click += new System.EventHandler(this.btnCal_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(322, 239);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(83, 72);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lbDay
            // 
            this.lbDay.AutoSize = true;
            this.lbDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDay.Location = new System.Drawing.Point(56, 149);
            this.lbDay.Name = "lbDay";
            this.lbDay.Size = new System.Drawing.Size(263, 22);
            this.lbDay.TabIndex = 7;
            this.lbDay.Text = "Số ngày của tháng ... năm ... là:";
            // 
            // frmDay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 367);
            this.Controls.Add(this.lbDay);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCal);
            this.Controls.Add(this.btnAgain);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMonth);
            this.Controls.Add(this.label1);
            this.Name = "frmDay";
            this.Text = "Day number of the month";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMonth;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAgain;
        private System.Windows.Forms.Button btnCal;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lbDay;
    }
}