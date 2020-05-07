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
    public partial class Glavnajaforma : Form
    {
        public Glavnajaforma()
        {
            InitializeComponent();
            Fill();
        }
        private void Fill()
        {
            Raspisaniedata.DataSource = DBobjects.Entities.Urok.ToList();
            Raspisaniedata.Columns[0].Visible = false;
            Raspisaniedata.Columns[3].Visible = false;
            Raspisaniedata.Columns[4].Visible = false;
            Raspisaniedata.Columns[5].Visible = false;
            Raspisaniedata.Columns[6].Visible = false;
            Raspisaniedata.Columns[1].HeaderText = "День недели";
            Raspisaniedata.Columns[2].HeaderText = "Номер урока";
            Raspisaniedata.Columns[7].HeaderText = "Кабинет";
            Raspisaniedata.Columns[8].HeaderText = "Класс";
            Raspisaniedata.Columns[9].HeaderText = "Предмет";
            Raspisaniedata.Columns[10].HeaderText = "Учитель";
        }

        private void учителяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UschitelaForma uchitel = new UschitelaForma();
            uchitel.ShowDialog();
        }

        private void классыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KlassForma klass = new KlassForma();
            klass.ShowDialog();
        }

        private void кабинетыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KabinetForma kabinet = new KabinetForma();
            kabinet.ShowDialog();
        }

        private void предметыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PredmetForma predmet = new PredmetForma();
            predmet.ShowDialog();
        }

        private void составлениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SostavlenieRaspisanijaForma sostavlenie = new SostavlenieRaspisanijaForma();
            sostavlenie.ShowDialog();
        }
    }
    }

