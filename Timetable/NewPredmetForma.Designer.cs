namespace Timetable
{
    partial class NewPredmetForma
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
            this.SavePredmet = new System.Windows.Forms.Button();
            this.RemovPredmet = new System.Windows.Forms.Button();
            this.textBoxPredmet = new System.Windows.Forms.TextBox();
            this.PredmetLabel = new System.Windows.Forms.Label();
            this.dataGridViewKlassPredmet = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKlassPredmet)).BeginInit();
            this.SuspendLayout();
            // 
            // SavePredmet
            // 
            this.SavePredmet.Location = new System.Drawing.Point(31, 305);
            this.SavePredmet.Name = "SavePredmet";
            this.SavePredmet.Size = new System.Drawing.Size(75, 23);
            this.SavePredmet.TabIndex = 24;
            this.SavePredmet.Text = "Сохранить";
            this.SavePredmet.UseVisualStyleBackColor = true;
            this.SavePredmet.Click += new System.EventHandler(this.SavePredmet_Click);
            // 
            // RemovPredmet
            // 
            this.RemovPredmet.Location = new System.Drawing.Point(170, 305);
            this.RemovPredmet.Name = "RemovPredmet";
            this.RemovPredmet.Size = new System.Drawing.Size(75, 23);
            this.RemovPredmet.TabIndex = 25;
            this.RemovPredmet.Text = "Удалить";
            this.RemovPredmet.UseVisualStyleBackColor = true;
            this.RemovPredmet.Click += new System.EventHandler(this.RemovPredmet_Click);
            // 
            // textBoxPredmet
            // 
            this.textBoxPredmet.Location = new System.Drawing.Point(90, 23);
            this.textBoxPredmet.Name = "textBoxPredmet";
            this.textBoxPredmet.Size = new System.Drawing.Size(155, 20);
            this.textBoxPredmet.TabIndex = 23;
            this.textBoxPredmet.TextChanged += new System.EventHandler(this.textBoxPredmet_TextChanged);
            // 
            // PredmetLabel
            // 
            this.PredmetLabel.AutoSize = true;
            this.PredmetLabel.Location = new System.Drawing.Point(28, 26);
            this.PredmetLabel.Name = "PredmetLabel";
            this.PredmetLabel.Size = new System.Drawing.Size(52, 13);
            this.PredmetLabel.TabIndex = 22;
            this.PredmetLabel.Text = "Предмет";
            // 
            // dataGridViewKlassPredmet
            // 
            this.dataGridViewKlassPredmet.AllowUserToAddRows = false;
            this.dataGridViewKlassPredmet.AllowUserToDeleteRows = false;
            this.dataGridViewKlassPredmet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKlassPredmet.Location = new System.Drawing.Point(32, 58);
            this.dataGridViewKlassPredmet.Name = "dataGridViewKlassPredmet";
            this.dataGridViewKlassPredmet.Size = new System.Drawing.Size(213, 211);
            this.dataGridViewKlassPredmet.TabIndex = 26;
            // 
            // NewPredmetForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 340);
            this.Controls.Add(this.dataGridViewKlassPredmet);
            this.Controls.Add(this.SavePredmet);
            this.Controls.Add(this.RemovPredmet);
            this.Controls.Add(this.textBoxPredmet);
            this.Controls.Add(this.PredmetLabel);
            this.Name = "NewPredmetForma";
            this.Text = "Предметы";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKlassPredmet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SavePredmet;
        private System.Windows.Forms.Button RemovPredmet;
        private System.Windows.Forms.TextBox textBoxPredmet;
        private System.Windows.Forms.Label PredmetLabel;
        private System.Windows.Forms.DataGridView dataGridViewKlassPredmet;
    }
}