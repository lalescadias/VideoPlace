﻿namespace TrabalhoFinal
{
    partial class UpdateUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateUser));
            this.gp_data = new System.Windows.Forms.GroupBox();
            this.txt_adress = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_contact = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_search = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_new_search = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.gp_search = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_nif = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.gp_data.SuspendLayout();
            this.gp_search.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gp_data
            // 
            this.gp_data.Controls.Add(this.txt_nif);
            this.gp_data.Controls.Add(this.label5);
            this.gp_data.Controls.Add(this.txt_adress);
            this.gp_data.Controls.Add(this.label3);
            this.gp_data.Controls.Add(this.txt_contact);
            this.gp_data.Controls.Add(this.txt_name);
            this.gp_data.Controls.Add(this.label2);
            this.gp_data.Controls.Add(this.label1);
            this.gp_data.Location = new System.Drawing.Point(12, 114);
            this.gp_data.Name = "gp_data";
            this.gp_data.Size = new System.Drawing.Size(488, 181);
            this.gp_data.TabIndex = 8;
            this.gp_data.TabStop = false;
            this.gp_data.Text = "Dados";
            // 
            // txt_adress
            // 
            this.txt_adress.Location = new System.Drawing.Point(81, 132);
            this.txt_adress.Name = "txt_adress";
            this.txt_adress.Size = new System.Drawing.Size(330, 20);
            this.txt_adress.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Adress:";
            // 
            // txt_contact
            // 
            this.txt_contact.Location = new System.Drawing.Point(81, 95);
            this.txt_contact.Name = "txt_contact";
            this.txt_contact.Size = new System.Drawing.Size(234, 20);
            this.txt_contact.TabIndex = 3;
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(81, 29);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(234, 20);
            this.txt_name.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Contact:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // btn_search
            // 
            this.btn_search.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_search.BackgroundImage")));
            this.btn_search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.Location = new System.Drawing.Point(263, 39);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(28, 25);
            this.btn_search.TabIndex = 2;
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Nº User:";
            // 
            // btn_new_search
            // 
            this.btn_new_search.Location = new System.Drawing.Point(183, 39);
            this.btn_new_search.Name = "btn_new_search";
            this.btn_new_search.Size = new System.Drawing.Size(123, 58);
            this.btn_new_search.TabIndex = 2;
            this.btn_new_search.Text = "New Search";
            this.btn_new_search.UseVisualStyleBackColor = true;
            this.btn_new_search.Click += new System.EventHandler(this.btn_new_search_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(349, 39);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(123, 58);
            this.btn_update.TabIndex = 1;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(9, 39);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(126, 58);
            this.btn_cancel.TabIndex = 0;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(81, 42);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(176, 20);
            this.txt_search.TabIndex = 1;
            // 
            // gp_search
            // 
            this.gp_search.Controls.Add(this.btn_search);
            this.gp_search.Controls.Add(this.txt_search);
            this.gp_search.Controls.Add(this.label4);
            this.gp_search.Location = new System.Drawing.Point(12, 12);
            this.gp_search.Name = "gp_search";
            this.gp_search.Size = new System.Drawing.Size(488, 100);
            this.gp_search.TabIndex = 10;
            this.gp_search.TabStop = false;
            this.gp_search.Text = "Search";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_new_search);
            this.groupBox2.Controls.Add(this.btn_update);
            this.groupBox2.Controls.Add(this.btn_cancel);
            this.groupBox2.Location = new System.Drawing.Point(12, 311);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(488, 123);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            // 
            // txt_nif
            // 
            this.txt_nif.Location = new System.Drawing.Point(81, 66);
            this.txt_nif.Name = "txt_nif";
            this.txt_nif.ReadOnly = true;
            this.txt_nif.Size = new System.Drawing.Size(123, 20);
            this.txt_nif.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Nif:";
            // 
            // UpdateUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 450);
            this.Controls.Add(this.gp_data);
            this.Controls.Add(this.gp_search);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UpdateUser";
            this.Text = "Update User";
            this.gp_data.ResumeLayout(false);
            this.gp_data.PerformLayout();
            this.gp_search.ResumeLayout(false);
            this.gp_search.PerformLayout();
            this.groupBox2.ResumeLayout(false);
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
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_new_search;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.GroupBox gp_search;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_nif;
        private System.Windows.Forms.Label label5;
    }
}