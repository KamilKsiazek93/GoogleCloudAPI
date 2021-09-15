using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

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

        public string GetTranaslateWord()
        {
            throw new NotImplementedException();
        }
    }
}
