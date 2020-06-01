namespace Timetable
{
    partial class PredmetForma
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DobavPredmet = new System.Windows.Forms.Button();
            this.dataGridViewPredmet = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPredmet)).BeginInit();
            this.SuspendLayout();
            // 
            // DobavPredmet
            // 
            this.DobavPredmet.Location = new System.Drawing.Point(29, 183);
            this.DobavPredmet.Name = "DobavPredmet";
            this.DobavPredmet.Size = new System.Drawing.Size(138, 23);
            this.DobavPredmet.TabIndex = 5;
            this.DobavPredmet.Text = "Добавление предмета";
            this.DobavPredmet.UseVisualStyleBackColor = true;
            this.DobavPredmet.Click += new System.EventHandler(this.DobavPredmet_Click);
            // 
            // dataGridViewPredmet
            // 
            this.dataGridViewPredmet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewPredmet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPredmet.Location = new System.Drawing.Point(29, 12);
            this.dataGridViewPredmet.Name = "dataGridViewPredmet";
            this.dataGridViewPredmet.RowHeadersVisible = false;
            this.dataGridViewPredmet.Size = new System.Drawing.Size(138, 150);
            this.dataGridViewPredmet.TabIndex = 4;
            this.dataGridViewPredmet.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewPredmet_CellMouseDoubleClick);
            // 
            // PredmetForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(188, 219);
            this.Controls.Add(this.DobavPredmet);
            this.Controls.Add(this.dataGridViewPredmet);
            this.Name = "PredmetForma";
            this.Text = "Список предметов";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPredmet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button DobavPredmet;
        private System.Windows.Forms.DataGridView dataGridViewPredmet;
    }
}