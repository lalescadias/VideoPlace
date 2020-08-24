namespace TrabalhoFinal
{
    partial class DeleteMovie
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteMovie));
            this.gp_search = new System.Windows.Forms.GroupBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_new_search = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gp_data = new System.Windows.Forms.GroupBox();
            this.txt_genre = new System.Windows.Forms.TextBox();
            this.txt_desc = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_releaseYear = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_amount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_title = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.gp_search.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gp_data.SuspendLayout();
            this.SuspendLayout();
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
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(81, 42);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(176, 20);
            this.txt_search.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Nº Movie:";
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
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(349, 39);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(123, 58);
            this.btn_delete.TabIndex = 1;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_new_search);
            this.groupBox2.Controls.Add(this.btn_delete);
            this.groupBox2.Controls.Add(this.btn_cancel);
            this.groupBox2.Location = new System.Drawing.Point(12, 403);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(488, 123);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            // 
            // gp_data
            // 
            this.gp_data.Controls.Add(this.txt_genre);
            this.gp_data.Controls.Add(this.txt_desc);
            this.gp_data.Controls.Add(this.label5);
            this.gp_data.Controls.Add(this.txt_releaseYear);
            this.gp_data.Controls.Add(this.label1);
            this.gp_data.Controls.Add(this.txt_amount);
            this.gp_data.Controls.Add(this.label3);
            this.gp_data.Controls.Add(this.txt_title);
            this.gp_data.Controls.Add(this.label2);
            this.gp_data.Controls.Add(this.label6);
            this.gp_data.Location = new System.Drawing.Point(12, 119);
            this.gp_data.Name = "gp_data";
            this.gp_data.Size = new System.Drawing.Size(488, 278);
            this.gp_data.TabIndex = 11;
            this.gp_data.TabStop = false;
            this.gp_data.Text = "Data";
            // 
            // txt_genre
            // 
            this.txt_genre.Location = new System.Drawing.Point(102, 77);
            this.txt_genre.Name = "txt_genre";
            this.txt_genre.Size = new System.Drawing.Size(121, 20);
            this.txt_genre.TabIndex = 11;
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
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Release year:";
            // 
            // txt_amount
            // 
            this.txt_amount.Location = new System.Drawing.Point(103, 112);
            this.txt_amount.Name = "txt_amount";
            this.txt_amount.Size = new System.Drawing.Size(49, 20);
            this.txt_amount.TabIndex = 5;
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Title:";
            // 
            // DeleteMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 538);
            this.Controls.Add(this.gp_data);
            this.Controls.Add(this.gp_search);
            this.Controls.Add(this.groupBox2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DeleteMovie";
            this.Text = "Delete Movie";
            this.Load += new System.EventHandler(this.DeleteMovie_Load);
            this.gp_search.ResumeLayout(false);
            this.gp_search.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.gp_data.ResumeLayout(false);
            this.gp_data.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gp_search;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_new_search;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox gp_data;
        private System.Windows.Forms.TextBox txt_desc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_releaseYear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_amount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_title;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_genre;
    }
}