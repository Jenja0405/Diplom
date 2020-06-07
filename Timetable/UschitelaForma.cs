using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timetable
{
    public partial class UschitelaForma : Form
    {
        public UschitelaForma()
        {
            InitializeComponent();
            Fill();
        }
        private void Fill()
        {
            dataGridViewucshitel.DataSource = DBobjects.Entities.Uchitel.ToList();
            dataGridViewucshitel.Columns[0].Visible = false;
            dataGridViewucshitel.Columns[1].HeaderText = "Фамилия";
            dataGridViewucshitel.Columns[2].HeaderText = "Имя";
            dataGridViewucshitel.Columns[3].HeaderText = "Отчество";
            dataGridViewucshitel.Columns[4].Visible = false;
            dataGridViewucshitel.Columns[5].Visible = false;
        }


        private void Dobavuschitel_Click(object sender, EventArgs e)
        {
            Uchitel p = new Uchitel();
            NewUschitelForma d = new NewUschitelForma(p);
            d.ShowDialog();
            Fill();
        }

        private void dataGridViewucshitel_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Uchitel p = (Uchitel)dataGridViewucshitel.Rows[e.RowIndex].DataBoundItem;
            NewUschitelForma d = new NewUschitelForma(p);
            d.ShowDialog();
            Fill();
        }

        private void buttonUschitelClear_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите удалить список классов предметы у которых ведут учителя?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                DBobjects.Entities.UchitelClear();
                MessageBox.Show("Список успешно очищен");
            }
        }
    }
}
