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
        private KabinetPredmet kabinetPredmet;
       
        public NewKabinetForma(Kabinet kabinet)
        {
            InitializeComponent();
            KABINET = kabinet;
            Fill();
            FillPredmet();
        }
        private void Fill()
        {
            textBoxKabinet.Text = KABINET.Nazvanie_K;
        }
        private void Save()
        {
            if (DBobjects.Entities.Kabinet.Where(p => p.ID_Kabinet == KABINET.ID_Kabinet).Count() == 0)
            {
                DBobjects.Entities.Kabinet.Add(KABINET);
            }
            DBobjects.Entities.SaveChanges();
            MessageBox.Show("Сохранено");

        }
        private void Remove()
        {
            if (DBobjects.Entities.Kabinet.Where(p => p.ID_Kabinet == KABINET.ID_Kabinet).Count() > 0)
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
            savePredmet();
            Fill();
            Close();
        }

        private void RemovKabinet_Click(object sender, EventArgs e)
        {
            Remove();
            Close();
        }
        private void FillPredmet()
        {
            DataTable PredmetTable = new DataTable();
            DataColumn idPredmet = new DataColumn("idPredmet", Type.GetType("System.Int32"));
            DataColumn nazvaniePredmet = new DataColumn("Предмет", Type.GetType("System.String"));
            DataColumn kabPredmet = new DataColumn("Да/Нет", Type.GetType("System.Boolean"));
            DataColumn idKabPredmet = new DataColumn("idKabPredmet", Type.GetType("System.Int32"));
            PredmetTable.Columns.Add(idPredmet);
            PredmetTable.Columns.Add(nazvaniePredmet);
            PredmetTable.Columns.Add(kabPredmet);
            PredmetTable.Columns.Add(idKabPredmet);
            List<Predmet> predmet = DBobjects.Entities.Predmet.ToList();
            foreach (Predmet predm in predmet)
            {
                if (DBobjects.Entities.KabinetPredmet.Where(p => p.ID_Kabinet == KABINET.ID_Kabinet && p.ID_Predmet == predm.ID_Predmet).Count() > 0)
                    PredmetTable.Rows.Add(predm.ID_Predmet, predm, true, DBobjects.Entities.KabinetPredmet.FirstOrDefault(p => p.ID_Kabinet == KABINET.ID_Kabinet && p.ID_Predmet == predm.ID_Predmet).ID_KabinetPredmet);
                else
                    PredmetTable.Rows.Add(predm.ID_Predmet, predm, false, 0);
            }
            dataGridViewPredmet.DataSource = PredmetTable;
            dataGridViewPredmet.Columns[0].Visible = false;
            dataGridViewPredmet.Columns[1].ReadOnly = true;
            dataGridViewPredmet.Columns[3].Visible = false;
        }
        private void savePredmet()
        {
            foreach (DataGridViewRow dgvr in dataGridViewPredmet.Rows)
            {
                if (Convert.ToInt32(dgvr.Cells[3].Value) == 0)
                    kabinetPredmet = new KabinetPredmet();
                else
                {
                    int id = Convert.ToInt32(dgvr.Cells[3].Value);
                    kabinetPredmet = DBobjects.Entities.KabinetPredmet.FirstOrDefault(p => p.ID_KabinetPredmet == id);
                }
                if (Convert.ToBoolean(dgvr.Cells[2].Value) == true)
                {
                    kabinetPredmet.ID_Kabinet = KABINET.ID_Kabinet;
                    kabinetPredmet.ID_Predmet = Convert.ToInt32(dgvr.Cells[0].Value);
                    if (DBobjects.Entities.KabinetPredmet.Where(p => p.ID_KabinetPredmet == kabinetPredmet.ID_KabinetPredmet).Count() == 0)
                        DBobjects.Entities.KabinetPredmet.Add(kabinetPredmet);
                    DBobjects.Entities.SaveChanges();
                }
                else if (kabinetPredmet.ID_KabinetPredmet != 0 && Convert.ToBoolean(dgvr.Cells[2].Value) == false)
                    DeleteKabinetPredmet();
            }
        }
            private void DeleteKabinetPredmet()
        {
            DBobjects.Entities.KabinetPredmet.Remove(kabinetPredmet);
            DBobjects.Entities.SaveChanges();
        }

        }
    }

