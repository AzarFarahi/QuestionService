using NUnit.Framework;
using PairingTest.Unit.Tests.Web.Stubs;
using PairingTest.Web.Controllers;
using PairingTest.Web.Models;

namespace PairingTest.Unit.Tests.Web
{
    [TestFixture]
    public class QuestionnaireControllerTests
    {
        [Test]
        public void ShouldGetQuestions()
        {
            //Arrange
            var expectedTitle = "My expected questions";
            var questionResult = new FakeQuestionResult();
            var questionnaireController = new QuestionnaireController(questionResult);

            //Act
            var result = (QuestionnaireViewModel)questionnaireController.Index().ViewData.Model;

            //Assert
            Assert.That(result.QuestionnaireTitle, Is.EqualTo(expectedTitle));
        }
    }
}