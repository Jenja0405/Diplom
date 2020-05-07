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
    public partial class KlassForma : Form
    {
        public KlassForma()
        {
            InitializeComponent();
            Fill();
        }
        private void Fill()
        {
            dataGridViewKlass.DataSource = DBobjects.Entities.Klass.ToList();
            dataGridViewKlass.Columns[0].Visible = false;
            dataGridViewKlass.Columns[1].HeaderText = "Класс";
            dataGridViewKlass.Columns[2].Visible = false;

        }

        private void dataGridViewKlass_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Klass p = (Klass)dataGridViewKlass.Rows[e.RowIndex].DataBoundItem;
            NewKlassForma f = new NewKlassForma(p);
            f.ShowDialog();
            Fill();
        }

        private void DobavKlass_Click(object sender, EventArgs e)
        {    
            Klass p = new Klass();
            NewKlassForma f = new NewKlassForma(p);
            f.ShowDialog();
            Fill();
        }
    }
}
