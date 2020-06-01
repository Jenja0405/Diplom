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
    public partial class PredmetForma : Form
    {
        public PredmetForma()
        {
            InitializeComponent();
            Fill();
        }
        private void Fill()
        {
            dataGridViewPredmet.DataSource = DBobjects.Entities.Predmet.ToList();
            dataGridViewPredmet.Columns[0].Visible = false;
            dataGridViewPredmet.Columns[1].HeaderText = "Предмет";
            dataGridViewPredmet.Columns[2].Visible = false;
            dataGridViewPredmet.Columns[3].Visible = false;
            dataGridViewPredmet.Columns[4].Visible = false;

        }
        private void dataGridViewPredmet_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Predmet p = (Predmet)dataGridViewPredmet.Rows[e.RowIndex].DataBoundItem;
            NewPredmetForma f = new NewPredmetForma(p);
            f.ShowDialog();
            Fill();
        }

        private void DobavPredmet_Click(object sender, EventArgs e)
        {
           Predmet p = new Predmet();
            NewPredmetForma f = new NewPredmetForma(p);
            f.ShowDialog();
            Fill();
        }
    }
}
