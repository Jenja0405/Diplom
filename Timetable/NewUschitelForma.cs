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
    public partial class NewUschitelForma : Form
    {
        private Uchitel UCHITEL { get; }
        public NewUschitelForma(Uchitel uchitel)
        {
            InitializeComponent();
            UCHITEL = uchitel;
            Fill();

        }
        private void Fill()
        {
            textBoxfamilie.Text = UCHITEL.Familia;
            textBoximya.Text = UCHITEL.Imya;
            textBoxotchestvo.Text = UCHITEL.Otchestvo;
        }
        private void Save()
        {
            if (DBobjects.Entities.Uchitel.Where(p => p.ID_Uchitel == UCHITEL.ID_Uchitel).Count() == 0)
            {
                DBobjects.Entities.Uchitel.Add(UCHITEL);
            }
            DBobjects.Entities.SaveChanges();
            MessageBox.Show("Сохранено");
        }
        private void Remove()
        {
            if (DBobjects.Entities.Uchitel.Where(p => p.ID_Uchitel == UCHITEL.ID_Uchitel).Count() > 0)
            {
                DBobjects.Entities.Uchitel.Remove(UCHITEL);
                DBobjects.Entities.SaveChanges();
            }
            MessageBox.Show("Удалено");
        }
        private void Saveuschitel_Click(object sender, EventArgs e)
        {
                Save();
                Fill();
                Close();
        }

        private void Removeuschitel_Click(object sender, EventArgs e)
        {
            Remove();
            Close();
        }

        private void textBoxfamilie_TextChanged_1(object sender, EventArgs e)
        {
            UCHITEL.Familia = textBoxfamilie.Text;
        }

        private void textBoximya_TextChanged_1(object sender, EventArgs e)
        {
            UCHITEL.Imya = textBoximya.Text;
        }

        private void textBoxotchestvo_TextChanged_1(object sender, EventArgs e)
        {
            UCHITEL.Otchestvo = textBoxotchestvo.Text;
        }
    }
}
    
