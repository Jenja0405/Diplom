namespace Timetable
{
    partial class KlassForma
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
            this.dataGridViewKlass = new System.Windows.Forms.DataGridView();
            this.DobavKlass = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKlass)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewKlass
            // 
            this.dataGridViewKlass.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewKlass.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKlass.Location = new System.Drawing.Point(25, 12);
            this.dataGridViewKlass.Name = "dataGridViewKlass";
            this.dataGridViewKlass.Size = new System.Drawing.Size(138, 150);
            this.dataGridViewKlass.TabIndex = 0;
            this.dataGridViewKlass.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewKlass_CellMouseDoubleClick);
            // 
            // DobavKlass
            // 
            this.DobavKlass.Location = new System.Drawing.Point(25, 183);
            this.DobavKlass.Name = "DobavKlass";
            this.DobavKlass.Size = new System.Drawing.Size(138, 23);
            this.DobavKlass.TabIndex = 1;
            this.DobavKlass.Text = "Добавление класса";
            this.DobavKlass.UseVisualStyleBackColor = true;
            this.DobavKlass.Click += new System.EventHandler(this.DobavKlass_Click);
            // 
            // KlassForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(207, 229);
            this.Controls.Add(this.DobavKlass);
            this.Controls.Add(this.dataGridViewKlass);
            this.Name = "KlassForma";
            this.Text = "Список классов";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKlass)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewKlass;
        private System.Windows.Forms.Button DobavKlass;
    }
}