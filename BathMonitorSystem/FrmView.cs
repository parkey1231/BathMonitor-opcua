using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BathMonitorSystem
{
    public partial class FrmView : Form
    {
        public FrmView()
        {
            InitializeComponent();


        }

        private void myTimer_Tick(object sender, EventArgs e)
        {
            foreach (Control item in Controls)
            {
                if (item is Label && item.Tag != null)
                {
                    string[] res = item.Tag.ToString().Split('_');
                    int index = Convert.ToInt32(res[1]);
                    if (CommonMethods.CurrentValue.Count > 0 && CommonMethods.CurrentValue.ContainsKey(index))
                    {
                        FlowData flowData = CommonMethods.CurrentValue[index];
                        switch (res[0])
                        {
                            case "Temp": item.Text = flowData.Temp.ToString() + " ℃"; break;
                            case "Pressure": item.Text = flowData.Pressure.ToString() + " Bar"; break;
                            case "FlowInstant": item.Text = flowData.FlowInstant.ToString() + " m3/h"; break;
                            case "FlowTotal": item.Text = flowData.FlowTotal.ToString() + " m3/h"; break;

                            default:
                                break;
                        }
                    }
                }

            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (sender is Button)
            {
                Button btnClear = (Button)sender;
                if (btnClear.Tag != null)
                {
                    int index = Convert.ToInt32(btnClear.Tag.ToString());
                    if (CommonMethods.CurrentModbusList.ContainsKey(index))
                    {
                        
                        if(CommonMethods.CurrentModbusList[index].PreSetFloatReg(6,0.0f))                      
                        {
                            MessageBox.Show("OK", "提示");
                        }
                        else
                        {
                            MessageBox.Show("NOK", "提示");
                        }
                    }

                }

            }
        }
    }
}
