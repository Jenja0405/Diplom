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
        private void GenerateSchedule()
        {
            DBobjects.Entities.Clear();
            int maxIdKabinet = DBobjects.Entities.Kabinet.OrderByDescending(p => p.ID_Kabinet).FirstOrDefault().ID_Kabinet + 1;
            int maxIdKlass = DBobjects.Entities.Klass.OrderByDescending(p => p.ID_Klass).FirstOrDefault().ID_Klass + 1;
            int maxIdUchitel = DBobjects.Entities.Uchitel.OrderByDescending(p => p.ID_Uchitel).FirstOrDefault().ID_Uchitel + 1;
            int[,,] ZanKabinet =new int [maxIdKabinet, 6,7];
            int[,,] ZanKlass = new int[maxIdKlass, 6, 7];
            int[,,] ZanUchitel = new int[maxIdUchitel, 6, 7];
            int[,] FreeKabs = new int[30, 2];
            Klass [] klasses = DBobjects.Entities.Klass.ToArray();
            Random RANDMASS = new Random();
           for (int i= klasses.Length - 1; i >= 1; i--)
           {
                int j = RANDMASS.Next(i + 1);
               Klass tmpM = klasses[j];
               klasses[j] = klasses[i];
                klasses[i] = tmpM;
            }
            int Lk = klasses.Count();
            int ik = 0;
            List<Predmet> predmets = new List<Predmet>();
            while ((ik < Lk) )
            {
              
                var tmp = klasses[ik];
                List<KlassPredmet> klassPr = DBobjects.Entities.KlassPredmet.Where(p => p.ID_Klass == tmp.ID_Klass).ToList();
                foreach (KlassPredmet klPr in klassPr)
                {
                    predmets.Add(klPr.Predmet);
                }
                predmets = predmets.Distinct().ToList();//список предметов для класса
                int Lp = predmets.Count();
                    for (int ip = 0; ip < Lp ; ip++)
                    {
                        var tmpP = predmets[ip];
                        if (DBobjects.Entities.UchitelKlassPredmet.Where(p => p.KlassPredmet.ID_Predmet == tmpP.ID_Predmet && p.KlassPredmet.Klass.ID_Klass == tmp.ID_Klass).Count() > 0)
                        {
                            UchitelKlassPredmet klascPrUch = DBobjects.Entities.UchitelKlassPredmet.FirstOrDefault(p => p.KlassPredmet.ID_Predmet == tmpP.ID_Predmet && p.KlassPredmet.Klass.ID_Klass == tmp.ID_Klass);
                            int uc = klascPrUch.ID_Uchitel;
                            int N = klascPrUch.KlassPredmet.UrokovVNedelyu;
                            List<Kabinet> kabinets = new List<Kabinet>();
                            for (int i = 1; i <= N; i++)
                            {
                                List<KabinetPredmet> kabPredm = DBobjects.Entities.KabinetPredmet.Where(p => p.ID_Predmet == tmpP.ID_Predmet).ToList();
                                foreach (KabinetPredmet kabPr in kabPredm)
                                {
                                    kabinets.Add(kabPr.Kabinet);
                                }
                                int Lkab = kabinets.Count();
                            for (int ikab = 0; ikab < Lkab;)
                            {
                                var tmpKab = kabinets[ikab];
                                int fk = -1;
                                for (int iwd = 1; iwd <= 5; iwd++)
                                {
                                    for (int iur = 1; iur <= 6; iur++)
                                    {
                                        if (ZanKabinet[tmpKab.ID_Kabinet, iwd, iur] == 0 && ZanKlass[tmp.ID_Klass, iwd, iur] == 0 && ZanUchitel[uc, iwd, iur] == 0)
                                        {
                                            fk = fk + 1;
                                            FreeKabs[fk, 0] = iwd;
                                            FreeKabs[fk, 1] = iur;
                                        }
                                    }
                                }
                                if (fk >= 0)
                                {
                                    Random rand = new Random();
                                    var rndwu = rand.Next(fk);
                                    var wd = FreeKabs[rndwu, 0];
                                    var ur = FreeKabs[rndwu, 1];

                                    ZanKabinet[tmpKab.ID_Kabinet, wd, ur] = 1;
                                    ZanKlass[tmp.ID_Klass, wd, ur] = 1;
                                    ZanUchitel[uc, wd, ur] = 1;
                                    Urok urok = new Urok();
                                    urok.ID_Kabinet = tmpKab.ID_Kabinet;
                                    urok.ID_Klass = tmp.ID_Klass;
                                    urok.ID_Predmet = tmpP.ID_Predmet;
                                    urok.ID_Uchitel = uc;
                                    urok.Weekday = wd;
                                    urok.Nomer_uroka = ur;
                                    DBobjects.Entities.Urok.Add(urok);
                                    DBobjects.Entities.SaveChanges();
                                }
                                break;
                            }                            
                        }
                        
                    }
                }
                ik++;
            }                   
        } 
        private void Fill1()
        {
            List<Urok> uroks = DBobjects.Entities.Urok.ToList();
            uroks = uroks.OrderBy(q => q.Weekday).ToList();
            System.Data.DataTable urok = new System.Data.DataTable();
            DataColumn idUrok = new DataColumn("idUrok", Type.GetType("System.Int32"));
            DataColumn WeekDay = new DataColumn("День недели", Type.GetType("System.String"));
            DataColumn Number = new DataColumn("Номер урока", Type.GetType("System.String"));
            DataColumn Kabinets = new DataColumn("Кабинет", Type.GetType("System.String"));
            DataColumn Klass = new DataColumn("Класс", Type.GetType("System.String"));
            DataColumn Predmet = new DataColumn("Предмет", Type.GetType("System.String"));
            DataColumn Uchit = new DataColumn("Учитель", Type.GetType("System.String"));
            urok.Columns.Add(idUrok);
            urok.Columns.Add(WeekDay);
            urok.Columns.Add(Number);
            urok.Columns.Add(Kabinets);
            urok.Columns.Add(Klass);
            urok.Columns.Add(Predmet);
            urok.Columns.Add(Uchit);
            foreach  (Urok uroki in uroks)      
            {
                urok.Rows.Add(uroki.ID_Urok, zamena(uroki.Weekday), uroki.Nomer_uroka, uroki.Kabinet, uroki.Klass, uroki.Predmet, uroki.Uchitel);      
            }
            Raspisaniedata.DataSource = urok;
            Raspisaniedata.Columns[0].Visible = false;
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
                GenerateSchedule();
                Fill1();
                this.Cursor = Cursors.Default;
            }
        }
        private void Raspisaniedata_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(Raspisaniedata.Rows[e.RowIndex].Cells[0].Value);
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

                for (int i = 1; i < Raspisaniedata.ColumnCount; i++)
                {
                    for (int j = 0; j < Raspisaniedata.RowCount; j++)
                    {
                        ExcelApp.Cells[j + 2, i + 0] = (Raspisaniedata[i, j].Value).ToString();
                    }
                }
                ExcelApp.Visible = true;
            }
            this.Cursor = Cursors.Default;
        }
    }
}
