namespace Test1
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btn_openmxdmap = new DevExpress.XtraBars.BarButtonItem();
            this.BtnZoomIn = new DevExpress.XtraBars.BarButtonItem();
            this.BtnZoomOut = new DevExpress.XtraBars.BarButtonItem();
            this.BtnPan = new DevExpress.XtraBars.BarButtonItem();
            this.BtnSelect = new DevExpress.XtraBars.BarButtonItem();
            this.BtnIdentify = new DevExpress.XtraBars.BarButtonItem();
            this.BtnMeasure = new DevExpress.XtraBars.BarButtonItem();
            this.BtnSelectFeatures = new DevExpress.XtraBars.BarButtonItem();
            this.BtnRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.BtnMapFull = new DevExpress.XtraBars.BarButtonItem();
            this.BtnMapZoomForward = new DevExpress.XtraBars.BarButtonItem();
            this.BtnMapZoomBack = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonMiniToolbar1 = new DevExpress.XtraBars.Ribbon.RibbonMiniToolbar(this.components);
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.dockManager1 = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.dockPanel_lyctrl = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel1_Lyctrl = new DevExpress.XtraBars.Docking.ControlContainer();
            this.axTOCControl1 = new ESRI.ArcGIS.Controls.AxTOCControl();
            this.GroupCtrl_Map = new DevExpress.XtraEditors.GroupControl();
            this.axLicenseControl1 = new ESRI.ArcGIS.Controls.AxLicenseControl();
            this.axMapControl1 = new ESRI.ArcGIS.Controls.AxMapControl();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).BeginInit();
            this.dockPanel_lyctrl.SuspendLayout();
            this.dockPanel1_Lyctrl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axTOCControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GroupCtrl_Map)).BeginInit();
            this.GroupCtrl_Map.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axLicenseControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axMapControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.btn_openmxdmap,
            this.BtnZoomIn,
            this.BtnZoomOut,
            this.BtnPan,
            this.BtnSelect,
            this.BtnIdentify,
            this.BtnMeasure,
            this.BtnSelectFeatures,
            this.BtnRefresh,
            this.BtnMapFull,
            this.BtnMapZoomForward,
            this.BtnMapZoomBack});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 22;
            this.ribbonControl1.MiniToolbars.Add(this.ribbonMiniToolbar1);
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.ribbonPage2});
            this.ribbonControl1.Size = new System.Drawing.Size(888, 145);
            // 
            // btn_openmxdmap
            // 
            this.btn_openmxdmap.Caption = "打开地图";
            this.btn_openmxdmap.Id = 2;
            this.btn_openmxdmap.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btn_openmxdmap.LargeGlyph")));
            this.btn_openmxdmap.Name = "btn_openmxdmap";
            this.btn_openmxdmap.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_openmxdmap_ItemClick);
            // 
            // BtnZoomIn
            // 
            this.BtnZoomIn.Caption = "放大";
            this.BtnZoomIn.Id = 11;
            this.BtnZoomIn.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("BtnZoomIn.LargeGlyph")));
            this.BtnZoomIn.Name = "BtnZoomIn";
            this.BtnZoomIn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnZoomIn_ItemClick_1);
            // 
            // BtnZoomOut
            // 
            this.BtnZoomOut.Caption = "缩小";
            this.BtnZoomOut.Id = 12;
            this.BtnZoomOut.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("BtnZoomOut.LargeGlyph")));
            this.BtnZoomOut.Name = "BtnZoomOut";
            this.BtnZoomOut.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnZoomOut_ItemClick);
            // 
            // BtnPan
            // 
            this.BtnPan.Caption = "漫游";
            this.BtnPan.Id = 13;
            this.BtnPan.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("BtnPan.LargeGlyph")));
            this.BtnPan.Name = "BtnPan";
            this.BtnPan.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnPan_ItemClick);
            // 
            // BtnSelect
            // 
            this.BtnSelect.Caption = "选择";
            this.BtnSelect.Id = 14;
            this.BtnSelect.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("BtnSelect.LargeGlyph")));
            this.BtnSelect.Name = "BtnSelect";
            this.BtnSelect.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnSelect_ItemClick);
            // 
            // BtnIdentify
            // 
            this.BtnIdentify.Caption = "属性";
            this.BtnIdentify.Id = 15;
            this.BtnIdentify.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("BtnIdentify.LargeGlyph")));
            this.BtnIdentify.Name = "BtnIdentify";
            this.BtnIdentify.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnIdentify_ItemClick);
            // 
            // BtnMeasure
            // 
            this.BtnMeasure.Caption = "测量";
            this.BtnMeasure.Id = 16;
            this.BtnMeasure.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("BtnMeasure.LargeGlyph")));
            this.BtnMeasure.Name = "BtnMeasure";
            this.BtnMeasure.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnMeasure_ItemClick);
            // 
            // BtnSelectFeatures
            // 
            this.BtnSelectFeatures.Caption = "选择要素";
            this.BtnSelectFeatures.Id = 17;
            this.BtnSelectFeatures.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("BtnSelectFeatures.LargeGlyph")));
            this.BtnSelectFeatures.Name = "BtnSelectFeatures";
            this.BtnSelectFeatures.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnSelectFeatures_ItemClick);
            // 
            // BtnRefresh
            // 
            this.BtnRefresh.Caption = "地图刷新";
            this.BtnRefresh.Id = 18;
            this.BtnRefresh.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("BtnRefresh.LargeGlyph")));
            this.BtnRefresh.Name = "BtnRefresh";
            this.BtnRefresh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnRefresh_ItemClick);
            // 
            // BtnMapFull
            // 
            this.BtnMapFull.Caption = "全图显示";
            this.BtnMapFull.Id = 19;
            this.BtnMapFull.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("BtnMapFull.LargeGlyph")));
            this.BtnMapFull.Name = "BtnMapFull";
            this.BtnMapFull.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnMapFull_ItemClick);
            // 
            // BtnMapZoomForward
            // 
            this.BtnMapZoomForward.Caption = "前一视图";
            this.BtnMapZoomForward.Id = 20;
            this.BtnMapZoomForward.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("BtnMapZoomForward.LargeGlyph")));
            this.BtnMapZoomForward.Name = "BtnMapZoomForward";
            this.BtnMapZoomForward.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnMapZoomForward_ItemClick);
            // 
            // BtnMapZoomBack
            // 
            this.BtnMapZoomBack.Caption = "后一视图";
            this.BtnMapZoomBack.Id = 21;
            this.BtnMapZoomBack.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("BtnMapZoomBack.LargeGlyph")));
            this.BtnMapZoomBack.Name = "BtnMapZoomBack";
            this.BtnMapZoomBack.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnMapZoomBack_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup3});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "文件";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btn_openmxdmap);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "ribbonPageGroup1";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.BtnZoomIn);
            this.ribbonPageGroup3.ItemLinks.Add(this.BtnZoomOut);
            this.ribbonPageGroup3.ItemLinks.Add(this.BtnPan);
            this.ribbonPageGroup3.ItemLinks.Add(this.BtnSelect);
            this.ribbonPageGroup3.ItemLinks.Add(this.BtnIdentify);
            this.ribbonPageGroup3.ItemLinks.Add(this.BtnMeasure);
            this.ribbonPageGroup3.ItemLinks.Add(this.BtnSelectFeatures);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "ribbonPageGroup3";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2});
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "工具";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.BtnRefresh);
            this.ribbonPageGroup2.ItemLinks.Add(this.BtnMapFull);
            this.ribbonPageGroup2.ItemLinks.Add(this.BtnMapZoomForward);
            this.ribbonPageGroup2.ItemLinks.Add(this.BtnMapZoomBack);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "ribbonPageGroup2";
            // 
            // dockManager1
            // 
            this.dockManager1.Form = this;
            this.dockManager1.RootPanels.AddRange(new DevExpress.XtraBars.Docking.DockPanel[] {
            this.dockPanel_lyctrl});
            this.dockManager1.TopZIndexControls.AddRange(new string[] {
            "DevExpress.XtraBars.BarDockControl",
            "DevExpress.XtraBars.StandaloneBarDockControl",
            "System.Windows.Forms.StatusBar",
            "System.Windows.Forms.MenuStrip",
            "System.Windows.Forms.StatusStrip",
            "DevExpress.XtraBars.Ribbon.RibbonStatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonControl"});
            // 
            // dockPanel_lyctrl
            // 
            this.dockPanel_lyctrl.Controls.Add(this.dockPanel1_Lyctrl);
            this.dockPanel_lyctrl.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left;
            this.dockPanel_lyctrl.ID = new System.Guid("eff4b79d-945a-4926-90cd-cc4bfbebf18d");
            this.dockPanel_lyctrl.Location = new System.Drawing.Point(0, 145);
            this.dockPanel_lyctrl.Name = "dockPanel_lyctrl";
            this.dockPanel_lyctrl.OriginalSize = new System.Drawing.Size(200, 200);
            this.dockPanel_lyctrl.Size = new System.Drawing.Size(200, 247);
            this.dockPanel_lyctrl.Text = "图层控制";
            // 
            // dockPanel1_Lyctrl
            // 
            this.dockPanel1_Lyctrl.Controls.Add(this.axTOCControl1);
            this.dockPanel1_Lyctrl.Location = new System.Drawing.Point(4, 23);
            this.dockPanel1_Lyctrl.Name = "dockPanel1_Lyctrl";
            this.dockPanel1_Lyctrl.Size = new System.Drawing.Size(192, 220);
            this.dockPanel1_Lyctrl.TabIndex = 0;
            // 
            // axTOCControl1
            // 
            this.axTOCControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axTOCControl1.Location = new System.Drawing.Point(0, 0);
            this.axTOCControl1.Name = "axTOCControl1";
            this.axTOCControl1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axTOCControl1.OcxState")));
            this.axTOCControl1.Size = new System.Drawing.Size(192, 220);
            this.axTOCControl1.TabIndex = 0;
            // 
            // GroupCtrl_Map
            // 
            this.GroupCtrl_Map.Controls.Add(this.axLicenseControl1);
            this.GroupCtrl_Map.Controls.Add(this.axMapControl1);
            this.GroupCtrl_Map.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GroupCtrl_Map.Location = new System.Drawing.Point(200, 145);
            this.GroupCtrl_Map.Name = "GroupCtrl_Map";
            this.GroupCtrl_Map.Size = new System.Drawing.Size(688, 247);
            this.GroupCtrl_Map.TabIndex = 1;
            this.GroupCtrl_Map.Text = "地图窗口";
            //this.GroupCtrl_Map.Paint += new System.Windows.Forms.PaintEventHandler(this.GroupCtrl_Map_Paint);
            // 
            // axLicenseControl1
            // 
            this.axLicenseControl1.Enabled = true;
            this.axLicenseControl1.Location = new System.Drawing.Point(299, 25);
            this.axLicenseControl1.Name = "axLicenseControl1";
            this.axLicenseControl1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axLicenseControl1.OcxState")));
            this.axLicenseControl1.Size = new System.Drawing.Size(32, 32);
            this.axLicenseControl1.TabIndex = 1;
            // 
            // axMapControl1
            // 
            this.axMapControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axMapControl1.Location = new System.Drawing.Point(2, 22);
            this.axMapControl1.Name = "axMapControl1";
            this.axMapControl1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axMapControl1.OcxState")));
            this.axMapControl1.Size = new System.Drawing.Size(684, 223);
            this.axMapControl1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 392);
            this.Controls.Add(this.GroupCtrl_Map);
            this.Controls.Add(this.dockPanel_lyctrl);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).EndInit();
            this.dockPanel_lyctrl.ResumeLayout(false);
            this.dockPanel1_Lyctrl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axTOCControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GroupCtrl_Map)).EndInit();
            this.GroupCtrl_Map.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axLicenseControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axMapControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Docking.DockManager dockManager1;
        private DevExpress.XtraEditors.GroupControl GroupCtrl_Map;
        private ESRI.ArcGIS.Controls.AxLicenseControl axLicenseControl1;
        private ESRI.ArcGIS.Controls.AxMapControl axMapControl1;
        private DevExpress.XtraBars.Docking.DockPanel dockPanel_lyctrl;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel1_Lyctrl;
        private ESRI.ArcGIS.Controls.AxTOCControl axTOCControl1;
        private DevExpress.XtraBars.BarButtonItem btn_openmxdmap;
        private DevExpress.XtraBars.BarButtonItem BtnZoomIn;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem BtnZoomOut;
        private DevExpress.XtraBars.BarButtonItem BtnPan;
        private DevExpress.XtraBars.BarButtonItem BtnSelect;
        private DevExpress.XtraBars.Ribbon.RibbonMiniToolbar ribbonMiniToolbar1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarButtonItem BtnIdentify;
        private DevExpress.XtraBars.BarButtonItem BtnMeasure;
        private DevExpress.XtraBars.BarButtonItem BtnSelectFeatures;
        private DevExpress.XtraBars.BarButtonItem BtnRefresh;
        private DevExpress.XtraBars.BarButtonItem BtnMapFull;
        private DevExpress.XtraBars.BarButtonItem BtnMapZoomForward;
        private DevExpress.XtraBars.BarButtonItem BtnMapZoomBack;
    }
}

