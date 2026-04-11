namespace RezerwacjaSalMVP
{
    partial class MainForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabSale = new System.Windows.Forms.TabPage();
            this.tabProwadzacy = new System.Windows.Forms.TabPage();
            this.tabRezerwacje = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabSale);
            this.tabControl1.Controls.Add(this.tabProwadzacy);
            this.tabControl1.Controls.Add(this.tabRezerwacje);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1084, 765);
            this.tabControl1.TabIndex = 0;
            // 
            // tabSale
            // 
            this.tabSale.Location = new System.Drawing.Point(4, 34);
            this.tabSale.Name = "tabSale";
            this.tabSale.Padding = new System.Windows.Forms.Padding(3);
            this.tabSale.Size = new System.Drawing.Size(1076, 727);
            this.tabSale.TabIndex = 0;
            this.tabSale.Text = "Sale";
            this.tabSale.UseVisualStyleBackColor = true;
            // 
            // tabProwadzacy
            // 
            this.tabProwadzacy.Location = new System.Drawing.Point(4, 34);
            this.tabProwadzacy.Name = "tabProwadzacy";
            this.tabProwadzacy.Padding = new System.Windows.Forms.Padding(3);
            this.tabProwadzacy.Size = new System.Drawing.Size(1076, 727);
            this.tabProwadzacy.TabIndex = 1;
            this.tabProwadzacy.Text = "Prowadzący";
            this.tabProwadzacy.UseVisualStyleBackColor = true;
            // 
            // tabRezerwacje
            // 
            this.tabRezerwacje.Location = new System.Drawing.Point(4, 34);
            this.tabRezerwacje.Name = "tabRezerwacje";
            this.tabRezerwacje.Padding = new System.Windows.Forms.Padding(3);
            this.tabRezerwacje.Size = new System.Drawing.Size(1076, 727);
            this.tabRezerwacje.TabIndex = 2;
            this.tabRezerwacje.Text = "Rezerwacje";
            this.tabRezerwacje.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 765);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rezerwacja Sal - MVP";
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabSale;
        private System.Windows.Forms.TabPage tabProwadzacy;
        private System.Windows.Forms.TabPage tabRezerwacje;
    }
}
