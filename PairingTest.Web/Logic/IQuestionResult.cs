using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PairingTest.Web.Logic
{
    //Interface used to create Dependency injection for the Questionnaire Controller
    public interface IQuestionResult
    {
        string JsonResult();
    }
}
