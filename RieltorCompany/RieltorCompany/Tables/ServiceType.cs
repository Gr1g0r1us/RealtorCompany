using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq.Mapping;

namespace RieltorCompany
{
	[Table(Name = "Тип_услуги")]
	public class ServiceType
	{
		[Column(Name ="Код_услуги",IsPrimaryKey =true,IsDbGenerated =true)]
		public int Id { get; set; }

		[Column(Name ="Наименование_услуги")]
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
