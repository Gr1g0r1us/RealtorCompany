using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq.Mapping;

namespace RieltorCompany
{
	[Table(Name ="Ремонт")]
	public class Repair
	{
		[Column(Name = "Код_ремонта",IsPrimaryKey = true,IsDbGenerated = true)]
		public int Id { get; set; }
		[Column(Name ="Состояние_ремонта")]
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
