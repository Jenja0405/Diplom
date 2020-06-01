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
            Fill1();
        }

        private void Fill()
        {
            List<Klass> Klass = DBobjects.Entities.Klass.ToList();
            List<Predmet> Predmet = DBobjects.Entities.Predmet.ToList();
            List<Uchitel> Uchitel = DBobjects.Entities.Uchitel.ToList();
            List<Kabinet> Kabinet = DBobjects.Entities.Kabinet.ToList();
            List<string> Weekday = new List<string>() { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница" };
            List<int> NomerUroka = new List<int>() { 1, 2, 3, 4, 5, 6 };
            List<Urok> Urok = DBobjects.Entities.Urok.ToList();

            foreach (Klass k in Klass)
            {
                foreach (Predmet pr in Predmet)
                {
                    if (DBobjects.Entities.KlassPredmet.Where(q => q.ID_Klass == k.ID_Klass && q.ID_Predmet == pr.ID_Predmet).Count() > 0)
                    {
                        foreach (Kabinet kab in Kabinet)
                        {
                            if (DBobjects.Entities.KabinetPredmet.Where(a => a.ID_Kabinet == kab.ID_Kabinet && a.ID_Predmet == pr.ID_Predmet).Count() > 0)
                            {
                                foreach (Uchitel uc in Uchitel)
                                {
                                    if (DBobjects.Entities.UchitelKlassPredmet.Where(z => z.KlassPredmet.ID_Predmet == pr.ID_Predmet && z.ID_Uchitel == uc.ID_Uchitel).Count() > 0)
                                    {
                                        if (DBobjects.Entities.UchitelKlassPredmet.Where(q => q.Uchitel.ID_Uchitel == uc.ID_Uchitel && q.KlassPredmet.ID_Klass == k.ID_Klass && q.KlassPredmet.ID_Predmet== pr.ID_Predmet).Count() > 0)
                                        {
                                            foreach (string w in Weekday)
                                            {
                                                if (Urok.Where(l => l.ID_Klass == k.ID_Klass && l.ID_Predmet == pr.ID_Predmet).Count() < pr.KlassPredmet.FirstOrDefault(f => f.ID_Predmet == pr.ID_Predmet && f.ID_Klass == k.ID_Klass).UrokovVNedelyu)
                                                {
                                                    foreach (int nomer in NomerUroka)
                                                    {
                                                        if (Urok.Where(v => v.Weekday == w && v.ID_Klass == k.ID_Klass && v.ID_Predmet == pr.ID_Predmet).Count() < 1)
                                                        {
                                                            Urok ur = new Urok();


                                                            if (Urok.Where(h => h.Nomer_uroka == nomer && h.Weekday == w).Count() == 0)
                                                            {
                                                                ur.ID_Uchitel = uc.ID_Uchitel;
                                                                ur.ID_Predmet = pr.ID_Predmet;
                                                                ur.ID_Kabinet = kab.ID_Kabinet;
                                                                ur.ID_Klass = k.ID_Klass;
                                                                ur.Weekday = w;
                                                                ur.Nomer_uroka = nomer;
                                                                Urok.Add(ur);
                                                                DBobjects.Entities.Urok.Add(ur);
                                                                DBobjects.Entities.SaveChanges();
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
                    }
                }



            }
        }
        private void Fill1()
        {
            Raspisaniedata.DataSource = DBobjects.Entities.Urok.ToList();
            Raspisaniedata.Columns[0].Visible = false;
            Raspisaniedata.Columns[1].Visible = false;
            Raspisaniedata.Columns[2].Visible = false;
            Raspisaniedata.Columns[3].Visible = false;
            Raspisaniedata.Columns[4].Visible = false;
            Raspisaniedata.Columns[5].HeaderText = "День недели";
            Raspisaniedata.Columns[6].HeaderText = "Номер урока";
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

        private void SgenerirovatMenu_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Сгенерировать новое расписание?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                this.Cursor = Cursors.WaitCursor;
                DBobjects.Entities.Clear();
                Fill();
                Fill1();
                this.Cursor = Cursors.Default;
            }
        }
        private void Raspisaniedata_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Urok p = (Urok)Raspisaniedata.Rows[e.RowIndex].DataBoundItem;
            redaktirovatGlavnajaforma redakt = new redaktirovatGlavnajaforma(p);
            redakt.ShowDialog();
        }
    }

    }

