﻿using System;
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
            Fill();
        }
        private void Fill()
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

        private void button1_Click(object sender, EventArgs e)
        {
            List<Klass> Klass= DBobjects.Entities.Klass.ToList();
             List<Predmet> Predmet = DBobjects.Entities.Predmet.ToList();
             List<Uchitel> Uchitel = DBobjects.Entities.Uchitel.ToList();
             List<Kabinet> Kabinet = DBobjects.Entities.Kabinet.ToList();
             List<string> Weekday = new List<string>() {"Понедельник", "Вторник", "Среда", "Четверг", "Пятница"};
             List<int> NomerUroka = new List<int>() { 1,2,3,4,5,6,7};
            List<Urok> Urok = DBobjects.Entities.Urok.ToList();
            MessageBox.Show("начало");
            Raspisaniedata.DataSource = Scheduling.Sapolnenie(Klass, Predmet, Uchitel, Kabinet, Weekday, NomerUroka, Urok);
            MessageBox.Show("конец");
        }
    }
    }

