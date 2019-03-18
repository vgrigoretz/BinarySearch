using System;

namespace BinarySearch
{
	class Program
	{
		static void Main(string[] args)
		{
			int nr = 11;
			int[] array = { 1, 3, 5, 7, 9, 11 };


			var binarySearch = new BinarySearchNr();
			var binaryResult = binarySearch.BinarySearchNumber(nr, array);

			Console.WriteLine(binaryResult);
			Console.ReadKey();
		}
	}
}
