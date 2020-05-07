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
    public partial class NewKabinetForma : Form
    {
        private Kabinet KABINET { get; }
       
        public NewKabinetForma(Kabinet kabinet)
        {
            InitializeComponent();
            KABINET = kabinet;
            Fill();
        }
        private void Fill()
        {
            textBoxKabinet.Text = KABINET.Nazvanie_K;
        }
        private void Save()
        {
            if (DBobjects.Entities.Kabinet.Where(p => p.ID_K == KABINET.ID_K).Count() == 0)
            {
                DBobjects.Entities.Kabinet.Add(KABINET);
            }
            DBobjects.Entities.SaveChanges();
            MessageBox.Show("Сохранено");

        }
        private void Remove()
        {
            if (DBobjects.Entities.Kabinet.Where(p => p.ID_K == KABINET.ID_K).Count() > 0)
            {
                DBobjects.Entities.Kabinet.Remove(KABINET);
                DBobjects.Entities.SaveChanges();
            }
            MessageBox.Show("Удалено");
        }
        private void textBoxKabinet_TextChanged(object sender, EventArgs e)
        {
            KABINET.Nazvanie_K = textBoxKabinet.Text;
        }

        private void SaveKabinet_Click(object sender, EventArgs e)
        {
            Save();
            Fill();
            Close();
        }

        private void RemovKabinet_Click(object sender, EventArgs e)
        {
            Remove();
            Close();
        }
    }
}
