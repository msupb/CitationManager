using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Data.Models;
using Data.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace WebServiceAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        IObjectRepository<CitationModel> objectRepository;
        public WeatherForecastController(IObjectRepository<CitationModel> objectRepository)
        {
            this.objectRepository = objectRepository;
        }

        [HttpGet]
        public List<CitationModel> Get()
        {
            List<CitationModel> list = objectRepository.Collection().ToList();

            return list;
        }
    }
}
