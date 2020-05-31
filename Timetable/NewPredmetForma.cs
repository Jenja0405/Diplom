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
    public partial class NewPredmetForma : Form
    {
        private Predmet PREDMET { get; }
        public NewPredmetForma(Predmet predmet)
        {
            InitializeComponent();
            PREDMET = predmet;
            Fill();
        }
        private void Fill()
        {
            textBoxPredmet.Text = PREDMET.Nazvanie_P;
        }
        private void Save()
        {
            if (DBobjects.Entities.Predmet.Where(p => p.ID_Predmet == PREDMET.ID_Predmet).Count() == 0)
            {
                DBobjects.Entities.Predmet.Add(PREDMET);
            }
            DBobjects.Entities.SaveChanges();
            MessageBox.Show("Сохранено");

        }
        private void Remove()
        {
            if (DBobjects.Entities.Predmet.Where(p => p.ID_Predmet == PREDMET.ID_Predmet).Count() > 0)
            {
                DBobjects.Entities.Predmet.Remove(PREDMET);
                DBobjects.Entities.SaveChanges();
            }
            MessageBox.Show("Удалено");
        }
       

        private void SavePredmet_Click(object sender, EventArgs e)
        {
            Save();
            Fill();
            Close();
        }

        private void RemovPredmet_Click(object sender, EventArgs e)
        {
            Remove();
            Close();
        }

        private void textBoxPredmet_TextChanged(object sender, EventArgs e)
        {
            PREDMET.Nazvanie_P = textBoxPredmet.Text;
        }
    }

}
