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
    public partial class UpdateBorrowing : Form
    {
        DBConnect connectDataBase = new DBConnect();
        public UpdateBorrowing()
        {
            InitializeComponent();
            btn_save.Enabled = false;
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_searchBorrowing_Click_1(object sender, EventArgs e)
        {
            string name = "";
            string contact = "";
            string title = "";
            string genre = "";
            string release = "";
            string initialDate = "";
            string finalDate = "";
            txt_seachBorrowing.Text = Util.removeSpaces(txt_seachBorrowing.Text);
            if (txt_seachBorrowing.Text.Length < 1)
            {
                MessageBox.Show("Enter a borrowing number.", Util.title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_seachBorrowing.Focus();
            }
            else
            {
                if (connectDataBase.SearchBorrowing(txt_seachBorrowing.Text, ref name, ref contact, ref title, ref genre, ref release, ref initialDate, ref finalDate))
                {
                    txt_name.Text = name;
                    txt_contact.Text = contact;
                    txt_title.Text = title;
                    txt_genre.Text = genre;
                    txt_release.Text = release;
                    initial_date.Value = DateTime.Parse(initialDate);
                    final_date.Value = DateTime.Parse(finalDate);
                    final_date.Enabled = true;
                    btn_save.Enabled = true;
                    btn_searchBorrowing.Enabled = false;
                    txt_seachBorrowing.Enabled = false;
                }
                else
                {
                    MessageBox.Show("No record found.", Util.title, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txt_seachBorrowing.Focus();
                }

            }

        }

        private void btn_clearUser_Click(object sender, EventArgs e)
        {
            txt_seachBorrowing.Text = "";
            txt_seachBorrowing.Enabled = true;
            txt_name.Text = "";
            txt_contact.Text = "";
            txt_title.Text = "";
            txt_genre.Text = "";
            txt_release.Text = "";
            initial_date.Value = DateTime.Now.Date;
            final_date.Value = DateTime.Now.Date;
            btn_save.Enabled = false;
            btn_searchBorrowing.Enabled = true;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (initial_date.Value >= final_date.Value)
            {
                MessageBox.Show("Invalid date!", Util.title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                final_date.Focus();
            }
            else
            {
                string finalDate = final_date.Value.Year + "-" + final_date.Value.Month + "-" + final_date.Value.Day;
                if (connectDataBase.updateBorrowing(txt_seachBorrowing.Text, finalDate))
                {
                    MessageBox.Show("Successfully updated!!", Util.title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btn_clearUser_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("Updated error!", Util.title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
    }
}


