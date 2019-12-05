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
    public class TriangleTypeController : Controller
    {
        // GET api/values/5
        [HttpGet]
        public string Get(int a, int b, int c)
        {
            TriangleTypeService tService = new TriangleTypeService(a, b, c);
            return tService.GetTriangleType();
        }
    }
}
