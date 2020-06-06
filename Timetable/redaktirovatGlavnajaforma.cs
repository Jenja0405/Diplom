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
            comboBoxWeekday.SelectedItem = zamena(UROK.Weekday);
            comboBoxPredmet.DataSource = DBobjects.Entities.Predmet.ToList();
            comboBoxPredmet.SelectedItem = UROK.Predmet;
            comboBoxKlass.DataSource = DBobjects.Entities.Klass.ToList();
            comboBoxKlass.SelectedItem = UROK.Klass;
            comboBoxUschitel.DataSource = DBobjects.Entities.Uchitel.ToList();
            comboBoxUschitel.SelectedItem = UROK.Uchitel;
        }
        private string zamena(int Weekday)
        {
            string day = "";
            switch (Weekday)
            {
                case 1:
                    day = "Понедельник";
                    break;
                case 2:
                    day = "Вторник";
                    break;
                case 3:
                    day = "Среда";
                    break;
                case 4:
                    day = "Четверг";
                    break;
                case 5:
                    day = "Пятница";
                    break;
            }
            return day;
        }
        private int zamena2(string Weekday)
        {
            int day = 0;
            switch (Weekday)
            {
                case "Понедельник":
                    day = 1;
                    break;
                case "Вторник":
                    day = 2;
                    break;
                case "Среда":
                    day = 3;
                    break;
                case "Четверг":
                    day = 4;
                    break;
                case "Пятница":
                    day = 5;
                    break;
            }
            return day;
        }
        private void comboBoxWeekday_SelectedIndexChanged(object sender, EventArgs e)
        {
            UROK.Weekday = zamena2(comboBoxWeekday.Text);
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
            UROK.ID_Klass = DBobjects.Entities.Klass.FirstOrDefault(r => r.Nazvanie_K == comboBoxKlass.Text).ID_Klass;
        }

        private void comboBoxPredmet_SelectedIndexChanged(object sender, EventArgs e)
        {
            UROK.ID_Predmet = DBobjects.Entities.Predmet.FirstOrDefault(w => w.Nazvanie_P == comboBoxPredmet.Text).ID_Predmet;
        }

        private void comboBoxUschitel_SelectedIndexChanged(object sender, EventArgs e)
        {
            UROK.ID_Uchitel = DBobjects.Entities.Uchitel.FirstOrDefault(t => t.Familia + " " + t.Imya + " " + t.Otchestvo == comboBoxUschitel.Text).ID_Uchitel;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (DBobjects.Entities.KlassPredmet.Where(q => q.ID_Klass == UROK.ID_Klass && q.ID_Predmet == UROK.ID_Predmet).Count() > 0)
            {
                if (DBobjects.Entities.KabinetPredmet.Where(a => a.ID_Kabinet == UROK.ID_Kabinet && a.ID_Predmet == UROK.ID_Predmet).Count() > 0)
                {
                    if (DBobjects.Entities.UchitelKlassPredmet.Where(z => z.KlassPredmet.ID_Predmet == UROK.ID_Predmet && z.ID_Uchitel == UROK.ID_Uchitel).Count() > 0)
                    {
                        if (DBobjects.Entities.UchitelKlassPredmet.Where(q => q.Uchitel.ID_Uchitel == UROK.ID_Uchitel && q.KlassPredmet.ID_Klass == UROK.ID_Klass && q.KlassPredmet.ID_Predmet == UROK.ID_Predmet).Count() > 0)
                        {
                            if (DBobjects.Entities.Urok.Where(l => l.ID_Klass == UROK.ID_Klass && l.ID_Predmet == UROK.ID_Predmet).Count() < DBobjects.Entities.KlassPredmet.FirstOrDefault(f => f.ID_Predmet == UROK.ID_Predmet && f.ID_Klass == UROK.ID_Klass).UrokovVNedelyu)
                            {
                                if (DBobjects.Entities.Urok.Where(v => v.Weekday == UROK.Weekday && v.ID_Klass == UROK.ID_Klass && v.ID_Predmet == UROK.ID_Predmet).Count() < 1)
                                {
                                    if (DBobjects.Entities.Urok.Where(h => h.Nomer_uroka == UROK.Nomer_uroka && h.Weekday == UROK.Weekday).Count() == 0)
                                    {
                                        
                                        DBobjects.Entities.SaveChanges();
                                        MessageBox.Show("Сохранено");
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
