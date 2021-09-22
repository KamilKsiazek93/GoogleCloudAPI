using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoogleCloudServiceAPI.Data
{
    public interface IGoogleService
    {
        Task<string> GetTranaslateWord(string word);
        Task<string> GetSpeechWord(string word);
    }
}
