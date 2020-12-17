namespace Site_Yonetim_Otomasyonu.Screens
{
    partial class MainForm
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
            DevExpress.XtraEditors.TileItemElement tileItemElement1 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement2 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement3 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement4 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement5 = new DevExpress.XtraEditors.TileItemElement();
            this.tileBar = new DevExpress.XtraBars.Navigation.TileBar();
            this.tileBarGroupTables = new DevExpress.XtraBars.Navigation.TileBarGroup();
            this.homePageTileBarItem = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.homeTileBarItem = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.carBarItem = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.duesBarItem = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.personBarItem = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.navigationFrame = new DevExpress.XtraBars.Navigation.NavigationFrame();
            this.homePageNavigationPage = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.homeNavigationPage = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.carNavigationPage = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.duesNavigationPage = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.personNavigationPage = new DevExpress.XtraBars.Navigation.NavigationPage();
            ((System.ComponentModel.ISupportInitialize)(this.navigationFrame)).BeginInit();
            this.navigationFrame.SuspendLayout();
            this.SuspendLayout();
            // 
            // tileBar
            // 
            this.tileBar.AllowGlyphSkinning = true;
            this.tileBar.AllowSelectedItem = true;
            this.tileBar.AppearanceGroupText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.tileBar.AppearanceGroupText.Options.UseForeColor = true;
            this.tileBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.tileBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.tileBar.DropDownButtonWidth = 30;
            this.tileBar.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            this.tileBar.Groups.Add(this.tileBarGroupTables);
            this.tileBar.IndentBetweenGroups = 10;
            this.tileBar.IndentBetweenItems = 10;
            this.tileBar.ItemPadding = new System.Windows.Forms.Padding(8, 6, 12, 6);
            this.tileBar.Location = new System.Drawing.Point(0, 0);
            this.tileBar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tileBar.MaxId = 6;
            this.tileBar.MaximumSize = new System.Drawing.Size(0, 110);
            this.tileBar.MinimumSize = new System.Drawing.Size(100, 110);
            this.tileBar.Name = "tileBar";
            this.tileBar.Padding = new System.Windows.Forms.Padding(29, 11, 29, 11);
            this.tileBar.ScrollMode = DevExpress.XtraEditors.TileControlScrollMode.None;
            this.tileBar.SelectedItem = this.homePageTileBarItem;
            this.tileBar.SelectionBorderWidth = 2;
            this.tileBar.SelectionColorMode = DevExpress.XtraBars.Navigation.SelectionColorMode.UseItemBackColor;
            this.tileBar.ShowGroupText = false;
            this.tileBar.Size = new System.Drawing.Size(1316, 110);
            this.tileBar.TabIndex = 1;
            this.tileBar.Text = "tileBar";
            this.tileBar.WideTileWidth = 150;
            this.tileBar.SelectedItemChanged += new DevExpress.XtraEditors.TileItemClickEventHandler(this.tileBar_SelectedItemChanged);
            // 
            // tileBarGroupTables
            // 
            this.tileBarGroupTables.Items.Add(this.homePageTileBarItem);
            this.tileBarGroupTables.Items.Add(this.homeTileBarItem);
            this.tileBarGroupTables.Items.Add(this.carBarItem);
            this.tileBarGroupTables.Items.Add(this.duesBarItem);
            this.tileBarGroupTables.Items.Add(this.personBarItem);
            this.tileBarGroupTables.Name = "tileBarGroupTables";
            this.tileBarGroupTables.Text = "TABLES";
            // 
            // homePageTileBarItem
            // 
            this.homePageTileBarItem.AppearanceItem.Normal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(111)))), ((int)(((byte)(166)))));
            this.homePageTileBarItem.AppearanceItem.Normal.Options.UseBackColor = true;
            this.homePageTileBarItem.DropDownOptions.BeakColor = System.Drawing.Color.Red;
            tileItemElement1.ImageOptions.Image = global::Site_Yonetim_Otomasyonu.Properties.Resources.icons8_home_32px;
            tileItemElement1.Text = "Anasayfa";
            this.homePageTileBarItem.Elements.Add(tileItemElement1);
            this.homePageTileBarItem.Name = "homePageTileBarItem";
            // 
            // homeTileBarItem
            // 
            this.homeTileBarItem.AppearanceItem.Normal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(144)))), ((int)(((byte)(191)))));
            this.homeTileBarItem.AppearanceItem.Normal.Options.UseBackColor = true;
            this.homeTileBarItem.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement2.ImageOptions.Image = global::Site_Yonetim_Otomasyonu.Properties.Resources.icons8_apartment_32px;
            tileItemElement2.Text = "Daire";
            this.homeTileBarItem.Elements.Add(tileItemElement2);
            this.homeTileBarItem.Id = 2;
            this.homeTileBarItem.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
            this.homeTileBarItem.Name = "homeTileBarItem";
            // 
            // carBarItem
            // 
            this.carBarItem.AppearanceItem.Normal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(187)))), ((int)(((byte)(216)))));
            this.carBarItem.AppearanceItem.Normal.Options.UseBackColor = true;
            this.carBarItem.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement3.ImageOptions.Image = global::Site_Yonetim_Otomasyonu.Properties.Resources.icons8_car_32px;
            tileItemElement3.Text = "Araç";
            this.carBarItem.Elements.Add(tileItemElement3);
            this.carBarItem.Id = 3;
            this.carBarItem.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
            this.carBarItem.Name = "carBarItem";
            // 
            // duesBarItem
            // 
            this.duesBarItem.AppearanceItem.Normal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(149)))), ((int)(((byte)(89)))));
            this.duesBarItem.AppearanceItem.Normal.Options.UseBackColor = true;
            this.duesBarItem.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement4.ImageOptions.Image = global::Site_Yonetim_Otomasyonu.Properties.Resources.icons8_paper_money_32px;
            tileItemElement4.Text = "Aidat";
            this.duesBarItem.Elements.Add(tileItemElement4);
            this.duesBarItem.Id = 4;
            this.duesBarItem.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
            this.duesBarItem.Name = "duesBarItem";
            // 
            // personBarItem
            // 
            this.personBarItem.AppearanceItem.Normal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(79)))), ((int)(((byte)(47)))));
            this.personBarItem.AppearanceItem.Normal.Options.UseBackColor = true;
            this.personBarItem.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement5.ImageOptions.Image = global::Site_Yonetim_Otomasyonu.Properties.Resources.icons8_person_32px;
            tileItemElement5.Text = "Kişi";
            this.personBarItem.Elements.Add(tileItemElement5);
            this.personBarItem.Id = 5;
            this.personBarItem.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
            this.personBarItem.Name = "personBarItem";
            // 
            // navigationFrame
            // 
            this.navigationFrame.Controls.Add(this.homePageNavigationPage);
            this.navigationFrame.Controls.Add(this.homeNavigationPage);
            this.navigationFrame.Controls.Add(this.carNavigationPage);
            this.navigationFrame.Controls.Add(this.duesNavigationPage);
            this.navigationFrame.Controls.Add(this.personNavigationPage);
            this.navigationFrame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navigationFrame.Location = new System.Drawing.Point(0, 110);
            this.navigationFrame.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.navigationFrame.Name = "navigationFrame";
            this.navigationFrame.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.homePageNavigationPage,
            this.homeNavigationPage,
            this.carNavigationPage,
            this.duesNavigationPage,
            this.personNavigationPage});
            this.navigationFrame.SelectedPage = this.homePageNavigationPage;
            this.navigationFrame.Size = new System.Drawing.Size(1316, 753);
            this.navigationFrame.TabIndex = 0;
            this.navigationFrame.Text = "navigationFrame";
            // 
            // homePageNavigationPage
            // 
            this.homePageNavigationPage.Name = "homePageNavigationPage";
            this.homePageNavigationPage.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(111)))), ((int)(((byte)(166)))));
            this.homePageNavigationPage.Size = new System.Drawing.Size(1316, 753);
            // 
            // homeNavigationPage
            // 
            this.homeNavigationPage.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(144)))), ((int)(((byte)(191)))));
            this.homeNavigationPage.Appearance.Options.UseBackColor = true;
            this.homeNavigationPage.Caption = "homeNavigationPage";
            this.homeNavigationPage.Name = "homeNavigationPage";
            this.homeNavigationPage.Size = new System.Drawing.Size(1316, 753);
            // 
            // carNavigationPage
            // 
            this.carNavigationPage.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(187)))), ((int)(((byte)(216)))));
            this.carNavigationPage.Appearance.Options.UseBackColor = true;
            this.carNavigationPage.Caption = "carNavigationPage";
            this.carNavigationPage.Name = "carNavigationPage";
            this.carNavigationPage.Size = new System.Drawing.Size(1316, 753);
            // 
            // duesNavigationPage
            // 
            this.duesNavigationPage.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(149)))), ((int)(((byte)(89)))));
            this.duesNavigationPage.Appearance.Options.UseBackColor = true;
            this.duesNavigationPage.Caption = "duesNavigationPage";
            this.duesNavigationPage.Name = "duesNavigationPage";
            this.duesNavigationPage.Size = new System.Drawing.Size(1316, 753);
            // 
            // personNavigationPage
            // 
            this.personNavigationPage.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(79)))), ((int)(((byte)(47)))));
            this.personNavigationPage.Appearance.Options.UseBackColor = true;
            this.personNavigationPage.Caption = "personNavigationPage";
            this.personNavigationPage.Name = "personNavigationPage";
            this.personNavigationPage.Size = new System.Drawing.Size(1316, 753);
            // 
            // MainForm
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1316, 863);
            this.Controls.Add(this.navigationFrame);
            this.Controls.Add(this.tileBar);
            this.IconOptions.Image = global::Site_Yonetim_Otomasyonu.Properties.Resources.icons8_apartment_250px;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Site Yonetim Otomasyonu";
            ((System.ComponentModel.ISupportInitialize)(this.navigationFrame)).EndInit();
            this.navigationFrame.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Navigation.TileBar tileBar;
        private DevExpress.XtraBars.Navigation.NavigationFrame navigationFrame;
        private DevExpress.XtraBars.Navigation.TileBarGroup tileBarGroupTables;




        private DevExpress.XtraBars.Navigation.TileBarItem homePageTileBarItem;
        private DevExpress.XtraBars.Navigation.TileBarItem homeTileBarItem;
        private DevExpress.XtraBars.Navigation.TileBarItem carBarItem;
        private DevExpress.XtraBars.Navigation.TileBarItem duesBarItem;
        private DevExpress.XtraBars.Navigation.TileBarItem personBarItem;

        private DevExpress.XtraBars.Navigation.NavigationPage homePageNavigationPage;
        private DevExpress.XtraBars.Navigation.NavigationPage homeNavigationPage;
        private DevExpress.XtraBars.Navigation.NavigationPage carNavigationPage;
        private DevExpress.XtraBars.Navigation.NavigationPage duesNavigationPage;
        private DevExpress.XtraBars.Navigation.NavigationPage personNavigationPage;

    }
}