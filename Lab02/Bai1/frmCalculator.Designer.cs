namespace Bai1
{
    partial class frmCalculator
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
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btnNumber = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCal = new System.Windows.Forms.Button();
            this.btnOp = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(19, 12);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(234, 44);
            this.txtResult.TabIndex = 0;
            // 
            // btnNumber
            // 
            this.btnNumber.Location = new System.Drawing.Point(19, 262);
            this.btnNumber.Name = "btnNumber";
            this.btnNumber.Size = new System.Drawing.Size(54, 42);
            this.btnNumber.TabIndex = 1;
            this.btnNumber.Text = "0";
            this.btnNumber.UseVisualStyleBackColor = true;
            this.btnNumber.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(79, 262);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(54, 42);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "C";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnCal
            // 
            this.btnCal.Location = new System.Drawing.Point(139, 262);
            this.btnCal.Name = "btnCal";
            this.btnCal.Size = new System.Drawing.Size(54, 42);
            this.btnCal.TabIndex = 3;
            this.btnCal.Text = "=";
            this.btnCal.UseVisualStyleBackColor = true;
            this.btnCal.Click += new System.EventHandler(this.btnCal_Click);
            // 
            // btnOp
            // 
            this.btnOp.Location = new System.Drawing.Point(199, 100);
            this.btnOp.Name = "btnOp";
            this.btnOp.Size = new System.Drawing.Size(54, 42);
            this.btnOp.TabIndex = 16;
            this.btnOp.Text = "+";
            this.btnOp.UseVisualStyleBackColor = true;
            this.btnOp.Click += new System.EventHandler(this.btnOp_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(199, 208);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(54, 42);
            this.button4.TabIndex = 18;
            this.button4.Text = "*";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.btnOp_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(199, 262);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(54, 42);
            this.button5.TabIndex = 18;
            this.button5.Text = "/";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.btnOp_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(19, 208);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(54, 42);
            this.button6.TabIndex = 1;
            this.button6.Text = "1";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(19, 154);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(54, 42);
            this.button7.TabIndex = 1;
            this.button7.Text = "4";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(19, 100);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(54, 42);
            this.button8.TabIndex = 1;
            this.button8.Text = "7";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(79, 154);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(54, 42);
            this.button9.TabIndex = 1;
            this.button9.Text = "5";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(79, 100);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(54, 42);
            this.button10.TabIndex = 1;
            this.button10.Text = "8";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(139, 154);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(54, 42);
            this.button11.TabIndex = 1;
            this.button11.Text = "6";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(139, 100);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(54, 42);
            this.button12.TabIndex = 1;
            this.button12.Text = "9";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(79, 208);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(54, 42);
            this.button13.TabIndex = 1;
            this.button13.Text = "2";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(139, 208);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(54, 42);
            this.button14.TabIndex = 1;
            this.button14.Text = "3";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(199, 154);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(54, 42);
            this.button1.TabIndex = 16;
            this.button1.Text = "-";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnOp_Click);
            // 
            // frmCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 312);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnOp);
            this.Controls.Add(this.btnCal);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.btnNumber);
            this.Controls.Add(this.txtResult);
            this.Name = "frmCalculator";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button btnNumber;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnCal;
        private System.Windows.Forms.Button btnOp;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button1;
    }
}

