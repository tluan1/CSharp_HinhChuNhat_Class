﻿namespace CSharp_HinhChuNhat_Class
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
            this.lblrong = new System.Windows.Forms.Label();
            this.lblcao = new System.Windows.Forms.Label();
            this.txtCao = new System.Windows.Forms.TextBox();
            this.txtRong = new System.Windows.Forms.TextBox();
            this.txtketqua = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDientich = new System.Windows.Forms.Button();
            this.btnChuvi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(762, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "TÍNH CHU VI VÀ DIỆN TÍCH HÌNH CHỮ NHẬT SỬ DỤNG CLASS";
            // 
            // lblrong
            // 
            this.lblrong.AutoSize = true;
            this.lblrong.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblrong.Location = new System.Drawing.Point(153, 157);
            this.lblrong.Name = "lblrong";
            this.lblrong.Size = new System.Drawing.Size(77, 33);
            this.lblrong.TabIndex = 0;
            this.lblrong.Text = "Rộng";
            // 
            // lblcao
            // 
            this.lblcao.AutoSize = true;
            this.lblcao.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcao.Location = new System.Drawing.Point(153, 91);
            this.lblcao.Name = "lblcao";
            this.lblcao.Size = new System.Drawing.Size(60, 33);
            this.lblcao.TabIndex = 0;
            this.lblcao.Text = "Cao";
            // 
            // txtCao
            // 
            this.txtCao.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCao.Location = new System.Drawing.Point(313, 89);
            this.txtCao.Name = "txtCao";
            this.txtCao.Size = new System.Drawing.Size(225, 38);
            this.txtCao.TabIndex = 1;
            this.txtCao.Text = "8";
            // 
            // txtRong
            // 
            this.txtRong.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRong.Location = new System.Drawing.Point(313, 152);
            this.txtRong.Name = "txtRong";
            this.txtRong.Size = new System.Drawing.Size(225, 38);
            this.txtRong.TabIndex = 1;
            this.txtRong.Text = "4";
            // 
            // txtketqua
            // 
            this.txtketqua.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtketqua.Location = new System.Drawing.Point(313, 220);
            this.txtketqua.Name = "txtketqua";
            this.txtketqua.ReadOnly = true;
            this.txtketqua.Size = new System.Drawing.Size(442, 38);
            this.txtketqua.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(153, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 33);
            this.label4.TabIndex = 0;
            this.label4.Text = "Kết quả";
            // 
            // btnDientich
            // 
            this.btnDientich.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDientich.Location = new System.Drawing.Point(224, 317);
            this.btnDientich.Name = "btnDientich";
            this.btnDientich.Size = new System.Drawing.Size(164, 77);
            this.btnDientich.TabIndex = 2;
            this.btnDientich.Text = "DIỆN TÍCH";
            this.btnDientich.UseVisualStyleBackColor = true;
            this.btnDientich.Click += new System.EventHandler(this.btnDientich_Click);
            // 
            // btnChuvi
            // 
            this.btnChuvi.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChuvi.Location = new System.Drawing.Point(462, 317);
            this.btnChuvi.Name = "btnChuvi";
            this.btnChuvi.Size = new System.Drawing.Size(164, 77);
            this.btnChuvi.TabIndex = 2;
            this.btnChuvi.Text = "CHU VI";
            this.btnChuvi.UseVisualStyleBackColor = true;
            this.btnChuvi.Click += new System.EventHandler(this.btnChuvi_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnChuvi);
            this.Controls.Add(this.btnDientich);
            this.Controls.Add(this.txtketqua);
            this.Controls.Add(this.txtRong);
            this.Controls.Add(this.txtCao);
            this.Controls.Add(this.lblcao);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblrong);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblrong;
        private System.Windows.Forms.Label lblcao;
        private System.Windows.Forms.TextBox txtCao;
        private System.Windows.Forms.TextBox txtRong;
        private System.Windows.Forms.TextBox txtketqua;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDientich;
        private System.Windows.Forms.Button btnChuvi;
    }
}

