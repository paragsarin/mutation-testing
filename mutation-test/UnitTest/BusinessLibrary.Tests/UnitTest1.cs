using EmailLibrary;
using Moq;
using NUnit.Framework;

namespace BusinessLibrary.Tests
{
    public class Tests
    {
       private Mock<IEmail> emailMock;
        [SetUp]
        public void Setup()
        {
            emailMock = new Mock<IEmail>();
            //arrange
            emailMock.Setup(c => c.SendEmail()).Returns(true);

        }

        [Test]
        public void SendOrder_SendEmail_ReturnsSuccess()
        {
            SendOrder order = new SendOrder();
            //Act
            bool success= order.Send(1, emailMock.Object);
            //Assert  
            Assert.IsTrue(success == true);

        }
        [Test]
        public void SendOrder_ReturnsFail()
        {
            SendOrder order = new SendOrder();
            //Act
            bool success = order.Send(-1, emailMock.Object);
            //Assert
            Assert.True(success == false);



        }
    }
}