using Actio.Api.Controllers;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
using Xunit;

namespace Actio.Api.Tests.Unit.Controllers
{
    public class HomeControllerTests
    {
        [Fact]
        public void home_controller_get_should_return_string_content()
        {
            var controller = new HomeController();

            var result = controller.Get();
            
            var contentResult = result as ContentResult;
            contentResult.Should().NotBeNull();
            contentResult.Content.ShouldBeEquivalentTo("Hello from Actio API!");
        }
    }
}