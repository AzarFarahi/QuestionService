using PairingTest.Web.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PairingTest.Unit.Tests.Web.Stubs
{
    //The Mock class on IQuestionResult to be used in the test cases
    public class FakeQuestionResult : IQuestionResult
    {
        public string JsonResult()
        {
            return "{\"QuestionnaireTitle\":\"My expected questions\",\"QuestionsText\":[\"I have no questions as I have expected it all!\"]}";
        }
    }
}


