using System;
using System.Data.Linq;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using RieltorCompany.Tables;

namespace RieltorCompany
{
	public partial class ReferenceDataForm : Form
	{
		static string connectionString = @"Data Source=DESKTOP-P0Q5PCQ\SQLEXPRESS;Initial Catalog=RealComp;Integrated Security=True";

		DataContext dataContext = null;

		private string tableName = null;

		private int rowIndex = -1;

		public ReferenceDataForm()
		{
			InitializeComponent();
		}
		

		private void Form2_Load(object sender, EventArgs e)
		{
			
		}
		
		/// <summary>
		/// Метод получения таблиц из бд.
		/// </summary>
		private void GetDataTable()
		{
			dataContext = new DataContext(connectionString);
			rowIndex = -1;
			if (tableName == "Назначение_объекта")
			{
				var objectAppointments = dataContext.GetTable<ObjectAppointment>();
				dataGridView1.DataSource = objectAppointments;
			}
			else if (tableName == "Тип_услуги")
			{
				var serviceTypes = dataContext.GetTable<ServiceType>();
				dataGridView1.DataSource = serviceTypes;
			}
			else if (tableName == "Тип_объекта")
			{
				var objType = dataContext.GetTable<TypeObj>();
				dataGridView1.DataSource = objType;
			}
			else if (tableName == "Ремонт")
			{
				var repairs = dataContext.GetTable<Repair>();
				dataGridView1.DataSource = repairs;
			}
			else if (tableName == "Клиент")
			{
				var clients = dataContext.GetTable<Client>();
				dataGridView1.DataSource = clients;
			}
			else if (tableName == "Статус_выполнения_услуги")
			{
				var serviceStatuses = dataContext.GetTable<ServiceStatus>();
				dataGridView1.DataSource = serviceStatuses;
			}
			else if (tableName == "Улица")
			{
				var street = dataContext.GetTable<Street>();
				dataGridView1.DataSource = street;
			}
			else if (tableName == "Риелтор")
			{
				var rieltor = dataContext.GetTable<Rieltor>();
				dataGridView1.DataSource = rieltor;
			}
			else if (tableName == "Объект")
			{
				var queryApart = from apartament in dataContext.GetTable<Apartament>()
								 join type in dataContext.GetTable<TypeObj>() on apartament.TypeObj equals type.Id
								 join repair in dataContext.GetTable<Repair>() on apartament.Repair equals repair.Id
								 join objApp in dataContext.GetTable<ObjectAppointment>() on apartament.ObjAppointment equals objApp.Id
								 join street in dataContext.GetTable<Street>() on apartament.Street equals street.Id
								 select new
								 {
									 apartament.Id,
									 ObjectType = type.Name,
									 ObjectApp = objApp.Name,
									 Street = street.Name,
									 apartament.NumberHouse,
									 apartament.NumberApartment,
									 apartament.AllSquare,
									 apartament.LifeSquare,
									 apartament.KitchenSquare,
									 apartament.CountRoom,
									 apartament.CountBathroom,
									 repName = repair.Name,
									 apartament.FirstFloor,
									 apartament.LastFloor,
									 apartament.CountFloor,
									 apartament.Comment,
									 apartament.Cost
								 };
				dataGridView1.DataSource = queryApart;
			}
		}

		private void риелторStripMenuItem_Click(object sender, EventArgs e)
		{
			tableName = "Риелтор";
			GetDataTable();
			dataGridView1.Columns[0].Visible = false;
			dataGridView1.Columns[1].HeaderText = "ФИО";
			dataGridView1.Columns[2].HeaderText = "Телефон";
			dataGridView1.Columns[3].Visible = false;

		}

		private void улицаStripMenuItem_Click(object sender, EventArgs e)
		{
			tableName = "Улица";
			GetDataTable();
			dataGridView1.Columns[0].Visible = false;
			dataGridView1.Columns[1].HeaderText = "Название_улицы";
		}
		/// <summary>
		/// Вывод таблицы состояние ремонта.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void состояниеРемонтаToolStripMenuItem_Click(object sender, EventArgs e)
		{
			tableName = "Ремонт";
			GetDataTable();
			dataGridView1.Columns[0].Visible = false;
			dataGridView1.Columns[1].HeaderText = "Состояние ремонта";
		}

		/// <summary>
		/// Вывод таблицы тип объекта.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void типОбъектаToolStripMenuItem_Click(object sender, EventArgs e)
		{
			tableName = "Тип_объекта";
			GetDataTable();
			dataGridView1.Columns[0].Visible = false;
			dataGridView1.Columns[1].HeaderText = "Название типа";

		}

		/// <summary>
		/// Вывод таблицы статус выполнения услуги.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void статусВыполненияУслугиToolStripMenuItem_Click(object sender, EventArgs e)
		{
			tableName = "Статус_выполнения_услуги";
			GetDataTable();
			dataGridView1.Columns[0].Visible = false;
			dataGridView1.Columns[1].HeaderText = "Название статуса";

		}

		/// <summary>
		/// Вывод таблицы клиенты.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void клиентыToolStripMenuItem_Click(object sender, EventArgs e)
		{
			tableName = "Клиент";
			GetDataTable();
			dataGridView1.Columns[0].Visible = false;
			dataGridView1.Columns[1].HeaderText = "ФИО";
			dataGridView1.Columns[2].HeaderText = "Номер телефона";
			dataGridView1.Columns[3].HeaderText = "Серия паспорта";
			dataGridView1.Columns[4].HeaderText = "Номер паспорта";
			dataGridView1.Columns[5].HeaderText = "Кем выдан";
			dataGridView1.Columns[6].HeaderText = "Дата выдачи";
		}

		/// <summary>
		/// Вывод таблицы объекты.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void объектыToolStripMenuItem_Click(object sender, EventArgs e)
		{
			tableName = "Объект";
			GetDataTable();
			dataGridView1.Columns[0].Visible = false;
			dataGridView1.Columns[1].HeaderText = "Тип объекта";
			dataGridView1.Columns[2].HeaderText = "Назначение объекта";
			dataGridView1.Columns[3].HeaderText = "Улица";
			dataGridView1.Columns[4].HeaderText = "Номер дома";
			dataGridView1.Columns[5].HeaderText = "Номер квартиры";
			dataGridView1.Columns[6].HeaderText = "Общая площадь";
			dataGridView1.Columns[7].HeaderText = "Площадь кухни";
			dataGridView1.Columns[8].HeaderText = "Жилая площадь";
			dataGridView1.Columns[9].HeaderText = "Кол-во комнат";
			dataGridView1.Columns[10].HeaderText = "Кол-во санузлов";
			dataGridView1.Columns[11].HeaderText = "Ремонт";
			dataGridView1.Columns[12].HeaderText = "Первый этаж";
			dataGridView1.Columns[13].HeaderText = "Последний этаж";
			dataGridView1.Columns[14].HeaderText = "Этажность";
			dataGridView1.Columns[15].HeaderText = "Комментарий";
			dataGridView1.Columns[16].HeaderText = "Стоимость";
		}

		/// <summary>
		/// Вывод таблицы услуги.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void услугиToolStripMenuItem_Click(object sender, EventArgs e)
		{
			tableName = "Тип_услуги";
			GetDataTable();
			dataGridView1.Columns[0].Visible = false;
			dataGridView1.Columns[1].HeaderText = "Название услуги";

		}

		/// <summary>
		/// Вывод таблицы назначение объекта.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void назнчениеОбъектаToolStripMenuItem_Click(object sender, EventArgs e)
		{
			tableName = "Назначение_объекта";
			GetDataTable();
			dataGridView1.Columns[0].Visible = false;
			dataGridView1.Columns[1].HeaderText = "Название назначения";

		}

		/// <summary>
		/// Получение индекса строки.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			rowIndex = e.RowIndex;
		}

		/// <summary>
		/// Нажание на кнопку удалить.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void button3_Click(object sender, EventArgs e)
		{
			if (tableName == null)
			{
				MessageBox.Show("Выберите таблицу для добавления записи!");
				return;
			}

			if (rowIndex == -1)
			{
				MessageBox.Show("Выберите запись которую хотите удалить!");
				return;
			}

			var res = MessageBox.Show("Вы уверены что хотите удалить запись? \nУдалятся все записи где используется данная запись","Вы уверены?", MessageBoxButtons.YesNo);
			if (res == DialogResult.Yes)
			{
				DeleteRow();
				GetDataTable();
			}
			
		}

		/// <summary>
		/// Метод удаления строки.
		/// </summary>
		public void DeleteRow()
		{
			if (tableName == "Назначение_объекта")
			{
				var idElement = int.Parse(dataGridView1.Rows[rowIndex].Cells[0].Value.ToString());
				var element = from elements in dataContext.GetTable<ObjectAppointment>()
							  where elements.Id == idElement
							  select elements;
				dataContext.GetTable<ObjectAppointment>().DeleteOnSubmit(element.First());
			}
			else if (tableName == "Тип_услуги")
			{
				var idElement = int.Parse(dataGridView1.Rows[rowIndex].Cells[0].Value.ToString());
				var element = from elements in dataContext.GetTable<ServiceType>()
							  where elements.Id == idElement
							  select elements;
				dataContext.GetTable<ServiceType>().DeleteOnSubmit(element.First());
			}
			else if (tableName == "Улица")
			{
				var idElement = int.Parse(dataGridView1.Rows[rowIndex].Cells[0].Value.ToString());
				var element = from elements in dataContext.GetTable<Street>()
							  where elements.Id == idElement
							  select elements;
				dataContext.GetTable<Street>().DeleteOnSubmit(element.First());
			}
			else if (tableName == "Риелтор")
			{
				var idElement = int.Parse(dataGridView1.Rows[rowIndex].Cells[0].Value.ToString());
				var element = from elements in dataContext.GetTable<Rieltor>()
							  where elements.Id == idElement
							  select elements;
				dataContext.GetTable<Rieltor>().DeleteOnSubmit(element.First());
			}
			else if (tableName == "Тип_объекта")
			{
				var idElement = int.Parse(dataGridView1.Rows[rowIndex].Cells[0].Value.ToString());
				var element = from elements in dataContext.GetTable<TypeObj>()
							  where elements.Id == idElement
							  select elements;
				dataContext.GetTable<TypeObj>().DeleteOnSubmit(element.First());
			}
			else if (tableName == "Ремонт")
			{
				var idElement = int.Parse(dataGridView1.Rows[rowIndex].Cells[0].Value.ToString());
				var element = from elements in dataContext.GetTable<Repair>()
							  where elements.Id == idElement
							  select elements;
				dataContext.GetTable<Repair>().DeleteOnSubmit(element.First());
			}
			else if (tableName == "Клиент")
			{
				var idElement = int.Parse(dataGridView1.Rows[rowIndex].Cells[0].Value.ToString());
				var element = from elements in dataContext.GetTable<Client>()
							  where elements.Id == idElement
							  select elements;
				dataContext.GetTable<Client>().DeleteOnSubmit(element.First());
			}
			else if (tableName == "Статус_выполнения_услуги")
			{
				var idElement = int.Parse(dataGridView1.Rows[rowIndex].Cells[0].Value.ToString());
				var element = from elements in dataContext.GetTable<ServiceStatus>()
							  where elements.Id == idElement
							  select elements;
				dataContext.GetTable<ServiceStatus>().DeleteOnSubmit(element.First());
			}
			else if (tableName == "Объект")
			{
				var idElement = int.Parse(dataGridView1.Rows[rowIndex].Cells[0].Value.ToString());
				var element = from elements in dataContext.GetTable<Apartament>()
							  where elements.Id == idElement
							  select elements;
				dataContext.GetTable<Apartament>().DeleteOnSubmit(element.First());
			}

			dataContext.SubmitChanges();
		}

		/// <summary>
		/// Проверка строки на наличие цифр и знаков препинания
		/// </summary>
		/// <param name="s"></param>
		/// <returns>true если нет, false иначе</returns>
		public bool CheckStringOnDigit(string s)
		{
			foreach(var c in s)
			{
				if (char.IsDigit(c))
				{
					return false;
				}
			}
			return true;
		}

		public bool CheckStringOnPunctuation(string s)
		{
			foreach (var c in s)
			{
				if (char.IsPunctuation(c))
				{
					return false;
				}
			}
			return true;
		}

		public bool CheckStringOnLetter(string s)
		{
			foreach(var c in s)
			{
				if (char.IsLetter(c))
				{
					return false;
				}
			}
			return true;
		}

		public bool CheckStringOnDataFormat(string s)
		{
			var reg = new Regex(@"\d{2}.\d{2}.\d{4}");
			if (reg.IsMatch(s))
			{
				return true;
			}
			return false;
		}

		/// <summary>
		/// Метод вставки строки.
		/// </summary>
		public void InsertedCommand()
		{
			if (tableName == "Клиент")
			{
				//проверка на заполненность полей
				for (int i = 1; i < dataGridView1.ColumnCount; i++)
				{
					if (dataGridView1.Rows[dataGridView1.Rows.Count - 2].Cells[i].Value == null)
					{
						MessageBox.Show("Все поля должны быть заполнены!");
						return;
					}
				}

				var fio = dataGridView1.Rows[dataGridView1.Rows.Count - 2].Cells[1].Value.ToString();
				var phoneNumberS = dataGridView1.Rows[dataGridView1.Rows.Count - 2].Cells[2].Value.ToString();
				var seriesPassportS = dataGridView1.Rows[dataGridView1.Rows.Count - 2].Cells[3].Value.ToString();
				var numberPassport = dataGridView1.Rows[dataGridView1.Rows.Count - 2].Cells[4].Value.ToString();
				var issuedBy = dataGridView1.Rows[dataGridView1.Rows.Count - 2].Cells[5].Value.ToString();

				if (!CheckStringOnDigit(fio) || !CheckStringOnPunctuation(fio))
				{
					MessageBox.Show("Поле *ФИО* не может содержать цифры или знаки препинания!");
					return;
				}


				if (!CheckStringOnLetter(phoneNumberS) || !CheckStringOnPunctuation(phoneNumberS))
				{
					MessageBox.Show("Номер телефона не может содержать буквы или знаки препинания!");
					return;
				}

				var phoneNumber = decimal.Parse(dataGridView1.Rows[dataGridView1.Rows.Count - 2].Cells[3].Value.ToString());

				if (!CheckStringOnLetter(seriesPassportS) || !CheckStringOnPunctuation(seriesPassportS))
				{
					MessageBox.Show("Серия паспорта не может содержать цифры или знаки препинания!");
					return;
				}

				var seriesPassport = int.Parse(dataGridView1.Rows[dataGridView1.Rows.Count - 2].Cells[4].Value.ToString());

				if (!CheckStringOnLetter(numberPassport) || !CheckStringOnPunctuation(numberPassport))
				{
					MessageBox.Show("Номер паспорта не может содержать цифры или знаки препинания!");
					return;
				}

				if (!CheckStringOnDigit(issuedBy) || !CheckStringOnPunctuation(issuedBy))
				{
					MessageBox.Show("Поле *Кем выдан* не может содержать цифры или знаки препинания!");
					return;
				}
				var whenIssued = DateTime.Parse(dataGridView1.Rows[dataGridView1.Rows.Count - 2].Cells[6].Value.ToString());

				var clients = dataContext.GetTable<Client>();

				foreach (var cl in clients)
				{
					if (cl.CheckEquals(fio))
					{
						MessageBox.Show("Такой клиент уже существует!");
						return;
					}
				}

				var client = new Client();

				client.FIO = fio;
				client.PhoneNumber = phoneNumber;
				client.SeriaPassport = seriesPassport;
				client.NumberPassport = numberPassport;
				client.IssuedBy = issuedBy;
				client.WhenIssued = whenIssued;
			}

			else if (tableName == "Риелтор")
			{
				dataGridView1.Rows[dataGridView1.Rows.Count - 2].Cells[3].Value = dataContext.GetTable<RieltorsCompany>().First().Id;

				for (int i = 1; i < dataGridView1.ColumnCount; i++)
				{
					if (dataGridView1.Rows[dataGridView1.Rows.Count - 2].Cells[i].Value == null)
					{
						MessageBox.Show("Все поля должны быть заполнены!");
						return;
					}
				}

				var fio = dataGridView1.Rows[dataGridView1.Rows.Count - 2].Cells[1].Value.ToString();
				var phoneNumberS = dataGridView1.Rows[dataGridView1.Rows.Count - 2].Cells[2].Value.ToString();
				

				if (!CheckStringOnDigit(fio) || !CheckStringOnPunctuation(fio))
				{
					MessageBox.Show("Поле *ФИО* не может содержать цифры или знаки препинания!");
					return;
				}


				if (!CheckStringOnLetter(phoneNumberS) || !CheckStringOnPunctuation(phoneNumberS))
				{
					MessageBox.Show("Номер телефона не может содержать буквы или знаки препинания!");
					return;
				}
				var phoneNumber = decimal.Parse(dataGridView1.Rows[dataGridView1.Rows.Count - 2].Cells[2].Value.ToString());

				var rieltors = dataContext.GetTable<Rieltor>();

				foreach (var cl in rieltors)
				{
					if (cl.CheckEquals(fio))
					{
						MessageBox.Show("Такой риелтор уже существует!");
						return;
					}
				}

				var rieltor = new Rieltor();

				rieltor.FIO = fio;
				rieltor.PhoneNumber = phoneNumber;
				rieltor.IdCompany = dataContext.GetTable<RieltorsCompany>().First().Id;
			}
			else
			{
				var newValue = dataGridView1.Rows[dataGridView1.Rows.Count - 2].Cells[1].Value.ToString();

				//проверка на ввод
				if (!CheckStringOnDigit(newValue) || !CheckStringOnPunctuation(newValue))
				{
					MessageBox.Show("Значение не может содержать цифры или знаки препинания!");
					return;
				}

				if (tableName == "Назначение_объекта")
				{
					var objApps = dataContext.GetTable<ObjectAppointment>();
					foreach (var cl in objApps)
					{
						if (cl.CheckEquals(newValue))
						{
							MessageBox.Show("Такое поле уже существует!");
							return;
						}
					}
					var objApp = new ObjectAppointment();
					objApp.Name = newValue;
				}

				else if (tableName == "Статус_выполнения_услуги")
				{
					var serviceStatuses = dataContext.GetTable<ServiceStatus>();

					foreach (var cl in serviceStatuses)
					{
						if (cl.CheckEquals(newValue))
						{
							MessageBox.Show("Такое поле уже существует!");
							return;
						}
					}

					var serviceStatus = new ServiceStatus();
					serviceStatus.Name = newValue;
				}

				else if (tableName == "Улица")
				{
					var streets = dataContext.GetTable<Street>();

					foreach (var cl in streets)
					{
						if (cl.CheckEquals(newValue))
						{
							MessageBox.Show("Такое поле уже существует!");
							return;
						}
					}

					var street = new Street();
					street.Name = newValue;
				}

				else if (tableName == "Тип_услуги")
				{
					var typeServices = dataContext.GetTable<ServiceType>();

					foreach (var cl in typeServices)
					{
						if (cl.CheckEquals(newValue))
						{
							MessageBox.Show("Такое поле уже существует!");
							return;
						}
					}

					var typeService = new ServiceType();
					typeService.Name = newValue;
				}

				else if (tableName == "Тип_объекта")
				{
					var objTypes = dataContext.GetTable<TypeObj>();

					foreach (var cl in objTypes)
					{
						if (cl.CheckEquals(newValue))
						{
							MessageBox.Show("Такое поле уже существует!");
							return;
						}
					}

					var objType = new TypeObj();
					objType.Name = newValue;
				}

				else if (tableName == "Ремонт")
				{
					var repairs = dataContext.GetTable<Repair>();

					foreach (var cl in repairs)
					{
						if (cl.CheckEquals(newValue))
						{
							MessageBox.Show("Такое поле уже существует!");
							return;
						}
					}

					var repair = new Repair();
					repair.Name = newValue;
				}
			}
			dataContext.SubmitChanges();
		}

		/// <summary>
		/// Нажатие на кнопку добавить.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void button1_Click(object sender, EventArgs e)
		{
			if(tableName == null)
			{
				MessageBox.Show("Выберите таблицу для добавления записи!");
				return;
			}

			if(tableName == "Объект")
			{
				var f7 = new ObjectForm();
				f7.ShowDialog();
			}
			else
			{
				InsertedCommand();
			}
			GetDataTable();
		}

		/// <summary>
		/// Метод обновления строки.
		/// </summary>
		public void UpdateDataCommand()
		{
			var idElem = int.Parse(dataGridView1.Rows[rowIndex].Cells[0].Value.ToString());

			if (tableName == "Клиент")
			{
				//проверка на заполненность полей
				for (int i = 1; i < dataGridView1.ColumnCount; i++)
				{
					if (dataGridView1.Rows[rowIndex].Cells[i].Value == null)
					{
						MessageBox.Show("Все поля должны быть заполнены!");
						return;
					}
				}

				var fio = dataGridView1.Rows[rowIndex].Cells[1].Value.ToString();
				if (!CheckStringOnDigit(fio) || !CheckStringOnPunctuation(fio))
				{
					MessageBox.Show("Поле *ФИО* не может содержать цифры или знаки препинания!");
					return;
				}

				var phoneNumberS = dataGridView1.Rows[rowIndex].Cells[2].Value.ToString();
				if (!CheckStringOnLetter(phoneNumberS) || !CheckStringOnPunctuation(phoneNumberS))
				{
					MessageBox.Show("Номер телефона не может содержать буквы или знаки препинания!");
					return;
				}
				var phoneNumber = decimal.Parse(dataGridView1.Rows[rowIndex].Cells[2].Value.ToString());

				var seriesPassportS = dataGridView1.Rows[rowIndex].Cells[3].Value.ToString();
				if (!CheckStringOnLetter(seriesPassportS) || !CheckStringOnPunctuation(seriesPassportS))
				{
					MessageBox.Show("Серия паспорта не может содержать цифры или знаки препинания!");
					return;
				}
				var seriesPassport = int.Parse(dataGridView1.Rows[rowIndex].Cells[3].Value.ToString());

				var numberPassport = dataGridView1.Rows[rowIndex].Cells[4].Value.ToString();
				if (!CheckStringOnLetter(numberPassport) || !CheckStringOnPunctuation(numberPassport))
				{
					MessageBox.Show("Номер паспорта не может содержать цифры или знаки препинания!");
					return;
				}

				var issuedBy = dataGridView1.Rows[rowIndex].Cells[5].Value.ToString();
				if (!CheckStringOnDigit(issuedBy) || !CheckStringOnPunctuation(issuedBy))
				{
					MessageBox.Show("Поле *Кем выдан* не может содержать цифры или знаки препинания!");
					return;
				}

				var whenIssued = DateTime.Parse(dataGridView1.Rows[rowIndex].Cells[6].Value.ToString());

				var clients = dataContext.GetTable<Client>();

				//проверка на одинаковые элементы
				

				var client = dataContext.GetTable<Client>().Where(i => i.Id == idElem).First();

				client.FIO = fio;
				client.PhoneNumber = phoneNumber;
				client.SeriaPassport = seriesPassport;
				client.NumberPassport = numberPassport;
				client.IssuedBy = issuedBy;
				client.WhenIssued = whenIssued;
			}
			else if (tableName == "Риелтор")
			{
				for (int i = 1; i < dataGridView1.ColumnCount; i++)
				{
					if (dataGridView1.Rows[rowIndex].Cells[i].Value == null)
					{
						MessageBox.Show("Все поля должны быть заполнены!");
						return;
					}
				}

				var fio = dataGridView1.Rows[rowIndex].Cells[1].Value.ToString();
				var phoneNumberS = dataGridView1.Rows[rowIndex].Cells[2].Value.ToString();


				if (!CheckStringOnDigit(fio) || !CheckStringOnPunctuation(fio))
				{
					MessageBox.Show("Поле *ФИО* не может содержать цифры или знаки препинания!");
					return;
				}


				if (!CheckStringOnLetter(phoneNumberS) || !CheckStringOnPunctuation(phoneNumberS))
				{
					MessageBox.Show("Номер телефона не может содержать буквы или знаки препинания!");
					return;
				}
				var phoneNumber = decimal.Parse(dataGridView1.Rows[rowIndex].Cells[2].Value.ToString());

				var rieltor = dataContext.GetTable<Rieltor>().Where(i => i.Id == idElem).First();

				rieltor.FIO = fio;
				rieltor.PhoneNumber = phoneNumber;
			}
			else
			{
				var newValue = dataGridView1.Rows[rowIndex].Cells[1].Value.ToString();
				//проверка на ввод
				if (!CheckStringOnDigit(newValue) || !CheckStringOnPunctuation(newValue))
				{
					MessageBox.Show("Значение не может содержать цифры или знаки препинания!");
					return;
				}

				if (tableName == "Назначение_объекта")
				{
					var objApp = dataContext.GetTable<ObjectAppointment>().Where(i => i.Id == idElem).First();
					objApp.Name = newValue;
				}

				else if (tableName == "Статус_выполнения_услуги")
				{
					

					var serviceStatus = dataContext.GetTable<ServiceStatus>().Where(i => i.Id == idElem).First();

					serviceStatus.Name = newValue;
				}

				else if (tableName == "Улица")
				{
					var street = dataContext.GetTable<Street>().Where(i => i.Id == idElem).First();
					street.Name = newValue;
				}

				else if (tableName == "Тип_услуги")
				{
					var typeService = dataContext.GetTable<ServiceType>().Where(i => i.Id == idElem).First();

					typeService.Name = newValue;
				}

				else if (tableName == "Тип_объекта")
				{
					var objType = dataContext.GetTable<TypeObj>().Where(i => i.Id == idElem).First();
					objType.Name = newValue;
				}

				else if (tableName == "Ремонт")
				{
					var repair = dataContext.GetTable<Repair>().Where(i => i.Id == idElem).First();
					repair.Name = newValue;
				}
			}
			dataContext.SubmitChanges();
		}

		/// <summary>
		/// Нажатие на кнопку изменить.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void button2_Click(object sender, EventArgs e)
		{
			if (tableName == null)
			{
				MessageBox.Show("Выберите таблицу для добавления записи!");
				return;
			}

			if (rowIndex == -1)
			{
				MessageBox.Show("Выберите запись которую хотите изменить!");
				return;
			}

			if (tableName == "Объект")
			{
				var index = int.Parse(dataGridView1.Rows[rowIndex].Cells[0].Value.ToString());
				var s = from elem in dataContext.GetTable<Apartament>()
						where elem.Id == index
						select elem;
				var f = s.First();
				var f7 = new ObjectForm(f);
				f7.ShowDialog();
			}
			else
			{
				UpdateDataCommand();
			}
			GetDataTable();
		}

		/// <summary>
		/// Получение индекса выделенной строки.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			rowIndex = e.RowIndex;
		}

		private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
		{
			if (tableName == "Клиент")
			{
				if(e.ColumnIndex == 6)
				{
					MessageBox.Show("Поле должно иметь формат мм.дд.гггг !");
				}
				else 
				{
					MessageBox.Show("Поле не может содержать буквы или знаки препинания!");
				}
			}
		}
		
	}
}
