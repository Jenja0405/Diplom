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
        private UchitelKlassPredmet uchitelKlassPredmet;

        public NewUschitelForma(Uchitel uchitel)
        {
            InitializeComponent();
            UCHITEL = uchitel;
            Fill();
            FillKlassPredmet();

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
        private void Saveuschitel_Click(object sender, EventArgs e)
        {
                Save();
                Fill();
            saveKlassPredmet();
                Close();
        }

        private void Removeuschitel_Click(object sender, EventArgs e)
        {
            Remove();
            Close();
        }
        private void FillKlassPredmet()
        {
            DataTable PredmetTable = new DataTable();
            DataColumn idKlassPredmet = new DataColumn("idKlassPredmet", Type.GetType("System.Int32"));
            DataColumn nazvaniePredmet = new DataColumn("Предмет", Type.GetType("System.String"));
            DataColumn nazvanieKlassa = new DataColumn("Класс", Type.GetType("System.String"));
            DataColumn KlassPredmet = new DataColumn("Да/Нет", Type.GetType("System.Boolean"));
            DataColumn idUschitelKlassPredmet = new DataColumn("idUschitelKlassPredmet",Type.GetType("System.Int32"));
            PredmetTable.Columns.Add(idKlassPredmet);
            PredmetTable.Columns.Add(nazvaniePredmet);
            PredmetTable.Columns.Add(nazvanieKlassa);
            PredmetTable.Columns.Add(KlassPredmet);
            PredmetTable.Columns.Add(idUschitelKlassPredmet);
            foreach (KlassPredmet klasspredm in DBobjects.Entities.KlassPredmet.ToList())
            {
                if (DBobjects.Entities.UchitelKlassPredmet.Where(p => p.ID_Uchitel == UCHITEL.ID_Uchitel && p.ID_KlassPredmet==klasspredm.ID_KlassPredmet).Count() > 0)
                    PredmetTable.Rows.Add(klasspredm.ID_KlassPredmet,klasspredm.Predmet,klasspredm.Klass, true, DBobjects.Entities.UchitelKlassPredmet.FirstOrDefault(p => p.ID_Uchitel == UCHITEL.ID_Uchitel && p.ID_KlassPredmet == klasspredm.ID_KlassPredmet).ID_UchitelKlassPredmet);
                else
                    PredmetTable.Rows.Add(klasspredm.ID_KlassPredmet,klasspredm.Predmet,klasspredm.Klass, false,0);
            }
            dataGridViewUschitelKlass.DataSource = PredmetTable;
            dataGridViewUschitelKlass.Columns[0].Visible = false;
            dataGridViewUschitelKlass.Columns[1].ReadOnly = true;
            dataGridViewUschitelKlass.Columns[4].Visible = false;
        }
        private void saveKlassPredmet()
        {
            foreach (DataGridViewRow dgvu in dataGridViewUschitelKlass.Rows)
            {
                if (Convert.ToInt32(dgvu.Cells[4].Value) == 0)
                    uchitelKlassPredmet = new UchitelKlassPredmet();
                else
                {
                    int id = Convert.ToInt32(dgvu.Cells[4].Value);
                    uchitelKlassPredmet = DBobjects.Entities.UchitelKlassPredmet.FirstOrDefault(p => p.ID_UchitelKlassPredmet == id);
                }
                if (Convert.ToBoolean(dgvu.Cells[3].Value) == true)
                {
                    uchitelKlassPredmet.ID_Uchitel = UCHITEL.ID_Uchitel;
                    uchitelKlassPredmet.ID_KlassPredmet = Convert.ToInt32(dgvu.Cells[0].Value);
                    if (DBobjects.Entities.UchitelKlassPredmet.Where(p => p.ID_UchitelKlassPredmet == uchitelKlassPredmet.ID_UchitelKlassPredmet).Count() == 0)
                        DBobjects.Entities.UchitelKlassPredmet.Add(uchitelKlassPredmet);
                    DBobjects.Entities.SaveChanges();
                }
                else if (uchitelKlassPredmet.ID_UchitelKlassPredmet != 0 && Convert.ToBoolean(dgvu.Cells[3].Value) == false)
                    DeleteKabinetPredmet();
            }
        }
        private void DeleteKabinetPredmet()
        {
            DBobjects.Entities.UchitelKlassPredmet.Remove(uchitelKlassPredmet);
            DBobjects.Entities.SaveChanges();
        }

    }
}
    
