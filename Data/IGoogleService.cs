using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoogleCloudServiceAPI.Data
{
    interface IGoogleService
    {
        string GetTranaslateWord();
        string GetSpeechWord();
    }
}
