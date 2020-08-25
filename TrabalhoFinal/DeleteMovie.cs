using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabalhoFinal
{
    public partial class DeleteMovie : Form
    {

        DBConnect connectDataBase = new DBConnect();
        public DeleteMovie()
        {
            InitializeComponent();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void BlockControls()
        {
            foreach (Control c in gp_data.Controls)
            {
                if (c.GetType() == typeof(TextBox))
                {
                    TextBox tb = c as TextBox;
                    tb.ReadOnly = true;
                }
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            string title = "";
            string genre = "";
            string amount = "";
            string realese = "";
            string desc = "";
            txt_search.Text = Util.removeSpaces(txt_search.Text);
            if (txt_search.Text.Length < 1)
            {
                MessageBox.Show("Enter a user number.", Util.title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_search.Focus();
            }
            else
            {
                if (connectDataBase.SearchMovie(txt_search.Text, ref title, ref  genre, ref amount, ref realese, ref desc))
                {
                    txt_title.Text = title;
                    txt_genre.Text = genre;
                    txt_amount.Text = amount;
                    txt_releaseYear.Text = realese;
                    txt_desc.Text = desc;
                    btn_delete.Enabled = true;
                    btn_new_search.Visible = true;
                    txt_search.Enabled = false;
                    btn_search.Enabled = false;

                }
                else
                {
                    MessageBox.Show("No record found.", Util.title, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txt_search.Focus();
                    gp_data.Enabled = true;
                    btn_delete.Enabled = false;
                    gp_data.Enabled = false;

                }
            }
        }

        private void btn_new_search_Click(object sender, EventArgs e)
        {
            btn_cancel.Enabled = true;
            btn_new_search.Visible = false;
            btn_delete.Enabled = false;
            txt_search.Enabled = true;
            btn_search.Enabled = true;
            txt_search.Text = "";
            txt_search.Focus();
            txt_title.Clear();
            txt_genre.Clear();
            txt_amount.Clear();
            txt_desc.Clear();
            txt_releaseYear.Clear();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (connectDataBase.SearchBorrowing(txt_search.Text, "movie") > 0)
            {
                MessageBox.Show("It is not possible to delete film as there are rented films.", Util.title, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (connectDataBase.DeleteMovie(txt_search.Text))
            {
                MessageBox.Show("Deleted record.", Util.title, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                btn_new_search_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Elimination error.", Util.title, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeleteMovie_Load(object sender, EventArgs e)
        {
            BlockControls();
            txt_search.Focus();
            btn_new_search.Visible = false;
            btn_delete.Enabled = false;
        }

      
    }
}
