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
using MySql.Data.MySqlClient;

namespace TrabalhoFinal
{
    public partial class InsertNewBorrowing : Form
    {
        DBConnect connectDataBase = new DBConnect();
        public InsertNewBorrowing()
        {
            InitializeComponent();
            txt_seachUser.Focus();
            btn_save.Enabled = false;
            gp_dadosUser.Visible = false;
            gp_dataMovie.Visible = false;
            txt_searchMovie.Enabled = false;
            btn_searchMovie.Enabled = false;
            initial_date.Enabled = false;
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_searchUser_Click(object sender, EventArgs e)
        {
            string name = "";
            string contact = "";
            txt_seachUser.Text = Util.removeSpaces(txt_seachUser.Text);
            if (txt_seachUser.Text.Length < 1)
            {
                MessageBox.Show("Enter a user number.", Util.title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_seachUser.Focus();
            }
            else if (connectDataBase.checkHowManyBorrowingTheUserHas(txt_seachUser.Text) > 3)
            {
                MessageBox.Show("The user has already made more than 3 loans!", Util.title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_seachUser.Focus();
            }
            else
            {
                if (connectDataBase.SearchUser(txt_seachUser.Text, ref name, ref contact))
                {
                    txt_name.Text = name;
                    txt_contact.Text = contact;
                    gp_dadosUser.Visible = true;
                    gp_dadosUser.Enabled = false;
                    btn_searchMovie.Enabled = true;
                    txt_searchMovie.Enabled = true;
                    btn_searchUser.Enabled = false;
                    txt_seachUser.Enabled = false;
                }
                else
                {
                    MessageBox.Show("No record found.", Util.title, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    gp_dadosUser.Visible = false;
                    btn_searchMovie.Enabled = false;
                    txt_seachUser.Enabled = true;
                    txt_seachUser.Focus();
                }

            }
        }

        private void btn_searchMovie_Click(object sender, EventArgs e)
        {          
                    string title = "";
                    string genre = "";
                    string realease = "";
                    string amount = "";
                    txt_searchMovie.Text = Util.removeSpaces(txt_searchMovie.Text);
                    if (txt_searchMovie.Text.Length < 1)
                    {
                        MessageBox.Show("Enter a movie number.", Util.title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txt_searchMovie.Focus();
                    }
                    else
                    {
                        if (connectDataBase.SearchMovie(txt_searchMovie.Text, ref title, ref genre, ref realease, ref amount))
                        {
                           int amountMovies = int.Parse(amount);
                           if (amountMovies > 0)
                           {
                                txt_title.Text = title;
                                txt_genre.Text = genre;
                                txt_release.Text = realease;                           
                                gp_dataMovie.Visible = true;
                                gp_dataMovie.Enabled = false;                 
                                txt_searchMovie.Enabled = false;
                                btn_searchMovie.Enabled = false;
                            }
                            else
                            {
                                MessageBox.Show("Movie unavailable", Util.title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }   
                            
                            if (txt_name.Text != "" && txt_title.Text != "")
                            {
                                  btn_save.Enabled = true;
                            }

                    }
                        else
                        {
                            MessageBox.Show("No record found.", Util.title, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            gp_dataMovie.Visible = false;
                            txt_searchMovie.Enabled = true;
                            txt_searchMovie.Focus();
                        }
                    }
            
            
        }

        private void txt_seachUser_TextChanged(object sender, EventArgs e)
        {
            txt_seachUser.Text = Regex.Replace(txt_seachUser.Text, "[^0-9]", "");
        }

        private void txt_searchMovie_TextChanged(object sender, EventArgs e)
        {
            txt_searchMovie.Text = Regex.Replace(txt_searchMovie.Text, "[^0-9]", "");
        }

        private void btn_clearUser_Click(object sender, EventArgs e)
        {
            btn_searchUser.Enabled = true;
            txt_seachUser.Enabled = true;
            txt_seachUser.Text = "";
            txt_searchMovie.Text = "";
            txt_name.Text = "";
            txt_contact.Text = "";
            gp_dadosUser.Visible = false;
            gp_dataMovie.Visible = false;
            txt_searchMovie.Text = "";
            btn_searchMovie.Enabled = false;
            txt_title.Text = "";
            txt_genre.Text = "";
            txt_release.Text = "";
            btn_save.Enabled = false;
            final_date.Value = initial_date.Value;
        }

        private void btn_clearMovie_Click(object sender, EventArgs e)
        {
            
            if (txt_name.Text == "")
            {
                btn_searchMovie.Enabled = false;
                txt_searchMovie.Enabled = false;
            }
            else
            {
                btn_searchMovie.Enabled = true;
                txt_searchMovie.Enabled = true;
            }
            
            txt_searchMovie.Text = "";
            txt_title.Text = "";
            txt_genre.Text = "";
            txt_release.Text = "";
            btn_save.Enabled = false;
            gp_dataMovie.Visible = false;
            
        
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if(initial_date.Value >= final_date.Value)
            {
                MessageBox.Show("Invalid date!", Util.title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                final_date.Focus();
            }
            else if (txt_name.Text =="" || txt_title.Text == "")
            {
                MessageBox.Show("Unable to insert, check the fields!", Util.title, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }         
            else { 
                string initialDate = initial_date.Value.Year + "-" + initial_date.Value.Month + "-" + initial_date.Value.Day;
                string finalDate = final_date.Value.Year + "-" + final_date.Value.Month + "-" + final_date.Value.Day;
                MySqlTransaction tran = null;
                try
                {
                    if (connectDataBase.OpenConnection())
                    {
                        tran = connectDataBase.BeginTransaction();
                        connectDataBase.insertBorrowingWithoutConnection(txt_searchMovie.Text, txt_seachUser.Text, initialDate, finalDate);
                        connectDataBase.updateMovieWithoutConnection(txt_searchMovie.Text, "-");
                        tran.Commit();
                        MessageBox.Show("Successfully inserted!!", Util.title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btn_clearUser_Click(sender, e);
                        btn_clearMovie_Click(sender, e);                                        
                    }
                }
                catch(MySqlException ex)
                {
                    if (tran != null)
                    {
                        tran.Rollback();
                        MessageBox.Show("Insert error!", Util.title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        MessageBox.Show(ex.Message);
                    }
                }
                finally
                {
                    connectDataBase.CloseConnection();
                }

            }
        }
    }
}
