namespace Timetable
{
    partial class NewUschitelForma
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
            this.Saveuschitel = new System.Windows.Forms.Button();
            this.Removeuschitel = new System.Windows.Forms.Button();
            this.textBoxotchestvo = new System.Windows.Forms.TextBox();
            this.textBoximya = new System.Windows.Forms.TextBox();
            this.textBoxfamilie = new System.Windows.Forms.TextBox();
            this.Otchestvo = new System.Windows.Forms.Label();
            this.Imya = new System.Windows.Forms.Label();
            this.Familie = new System.Windows.Forms.Label();
            this.dataGridViewUschitelKlass = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUschitelKlass)).BeginInit();
            this.SuspendLayout();
            // 
            // Saveuschitel
            // 
            this.Saveuschitel.Location = new System.Drawing.Point(12, 420);
            this.Saveuschitel.Name = "Saveuschitel";
            this.Saveuschitel.Size = new System.Drawing.Size(75, 23);
            this.Saveuschitel.TabIndex = 14;
            this.Saveuschitel.Text = "Сохранить";
            this.Saveuschitel.UseVisualStyleBackColor = true;
            this.Saveuschitel.Click += new System.EventHandler(this.Saveuschitel_Click);
            // 
            // Removeuschitel
            // 
            this.Removeuschitel.Location = new System.Drawing.Point(194, 420);
            this.Removeuschitel.Name = "Removeuschitel";
            this.Removeuschitel.Size = new System.Drawing.Size(75, 23);
            this.Removeuschitel.TabIndex = 15;
            this.Removeuschitel.Text = "Удалить";
            this.Removeuschitel.UseVisualStyleBackColor = true;
            this.Removeuschitel.Click += new System.EventHandler(this.Removeuschitel_Click);
            // 
            // textBoxotchestvo
            // 
            this.textBoxotchestvo.Location = new System.Drawing.Point(87, 70);
            this.textBoxotchestvo.Name = "textBoxotchestvo";
            this.textBoxotchestvo.Size = new System.Drawing.Size(155, 20);
            this.textBoxotchestvo.TabIndex = 13;
            this.textBoxotchestvo.TextChanged += new System.EventHandler(this.textBoxotchestvo_TextChanged_1);
            // 
            // textBoximya
            // 
            this.textBoximya.Location = new System.Drawing.Point(87, 41);
            this.textBoximya.Name = "textBoximya";
            this.textBoximya.Size = new System.Drawing.Size(155, 20);
            this.textBoximya.TabIndex = 12;
            this.textBoximya.TextChanged += new System.EventHandler(this.textBoximya_TextChanged_1);
            // 
            // textBoxfamilie
            // 
            this.textBoxfamilie.Location = new System.Drawing.Point(87, 16);
            this.textBoxfamilie.Name = "textBoxfamilie";
            this.textBoxfamilie.Size = new System.Drawing.Size(155, 20);
            this.textBoxfamilie.TabIndex = 11;
            this.textBoxfamilie.TextChanged += new System.EventHandler(this.textBoxfamilie_TextChanged_1);
            // 
            // Otchestvo
            // 
            this.Otchestvo.AutoSize = true;
            this.Otchestvo.Location = new System.Drawing.Point(28, 73);
            this.Otchestvo.Name = "Otchestvo";
            this.Otchestvo.Size = new System.Drawing.Size(54, 13);
            this.Otchestvo.TabIndex = 10;
            this.Otchestvo.Text = "Отчество";
            // 
            // Imya
            // 
            this.Imya.AutoSize = true;
            this.Imya.Location = new System.Drawing.Point(28, 44);
            this.Imya.Name = "Imya";
            this.Imya.Size = new System.Drawing.Size(29, 13);
            this.Imya.TabIndex = 9;
            this.Imya.Text = "Имя";
            // 
            // Familie
            // 
            this.Familie.AutoSize = true;
            this.Familie.Location = new System.Drawing.Point(25, 19);
            this.Familie.Name = "Familie";
            this.Familie.Size = new System.Drawing.Size(56, 13);
            this.Familie.TabIndex = 8;
            this.Familie.Text = "Фамилия";
            // 
            // dataGridViewUschitelKlass
            // 
            this.dataGridViewUschitelKlass.AllowUserToAddRows = false;
            this.dataGridViewUschitelKlass.AllowUserToDeleteRows = false;
            this.dataGridViewUschitelKlass.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewUschitelKlass.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUschitelKlass.Location = new System.Drawing.Point(31, 106);
            this.dataGridViewUschitelKlass.Name = "dataGridViewUschitelKlass";
            this.dataGridViewUschitelKlass.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewUschitelKlass.Size = new System.Drawing.Size(214, 308);
            this.dataGridViewUschitelKlass.TabIndex = 24;
            // 
            // NewUschitelForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 455);
            this.Controls.Add(this.dataGridViewUschitelKlass);
            this.Controls.Add(this.Saveuschitel);
            this.Controls.Add(this.Removeuschitel);
            this.Controls.Add(this.textBoxotchestvo);
            this.Controls.Add(this.textBoximya);
            this.Controls.Add(this.textBoxfamilie);
            this.Controls.Add(this.Otchestvo);
            this.Controls.Add(this.Imya);
            this.Controls.Add(this.Familie);
            this.Name = "NewUschitelForma";
            this.Text = "Учителя";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUschitelKlass)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Saveuschitel;
        private System.Windows.Forms.Button Removeuschitel;
        private System.Windows.Forms.TextBox textBoxotchestvo;
        private System.Windows.Forms.TextBox textBoximya;
        private System.Windows.Forms.TextBox textBoxfamilie;
        private System.Windows.Forms.Label Otchestvo;
        private System.Windows.Forms.Label Imya;
        private System.Windows.Forms.Label Familie;
        private System.Windows.Forms.DataGridView dataGridViewUschitelKlass;
    }
}