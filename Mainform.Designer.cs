namespace Ulfi
{
    partial class Mainform
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mainform));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.addFilterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeFilterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editFilterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importFiltersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportFiltersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Dateiaufmachdialog = new System.Windows.Forms.OpenFileDialog();
            this.Dateispeicherdialog = new System.Windows.Forms.SaveFileDialog();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.Gesamtelemente = new System.Windows.Forms.ToolStripStatusLabel();
            this.Anzeigelemente = new System.Windows.Forms.ToolStripStatusLabel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.Filterliste = new System.Windows.Forms.ListBox();
            this.Filtercontextmenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.Logdatei = new System.Windows.Forms.ListBox();
            this.Logkontextmenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.openFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFilteredFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openInNotepadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Filterimportdialog = new System.Windows.Forms.OpenFileDialog();
            this.Filterexportdialog = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.Filtercontextmenu.SuspendLayout();
            this.Logkontextmenu.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addFilterToolStripMenuItem,
            this.removeFilterToolStripMenuItem,
            this.editFilterToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.importFiltersToolStripMenuItem,
            this.exportFiltersToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 24);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(741, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // addFilterToolStripMenuItem
            // 
            this.addFilterToolStripMenuItem.Name = "addFilterToolStripMenuItem";
            this.addFilterToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.addFilterToolStripMenuItem.Text = global::Ulfi.Properties.Settings.Default.addfilter;
            this.addFilterToolStripMenuItem.Click += new System.EventHandler(this.addFilterToolStripMenuItem_Click);
            // 
            // removeFilterToolStripMenuItem
            // 
            this.removeFilterToolStripMenuItem.Name = "removeFilterToolStripMenuItem";
            this.removeFilterToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.removeFilterToolStripMenuItem.Text = global::Ulfi.Properties.Settings.Default.removefilter;
            this.removeFilterToolStripMenuItem.Click += new System.EventHandler(this.removeFilterToolStripMenuItem_Click);
            // 
            // editFilterToolStripMenuItem
            // 
            this.editFilterToolStripMenuItem.Name = "editFilterToolStripMenuItem";
            this.editFilterToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.editFilterToolStripMenuItem.Text = global::Ulfi.Properties.Settings.Default.editfilter;
            this.editFilterToolStripMenuItem.Click += new System.EventHandler(this.editFilterToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.helpToolStripMenuItem.Text = global::Ulfi.Properties.Settings.Default.clearfilters;
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // importFiltersToolStripMenuItem
            // 
            this.importFiltersToolStripMenuItem.Name = "importFiltersToolStripMenuItem";
            this.importFiltersToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.importFiltersToolStripMenuItem.Text = "&Import filters";
            this.importFiltersToolStripMenuItem.Click += new System.EventHandler(this.importFiltersToolStripMenuItem_Click);
            // 
            // exportFiltersToolStripMenuItem
            // 
            this.exportFiltersToolStripMenuItem.Name = "exportFiltersToolStripMenuItem";
            this.exportFiltersToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.exportFiltersToolStripMenuItem.Text = "E&xport filters";
            this.exportFiltersToolStripMenuItem.Click += new System.EventHandler(this.exportFiltersToolStripMenuItem_Click);
            // 
            // Dateiaufmachdialog
            // 
            this.Dateiaufmachdialog.Filter = "Common log files(*.txt;*.log)|*.txt;*.log|All files (*.*)|*";
            // 
            // Dateispeicherdialog
            // 
            this.Dateispeicherdialog.Filter = "Text files(*.txt)|*.txt|Log files(*.log)|*.log|All files (*.*)|*";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Gesamtelemente,
            this.Anzeigelemente});
            this.statusStrip1.Location = new System.Drawing.Point(0, 446);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(741, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // Gesamtelemente
            // 
            this.Gesamtelemente.Name = "Gesamtelemente";
            this.Gesamtelemente.Size = new System.Drawing.Size(0, 17);
            // 
            // Anzeigelemente
            // 
            this.Anzeigelemente.Name = "Anzeigelemente";
            this.Anzeigelemente.Size = new System.Drawing.Size(0, 17);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 48);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.Filterliste);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.Logdatei);
            this.splitContainer1.Size = new System.Drawing.Size(741, 398);
            this.splitContainer1.SplitterDistance = 247;
            this.splitContainer1.TabIndex = 2;
            // 
            // Filterliste
            // 
            this.Filterliste.ContextMenuStrip = this.Filtercontextmenu;
            this.Filterliste.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Filterliste.FormattingEnabled = true;
            this.Filterliste.Location = new System.Drawing.Point(0, 0);
            this.Filterliste.Name = "Filterliste";
            this.Filterliste.Size = new System.Drawing.Size(247, 398);
            this.Filterliste.Sorted = true;
            this.Filterliste.TabIndex = 0;
            this.Filterliste.DoubleClick += new System.EventHandler(this.Filterliste_DoubleClick);
            this.Filterliste.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Filterliste_MouseDown);
            // 
            // Filtercontextmenu
            // 
            this.Filtercontextmenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem4});
            this.Filtercontextmenu.Name = "Filtercontextmenu";
            this.Filtercontextmenu.Size = new System.Drawing.Size(145, 70);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(144, 22);
            this.toolStripMenuItem1.Text = global::Ulfi.Properties.Settings.Default.addfilter;
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click_1);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(144, 22);
            this.toolStripMenuItem2.Text = global::Ulfi.Properties.Settings.Default.removefilter;
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(144, 22);
            this.toolStripMenuItem4.Text = global::Ulfi.Properties.Settings.Default.clearfilters;
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // Logdatei
            // 
            this.Logdatei.ContextMenuStrip = this.Logkontextmenu;
            this.Logdatei.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Logdatei.FormattingEnabled = true;
            this.Logdatei.Location = new System.Drawing.Point(0, 0);
            this.Logdatei.Name = "Logdatei";
            this.Logdatei.Size = new System.Drawing.Size(490, 398);
            this.Logdatei.TabIndex = 0;
            this.Logdatei.DoubleClick += new System.EventHandler(this.Logdatei_DoubleClick);
            this.Logdatei.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Logdatei_MouseDown);
            // 
            // Logkontextmenu
            // 
            this.Logkontextmenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem6,
            this.toolStripMenuItem7});
            this.Logkontextmenu.Name = "Logkontextmenu";
            this.Logkontextmenu.Size = new System.Drawing.Size(115, 48);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(114, 22);
            this.toolStripMenuItem6.Text = "&Include";
            this.toolStripMenuItem6.Click += new System.EventHandler(this.toolStripMenuItem6_Click);
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(114, 22);
            this.toolStripMenuItem7.Text = "&Exclude";
            this.toolStripMenuItem7.Click += new System.EventHandler(this.toolStripMenuItem7_Click);
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFileToolStripMenuItem,
            this.saveFilteredFileToolStripMenuItem,
            this.openInNotepadToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(741, 24);
            this.menuStrip2.TabIndex = 3;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // openFileToolStripMenuItem
            // 
            this.openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
            this.openFileToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.openFileToolStripMenuItem.Text = "&Open file";
            this.openFileToolStripMenuItem.Click += new System.EventHandler(this.openFileToolStripMenuItem_Click);
            // 
            // saveFilteredFileToolStripMenuItem
            // 
            this.saveFilteredFileToolStripMenuItem.Name = "saveFilteredFileToolStripMenuItem";
            this.saveFilteredFileToolStripMenuItem.Size = new System.Drawing.Size(102, 20);
            this.saveFilteredFileToolStripMenuItem.Text = "&Save filtered file";
            this.saveFilteredFileToolStripMenuItem.Click += new System.EventHandler(this.saveFilteredFileToolStripMenuItem_Click);
            // 
            // openInNotepadToolStripMenuItem
            // 
            this.openInNotepadToolStripMenuItem.Enabled = false;
            this.openInNotepadToolStripMenuItem.Name = "openInNotepadToolStripMenuItem";
            this.openInNotepadToolStripMenuItem.Size = new System.Drawing.Size(110, 20);
            this.openInNotepadToolStripMenuItem.Text = "Open in &Notepad";
            this.openInNotepadToolStripMenuItem.Click += new System.EventHandler(this.openInNotepadToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "A&bout";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // Filterimportdialog
            // 
            this.Filterimportdialog.DefaultExt = "ulfi";
            this.Filterimportdialog.Filter = "Ulfi files (*.ulfi)|*.ulfi|Text files (*.txt)|*.txt|All files (*.*)|*";
            // 
            // Filterexportdialog
            // 
            this.Filterexportdialog.DefaultExt = "ulfi";
            this.Filterexportdialog.Filter = "Ulfi files (*.ulfi)|*.ulfi|Text files (*.txt)|*.txt|All files (*.*)|*.* ";
            // 
            // Mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 468);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Mainform";
            this.Text = "Universal log filter";
            this.Shown += new System.EventHandler(this.GUI_Shown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.Filtercontextmenu.ResumeLayout(false);
            this.Logkontextmenu.ResumeLayout(false);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addFilterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeFilterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editFilterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog Dateiaufmachdialog;
        private System.Windows.Forms.SaveFileDialog Dateispeicherdialog;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel Gesamtelemente;
        private System.Windows.Forms.ToolStripStatusLabel Anzeigelemente;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListBox Filterliste;
        private System.Windows.Forms.ListBox Logdatei;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem openFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveFilteredFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openInNotepadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportFiltersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importFiltersToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog Filterimportdialog;
        private System.Windows.Forms.SaveFileDialog Filterexportdialog;
        private System.Windows.Forms.ContextMenuStrip Filtercontextmenu;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ContextMenuStrip Logkontextmenu;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}

