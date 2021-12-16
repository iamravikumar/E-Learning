using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace E_Learning
{
	public partial class AdminUploadDownloadInfoForm : Form
	{
		public AdminUploadDownloadInfoForm()
		{
			InitializeComponent();
		}

		private void btnBack_Click(object sender, EventArgs e)
		{
			AdminDashboardForm frm = new AdminDashboardForm();
			frm.Show();
			this.Hide();
		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			Environment.Exit(0);
		}
	}
}
