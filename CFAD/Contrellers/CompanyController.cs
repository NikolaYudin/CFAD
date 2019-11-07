using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CFAD.Models;
using CFAD.Models.Companys;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CFAD.Contrellers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyController : ControllerBase
    {
        private ApplicationContext _context;

        // GET: api/Company
        [HttpGet]
        public List<Company> Get(ApplicationContext context)
        {
            _context = context;
            List<Company> lstCompany = _context.tblCompany.ToList<Company>();
            return lstCompany;
        }

        // GET: api/Company/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Company
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Company/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
