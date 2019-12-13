using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using EcomMicroservice2.Models;

namespace EcomMicroservice2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [AddHeader("Access-Control-Allow-Origin", "*")]
    public class BrandController : ControllerBase
    {
        public IConfiguration Configuration { get; }
        public BrandController(IConfiguration _configuration)
        {
            Configuration = _configuration;
        }

        // GET api/values/5
        [HttpGet]
        public JsonResult Get()
        {
              DatabaseCURD dbCurd = new DatabaseCURD();
              List<ProductBrandClass> lst = dbCurd.GetAllBrand(Configuration["ConnectionStrings:Default"]);
              return new JsonResult(lst);  //dbCurd.GetAllProduct(Configuration["ConnectionStrings:Default"]);
              //return "value";
            
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
