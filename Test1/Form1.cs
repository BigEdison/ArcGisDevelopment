using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ESRI.ArcGIS.esriSystem;
using ESRI.ArcGIS.Controls;
using ESRI.ArcGIS.Carto;
using ESRI.ArcGIS.SystemUI;
using ESRI.ArcGIS.Display;

namespace Test1
{
    public partial class Form1 : Form
    {
        //构造窗口
        public Form1()
        {
            ESRI.ArcGIS.RuntimeManager.Bind(ESRI.ArcGIS.ProductCode.EngineOrDesktop);
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //axMapControl1.LoadMxFile(Application.StartupPath + "\\Map\\矢量化沙河口.mxd");
            axTOCControl1.SetBuddyControl(axMapControl1);
        }
        #region 文件
        //打开地图
        private void btn_openmxdmap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            //ofd.InitialDirectory = "F:\\矢量化";
            ofd.InitialDirectory = "D:\\ArcGIS\\Desktop10.2\\MapTemplates\\Traditional Layouts";
            ofd.Filter = "Map Document|*.mxd";
            ofd.RestoreDirectory = true;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                IMapControlDefault pMCD;
                pMCD = axMapControl1.Object as IMapControlDefault;
                string strFileName = ofd.FileName;
                bool bRet = pMCD.CheckMxFile(strFileName);
                if (bRet)
                {
                    pMCD.LoadMxFile(strFileName, null, Type.Missing);
                }
            }
        }

        //缩小
        private void BtnZoomOut_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ICommand Cmd = new ControlsMapZoomOutTool();
            Cmd.OnCreate(this.axMapControl1.Object);
            this.axMapControl1.CurrentTool = Cmd as ITool;
        }

        //漫游
        private void BtnPan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ICommand Cmd = new ControlsMapPanTool();
            Cmd.OnCreate(this.axMapControl1.Object);
            this.axMapControl1.CurrentTool = Cmd as ITool;
        }

        //选择
        private void BtnSelect_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ICommand Cmd = new ControlsSelectTool();
            Cmd.OnCreate(this.axMapControl1.Object);
            this.axMapControl1.CurrentTool = Cmd as ITool;
        }

        //放大
        private void BtnZoomIn_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ICommand Cmd = new ControlsMapZoomInTool();
            Cmd.OnCreate(this.axMapControl1.Object);
            this.axMapControl1.CurrentTool = Cmd as ITool;
        }

        //属性
        private void BtnIdentify_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ICommand Cmd = new ControlsMapIdentifyTool();
            Cmd.OnCreate(this.axMapControl1.Object);
            this.axMapControl1.CurrentTool = Cmd as ITool;
        }

        //测量
        private void BtnMeasure_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ICommand Cmd = new ControlsMapMeasureTool();
            Cmd.OnCreate(this.axMapControl1.Object);
            this.axMapControl1.CurrentTool = Cmd as ITool;
        }

        //选择要素
        private void BtnSelectFeatures_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ICommand Cmd = new ControlsSelectFeaturesTool();
            Cmd.OnCreate(this.axMapControl1.Object);
            this.axMapControl1.CurrentTool = Cmd as ITool;
        }
        #endregion 
        #region 工具
        //刷新地图
        private void BtnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            axMapControl1.Refresh();
        }

        //全图显示
        private void BtnMapFull_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ICommand Cmd = new ControlsMapFullExtentCommand();
            Cmd.OnCreate(this.axMapControl1.Object);
            Cmd.OnClick();
        }

        //前一视图
        private void BtnMapZoomForward_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ICommand Cmd = new ControlsMapZoomToLastExtentForwardCommand();
            Cmd.OnCreate(this.axMapControl1.Object);
            Cmd.OnClick();
        }

        //后一视图
        private void BtnMapZoomBack_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ICommand Cmd = new ControlsMapZoomToLastExtentBackCommand();
            Cmd.OnCreate(this.axMapControl1.Object);
            Cmd.OnClick();
        }
        #endregion
    }
}
