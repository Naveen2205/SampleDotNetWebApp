using Microsoft.AspNetCore.Mvc;
using RestApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RestApi.Services;



namespace RestApi.Controllers
{
    public class HomeController : Controller
    {
        private readonly IHomeServicer _homeServicer;

        public HomeController(
               IHomeServicer homeServicer
            )
        {
            _homeServicer = homeServicer;
        }
        [HttpGet]
        public string Index()
        {
           
            return _homeServicer.DisplayText();
        }

        [HttpGet]
        public string GetById()
        {
            return "Get By Id";
        } 

        [HttpPost]
        public Person Create(Person person)
        {
            return person;
        }

        [HttpPut]
        public string UpdateById()
        {
            return "Update by Id";
        }

        [HttpDelete]
        public string DeleteById()
        {
            return "Delete By Id";
        }
    }
}
