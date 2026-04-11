namespace RezerwacjaSalMVP.Views
{
    partial class RezerwacjaViewControl
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnUsunRezerwacje = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cbWybranyProwadzacy = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbWybranaSala = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.dtpOd = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.dtpDo = new System.Windows.Forms.DateTimePicker();
            this.btnDodajRezerwacje = new System.Windows.Forms.Button();
            this.lbRezerwacje = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnUsunRezerwacje
            // 
            this.btnUsunRezerwacje.Location = new System.Drawing.Point(160, 274);
            this.btnUsunRezerwacje.Name = "btnUsunRezerwacje";
            this.btnUsunRezerwacje.Size = new System.Drawing.Size(270, 34);
            this.btnUsunRezerwacje.TabIndex = 12;
            this.btnUsunRezerwacje.Text = "Usuń Rezerwację";
            this.btnUsunRezerwacje.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(20, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 25);
            this.label7.TabIndex = 0;
            this.label7.Text = "Prowadzący:";
            // 
            // cbWybranyProwadzacy
            // 
            this.cbWybranyProwadzacy.DisplayMember = "Nazwisko";
            this.cbWybranyProwadzacy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbWybranyProwadzacy.FormattingEnabled = true;
            this.cbWybranyProwadzacy.Location = new System.Drawing.Point(160, 20);
            this.cbWybranyProwadzacy.Name = "cbWybranyProwadzacy";
            this.cbWybranyProwadzacy.Size = new System.Drawing.Size(270, 33);
            this.cbWybranyProwadzacy.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(20, 60);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 25);
            this.label8.TabIndex = 2;
            this.label8.Text = "Sala:";
            // 
            // cbWybranaSala
            // 
            this.cbWybranaSala.DisplayMember = "Numer";
            this.cbWybranaSala.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbWybranaSala.FormattingEnabled = true;
            this.cbWybranaSala.Location = new System.Drawing.Point(160, 60);
            this.cbWybranaSala.Name = "cbWybranaSala";
            this.cbWybranaSala.Size = new System.Drawing.Size(270, 33);
            this.cbWybranaSala.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(20, 100);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 25);
            this.label9.TabIndex = 4;
            this.label9.Text = "Data:";
            // 
            // dtpData
            // 
            this.dtpData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpData.Location = new System.Drawing.Point(160, 100);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(270, 31);
            this.dtpData.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(20, 140);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(119, 25);
            this.label10.TabIndex = 6;
            this.label10.Text = "Godzina Od:";
            // 
            // dtpOd
            // 
            this.dtpOd.CustomFormat = "HH:mm";
            this.dtpOd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpOd.Location = new System.Drawing.Point(160, 140);
            this.dtpOd.Name = "dtpOd";
            this.dtpOd.ShowUpDown = true;
            this.dtpOd.Size = new System.Drawing.Size(270, 31);
            this.dtpOd.TabIndex = 7;
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(20, 180);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(119, 25);
            this.label11.TabIndex = 8;
            this.label11.Text = "Godzina Do:";
            // 
            // dtpDo
            // 
            this.dtpDo.CustomFormat = "HH:mm";
            this.dtpDo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDo.Location = new System.Drawing.Point(160, 180);
            this.dtpDo.Name = "dtpDo";
            this.dtpDo.ShowUpDown = true;
            this.dtpDo.Size = new System.Drawing.Size(270, 31);
            this.dtpDo.TabIndex = 9;
            // 
            // btnDodajRezerwacje
            // 
            this.btnDodajRezerwacje.Location = new System.Drawing.Point(160, 220);
            this.btnDodajRezerwacje.Name = "btnDodajRezerwacje";
            this.btnDodajRezerwacje.Size = new System.Drawing.Size(270, 34);
            this.btnDodajRezerwacje.TabIndex = 10;
            this.btnDodajRezerwacje.Text = "Dodaj Rezerwację";
            this.btnDodajRezerwacje.UseVisualStyleBackColor = true;
            // 
            // lbRezerwacje
            // 
            this.lbRezerwacje.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbRezerwacje.FormattingEnabled = true;
            this.lbRezerwacje.ItemHeight = 25;
            this.lbRezerwacje.Location = new System.Drawing.Point(449, 20);
            this.lbRezerwacje.Name = "lbRezerwacje";
            this.lbRezerwacje.Size = new System.Drawing.Size(619, 404);
            this.lbRezerwacje.TabIndex = 11;
            // 
            // RezerwacjaViewControl
            // 
            this.Controls.Add(this.btnUsunRezerwacje);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbWybranyProwadzacy);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbWybranaSala);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dtpData);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dtpOd);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dtpDo);
            this.Controls.Add(this.btnDodajRezerwacje);
            this.Controls.Add(this.lbRezerwacje);
            this.Name = "RezerwacjaViewControl";
            this.Size = new System.Drawing.Size(1076, 727);
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Button btnUsunRezerwacje;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbWybranyProwadzacy;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbWybranaSala;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtpOd;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dtpDo;
        private System.Windows.Forms.Button btnDodajRezerwacje;
        private System.Windows.Forms.ListBox lbRezerwacje;
    }
}