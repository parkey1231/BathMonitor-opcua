using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace BathMonitorSystem
{
    public partial class FrmAdminLogin : Form
    {
        public FrmAdminLogin( )
        {
            InitializeComponent( );

        }

        private void pictureBox1_Click( object sender, EventArgs e )
        {
            Application.Exit( );


        }

        private void binLoginSysterm_Click( object sender, EventArgs e )
        {
            //string userName = txtUserName.Text;
            //string userPassword = txtUserPassword.Text;

            //if (userName.Equals( "" ) || userPassword.Equals( "" ))
            //{
            //    MessageBox.Show( "用户名或密码不能为空！" );
            //}
            //else
            //{
            //    if (userName.Equals( "admin" ) && userPassword.Equals( "admin" ))
            //    {

            //        MessageBox.Show( "登录成功！" );
            //        CommonMethods.UserName = userName;
            //        FrmMain frmMain = new FrmMain( );
            //        frmMain.Show( );

            //    }
            //    else
            //    {
            //        MessageBox.Show( "用户名或密码错误！" );
            //    }
            //}

            if (isValidUserName( txtUserName.Text ) == false)
            {
                MessageBox.Show( "用户名格式不正确！请重新输入！" );
                txtUserName.Text = "";
            }
            else
            {
                //用户名正确 校验密码
                CheckUserAndPwd( txtUserName.Text, txtUserPassword.Text );
            }



        }
        private void CheckUserAndPwd( string userName, string pwd )
        {
            //读取UserInfo.xml检测user是否存在
            XDocument userInfo = XDocument.Load( @"C:\User\jghuang\Desktop\UserInfo.xml" );
            var result = from userElement in userInfo.Element( "System" ).Element( "users" ).Elements( )
                         where userElement.Element( "username" ).Value.ToString( ) == txtUserPassword.Text.ToString( )
                         select userElement.Element( "pwd" ).Value;
            if (result != null)
            {
                foreach (var password in result)
                {
                    if (password == pwd)
                    {
                        MessageBox.Show( "用户名和密码匹配成功！" );
                        CommonMethods.UserName = userName;
                        FrmMain frmMain = new FrmMain( );
                        frmMain.Show( );
                    }
                    else
                    {
                        MessageBox.Show( "用户名和密码不匹配，请重新输入密码" );
                        txtUserPassword.Text = "";
                    }
                }
            }

        }

        private bool isValidUserName( string userName )
        {
            return Regex.IsMatch( userName, @"^.+\\.+$" );
        }

          private void txtUserName_MouseClick( object sender, MouseEventArgs e )
        {
            if (txtUserName.Text == "请输入用户名")
            {
                txtUserName.Text = "";
            }
        }


    }
}
