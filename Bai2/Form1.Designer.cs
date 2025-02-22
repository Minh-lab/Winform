namespace Bai2_WinformCoBan_
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
            this.label3 = new System.Windows.Forms.Label();
            this.txtSoNguyen = new System.Windows.Forms.TextBox();
            this.btnHienThi = new System.Windows.Forms.Button();
            this.lblSoHoanChinh = new System.Windows.Forms.Label();
            this.lblSoNguyenTo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.lblSoChinhPhuong = new System.Windows.Forms.Label();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập số n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-3, 13);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(273, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Các số hoàn chỉnh nhỏ hơn n:";
            // 
            // txtSoNguyen
            // 
            this.txtSoNguyen.Location = new System.Drawing.Point(86, 35);
            this.txtSoNguyen.Margin = new System.Windows.Forms.Padding(4);
            this.txtSoNguyen.Name = "txtSoNguyen";
            this.txtSoNguyen.Size = new System.Drawing.Size(228, 30);
            this.txtSoNguyen.TabIndex = 4;
            this.txtSoNguyen.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSoNguyen_KeyDown);
            this.txtSoNguyen.Leave += new System.EventHandler(this.txtSoNguyen_Leave);
            // 
            // btnHienThi
            // 
            this.btnHienThi.Location = new System.Drawing.Point(322, 31);
            this.btnHienThi.Margin = new System.Windows.Forms.Padding(4);
            this.btnHienThi.Name = "btnHienThi";
            this.btnHienThi.Size = new System.Drawing.Size(108, 38);
            this.btnHienThi.TabIndex = 7;
            this.btnHienThi.Text = "Hiển Thị";
            this.btnHienThi.UseVisualStyleBackColor = true;
            // 
            // lblSoHoanChinh
            // 
            this.lblSoHoanChinh.AutoSize = true;
            this.lblSoHoanChinh.Location = new System.Drawing.Point(207, 13);
            this.lblSoHoanChinh.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSoHoanChinh.MaximumSize = new System.Drawing.Size(400, 0);
            this.lblSoHoanChinh.Name = "lblSoHoanChinh";
            this.lblSoHoanChinh.Size = new System.Drawing.Size(0, 25);
            this.lblSoHoanChinh.TabIndex = 10;
            // 
            // lblSoNguyenTo
            // 
            this.lblSoNguyenTo.AutoSize = true;
            this.lblSoNguyenTo.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblSoNguyenTo.Location = new System.Drawing.Point(200, 12);
            this.lblSoNguyenTo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSoNguyenTo.MaximumSize = new System.Drawing.Size(400, 0);
            this.lblSoNguyenTo.Name = "lblSoNguyenTo";
            this.lblSoNguyenTo.Size = new System.Drawing.Size(0, 25);
            this.lblSoNguyenTo.TabIndex = 8;
            this.lblSoNguyenTo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-3, 12);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(263, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Các số nguyên tố nhỏ hơn n:";
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.AutoSize = true;
            this.panel4.Controls.Add(this.panel1);
            this.panel4.Controls.Add(this.panel3);
            this.panel4.Controls.Add(this.panel2);
            this.panel4.Location = new System.Drawing.Point(8, 71);
            this.panel4.Margin = new System.Windows.Forms.Padding(100);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(449, 182);
            this.panel4.TabIndex = 14;
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblSoNguyenTo);
            this.panel1.Location = new System.Drawing.Point(0, 16);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(425, 46);
            this.panel1.TabIndex = 11;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.lblSoHoanChinh);
            this.panel3.Location = new System.Drawing.Point(0, 120);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(425, 46);
            this.panel3.TabIndex = 13;
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.lblSoChinhPhuong);
            this.panel2.Location = new System.Drawing.Point(3, 68);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 100, 3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(425, 46);
            this.panel2.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(-3, 16);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(295, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Các số chính phương nhỏ hơn n:";
            // 
            // lblSoChinhPhuong
            // 
            this.lblSoChinhPhuong.AutoSize = true;
            this.lblSoChinhPhuong.Location = new System.Drawing.Point(214, 16);
            this.lblSoChinhPhuong.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSoChinhPhuong.MaximumSize = new System.Drawing.Size(400, 0);
            this.lblSoChinhPhuong.Name = "lblSoChinhPhuong";
            this.lblSoChinhPhuong.Size = new System.Drawing.Size(0, 25);
            this.lblSoChinhPhuong.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 265);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.btnHienThi);
            this.Controls.Add(this.txtSoNguyen);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSoNguyen;
        private System.Windows.Forms.Button btnHienThi;
        private System.Windows.Forms.Label lblSoHoanChinh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSoNguyenTo;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblSoChinhPhuong;
    }
}

