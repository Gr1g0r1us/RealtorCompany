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
	public partial class Form8 : Form
	{
		static string connectionString = @"Data Source=DESKTOP-P0Q5PCQ\SQLEXPRESS;Initial Catalog=RealComp;Integrated Security=True";

		DataContext dataContext = null;

		ChooseObjectForm form6;

		private int rowIndex;

		private int idApartament = 0;
		public Form8()
		{
			InitializeComponent();
			LoadTables();
		}

		public void LoadTables()
		{
			dataContext = new DataContext(connectionString);

			var fioClient = dataContext.GetTable<Client>().Select(i => i.FIO);
			comboBox1.DataSource = fioClient;
		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		public string ReturnData()
		{
			return dataGridView1.Rows[rowIndex].Cells[0].Value.ToString();
		}

		private void button6_Click(object sender, EventArgs e)
		{
			form6 = new ChooseObjectForm();
			form6.ShowDialog();

			if (form6.DialogResult == DialogResult.OK)
			{
				idApartament = int.Parse(form6.ReturnData());
			}
			var s = dataContext.GetTable<Apartament>().Where(i => i.Id == idApartament).Select(i => new { i.Street, i.NumberHouse, i.NumberApartment }).First();
			var s1 = s.Street + ", " + s.NumberHouse + ", " + s.NumberApartment;
			textBox1.Text = s1;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.OK;
		}

		private void button2_Click(object sender, EventArgs e)
		{
			var contracts = dataContext.GetTable<Contract>().Where(i=> i.IdClient == dataContext.GetTable<Client>().Where(j=>j.FIO == comboBox1.Text).Select(z=>z.Id).First() ).Select(i=> new { i.Id }); //&& i.IdApparamet == idApartament
			dataGridView1.DataSource = contracts;

		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			rowIndex = e.RowIndex;
		}
	}
}
