using System.Data.Linq.Mapping;

namespace RieltorCompany.Tables
{
	[Table(Name ="Объект")]
	public class Apartament
	{
		[Column(Name ="Код_объекта",IsPrimaryKey =true,IsDbGenerated =true)]
		public int Id { get; set; }

		[Column(Name ="Код_типа_объекта")]
		public int TypeObj { get; set; }

		[Column(Name ="Код_деятельности")]
		public int ObjAppointment { get; set; }

		[Column(Name ="Код_улицы")]
		public int Street { get; set; }

		[Column(Name ="Номер_дома")]
		public int NumberHouse { get; set; }

		[Column(Name ="Номер_квартиры")]
		public int NumberApartment { get; set; }
		
		[Column(Name = "Стоимость")]
		public int Cost { get; set; }

		[Column(Name = "Общая_площадь")]
		public decimal AllSquare { get; set; }

		[Column(Name = "Площадь_кухни")]
		public decimal KitchenSquare { get; set; }

		[Column(Name = "Жилая_площадь")]
		public decimal LifeSquare { get; set; }

		[Column(Name = "Количество_комнат")]
		public int CountRoom { get; set; }

		[Column(Name = "Количество_санузлов")]
		public int CountBathroom { get; set; }

		[Column(Name = "Код_ремонта")]
		public int Repair { get; set; }

		[Column(Name = "Комментарий")]
		public string Comment { get; set; }

		[Column(Name = "Первый_этаж")]
		public bool FirstFloor { get; set; }

		[Column(Name = "Последний_этаж")]
		public bool LastFloor { get; set; }

		[Column(Name = "Этажность_объекта")]
		public int CountFloor { get; set; }

		/// <summary>
		/// Проверка на уникальность объекта.
		/// </summary>
		/// <param name="street">Улица</param>
		/// <param name="numHouse">Номер дома</param>
		/// <param name="numApart">Номер квартиры</param>
		/// <returns>true,если найдено совпадение, false иначе</returns>
		public bool CheckEquals(int street, int numHouse, int numApart)
		{
			if( Street == street && NumberHouse == numHouse && NumberApartment == numApart)
			{
				return true;
			}
			return false;
		}
	}
}
