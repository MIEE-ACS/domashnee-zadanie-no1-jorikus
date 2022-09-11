using System;

namespace homework1{
	class Program{
		static bool CheckNumber(string s) //Функция для проверки строки на содержание символов(для преобразования в число)
        {
			foreach (char item in s) //Цикл для поочередного обращения к элементам строки
			{
				if (item != ',')
				{
					if (char.IsDigit(item) == false) // IsDigit функция определяет относится ли символ к категории чисел
					{
						return true;
					}
				}
			}
			return false;
		}

		static void Main(string[] args)
		{
			Console.Write("Введите площадь круга(если число дробное, вводить через запятую): ");
			string s = Console.ReadLine();
			while (CheckNumber(s))
            {
				Console.Write("\nОшибка. Введите число: ");
				s = Console.ReadLine();
            }

			double S = Convert.ToDouble(s);
			double D = Math.Sqrt((4 * S) / Math.PI);
			double L = Math.PI * D;

			Console.Write($"\n\nДиаметр равен: {D}\nДлинна окружности равна: {L}\n\n");
		}
	}
}
