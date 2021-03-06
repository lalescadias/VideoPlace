﻿using System;
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
    public partial class insertUser : Form
    {
        DBConnect connectDataBase = new DBConnect();
        public insertUser()
        {
            InitializeComponent();
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
                MessageBox.Show("Error in the name field!", Util.title, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt_name.Focus();
                return false;
            }
            if(txt_nif.Text.Length < 9)
            {
                MessageBox.Show("Error in the nif field!", Util.title, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt_nif.Focus();
                return false;
            }

            return true;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {           
            if (checksField())
            {
                if (connectDataBase.SearchUser(txt_nif.Text) > 0)
                {
                    MessageBox.Show("User already registered!", Util.title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (connectDataBase.insertUser(txt_name.Text, txt_nif.Text, txt_contact.Text, txt_adress.Text))
                    {
                        MessageBox.Show("Successfully inserted!! Name: \n" + txt_name.Text, Util.title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Util.cleanfields(ref txt_name,ref txt_nif,ref txt_contact,ref txt_adress);
                    }
               else
                    {
                        MessageBox.Show("Insertion error!", Util.title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
            }
        }

        private void txt_nif_TextChanged(object sender, EventArgs e)
        {
            txt_nif.Text = Regex.Replace(txt_nif.Text, "[^0-9]", "");
        }
    }
}
