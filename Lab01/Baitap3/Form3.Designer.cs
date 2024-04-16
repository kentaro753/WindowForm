namespace Baitap3
{
    partial class Form3
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
            this.txtN = new System.Windows.Forms.TextBox();
            this.lbS = new System.Windows.Forms.Label();
            this.btnAgain = new System.Windows.Forms.Button();
            this.btnCal = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(102, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập n:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(102, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "S=1+1/2+1/3+..+1/n (n>0)";
            // 
            // txtN
            // 
            this.txtN.Location = new System.Drawing.Point(180, 53);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(144, 22);
            this.txtN.TabIndex = 0;
            // 
            // lbS
            // 
            this.lbS.AutoSize = true;
            this.lbS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbS.Location = new System.Drawing.Point(102, 139);
            this.lbS.Name = "lbS";
            this.lbS.Size = new System.Drawing.Size(0, 20);
            this.lbS.TabIndex = 3;
            // 
            // btnAgain
            // 
            this.btnAgain.Location = new System.Drawing.Point(31, 197);
            this.btnAgain.Name = "btnAgain";
            this.btnAgain.Size = new System.Drawing.Size(102, 85);
            this.btnAgain.TabIndex = 2;
            this.btnAgain.Text = "Làm lại";
            this.btnAgain.UseVisualStyleBackColor = true;
            this.btnAgain.Click += new System.EventHandler(this.btnAgain_Click);
            // 
            // btnCal
            // 
            this.btnCal.Location = new System.Drawing.Point(170, 197);
            this.btnCal.Name = "btnCal";
            this.btnCal.Size = new System.Drawing.Size(102, 85);
            this.btnCal.TabIndex = 1;
            this.btnCal.Text = "Tính S";
            this.btnCal.UseVisualStyleBackColor = true;
            this.btnCal.Click += new System.EventHandler(this.btnCal_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(306, 197);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(102, 85);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 309);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCal);
            this.Controls.Add(this.btnAgain);
            this.Controls.Add(this.lbS);
            this.Controls.Add(this.txtN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Nhập n tính S";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.Label lbS;
        private System.Windows.Forms.Button btnAgain;
        private System.Windows.Forms.Button btnCal;
        private System.Windows.Forms.Button btnExit;
    }
}