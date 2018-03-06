using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web.Mvc;
using Newtonsoft.Json;
using PairingTest.Web.Logic;
using PairingTest.Web.Models;

namespace PairingTest.Web.Controllers
{
    public class QuestionnaireController : Controller
    {
        private IQuestionResult _questionResult;
        public QuestionnaireController(IQuestionResult questionResult)
        {
            _questionResult = questionResult;
        }

        public QuestionnaireController() : this(new QuestionResult())
        {
        }

        public ViewResult Index()
        {
            var result = _questionResult.JsonResult();

            QuestionnaireViewModel questions = null;
            if (result != null)
            {
                questions = JsonConvert.DeserializeObject<QuestionnaireViewModel>(result);
            }
            else
            {
                questions = new QuestionnaireViewModel();

                ModelState.AddModelError(string.Empty, "Server error.");
            }


            return View(questions);
        }
    }
}
