namespace Timetable
{
    partial class NewKabinetForma
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
            this.SaveKabinet = new System.Windows.Forms.Button();
            this.RemovKabinet = new System.Windows.Forms.Button();
            this.textBoxKabinet = new System.Windows.Forms.TextBox();
            this.KabinetLabel = new System.Windows.Forms.Label();
            this.dataGridViewPredmet = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPredmet)).BeginInit();
            this.SuspendLayout();
            // 
            // SaveKabinet
            // 
            this.SaveKabinet.Location = new System.Drawing.Point(33, 309);
            this.SaveKabinet.Name = "SaveKabinet";
            this.SaveKabinet.Size = new System.Drawing.Size(75, 23);
            this.SaveKabinet.TabIndex = 20;
            this.SaveKabinet.Text = "Сохранить";
            this.SaveKabinet.UseVisualStyleBackColor = true;
            this.SaveKabinet.Click += new System.EventHandler(this.SaveKabinet_Click);
            // 
            // RemovKabinet
            // 
            this.RemovKabinet.Location = new System.Drawing.Point(172, 309);
            this.RemovKabinet.Name = "RemovKabinet";
            this.RemovKabinet.Size = new System.Drawing.Size(75, 23);
            this.RemovKabinet.TabIndex = 21;
            this.RemovKabinet.Text = "Удалить";
            this.RemovKabinet.UseVisualStyleBackColor = true;
            this.RemovKabinet.Click += new System.EventHandler(this.RemovKabinet_Click);
            // 
            // textBoxKabinet
            // 
            this.textBoxKabinet.Location = new System.Drawing.Point(92, 25);
            this.textBoxKabinet.Name = "textBoxKabinet";
            this.textBoxKabinet.Size = new System.Drawing.Size(155, 20);
            this.textBoxKabinet.TabIndex = 19;
            this.textBoxKabinet.TextChanged += new System.EventHandler(this.textBoxKabinet_TextChanged);
            // 
            // KabinetLabel
            // 
            this.KabinetLabel.AutoSize = true;
            this.KabinetLabel.Location = new System.Drawing.Point(30, 28);
            this.KabinetLabel.Name = "KabinetLabel";
            this.KabinetLabel.Size = new System.Drawing.Size(49, 13);
            this.KabinetLabel.TabIndex = 18;
            this.KabinetLabel.Text = "Кабинет";
            // 
            // dataGridViewPredmet
            // 
            this.dataGridViewPredmet.AllowUserToAddRows = false;
            this.dataGridViewPredmet.AllowUserToDeleteRows = false;
            this.dataGridViewPredmet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewPredmet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPredmet.Location = new System.Drawing.Point(33, 62);
            this.dataGridViewPredmet.Name = "dataGridViewPredmet";
            this.dataGridViewPredmet.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewPredmet.Size = new System.Drawing.Size(214, 227);
            this.dataGridViewPredmet.TabIndex = 22;
            // 
            // NewKabinetForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 340);
            this.Controls.Add(this.dataGridViewPredmet);
            this.Controls.Add(this.SaveKabinet);
            this.Controls.Add(this.RemovKabinet);
            this.Controls.Add(this.textBoxKabinet);
            this.Controls.Add(this.KabinetLabel);
            this.Name = "NewKabinetForma";
            this.Text = "Кабинеты";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPredmet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SaveKabinet;
        private System.Windows.Forms.Button RemovKabinet;
        private System.Windows.Forms.TextBox textBoxKabinet;
        private System.Windows.Forms.Label KabinetLabel;
        private System.Windows.Forms.DataGridView dataGridViewPredmet;
    }
}