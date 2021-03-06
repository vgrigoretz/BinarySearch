﻿using System;

namespace BinarySearch
{
	public class Search
	{
		public int SearchNumber(int nr, int[] array)
		{
			//int length = array.Length;

			if (array.Length <= 0)
			{
				throw new ArgumentNullException();
			}

			for (int i = 0; i < array.Length; i++)
			{
				if (nr == array[i])
					return i + 1;
			}
			return -1;
		}
	}
}
