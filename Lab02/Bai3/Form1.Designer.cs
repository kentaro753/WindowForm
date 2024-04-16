namespace Bai3
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
            this.listBangso = new System.Windows.Forms.ListBox();
            this.btTatca = new System.Windows.Forms.Button();
            this.btChinnut = new System.Windows.Forms.Button();
            this.btDoixung = new System.Windows.Forms.Button();
            this.btGanh = new System.Windows.Forms.Button();
            this.btKhonggiam = new System.Windows.Forms.Button();
            this.btBasotang = new System.Windows.Forms.Button();
            this.btThoat = new System.Windows.Forms.Button();
            this.lbDem = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBangso
            // 
            this.listBangso.FormattingEnabled = true;
            this.listBangso.Location = new System.Drawing.Point(5, 6);
            this.listBangso.Name = "listBangso";
            this.listBangso.Size = new System.Drawing.Size(186, 368);
            this.listBangso.TabIndex = 0;
            // 
            // btTatca
            // 
            this.btTatca.Location = new System.Drawing.Point(199, 6);
            this.btTatca.Name = "btTatca";
            this.btTatca.Size = new System.Drawing.Size(228, 37);
            this.btTatca.TabIndex = 1;
            this.btTatca.Text = "Tất cả các bảng số";
            this.btTatca.UseVisualStyleBackColor = true;
            this.btTatca.Click += new System.EventHandler(this.btTatca_Click);
            // 
            // btChinnut
            // 
            this.btChinnut.Location = new System.Drawing.Point(199, 49);
            this.btChinnut.Name = "btChinnut";
            this.btChinnut.Size = new System.Drawing.Size(228, 37);
            this.btChinnut.TabIndex = 1;
            this.btChinnut.Text = "Bảng số 9 nút";
            this.btChinnut.UseVisualStyleBackColor = true;
            this.btChinnut.Click += new System.EventHandler(this.btChinnut_Click);
            // 
            // btDoixung
            // 
            this.btDoixung.Location = new System.Drawing.Point(199, 92);
            this.btDoixung.Name = "btDoixung";
            this.btDoixung.Size = new System.Drawing.Size(228, 37);
            this.btDoixung.TabIndex = 1;
            this.btDoixung.Text = "Bảng số đối xứng";
            this.btDoixung.UseVisualStyleBackColor = true;
            this.btDoixung.Click += new System.EventHandler(this.btDoixung_Click);
            // 
            // btGanh
            // 
            this.btGanh.Location = new System.Drawing.Point(199, 135);
            this.btGanh.Name = "btGanh";
            this.btGanh.Size = new System.Drawing.Size(228, 37);
            this.btGanh.TabIndex = 1;
            this.btGanh.Text = "Bảng số gánh";
            this.btGanh.UseVisualStyleBackColor = true;
            this.btGanh.Click += new System.EventHandler(this.btGanh_Click);
            // 
            // btKhonggiam
            // 
            this.btKhonggiam.Location = new System.Drawing.Point(199, 221);
            this.btKhonggiam.Name = "btKhonggiam";
            this.btKhonggiam.Size = new System.Drawing.Size(228, 37);
            this.btKhonggiam.TabIndex = 1;
            this.btKhonggiam.Text = "Bảng số không giảm";
            this.btKhonggiam.UseVisualStyleBackColor = true;
            this.btKhonggiam.Click += new System.EventHandler(this.btKhonggiam_Click);
            // 
            // btBasotang
            // 
            this.btBasotang.Location = new System.Drawing.Point(199, 178);
            this.btBasotang.Name = "btBasotang";
            this.btBasotang.Size = new System.Drawing.Size(228, 37);
            this.btBasotang.TabIndex = 1;
            this.btBasotang.Text = "Bảng số có 3 số tăng";
            this.btBasotang.UseVisualStyleBackColor = true;
            this.btBasotang.Click += new System.EventHandler(this.btBasotang_Click);
            // 
            // btThoat
            // 
            this.btThoat.Location = new System.Drawing.Point(199, 264);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(228, 37);
            this.btThoat.TabIndex = 1;
            this.btThoat.Text = "Thoát";
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // lbDem
            // 
            this.lbDem.AutoSize = true;
            this.lbDem.Location = new System.Drawing.Point(210, 321);
            this.lbDem.Name = "lbDem";
            this.lbDem.Size = new System.Drawing.Size(0, 13);
            this.lbDem.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 385);
            this.Controls.Add(this.lbDem);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.btKhonggiam);
            this.Controls.Add(this.btBasotang);
            this.Controls.Add(this.btGanh);
            this.Controls.Add(this.btDoixung);
            this.Controls.Add(this.btChinnut);
            this.Controls.Add(this.btTatca);
            this.Controls.Add(this.listBangso);
            this.Name = "Form1";
            this.Text = "Bảng số xe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBangso;
        private System.Windows.Forms.Button btTatca;
        private System.Windows.Forms.Button btChinnut;
        private System.Windows.Forms.Button btDoixung;
        private System.Windows.Forms.Button btGanh;
        private System.Windows.Forms.Button btKhonggiam;
        private System.Windows.Forms.Button btBasotang;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.Label lbDem;
    }
}

