using System;
using Moq;
using NUnit.Framework;


namespace TestProject1.Moq
{

    [TestFixture]
    public class UserServiceTests
    {
        [Test]
        public void GetUserById_Should_Return_User_With_Given_Id()
        {
            // Arrange
            var userId = 123;
            var expectedUser = new User { Id = userId, Name = "John Doe" };

            var userRepositoryMock = new Mock<IUserRepository>();
            userRepositoryMock.Setup(repo => repo.GetUserById(userId))
                              .Returns(expectedUser);

            var userService = new UserService(userRepositoryMock.Object);

            // Act
            var actualUser = userService.GetUserById(userId);

            // Assert
            Assert.AreEqual(expectedUser, actualUser);
        }
    }


}
