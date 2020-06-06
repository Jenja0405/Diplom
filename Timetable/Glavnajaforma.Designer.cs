namespace Timetable
{
    partial class Glavnajaforma
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Raspisaniedata = new System.Windows.Forms.DataGridView();
            this.LabelSostavlenieraspisanie = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.SgenerirovatMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.CpravochnikiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.классыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.учителяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.кабинетыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.предметыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.составлениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.экспортироватьВExceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.Raspisaniedata)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Raspisaniedata
            // 
            this.Raspisaniedata.AllowUserToAddRows = false;
            this.Raspisaniedata.AllowUserToDeleteRows = false;
            this.Raspisaniedata.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.Raspisaniedata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Raspisaniedata.DefaultCellStyle = dataGridViewCellStyle1;
            this.Raspisaniedata.Location = new System.Drawing.Point(39, 72);
            this.Raspisaniedata.Name = "Raspisaniedata";
            this.Raspisaniedata.ReadOnly = true;
            this.Raspisaniedata.RowHeadersVisible = false;
            this.Raspisaniedata.Size = new System.Drawing.Size(600, 281);
            this.Raspisaniedata.TabIndex = 1;
            this.Raspisaniedata.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Raspisaniedata_CellDoubleClick);
            // 
            // LabelSostavlenieraspisanie
            // 
            this.LabelSostavlenieraspisanie.AutoSize = true;
            this.LabelSostavlenieraspisanie.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelSostavlenieraspisanie.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.LabelSostavlenieraspisanie.Location = new System.Drawing.Point(152, 24);
            this.LabelSostavlenieraspisanie.Name = "LabelSostavlenieraspisanie";
            this.LabelSostavlenieraspisanie.Size = new System.Drawing.Size(363, 45);
            this.LabelSostavlenieraspisanie.TabIndex = 2;
            this.LabelSostavlenieraspisanie.Text = "Составление расписания";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SgenerirovatMenu,
            this.CpravochnikiToolStripMenuItem,
            this.составлениеToolStripMenuItem,
            this.экспортироватьВExceToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(677, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // SgenerirovatMenu
            // 
            this.SgenerirovatMenu.Name = "SgenerirovatMenu";
            this.SgenerirovatMenu.Size = new System.Drawing.Size(102, 20);
            this.SgenerirovatMenu.Text = "Сгенерировать";
            this.SgenerirovatMenu.Click += new System.EventHandler(this.SgenerirovatMenu_Click);
            // 
            // CpravochnikiToolStripMenuItem
            // 
            this.CpravochnikiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.классыToolStripMenuItem,
            this.учителяToolStripMenuItem,
            this.кабинетыToolStripMenuItem,
            this.предметыToolStripMenuItem});
            this.CpravochnikiToolStripMenuItem.Name = "CpravochnikiToolStripMenuItem";
            this.CpravochnikiToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.CpravochnikiToolStripMenuItem.Text = "Справочники";
            // 
            // классыToolStripMenuItem
            // 
            this.классыToolStripMenuItem.Name = "классыToolStripMenuItem";
            this.классыToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.классыToolStripMenuItem.Text = "Классы";
            this.классыToolStripMenuItem.Click += new System.EventHandler(this.классыToolStripMenuItem_Click);
            // 
            // учителяToolStripMenuItem
            // 
            this.учителяToolStripMenuItem.Name = "учителяToolStripMenuItem";
            this.учителяToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.учителяToolStripMenuItem.Text = "Учителя";
            this.учителяToolStripMenuItem.Click += new System.EventHandler(this.учителяToolStripMenuItem_Click);
            // 
            // кабинетыToolStripMenuItem
            // 
            this.кабинетыToolStripMenuItem.Name = "кабинетыToolStripMenuItem";
            this.кабинетыToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.кабинетыToolStripMenuItem.Text = "Кабинеты";
            this.кабинетыToolStripMenuItem.Click += new System.EventHandler(this.кабинетыToolStripMenuItem_Click);
            // 
            // предметыToolStripMenuItem
            // 
            this.предметыToolStripMenuItem.Name = "предметыToolStripMenuItem";
            this.предметыToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.предметыToolStripMenuItem.Text = "Предметы";
            this.предметыToolStripMenuItem.Click += new System.EventHandler(this.предметыToolStripMenuItem_Click);
            // 
            // составлениеToolStripMenuItem
            // 
            this.составлениеToolStripMenuItem.Name = "составлениеToolStripMenuItem";
            this.составлениеToolStripMenuItem.Size = new System.Drawing.Size(12, 20);
            // 
            // экспортироватьВExceToolStripMenuItem
            // 
            this.экспортироватьВExceToolStripMenuItem.Name = "экспортироватьВExceToolStripMenuItem";
            this.экспортироватьВExceToolStripMenuItem.Size = new System.Drawing.Size(149, 20);
            this.экспортироватьВExceToolStripMenuItem.Text = "Экспортировать в Excel ";
            this.экспортироватьВExceToolStripMenuItem.Click += new System.EventHandler(this.экспортироватьВExceToolStripMenuItem_Click);
            // 
            // Glavnajaforma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 365);
            this.Controls.Add(this.LabelSostavlenieraspisanie);
            this.Controls.Add(this.Raspisaniedata);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Glavnajaforma";
            ((System.ComponentModel.ISupportInitialize)(this.Raspisaniedata)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView Raspisaniedata;
        private System.Windows.Forms.Label LabelSostavlenieraspisanie;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem CpravochnikiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem классыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem учителяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem кабинетыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem предметыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem составлениеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SgenerirovatMenu;
        private System.Windows.Forms.ToolStripMenuItem экспортироватьВExceToolStripMenuItem;
    }
}

