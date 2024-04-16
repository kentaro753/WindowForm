namespace Baitap3
{
    partial class frmSolve1
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
            this.btnAgain = new System.Windows.Forms.Button();
            this.btnSolve = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lbA = new System.Windows.Forms.Label();
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbS = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAgain
            // 
            this.btnAgain.Location = new System.Drawing.Point(50, 273);
            this.btnAgain.Name = "btnAgain";
            this.btnAgain.Size = new System.Drawing.Size(96, 78);
            this.btnAgain.TabIndex = 3;
            this.btnAgain.Text = "Again";
            this.btnAgain.UseVisualStyleBackColor = true;
            this.btnAgain.Click += new System.EventHandler(this.btnAgain_Click);
            // 
            // btnSolve
            // 
            this.btnSolve.Location = new System.Drawing.Point(193, 273);
            this.btnSolve.Name = "btnSolve";
            this.btnSolve.Size = new System.Drawing.Size(96, 78);
            this.btnSolve.TabIndex = 2;
            this.btnSolve.Text = "Solve";
            this.btnSolve.UseVisualStyleBackColor = true;
            this.btnSolve.Click += new System.EventHandler(this.btnSolve_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(331, 273);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(96, 78);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lbA
            // 
            this.lbA.AutoSize = true;
            this.lbA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbA.Location = new System.Drawing.Point(95, 50);
            this.lbA.Name = "lbA";
            this.lbA.Size = new System.Drawing.Size(30, 20);
            this.lbA.TabIndex = 3;
            this.lbA.Text = "A=";
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(148, 50);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(195, 22);
            this.txtA.TabIndex = 0;
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(148, 100);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(195, 22);
            this.txtB.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(95, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "B=";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbS
            // 
            this.lbS.AutoSize = true;
            this.lbS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbS.Location = new System.Drawing.Point(47, 161);
            this.lbS.Name = "lbS";
            this.lbS.Size = new System.Drawing.Size(0, 25);
            this.lbS.TabIndex = 7;
            // 
            // frmSolve1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 395);
            this.Controls.Add(this.lbS);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.lbA);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSolve);
            this.Controls.Add(this.btnAgain);
            this.Name = "frmSolve1";
            this.Text = "Giải phương trình bậc nhất 1 ẩn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgain;
        private System.Windows.Forms.Button btnSolve;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lbA;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbS;
    }
}