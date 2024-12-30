namespace ShopOtomation
{
    partial class MainPage
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.HomeSection = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.SalesSection = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ProductsSection = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.StatsSection = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.StocksSection = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.AuthoritySection = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.SaleButton = new DevExpress.XtraBars.BarButtonItem();
            this.SalePageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.NewSale = new DevExpress.XtraBars.BarButtonItem();
            this.SaleReturn = new DevExpress.XtraBars.BarButtonItem();
            this.AddProduct = new DevExpress.XtraBars.BarButtonItem();
            this.DeleteProduct = new DevExpress.XtraBars.BarButtonItem();
            this.UpdateProduct = new DevExpress.XtraBars.BarButtonItem();
            this.ListProducts = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ListTodaySales = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.SaleButton,
            this.NewSale,
            this.SaleReturn,
            this.AddProduct,
            this.DeleteProduct,
            this.UpdateProduct,
            this.ListProducts,
            this.ListTodaySales});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 11;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.HomeSection,
            this.SalesSection,
            this.ProductsSection,
            this.StocksSection,
            this.StatsSection,
            this.AuthoritySection});
            this.ribbon.Size = new System.Drawing.Size(1171, 181);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // HomeSection
            // 
            this.HomeSection.Appearance.Font = new System.Drawing.Font("Outfit SemiBold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeSection.Appearance.Options.UseFont = true;
            this.HomeSection.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.HomeSection.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("HomeSection.ImageOptions.Image")));
            this.HomeSection.Name = "HomeSection";
            this.HomeSection.Text = " Ana Sayfa";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "ribbonPageGroup1";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 618);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1171, 26);
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "The Bezier";
            // 
            // SalesSection
            // 
            this.SalesSection.Appearance.Font = new System.Drawing.Font("Outfit SemiBold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalesSection.Appearance.Options.UseFont = true;
            this.SalesSection.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.SalePageGroup,
            this.ribbonPageGroup2});
            this.SalesSection.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("SalesSection.ImageOptions.Image")));
            this.SalesSection.Name = "SalesSection";
            this.SalesSection.Text = " Satış";
            // 
            // ProductsSection
            // 
            this.ProductsSection.Appearance.Font = new System.Drawing.Font("Outfit SemiBold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductsSection.Appearance.Options.UseFont = true;
            this.ProductsSection.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup3});
            this.ProductsSection.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ProductsSection.ImageOptions.Image")));
            this.ProductsSection.Name = "ProductsSection";
            this.ProductsSection.Text = " Ürünler";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.AddProduct);
            this.ribbonPageGroup3.ItemLinks.Add(this.DeleteProduct);
            this.ribbonPageGroup3.ItemLinks.Add(this.UpdateProduct);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "ribbonPageGroup3";
            // 
            // StatsSection
            // 
            this.StatsSection.Appearance.Font = new System.Drawing.Font("Outfit SemiBold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatsSection.Appearance.Options.UseFont = true;
            this.StatsSection.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup4});
            this.StatsSection.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("StatsSection.ImageOptions.Image")));
            this.StatsSection.Name = "StatsSection";
            this.StatsSection.Text = " İstatistikler";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "ribbonPageGroup4";
            // 
            // StocksSection
            // 
            this.StocksSection.Appearance.Font = new System.Drawing.Font("Outfit SemiBold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StocksSection.Appearance.Options.UseFont = true;
            this.StocksSection.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup5});
            this.StocksSection.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ribbonPage1.ImageOptions.Image")));
            this.StocksSection.Name = "StocksSection";
            this.StocksSection.Text = " Stok";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.ItemLinks.Add(this.ListProducts);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            this.ribbonPageGroup5.Text = "ribbonPageGroup5";
            // 
            // AuthoritySection
            // 
            this.AuthoritySection.Appearance.Font = new System.Drawing.Font("Outfit SemiBold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AuthoritySection.Appearance.Options.UseFont = true;
            this.AuthoritySection.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup6});
            this.AuthoritySection.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("AuthoritySection.ImageOptions.Image")));
            this.AuthoritySection.Name = "AuthoritySection";
            this.AuthoritySection.Text = " Yetki";
            // 
            // ribbonPageGroup6
            // 
            this.ribbonPageGroup6.Name = "ribbonPageGroup6";
            this.ribbonPageGroup6.Text = "ribbonPageGroup6";
            // 
            // SaleButton
            // 
            this.SaleButton.Caption = "Satış";
            this.SaleButton.Id = 3;
            this.SaleButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("SaleButton.ImageOptions.Image")));
            this.SaleButton.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("SaleButton.ImageOptions.LargeImage")));
            this.SaleButton.Name = "SaleButton";
            // 
            // SalePageGroup
            // 
            this.SalePageGroup.ItemLinks.Add(this.NewSale);
            this.SalePageGroup.ItemLinks.Add(this.SaleReturn);
            this.SalePageGroup.Name = "SalePageGroup";
            // 
            // NewSale
            // 
            this.NewSale.Caption = "Yeni Satış";
            this.NewSale.Id = 4;
            this.NewSale.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
            this.NewSale.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.LargeImage")));
            this.NewSale.ItemAppearance.Hovered.Font = new System.Drawing.Font("Outfit", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewSale.ItemAppearance.Hovered.Options.UseFont = true;
            this.NewSale.ItemAppearance.Normal.Font = new System.Drawing.Font("Outfit", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewSale.ItemAppearance.Normal.Options.UseFont = true;
            this.NewSale.ItemAppearance.Pressed.Font = new System.Drawing.Font("Outfit", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewSale.ItemAppearance.Pressed.Options.UseFont = true;
            this.NewSale.Name = "NewSale";
            // 
            // SaleReturn
            // 
            this.SaleReturn.Caption = "Satış İade";
            this.SaleReturn.Id = 5;
            this.SaleReturn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.Image")));
            this.SaleReturn.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.LargeImage")));
            this.SaleReturn.ItemAppearance.Hovered.Font = new System.Drawing.Font("Outfit", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaleReturn.ItemAppearance.Hovered.Options.UseFont = true;
            this.SaleReturn.ItemAppearance.Normal.Font = new System.Drawing.Font("Outfit", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaleReturn.ItemAppearance.Normal.Options.UseFont = true;
            this.SaleReturn.ItemAppearance.Pressed.Font = new System.Drawing.Font("Outfit", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaleReturn.ItemAppearance.Pressed.Options.UseFont = true;
            this.SaleReturn.Name = "SaleReturn";
            // 
            // AddProduct
            // 
            this.AddProduct.Caption = "Ürün Ekle";
            this.AddProduct.Id = 6;
            this.AddProduct.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.ImageOptions.Image")));
            this.AddProduct.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.ImageOptions.LargeImage")));
            this.AddProduct.ItemAppearance.Hovered.Font = new System.Drawing.Font("Outfit", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddProduct.ItemAppearance.Hovered.Options.UseFont = true;
            this.AddProduct.ItemAppearance.Normal.Font = new System.Drawing.Font("Outfit", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddProduct.ItemAppearance.Normal.Options.UseFont = true;
            this.AddProduct.ItemAppearance.Pressed.Font = new System.Drawing.Font("Outfit", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddProduct.ItemAppearance.Pressed.Options.UseFont = true;
            this.AddProduct.Name = "AddProduct";
            // 
            // DeleteProduct
            // 
            this.DeleteProduct.Caption = "Ürün Kaldır";
            this.DeleteProduct.Id = 7;
            this.DeleteProduct.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem4.ImageOptions.Image")));
            this.DeleteProduct.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem4.ImageOptions.LargeImage")));
            this.DeleteProduct.ItemAppearance.Hovered.Font = new System.Drawing.Font("Outfit", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteProduct.ItemAppearance.Hovered.Options.UseFont = true;
            this.DeleteProduct.ItemAppearance.Normal.Font = new System.Drawing.Font("Outfit", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteProduct.ItemAppearance.Normal.Options.UseFont = true;
            this.DeleteProduct.ItemAppearance.Pressed.Font = new System.Drawing.Font("Outfit", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteProduct.ItemAppearance.Pressed.Options.UseFont = true;
            this.DeleteProduct.Name = "DeleteProduct";
            // 
            // UpdateProduct
            // 
            this.UpdateProduct.Caption = "Ürün Güncelle";
            this.UpdateProduct.Id = 8;
            this.UpdateProduct.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem5.ImageOptions.Image")));
            this.UpdateProduct.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem5.ImageOptions.LargeImage")));
            this.UpdateProduct.ItemAppearance.Hovered.Font = new System.Drawing.Font("Outfit", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateProduct.ItemAppearance.Hovered.Options.UseFont = true;
            this.UpdateProduct.ItemAppearance.Normal.Font = new System.Drawing.Font("Outfit", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateProduct.ItemAppearance.Normal.Options.UseFont = true;
            this.UpdateProduct.ItemAppearance.Pressed.Font = new System.Drawing.Font("Outfit", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateProduct.ItemAppearance.Pressed.Options.UseFont = true;
            this.UpdateProduct.Name = "UpdateProduct";
            // 
            // ListProducts
            // 
            this.ListProducts.Caption = "Ürünleri Listele";
            this.ListProducts.Id = 9;
            this.ListProducts.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ListProducts.ImageOptions.Image")));
            this.ListProducts.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("ListProducts.ImageOptions.LargeImage")));
            this.ListProducts.ItemAppearance.Hovered.Font = new System.Drawing.Font("Outfit", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListProducts.ItemAppearance.Hovered.Options.UseFont = true;
            this.ListProducts.ItemAppearance.Normal.Font = new System.Drawing.Font("Outfit", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListProducts.ItemAppearance.Normal.Options.UseFont = true;
            this.ListProducts.ItemAppearance.Pressed.Font = new System.Drawing.Font("Outfit", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListProducts.ItemAppearance.Pressed.Options.UseFont = true;
            this.ListProducts.Name = "ListProducts";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.ListTodaySales);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            // 
            // ListTodaySales
            // 
            this.ListTodaySales.Caption = "Bugünkü Satışlar";
            this.ListTodaySales.Id = 10;
            this.ListTodaySales.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ListTodaySales.ImageOptions.Image")));
            this.ListTodaySales.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("ListTodaySales.ImageOptions.LargeImage")));
            this.ListTodaySales.ItemAppearance.Hovered.Font = new System.Drawing.Font("Outfit", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListTodaySales.ItemAppearance.Hovered.Options.UseFont = true;
            this.ListTodaySales.ItemAppearance.Normal.Font = new System.Drawing.Font("Outfit", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListTodaySales.ItemAppearance.Normal.Options.UseFont = true;
            this.ListTodaySales.ItemAppearance.Pressed.Font = new System.Drawing.Font("Outfit", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListTodaySales.ItemAppearance.Pressed.Options.UseFont = true;
            this.ListTodaySales.Name = "ListTodaySales";
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1171, 644);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainPage";
            this.Ribbon = this.ribbon;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "MainPage";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage HomeSection;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.XtraBars.Ribbon.RibbonPage SalesSection;
        private DevExpress.XtraBars.Ribbon.RibbonPage ProductsSection;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.Ribbon.RibbonPage StocksSection;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.Ribbon.RibbonPage StatsSection;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.Ribbon.RibbonPage AuthoritySection;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
        private DevExpress.XtraBars.BarButtonItem SaleButton;
        private DevExpress.XtraBars.BarButtonItem NewSale;
        private DevExpress.XtraBars.BarButtonItem SaleReturn;
        private DevExpress.XtraBars.BarButtonItem AddProduct;
        private DevExpress.XtraBars.BarButtonItem DeleteProduct;
        private DevExpress.XtraBars.BarButtonItem UpdateProduct;
        private DevExpress.XtraBars.BarButtonItem ListProducts;
        private DevExpress.XtraBars.BarButtonItem ListTodaySales;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup SalePageGroup;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
    }
}