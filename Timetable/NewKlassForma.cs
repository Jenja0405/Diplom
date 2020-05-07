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
    public partial class NewKlassForma : Form
    {
        private Klass KLASS { get; }
        public NewKlassForma(Klass klass)
        {
            InitializeComponent();
            KLASS = klass;
            Fill();
            
        }
        private void Fill()
        {
            textBoxklass.Text = KLASS.Nazvanie_K;
        }
        private void Save()
        {
            if (DBobjects.Entities.Klass.Where(p => p.ID_Klass == KLASS.ID_Klass).Count() == 0)
            {
                DBobjects.Entities.Klass.Add(KLASS);
            }
            DBobjects.Entities.SaveChanges();
            MessageBox.Show("Сохранено");

        }
       

        private void Saveklass_Click(object sender, EventArgs e)
        {
                Save();
                Fill();
                Close();
            }

        private void Removklass_Click(object sender, EventArgs e)
        {
            if (DBobjects.Entities.Klass.Where(p => p.ID_Klass == KLASS.ID_Klass).Count() > 0)
            {
                DBobjects.Entities.Klass.Remove(KLASS);
                DBobjects.Entities.SaveChanges();
            }
            MessageBox.Show("Удалено");
            Close();
        }

        private void textBoxklass_TextChanged(object sender, EventArgs e)
        {
            KLASS.Nazvanie_K = textBoxklass.Text;
        }
    }
}
