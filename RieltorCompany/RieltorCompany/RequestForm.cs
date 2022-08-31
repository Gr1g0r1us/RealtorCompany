using RieltorCompany.Tables;
using System;
using System.Data;
using System.Data.Linq;
using System.Linq;
using System.Windows.Forms;

namespace RieltorCompany
{
	public partial class RequestForm : Form
	{
		static string connectionString = @"Data Source=DESKTOP-P0Q5PCQ\SQLEXPRESS;Initial Catalog=RealComp;Integrated Security=True";

		DataContext dataContext = null;

		public RequestForm()
		{
			InitializeComponent();
			LoadTables();
		}

		public void LoadTables()
		{
			dataContext = new DataContext(connectionString);

			comboBox1.DataSource = dataContext.GetTable<Rieltor>().Select(i => i.FIO);
		}

		private void button1_Click(object sender, EventArgs e)
		{
			ActiveContract();
		}

		

		private void ActiveContract()
		{
			
			var queue = from contract in dataContext.GetTable<Contract>()
						join condServ in dataContext.GetTable<ConditionService>() on contract.Id equals condServ.IdContract
						join servType in dataContext.GetTable<ServiceType>() on contract.IdService equals servType.Id
						join servStat in dataContext.GetTable<ServiceStatus>() on condServ.IdServiceStatus equals servStat.Id
						join rieltor in dataContext.GetTable<Rieltor>() on contract.IdRieltor equals rieltor.Id
						join client in dataContext.GetTable<Client>() on contract.IdClient equals client.Id
						where contract.DateContract <= DateTime.Now && contract.DateEndService >= DateTime.Now
						select new
						{ 
							contract.NumberContract,
							rieltor = rieltor.FIO,
							client = client.FIO,
							servStat.Name,
							contract.DateContract,
							contract.DateEndService,
							condServ.Comment,
							condServ.DateUpdate
						};

			dataGridView5.DataSource = queue.OrderByDescending(i=> i.DateUpdate).GroupBy(i => i.NumberContract).Select(i => i.First());
			dataGridView5.Columns[0].HeaderText = "Номер договора";
			dataGridView5.Columns[1].HeaderText = "Риелтор";
			dataGridView5.Columns[2].HeaderText = "Клиент";
			dataGridView5.Columns[3].HeaderText = "Статус выполнения";
			dataGridView5.Columns[4].HeaderText = "Дата составления";
			dataGridView5.Columns[5].HeaderText = "Дата выполнения";
			dataGridView5.Columns[6].HeaderText = "Комментарий";
			dataGridView5.Columns[7].Visible = false;

			if (queue.Count() == 0)
			{
				MessageBox.Show("Не найдено ни одного договора!");
				return;
			}

			
		}

		private void button3_Click(object sender, EventArgs e)
		{
			SomeMethod();
		}

		private void SomeMethod()
		{
			var queue = from contract in dataContext.GetTable<Contract>()
						join condServ in dataContext.GetTable<ConditionService>() on contract.Id equals condServ.IdContract
						join servType in dataContext.GetTable<ServiceType>() on contract.IdService equals servType.Id
						join servStat in dataContext.GetTable<ServiceStatus>() on condServ.IdServiceStatus equals servStat.Id
						join rieltor in dataContext.GetTable<Rieltor>() on contract.IdRieltor equals rieltor.Id
						join client in dataContext.GetTable<Client>() on contract.IdClient equals client.Id

						where (contract.DateEndService < DateTime.Now && servStat.Name != "Сделка завершена") || servStat.Name == "Договор расторгнут"
						
						select new
						{
							contract.NumberContract,
							serviceType = servType.Name,
							rieltor = rieltor.FIO,
							client = client.FIO,
							servStat.Name,
							contract.DateContract,
							contract.DateEndService,
							condServ.DateUpdate,
							condServ.Comment
						};
			dataGridView2.DataSource = queue.OrderByDescending(i=>i.DateUpdate).GroupBy(i => i.NumberContract).Select(i => i.First());

			dataGridView2.Columns[0].HeaderText = "Номер договора";
			dataGridView2.Columns[1].HeaderText = "Тип услуги";
			dataGridView2.Columns[2].HeaderText = "Риелтор";
			dataGridView2.Columns[3].HeaderText = "Клиент";
			dataGridView2.Columns[4].HeaderText = "Статус выполнения";
			dataGridView2.Columns[5].HeaderText = "Дата составления";
			dataGridView2.Columns[6].HeaderText = "Дата выполнения";
			dataGridView2.Columns[7].HeaderText = "Дата изменения статуса";
			dataGridView2.Columns[8].HeaderText = "Комментарий";
		}

		private void button2_Click(object sender, EventArgs e)
		{
			SomeMethod2();
		}

		private void SomeMethod2()
		{
			var queue = from contract in dataContext.GetTable<Contract>()
						
						join condServ in dataContext.GetTable<ConditionService>() on contract.Id equals condServ.IdContract
						join servType in dataContext.GetTable<ServiceType>() on contract.IdService equals servType.Id
						join servStat in dataContext.GetTable<ServiceStatus>() on condServ.IdServiceStatus equals servStat.Id
						join client in dataContext.GetTable<Client>() on contract.IdClient equals client.Id
						
						where contract.IdRieltor == dataContext.GetTable<Rieltor>().Where(i => i.FIO == comboBox1.Text).First().Id
						
						select new
						{
							contract.NumberContract,
							client = client.FIO,
							serviceType = servType.Name,
							contract.CostService,
							servStat.Name,
							condServ.DateUpdate,
							contract.DateContract,
							contract.DateEndService
						}
						;
			dataGridView1.DataSource = queue.OrderByDescending(i=>i.DateUpdate).GroupBy(i=>i.NumberContract).Select(i=>i.First());

			dataGridView1.Columns[0].HeaderText = "Номер договора";
			dataGridView1.Columns[1].HeaderText = "Клиент";
			dataGridView1.Columns[2].HeaderText = "Тип услуги";
			dataGridView1.Columns[3].HeaderText = "Стоимость услуги";
			dataGridView1.Columns[4].HeaderText = "Статус выполнения";
			dataGridView1.Columns[5].HeaderText = "Дата составления";
			dataGridView1.Columns[6].HeaderText = "Дата выполнения";

		}
	}
}
