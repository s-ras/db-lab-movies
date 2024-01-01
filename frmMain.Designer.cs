namespace db_lab_movies
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.rbnMain = new System.Windows.Forms.Ribbon();
            this.Backup_Menu_Item = new System.Windows.Forms.RibbonOrbMenuItem();
            this.Restore_Menu_Item = new System.Windows.Forms.RibbonOrbMenuItem();
            this.Help_Menu_Item = new System.Windows.Forms.RibbonOrbMenuItem();
            this.About_Menu_Item = new System.Windows.Forms.RibbonOrbMenuItem();
            this.Exit_Menu_Item = new System.Windows.Forms.RibbonOrbMenuItem();
            this.person_tab = new System.Windows.Forms.RibbonTab();
            this.rbnpAddPerson = new System.Windows.Forms.RibbonPanel();
            this.btnAddPerson = new System.Windows.Forms.RibbonButton();
            this.rbnpDeletePerson = new System.Windows.Forms.RibbonPanel();
            this.btnDeletePerson = new System.Windows.Forms.RibbonButton();
            this.rbnpEditPerson = new System.Windows.Forms.RibbonPanel();
            this.btnEditPerson = new System.Windows.Forms.RibbonButton();
            this.rbnpSearchPerson = new System.Windows.Forms.RibbonPanel();
            this.txtSearchPerson = new System.Windows.Forms.RibbonTextBox();
            this.rbnpPrintPerson = new System.Windows.Forms.RibbonPanel();
            this.btnPrintPerson = new System.Windows.Forms.RibbonButton();
            this.movie_tab = new System.Windows.Forms.RibbonTab();
            this.rbnpAddMovie = new System.Windows.Forms.RibbonPanel();
            this.btnAddMovie = new System.Windows.Forms.RibbonButton();
            this.rbnpDeleteMovie = new System.Windows.Forms.RibbonPanel();
            this.btnDeleteMovie = new System.Windows.Forms.RibbonButton();
            this.rbnpEditMovie = new System.Windows.Forms.RibbonPanel();
            this.btnEditMovie = new System.Windows.Forms.RibbonButton();
            this.rbnpSearchMovie = new System.Windows.Forms.RibbonPanel();
            this.txtSearchMovie = new System.Windows.Forms.RibbonTextBox();
            this.rbnpPrintMovie = new System.Windows.Forms.RibbonPanel();
            this.btnPrintMovie = new System.Windows.Forms.RibbonButton();
            this.dtgView = new System.Windows.Forms.DataGridView();
            this.backupFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.restoreFileDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dtgView)).BeginInit();
            this.SuspendLayout();
            // 
            // rbnMain
            // 
            this.rbnMain.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.rbnMain.Location = new System.Drawing.Point(0, 0);
            this.rbnMain.Minimized = false;
            this.rbnMain.Name = "rbnMain";
            // 
            // 
            // 
            this.rbnMain.OrbDropDown.BorderRoundness = 8;
            this.rbnMain.OrbDropDown.Location = new System.Drawing.Point(0, 0);
            this.rbnMain.OrbDropDown.MenuItems.Add(this.Backup_Menu_Item);
            this.rbnMain.OrbDropDown.MenuItems.Add(this.Restore_Menu_Item);
            this.rbnMain.OrbDropDown.MenuItems.Add(this.Help_Menu_Item);
            this.rbnMain.OrbDropDown.MenuItems.Add(this.About_Menu_Item);
            this.rbnMain.OrbDropDown.MenuItems.Add(this.Exit_Menu_Item);
            this.rbnMain.OrbDropDown.Name = "";
            this.rbnMain.OrbDropDown.Size = new System.Drawing.Size(527, 292);
            this.rbnMain.OrbDropDown.TabIndex = 0;
            this.rbnMain.OrbImage = null;
            this.rbnMain.RibbonTabFont = new System.Drawing.Font("Trebuchet MS", 9F);
            this.rbnMain.Size = new System.Drawing.Size(800, 145);
            this.rbnMain.TabIndex = 0;
            this.rbnMain.Tabs.Add(this.person_tab);
            this.rbnMain.Tabs.Add(this.movie_tab);
            this.rbnMain.TabsMargin = new System.Windows.Forms.Padding(12, 26, 20, 0);
            this.rbnMain.ThemeColor = System.Windows.Forms.RibbonTheme.Blue;
            this.rbnMain.ActiveTabChanged += new System.EventHandler(this.rbnMain_ActiveTabChanged);
            // 
            // Backup_Menu_Item
            // 
            this.Backup_Menu_Item.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.Backup_Menu_Item.Image = ((System.Drawing.Image)(resources.GetObject("Backup_Menu_Item.Image")));
            this.Backup_Menu_Item.SmallImage = ((System.Drawing.Image)(resources.GetObject("Backup_Menu_Item.SmallImage")));
            this.Backup_Menu_Item.Text = "Backup";
            this.Backup_Menu_Item.Click += new System.EventHandler(this.Backup_Menu_Item_Click);
            // 
            // Restore_Menu_Item
            // 
            this.Restore_Menu_Item.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.Restore_Menu_Item.Image = ((System.Drawing.Image)(resources.GetObject("Restore_Menu_Item.Image")));
            this.Restore_Menu_Item.SmallImage = ((System.Drawing.Image)(resources.GetObject("Restore_Menu_Item.SmallImage")));
            this.Restore_Menu_Item.Text = "Restore";
            this.Restore_Menu_Item.Click += new System.EventHandler(this.Restore_Menu_Item_Click);
            // 
            // Help_Menu_Item
            // 
            this.Help_Menu_Item.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.Help_Menu_Item.Image = ((System.Drawing.Image)(resources.GetObject("Help_Menu_Item.Image")));
            this.Help_Menu_Item.SmallImage = ((System.Drawing.Image)(resources.GetObject("Help_Menu_Item.SmallImage")));
            this.Help_Menu_Item.Text = "Help";
            // 
            // About_Menu_Item
            // 
            this.About_Menu_Item.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.About_Menu_Item.Image = ((System.Drawing.Image)(resources.GetObject("About_Menu_Item.Image")));
            this.About_Menu_Item.SmallImage = ((System.Drawing.Image)(resources.GetObject("About_Menu_Item.SmallImage")));
            this.About_Menu_Item.Text = "About";
            // 
            // Exit_Menu_Item
            // 
            this.Exit_Menu_Item.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.Exit_Menu_Item.Image = ((System.Drawing.Image)(resources.GetObject("Exit_Menu_Item.Image")));
            this.Exit_Menu_Item.SmallImage = ((System.Drawing.Image)(resources.GetObject("Exit_Menu_Item.SmallImage")));
            this.Exit_Menu_Item.Text = "Exit";
            this.Exit_Menu_Item.Click += new System.EventHandler(this.Exit_Menu_Item_Click);
            // 
            // person_tab
            // 
            this.person_tab.Panels.Add(this.rbnpAddPerson);
            this.person_tab.Panels.Add(this.rbnpDeletePerson);
            this.person_tab.Panels.Add(this.rbnpEditPerson);
            this.person_tab.Panels.Add(this.rbnpSearchPerson);
            this.person_tab.Panels.Add(this.rbnpPrintPerson);
            this.person_tab.Text = "Persons";
            // 
            // rbnpAddPerson
            // 
            this.rbnpAddPerson.Items.Add(this.btnAddPerson);
            this.rbnpAddPerson.Text = "Add Person";
            // 
            // btnAddPerson
            // 
            this.btnAddPerson.Image = ((System.Drawing.Image)(resources.GetObject("btnAddPerson.Image")));
            this.btnAddPerson.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnAddPerson.SmallImage")));
            this.btnAddPerson.Text = "";
            this.btnAddPerson.Click += new System.EventHandler(this.btnAddPerson_Click);
            // 
            // rbnpDeletePerson
            // 
            this.rbnpDeletePerson.Items.Add(this.btnDeletePerson);
            this.rbnpDeletePerson.Text = "Delete Person";
            // 
            // btnDeletePerson
            // 
            this.btnDeletePerson.Image = ((System.Drawing.Image)(resources.GetObject("btnDeletePerson.Image")));
            this.btnDeletePerson.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnDeletePerson.SmallImage")));
            this.btnDeletePerson.Text = "";
            this.btnDeletePerson.Click += new System.EventHandler(this.btnDeletePerson_Click);
            // 
            // rbnpEditPerson
            // 
            this.rbnpEditPerson.Items.Add(this.btnEditPerson);
            this.rbnpEditPerson.Text = "Edit Person";
            // 
            // btnEditPerson
            // 
            this.btnEditPerson.Image = ((System.Drawing.Image)(resources.GetObject("btnEditPerson.Image")));
            this.btnEditPerson.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnEditPerson.SmallImage")));
            this.btnEditPerson.Text = "";
            this.btnEditPerson.Click += new System.EventHandler(this.btnEditPerson_Click);
            // 
            // rbnpSearchPerson
            // 
            this.rbnpSearchPerson.Items.Add(this.txtSearchPerson);
            this.rbnpSearchPerson.Text = "Search Person";
            // 
            // txtSearchPerson
            // 
            this.txtSearchPerson.Text = "";
            this.txtSearchPerson.TextBoxText = "";
            this.txtSearchPerson.TextBoxTextChanged += new System.EventHandler(this.txtSearchPerson_TextBoxTextChanged);
            // 
            // rbnpPrintPerson
            // 
            this.rbnpPrintPerson.Items.Add(this.btnPrintPerson);
            this.rbnpPrintPerson.Text = "Print";
            // 
            // btnPrintPerson
            // 
            this.btnPrintPerson.Image = ((System.Drawing.Image)(resources.GetObject("btnPrintPerson.Image")));
            this.btnPrintPerson.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnPrintPerson.SmallImage")));
            this.btnPrintPerson.Text = "";
            this.btnPrintPerson.Click += new System.EventHandler(this.btnPrintPerson_Click);
            // 
            // movie_tab
            // 
            this.movie_tab.Panels.Add(this.rbnpAddMovie);
            this.movie_tab.Panels.Add(this.rbnpDeleteMovie);
            this.movie_tab.Panels.Add(this.rbnpEditMovie);
            this.movie_tab.Panels.Add(this.rbnpSearchMovie);
            this.movie_tab.Panels.Add(this.rbnpPrintMovie);
            this.movie_tab.Text = "Movies";
            // 
            // rbnpAddMovie
            // 
            this.rbnpAddMovie.Items.Add(this.btnAddMovie);
            this.rbnpAddMovie.Text = "Add Movie";
            // 
            // btnAddMovie
            // 
            this.btnAddMovie.Image = ((System.Drawing.Image)(resources.GetObject("btnAddMovie.Image")));
            this.btnAddMovie.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnAddMovie.SmallImage")));
            this.btnAddMovie.Text = "";
            // 
            // rbnpDeleteMovie
            // 
            this.rbnpDeleteMovie.Items.Add(this.btnDeleteMovie);
            this.rbnpDeleteMovie.Text = "Delete Movie";
            // 
            // btnDeleteMovie
            // 
            this.btnDeleteMovie.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteMovie.Image")));
            this.btnDeleteMovie.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnDeleteMovie.SmallImage")));
            this.btnDeleteMovie.Text = "";
            // 
            // rbnpEditMovie
            // 
            this.rbnpEditMovie.Items.Add(this.btnEditMovie);
            this.rbnpEditMovie.Text = "Edit Movie";
            // 
            // btnEditMovie
            // 
            this.btnEditMovie.Image = ((System.Drawing.Image)(resources.GetObject("btnEditMovie.Image")));
            this.btnEditMovie.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnEditMovie.SmallImage")));
            this.btnEditMovie.Text = "";
            // 
            // rbnpSearchMovie
            // 
            this.rbnpSearchMovie.Items.Add(this.txtSearchMovie);
            this.rbnpSearchMovie.Text = "Search Movie";
            // 
            // txtSearchMovie
            // 
            this.txtSearchMovie.Text = "";
            this.txtSearchMovie.TextBoxText = "";
            // 
            // rbnpPrintMovie
            // 
            this.rbnpPrintMovie.Items.Add(this.btnPrintMovie);
            this.rbnpPrintMovie.Text = "Print";
            // 
            // btnPrintMovie
            // 
            this.btnPrintMovie.Image = ((System.Drawing.Image)(resources.GetObject("btnPrintMovie.Image")));
            this.btnPrintMovie.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnPrintMovie.SmallImage")));
            this.btnPrintMovie.Text = "";
            // 
            // dtgView
            // 
            this.dtgView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgView.Location = new System.Drawing.Point(0, 145);
            this.dtgView.Name = "dtgView";
            this.dtgView.RowHeadersWidth = 51;
            this.dtgView.RowTemplate.Height = 24;
            this.dtgView.Size = new System.Drawing.Size(800, 305);
            this.dtgView.TabIndex = 1;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtgView);
            this.Controls.Add(this.rbnMain);
            this.Name = "frmMain";
            this.Text = "MainWindow";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dtgView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Ribbon rbnMain;
        private System.Windows.Forms.RibbonOrbMenuItem Backup_Menu_Item;
        private System.Windows.Forms.RibbonOrbMenuItem Restore_Menu_Item;
        private System.Windows.Forms.RibbonOrbMenuItem Help_Menu_Item;
        private System.Windows.Forms.RibbonOrbMenuItem About_Menu_Item;
        private System.Windows.Forms.RibbonOrbMenuItem Exit_Menu_Item;
        private System.Windows.Forms.RibbonTab person_tab;
        private System.Windows.Forms.RibbonPanel rbnpAddPerson;
        private System.Windows.Forms.RibbonButton btnAddPerson;
        private System.Windows.Forms.RibbonPanel rbnpDeletePerson;
        private System.Windows.Forms.RibbonPanel rbnpEditPerson;
        private System.Windows.Forms.RibbonPanel rbnpSearchPerson;
        private System.Windows.Forms.RibbonButton btnDeletePerson;
        private System.Windows.Forms.RibbonButton btnEditPerson;
        private System.Windows.Forms.RibbonTextBox txtSearchPerson;
        private System.Windows.Forms.DataGridView dtgView;
        private System.Windows.Forms.SaveFileDialog backupFileDialog;
        private System.Windows.Forms.OpenFileDialog restoreFileDialog;
        private System.Windows.Forms.RibbonPanel rbnpPrintPerson;
        private System.Windows.Forms.RibbonButton btnPrintPerson;
        private System.Windows.Forms.RibbonTab movie_tab;
        private System.Windows.Forms.RibbonPanel rbnpAddMovie;
        private System.Windows.Forms.RibbonPanel rbnpDeleteMovie;
        private System.Windows.Forms.RibbonPanel rbnpEditMovie;
        private System.Windows.Forms.RibbonPanel rbnpSearchMovie;
        private System.Windows.Forms.RibbonPanel rbnpPrintMovie;
        private System.Windows.Forms.RibbonButton btnAddMovie;
        private System.Windows.Forms.RibbonButton btnDeleteMovie;
        private System.Windows.Forms.RibbonButton btnEditMovie;
        private System.Windows.Forms.RibbonTextBox txtSearchMovie;
        private System.Windows.Forms.RibbonButton btnPrintMovie;
    }
}

