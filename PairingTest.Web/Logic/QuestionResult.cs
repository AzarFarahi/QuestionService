using PairingTest.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;
using System.Web.Configuration;

namespace PairingTest.Web.Logic
{
    //The class in charge of making the real call to the API
    public class QuestionResult : IQuestionResult
    {
        //This method calls the API and fetches the questions
        public string JsonResult()
        {
            var result = "";
            var url = WebConfigurationManager.AppSettings["QuestionnaireServiceUri"];
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Clear();

                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage responseTask = client.GetAsync(url).Result;

                if (responseTask.IsSuccessStatusCode)
                {
                    result = responseTask.Content.ReadAsStringAsync().Result;
                }

                return result;
            }
        }
    }
}