using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oyun2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        public int count = 0;
        public int oyunAlani = 0;

        private void btnOyna_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            count = 0;

            if (rdBes.Checked)
            {
                oyunAlani = 5;
            }
            else if (rdAlti.Checked)
            {
                oyunAlani = 6;
            }
            else if (rdYedi.Checked)
            {
                oyunAlani = 7;
            }
            else if (rdSekiz.Checked)
            {
                oyunAlani = 8;
            }
            else if (rdDokuz.Checked)
            {
                oyunAlani = 9;
            }
            else
            { 
                MessageBox.Show("Oyun Alanını Seçmedin!");
            }

            gridAlan.Enabled = true;
            gridAlan.Rows.Clear();
            gridAlan.Columns.Clear();

            gridAlan.Size = new Size(oyunAlani * 60, oyunAlani * 60);

            for (int i = 0; i < oyunAlani; i++)
            {
                gridAlan.Columns.Add(null, null);
                DataGridViewColumn Column = gridAlan.Columns[i];
                Column.Width = 40;

                gridAlan.Rows.Add(null, null);
                DataGridViewRow Row = gridAlan.Rows[i];
                Row.Height = 40;
            }
        }

        private void grdOyun_Click(object sender, EventArgs e)
        {
            int SelectedRow = gridAlan.CurrentCell.RowIndex;
            int SelectedColumn = gridAlan.CurrentCell.ColumnIndex;

            if (gridAlan.Rows[SelectedRow].Cells[SelectedColumn].Style.BackColor == Color.Yellow || count == 0)
            {
                for (int a = 0; a < oyunAlani; a++)
                {
                    for (int b = 0; b < oyunAlani; b++)
                    {
                        if (gridAlan.Rows[a].Cells[b].Style.BackColor != Color.Red)
                            gridAlan.Rows[a].Cells[b].Style.BackColor = Color.White;
                    }

                }

                count++;
                gridAlan.Rows[gridAlan.CurrentCell.RowIndex].Cells[gridAlan.CurrentCell.ColumnIndex].Value = count;
                gridAlan.Rows[gridAlan.CurrentCell.RowIndex].Cells[gridAlan.CurrentCell.ColumnIndex].Style.BackColor = Color.Red;

                if (SelectedRow + 2 < oyunAlani && SelectedColumn + 1 < oyunAlani && gridAlan.Rows[SelectedRow + 2].Cells[SelectedColumn + 1].Style.BackColor != Color.Red)
                    gridAlan.Rows[SelectedRow + 2].Cells[SelectedColumn + 1].Style.BackColor = Color.Yellow;
                if (SelectedRow + 2 < oyunAlani && 0 <= SelectedColumn - 1 && gridAlan.Rows[SelectedRow + 2].Cells[SelectedColumn - 1].Style.BackColor != Color.Red)
                    gridAlan.Rows[SelectedRow + 2].Cells[SelectedColumn - 1].Style.BackColor = Color.Yellow;
                if (SelectedRow - 2 >= 0 && SelectedColumn + 1 < oyunAlani && gridAlan.Rows[SelectedRow - 2].Cells[SelectedColumn + 1].Style.BackColor != Color.Red)
                    gridAlan.Rows[SelectedRow - 2].Cells[SelectedColumn + 1].Style.BackColor = Color.Yellow;
                if (SelectedRow - 2 >= 0 && SelectedColumn - 1 >= 0 && gridAlan.Rows[SelectedRow - 2].Cells[SelectedColumn - 1].Style.BackColor != Color.Red)
                    gridAlan.Rows[SelectedRow - 2].Cells[SelectedColumn - 1].Style.BackColor = Color.Yellow;
                if (SelectedRow + 1 < oyunAlani && SelectedColumn + 2 < oyunAlani && gridAlan.Rows[SelectedRow + 1].Cells[SelectedColumn + 2].Style.BackColor != Color.Red)
                    gridAlan.Rows[SelectedRow + 1].Cells[SelectedColumn + 2].Style.BackColor = Color.Yellow;
                if (SelectedRow + 1 < oyunAlani && SelectedColumn - 2 >= 0 && gridAlan.Rows[SelectedRow + 1].Cells[SelectedColumn - 2].Style.BackColor != Color.Red)
                    gridAlan.Rows[SelectedRow + 1].Cells[SelectedColumn - 2].Style.BackColor = Color.Yellow;
                if (SelectedRow - 1 >= 0 && SelectedColumn + 2 < oyunAlani && gridAlan.Rows[SelectedRow - 1].Cells[SelectedColumn + 2].Style.BackColor != Color.Red)
                    gridAlan.Rows[SelectedRow - 1].Cells[SelectedColumn + 2].Style.BackColor = Color.Yellow;
                if (SelectedRow - 1 >= 0 && SelectedColumn - 2 >= 0 && gridAlan.Rows[SelectedRow - 1].Cells[SelectedColumn - 2].Style.BackColor != Color.Red)
                    gridAlan.Rows[SelectedRow - 1].Cells[SelectedColumn - 2].Style.BackColor = Color.Yellow;
            }
            if (gridAlan.Rows[SelectedRow].Cells[SelectedColumn].Style.BackColor == Color.Yellow)
            {
                gridAlan.Rows[SelectedRow].Cells[SelectedColumn].Value = count;
                gridAlan.Rows[SelectedRow].Cells[SelectedColumn].Style.BackColor = Color.Red;
            }

            lblPuan.Text =count.ToString();
            if (count == oyunAlani * oyunAlani)
            {
                pictureBox2.Visible = true;
                MessageBox.Show("KAZANDIN");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
        }
    }
}