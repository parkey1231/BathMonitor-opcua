using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using System.Threading;
using Opc;
using Opc.Ua;
using OpcUaHelper;

namespace BathMonitorSystem
{
    //第一步：创建委托
    //public delegate byte[] CommDelegate(ModTCP modTCP);

    public partial class FrmMain : Form
    {

      //  CommDelegate MyDelegate;
        ModTCP[] objModbusArray = new ModTCP[8];

        public FrmMain()
        {
            InitializeComponent();
            //this.Load += FrmMain_Load;
            //第三步：绑定方法
          //  MyDelegate += GetData;

            btnView_Click(null, null);

            //for (int i = 0; i < objModbusArray.Length; i++)
            //{
            //    objModbusArray[i] = new ModTCP();
            //    //第四步：激活委托
            //    if (objModbusArray[i].Connect("127.0.0.1", "50" + (i + 2).ToString()))
            //    {
            //        Thread.Sleep(100);
            //        MyDelegate.BeginInvoke(objModbusArray[i], MyAsyncCallback, objModbusArray[i]);
            //        CommonMethods.CurrentModbusList[i + 1] = objModbusArray[i];
            //    }

            //}
            InitOpcUaClient();

        }

        private async void InitOpcUaClient()
        {
            CommonMethods.opcUaClient = new OpcUaClient();
            await CommonMethods.opcUaClient.ConnectServer("opc.tcp://118.24.36.220:62547/DataAccessServer");
        }




        private enum ButtonName
        {
            View,
            CtrlProcess,
            ParaSet,
            Alarm,
            Tend,
            Report,
            SysMaintenance,
            OpcView,
            Exit

        }

        //private void FrmMain_Load(object sender, EventArgs e)
        //{
        //    for (int i = 0; i < modbusArray.Length; i++)
        //    {


        //    }

        //}

        //第五步：编写回调函数
        //private void MyAsyncCallback(IAsyncResult asyncResult)
        //{
        //    //获取返回值
        //    byte[] Res = MyDelegate.EndInvoke(asyncResult);
        //    //获取Modbus实例
        //    ModTCP objModbus = (ModTCP)asyncResult.AsyncState;
        //    //解析返回值
        //    FlowData flowData = Analyse(Res);
        //    int index = (from d in CommonMethods.CurrentModbusList where d.Value == objModbus select d.Key).FirstOrDefault();
        //    if (objModbus != null)
        //    {
        //        CommonMethods.CurrentValue[index] = flowData;
        //    }

        //    //第六步：继续激活委托
        //    MyDelegate.BeginInvoke(objModbus, MyAsyncCallback, objModbus);
        //}





        List<ModTCP> modbusList = new List<ModTCP>();






        //第二步：编写委托方法
        private byte[] GetData(ModTCP modTCP)
        {
            try
            {
                return modTCP.ReadKeepReg(0, 8);
            }
            catch (Exception)
            {

                return null;
            }
        }

        private FlowData Analyse(byte[] byteArray)
        {
            if (byteArray != null && byteArray.Length == 16)
            {
                FlowData flowData = new FlowData();
                flowData.Temp = ByteToFloatByPoint(new byte[] { byteArray[0], byteArray[1], byteArray[2], byteArray[3] });
                flowData.Pressure = ByteToFloatByPoint(new byte[] { byteArray[4], byteArray[5], byteArray[6], byteArray[7] });
                flowData.FlowInstant = ByteToFloatByPoint(new byte[] { byteArray[8], byteArray[9], byteArray[10], byteArray[11] });
                flowData.FlowTotal = ByteToFloatByPoint(new byte[] { byteArray[12], byteArray[13], byteArray[14], byteArray[15] });
                return flowData;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// 用指针方式强制将byte数组转为浮点数
        /// </summary>
        /// <param name="bResponse"></param>
        /// <returns></returns>
        private float ByteToFloatByPoint(byte[] bResponse)
        {
            //uint nRest = ((uint)response[startByte]) * 256 + ((uint)response[startByte + 1]) + 65536 * ((uint)response[startByte + 2]) * 256 + ((uint)response[startByte + 3]);
            float fValue = 0.0f;
            uint nRest = ((uint)bResponse[2]) * 256
            + ((uint)bResponse[3]) +
            65536 * (((uint)bResponse[0]) * 256 + ((uint)bResponse[1]));
            //用指针将整形强制转换成float
            unsafe
            {
                float* ptemp;
                ptemp = (float*)(&nRest);
                fValue = *ptemp;
            }
            return fValue;
        }

        /// <summary>
        /// 打开窗体
        /// </summary>
        /// <param name="form"></param>
        private void OpenWindow(Form form)
        {
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            form.Parent = Pannel;
            form.Show();
        }
        /// <summary>
        /// 关闭窗体
        /// </summary>
        /// <param name="frmName"></param>
        /// <returns></returns>
        private bool CloseWindow(string frmName)
        {
            bool res = true;
            foreach (Control item in Pannel.Controls)
            {
                if (item is Form)
                {
                    Form Frm = (Form)item;
                    if (Frm.Name == frmName)
                    {
                        res = false;
                        break;
                    }
                    else
                    {
                        Frm.Close();
                    }
                }
            }
            return res;
        }


        private void btnView_Click(object sender, EventArgs e)
        {
            if (CloseWindow("FrmView"))
            {
                OpenWindow(new FrmView());
            }
            BackColorSet(ButtonName.View);

        }
        /// <summary>
        /// Exit Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_Click(object sender, EventArgs e)
        {
            CommonMethods.opcUaClient.Disconnect();
            Application.Exit();
        }

        private void btnCtrlProcess_Click(object sender, EventArgs e)
        {
            if (CloseWindow("FrmProcess"))
            {
                OpenWindow(new FrmProcess());

            }
            BackColorSet(ButtonName.CtrlProcess);
        }

        private void btnParaSet_Click(object sender, EventArgs e)
        {
            if (CloseWindow("FrmParaSet"))
            {
                OpenWindow(new FrmParaSet());
            }
            BackColorSet(ButtonName.ParaSet);
        }

        private void btnAlarm_Click(object sender, EventArgs e)
        {
            if (CloseWindow("FrmAlarm"))
            {
                OpenWindow(new FrmAlarm());
            }
            BackColorSet(ButtonName.Alarm);
        }

        private void btnTrend_Click(object sender, EventArgs e)
        {
            if (CloseWindow("FrmTrend"))
            {
                OpenWindow(new FrmTrend());
            }
            BackColorSet(ButtonName.Tend);
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            if (CloseWindow("FrmReport"))
            {
                OpenWindow(new FrmReport());
            }
            BackColorSet(ButtonName.Report);
        }

        private void btnSysMaintenance_Click(object sender, EventArgs e)
        {
            if (CloseWindow("FrmSysMaint"))
            {
                OpenWindow(new FrmSysMaint());
            }
            BackColorSet(ButtonName.SysMaintenance);
        }
        private void btnOPC_Click(object sender, EventArgs e)
        {
            if (CloseWindow("FrmOpcView"))
            {
                OpenWindow(new FrmOpcView());
            }
            BackColorSet(ButtonName.OpcView);
        }
        private void BackColorSet(ButtonName index)
        {
            btnView.BackColor = Color.FromKnownColor(KnownColor.Highlight);
            btnPraraSet.BackColor = Color.FromKnownColor(KnownColor.Highlight);
            btnCtrlProcess.BackColor = Color.FromKnownColor(KnownColor.Highlight);
            btnAlarm.BackColor = Color.FromKnownColor(KnownColor.Highlight);
            btnTrend.BackColor = Color.FromKnownColor(KnownColor.Highlight);
            btnReport.BackColor = Color.FromKnownColor(KnownColor.Highlight);
            btnSysMaintenance.BackColor = Color.FromKnownColor(KnownColor.Highlight);
            btnExit.BackColor = Color.FromKnownColor(KnownColor.Highlight);

            switch (index)
            {
                case ButtonName.View: btnView.BackColor = Color.FromKnownColor(KnownColor.Green); break;
                case ButtonName.ParaSet: btnPraraSet.BackColor = Color.FromKnownColor(KnownColor.Green); break;
                case ButtonName.CtrlProcess: btnCtrlProcess.BackColor = Color.FromKnownColor(KnownColor.Green); break;
                case ButtonName.Alarm: btnAlarm.BackColor = Color.FromKnownColor(KnownColor.Green); break;
                case ButtonName.Tend: btnTrend.BackColor = Color.FromKnownColor(KnownColor.Green); break;
                case ButtonName.Report: btnReport.BackColor = Color.FromKnownColor(KnownColor.Green); break;
                case ButtonName.SysMaintenance: btnSysMaintenance.BackColor = Color.FromKnownColor(KnownColor.Green); break;
                case ButtonName.Exit: btnExit.BackColor = Color.FromKnownColor(KnownColor.Green); break;

                default:
                    break;
            }
        }


    }
}
