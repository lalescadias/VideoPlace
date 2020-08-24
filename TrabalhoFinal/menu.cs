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
    public partial class menu : Form
    {
        deleteUser frmDeleteUser = new deleteUser();
        insertUser frmInsertUser = new insertUser();
        ListUser frmListUser = new ListUser();
        UpdateUser frmUpdateUser = new UpdateUser();
        InsertMovie frmInsertMovie = new InsertMovie();
        DeleteMovie frmDeleteMovie = new DeleteMovie();
        UpdateMovie frmUpdateMovie = new UpdateMovie();
        ListMovies frmListMovie = new ListMovies();
        InsertNewBorrowing frminsertNewBorrowing = new InsertNewBorrowing();
        UpdateBorrowing frmUpdateBorrowing = new UpdateBorrowing();
        ListBorrowing frmListBorrowing = new ListBorrowing();
        DeleteBorrowing frmDeleteBorrowing = new DeleteBorrowing();
        ReturnBorrowing frmReturnBorrowing = new ReturnBorrowing();
        public menu()
        {
            InitializeComponent();
        }

        private void menu_Load(object sender, EventArgs e)
        {
            /*frmDeleteUser.MdiParent = this;
            frmInsertUser.MdiParent = this;
            frmListUser.MdiParent = this;
            frmUpdateUser.MdiParent = this;*/
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
                if (frmUpdateUser.IsDisposed)
                {
                    frmUpdateUser = new UpdateUser();
                    frmUpdateUser.MdiParent = this;
                }
                frmUpdateUser.StartPosition = FormStartPosition.Manual;
                frmUpdateUser.Location = new Point((this.ClientSize.Width - frmUpdateUser.Width) / 2, (this.ClientSize.Height - 50 - frmUpdateUser.Height));
                frmUpdateUser.Show();
                frmUpdateUser.Activate();
        }

        private void insertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmInsertUser.IsDisposed)
            {
                frmInsertUser = new insertUser();
                frmInsertUser.MdiParent = this;
            }
            frmInsertUser.StartPosition = FormStartPosition.Manual;
            frmInsertUser.Location = new Point((this.ClientSize.Width - frmInsertUser.Width) / 2, (this.ClientSize.Height - 50 - frmInsertUser.Height) / 2);
            frmInsertUser.Show();
            frmInsertUser.Activate();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmDeleteUser.IsDisposed)
            {
                frmDeleteUser = new deleteUser();
                frmDeleteUser.MdiParent = this;
            }
            frmDeleteUser.StartPosition = FormStartPosition.Manual;
            frmDeleteUser.Location = new Point((this.ClientSize.Width - frmDeleteUser.Width) / 2, (this.ClientSize.Height - 50 - frmDeleteUser.Height) / 2);
            frmDeleteUser.Show();
            frmDeleteUser.Activate();
        }

        private void listToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmListUser.IsDisposed)
            {
                frmListUser = new ListUser();
                frmListUser.MdiParent = this;
            }
            frmListUser.StartPosition = FormStartPosition.Manual;
            frmListUser.Location = new Point((this.ClientSize.Width - frmListUser.Width) / 2, (this.ClientSize.Height - 50 - frmListUser.Height) / 2);
            frmListUser.Show();
            frmListUser.Activate();
        }

        private void formandosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void insertMovieToolStripMenuItem_Click(object sender, EventArgs e)
        {
                if (frmInsertMovie.IsDisposed)
                {
                    frmInsertMovie = new InsertMovie();
                    frmInsertMovie.MdiParent = this;
                }
                frmInsertMovie.StartPosition = FormStartPosition.Manual;
                frmInsertMovie.Location = new Point((this.ClientSize.Width - frmInsertMovie.Width) / 2, (this.ClientSize.Height - 50 - frmInsertMovie.Height));
                frmInsertMovie.Show();
                frmInsertMovie.Activate();
            
        }

        private void deleteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if(frmDeleteMovie.IsDisposed)
                {
                frmDeleteMovie = new DeleteMovie();
                frmDeleteMovie.MdiParent = this;
            }
            frmDeleteMovie.StartPosition = FormStartPosition.Manual;
            frmDeleteMovie.Location = new Point((this.ClientSize.Width - frmDeleteMovie.Width) / 2, (this.ClientSize.Height - 50 - frmDeleteMovie.Height));
            frmDeleteMovie.Show();
            frmDeleteMovie.Activate();
        }

        private void updateToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (frmUpdateMovie.IsDisposed)
            {
                frmUpdateMovie = new UpdateMovie();
                frmUpdateMovie.MdiParent = this;
            }
            frmUpdateMovie.StartPosition = FormStartPosition.Manual;
            frmUpdateMovie.Location = new Point((this.ClientSize.Width - frmUpdateMovie.Width) / 2, (this.ClientSize.Height - 50 - frmUpdateMovie.Height));
            frmUpdateMovie.Show();
            frmUpdateMovie.Activate();
        }

        private void listToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (frmListMovie.IsDisposed)
            {
                frmListMovie = new ListMovies();
                frmListMovie.MdiParent = this;
            }
            frmListMovie.StartPosition = FormStartPosition.Manual;
            frmListMovie.Location = new Point((this.ClientSize.Width - frmListMovie.Width) / 2, (this.ClientSize.Height - 50 - frmListMovie.Height) / 2);
            frmListMovie.Show();
            frmListMovie.Activate();
        }

        private void insertToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (frminsertNewBorrowing.IsDisposed)
            {
                frminsertNewBorrowing = new InsertNewBorrowing();
                frminsertNewBorrowing.MdiParent = this;
            }
            frminsertNewBorrowing.StartPosition = FormStartPosition.Manual;
            frminsertNewBorrowing.Location = new Point((this.ClientSize.Width - frminsertNewBorrowing.Width) / 2, (this.ClientSize.Height - 50 - frminsertNewBorrowing.Height));
            frminsertNewBorrowing.Show();
            frminsertNewBorrowing.Activate();
        }

        private void updateToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (frmUpdateBorrowing.IsDisposed)
            {
                frmUpdateBorrowing = new UpdateBorrowing();
                frmUpdateBorrowing.MdiParent = this;
            }
            frmUpdateBorrowing.StartPosition = FormStartPosition.Manual;
            frmUpdateBorrowing.Location = new Point((this.ClientSize.Width - frmUpdateBorrowing.Width) / 2, (this.ClientSize.Height - 50 - frmUpdateBorrowing.Height));
            frmUpdateBorrowing.Show();
            frmUpdateBorrowing.Activate();
        }

        private void listToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (frmListBorrowing.IsDisposed)
            {
                frmListBorrowing = new ListBorrowing();
                frmListBorrowing.MdiParent = this;
            }
            frmListBorrowing.StartPosition = FormStartPosition.Manual;
            frmListBorrowing.Location = new Point((this.ClientSize.Width - frmListBorrowing.Width) / 2, (this.ClientSize.Height - 50 - frmListBorrowing.Height) / 2);
            frmListBorrowing.Show();
            frmListBorrowing.Activate();
        }

        private void deleteToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (frmDeleteBorrowing.IsDisposed)
            {
                frmDeleteBorrowing = new DeleteBorrowing();
                frmDeleteBorrowing.MdiParent = this;
            }
            frmDeleteBorrowing.StartPosition = FormStartPosition.Manual;
            frmDeleteBorrowing.Location = new Point((this.ClientSize.Width - frmDeleteBorrowing.Width) / 2, (this.ClientSize.Height - 50 - frmDeleteBorrowing.Height) / 2);
            frmDeleteBorrowing.Show();
            frmDeleteBorrowing.Activate();

        }

        private void returnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmReturnBorrowing.IsDisposed)
            {
                frmReturnBorrowing = new ReturnBorrowing();
                frmReturnBorrowing.MdiParent = this;
            }
            frmReturnBorrowing.StartPosition = FormStartPosition.Manual;
            frmReturnBorrowing.Location = new Point((this.ClientSize.Width - frmReturnBorrowing.Width) / 2, (this.ClientSize.Height - 50 - frmReturnBorrowing.Height) / 2);
            frmReturnBorrowing.Show();
            frmReturnBorrowing.Activate();
        }
    }
}
