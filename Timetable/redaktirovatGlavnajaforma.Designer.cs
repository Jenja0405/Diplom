namespace Timetable
{
    partial class redaktirovatGlavnajaforma
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
            this.LabelWekday = new System.Windows.Forms.Label();
            this.labelNomer = new System.Windows.Forms.Label();
            this.labelKabinet = new System.Windows.Forms.Label();
            this.labelKlass = new System.Windows.Forms.Label();
            this.labelPredmet = new System.Windows.Forms.Label();
            this.labelUschitel = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.comboBoxWeekday = new System.Windows.Forms.ComboBox();
            this.comboBoxNomer = new System.Windows.Forms.ComboBox();
            this.comboBoxKabinet = new System.Windows.Forms.ComboBox();
            this.comboBoxKlass = new System.Windows.Forms.ComboBox();
            this.comboBoxPredmet = new System.Windows.Forms.ComboBox();
            this.comboBoxUschitel = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // LabelWekday
            // 
            this.LabelWekday.AutoSize = true;
            this.LabelWekday.Location = new System.Drawing.Point(13, 22);
            this.LabelWekday.Name = "LabelWekday";
            this.LabelWekday.Size = new System.Drawing.Size(73, 13);
            this.LabelWekday.TabIndex = 0;
            this.LabelWekday.Text = "День недели";
            // 
            // labelNomer
            // 
            this.labelNomer.AutoSize = true;
            this.labelNomer.Location = new System.Drawing.Point(13, 54);
            this.labelNomer.Name = "labelNomer";
            this.labelNomer.Size = new System.Drawing.Size(73, 13);
            this.labelNomer.TabIndex = 1;
            this.labelNomer.Text = "Номер урока";
            // 
            // labelKabinet
            // 
            this.labelKabinet.AutoSize = true;
            this.labelKabinet.Location = new System.Drawing.Point(13, 91);
            this.labelKabinet.Name = "labelKabinet";
            this.labelKabinet.Size = new System.Drawing.Size(49, 13);
            this.labelKabinet.TabIndex = 2;
            this.labelKabinet.Text = "Кабинет";
            // 
            // labelKlass
            // 
            this.labelKlass.AutoSize = true;
            this.labelKlass.Location = new System.Drawing.Point(13, 129);
            this.labelKlass.Name = "labelKlass";
            this.labelKlass.Size = new System.Drawing.Size(38, 13);
            this.labelKlass.TabIndex = 3;
            this.labelKlass.Text = "Класс";
            // 
            // labelPredmet
            // 
            this.labelPredmet.AutoSize = true;
            this.labelPredmet.Location = new System.Drawing.Point(13, 163);
            this.labelPredmet.Name = "labelPredmet";
            this.labelPredmet.Size = new System.Drawing.Size(52, 13);
            this.labelPredmet.TabIndex = 4;
            this.labelPredmet.Text = "Предмет";
            // 
            // labelUschitel
            // 
            this.labelUschitel.AutoSize = true;
            this.labelUschitel.Location = new System.Drawing.Point(13, 196);
            this.labelUschitel.Name = "labelUschitel";
            this.labelUschitel.Size = new System.Drawing.Size(49, 13);
            this.labelUschitel.TabIndex = 5;
            this.labelUschitel.Text = "Учитель";
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(88, 234);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(129, 23);
            this.buttonSave.TabIndex = 6;
            this.buttonSave.Text = "Сохранить изменения";
            this.buttonSave.UseVisualStyleBackColor = true;
            // 
            // comboBoxWeekday
            // 
            this.comboBoxWeekday.FormattingEnabled = true;
            this.comboBoxWeekday.Items.AddRange(new object[] {
            "Понедельник",
            "Вторник",
            "Среда",
            "Четверг",
            "Пятница"});
            this.comboBoxWeekday.Location = new System.Drawing.Point(133, 14);
            this.comboBoxWeekday.Name = "comboBoxWeekday";
            this.comboBoxWeekday.Size = new System.Drawing.Size(163, 21);
            this.comboBoxWeekday.TabIndex = 7;
            this.comboBoxWeekday.SelectedIndexChanged += new System.EventHandler(this.comboBoxWeekday_SelectedIndexChanged);
            // 
            // comboBoxNomer
            // 
            this.comboBoxNomer.FormattingEnabled = true;
            this.comboBoxNomer.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.comboBoxNomer.Location = new System.Drawing.Point(133, 46);
            this.comboBoxNomer.Name = "comboBoxNomer";
            this.comboBoxNomer.Size = new System.Drawing.Size(163, 21);
            this.comboBoxNomer.TabIndex = 8;
            this.comboBoxNomer.SelectedIndexChanged += new System.EventHandler(this.comboBoxNomer_SelectedIndexChanged);
            // 
            // comboBoxKabinet
            // 
            this.comboBoxKabinet.FormattingEnabled = true;
            this.comboBoxKabinet.Location = new System.Drawing.Point(133, 83);
            this.comboBoxKabinet.Name = "comboBoxKabinet";
            this.comboBoxKabinet.Size = new System.Drawing.Size(163, 21);
            this.comboBoxKabinet.TabIndex = 9;
            // 
            // comboBoxKlass
            // 
            this.comboBoxKlass.FormattingEnabled = true;
            this.comboBoxKlass.Location = new System.Drawing.Point(133, 121);
            this.comboBoxKlass.Name = "comboBoxKlass";
            this.comboBoxKlass.Size = new System.Drawing.Size(163, 21);
            this.comboBoxKlass.TabIndex = 10;
            // 
            // comboBoxPredmet
            // 
            this.comboBoxPredmet.FormattingEnabled = true;
            this.comboBoxPredmet.Location = new System.Drawing.Point(133, 155);
            this.comboBoxPredmet.Name = "comboBoxPredmet";
            this.comboBoxPredmet.Size = new System.Drawing.Size(163, 21);
            this.comboBoxPredmet.TabIndex = 11;
            // 
            // comboBoxUschitel
            // 
            this.comboBoxUschitel.FormattingEnabled = true;
            this.comboBoxUschitel.Location = new System.Drawing.Point(133, 188);
            this.comboBoxUschitel.Name = "comboBoxUschitel";
            this.comboBoxUschitel.Size = new System.Drawing.Size(163, 21);
            this.comboBoxUschitel.TabIndex = 12;
            // 
            // redaktirovatGlavnajaforma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 268);
            this.Controls.Add(this.comboBoxUschitel);
            this.Controls.Add(this.comboBoxPredmet);
            this.Controls.Add(this.comboBoxKlass);
            this.Controls.Add(this.comboBoxKabinet);
            this.Controls.Add(this.comboBoxNomer);
            this.Controls.Add(this.comboBoxWeekday);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.labelUschitel);
            this.Controls.Add(this.labelPredmet);
            this.Controls.Add(this.labelKlass);
            this.Controls.Add(this.labelKabinet);
            this.Controls.Add(this.labelNomer);
            this.Controls.Add(this.LabelWekday);
            this.Name = "redaktirovatGlavnajaforma";
            this.Text = "Редактирование расписания";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelWekday;
        private System.Windows.Forms.Label labelNomer;
        private System.Windows.Forms.Label labelKabinet;
        private System.Windows.Forms.Label labelKlass;
        private System.Windows.Forms.Label labelPredmet;
        private System.Windows.Forms.Label labelUschitel;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.ComboBox comboBoxWeekday;
        private System.Windows.Forms.ComboBox comboBoxNomer;
        private System.Windows.Forms.ComboBox comboBoxKabinet;
        private System.Windows.Forms.ComboBox comboBoxKlass;
        private System.Windows.Forms.ComboBox comboBoxPredmet;
        private System.Windows.Forms.ComboBox comboBoxUschitel;
    }
}