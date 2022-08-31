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
	public partial class ChooseObjectForm : Form
	{
		static string connectionString = @"Data Source=DESKTOP-P0Q5PCQ\SQLEXPRESS;Initial Catalog=RealComp;Integrated Security=True";

		DataContext dataContext = null;
		private int rowIndex;

		public ChooseObjectForm()
		{
			InitializeComponent();
			LoadTables();
		}

		public ChooseObjectForm(string id)
		{
			InitializeComponent();
			LoadTables();
		}

		public void LoadTables()
		{
			dataContext = new DataContext(connectionString);

			var streets = dataContext.GetTable<Street>().Select(i => i.Name);
			comboBox1.DataSource = streets;
			comboBox1.Text = null;
		}


		private void button2_Click(object sender, EventArgs e)
		{
			dataContext = new DataContext(connectionString);

			var street = dataContext.GetTable<Street>().Where(i=> i.Name == comboBox1.Text).First().Name;

			var streets = dataContext.GetTable<Street>();

			var query = dataContext.GetTable<Apartament>().Join(streets, a => a.Street, s => s.Id, (a, s) => new { a.Id, s.Name, a.NumberHouse, a.NumberApartment }).Select(i => new { i.Id, i.Name, i.NumberHouse, i.NumberApartment });

			if (!string.IsNullOrEmpty(comboBox1.Text))
			{
				if(!string.IsNullOrEmpty(textBox1.Text))
				{
					var houseNum = int.Parse(textBox1.Text);
					if (!string.IsNullOrEmpty(textBox2.Text))
					{
						var apartNum = int.Parse(textBox2.Text);
						query = dataContext.GetTable<Apartament>().Join(streets, a => a.Street, s => s.Id, (a, s) => new { a.Id, s.Name, a.NumberHouse, a.NumberApartment }).Where(i => i.Name == street && i.NumberHouse== houseNum && i.NumberApartment == apartNum).Select(i => new { i.Id, i.Name, i.NumberHouse, i.NumberApartment });
						
					}
					else
					{
						query = dataContext.GetTable<Apartament>().Join(streets, a => a.Street, s => s.Id, (a, s) => new { a.Id, s.Name, a.NumberHouse, a.NumberApartment }).Where(i => i.Name == street && i.NumberHouse == houseNum).Select(i => new { i.Id, i.Name, i.NumberHouse, i.NumberApartment });
					}
				}
				else if(!string.IsNullOrEmpty(textBox2.Text))
				{
					var apartNum = int.Parse(textBox2.Text);
					query = dataContext.GetTable<Apartament>().Join(streets, a => a.Street, s => s.Id, (a, s) => new { a.Id, s.Name, a.NumberHouse, a.NumberApartment }).Where(i => i.Name == street && i.NumberApartment == apartNum).Select(i => new { i.Id, i.Name, i.NumberHouse, i.NumberApartment });

				}
				else
				{
					query = dataContext.GetTable<Apartament>().Join(streets, a => a.Street, s => s.Id, (a, s) => new { a.Id, s.Name, a.NumberHouse, a.NumberApartment }).Where(i => i.Name == street).Select(i => new { i.Id, i.Name, i.NumberHouse, i.NumberApartment });
				}
			}
			else if (!string.IsNullOrEmpty(textBox1.Text))
			{
				var houseNum = int.Parse(textBox1.Text);
				if (!string.IsNullOrEmpty(textBox2.Text))
				{
					var apartNum = int.Parse(textBox2.Text);
					query = dataContext.GetTable<Apartament>().Join(streets, a => a.Street, s => s.Id, (a, s) => new { a.Id, s.Name, a.NumberHouse, a.NumberApartment }).Where(i => i.NumberHouse == houseNum && i.NumberApartment == apartNum).Select(i => new { i.Id, i.Name, i.NumberHouse, i.NumberApartment });
				}
				else
				{
					query = dataContext.GetTable<Apartament>().Join(streets, a => a.Street, s => s.Id, (a, s) => new { a.Id, s.Name, a.NumberHouse, a.NumberApartment }).Where(i =>  i.NumberHouse == houseNum).Select(i => new { i.Id, i.Name, i.NumberHouse, i.NumberApartment });
				}
			}
			else if (!string.IsNullOrEmpty(textBox2.Text))
			{
				var apartNum = int.Parse(textBox2.Text);
				query = dataContext.GetTable<Apartament>().Join(streets, a => a.Street, s => s.Id, (a, s) => new { a.Id, s.Name, a.NumberHouse, a.NumberApartment }).Where(i => i.NumberApartment == apartNum).Select(i => new { i.Id, i.Name, i.NumberHouse, i.NumberApartment });
			}

			dataGridView1.DataSource = query;
			dataGridView1.Columns[0].Visible = false;
			dataGridView1.Columns[1].HeaderText = "Улица";
			dataGridView1.Columns[2].HeaderText = "Дом";
			dataGridView1.Columns[3].HeaderText = "Квартира";

		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		public string ReturnData()
		{
			return dataGridView1.Rows[rowIndex].Cells[0].Value.ToString();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.OK;
		}

		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			rowIndex = e.RowIndex;
		}
	}
}
