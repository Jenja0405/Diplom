namespace Timetable
{
    partial class KabinetForma
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
            this.DobavKabinet = new System.Windows.Forms.Button();
            this.dataGridViewKabinet = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKabinet)).BeginInit();
            this.SuspendLayout();
            // 
            // DobavKabinet
            // 
            this.DobavKabinet.Location = new System.Drawing.Point(42, 183);
            this.DobavKabinet.Name = "DobavKabinet";
            this.DobavKabinet.Size = new System.Drawing.Size(138, 23);
            this.DobavKabinet.TabIndex = 3;
            this.DobavKabinet.Text = "Добавление кабинета";
            this.DobavKabinet.UseVisualStyleBackColor = true;
            this.DobavKabinet.Click += new System.EventHandler(this.DobavKabinet_Click);
            // 
            // dataGridViewKabinet
            // 
            this.dataGridViewKabinet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewKabinet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKabinet.Location = new System.Drawing.Point(42, 12);
            this.dataGridViewKabinet.Name = "dataGridViewKabinet";
            this.dataGridViewKabinet.Size = new System.Drawing.Size(138, 150);
            this.dataGridViewKabinet.TabIndex = 2;
            this.dataGridViewKabinet.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewKabinet_CellMouseDoubleClick);
            // 
            // KabinetForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(220, 219);
            this.Controls.Add(this.DobavKabinet);
            this.Controls.Add(this.dataGridViewKabinet);
            this.Name = "KabinetForma";
            this.Text = "Список кабинетов";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKabinet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button DobavKabinet;
        private System.Windows.Forms.DataGridView dataGridViewKabinet;
    }
}