using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq.Mapping;

namespace RieltorCompany.Tables
{
	[Table(Name ="Состояние_выполнения_услуги")]
	public class ConditionService
	{
		[Column(Name ="Дата_изменения_статуса_выполнения_услуги" )]
		public DateTime DateUpdate { get; set; }

		[Column(Name = "Комментарий")]
		public string Comment { get; set; }

		[Column(Name ="Код_договора", IsPrimaryKey = true)]
		public int IdContract { get; set; }

		[Column(Name = "Код_статуса", IsPrimaryKey = true)]
		public int IdServiceStatus { get; set; }
	}
}
