namespace MultiMega_Client
{
    partial class FormMultiMegaClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMultiMegaClient));
            this.ribbonTab1 = new System.Windows.Forms.RibbonTab();
            this.ribbonPanel1 = new System.Windows.Forms.RibbonPanel();
            this.bt_manageaccounts = new System.Windows.Forms.RibbonButton();
            this.ribbonPanel2 = new System.Windows.Forms.RibbonPanel();
            this.bt_downloadfile = new System.Windows.Forms.RibbonButton();
            this.bt_uploadfile = new System.Windows.Forms.RibbonButton();
            this.bt_deletefile = new System.Windows.Forms.RibbonButton();
            this.bt_createfolder = new System.Windows.Forms.RibbonButton();
            this.bt_deletefolder = new System.Windows.Forms.RibbonButton();
            this.bt_parentfolder = new System.Windows.Forms.RibbonButton();
            this.listView1 = new System.Windows.Forms.ListView();
            this.ribbon1 = new System.Windows.Forms.Ribbon();
            this.lbl_status = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribbonTab1
            // 
            this.ribbonTab1.Panels.Add(this.ribbonPanel1);
            this.ribbonTab1.Panels.Add(this.ribbonPanel2);
            this.ribbonTab1.Text = "Menu";
            // 
            // ribbonPanel1
            // 
            this.ribbonPanel1.Items.Add(this.bt_manageaccounts);
            this.ribbonPanel1.Text = "Manage Accounts";
            // 
            // bt_manageaccounts
            // 
            this.bt_manageaccounts.Image = ((System.Drawing.Image)(resources.GetObject("bt_manageaccounts.Image")));
            this.bt_manageaccounts.SmallImage = ((System.Drawing.Image)(resources.GetObject("bt_manageaccounts.SmallImage")));
            this.bt_manageaccounts.ToolTip = "Manage Accounts";
            this.bt_manageaccounts.Click += new System.EventHandler(this.bt_manageaccounts_Click);
            // 
            // ribbonPanel2
            // 
            this.ribbonPanel2.Items.Add(this.bt_downloadfile);
            this.ribbonPanel2.Items.Add(this.bt_uploadfile);
            this.ribbonPanel2.Items.Add(this.bt_deletefile);
            this.ribbonPanel2.Items.Add(this.bt_createfolder);
            this.ribbonPanel2.Items.Add(this.bt_deletefolder);
            this.ribbonPanel2.Items.Add(this.bt_parentfolder);
            this.ribbonPanel2.Text = "Operations with accounts";
            // 
            // bt_downloadfile
            // 
            this.bt_downloadfile.Image = ((System.Drawing.Image)(resources.GetObject("bt_downloadfile.Image")));
            this.bt_downloadfile.SmallImage = ((System.Drawing.Image)(resources.GetObject("bt_downloadfile.SmallImage")));
            this.bt_downloadfile.ToolTip = "Download a file";
            this.bt_downloadfile.Click += new System.EventHandler(this.bt_downloadfile_Click);
            // 
            // bt_uploadfile
            // 
            this.bt_uploadfile.Image = ((System.Drawing.Image)(resources.GetObject("bt_uploadfile.Image")));
            this.bt_uploadfile.SmallImage = ((System.Drawing.Image)(resources.GetObject("bt_uploadfile.SmallImage")));
            this.bt_uploadfile.ToolTip = "Upload a file";
            this.bt_uploadfile.Click += new System.EventHandler(this.bt_uploadfile_Click);
            // 
            // bt_deletefile
            // 
            this.bt_deletefile.Image = ((System.Drawing.Image)(resources.GetObject("bt_deletefile.Image")));
            this.bt_deletefile.SmallImage = ((System.Drawing.Image)(resources.GetObject("bt_deletefile.SmallImage")));
            this.bt_deletefile.ToolTip = "Delete file";
            this.bt_deletefile.Click += new System.EventHandler(this.bt_deletefile_Click);
            // 
            // bt_createfolder
            // 
            this.bt_createfolder.Image = ((System.Drawing.Image)(resources.GetObject("bt_createfolder.Image")));
            this.bt_createfolder.SmallImage = ((System.Drawing.Image)(resources.GetObject("bt_createfolder.SmallImage")));
            this.bt_createfolder.ToolTip = "Create folder";
            this.bt_createfolder.Click += new System.EventHandler(this.bt_createfolder_Click);
            // 
            // bt_deletefolder
            // 
            this.bt_deletefolder.Image = ((System.Drawing.Image)(resources.GetObject("bt_deletefolder.Image")));
            this.bt_deletefolder.SmallImage = ((System.Drawing.Image)(resources.GetObject("bt_deletefolder.SmallImage")));
            this.bt_deletefolder.ToolTip = "Delete folder";
            this.bt_deletefolder.Click += new System.EventHandler(this.bt_deletefolder_Click);
            // 
            // bt_parentfolder
            // 
            this.bt_parentfolder.Image = ((System.Drawing.Image)(resources.GetObject("bt_parentfolder.Image")));
            this.bt_parentfolder.SmallImage = ((System.Drawing.Image)(resources.GetObject("bt_parentfolder.SmallImage")));
            this.bt_parentfolder.ToolTip = "Go to parent folder";
            this.bt_parentfolder.Click += new System.EventHandler(this.bt_parentfolder_Click);
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.Location = new System.Drawing.Point(12, 159);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(847, 277);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Tile;
            this.listView1.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
            // 
            // ribbon1
            // 
            this.ribbon1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ribbon1.Location = new System.Drawing.Point(0, 0);
            this.ribbon1.Minimized = false;
            this.ribbon1.Name = "ribbon1";
            // 
            // 
            // 
            this.ribbon1.OrbDropDown.BorderRoundness = 8;
            this.ribbon1.OrbDropDown.Location = new System.Drawing.Point(0, 0);
            this.ribbon1.OrbDropDown.Name = "";
            this.ribbon1.OrbDropDown.Size = new System.Drawing.Size(527, 447);
            this.ribbon1.OrbDropDown.TabIndex = 0;
            this.ribbon1.OrbImage = null;
            this.ribbon1.OrbStyle = System.Windows.Forms.RibbonOrbStyle.Office_2013;
            this.ribbon1.OrbVisible = false;
            this.ribbon1.RibbonTabFont = new System.Drawing.Font("Trebuchet MS", 9F);
            this.ribbon1.Size = new System.Drawing.Size(871, 153);
            this.ribbon1.TabIndex = 1;
            this.ribbon1.Tabs.Add(this.ribbonTab1);
            this.ribbon1.TabsMargin = new System.Windows.Forms.Padding(12, 26, 20, 0);
            this.ribbon1.Text = "ribbon1";
            this.ribbon1.ThemeColor = System.Windows.Forms.RibbonTheme.Blue;
            // 
            // lbl_status
            // 
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(66, 17);
            this.lbl_status.Text = "No Activity";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbl_status});
            this.statusStrip1.Location = new System.Drawing.Point(0, 439);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.statusStrip1.Size = new System.Drawing.Size(871, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // FormMultiMegaClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 461);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.ribbon1);
            this.Controls.Add(this.listView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMultiMegaClient";
            this.Text = "MultiCloud Client";
            this.Load += new System.EventHandler(this.FormMultiMegaClient_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RibbonTab ribbonTab1;
        private System.Windows.Forms.RibbonPanel ribbonPanel1;
        private System.Windows.Forms.RibbonButton bt_manageaccounts;
        private System.Windows.Forms.RibbonPanel ribbonPanel2;
        private System.Windows.Forms.RibbonButton bt_downloadfile;
        private System.Windows.Forms.RibbonButton bt_uploadfile;
        private System.Windows.Forms.RibbonButton bt_createfolder;
        private System.Windows.Forms.RibbonButton bt_deletefolder;
        private System.Windows.Forms.RibbonButton bt_parentfolder;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Ribbon ribbon1;
        private System.Windows.Forms.ToolStripStatusLabel lbl_status;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.RibbonButton bt_deletefile;
    }
}

