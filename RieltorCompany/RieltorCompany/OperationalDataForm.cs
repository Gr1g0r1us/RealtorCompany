using RieltorCompany.Tables;
using System;
using System.Data;
using System.Data.Linq;
using System.Linq;
using System.Windows.Forms;

namespace RieltorCompany
{
	public partial class OperationalDataForm : Form
	{

		static string connectionString = @"Data Source=DESKTOP-P0Q5PCQ\SQLEXPRESS;Initial Catalog=RealComp;Integrated Security=True";

		DataContext dataContext = null;

		ChooseObjectForm newForm;

		private Contract contract;

		private int? idApartament = null;

		private int idContract = 0;

		private int contractNum = 1;

		public OperationalDataForm()
		{
			InitializeComponent();
			LoadTables();
			LoadContracts();
		}

		public void LoadTables()
		{
			dataContext = new DataContext(connectionString);

			comboBox1.DataSource = dataContext.GetTable<ServiceType>().Select(i => i.Name);
			comboBox3.DataSource = dataContext.GetTable<Client>().Select(i => i.FIO);
			comboBox4.DataSource = dataContext.GetTable<Rieltor>().Select(i => i.FIO);
			comboBox6.DataSource = dataContext.GetTable<ServiceStatus>().Select(i => i.Name);

			ClearText();
		}

		public void LoadContracts()
		{
			comboBox2.DataSource = dataContext.GetTable<Contract>().Select(i => i.NumberContract);
		}

		private void button6_Click(object sender, EventArgs e)
		{
			newForm = new ChooseObjectForm();
			newForm.ShowDialog();

			if (newForm.DialogResult == DialogResult.OK)
			{
				idApartament = int.Parse(newForm.ReturnData());
			}
			var s = dataContext.GetTable<Apartament>().Where(i => i.Id == idApartament).Select(i => new { i.Street, i.NumberHouse, i.NumberApartment }).First();
			var street = dataContext.GetTable<Street>().Where(i => i.Id == s.Street).First().Name;
			var s1 = street + ", " + s.NumberHouse + ", " + s.NumberApartment;
			textBox1.Text = s1;
		}

		public void ClearText()
		{
			comboBox1.Text = null;
			comboBox3.Text = null;
			textBox4.Text = null;
			comboBox4.Text = null;
			comboBox6.Text = null;
			idApartament = null;
		}

		/// <summary>
		/// 
		/// </summary>
		private void AddContract()
		{
			var contracts = dataContext.GetTable<Contract>();
			contract = new Contract();

			contract.IdClient = dataContext.GetTable<Client>().Where(i => i.FIO == comboBox3.Text).Select(i => i.Id).First();
			contract.IdRieltor = dataContext.GetTable<Rieltor>().Where(i => i.FIO == comboBox4.Text).Select(i => i.Id).First();
			contract.NumberContract = textBox4.Text;
			contract.DateContract = dateTimePicker1.Value;
			contract.DateEndService = dateTimePicker2.Value;
			contract.IdService = dataContext.GetTable<ServiceType>().Where(i => i.Name == comboBox1.Text).Select(i => i.Id).First();
			contract.CostService = (int)numericUpDown1.Value;
			contract.IdCompany = dataContext.GetTable<Rieltor>().Where(i => i.FIO == comboBox4.Text).Select(i => i.IdCompany).First();
			contract.IdApparamet = idApartament;

			contracts.InsertOnSubmit(contract);
			dataContext.SubmitChanges();
			MessageBox.Show("Договор успешно сохранен!");
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void button1_Click(object sender, EventArgs e)
		{

			if (comboBox1.SelectedItem == null || textBox4.Text == null || comboBox3.SelectedItem == null || comboBox4.SelectedItem == null || numericUpDown1.Value <= 0)
			{
				MessageBox.Show("Все поля должны быть заполнены! \nСтоимость услуги не может быть меньше или равна 0!");
				return;
			}

			if (dateTimePicker1.Value > dateTimePicker2.Value)
			{
				MessageBox.Show("Дата составления договора не может быть похже даты его выполения!");
				return;
			}

			AddContract();
			AddServiceStatus();
			ClearText();
			LoadContracts();
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void button7_Click(object sender, EventArgs e)
		{
			var f8 = new Form8();
			f8.ShowDialog();

			if (f8.DialogResult == DialogResult.OK)
			{
				idContract = int.Parse(f8.ReturnData());
			}

		}

		/// <summary>
		/// Добавления состояния выполнения договора
		/// </summary>
		public void AddServiceStatus()
		{
			var conditionServices = dataContext.GetTable<ConditionService>();
			var conditionService = new ConditionService();

			conditionService.DateUpdate = DateTime.Now;
			conditionService.IdContract = contract.Id;
			if (idApartament != null)
			{
				conditionService.IdServiceStatus = dataContext.GetTable<ServiceStatus>().Where(i => i.Name == "Договор составлен").First().Id;
				conditionService.Comment = "Договор сохранен";
			}
			else
			{
				conditionService.IdServiceStatus = dataContext.GetTable<ServiceStatus>().Where(i => i.Name == "Подбор объекта").First().Id;
				conditionService.Comment = "Выполняется подбор объекта";
			}

			conditionServices.InsertOnSubmit(conditionService);
			dataContext.SubmitChanges();
		}

		/// <summary>
		/// Нахожение состояний договора.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void button2_Click(object sender, EventArgs e)
		{
			SearchServiceStarus();
		}


		/// <summary>
		/// Поиск и вывод состояния договора
		/// </summary>
		private void SearchServiceStarus()
		{
			comboBox6.Text = null;
			textBox2.Text = null;
			var queue = from condService in dataContext.GetTable<ConditionService>()
						where condService.IdContract == dataContext.GetTable<Contract>().Where(i => i.NumberContract == comboBox2.Text).First().Id
						join serviceStatus in dataContext.GetTable<ServiceStatus>() on condService.IdServiceStatus equals serviceStatus.Id
						join contract in dataContext.GetTable<Contract>() on condService.IdContract equals contract.Id
						join rieltor in dataContext.GetTable<Rieltor>() on contract.IdRieltor equals rieltor.Id
						join client in dataContext.GetTable<Client>() on contract.IdClient equals client.Id
						join serviceType in dataContext.GetTable<ServiceType>() on contract.IdService equals serviceType.Id
						select new
						{
							condService.IdContract,
							rieltor.FIO,
							condService.DateUpdate,
							type = serviceType.Name,
							name = serviceStatus.Name,
							condService.Comment
						};

			dataGridView1.DataSource = queue;

			dataGridView1.Columns[0].Visible = false;
			dataGridView1.Columns[1].HeaderText = "Риелтор";
			dataGridView1.Columns[2].HeaderText = "Последняя дата обновления";
			dataGridView1.Columns[3].HeaderText = "Услуга";
			dataGridView1.Columns[4].HeaderText = "Состояние выполнения";
			dataGridView1.Columns[5].HeaderText = "Комментарий";

		}

		// Доделать изменение состояния статуса услуги
		private void button3_Click(object sender, EventArgs e)
		{
			UpdateServiceStatus();
			SearchServiceStarus();
		}

		private void UpdateServiceStatus()
		{
			var idElem = int.Parse(dataGridView1.Rows[0].Cells[0].Value.ToString());
			var elem = dataContext.GetTable<ConditionService>().Where(i => i.IdContract == idElem).First();
			var condServ = dataContext.GetTable<ConditionService>();

			var newElem = new ConditionService();

			newElem.IdContract = elem.IdContract;
			newElem.Comment = textBox2.Text;
			newElem.IdServiceStatus = dataContext.GetTable<ServiceStatus>().Where(i => i.Name == comboBox6.Text).First().Id;
			newElem.DateUpdate = DateTime.Now;

			condServ.InsertOnSubmit(newElem);

			dataContext.SubmitChanges();
		}
	}
}
