using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace PuzzleCareerSwitch.Model
{
    public static class RequestHandler
    {
        static string Email = "jssalasaro@gmail.com";
        static string Url = "https://rooftop-career-switch.herokuapp.com/";

        public static string GetToken()
        {
            var urlWithToken = $"{Url}token?email={Email}";
            var httpWebRequest = (HttpWebRequest)WebRequest.Create(urlWithToken);
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "GET";

            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
                dynamic results = JsonConvert.DeserializeObject<dynamic>(result);
                return results["token"].ToString();
            }

            return string.Empty;
        }

        public static bool GetIssequence(string token, string sequence1, string sequence2)
        {
            var urlWithToken = $"{Url}check?token={token}";
            var httpWebRequest = (HttpWebRequest)WebRequest.Create(urlWithToken);
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "POST";

            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                string json = $"{{\"blocks\" : [ \"{sequence1}\",\"{sequence2}\" ] }}";

                streamWriter.Write(json);
            }

            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
                dynamic results = JsonConvert.DeserializeObject<dynamic>(result);
                return (bool)results["message"];
            }

            return false;
        }     

        public static JToken GetBlocks(string token)
        {
            var urlWithToken = $"{Url}blocks?token={token}";
            var httpWebRequest = (HttpWebRequest)WebRequest.Create(urlWithToken);
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "GET";

            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
                dynamic results = JsonConvert.DeserializeObject<dynamic>(result);
                return results["data"];
            }

            return null;
        }
    }
}
