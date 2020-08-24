namespace TrabalhoFinal
{
    partial class ListBorrowing
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_print = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.gp_num_record = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.data_grid_borrowing = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.gp_num_record.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_grid_borrowing)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_print);
            this.groupBox1.Controls.Add(this.btn_close);
            this.groupBox1.Controls.Add(this.gp_num_record);
            this.groupBox1.Location = new System.Drawing.Point(12, 400);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(504, 107);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // btn_print
            // 
            this.btn_print.Location = new System.Drawing.Point(255, 27);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(90, 52);
            this.btn_print.TabIndex = 4;
            this.btn_print.Text = "Print";
            this.btn_print.UseVisualStyleBackColor = true;
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(383, 27);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(90, 52);
            this.btn_close.TabIndex = 3;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // gp_num_record
            // 
            this.gp_num_record.Controls.Add(this.label1);
            this.gp_num_record.Location = new System.Drawing.Point(16, 15);
            this.gp_num_record.Name = "gp_num_record";
            this.gp_num_record.Size = new System.Drawing.Size(156, 69);
            this.gp_num_record.TabIndex = 0;
            this.gp_num_record.TabStop = false;
            this.gp_num_record.Text = "Nº Record";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // data_grid_borrowing
            // 
            this.data_grid_borrowing.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_grid_borrowing.Location = new System.Drawing.Point(12, 12);
            this.data_grid_borrowing.Name = "data_grid_borrowing";
            this.data_grid_borrowing.Size = new System.Drawing.Size(510, 382);
            this.data_grid_borrowing.TabIndex = 6;
            // 
            // ListBorrowing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 510);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.data_grid_borrowing);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ListBorrowing";
            this.Text = "List Borrowing";
            this.Load += new System.EventHandler(this.ListBorrowing_Load);
            this.groupBox1.ResumeLayout(false);
            this.gp_num_record.ResumeLayout(false);
            this.gp_num_record.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_grid_borrowing)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_print;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.GroupBox gp_num_record;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView data_grid_borrowing;
    }
}