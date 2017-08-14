using System;
using Xunit;
using SonOfCod.Models;

namespace SonOfCod.Tests
{
    public class NewsletterTest
    {
		[Fact]
		public void GetNameTest()
		{
			//Arrange
			var newsletter = new Newsletter();

			//Act
			var result = newsletter.Name;

			//Assert
			Assert.Equal("John", result);
		}
    }
}
