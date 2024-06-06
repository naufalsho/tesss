using Backend.BusinessLogic.Data;
using Backend.BusinessLogic.Interfaces;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AssetController : ControllerBase
    {
        private readonly IAssetLogic objLogic;

        // Constructor injection
        public AssetController(IAssetLogic objLogic)
        {
            this.objLogic = objLogic;
        }
        // GET: api/<AssetController>
        [HttpGet]
        public IActionResult GetAll()
        {
            try
            {
                var result = objLogic.GetAll();
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // GET api/<AssetController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<AssetController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<AssetController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<AssetController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
