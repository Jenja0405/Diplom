namespace Timetable
{
    partial class NewKlassForma
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
            this.textBoxklass = new System.Windows.Forms.TextBox();
            this.KlassLabel = new System.Windows.Forms.Label();
            this.Saveklass = new System.Windows.Forms.Button();
            this.Removklass = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxklass
            // 
            this.textBoxklass.Location = new System.Drawing.Point(83, 30);
            this.textBoxklass.Name = "textBoxklass";
            this.textBoxklass.Size = new System.Drawing.Size(155, 20);
            this.textBoxklass.TabIndex = 13;
            this.textBoxklass.TextChanged += new System.EventHandler(this.textBoxklass_TextChanged);
            // 
            // KlassLabel
            // 
            this.KlassLabel.AutoSize = true;
            this.KlassLabel.Location = new System.Drawing.Point(21, 33);
            this.KlassLabel.Name = "KlassLabel";
            this.KlassLabel.Size = new System.Drawing.Size(38, 13);
            this.KlassLabel.TabIndex = 12;
            this.KlassLabel.Text = "Класс";
            // 
            // Saveklass
            // 
            this.Saveklass.Location = new System.Drawing.Point(24, 73);
            this.Saveklass.Name = "Saveklass";
            this.Saveklass.Size = new System.Drawing.Size(75, 23);
            this.Saveklass.TabIndex = 16;
            this.Saveklass.Text = "Сохранить";
            this.Saveklass.UseVisualStyleBackColor = true;
            this.Saveklass.Click += new System.EventHandler(this.Saveklass_Click);
            // 
            // Removklass
            // 
            this.Removklass.Location = new System.Drawing.Point(163, 73);
            this.Removklass.Name = "Removklass";
            this.Removklass.Size = new System.Drawing.Size(75, 23);
            this.Removklass.TabIndex = 17;
            this.Removklass.Text = "Удалить";
            this.Removklass.UseVisualStyleBackColor = true;
            this.Removklass.Click += new System.EventHandler(this.Removklass_Click);
            // 
            // NewKlassForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(252, 109);
            this.Controls.Add(this.Saveklass);
            this.Controls.Add(this.Removklass);
            this.Controls.Add(this.textBoxklass);
            this.Controls.Add(this.KlassLabel);
            this.Name = "NewKlassForma";
            this.Text = "Классы";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxklass;
        private System.Windows.Forms.Label KlassLabel;
        private System.Windows.Forms.Button Saveklass;
        private System.Windows.Forms.Button Removklass;
    }
}