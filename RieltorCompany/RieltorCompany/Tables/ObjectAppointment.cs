using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq.Mapping;

namespace RieltorCompany
{
	[Table(Name ="Назначение_объекта")]
	public class ObjectAppointment
	{
		[Column(Name = "Код_деятельности",IsPrimaryKey = true, IsDbGenerated = true)]
		public int Id { get; set; }

		[Column(Name ="Наименование_деятельности")]
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
