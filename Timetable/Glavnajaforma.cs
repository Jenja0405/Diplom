using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;

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
            List<int> Weekday = new List<int>() {1,2,3,4,5};
            List<int> NomerUroka = new List<int>() { 1, 2, 3, 4, 5, 6};
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
                                        if (DBobjects.Entities.UchitelKlassPredmet.Where(q => q.Uchitel.ID_Uchitel == uc.ID_Uchitel && q.KlassPredmet.ID_Klass == k.ID_Klass && q.KlassPredmet.ID_Predmet == pr.ID_Predmet).Count() > 0)
                                        {
                                            foreach (int w in Weekday)
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
            List<Urok> uroks = DBobjects.Entities.Urok.ToList();
            uroks = uroks.OrderBy(q => q.Weekday).ToList();
            System.Data.DataTable urok = new System.Data.DataTable();
            DataColumn WeekDay = new DataColumn("День недели", Type.GetType("System.String"));
            DataColumn Number = new DataColumn("Номер урока", Type.GetType("System.String"));
            DataColumn Kabinets = new DataColumn("Кабинет", Type.GetType("System.String"));
            DataColumn Klass = new DataColumn("Класс", Type.GetType("System.String"));
            DataColumn Predmet = new DataColumn("Предмет", Type.GetType("System.String"));
            DataColumn Uchit = new DataColumn("Учитель", Type.GetType("System.String"));
            DataColumn idUrok = new DataColumn("idUrok", Type.GetType("System.Int32"));
            urok.Columns.Add(WeekDay);
            urok.Columns.Add(Number);
            urok.Columns.Add(Kabinets);
            urok.Columns.Add(Klass);
            urok.Columns.Add(Predmet);
            urok.Columns.Add(Uchit);
            urok.Columns.Add(idUrok);
            foreach  (Urok uroki in uroks)      
            {
                urok.Rows.Add(zamena(uroki.Weekday), uroki.Nomer_uroka, uroki.Kabinet, uroki.Klass, uroki.Predmet, uroki.Uchitel,uroki.ID_Urok);      
            }
            Raspisaniedata.DataSource = urok;
            Raspisaniedata.Columns[6].Visible = false;
        }
        private string zamena(int Weekday)
        {
            string day = "";
                switch(Weekday)
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
        { int id = Convert.ToInt32(Raspisaniedata.Rows[e.RowIndex].Cells[6].Value);
            Urok p = DBobjects.Entities.Urok.FirstOrDefault(u => u.ID_Urok == id);
            redaktirovatGlavnajaforma redakt = new redaktirovatGlavnajaforma(p);
            redakt.ShowDialog();
            Fill1();
        }

        private void экспортироватьВExceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Экспортировать данные в Excel?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                this.Cursor = Cursors.WaitCursor;
                Microsoft.Office.Interop.Excel.Application ExcelApp = new 
                Microsoft.Office.Interop.Excel.Application();
                ExcelApp.Application.Workbooks.Add(Type.Missing);
                ExcelApp.Columns.ColumnWidth = 15;
                ExcelApp.Cells[1, 1] = "День недели";
                ExcelApp.Cells[1, 2] = "Номер урока";
                ExcelApp.Cells[1, 3] = "Кабинет";
                ExcelApp.Cells[1, 4] = "Класс";
                ExcelApp.Cells[1, 5] = "Предмет";
                ExcelApp.Cells[1, 6] = "Учитель";

                for (int i = 0; i < Raspisaniedata.ColumnCount; i++)
                {
                    for (int j = 0; j < Raspisaniedata.RowCount; j++)
                    {
                        ExcelApp.Cells[j + 2, i + 1] = (Raspisaniedata[i, j].Value).ToString();
                    }
                }
                ExcelApp.Visible = true;
            }
            this.Cursor = Cursors.Default;
        }

    }
}
