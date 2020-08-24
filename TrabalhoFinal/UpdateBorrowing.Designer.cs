namespace TrabalhoFinal
{
    partial class UpdateBorrowing
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateBorrowing));
            this.txt_seachBorrowing = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.gb_btn = new System.Windows.Forms.GroupBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_clearUser = new System.Windows.Forms.Button();
            this.btn_searchBorrowing = new System.Windows.Forms.Button();
            this.gp_borrowing = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gp_data = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gp_dataMovie = new System.Windows.Forms.GroupBox();
            this.txt_release = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_genre = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_title = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.gp_dadosUser = new System.Windows.Forms.GroupBox();
            this.txt_contact = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.final_date = new System.Windows.Forms.DateTimePicker();
            this.initial_date = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gb_btn.SuspendLayout();
            this.gp_borrowing.SuspendLayout();
            this.gp_data.SuspendLayout();
            this.gp_dataMovie.SuspendLayout();
            this.gp_dadosUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_seachBorrowing
            // 
            this.txt_seachBorrowing.Location = new System.Drawing.Point(87, 46);
            this.txt_seachBorrowing.Name = "txt_seachBorrowing";
            this.txt_seachBorrowing.Size = new System.Drawing.Size(176, 20);
            this.txt_seachBorrowing.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Nº borrowing:";
            // 
            // gb_btn
            // 
            this.gb_btn.Controls.Add(this.btn_save);
            this.gb_btn.Controls.Add(this.btn_cancel);
            this.gb_btn.Location = new System.Drawing.Point(12, 519);
            this.gb_btn.Name = "gb_btn";
            this.gb_btn.Size = new System.Drawing.Size(476, 99);
            this.gb_btn.TabIndex = 9;
            this.gb_btn.TabStop = false;
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(303, 19);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(163, 71);
            this.btn_save.TabIndex = 1;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(12, 19);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(163, 71);
            this.btn_cancel.TabIndex = 0;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_clearUser
            // 
            this.btn_clearUser.Location = new System.Drawing.Point(320, 46);
            this.btn_clearUser.Name = "btn_clearUser";
            this.btn_clearUser.Size = new System.Drawing.Size(57, 25);
            this.btn_clearUser.TabIndex = 2;
            this.btn_clearUser.Text = "Clear";
            this.btn_clearUser.UseVisualStyleBackColor = true;
            this.btn_clearUser.Click += new System.EventHandler(this.btn_clearUser_Click);
            // 
            // btn_searchBorrowing
            // 
            this.btn_searchBorrowing.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_searchBorrowing.BackgroundImage")));
            this.btn_searchBorrowing.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_searchBorrowing.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_searchBorrowing.Location = new System.Drawing.Point(272, 46);
            this.btn_searchBorrowing.Name = "btn_searchBorrowing";
            this.btn_searchBorrowing.Size = new System.Drawing.Size(28, 25);
            this.btn_searchBorrowing.TabIndex = 17;
            this.btn_searchBorrowing.UseVisualStyleBackColor = true;
            this.btn_searchBorrowing.Click += new System.EventHandler(this.btn_searchBorrowing_Click_1);
            // 
            // gp_borrowing
            // 
            this.gp_borrowing.Controls.Add(this.btn_clearUser);
            this.gp_borrowing.Controls.Add(this.btn_searchBorrowing);
            this.gp_borrowing.Controls.Add(this.txt_seachBorrowing);
            this.gp_borrowing.Controls.Add(this.label5);
            this.gp_borrowing.Controls.Add(this.label2);
            this.gp_borrowing.Location = new System.Drawing.Point(11, 29);
            this.gp_borrowing.Name = "gp_borrowing";
            this.gp_borrowing.Size = new System.Drawing.Size(476, 106);
            this.gp_borrowing.TabIndex = 8;
            this.gp_borrowing.TabStop = false;
            this.gp_borrowing.Text = "Borrowing";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 2;
            // 
            // gp_data
            // 
            this.gp_data.Controls.Add(this.label11);
            this.gp_data.Controls.Add(this.label1);
            this.gp_data.Controls.Add(this.gp_dataMovie);
            this.gp_data.Controls.Add(this.gp_dadosUser);
            this.gp_data.Controls.Add(this.final_date);
            this.gp_data.Controls.Add(this.initial_date);
            this.gp_data.Controls.Add(this.label4);
            this.gp_data.Controls.Add(this.label3);
            this.gp_data.Location = new System.Drawing.Point(12, 141);
            this.gp_data.Name = "gp_data";
            this.gp_data.Size = new System.Drawing.Size(475, 372);
            this.gp_data.TabIndex = 10;
            this.gp_data.TabStop = false;
            this.gp_data.Text = "Data";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 167);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(36, 13);
            this.label11.TabIndex = 30;
            this.label11.Text = "Movie";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "User";
            // 
            // gp_dataMovie
            // 
            this.gp_dataMovie.Controls.Add(this.txt_release);
            this.gp_dataMovie.Controls.Add(this.label10);
            this.gp_dataMovie.Controls.Add(this.txt_genre);
            this.gp_dataMovie.Controls.Add(this.label8);
            this.gp_dataMovie.Controls.Add(this.txt_title);
            this.gp_dataMovie.Controls.Add(this.label9);
            this.gp_dataMovie.Location = new System.Drawing.Point(6, 183);
            this.gp_dataMovie.Name = "gp_dataMovie";
            this.gp_dataMovie.Size = new System.Drawing.Size(407, 100);
            this.gp_dataMovie.TabIndex = 28;
            this.gp_dataMovie.TabStop = false;
            // 
            // txt_release
            // 
            this.txt_release.Location = new System.Drawing.Point(297, 61);
            this.txt_release.Name = "txt_release";
            this.txt_release.ReadOnly = true;
            this.txt_release.Size = new System.Drawing.Size(89, 20);
            this.txt_release.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(222, 63);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Release Year";
            // 
            // txt_genre
            // 
            this.txt_genre.Location = new System.Drawing.Point(63, 57);
            this.txt_genre.Name = "txt_genre";
            this.txt_genre.ReadOnly = true;
            this.txt_genre.Size = new System.Drawing.Size(122, 20);
            this.txt_genre.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 60);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Genre:";
            // 
            // txt_title
            // 
            this.txt_title.Location = new System.Drawing.Point(64, 19);
            this.txt_title.Name = "txt_title";
            this.txt_title.ReadOnly = true;
            this.txt_title.Size = new System.Drawing.Size(240, 20);
            this.txt_title.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Title:";
            // 
            // gp_dadosUser
            // 
            this.gp_dadosUser.Controls.Add(this.txt_contact);
            this.gp_dadosUser.Controls.Add(this.label7);
            this.gp_dadosUser.Controls.Add(this.txt_name);
            this.gp_dadosUser.Controls.Add(this.label6);
            this.gp_dadosUser.Location = new System.Drawing.Point(6, 38);
            this.gp_dadosUser.Name = "gp_dadosUser";
            this.gp_dadosUser.Size = new System.Drawing.Size(407, 100);
            this.gp_dadosUser.TabIndex = 27;
            this.gp_dadosUser.TabStop = false;
            // 
            // txt_contact
            // 
            this.txt_contact.Location = new System.Drawing.Point(63, 57);
            this.txt_contact.Name = "txt_contact";
            this.txt_contact.ReadOnly = true;
            this.txt_contact.Size = new System.Drawing.Size(240, 20);
            this.txt_contact.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Contact: ";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(64, 19);
            this.txt_name.Name = "txt_name";
            this.txt_name.ReadOnly = true;
            this.txt_name.Size = new System.Drawing.Size(240, 20);
            this.txt_name.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Name:";
            // 
            // final_date
            // 
            this.final_date.Location = new System.Drawing.Point(69, 330);
            this.final_date.Name = "final_date";
            this.final_date.Size = new System.Drawing.Size(200, 20);
            this.final_date.TabIndex = 26;
            // 
            // initial_date
            // 
            this.initial_date.Enabled = false;
            this.initial_date.Location = new System.Drawing.Point(69, 289);
            this.initial_date.Name = "initial_date";
            this.initial_date.Size = new System.Drawing.Size(200, 20);
            this.initial_date.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 330);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Final date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 295);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Initial date:";
            // 
            // UpdateBorrowing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 630);
            this.Controls.Add(this.gp_data);
            this.Controls.Add(this.gb_btn);
            this.Controls.Add(this.gp_borrowing);
            this.Name = "UpdateBorrowing";
            this.Text = "UpdateBorrowing";
            this.gb_btn.ResumeLayout(false);
            this.gp_borrowing.ResumeLayout(false);
            this.gp_borrowing.PerformLayout();
            this.gp_data.ResumeLayout(false);
            this.gp_data.PerformLayout();
            this.gp_dataMovie.ResumeLayout(false);
            this.gp_dataMovie.PerformLayout();
            this.gp_dadosUser.ResumeLayout(false);
            this.gp_dadosUser.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txt_seachBorrowing;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox gb_btn;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_clearUser;
        private System.Windows.Forms.Button btn_searchBorrowing;
        private System.Windows.Forms.GroupBox gp_borrowing;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gp_data;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gp_dataMovie;
        private System.Windows.Forms.TextBox txt_release;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_genre;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_title;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox gp_dadosUser;
        private System.Windows.Forms.TextBox txt_contact;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker final_date;
        private System.Windows.Forms.DateTimePicker initial_date;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}