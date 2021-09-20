using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
using Microsoft.Extensions.Configuration;
using Flurl;

namespace GoogleCloudServiceAPI.Data
{
    public class GoogleService : IGoogleService
    {
        private readonly string GOOGLE_SPEECH_KEY;
        private readonly string GOOGLE_TRANSLATE_KEY;

        public GoogleService(IConfiguration configuration)
        {
            GOOGLE_SPEECH_KEY = configuration["GoogleCloudSecretKey:Speech"];
            GOOGLE_TRANSLATE_KEY = configuration["GoogleCloudSecretKey:Translate"];
        }
        public string GetSpeechWord()
        {
            throw new NotImplementedException();
        }

        public async Task<string> GetTranaslateWord(string word)
        {
            string url = "https://www.googleapis.com/language/translate/v2"
                .SetQueryParam("key", GOOGLE_TRANSLATE_KEY)
                .SetQueryParam("q", word)
                .SetQueryParam("&source=en&target=pl");

            HttpClient client = new HttpClient();
            var response = await client.GetAsync(url);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsStringAsync();
        }
    }
}
