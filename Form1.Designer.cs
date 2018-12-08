namespace OgrenciBilgi
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.öĞRENCİİŞLEMLERİToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.öĞRENCİEKLEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.öĞRENCİSİLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.öĞRENCİDÜZENLEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.öĞRENCİLİSTESİToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bÖLÜMİŞLEMLERİToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bÖLÜMEKLEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bÖLÜMDÜZENLEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bÖLÜMSİLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bÖLÜMLİSTELEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fAKÜLTEİŞLEMLERİToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fAKÜLTEEKLEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fAKÜLTEDÜZENLEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fAKÜLTESİLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fAKÜLTELİSTELEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.universite1 = new OgrenciBilgi.Universite();
            this.ogrencilerTableAdapter1 = new OgrenciBilgi.UniversiteTableAdapters.OgrencilerTableAdapter();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.universite1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.öĞRENCİİŞLEMLERİToolStripMenuItem,
            this.bÖLÜMİŞLEMLERİToolStripMenuItem,
            this.fAKÜLTEİŞLEMLERİToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1103, 28);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // öĞRENCİİŞLEMLERİToolStripMenuItem
            // 
            this.öĞRENCİİŞLEMLERİToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.öĞRENCİEKLEToolStripMenuItem,
            this.öĞRENCİSİLToolStripMenuItem,
            this.öĞRENCİDÜZENLEToolStripMenuItem,
            this.öĞRENCİLİSTESİToolStripMenuItem});
            this.öĞRENCİİŞLEMLERİToolStripMenuItem.Name = "öĞRENCİİŞLEMLERİToolStripMenuItem";
            this.öĞRENCİİŞLEMLERİToolStripMenuItem.Size = new System.Drawing.Size(155, 24);
            this.öĞRENCİİŞLEMLERİToolStripMenuItem.Text = "ÖĞRENCİ İŞLEMLERİ";
            // 
            // öĞRENCİEKLEToolStripMenuItem
            // 
            this.öĞRENCİEKLEToolStripMenuItem.Name = "öĞRENCİEKLEToolStripMenuItem";
            this.öĞRENCİEKLEToolStripMenuItem.Size = new System.Drawing.Size(214, 26);
            this.öĞRENCİEKLEToolStripMenuItem.Text = "ÖĞRENCİ EKLE";
            this.öĞRENCİEKLEToolStripMenuItem.Click += new System.EventHandler(this.button4_Click);
            // 
            // öĞRENCİSİLToolStripMenuItem
            // 
            this.öĞRENCİSİLToolStripMenuItem.Name = "öĞRENCİSİLToolStripMenuItem";
            this.öĞRENCİSİLToolStripMenuItem.Size = new System.Drawing.Size(214, 26);
            this.öĞRENCİSİLToolStripMenuItem.Text = "ÖĞRENCİ SİL";
            this.öĞRENCİSİLToolStripMenuItem.Click += new System.EventHandler(this.öĞRENCİSİLToolStripMenuItem_Click);
            // 
            // öĞRENCİDÜZENLEToolStripMenuItem
            // 
            this.öĞRENCİDÜZENLEToolStripMenuItem.Name = "öĞRENCİDÜZENLEToolStripMenuItem";
            this.öĞRENCİDÜZENLEToolStripMenuItem.Size = new System.Drawing.Size(214, 26);
            this.öĞRENCİDÜZENLEToolStripMenuItem.Text = "ÖĞRENCİ DÜZENLE";
            this.öĞRENCİDÜZENLEToolStripMenuItem.Click += new System.EventHandler(this.öĞRENCİDÜZENLEToolStripMenuItem_Click);
            // 
            // öĞRENCİLİSTESİToolStripMenuItem
            // 
            this.öĞRENCİLİSTESİToolStripMenuItem.Name = "öĞRENCİLİSTESİToolStripMenuItem";
            this.öĞRENCİLİSTESİToolStripMenuItem.Size = new System.Drawing.Size(214, 26);
            this.öĞRENCİLİSTESİToolStripMenuItem.Text = "ÖĞRENCİ LİSTESİ";
            this.öĞRENCİLİSTESİToolStripMenuItem.Click += new System.EventHandler(this.öĞRENCİLİSTESİToolStripMenuItem_Click);
            // 
            // bÖLÜMİŞLEMLERİToolStripMenuItem
            // 
            this.bÖLÜMİŞLEMLERİToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bÖLÜMEKLEToolStripMenuItem,
            this.bÖLÜMDÜZENLEToolStripMenuItem,
            this.bÖLÜMSİLToolStripMenuItem,
            this.bÖLÜMLİSTELEToolStripMenuItem});
            this.bÖLÜMİŞLEMLERİToolStripMenuItem.Name = "bÖLÜMİŞLEMLERİToolStripMenuItem";
            this.bÖLÜMİŞLEMLERİToolStripMenuItem.Size = new System.Drawing.Size(143, 24);
            this.bÖLÜMİŞLEMLERİToolStripMenuItem.Text = "BÖLÜM İŞLEMLERİ";
            // 
            // bÖLÜMEKLEToolStripMenuItem
            // 
            this.bÖLÜMEKLEToolStripMenuItem.Name = "bÖLÜMEKLEToolStripMenuItem";
            this.bÖLÜMEKLEToolStripMenuItem.Size = new System.Drawing.Size(202, 26);
            this.bÖLÜMEKLEToolStripMenuItem.Text = "BÖLÜM EKLE";
            this.bÖLÜMEKLEToolStripMenuItem.Click += new System.EventHandler(this.bÖLÜMEKLEToolStripMenuItem_Click);
            // 
            // bÖLÜMDÜZENLEToolStripMenuItem
            // 
            this.bÖLÜMDÜZENLEToolStripMenuItem.Name = "bÖLÜMDÜZENLEToolStripMenuItem";
            this.bÖLÜMDÜZENLEToolStripMenuItem.Size = new System.Drawing.Size(202, 26);
            this.bÖLÜMDÜZENLEToolStripMenuItem.Text = "BÖLÜM DÜZENLE";
            // 
            // bÖLÜMSİLToolStripMenuItem
            // 
            this.bÖLÜMSİLToolStripMenuItem.Name = "bÖLÜMSİLToolStripMenuItem";
            this.bÖLÜMSİLToolStripMenuItem.Size = new System.Drawing.Size(202, 26);
            this.bÖLÜMSİLToolStripMenuItem.Text = "BÖLÜM SİL";
            // 
            // bÖLÜMLİSTELEToolStripMenuItem
            // 
            this.bÖLÜMLİSTELEToolStripMenuItem.Name = "bÖLÜMLİSTELEToolStripMenuItem";
            this.bÖLÜMLİSTELEToolStripMenuItem.Size = new System.Drawing.Size(202, 26);
            this.bÖLÜMLİSTELEToolStripMenuItem.Text = "BÖLÜM LİSTELE";
            // 
            // fAKÜLTEİŞLEMLERİToolStripMenuItem
            // 
            this.fAKÜLTEİŞLEMLERİToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fAKÜLTEEKLEToolStripMenuItem,
            this.fAKÜLTEDÜZENLEToolStripMenuItem,
            this.fAKÜLTESİLToolStripMenuItem,
            this.fAKÜLTELİSTELEToolStripMenuItem});
            this.fAKÜLTEİŞLEMLERİToolStripMenuItem.Name = "fAKÜLTEİŞLEMLERİToolStripMenuItem";
            this.fAKÜLTEİŞLEMLERİToolStripMenuItem.Size = new System.Drawing.Size(150, 24);
            this.fAKÜLTEİŞLEMLERİToolStripMenuItem.Text = "FAKÜLTE İŞLEMLERİ";
            // 
            // fAKÜLTEEKLEToolStripMenuItem
            // 
            this.fAKÜLTEEKLEToolStripMenuItem.Name = "fAKÜLTEEKLEToolStripMenuItem";
            this.fAKÜLTEEKLEToolStripMenuItem.Size = new System.Drawing.Size(209, 26);
            this.fAKÜLTEEKLEToolStripMenuItem.Text = "FAKÜLTE EKLE";
            this.fAKÜLTEEKLEToolStripMenuItem.Click += new System.EventHandler(this.fAKÜLTEEKLEToolStripMenuItem_Click);
            // 
            // fAKÜLTEDÜZENLEToolStripMenuItem
            // 
            this.fAKÜLTEDÜZENLEToolStripMenuItem.Name = "fAKÜLTEDÜZENLEToolStripMenuItem";
            this.fAKÜLTEDÜZENLEToolStripMenuItem.Size = new System.Drawing.Size(209, 26);
            this.fAKÜLTEDÜZENLEToolStripMenuItem.Text = "FAKÜLTE DÜZENLE";
            // 
            // fAKÜLTESİLToolStripMenuItem
            // 
            this.fAKÜLTESİLToolStripMenuItem.Name = "fAKÜLTESİLToolStripMenuItem";
            this.fAKÜLTESİLToolStripMenuItem.Size = new System.Drawing.Size(209, 26);
            this.fAKÜLTESİLToolStripMenuItem.Text = "FAKÜLTE SİL";
            // 
            // fAKÜLTELİSTELEToolStripMenuItem
            // 
            this.fAKÜLTELİSTELEToolStripMenuItem.Name = "fAKÜLTELİSTELEToolStripMenuItem";
            this.fAKÜLTELİSTELEToolStripMenuItem.Size = new System.Drawing.Size(209, 26);
            this.fAKÜLTELİSTELEToolStripMenuItem.Text = "FAKÜLTE LİSTELE";
            // 
            // universite1
            // 
            this.universite1.DataSetName = "Universite";
            this.universite1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ogrencilerTableAdapter1
            // 
            this.ogrencilerTableAdapter1.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1103, 621);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ÖĞRENCİ İŞLEMLERİ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.universite1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem öĞRENCİİŞLEMLERİToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem öĞRENCİEKLEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem öĞRENCİSİLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem öĞRENCİDÜZENLEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem öĞRENCİLİSTESİToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bÖLÜMİŞLEMLERİToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bÖLÜMEKLEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bÖLÜMDÜZENLEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bÖLÜMSİLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bÖLÜMLİSTELEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fAKÜLTEİŞLEMLERİToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fAKÜLTEEKLEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fAKÜLTEDÜZENLEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fAKÜLTESİLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fAKÜLTELİSTELEToolStripMenuItem;
        private Universite universite1;
        private UniversiteTableAdapters.OgrencilerTableAdapter ogrencilerTableAdapter1;
    }
}

