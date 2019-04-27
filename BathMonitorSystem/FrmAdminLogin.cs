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
            //XDocument document = new XDocument( );
            //document.Declaration = new XDeclaration( "1.0", "UTF-8", "" );



            
            //XElement root = new XElement("System");

            //XElement a= root.Add( new XElement( "users" ) );
            //   XmlElement a= root.Add( new XElement( "users" ) );


            //root.Add( new XElement( "ZWERKS", "ZFM1" ),
            //    new XElement( "user",
            //        new XElement( "username", 11 ),
            //        new XElement( "pwd", 123 ) ),

            //    new XElement( "user",
            //        new XElement( "ZNO", 13022101 ),
            //        new XElement( "ZORDER", 2013238955 ),
            //        new XElement( "ZWEIGHT", 4140 ) )
            //        );

            //document.Add( root );
            //document.Save( @"C:\Users\Parkey\Desktop\UserInfo2.xml" );//保存xml到文件
        }

        private void pictureBox1_Click( object sender, EventArgs e )
        {
            Application.Exit( );
        }

        private void binLoginSysterm_Click( object sender, EventArgs e )
        {
            string userName = txtUserName.Text;
            string userPassword = txtUserPassword.Text;

            if (isValidUserName( userName ) == false)
            {
                MessageBox.Show( "用户名不能为空", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information );
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
            XDocument userInfo = XDocument.Load( @"C:\Users\Parkey\Desktop\UserInfo.xml" );

            var res = from a in userInfo.Element( "System" ).Element( "users" ).Elements( ) where a.Element( "username" ).Value.ToString( ) == txtUserName.Text select a.Element( "pwd" ).Value;

            if (res.Count( ) > 0)
            {
                CommonMethods.UserName = userName;
                foreach (string password in res)
                {
                    if (password == pwd)
                    {
                        MessageBox.Show( "登录成功！", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information );
                        CommonMethods.UserName = userName;
                        this.DialogResult = DialogResult.OK;
                        this.Dispose( );
                    }
                    else
                    {
                        MessageBox.Show( "密码错误，请重新输入", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Error );
                        txtUserPassword.Text = "";
                    }
                }
            }
            else
            {
                MessageBox.Show( "无效用户名，请重新输入", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Error );
                txtUserPassword.Text = "";
            }
        }
        //正则表达式判断
        private bool isValidUserName( string userName )
        {
            return Regex.IsMatch( userName, @"[^\s]+" );
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
