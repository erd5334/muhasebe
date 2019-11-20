namespace alerd_muhasebe_takip_projesi
{
    partial class MDIParent1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.modüllerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stokToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cariToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.bankaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kasaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.faturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.irsaliyeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modüllerToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1377, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // modüllerToolStripMenuItem
            // 
            this.modüllerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stokToolStripMenuItem,
            this.cariToolStripMenuItem,
            this.bankaToolStripMenuItem,
            this.kasaToolStripMenuItem,
            this.faturaToolStripMenuItem,
            this.irsaliyeToolStripMenuItem});
            this.modüllerToolStripMenuItem.Name = "modüllerToolStripMenuItem";
            this.modüllerToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.modüllerToolStripMenuItem.Text = "Modüller";
            // 
            // stokToolStripMenuItem
            // 
            this.stokToolStripMenuItem.Name = "stokToolStripMenuItem";
            this.stokToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.stokToolStripMenuItem.Text = "Stok";
            this.stokToolStripMenuItem.Click += new System.EventHandler(this.stokToolStripMenuItem_Click);
            // 
            // cariToolStripMenuItem
            // 
            this.cariToolStripMenuItem.Name = "cariToolStripMenuItem";
            this.cariToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cariToolStripMenuItem.Text = "Cari";
            this.cariToolStripMenuItem.Click += new System.EventHandler(this.cariToolStripMenuItem_Click);
            // 
            // bankaToolStripMenuItem
            // 
            this.bankaToolStripMenuItem.Name = "bankaToolStripMenuItem";
            this.bankaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.bankaToolStripMenuItem.Text = "Banka";
            this.bankaToolStripMenuItem.Click += new System.EventHandler(this.bankaToolStripMenuItem_Click);
            // 
            // kasaToolStripMenuItem
            // 
            this.kasaToolStripMenuItem.Name = "kasaToolStripMenuItem";
            this.kasaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.kasaToolStripMenuItem.Text = "Kasa";
            this.kasaToolStripMenuItem.Click += new System.EventHandler(this.kasaToolStripMenuItem_Click);
            // 
            // faturaToolStripMenuItem
            // 
            this.faturaToolStripMenuItem.Name = "faturaToolStripMenuItem";
            this.faturaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.faturaToolStripMenuItem.Text = "Fatura";
            this.faturaToolStripMenuItem.Click += new System.EventHandler(this.faturaToolStripMenuItem_Click);
            // 
            // irsaliyeToolStripMenuItem
            // 
            this.irsaliyeToolStripMenuItem.Name = "irsaliyeToolStripMenuItem";
            this.irsaliyeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.irsaliyeToolStripMenuItem.Text = "İrsaliye";
            this.irsaliyeToolStripMenuItem.Click += new System.EventHandler(this.irsaliyeToolStripMenuItem_Click);
            // 
            // MDIParent1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1377, 560);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MDIParent1";
            this.Text = "Muhasebe";
            this.Load += new System.EventHandler(this.MDIParent1_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem modüllerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stokToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cariToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bankaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kasaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem faturaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem irsaliyeToolStripMenuItem;
    }
}



