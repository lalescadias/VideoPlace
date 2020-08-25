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
    public partial class deleteUser : Form
    {
        DBConnect connectDataBase = new DBConnect();
        public deleteUser()
        {
            InitializeComponent();            
        }

        private void DeleteUser_Load(object sender, EventArgs e)
        {
            BlockControls();
            txt_search.Focus();
            btn_new_search.Visible = false;
            btn_delete.Enabled = false;
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
            string name = "";
            string contact = "";
            string adress = "";
            string nif = "";
            txt_search.Text = Util.removeSpaces(txt_search.Text);
            if (txt_search.Text.Length < 1)
            {
                MessageBox.Show("Enter a user number.", Util.title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_search.Focus();
            }
            else
            {
                if (connectDataBase.SearchUser(txt_search.Text, ref name, ref nif, ref contact, ref adress))
                {
                    txt_name.Text = name;
                    txt_contact.Text = contact;
                    txt_adress.Text = adress;
                    txt_nif.Text = nif;
                    btn_delete.Enabled = true;
                    btn_new_search.Visible = true;
                    btn_search.Enabled = false;
                    txt_search.Enabled = false;
                }
                else
                {
                    MessageBox.Show("No record found.", Util.title, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txt_search.Focus();
                    btn_new_search_Click(sender, e);

                }
            }
        }

        private void btn_new_search_Click(object sender, EventArgs e)
        {
            btn_cancel.Enabled = true;
            btn_new_search.Visible = false;
            btn_delete.Enabled = false;
            txt_search.Text = "";
            btn_search.Enabled = true;
            txt_search.Enabled = true;
            txt_search.Focus();
            Util.cleanfields(ref txt_name, ref txt_nif,ref txt_contact, ref txt_adress);
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (connectDataBase.SearchBorrowing(txt_search.Text, "user") >0)
            {
                MessageBox.Show("It is not possible to delete a user because he has rented movies.", Util.title, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (connectDataBase.DeleteUser(txt_search.Text))
            {
                MessageBox.Show("Deleted record.", Util.title, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                btn_new_search_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Elimination error.", Util.title, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}