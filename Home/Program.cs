using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home
{
	internal class Program
	{
		
    // Метод для вычисления расстояния между двумя точками
    static double Distance(double x1, double y1, double x2, double y2)
		{
			// Вычисление разницы по координатам
			double deltaX = x2 - x1;
			double deltaY = y2 - y1;


			return Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
		}

		static void Main(string[] args)
		{
			// Пример вызова метода Distance
			double x1 = 3, y1 = 4;
			double x2 = 7, y2 = 1;

			double result = Distance(x1, y1, x2, y2);

			// Вывод результата
			Console.WriteLine($"Расстояние между точками ({x1}, {y1}) и ({x2}, {y2}) равно {result}");
		}
	}
}
