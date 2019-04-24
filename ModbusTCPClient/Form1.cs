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

namespace ModbusTCPClient
{
    public partial class Form1 : Form
    {
        ModTCP modTCP;
        public Form1()
        {
            InitializeComponent();
            modTCP = new ModTCP();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            if (modTCP.Connect("127.0.0.1", "502"))
            {
                MessageBox.Show("连接成功");
            }
            else
            {
                MessageBox.Show("连接失败");
            }
        }
        private void btnConnect_Click(object sender, EventArgs e)
        {

            if (modTCP.Connect("127.0.0.1", "502"))
            {
                MessageBox.Show("连接成功");
            }
            else
            {
                MessageBox.Show("连接失败");
            }
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            modTCP.DisConnect();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            byte[] res = modTCP.ReadKeepReg(0, 2);
            for (int i = 0; i < res.Length; i++)
            {
                lstRead.Items.Add(res[i].ToString());
            }
        }
        private void btnWrite_Click(object sender, EventArgs e)
        {
            if (modTCP.PreSetFloatReg(0, float.Parse(txtWrite.Text)))
            {
                MessageBox.Show("写入成功");
            }
            else
            {
                MessageBox.Show("写入失败");
            }

        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            lstRead.Items.Clear();

        }

        private void txtWrite_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == Convert.ToChar(13))
            {
                modTCP.PreSetFloatReg(0, float.Parse(txtWrite.Text));
                e.Handled = true;
            }
        }
    }
}
