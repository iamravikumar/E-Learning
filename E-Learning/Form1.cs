using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using E_Learning.Business;
using E_Learning.DAL;

namespace E_Learning
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			LanguageRepository langRepo = new LanguageRepository();
			AdminRepository adminRepo = new AdminRepository();
			List<Language> languages = langRepo.GetAllLanguages();
			List<Admin> admins = adminRepo.GetAllAdmins();
			foreach (Admin admin in admins)
			{
				this.richTextBox1.Text += admin.email + "\t" + admin.password + "\n";
			}
			
		}
	}
}
