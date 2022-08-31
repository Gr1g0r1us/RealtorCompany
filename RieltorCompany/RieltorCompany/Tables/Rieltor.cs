using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq.Mapping;

namespace RieltorCompany.Tables
{
	[Table(Name ="Риелтор")]
	public class Rieltor
	{
		[Column(Name ="Код_риелтора", IsPrimaryKey = true,IsDbGenerated = true)]
		public int Id { get; set; }

		[Column(Name ="ФИО")]
		public string FIO { get; set; }

		[Column(Name = "Номер_телефона")]
		public decimal PhoneNumber { get; set; }

		[Column(Name = "Название_компании")]
		public string IdCompany { get; set; }

		public bool CheckEquals(string name)
		{
			if (FIO == name)
			{
				return true;
			}
			return false;
		}
	}
}
