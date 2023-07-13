using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities;

namespace ClassTypeExercisesApplication
{
	internal class Program
	{
		static void Main(string[] args)
		{
			UseCurrencyFormatter();
			Console.ReadLine();
		}

		private static void UseCurrencyFormatter()
		{
			List<decimal> values = new List<decimal>{2574.8m,32423,423423};

			foreach (var value in values)
			{

				string formattedValue = value.DisplayAsCurrency();

				Console.WriteLine(formattedValue);
            }
		}
	}
}
