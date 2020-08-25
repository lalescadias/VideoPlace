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
    public partial class ListMovies : Form
    {
        DBConnect connectDataBase = new DBConnect();
        public ListMovies()
        {
            InitializeComponent();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ListMovies_Load(object sender, EventArgs e)
        {
            data_grid_user.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            data_grid_user.AllowUserToResizeRows = false;
            data_grid_user.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            data_grid_user.AllowUserToAddRows = false;
            data_grid_user.AllowUserToDeleteRows = false;
            data_grid_user.EditMode = DataGridViewEditMode.EditProgrammatically;
            data_grid_user.ColumnCount = 6;
            data_grid_user.Columns[0].HeaderCell.Value = "Id";
            data_grid_user.Columns[1].HeaderCell.Value = "Title";
            data_grid_user.Columns[2].HeaderCell.Value = "Genre";
            data_grid_user.Columns[3].HeaderCell.Value = "Amount";
            data_grid_user.Columns[4].HeaderCell.Value = "Release Year";
            data_grid_user.Columns[5].HeaderCell.Value = "Description";

            List<string>[] list;
            list = connectDataBase.MovieList();

            data_grid_user.Rows.Clear();
            for (int i = 0; i < list[0].Count; i++)
            {
                int number = data_grid_user.Rows.Add();
                data_grid_user.Rows[number].Cells[0].Value = list[0][i];
                data_grid_user.Rows[number].Cells[1].Value = list[1][i];
                data_grid_user.Rows[number].Cells[2].Value = list[2][i];
                data_grid_user.Rows[number].Cells[3].Value = list[3][i];
                data_grid_user.Rows[number].Cells[4].Value = list[4][i];
                data_grid_user.Rows[number].Cells[5].Value = list[5][i];                
            }
            label1.Text = list[0].Count.ToString();
        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            Util.printDataGridView(data_grid_user);
        }
    }
}
