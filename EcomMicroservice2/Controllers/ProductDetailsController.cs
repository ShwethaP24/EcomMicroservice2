using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using EcomMicroservice2.Models;

namespace EcomMicroservice2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductDetailsController : ControllerBase
    {
        public IConfiguration Configuration { get; }
        public ProductDetailsController(IConfiguration _configuration)
        {
            Configuration = _configuration;
        }


        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value2", "value3" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public JsonResult Get(int id)
        {
              DatabaseCURD dbCurd = new DatabaseCURD();
              List<ProductDetailsClass> lst = dbCurd.GetProductDetails(Configuration["ConnectionStrings:Default"]);
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
