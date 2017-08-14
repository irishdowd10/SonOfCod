using System;
using Xunit;
using SonOfCod.Models;
using SonOfCod.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace SonOfCod.Tests
{
	public class NewsletterControllerTest
	{
		[Fact]
		public void Get_ViewResult_Index_Test()
		{
			//Arrange
			NewsletterController controller = new NewsletterController();

			//Act
			var result = controller.Index();

			//Assert
			Assert.IsType<ViewResult>(result);
		}
	}
}