using RieltorCompany.Report1;
using RieltorCompany.Report2;
using RieltorCompany.Report3;
using System;
using System.Data;
using System.Data.Linq;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;


namespace RieltorCompany
{
	
	public partial class ReportsForm : Form
	{
		static string connectionString = @"Data Source=DESKTOP-P0Q5PCQ\SQLEXPRESS;Initial Catalog=RealComp;Integrated Security=True";

		DataContext dataContext = null;
		SqlConnection connection = null;

		public ReportsForm()
		{
			InitializeComponent();
			
			dataContext = new DataContext(connectionString);

			connection = new SqlConnection(connectionString);
			comboBox4.DataSource = dataContext.GetTable<Contract>().Select(i => i.NumberContract);
		}

		private void button1_Click(object sender, EventArgs e)
		{
			connection.Open();
			var CRForm = new CRForm();

			this.dataTable1TableAdapter1.Fill(this.dataSet11.DataTable1, dateTimePicker4.Value, dateTimePicker3.Value);

			var cr = new CrystalReport1();

			cr.SetDataSource((DataTable)dataSet11.DataTable1);

			CRForm.crystalReportViewer1.ReportSource = cr;
			CRForm.crystalReportViewer1.Refresh();
			CRForm.Show();
			connection.Close();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			connection.Open();
			var CRForm = new CRForm();

			this.dataTable3TableAdapter1.Fill(this.dataSet31.DataTable3, comboBox4.Text);


			var cr = new CrystalReport2();

			cr.SetDataSource((DataTable)dataSet31.DataTable3);

			CRForm.crystalReportViewer1.ReportSource = cr;
			CRForm.crystalReportViewer1.Refresh();
			CRForm.Show();
			connection.Close();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			connection.Open();
			var CRForm = new CRForm();

			this.dataTable2TableAdapter1.Fill(this.dataSet21.DataTable2, dateTimePicker2.Value, dateTimePicker1.Value);
			
						
			var cr = new CrystalReport3();

			cr.SetDataSource((DataTable)dataSet21.DataTable2);

			CRForm.crystalReportViewer1.ReportSource = cr;
			CRForm.crystalReportViewer1.Refresh();
			CRForm.Show();
			connection.Close();
		}
	}
}
