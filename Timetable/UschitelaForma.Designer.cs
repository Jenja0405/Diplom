namespace Timetable
{
    partial class UschitelaForma
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
            this.Dobavuschitel = new System.Windows.Forms.Button();
            this.dataGridViewucshitel = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewucshitel)).BeginInit();
            this.SuspendLayout();
            // 
            // Dobavuschitel
            // 
            this.Dobavuschitel.Location = new System.Drawing.Point(22, 187);
            this.Dobavuschitel.Name = "Dobavuschitel";
            this.Dobavuschitel.Size = new System.Drawing.Size(301, 23);
            this.Dobavuschitel.TabIndex = 8;
            this.Dobavuschitel.Text = "Добавление учителя";
            this.Dobavuschitel.UseVisualStyleBackColor = true;
            this.Dobavuschitel.Click += new System.EventHandler(this.Dobavuschitel_Click);
            // 
            // dataGridViewucshitel
            // 
            this.dataGridViewucshitel.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewucshitel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewucshitel.Location = new System.Drawing.Point(22, 22);
            this.dataGridViewucshitel.Name = "dataGridViewucshitel";
            this.dataGridViewucshitel.RowHeadersVisible = false;
            this.dataGridViewucshitel.Size = new System.Drawing.Size(301, 150);
            this.dataGridViewucshitel.TabIndex = 7;
            this.dataGridViewucshitel.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewucshitel_CellMouseDoubleClick);
            // 
            // UschitelaForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 222);
            this.Controls.Add(this.Dobavuschitel);
            this.Controls.Add(this.dataGridViewucshitel);
            this.Name = "UschitelaForma";
            this.Text = "Список учителей";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewucshitel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Dobavuschitel;
        private System.Windows.Forms.DataGridView dataGridViewucshitel;
    }
}