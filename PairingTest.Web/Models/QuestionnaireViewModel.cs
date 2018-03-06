using Newtonsoft.Json;
using System.Collections.Generic;

namespace PairingTest.Web.Models
{
    public class QuestionnaireViewModel
    {
        [JsonProperty("QuestionnaireTitle")]
        public string QuestionnaireTitle { get; set; }

        [JsonProperty("QuestionsText")]
        public IList<string> QuestionsText { get; set; }

    }
}