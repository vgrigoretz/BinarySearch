using NUnit.Framework;

namespace BinarySearch.Test
{
	class SearchTest
	{
		int nr = 11;
		int[] empty_array = { };
		int[] array = { 1, 3, 5, 7 };


		Search search = new Search();

		[Test]
		public void Return_neggative_two_for_empty_array()
		{
			Assert.AreEqual(-2, search.SearchNumber(4, empty_array));
		}

		[Test]
		public void Return_neggative_one_for_number_not_present_in_array()
		{
			Assert.AreEqual(-1, search.SearchNumber(2, array));
		}

		[Test]
		public void Return_index_1_for_number_1_present_in_array()
		{
			Assert.AreEqual(1, search.SearchNumber(1, array));
		}

		[Test]
		public void Return_index_2_for_number_3_present_in_array()
		{
			Assert.AreEqual(2, search.SearchNumber(3, array));
		}

		[Test]
		public void Return_index_4_for_number_7_present_in_array()
		{
			Assert.AreEqual(4, search.SearchNumber(7, array));
		}
	}
}
