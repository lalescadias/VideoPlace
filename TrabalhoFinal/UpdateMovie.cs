using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace TrabalhoFinal
{
    public partial class UpdateMovie : Form
    {
        DBConnect connectDataBase = new DBConnect();
        public UpdateMovie()
        {
            InitializeComponent();
            gp_data.Enabled = false;
            btn_update.Enabled = false;
            btn_new_search.Visible = false;
            cb_genre.SelectedIndex = 25;
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
                if (connectDataBase.SearchMovie(txt_search.Text, ref title, ref genre, ref amount, ref realese, ref desc))
                {
                    txt_title.Text = title;
                    txt_amount.Text = amount;
                    txt_releaseYear.Text = realese;
                    txt_desc.Text = desc;                   
                    gp_search.Enabled = false;
                    gp_data.Enabled = true;
                    btn_update.Enabled = true;
                    btn_new_search.Visible = true;
                    int i = -1;
                    foreach (string options in cb_genre.Items)
                    {
                        i++;
                        if (options == genre)
                        {
                            cb_genre.SelectedIndex = i;
                            break;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("No record found.", Util.title, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txt_search.Focus();
                    gp_data.Enabled = true;
                    btn_update.Enabled = false;
                    gp_data.Enabled = false;

                }
            }
        }

        private void btn_new_search_Click(object sender, EventArgs e)
        {
            gp_search.Enabled = true;
            gp_data.Enabled = false;
            btn_update.Enabled = false;
            btn_new_search.Visible = false;
            txt_search.Text = "";
            txt_search.Focus();
            Util.cleanfields1(ref txt_title, ref cb_genre, ref txt_amount, ref txt_releaseYear, ref txt_desc);
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        bool checksField()
        {
            txt_title.Text = Util.removeSpaces(txt_title.Text);
            txt_desc.Text = Util.removeSpaces(txt_desc.Text);
            if (txt_title.Text.Length < 1)
            {
                MessageBox.Show("Error in the title field!", Util.title, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt_title.Focus();
                return false;
            }
            return true;
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (checksField())
            {
                if (connectDataBase.updateMovie(txt_search.Text,txt_title.Text, cb_genre.Text, txt_amount.Text, txt_releaseYear.Text, txt_desc.Text))
                {
                    MessageBox.Show("Successfully updated!! Name: \n" + txt_title.Text, Util.title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Util.cleanfields(ref txt_title, ref cb_genre, ref txt_amount, ref txt_releaseYear, ref txt_desc);
                    btn_new_search_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("Update error!", Util.title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txt_amount_TextChanged(object sender, EventArgs e)
        {
            txt_amount.Text = Regex.Replace(txt_amount.Text, "[^0-9]", "");
        }

        private void txt_releaseYear_TextChanged(object sender, EventArgs e)
        {
            txt_releaseYear.Text = Regex.Replace(txt_releaseYear.Text, "[^0-9]", "");
        }
    }
}
