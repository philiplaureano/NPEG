﻿using System.Text;
using NUnit.Framework;

namespace RobustHaven.Text.Npeg.Tests
{
	[TestFixture]
	public class InputIteratorTests
	{
		[Test]
		public void StringInputIterator_InitializationTest()
		{
			var iterator = new StringInputIterator(
				Encoding.ASCII.GetBytes(""));
			Assert.IsTrue(iterator.Length == 0);
			Assert.IsTrue(iterator.Index == 0);
			Assert.IsTrue(iterator.Current() == -1);
			Assert.IsTrue(iterator.Next() == -1);
			Assert.IsTrue(iterator.Previous() == -1);
		}
	}
}