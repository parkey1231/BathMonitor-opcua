using OpcUaHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Opc;
using Opc.Ua;


namespace BathMonitorSystem
{
    public partial class FrmProcess : Form
    {
        public FrmProcess( )
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string value = CommonMethods.opcUaClient.ReadNode<string>("ns=2;s=Machines/Machine A/Name");
                
                MessageBox.Show(value); // 显示测试数据
            }
            catch (Exception ex)
            {
                // 使用了opc ua的错误处理机制来处理错误，网络不通或是读取拒绝
                ClientUtils.HandleException(Text, ex);
            }
        }
    }
}
