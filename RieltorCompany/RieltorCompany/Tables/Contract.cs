using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq.Mapping;

namespace RieltorCompany
{
	[Table(Name = "Договор")]
	public class Contract
	{
		[Column(Name = "Код_договора",IsPrimaryKey = true, IsDbGenerated = true)]
		public int Id { get; set; }

		[Column(Name = "Номер_договора")]
		public string NumberContract { get; set; }

		[Column(Name = "Код_риелтора")]
		public int IdRieltor { get; set; }

		[Column(Name = "Код_клиента")]
		public int IdClient { get; set; }

		[Column(Name ="Дата_заключения")]
		public DateTime DateContract { get; set; }

		[Column(Name = "Дата_выполнения_услуги")]
		public DateTime DateEndService { get; set; }

		[Column(Name = "Код_услуги")]
		public int IdService { get; set; }

		[Column(Name = "Стоимость_услуги")]
		public int CostService { get; set; }

		[Column(Name = "Название_компании")]
		public string IdCompany { get; set; }

		[Column(Name ="Код_объекта")]
		public int? IdApparamet { get; set; }
	}
}
