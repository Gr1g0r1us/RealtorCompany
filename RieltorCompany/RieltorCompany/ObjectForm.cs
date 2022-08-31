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
	public partial class ObjectForm : Form
	{
		static string connectionString = @"Data Source=DESKTOP-P0Q5PCQ\SQLEXPRESS;Initial Catalog=RealComp;Integrated Security=True";

		DataContext dataContext = null;

		private bool insertOrUpdate;

		private Apartament updateApartament = null;

		public ObjectForm()
		{
			insertOrUpdate = true;
			InitializeComponent();
			LoadTables();
		}

		public ObjectForm(Apartament apartament)
		{
			insertOrUpdate = false;
			updateApartament = apartament;
			InitializeComponent();
			LoadRow();
		}

		public bool CheckStringOnDigit(string s)
		{
			foreach (var c in s)
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
			foreach (var c in s)
			{
				if (char.IsLetter(c))
				{
					return false;
				}
			}
			return true;
		}


		private void AddRow()
		{
			dataContext = new DataContext(connectionString);
			

			var apartaments = dataContext.GetTable<Apartament>();

			foreach (var cl in apartaments)
			{
				if (cl.CheckEquals(dataContext.GetTable<Street>().Where(i => i.Name == comboBox4.Text).First().Id, (int)numericUpDown8.Value, (int)numericUpDown9.Value))
				{
					MessageBox.Show("Такой объект уже существует!");
					return;
				}
			}

			var apartament = new Apartament();
			apartament.TypeObj = dataContext.GetTable<TypeObj>().Where(i => i.Name == comboBox1.Text).First().Id;
			apartament.ObjAppointment = dataContext.GetTable<ObjectAppointment>().Where(i => i.Name == comboBox2.Text).First().Id;
			apartament.Street = dataContext.GetTable<Street>().Where(i => i.Name == comboBox4.Text).First().Id;
			apartament.NumberHouse = (int)numericUpDown8.Value;
			apartament.NumberApartment = (int)numericUpDown9.Value;
			var allSquare = textBox1.Text;
			var kSquare = textBox1.Text;
			var lSquare = textBox1.Text;
			if (!CheckStringOnLetter(allSquare)|| !CheckStringOnLetter(kSquare)|| !CheckStringOnLetter(lSquare))
			{
				MessageBox.Show("Площадь не может содержать буквы!");
				return;
			}

			apartament.AllSquare = decimal.Parse(textBox1.Text);
			apartament.LifeSquare = decimal.Parse(textBox2.Text);
			apartament.KitchenSquare = decimal.Parse(textBox4.Text);
			apartament.CountRoom = (int)numericUpDown4.Value;
			apartament.CountBathroom = (int)numericUpDown5.Value;
			apartament.Repair = dataContext.GetTable<Repair>().Where(i => i.Name == comboBox11.Text).First().Id;
			apartament.Comment = textBox3.Text;
			apartament.FirstFloor = checkBox1.Checked;
			apartament.LastFloor = checkBox2.Checked;
			apartament.CountFloor = (int)numericUpDown6.Value;
			apartament.Cost = (int)numericUpDown7.Value;


			apartaments.InsertOnSubmit(apartament);

			dataContext.SubmitChanges();
		}

		private void UpdateRow()
		{
			dataContext = new DataContext(connectionString);
			if (checkBox1.Checked == true && checkBox2.Checked == true)
			{
				MessageBox.Show("Объект не может быть одновременно первым и последним этажом!");
				return;
			}

			var apartament = dataContext.GetTable<Apartament>().Where(i => i.Id == updateApartament.Id).First();
			apartament.TypeObj = dataContext.GetTable<TypeObj>().Where(i => i.Name == comboBox1.Text).First().Id;
			apartament.ObjAppointment = dataContext.GetTable<ObjectAppointment>().Where(i => i.Name == comboBox2.Text).First().Id;
			apartament.Street = dataContext.GetTable<Street>().Where(i => i.Name == comboBox4.Text).First().Id;
			apartament.NumberHouse = (int)numericUpDown8.Value;
			apartament.NumberApartment = (int)numericUpDown9.Value;
			apartament.AllSquare = decimal.Parse(textBox1.Text);
			apartament.LifeSquare = decimal.Parse(textBox2.Text);
			apartament.KitchenSquare = decimal.Parse(textBox4.Text);
			apartament.CountRoom = (int)numericUpDown4.Value;
			apartament.CountBathroom = (int)numericUpDown5.Value;
			apartament.Repair = dataContext.GetTable<Repair>().Where(i => i.Name == comboBox11.Text).First().Id;
			apartament.Comment = textBox3.Text;
			apartament.FirstFloor = checkBox1.Checked;
			apartament.LastFloor = checkBox2.Checked;
			apartament.CountFloor = (int)numericUpDown6.Value;
			apartament.Cost = (int)numericUpDown7.Value;

			dataContext.SubmitChanges();
		}

		public void LoadRow()
		{
			LoadTables();
			var typeObjs = dataContext.GetTable<TypeObj>().Where(i => i.Id == updateApartament.TypeObj).First().Name;
			var objApp = dataContext.GetTable<ObjectAppointment>().Where(i => i.Id == updateApartament.ObjAppointment).First().Name;
			var repair = dataContext.GetTable<Repair>().Where(i => i.Id == updateApartament.Repair).First().Name;
			var street = dataContext.GetTable<Street>().Where(i => i.Id == updateApartament.Street).First().Name;
			comboBox1.SelectedItem = typeObjs;
			comboBox2.SelectedItem = objApp;
			comboBox4.SelectedItem = updateApartament.Street;
			numericUpDown8.Value = updateApartament.NumberHouse;
			numericUpDown9.Value = updateApartament.NumberApartment;
			textBox1.Text = updateApartament.AllSquare.ToString();
			textBox1.Text = updateApartament.LifeSquare.ToString();
			textBox4.Text = updateApartament.KitchenSquare.ToString();
			numericUpDown4.Value = updateApartament.CountRoom;
			numericUpDown5.Value = updateApartament.CountBathroom;
			comboBox11.SelectedItem = repair;
			checkBox1.Checked = updateApartament.FirstFloor;
			checkBox2.Checked = updateApartament.LastFloor;
			numericUpDown6.Value = updateApartament.CountFloor;
			textBox3.Text = $"{updateApartament.Comment}";
			numericUpDown7.Value = updateApartament.Cost;
		}

		public void LoadTables()
		{
			dataContext = new DataContext(connectionString);

			Table<ObjectAppointment> objectAppointments = dataContext.GetTable<ObjectAppointment>();
			var objApp = objectAppointments.Select(i => i.Name);
			comboBox2.DataSource = objApp;


			Table<TypeObj> objType = dataContext.GetTable<TypeObj>();
			var oT = objType.Select(i => i.Name);
			comboBox1.DataSource = oT;

			Table<Repair> repairs = dataContext.GetTable<Repair>();
			var sT = repairs.Select(i => i.Name);
			comboBox11.DataSource = sT;

			Table<Street> streets = dataContext.GetTable<Street>();
			var str = streets.Select(i => i.Name);
			comboBox4.DataSource = str;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (insertOrUpdate)
			{
				AddRow();
			}
			else
			{
				UpdateRow();
			}
			Close();
		}


		private void Form7_Load(object sender, EventArgs e)
		{

		}

		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBox1.Checked == false) 
			{
				checkBox2.Enabled = true;
			}
			else
			{
				checkBox2.Enabled = false;
			}
		}

		private void checkBox2_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBox2.Checked == false)
			{
				checkBox1.Enabled = true;
			}
			else
			{
				checkBox1.Enabled = false;
			}
		}
	}
}
