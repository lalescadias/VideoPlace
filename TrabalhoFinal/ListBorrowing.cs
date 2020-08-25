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
    public partial class ListBorrowing : Form
    {
        DBConnect connectDataBase = new DBConnect();
        public ListBorrowing()
        {
            InitializeComponent();
        }

        private void ListBorrowing_Load(object sender, EventArgs e)
        {
            data_grid_borrowing.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            data_grid_borrowing.AllowUserToResizeRows = false;
            data_grid_borrowing.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            data_grid_borrowing.AllowUserToAddRows = false;
            data_grid_borrowing.AllowUserToDeleteRows = false;
            data_grid_borrowing.EditMode = DataGridViewEditMode.EditProgrammatically;
            data_grid_borrowing.ColumnCount = 7;
            data_grid_borrowing.Columns[0].HeaderCell.Value = "Id";
            data_grid_borrowing.Columns[1].HeaderCell.Value = "Name";
            data_grid_borrowing.Columns[2].HeaderCell.Value = "Contact";
            data_grid_borrowing.Columns[3].HeaderCell.Value = "Title";
            data_grid_borrowing.Columns[4].HeaderCell.Value = "Genre";
            data_grid_borrowing.Columns[5].HeaderCell.Value = "Initial date";
            data_grid_borrowing.Columns[6].HeaderCell.Value = "Final date";

            List<string>[] list;
            list = connectDataBase.BorrowingList();

            data_grid_borrowing.Rows.Clear();
            for (int i = 0; i < list[0].Count; i++)
            {
                int number = data_grid_borrowing.Rows.Add();
                data_grid_borrowing.Rows[number].Cells[0].Value = list[0][i];
                data_grid_borrowing.Rows[number].Cells[1].Value = list[1][i];
                data_grid_borrowing.Rows[number].Cells[2].Value = list[2][i];
                data_grid_borrowing.Rows[number].Cells[3].Value = list[3][i];
                data_grid_borrowing.Rows[number].Cells[4].Value = list[4][i];
                data_grid_borrowing.Rows[number].Cells[5].Value = list[5][i];
                data_grid_borrowing.Rows[number].Cells[6].Value = list[6][i];
            }
            label1.Text = list[0].Count.ToString();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            Util.printDataGridView(data_grid_borrowing);
        }
    }
    }

