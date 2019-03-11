using System;
using System.Configuration;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ANRA_WindowsClient.DTO;

namespace ANRA_WindowsClient
{
	public partial class Login : Form
	{
		//login into uss
		public Login()
		{
			InitializeComponent();
		}
		private AuthResult authResult = null;
		

		private async void btnLogin_Click(object sender, EventArgs e)
		{
			btnLogin.Enabled = false;
			if (!String.IsNullOrEmpty(txtUserId.Text.Trim()) && !String.IsNullOrEmpty(txtPwd.Text.Trim()))
			{
				//var url = System.Configuration.ConfigurationManager.AppSettings["anrausssecurityserver"];
				//var proxy = new AnraServiceProxy(url);
				//var authRequest = new AuthRequest();
				//authRequest.Email = txtUserId.Text;
				//authRequest.Password = txtPwd.Text;

				//authResult = await proxy.DoLogin(authRequest);

				//if (IsValidUser(authResult))
				//{
				//	Main frmMain = new Main(authResult);
				//	frmMain.Show();
				//	this.Hide();									
				//}
				//else
				//{
				//	HandleMessage("Invalid UserId/Password.", nameof(Login), MessageBoxButtons.OK, MessageBoxIcon.Error, true);
				//	btnLogin.Enabled = true;
				//}
			}
			else
			{
				HandleMessage("UserId/Password is Mandatory Fields.", nameof(Login), MessageBoxButtons.OK, MessageBoxIcon.Information, true);
				btnLogin.Enabled = true;
			}

		}

		private void Reset()
		{
			txtUserId.Text = string.Empty;
			txtPwd.Text = string.Empty;
			txtUserId.Focus();
		}

		private bool IsValidUser(AuthResult result)
		{
			return result.IsAuthenticated;
		}

		private void HandleMessage(string msgToDisplay, string caption, MessageBoxButtons buttons, MessageBoxIcon icon, bool resetForm)
		{
			MessageBox.Show(msgToDisplay, caption, buttons, icon);

			if (resetForm)
				Reset();
		}
	}
}
