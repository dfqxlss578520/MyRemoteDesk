using MSTSCLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RemoteDesk
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            string serverip = txtServerIP.Text;
            string username = txtUserName.Text;
            string password = txtPassword.Text;

            if(string.IsNullOrEmpty(serverip))
            {
                MessageBox.Show("服务器IP不能为空！", "温馨提示");
                return ;
            }
            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("用户名不能为空！", "温馨提示");
                return;
            }
            if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("密码不能为空！", "温馨提示");
                return;
            }
            try
            {
                axMsTscAxNotSafeForScripting1.Server = txtServerIP.Text;
                axMsTscAxNotSafeForScripting1.UserName = txtUserName.Text;
                IMsTscNonScriptable secured = (IMsTscNonScriptable)axMsTscAxNotSafeForScripting1.GetOcx();
                secured.ClearTextPassword = txtPassword.Text;
                axMsTscAxNotSafeForScripting1.Connect();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "温馨提示");
            }
        }

        private void btnBrokenConnect_Click(object sender, EventArgs e)
        {
            if(axMsTscAxNotSafeForScripting1.Connected.ToString()=="1")
            {
                axMsTscAxNotSafeForScripting1.Disconnect();
            }
        }
    }
}
