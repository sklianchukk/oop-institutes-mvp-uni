namespace RezerwacjaSalMVP.Views
{
    partial class SalaViewControl
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
            this.btnUsunSale = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNazwaWydzialu = new System.Windows.Forms.TextBox();
            this.lblUlica = new System.Windows.Forms.Label();
            this.txtUlica = new System.Windows.Forms.TextBox();
            this.lblMiasto = new System.Windows.Forms.Label();
            this.txtMiasto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNumerSali = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.numIloscMiejsc = new System.Windows.Forms.NumericUpDown();
            this.lblTypSali = new System.Windows.Forms.Label();
            this.cbTypSali = new System.Windows.Forms.ComboBox();
            this.btnDodajSale = new System.Windows.Forms.Button();
            this.lbSale = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.numIloscMiejsc)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUsunSale
            // 
            this.btnUsunSale.Location = new System.Drawing.Point(158, 325);
            this.btnUsunSale.Name = "btnUsunSale";
            this.btnUsunSale.Size = new System.Drawing.Size(262, 34);
            this.btnUsunSale.TabIndex = 8;
            this.btnUsunSale.Text = "Usuń Salę";
            this.btnUsunSale.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Wydział:";
            // 
            // txtNazwaWydzialu
            // 
            this.txtNazwaWydzialu.Location = new System.Drawing.Point(158, 20);
            this.txtNazwaWydzialu.Name = "txtNazwaWydzialu";
            this.txtNazwaWydzialu.Size = new System.Drawing.Size(262, 31);
            this.txtNazwaWydzialu.TabIndex = 1;
            // 
            // lblUlica
            // 
            this.lblUlica.Location = new System.Drawing.Point(20, 112);
            this.lblUlica.Name = "lblUlica";
            this.lblUlica.Size = new System.Drawing.Size(132, 25);
            this.lblUlica.TabIndex = 9;
            this.lblUlica.Text = "Adres:";
            // 
            // txtUlica
            // 
            this.txtUlica.Location = new System.Drawing.Point(158, 112);
            this.txtUlica.Name = "txtUlica";
            this.txtUlica.Size = new System.Drawing.Size(262, 31);
            this.txtUlica.TabIndex = 10;
            // 
            // lblMiasto
            // 
            this.lblMiasto.Location = new System.Drawing.Point(20, 66);
            this.lblMiasto.Name = "lblMiasto";
            this.lblMiasto.Size = new System.Drawing.Size(132, 25);
            this.lblMiasto.TabIndex = 11;
            this.lblMiasto.Text = "Miasto:";
            // 
            // txtMiasto
            // 
            this.txtMiasto.Location = new System.Drawing.Point(158, 66);
            this.txtMiasto.Name = "txtMiasto";
            this.txtMiasto.Size = new System.Drawing.Size(262, 31);
            this.txtMiasto.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(20, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Numer Sali:";
            // 
            // txtNumerSali
            // 
            this.txtNumerSali.Location = new System.Drawing.Point(158, 155);
            this.txtNumerSali.Name = "txtNumerSali";
            this.txtNumerSali.Size = new System.Drawing.Size(262, 31);
            this.txtNumerSali.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(20, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ilość Miejsc:";
            // 
            // numIloscMiejsc
            // 
            this.numIloscMiejsc.Location = new System.Drawing.Point(158, 198);
            this.numIloscMiejsc.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            this.numIloscMiejsc.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.numIloscMiejsc.Name = "numIloscMiejsc";
            this.numIloscMiejsc.Size = new System.Drawing.Size(262, 31);
            this.numIloscMiejsc.TabIndex = 5;
            this.numIloscMiejsc.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblTypSali
            // 
            this.lblTypSali.Location = new System.Drawing.Point(20, 235);
            this.lblTypSali.Name = "lblTypSali";
            this.lblTypSali.Size = new System.Drawing.Size(120, 25);
            this.lblTypSali.TabIndex = 15;
            this.lblTypSali.Text = "Typ Sali:";
            // 
            // cbTypSali
            // 
            this.cbTypSali.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTypSali.Location = new System.Drawing.Point(158, 235);
            this.cbTypSali.Name = "cbTypSali";
            this.cbTypSali.Size = new System.Drawing.Size(262, 33);
            this.cbTypSali.TabIndex = 16;
            // 
            // btnDodajSale
            // 
            this.btnDodajSale.Location = new System.Drawing.Point(158, 275);
            this.btnDodajSale.Name = "btnDodajSale";
            this.btnDodajSale.Size = new System.Drawing.Size(262, 34);
            this.btnDodajSale.TabIndex = 6;
            this.btnDodajSale.Text = "Dodaj Salę";
            this.btnDodajSale.UseVisualStyleBackColor = true;
            // 
            // lbSale
            // 
            this.lbSale.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbSale.FormattingEnabled = true;
            this.lbSale.ItemHeight = 25;
            this.lbSale.Location = new System.Drawing.Point(445, 20);
            this.lbSale.Name = "lbSale";
            this.lbSale.Size = new System.Drawing.Size(623, 404);
            this.lbSale.TabIndex = 7;
            // 
            // SalaViewControl
            // 
            this.Controls.Add(this.btnUsunSale);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNazwaWydzialu);
            this.Controls.Add(this.lblUlica);
            this.Controls.Add(this.txtUlica);
            this.Controls.Add(this.lblMiasto);
            this.Controls.Add(this.txtMiasto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNumerSali);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numIloscMiejsc);
            this.Controls.Add(this.lblTypSali);
            this.Controls.Add(this.cbTypSali);
            this.Controls.Add(this.btnDodajSale);
            this.Controls.Add(this.lbSale);
            this.Name = "SalaViewControl";
            this.Size = new System.Drawing.Size(1076, 727);
            ((System.ComponentModel.ISupportInitialize)(this.numIloscMiejsc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Button btnUsunSale;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNazwaWydzialu;
        private System.Windows.Forms.Label lblUlica;
        private System.Windows.Forms.TextBox txtUlica;
        private System.Windows.Forms.Label lblMiasto;
        private System.Windows.Forms.TextBox txtMiasto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNumerSali;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numIloscMiejsc;
        private System.Windows.Forms.Label lblTypSali;
        private System.Windows.Forms.ComboBox cbTypSali;
        private System.Windows.Forms.Button btnDodajSale;
        private System.Windows.Forms.ListBox lbSale;
    }
}
