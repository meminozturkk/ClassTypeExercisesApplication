using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilities
{
	public static class CurrencyFormatUtility
	{
		public static string DisplayAsCurrency(this decimal value)
		{
			return string.Format("{0:C} TL",value);
		}
	}
}
