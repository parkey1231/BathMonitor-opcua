using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace BathMonitorSystem
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main( )
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //FrmAdminLogin frmAdminLogin = new FrmAdminLogin( );
            //frmAdminLogin.ShowDialog( );
            //if (frmAdminLogin.DialogResult == DialogResult.OK)
            //{
            //    Application.Run( new FrmMain( ) );
            //}

            Application.Run(new FrmMain( ));
        }
    }
}
