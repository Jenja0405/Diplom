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
    public partial class redaktirovatGlavnajaforma : Form
    {
        private Urok UROK { get; }
        public redaktirovatGlavnajaforma(Urok urok) 
        {
            InitializeComponent();
            UROK = urok;
            comboBoxKabinet.DataSource = DBobjects.Entities.Kabinet.ToList();
            comboBoxKabinet.SelectedItem = UROK.Kabinet;
            comboBoxNomer.SelectedItem = UROK.Nomer_uroka.ToString();
            comboBoxWeekday.SelectedItem = UROK.Weekday.ToString();
            comboBoxPredmet.DataSource = DBobjects.Entities.Predmet.ToList();
            comboBoxPredmet.SelectedItem = UROK.Predmet;
            comboBoxKlass.DataSource = DBobjects.Entities.Klass.ToList();
            comboBoxKlass.SelectedItem = UROK.Klass;
            comboBoxUschitel.DataSource = DBobjects.Entities.Uchitel.ToList();
            comboBoxUschitel.SelectedItem = UROK.Uchitel;
        }
        
        private void comboBoxWeekday_SelectedIndexChanged(object sender, EventArgs e)
        {
            UROK.Weekday = comboBoxWeekday.Text;
        }

        private void comboBoxNomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            UROK.Nomer_uroka = Convert.ToInt32(comboBoxNomer.Text);
        }

        private void comboBoxKabinet_SelectedIndexChanged(object sender, EventArgs e)
        {
            UROK.ID_Kabinet = DBobjects.Entities.Kabinet.FirstOrDefault(q => q.Nazvanie_K == comboBoxKabinet.Text).ID_Kabinet;
        }

        private void comboBoxKlass_SelectedIndexChanged(object sender, EventArgs e)
        {
            UROK.ID_Klass = DBobjects.Entities.Klass.FirstOrDefault(r => r.Nazvanie_K ==comboBoxKlass.Text).ID_Klass;
        }

        private void comboBoxPredmet_SelectedIndexChanged(object sender, EventArgs e)
        {
            UROK.ID_Predmet = DBobjects.Entities.Predmet.FirstOrDefault(w=> w.Nazvanie_P == comboBoxPredmet.Text).ID_Predmet;
        }

        private void comboBoxUschitel_SelectedIndexChanged(object sender, EventArgs e)
        {
            UROK.ID_Uchitel = DBobjects.Entities.Uchitel.FirstOrDefault(t => t.Familia+" "+t.Imya+" "+t.Otchestvo == comboBoxUschitel.Text).ID_Uchitel;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {   
            DBobjects.Entities.SaveChanges();
            MessageBox.Show("Сохранено");
        }
    }

}
