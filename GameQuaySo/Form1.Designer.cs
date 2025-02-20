namespace WindowsFormsApp2
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
            this.components = new System.ComponentModel.Container();
            this.lblSo1 = new System.Windows.Forms.Label();
            this.lblSo2 = new System.Windows.Forms.Label();
            this.lblSo3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTien = new System.Windows.Forms.Label();
            this.btnQuay = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnGameMoi = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblBonous = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblSo1
            // 
            this.lblSo1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblSo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSo1.ForeColor = System.Drawing.Color.Red;
            this.lblSo1.Location = new System.Drawing.Point(148, 45);
            this.lblSo1.Name = "lblSo1";
            this.lblSo1.Size = new System.Drawing.Size(157, 150);
            this.lblSo1.TabIndex = 0;
            this.lblSo1.Text = "0";
            this.lblSo1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSo2
            // 
            this.lblSo2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblSo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSo2.ForeColor = System.Drawing.Color.Red;
            this.lblSo2.Location = new System.Drawing.Point(329, 45);
            this.lblSo2.Name = "lblSo2";
            this.lblSo2.Size = new System.Drawing.Size(157, 150);
            this.lblSo2.TabIndex = 1;
            this.lblSo2.Text = "0";
            this.lblSo2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSo3
            // 
            this.lblSo3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblSo3.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSo3.ForeColor = System.Drawing.Color.Red;
            this.lblSo3.Location = new System.Drawing.Point(512, 45);
            this.lblSo3.Name = "lblSo3";
            this.lblSo3.Size = new System.Drawing.Size(157, 150);
            this.lblSo3.TabIndex = 2;
            this.lblSo3.Text = "0";
            this.lblSo3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(177, 254);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tiền Người Chơi:";
            // 
            // lblTien
            // 
            this.lblTien.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTien.ForeColor = System.Drawing.Color.Blue;
            this.lblTien.Location = new System.Drawing.Point(380, 248);
            this.lblTien.Name = "lblTien";
            this.lblTien.Size = new System.Drawing.Size(249, 41);
            this.lblTien.TabIndex = 4;
            this.lblTien.Text = "100";
            this.lblTien.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnQuay
            // 
            this.btnQuay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuay.Location = new System.Drawing.Point(167, 329);
            this.btnQuay.Name = "btnQuay";
            this.btnQuay.Size = new System.Drawing.Size(119, 48);
            this.btnQuay.TabIndex = 5;
            this.btnQuay.Text = "Quay Số";
            this.btnQuay.UseVisualStyleBackColor = true;
            this.btnQuay.Click += new System.EventHandler(this.btnQuay_Click);
            // 
            // btnStop
            // 
            this.btnStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.Location = new System.Drawing.Point(347, 329);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(119, 48);
            this.btnStop.TabIndex = 6;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnGameMoi
            // 
            this.btnGameMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGameMoi.Location = new System.Drawing.Point(540, 329);
            this.btnGameMoi.Name = "btnGameMoi";
            this.btnGameMoi.Size = new System.Drawing.Size(119, 48);
            this.btnGameMoi.TabIndex = 7;
            this.btnGameMoi.Text = "Game Mới";
            this.btnGameMoi.UseVisualStyleBackColor = true;
            this.btnGameMoi.Click += new System.EventHandler(this.btnGameMoi_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(329, 400);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(148, 48);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "Kết Thúc";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblBonous
            // 
            this.lblBonous.Location = new System.Drawing.Point(635, 248);
            this.lblBonous.Name = "lblBonous";
            this.lblBonous.Size = new System.Drawing.Size(86, 41);
            this.lblBonous.TabIndex = 9;
            this.lblBonous.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(777, 460);
            this.Controls.Add(this.lblBonous);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnGameMoi);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnQuay);
            this.Controls.Add(this.lblTien);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblSo3);
            this.Controls.Add(this.lblSo2);
            this.Controls.Add(this.lblSo1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSo1;
        private System.Windows.Forms.Label lblSo2;
        private System.Windows.Forms.Label lblSo3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTien;
        private System.Windows.Forms.Button btnQuay;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnGameMoi;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblBonous;
    }
}

