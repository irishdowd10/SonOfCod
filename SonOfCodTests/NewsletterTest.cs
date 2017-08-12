using System;
using System.Collections.Generic;
using System.Text;
using SonOfCod.Models;
using Xunit;

namespace SonOfCodTests
{
    class NewsletterTest
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
