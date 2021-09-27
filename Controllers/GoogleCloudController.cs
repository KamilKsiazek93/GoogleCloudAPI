using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using GoogleCloudServiceAPI.Data;

namespace GoogleCloudServiceAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GoogleCloudController : ControllerBase
    {
        private readonly IGoogleService _googleService;
        public GoogleCloudController(IGoogleService googleService)
        {
            _googleService = googleService;
        }
        [HttpGet("translate")]
        public async Task<string> GetTranslateWord(string word)
        {
            return await _googleService.GetTranaslateWord(word);
        }

        [HttpGet("speech")]
        public async Task<string> GetSpeechWord(string word)
        {
            return await _googleService.GetSpeechWord(word);
        }
    }
}
