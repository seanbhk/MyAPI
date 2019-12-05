using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyAPI.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MyAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FibonacciController : Controller
    {
        // GET api/Fibonacci?n=5
        [HttpGet]
        public int Get(int n)
        {
            FibonacciServices fibService = new FibonacciServices(n);
            int result = fibService.CalFibonacci();
            return result;
        }
    }
}
