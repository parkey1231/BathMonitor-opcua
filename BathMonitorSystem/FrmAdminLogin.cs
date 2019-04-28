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
            InitLoginUser( );
           
        }
        /// <summary>
        /// 用户登陆初始化信息
        /// </summary>
        private void InitLoginUser( )
        {
            XmlDocument xmlDoc;
            XmlNode root;
            XmlElement xmlElem;
            List<XmlElement> userList = new List<XmlElement>( );
            List<XmlElement> userNameList = new List<XmlElement>( );
            List<XmlElement> userpwdList = new List<XmlElement>( );
            //xmlEles.Add( user );
            xmlDoc = new XmlDocument( );
            //加入XML的声明段落,<?xml version="1.0" encoding="UTF-8"?>
            XmlDeclaration xmldecl;
            xmldecl = xmlDoc.CreateXmlDeclaration("1.0", "UTF-8", null);
            xmlDoc.AppendChild(xmldecl);
            //加入一个根元素
            xmlElem = xmlDoc.CreateElement("Systerm");
            xmlDoc.AppendChild(xmlElem);
            root = xmlDoc.SelectSingleNode("Systerm");//查找<Systerm>
            XmlElement users = xmlDoc.CreateElement("users");
            for (int i = 0; i < 2; i++)
            {
                userList.Add(xmlDoc.CreateElement("user"));
                userNameList.Add(xmlDoc.CreateElement("username"));
                userpwdList.Add(xmlDoc.CreateElement("pwd"));
                userList[i].AppendChild(userNameList[i]);//添加到<user>节点中
                userList[i].AppendChild(userpwdList[i]);//添加到<user节点中            
                users.AppendChild(userList[i]);//添加到<users>节点中
            }
            //添加用户1的信息
            userList[0].SetAttribute("用户权限", "管理员");//设置该节点属性
            userList[0].SetAttribute("用户等级", "4");//设置该节点属性
            userNameList[0].InnerText = "Admin";
            userpwdList[0].InnerText = "123";
            //添加用户2的信息
            userList[1].SetAttribute("用户权限", "用户");//设置该节点属性
            userList[1].SetAttribute("用户等级", "1");//设置该节点属性
            userNameList[1].InnerText = "Truking";
            userpwdList[1].InnerText = "312";
            root.AppendChild(users);//添加到<Systerm>节点中  
            xmlDoc.Save(@"C:\Users\Parkey\Desktop\UserInfo.xml");
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit( );
        }
        private void binLoginSysterm_Click(object sender, EventArgs e)
        {
            string userName = txtUserName.Text;
            string userPassword = txtUserPassword.Text;
            if (isValidUserName(userName) == false)
            {
                MessageBox.Show("用户名不能为空", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtUserName.Text = "";
            }
            else
            {
                //用户名正确 校验密码
                CheckUserAndPwd(txtUserName.Text, txtUserPassword.Text);
            }
        }
        private void CheckUserAndPwd(string userName, string pwd)
        {
            //读取UserInfo.xml检测user是否存在
            XDocument userInfo = XDocument.Load(@"C:\Users\Parkey\Desktop\UserInfo.xml");
            var res = from a in userInfo.Element("Systerm").Element("users").Elements( ) where a.Element("username").Value.ToString( ) == txtUserName.Text select a.Element("pwd").Value;
            if (res.Count( ) > 0)
            {
                CommonMethods.UserName = userName;
                foreach (string password in res)
                {
                    if (password == pwd)
                    {
                        MessageBox.Show("登录成功！", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CommonMethods.UserName = userName;
                        this.DialogResult = DialogResult.OK;
                        this.Dispose( );
                    }
                    else
                    {
                        MessageBox.Show("密码错误，请重新输入", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtUserPassword.Text = "";
                    }
                }
            }
            else
            {
                MessageBox.Show("无效用户名，请重新输入", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUserPassword.Text = "";
            }
        }
        //正则表达式判断
        private bool isValidUserName(string userName)
        {
            return Regex.IsMatch(userName, @"[^\s]+");
        }
        private void txtUserName_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtUserName.Text == "请输入用户名")
            {
                txtUserName.Text = "";
            }
        }
    }
}
