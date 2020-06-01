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
        private KlassPredmet klassPredmet;
        public NewKlassForma(Klass klass)
        {
            InitializeComponent();
            KLASS = klass;
            Fill();
            FillKlassPredmet();
            
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
        private void Remove()
        {
            if (DBobjects.Entities.Klass.Where(p => p.ID_Klass == KLASS.ID_Klass).Count() > 0)
            {
                DBobjects.Entities.Klass.Remove(KLASS);
                DBobjects.Entities.SaveChanges();
            }
            MessageBox.Show("Удалено");
        }
        private void textBoxklass_TextChanged(object sender, EventArgs e)
        {
            KLASS.Nazvanie_K = textBoxklass.Text;
        }

        private void Saveklass_Click(object sender, EventArgs e)
        {
          Save();
          Fill();
            savePredmet();
            Close();
         }

        private void Removklass_Click(object sender, EventArgs e)
        {
            Remove();
            Close();
        }
        private void FillKlassPredmet()
        {
            DataTable PredmetTable = new DataTable();
            DataColumn idPredmet = new DataColumn("idPredmet", Type.GetType("System.Int32"));
            DataColumn nazvaniePredmet = new DataColumn("Предмет", Type.GetType("System.String"));
            DataColumn idKlaPredmet = new DataColumn("idKlaPredmet", Type.GetType("System.Int32"));
            DataColumn UrokovVNedelyu = new DataColumn("Количество уроков в неделю", Type.GetType("System.Int32"));
            PredmetTable.Columns.Add(idPredmet);
            PredmetTable.Columns.Add(nazvaniePredmet);
            PredmetTable.Columns.Add(idKlaPredmet);
            PredmetTable.Columns.Add(UrokovVNedelyu);
            List<Predmet> predmets = DBobjects.Entities.Predmet.ToList();
            foreach (Predmet predmet in predmets)
            {
                if (DBobjects.Entities.KlassPredmet.Where(p => p.ID_Klass == KLASS.ID_Klass && p.ID_Predmet == predmet.ID_Predmet).Count() > 0)
                {
                    KlassPredmet klasspr = DBobjects.Entities.KlassPredmet.FirstOrDefault(p => p.ID_Klass == KLASS.ID_Klass && p.ID_Predmet == predmet.ID_Predmet);
                    PredmetTable.Rows.Add(predmet.ID_Predmet, predmet, klasspr.ID_KlassPredmet, klasspr.UrokovVNedelyu);
                }

                else
                    PredmetTable.Rows.Add(predmet.ID_Predmet, predmet, 0,0);
            }
            dataGridViewKlassPredmet.DataSource = PredmetTable;
            dataGridViewKlassPredmet.Columns[0].Visible = false;
            dataGridViewKlassPredmet.Columns[1].ReadOnly = true;
            dataGridViewKlassPredmet.Columns[2].Visible = false;
        }
        private void savePredmet()
        {
            foreach (DataGridViewRow dgvk in dataGridViewKlassPredmet.Rows)
            {
                if (Convert.ToInt32(dgvk.Cells[2].Value) == 0)
                    klassPredmet = new KlassPredmet();
                else
                {
                    int id = Convert.ToInt32(dgvk.Cells[2].Value);
                    klassPredmet = DBobjects.Entities.KlassPredmet.FirstOrDefault(p => p.ID_KlassPredmet == id);
                }
                if (Convert.ToInt32(dgvk.Cells[3].Value) !=0)
                {
                    klassPredmet.ID_Klass = KLASS.ID_Klass;
                    klassPredmet.UrokovVNedelyu= Convert.ToInt16(dgvk.Cells[3].Value);
                    klassPredmet.ID_Predmet = Convert.ToInt32(dgvk.Cells[0].Value);
                    if (DBobjects.Entities.KlassPredmet.Where(p => p.ID_KlassPredmet == klassPredmet.ID_KlassPredmet).Count() == 0)
                        DBobjects.Entities.KlassPredmet.Add(klassPredmet);
                    DBobjects.Entities.SaveChanges();
                }
                else if (klassPredmet.ID_KlassPredmet != 0 && Convert.ToInt16(dgvk.Cells[3].Value) == 0)
                    DeleteKlassPredmet();
            }
        }
        private void DeleteKlassPredmet()
        {
            DBobjects.Entities.KlassPredmet.Remove(klassPredmet);
            DBobjects.Entities.SaveChanges();
        }
       
    }
}
