using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq.Mapping;

namespace RieltorCompany
{
	[Table(Name = "Тип_объекта")]
	public class TypeObj
	{
		[Column(Name = "Код_типа_объекта",IsPrimaryKey = true, IsDbGenerated = true)]
		public int Id { get; set; }
		[Column(Name = "Наименование_типа_объекта")]
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
