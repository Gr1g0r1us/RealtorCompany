using RieltorCompany.Tables;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RieltorCompany
{
	public partial class CRForm : Form
	{

		static string connectionString = @"Data Source=DESKTOP-P0Q5PCQ\SQLEXPRESS;Initial Catalog=RealComp;Integrated Security=True";

		DataContext dataContext = null;
		public CRForm()
		{
			InitializeComponent();
			dataContext = new DataContext(connectionString);
		}

		private void crystalReportViewer1_Load(object sender, EventArgs e)
		{
			
		}
	}
}
