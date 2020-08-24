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
    public partial class UpdateUser : Form
    {
        DBConnect connectDataBase = new DBConnect();
        public UpdateUser()
        {
            InitializeComponent();
            gp_data.Enabled = false;
            btn_update.Enabled = false;
            btn_new_search.Visible = false;
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            string name = "";
            string contact = "";
            string adress = "";
            txt_search.Text = Util.removeSpaces(txt_search.Text);
            if (txt_search.Text.Length < 1)
            {
                MessageBox.Show("Enter a user number.", Util.title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_search.Focus();
            }
            else
            {
                if (connectDataBase.SearchUser(txt_search.Text, ref name, ref contact, ref adress))
                {
                    txt_name.Text = name;
                    txt_contact.Text = contact;
                    txt_adress.Text = adress;
                    gp_search.Enabled = false;
                    gp_data.Enabled = true;
                    btn_update.Enabled = true;
                    btn_new_search.Visible = true;
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
            Util.cleanfields(ref txt_name, ref txt_contact, ref txt_adress);
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        bool checksField()
        {
            txt_name.Text = Util.removeSpaces(txt_name.Text);
            txt_contact.Text = Util.removeSpaces(txt_contact.Text);
            txt_adress.Text = Util.removeSpaces(txt_adress.Text);
            if (txt_name.Text.Length < 1)
            {
                MessageBox.Show("Error in field name!", Util.title, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt_name.Focus();
                return false;
            }

            return true;
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (checksField())
            {
                if (connectDataBase.UpdateUser(txt_search.Text,txt_name.Text, txt_contact.Text, txt_adress.Text))
                {
                    MessageBox.Show("Successfully update!! Name: \n" + txt_name.Text, Util.title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Util.cleanfields(ref txt_name, ref txt_contact, ref txt_adress);
                    btn_new_search_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("Error update!", Util.title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }


}

