namespace MDI_Form_Menu_Tabs_List_View
{
    partial class frmSolve
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lstPrime = new System.Windows.Forms.ListBox();
            this.lbPrime = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lstPerfect = new System.Windows.Forms.ListBox();
            this.lbPerfect = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.lstSquare = new System.Windows.Forms.ListBox();
            this.lbSquare = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboNumber = new System.Windows.Forms.ComboBox();
            this.btnSolve = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lbA = new System.Windows.Forms.Label();
            this.lbB = new System.Windows.Forms.Label();
            this.lbC = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(330, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(431, 505);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lbA);
            this.tabPage1.Controls.Add(this.lstPrime);
            this.tabPage1.Controls.Add(this.lbPrime);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(423, 476);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Prime Number";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lstPrime
            // 
            this.lstPrime.FormattingEnabled = true;
            this.lstPrime.ItemHeight = 16;
            this.lstPrime.Location = new System.Drawing.Point(45, 51);
            this.lstPrime.Name = "lstPrime";
            this.lstPrime.Size = new System.Drawing.Size(335, 372);
            this.lstPrime.TabIndex = 1;
            // 
            // lbPrime
            // 
            this.lbPrime.AutoSize = true;
            this.lbPrime.Location = new System.Drawing.Point(42, 18);
            this.lbPrime.Name = "lbPrime";
            this.lbPrime.Size = new System.Drawing.Size(110, 16);
            this.lbPrime.TabIndex = 0;
            this.lbPrime.Text = "Các số nguyên tố";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lbB);
            this.tabPage2.Controls.Add(this.lstPerfect);
            this.tabPage2.Controls.Add(this.lbPerfect);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(423, 476);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Perfect Number";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lstPerfect
            // 
            this.lstPerfect.FormattingEnabled = true;
            this.lstPerfect.ItemHeight = 16;
            this.lstPerfect.Location = new System.Drawing.Point(45, 51);
            this.lstPerfect.Name = "lstPerfect";
            this.lstPerfect.Size = new System.Drawing.Size(335, 372);
            this.lstPerfect.TabIndex = 3;
            // 
            // lbPerfect
            // 
            this.lbPerfect.AutoSize = true;
            this.lbPerfect.Location = new System.Drawing.Point(42, 18);
            this.lbPerfect.Name = "lbPerfect";
            this.lbPerfect.Size = new System.Drawing.Size(113, 16);
            this.lbPerfect.TabIndex = 2;
            this.lbPerfect.Text = "Các số hoàn thiện";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.lbC);
            this.tabPage3.Controls.Add(this.lstSquare);
            this.tabPage3.Controls.Add(this.lbSquare);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(423, 476);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Square Number";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // lstSquare
            // 
            this.lstSquare.FormattingEnabled = true;
            this.lstSquare.ItemHeight = 16;
            this.lstSquare.Location = new System.Drawing.Point(45, 51);
            this.lstSquare.Name = "lstSquare";
            this.lstSquare.Size = new System.Drawing.Size(335, 372);
            this.lstSquare.TabIndex = 3;
            // 
            // lbSquare
            // 
            this.lbSquare.AutoSize = true;
            this.lbSquare.Location = new System.Drawing.Point(42, 18);
            this.lbSquare.Name = "lbSquare";
            this.lbSquare.Size = new System.Drawing.Size(131, 16);
            this.lbSquare.TabIndex = 2;
            this.lbSquare.Text = "Các số chính phương";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chọn N";
            // 
            // cboNumber
            // 
            this.cboNumber.FormattingEnabled = true;
            this.cboNumber.Items.AddRange(new object[] {
            "100",
            "200",
            "300",
            "400",
            "500",
            "600",
            "700",
            "800",
            "900",
            "1000"});
            this.cboNumber.Location = new System.Drawing.Point(63, 64);
            this.cboNumber.Name = "cboNumber";
            this.cboNumber.Size = new System.Drawing.Size(199, 24);
            this.cboNumber.TabIndex = 2;
            // 
            // btnSolve
            // 
            this.btnSolve.Location = new System.Drawing.Point(64, 119);
            this.btnSolve.Name = "btnSolve";
            this.btnSolve.Size = new System.Drawing.Size(197, 88);
            this.btnSolve.TabIndex = 3;
            this.btnSolve.Text = "Solve";
            this.btnSolve.UseVisualStyleBackColor = true;
            this.btnSolve.Click += new System.EventHandler(this.btnSolve_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(64, 221);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(197, 88);
            this.btnRemove.TabIndex = 3;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(65, 323);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(197, 88);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lbA
            // 
            this.lbA.AutoSize = true;
            this.lbA.Location = new System.Drawing.Point(42, 443);
            this.lbA.Name = "lbA";
            this.lbA.Size = new System.Drawing.Size(0, 16);
            this.lbA.TabIndex = 2;
            // 
            // lbB
            // 
            this.lbB.AutoSize = true;
            this.lbB.Location = new System.Drawing.Point(42, 443);
            this.lbB.Name = "lbB";
            this.lbB.Size = new System.Drawing.Size(0, 16);
            this.lbB.TabIndex = 4;
            // 
            // lbC
            // 
            this.lbC.AutoSize = true;
            this.lbC.Location = new System.Drawing.Point(42, 443);
            this.lbC.Name = "lbC";
            this.lbC.Size = new System.Drawing.Size(0, 16);
            this.lbC.TabIndex = 4;
            // 
            // frmSolve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 529);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnSolve);
            this.Controls.Add(this.cboNumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmSolve";
            this.Text = "Solve Problems";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ListBox lstPrime;
        private System.Windows.Forms.Label lbPrime;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ListBox lstPerfect;
        private System.Windows.Forms.Label lbPerfect;
        private System.Windows.Forms.ListBox lstSquare;
        private System.Windows.Forms.Label lbSquare;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboNumber;
        private System.Windows.Forms.Button btnSolve;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lbA;
        private System.Windows.Forms.Label lbB;
        private System.Windows.Forms.Label lbC;
    }
}