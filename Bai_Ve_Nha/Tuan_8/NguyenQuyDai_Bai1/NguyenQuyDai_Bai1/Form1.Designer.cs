namespace NguyenQuyDai_Bai1
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
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.caiRang = new System.Windows.Forms.NumericUpDown();
            this.ckbLayCao = new System.Windows.Forms.CheckBox();
            this.ckbChupHinhRang = new System.Windows.Forms.CheckBox();
            this.ckbTayTrang = new System.Windows.Forms.CheckBox();
            this.ckbCaoVoi = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnTinh = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.lblMoney = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.caiRang)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(106, 77);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(103, 16);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Tên khách hàng";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(279, 77);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(270, 22);
            this.txtName.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.caiRang);
            this.groupBox1.Controls.Add(this.ckbLayCao);
            this.groupBox1.Controls.Add(this.ckbChupHinhRang);
            this.groupBox1.Controls.Add(this.ckbTayTrang);
            this.groupBox1.Controls.Add(this.ckbCaoVoi);
            this.groupBox1.Location = new System.Drawing.Point(123, 150);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(478, 318);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bảng giá";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 269);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Hàn răng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(353, 275);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "90 000 VND / cái";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(353, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "100 000 VND";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(343, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "150 000 VND";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(343, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "1 200 000 VND";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(343, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "100 000 VND";
            // 
            // caiRang
            // 
            this.caiRang.Location = new System.Drawing.Point(115, 269);
            this.caiRang.Maximum = new decimal(new int[] {
            32,
            0,
            0,
            0});
            this.caiRang.Name = "caiRang";
            this.caiRang.Size = new System.Drawing.Size(68, 22);
            this.caiRang.TabIndex = 4;
            // 
            // ckbLayCao
            // 
            this.ckbLayCao.AutoSize = true;
            this.ckbLayCao.Location = new System.Drawing.Point(35, 230);
            this.ckbLayCao.Name = "ckbLayCao";
            this.ckbLayCao.Size = new System.Drawing.Size(77, 20);
            this.ckbLayCao.TabIndex = 3;
            this.ckbLayCao.Text = "Lấy cao";
            this.ckbLayCao.UseVisualStyleBackColor = true;
            // 
            // ckbChupHinhRang
            // 
            this.ckbChupHinhRang.AutoSize = true;
            this.ckbChupHinhRang.Location = new System.Drawing.Point(35, 165);
            this.ckbChupHinhRang.Name = "ckbChupHinhRang";
            this.ckbChupHinhRang.Size = new System.Drawing.Size(117, 20);
            this.ckbChupHinhRang.TabIndex = 2;
            this.ckbChupHinhRang.Text = "Chụp hình răng";
            this.ckbChupHinhRang.UseVisualStyleBackColor = true;
            // 
            // ckbTayTrang
            // 
            this.ckbTayTrang.AutoSize = true;
            this.ckbTayTrang.Location = new System.Drawing.Point(35, 99);
            this.ckbTayTrang.Name = "ckbTayTrang";
            this.ckbTayTrang.Size = new System.Drawing.Size(86, 20);
            this.ckbTayTrang.TabIndex = 1;
            this.ckbTayTrang.Text = "Tẩy trắng";
            this.ckbTayTrang.UseVisualStyleBackColor = true;
            // 
            // ckbCaoVoi
            // 
            this.ckbCaoVoi.AutoSize = true;
            this.ckbCaoVoi.Location = new System.Drawing.Point(35, 40);
            this.ckbCaoVoi.Name = "ckbCaoVoi";
            this.ckbCaoVoi.Size = new System.Drawing.Size(75, 20);
            this.ckbCaoVoi.TabIndex = 0;
            this.ckbCaoVoi.Text = "Cạo vôi";
            this.ckbCaoVoi.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(276, 507);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 16);
            this.label7.TabIndex = 3;
            this.label7.Text = "Tổng tiền";
            // 
            // btnTinh
            // 
            this.btnTinh.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnTinh.Location = new System.Drawing.Point(238, 555);
            this.btnTinh.Name = "btnTinh";
            this.btnTinh.Size = new System.Drawing.Size(95, 35);
            this.btnTinh.TabIndex = 4;
            this.btnTinh.Text = "Tính tiền";
            this.btnTinh.UseVisualStyleBackColor = false;
            this.btnTinh.Click += new System.EventHandler(this.btnTinh_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnThoat.Location = new System.Drawing.Point(424, 555);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(95, 35);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click_1);
            // 
            // lblMoney
            // 
            this.lblMoney.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMoney.Location = new System.Drawing.Point(469, 507);
            this.lblMoney.Name = "lblMoney";
            this.lblMoney.Size = new System.Drawing.Size(132, 23);
            this.lblMoney.TabIndex = 6;
            this.lblMoney.Text = "0";
            this.lblMoney.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 662);
            this.Controls.Add(this.lblMoney);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnTinh);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Name = "Form1";
            this.Text = "Tính tiền khám răng";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.caiRang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown caiRang;
        private System.Windows.Forms.CheckBox ckbLayCao;
        private System.Windows.Forms.CheckBox ckbChupHinhRang;
        private System.Windows.Forms.CheckBox ckbTayTrang;
        private System.Windows.Forms.CheckBox ckbCaoVoi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnTinh;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label lblMoney;
    }
}

