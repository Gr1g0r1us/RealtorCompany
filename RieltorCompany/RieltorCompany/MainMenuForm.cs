using System;
using System.Windows.Forms;

namespace RieltorCompany
{
	public partial class MainMenuForm : Form
	{
		public MainMenuForm()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			var f2 = new ReferenceDataForm();
			f2.ShowDialog();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			var f3 = new RequestForm();
			f3.ShowDialog();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			var f3 = new OperationalDataForm();
			f3.ShowDialog();
		}

		private void button4_Click(object sender, EventArgs e)
		{
			var f4 = new ReportsForm();
			f4.ShowDialog();
		}
	}
}
