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
    public partial class KabinetForma : Form
    {
        public KabinetForma()
        {
            InitializeComponent();
            Fill();
        }
        private void Fill()
        {
            dataGridViewKabinet.DataSource = DBobjects.Entities.Kabinet.ToList();
            dataGridViewKabinet.Columns[0].Visible = false;
            dataGridViewKabinet.Columns[1].HeaderText = "Кабинет";
            dataGridViewKabinet.Columns[2].Visible = false ;
            dataGridViewKabinet.Columns[3].Visible = false;

        }
        

        private void dataGridViewKabinet_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Kabinet p = (Kabinet)dataGridViewKabinet.Rows[e.RowIndex].DataBoundItem;
            NewKabinetForma f = new NewKabinetForma(p);
            f.ShowDialog();
            Fill();
        }

        private void DobavKabinet_Click(object sender, EventArgs e)
        {
            Kabinet p = new Kabinet();
            NewKabinetForma f = new NewKabinetForma(p);
            f.ShowDialog();
            Fill();
        }
    }
}
 