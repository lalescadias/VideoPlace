﻿namespace TrabalhoFinal
{
    partial class insertUser
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.gp_data = new System.Windows.Forms.GroupBox();
            this.txt_contact = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.gb_btn = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_adress = new System.Windows.Forms.TextBox();
            this.gp_data.SuspendLayout();
            this.gb_btn.SuspendLayout();
            this.SuspendLayout();
            // 
            // gp_data
            // 
            this.gp_data.Controls.Add(this.txt_adress);
            this.gp_data.Controls.Add(this.label3);
            this.gp_data.Controls.Add(this.txt_contact);
            this.gp_data.Controls.Add(this.txt_name);
            this.gp_data.Controls.Add(this.label2);
            this.gp_data.Controls.Add(this.label1);
            this.gp_data.Location = new System.Drawing.Point(12, 12);
            this.gp_data.Name = "gp_data";
            this.gp_data.Size = new System.Drawing.Size(476, 181);
            this.gp_data.TabIndex = 2;
            this.gp_data.TabStop = false;
            this.gp_data.Text = "Data";
            // 
            // txt_contact
            // 
            this.txt_contact.Location = new System.Drawing.Point(81, 77);
            this.txt_contact.Name = "txt_contact";
            this.txt_contact.Size = new System.Drawing.Size(157, 20);
            this.txt_contact.TabIndex = 3;
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(81, 41);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(338, 20);
            this.txt_name.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Contact:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(256, 33);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(163, 71);
            this.btn_save.TabIndex = 1;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(16, 33);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(163, 71);
            this.btn_cancel.TabIndex = 0;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // gb_btn
            // 
            this.gb_btn.Controls.Add(this.btn_save);
            this.gb_btn.Controls.Add(this.btn_cancel);
            this.gb_btn.Location = new System.Drawing.Point(12, 209);
            this.gb_btn.Name = "gb_btn";
            this.gb_btn.Size = new System.Drawing.Size(476, 123);
            this.gb_btn.TabIndex = 3;
            this.gb_btn.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Adress:";
            // 
            // txt_adress
            // 
            this.txt_adress.Location = new System.Drawing.Point(81, 109);
            this.txt_adress.Name = "txt_adress";
            this.txt_adress.Size = new System.Drawing.Size(338, 20);
            this.txt_adress.TabIndex = 5;
            // 
            // insertUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 353);
            this.Controls.Add(this.gp_data);
            this.Controls.Add(this.gb_btn);
            this.Name = "insertUser";
            this.Text = "Insert User";
            this.gp_data.ResumeLayout(false);
            this.gp_data.PerformLayout();
            this.gb_btn.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gp_data;
        private System.Windows.Forms.TextBox txt_adress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_contact;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.GroupBox gb_btn;
    }
}
