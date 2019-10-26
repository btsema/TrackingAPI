using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Tracking.Data.Models;
using Tracking.Services.Services;
using TrackingMyFoodAPI.Models.Requests;

namespace TrackingMyFood.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;
        private readonly ICompanyService _company;
        private readonly IMapper _mapper;

        public CompanyController(ILogger<WeatherForecastController> logger, ICompanyService company, IMapper mapper)
        {
            _logger = logger;
            _company = company;
            _mapper = mapper;
        }

        [HttpPost]
        public ActionResult<Company> Add([FromBody] AddNewCompanyRequest newCompany)
        {
            try
            {
                Company company = _mapper.Map<Company>(newCompany);

                return _company.Add(company);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }

        [HttpGet]
        [Route("GetAll")]
        public ActionResult<List<Company>> GetAll()
        {
            try
            {
                return _company.GetAllCompanies();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }
    }
}
