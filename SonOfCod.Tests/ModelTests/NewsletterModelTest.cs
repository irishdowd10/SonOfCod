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
			newsletter.Name = "John";

			//Act
			var result = newsletter.Name;

			//Assert
			Assert.Equal("John", result);
		}
    }
}
