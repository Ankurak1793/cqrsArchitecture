using Demo.Controllers;
using Demo.Core.Commands;
using Demo.Core.Models;
using Demo.Core.Queries;
using Demo.ViewModels;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Moq;

namespace Demo.Tests.Controllers
{

    [TestFixture]
    public class BlogControllerTests
    {
        private Mock<IMediator> mediatorMock;
        private BlogController blogController;
        [SetUp]
        public void Setup()
        {
            // Arrange
            mediatorMock = new Mock<IMediator>();
            blogController = new BlogController(mediatorMock.Object);
        }
        [Test]
        public async Task CreateBlog_WithValidModel_ReturnsOk()
        {
            // Arrange
            var model = new BlogViewModel { Name = "Test Blog", Content = "Test Content" };
            mediatorMock
                .Setup(x => x.Send(It.IsAny<CreateBlogCommand>(), CancellationToken.None))
                .ReturnsAsync(true);
            // Act
            var result = await blogController.CreateBlog(model);
            // Assert
            Assert.That(result, Is.TypeOf<OkObjectResult>());
        }

        [Test]
        public async Task GetBlogById_WithValidId_ReturnsOk()
        {
            // Arrange
            int validBlogId = 1;
            var blogDetails = new BlogDTO { Name = "Test Blog", Content = "Test Content" };
            mediatorMock
                .Setup(x => x.Send(It.IsAny<GetBlogsByIdQuery>(), CancellationToken.None))
                .ReturnsAsync(blogDetails);
            // Act
            var result = await blogController.GetBlogById(validBlogId);
            // Assert
            Assert.That(result, Is.TypeOf<OkObjectResult>());
            dynamic okResult = (OkObjectResult)result;
            Assert.That(okResult?.Value?.Data, Is.EqualTo(blogDetails));
        }

    }

}