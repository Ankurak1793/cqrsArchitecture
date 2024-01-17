using Demo.Controllers;
using Demo.Core.Commands;
using Demo.Core.ViewModels;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Moq;

namespace Demo.Tests.Controllers
{

    [TestFixture]
    public class CommentsControllerTests
    {
        private Mock<IMediator> mediatorMock;
        private CommentsController commentController;
        [SetUp]
        public void Setup()
        {
            // Arrange
            mediatorMock = new Mock<IMediator>();
            commentController = new CommentsController(mediatorMock.Object);
        }

        [Test]
        public async Task CreateComment_WithValidModel_ReturnsOk()
        {
            // Arrange
            var model = new CommentsViewModel { BlogId = 1, Comment = "Test Comment" };
            mediatorMock
                .Setup(x => x.Send(It.IsAny<CreateCommentCommand>(), CancellationToken.None))
                .ReturnsAsync(true);
            // Act
            var result = await commentController.CreateComment(model);
            // Assert
            Assert.That(result, Is.TypeOf<OkObjectResult>());
        }
    }
}