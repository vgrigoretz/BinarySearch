using NUnit.Framework;
using System;

namespace BinarySearch.Test
{
	class BinarySearchTest
	{
		BinarySearchNr binarySearch = new BinarySearchNr();
		int[] empty_array = { };
		int[] array = { 1, 3, 5, 7 }; 

		[Test]
		public void Throw_Arg_Exception_for_empty_array()
		{
			Assert.Throws(typeof(ArgumentNullException), () => binarySearch.BinarySearchNumber(4, empty_array));
		}

		[Test]
		public void Return_neggative_one_for_number_not_present_in_array()
		{
			Assert.AreEqual(-1, binarySearch.BinarySearchNumber(2, array));
		}

		[Test]
		public void Return_index_1_for_number_1_present_in_array()
		{
			Assert.AreEqual(1, binarySearch.BinarySearchNumber(1, array));
		}

		[Test]
		public void Return_index_2_for_number_3_present_in_array()
		{
			Assert.AreEqual(2, binarySearch.BinarySearchNumber(3, array));
		}

		[Test]
		public void Return_index_4_for_number_7_present_in_array()
		{
			Assert.AreEqual(4, binarySearch.BinarySearchNumber(7, array));
		}
	}
}
