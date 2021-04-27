namespace Pluralize
{
	public static class PluralizeTask
	{
		public static string PluralizeRubles(int count)
		{
			if (count % 10 >= 5 || count % 10 == 0)
			{
				return "рублей";
			}
			else if (count % 100 >= 11 && count % 100 <= 14)
			{
				return "рублей";
			}
			else if (count % 10 == 1)
			{
				return "рубль";
			}
			else return "рубля";
		}
	}
}