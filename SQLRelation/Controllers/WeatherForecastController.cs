using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SQLRelation.Context;
using SQLRelation.Models;
using Microsoft.EntityFrameworkCore;

namespace SQLRelation.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly SchoolContext _SchoolContext = new SchoolContext();

        [HttpGet]
        public IEnumerable<Student> Get()
        {
            return _SchoolContext.Students.Include(x => x.Grade).AsNoTracking().ToList();
        }
    }
}
