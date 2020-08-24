namespace TrabalhoFinal
{
    partial class InsertMovie
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
            this.gp_data = new System.Windows.Forms.GroupBox();
            this.cb_genre = new System.Windows.Forms.ComboBox();
            this.txt_desc = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_releaseYear = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_amount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_title = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.gb_btn = new System.Windows.Forms.GroupBox();
            this.gp_data.SuspendLayout();
            this.gb_btn.SuspendLayout();
            this.SuspendLayout();
            // 
            // gp_data
            // 
            this.gp_data.Controls.Add(this.cb_genre);
            this.gp_data.Controls.Add(this.txt_desc);
            this.gp_data.Controls.Add(this.label5);
            this.gp_data.Controls.Add(this.txt_releaseYear);
            this.gp_data.Controls.Add(this.label4);
            this.gp_data.Controls.Add(this.txt_amount);
            this.gp_data.Controls.Add(this.label3);
            this.gp_data.Controls.Add(this.txt_title);
            this.gp_data.Controls.Add(this.label2);
            this.gp_data.Controls.Add(this.label1);
            this.gp_data.Location = new System.Drawing.Point(12, 12);
            this.gp_data.Name = "gp_data";
            this.gp_data.Size = new System.Drawing.Size(476, 278);
            this.gp_data.TabIndex = 4;
            this.gp_data.TabStop = false;
            this.gp_data.Text = "Data";
            // 
            // cb_genre
            // 
            this.cb_genre.FormattingEnabled = true;
            this.cb_genre.Items.AddRange(new object[] {
            "Absurdist/surreal/whimsical",
            "Action",
            "Adventure",
            "Animation",
            "Comedy",
            "Crime",
            "Drama",
            "Fantasy",
            "Historical",
            "Historical fiction",
            "Horror",
            "Magical realism",
            "Mystery",
            "Paranoid fiction",
            "Philosophical",
            "Political",
            "Romance",
            "Saga",
            "Satire",
            "Science fiction",
            "Social",
            "Speculative",
            "Thriller",
            "Urban",
            "Western",
            "Others"});
            this.cb_genre.Location = new System.Drawing.Point(103, 74);
            this.cb_genre.Name = "cb_genre";
            this.cb_genre.Size = new System.Drawing.Size(121, 21);
            this.cb_genre.TabIndex = 10;
            // 
            // txt_desc
            // 
            this.txt_desc.Location = new System.Drawing.Point(102, 190);
            this.txt_desc.MaxLength = 200;
            this.txt_desc.Multiline = true;
            this.txt_desc.Name = "txt_desc";
            this.txt_desc.Size = new System.Drawing.Size(337, 82);
            this.txt_desc.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Description:";
            // 
            // txt_releaseYear
            // 
            this.txt_releaseYear.Location = new System.Drawing.Point(103, 150);
            this.txt_releaseYear.Name = "txt_releaseYear";
            this.txt_releaseYear.Size = new System.Drawing.Size(49, 20);
            this.txt_releaseYear.TabIndex = 7;
            this.txt_releaseYear.TextChanged += new System.EventHandler(this.txt_releaseYear_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Release year:";
            // 
            // txt_amount
            // 
            this.txt_amount.Location = new System.Drawing.Point(103, 112);
            this.txt_amount.Name = "txt_amount";
            this.txt_amount.Size = new System.Drawing.Size(49, 20);
            this.txt_amount.TabIndex = 5;
            this.txt_amount.TextChanged += new System.EventHandler(this.txt_amount_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Amount:";
            // 
            // txt_title
            // 
            this.txt_title.Location = new System.Drawing.Point(102, 41);
            this.txt_title.Name = "txt_title";
            this.txt_title.Size = new System.Drawing.Size(338, 20);
            this.txt_title.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Genre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Title:";
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
            this.gb_btn.Location = new System.Drawing.Point(11, 315);
            this.gb_btn.Name = "gb_btn";
            this.gb_btn.Size = new System.Drawing.Size(476, 123);
            this.gb_btn.TabIndex = 5;
            this.gb_btn.TabStop = false;
            // 
            // InsertMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 450);
            this.Controls.Add(this.gp_data);
            this.Controls.Add(this.gb_btn);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InsertMovie";
            this.Text = "Insert Movie";
            this.Load += new System.EventHandler(this.InsertMovie_Load);
            this.gp_data.ResumeLayout(false);
            this.gp_data.PerformLayout();
            this.gb_btn.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gp_data;
        private System.Windows.Forms.TextBox txt_amount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_title;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.GroupBox gb_btn;
        private System.Windows.Forms.TextBox txt_desc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_releaseYear;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cb_genre;
    }
}