using System.Collections.Generic;
using Domain.DataWrapper.Interface;
using Domain.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace DomainTests
{
    [TestClass]
    public class MessageUnitTest
    {

        [TestMethod]
        public void ShouldRetrieveMessagesFromDatabase()
        {
            //Arrange
            var mockedMessageList = new List<Message> { new Message(), new Message() };

            var dataMock = new Mock<IDataWrapper<Message>>();
            dataMock.Setup(mock => mock.RetrieveList()).Returns(mockedMessageList);

            var message = new Message { UserId = 1, DataWrapper = dataMock.Object };

            //Act
            var messageList = message.RetrieveAllMessages();

            //Assert
            Assert.IsTrue(messageList.Count == 2);

        }
    }
}
