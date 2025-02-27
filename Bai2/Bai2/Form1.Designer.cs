namespace Bai2
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSoNguyen = new System.Windows.Forms.TextBox();
            this.btnHienthi = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblSoHoanChinh = new System.Windows.Forms.Label();
            this.lblSoChinhPhuong = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSoNguyenTo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel1);
            this.splitContainer1.Size = new System.Drawing.Size(1015, 358);
            this.splitContainer1.SplitterDistance = 167;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtSoNguyen, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.btnHienthi, 2, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1015, 167);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(4, 55);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(195, 55);
            this.label4.TabIndex = 0;
            this.label4.Text = "Nhập số n:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSoNguyen
            // 
            this.txtSoNguyen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSoNguyen.Location = new System.Drawing.Point(207, 59);
            this.txtSoNguyen.Margin = new System.Windows.Forms.Padding(4);
            this.txtSoNguyen.Multiline = true;
            this.txtSoNguyen.Name = "txtSoNguyen";
            this.txtSoNguyen.Size = new System.Drawing.Size(601, 47);
            this.txtSoNguyen.TabIndex = 1;
            this.txtSoNguyen.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSoNguyen_KeyDown);
            this.txtSoNguyen.Leave += new System.EventHandler(this.txtSoNguyen_Leave);
            // 
            // btnHienthi
            // 
            this.btnHienthi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnHienthi.Location = new System.Drawing.Point(816, 59);
            this.btnHienthi.Margin = new System.Windows.Forms.Padding(4);
            this.btnHienthi.Name = "btnHienthi";
            this.btnHienthi.Size = new System.Drawing.Size(195, 47);
            this.btnHienthi.TabIndex = 2;
            this.btnHienthi.Text = "Hiển Thị";
            this.btnHienthi.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.Controls.Add(this.lblSoHoanChinh, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblSoChinhPhuong, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblSoNguyenTo, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1015, 186);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblSoHoanChinh
            // 
            this.lblSoHoanChinh.AutoSize = true;
            this.lblSoHoanChinh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSoHoanChinh.Location = new System.Drawing.Point(207, 124);
            this.lblSoHoanChinh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSoHoanChinh.Name = "lblSoHoanChinh";
            this.lblSoHoanChinh.Size = new System.Drawing.Size(804, 62);
            this.lblSoHoanChinh.TabIndex = 5;
            this.lblSoHoanChinh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSoChinhPhuong
            // 
            this.lblSoChinhPhuong.AutoSize = true;
            this.lblSoChinhPhuong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSoChinhPhuong.Location = new System.Drawing.Point(207, 62);
            this.lblSoChinhPhuong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSoChinhPhuong.Name = "lblSoChinhPhuong";
            this.lblSoChinhPhuong.Size = new System.Drawing.Size(804, 62);
            this.lblSoChinhPhuong.TabIndex = 4;
            this.lblSoChinhPhuong.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(4, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 62);
            this.label1.TabIndex = 0;
            this.label1.Text = "Các số nguyên tố nhỏ hơn n:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(4, 62);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 62);
            this.label2.TabIndex = 1;
            this.label2.Text = "Các số chính phương nhỏ hơn n:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(4, 124);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(195, 62);
            this.label3.TabIndex = 2;
            this.label3.Text = "Các số hoàn chỉnh nhỏ hơn n:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSoNguyenTo
            // 
            this.lblSoNguyenTo.AutoSize = true;
            this.lblSoNguyenTo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSoNguyenTo.Location = new System.Drawing.Point(207, 0);
            this.lblSoNguyenTo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSoNguyenTo.Name = "lblSoNguyenTo";
            this.lblSoNguyenTo.Size = new System.Drawing.Size(804, 62);
            this.lblSoNguyenTo.TabIndex = 3;
            this.lblSoNguyenTo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 358);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSoNguyen;
        private System.Windows.Forms.Button btnHienthi;
        private System.Windows.Forms.Label lblSoHoanChinh;
        private System.Windows.Forms.Label lblSoChinhPhuong;
        private System.Windows.Forms.Label lblSoNguyenTo;
    }
}

