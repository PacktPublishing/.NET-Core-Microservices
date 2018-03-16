using System;
using System.Security.Claims;
using System.Threading.Tasks;
using Actio.Api.Controllers;
using Actio.Api.Repositories;
using Actio.Common.Commands;
using FluentAssertions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Moq;
using RawRabbit;
using Xunit;

namespace Actio.Api.Tests.Unit.Controllers
{
    public class ActivitiesControllerTests
    {
        [Fact]
        public async Task activities_controller_post_should_return_accepted()
        {
            var busClientMock = new Mock<IBusClient>();
            var activityRepositoryMock = new Mock<IActivityRepository>();
            var controller = new ActivitiesController(busClientMock.Object,
                activityRepositoryMock.Object);
            var userId = Guid.NewGuid();
            controller.ControllerContext = new ControllerContext
                {
                    HttpContext = new DefaultHttpContext
                    {
                        User = new ClaimsPrincipal(new ClaimsIdentity(new Claim[]
                        {
                            new Claim(ClaimTypes.Name, userId.ToString())
                        }, "test"))
                    }
                };

            var command = new CreateActivity
            {
                Id = Guid.NewGuid(),
                UserId = userId
            };

            var result = await controller.Post(command);
            
            var contentResult = result as AcceptedResult;
            contentResult.Should().NotBeNull();
            contentResult.Location.ShouldBeEquivalentTo($"activities/{command.Id}");
        }        
    }
}