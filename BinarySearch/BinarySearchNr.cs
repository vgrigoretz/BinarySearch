using System;
namespace BinarySearch
{
	public class BinarySearchNr
	{
		public int BinarySearchNumber(int nr, int[] array)
		{
			int min = 0;
			int max = array.Length - 1;

			if (max <= 0)
			{
				throw new ArgumentNullException();
			}

			while (min <= max)
			{
				int mid = (min + max) / 2;
				if (nr == array[mid])
				{
					return ++mid;
				}
				else if(nr < array[mid])
				{
					max = mid - 1;
				}
				else
				{
					min = mid + 1;
				}
			}
			return -1;
		}
	}
}
