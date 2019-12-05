using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyAPI.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MyAPI.Controllers
{
    [Route("api/[controller]")]
    public class ReverseWordsController : Controller
    {
        // GET api/ReverseWords?sentence=aaffd
        [HttpGet]
        public string Get(string sentence)
        {
            ReverseWordsService reverseService = new ReverseWordsService(sentence);
            return reverseService.reverse();
        }
    }
}
