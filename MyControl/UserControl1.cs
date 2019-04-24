using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyControl
{
    public partial class UserControl1: UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }
        public delegate void TransfDelegate(string Value);
        public event TransfDelegate TransfEvent;
        private void UserControl1_Load(object sender, EventArgs e)
        {
            
        }
        public void WriteMessage(string str)
        {
            listBoxRecv.Items.Add(str);
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            TransfEvent(txtSend.Text);
        }
    }
}
