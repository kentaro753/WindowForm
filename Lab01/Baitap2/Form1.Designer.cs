namespace Baitap2
{
    partial class Form4Operators
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
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSum = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDiff = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtProduct = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtQuotient = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCal = new System.Windows.Forms.Button();
            this.btnAgain = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập A:";
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(146, 53);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(281, 22);
            this.txtA.TabIndex = 0;
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(146, 81);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(281, 22);
            this.txtB.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nhập B:";
            // 
            // txtSum
            // 
            this.txtSum.Enabled = false;
            this.txtSum.Location = new System.Drawing.Point(146, 109);
            this.txtSum.Name = "txtSum";
            this.txtSum.Size = new System.Drawing.Size(281, 22);
            this.txtSum.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tổng là:";
            // 
            // txtDiff
            // 
            this.txtDiff.Enabled = false;
            this.txtDiff.Location = new System.Drawing.Point(146, 137);
            this.txtDiff.Name = "txtDiff";
            this.txtDiff.Size = new System.Drawing.Size(281, 22);
            this.txtDiff.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(68, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Hiệu là:";
            // 
            // txtProduct
            // 
            this.txtProduct.Enabled = false;
            this.txtProduct.Location = new System.Drawing.Point(146, 165);
            this.txtProduct.Name = "txtProduct";
            this.txtProduct.Size = new System.Drawing.Size(281, 22);
            this.txtProduct.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(68, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Tích là:";
            // 
            // txtQuotient
            // 
            this.txtQuotient.Enabled = false;
            this.txtQuotient.Location = new System.Drawing.Point(146, 193);
            this.txtQuotient.Name = "txtQuotient";
            this.txtQuotient.Size = new System.Drawing.Size(281, 22);
            this.txtQuotient.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(68, 199);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Thương là:";
            // 
            // btnCal
            // 
            this.btnCal.Location = new System.Drawing.Point(71, 262);
            this.btnCal.Name = "btnCal";
            this.btnCal.Size = new System.Drawing.Size(91, 74);
            this.btnCal.TabIndex = 2;
            this.btnCal.Text = "Tính";
            this.btnCal.UseVisualStyleBackColor = true;
            this.btnCal.Click += new System.EventHandler(this.btnCal_Click);
            // 
            // btnAgain
            // 
            this.btnAgain.Location = new System.Drawing.Point(205, 262);
            this.btnAgain.Name = "btnAgain";
            this.btnAgain.Size = new System.Drawing.Size(91, 74);
            this.btnAgain.TabIndex = 3;
            this.btnAgain.Text = "Làm lại";
            this.btnAgain.UseVisualStyleBackColor = true;
            this.btnAgain.Click += new System.EventHandler(this.btnAgain_Click_1);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(336, 262);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(91, 74);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form4Operators
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 383);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAgain);
            this.Controls.Add(this.btnCal);
            this.Controls.Add(this.txtQuotient);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtProduct);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDiff);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.label1);
            this.Name = "Form4Operators";
            this.Text = "Sum, Difference, Product and Quotient";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDiff;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtProduct;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtQuotient;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCal;
        private System.Windows.Forms.Button btnAgain;
        private System.Windows.Forms.Button btnExit;
    }
}