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
    public partial class InsertMovie : Form
    {
        DBConnect connectDataBase = new DBConnect();
        public InsertMovie()
        {
            InitializeComponent();
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

            private void btn_cancel_Click(object sender, EventArgs e)
            {
                this.Close();
            }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (checksField())
            {            
                if (connectDataBase.insertMovie(txt_title.Text,cb_genre.Text, txt_amount.Text, txt_releaseYear.Text, txt_desc.Text))
                {
                    MessageBox.Show("Successfully inserted!! Name: \n" + txt_title.Text, Util.title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Util.cleanfields(ref txt_title, ref cb_genre, ref txt_amount, ref txt_releaseYear, ref txt_desc);
                }
                else
                {
                    MessageBox.Show("Insertion error!", Util.title, MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void InsertMovie_Load(object sender, EventArgs e)
        {
            cb_genre.SelectedIndex = 25;
        }
    }
    }

