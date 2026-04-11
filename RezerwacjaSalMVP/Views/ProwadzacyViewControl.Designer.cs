namespace RezerwacjaSalMVP.Views
{
    partial class ProwadzacyViewControl
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
            this.btnUsunProwadzacego = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtImie = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNazwisko = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnDodajProwadzacego = new System.Windows.Forms.Button();
            this.lbProwadzacy = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnUsunProwadzacego
            // 
            this.btnUsunProwadzacego.Location = new System.Drawing.Point(165, 194);
            this.btnUsunProwadzacego.Name = "btnUsunProwadzacego";
            this.btnUsunProwadzacego.Size = new System.Drawing.Size(259, 34);
            this.btnUsunProwadzacego.TabIndex = 8;
            this.btnUsunProwadzacego.Text = "Usuń Prowadzącego";
            this.btnUsunProwadzacego.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(20, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Imię:";
            // 
            // txtImie
            // 
            this.txtImie.Location = new System.Drawing.Point(165, 20);
            this.txtImie.Name = "txtImie";
            this.txtImie.Size = new System.Drawing.Size(259, 31);
            this.txtImie.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(20, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 25);
            this.label5.TabIndex = 2;
            this.label5.Text = "Nazwisko:";
            // 
            // txtNazwisko
            // 
            this.txtNazwisko.Location = new System.Drawing.Point(165, 60);
            this.txtNazwisko.Name = "txtNazwisko";
            this.txtNazwisko.Size = new System.Drawing.Size(259, 31);
            this.txtNazwisko.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(20, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 25);
            this.label6.TabIndex = 4;
            this.label6.Text = "Email:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(165, 100);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(259, 31);
            this.txtEmail.TabIndex = 5;
            // 
            // btnDodajProwadzacego
            // 
            this.btnDodajProwadzacego.Location = new System.Drawing.Point(165, 140);
            this.btnDodajProwadzacego.Name = "btnDodajProwadzacego";
            this.btnDodajProwadzacego.Size = new System.Drawing.Size(259, 34);
            this.btnDodajProwadzacego.TabIndex = 6;
            this.btnDodajProwadzacego.Text = "Dodaj Prowadzącego";
            this.btnDodajProwadzacego.UseVisualStyleBackColor = true;
            // 
            // lbProwadzacy
            // 
            this.lbProwadzacy.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbProwadzacy.FormattingEnabled = true;
            this.lbProwadzacy.ItemHeight = 25;
            this.lbProwadzacy.Location = new System.Drawing.Point(451, 20);
            this.lbProwadzacy.Name = "lbProwadzacy";
            this.lbProwadzacy.Size = new System.Drawing.Size(617, 404);
            this.lbProwadzacy.TabIndex = 7;
            // 
            // ProwadzacyViewControl
            // 
            this.Controls.Add(this.btnUsunProwadzacego);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtImie);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNazwisko);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.btnDodajProwadzacego);
            this.Controls.Add(this.lbProwadzacy);
            this.Name = "ProwadzacyViewControl";
            this.Size = new System.Drawing.Size(1076, 727);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Button btnUsunProwadzacego;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtImie;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNazwisko;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnDodajProwadzacego;
        private System.Windows.Forms.ListBox lbProwadzacy;
    }
}