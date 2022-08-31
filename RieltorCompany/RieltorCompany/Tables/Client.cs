using System;
using System.Data.Linq.Mapping;

namespace RieltorCompany.Tables
{
	[Table(Name = "Клиент")]
	public class Client
	{
		[Column(Name = "Код_клиента", IsPrimaryKey =true, IsDbGenerated =true)]
		public int Id { get; set; }

		[Column(Name ="ФИО")]
		public string FIO { get; set; }

		[Column(Name ="Номер_телефона")]
		public decimal PhoneNumber { get; set; }

		[Column(Name ="Серия_паспорта")]
		public int SeriaPassport { get; set; }

		[Column(Name ="Номер_паспорта")]
		public string NumberPassport { get; set; }

		[Column(Name ="Кем_выдан")]
		public string IssuedBy { get; set; }

		[Column(Name = "Дата_выдачи")]
		public DateTime WhenIssued { get; set; }

		public bool CheckEquals(string fio)
		{
			if (FIO == fio)
			{
				return true;
			}
			return false;
		}
	}
}
