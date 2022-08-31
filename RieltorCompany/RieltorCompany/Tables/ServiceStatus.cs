using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq.Mapping;

namespace RieltorCompany
{
	[Table(Name ="Статус_выполнения_услуги")]
	public class ServiceStatus
	{
		[Column(Name = "Код_статуса", IsPrimaryKey = true, IsDbGenerated = true)]
		public int Id { get; set; }

		[Column(Name ="Название_статуса")]
		public string Name { get; set; }

		public bool CheckEquals(string name)
		{
			if (Name == name)
			{
				return true;
			}
			return false;
		}
	}
}
