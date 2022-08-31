using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq.Mapping;

namespace RieltorCompany
{
	[Table(Name ="Риелторская_компания")]
	public class RieltorsCompany
	{
		[Column(Name = "Название_компании",IsPrimaryKey = true)]
		public string Id { get; set; }
		[Column(Name ="Директор")]
		public string Director { get; set; }

		public bool CheckEquals(string name)
		{
			if (Id == name)
			{
				return true;
			}
			return false;
		}
	}
}
