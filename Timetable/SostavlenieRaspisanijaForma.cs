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
    public partial class SostavlenieRaspisanijaForma : Form
    {
        private Urok UROK { get; }
        public SostavlenieRaspisanijaForma(Urok urok)
        {
            InitializeComponent();
            UROK = urok;
            Fill();
        }

        public void Fill()
        {
            comboBoxKlass.DataSource = DBobjects.Entities.Klass.Select(p => p.Nazvanie_K).ToList();
            comboBoxKlass.SelectedItem = UROK.Klass.Nazvanie_K;
            comboBoxKabinet.DataSource = DBobjects.Entities.Kabinet.Select(p => p.Nazvanie_K).ToList();
            comboBoxKabinet.SelectedItem = UROK.Kabinet.Nazvanie_K;
            comboBoxPredmet.DataSource = DBobjects.Entities.Predmet.Select(p => p.Nazvanie_P).ToList();
            comboBoxPredmet.SelectedItem = UROK.Predmet.Nazvanie_P;
            comboBoxUschitel.DataSource = DBobjects.Entities.Uchitel.Select(p => p.Familia).ToList();
            comboBoxUschitel.SelectedItem = UROK.Uchitel.Familia;
        }

        private void SaveBatton_Click(object sender, EventArgs e)
        {

        }
    }
}
