using DoodPelletibrary;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using REST_api_WoodPellet.Managers;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace REST_api_WoodPellet.Controllers
{
   
    [EnableCors("allowAll")]


     [Route("api/[controller]")]
    [ApiController]
    public class WoodpelletsController : ControllerBase
    {
        private readonly WoodPelletsManager _manager = new WoodPelletsManager();

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<Wodpeller> GetAll()
        {
            IEnumerable<Wodpeller> wodpellers = _manager.GetAll();
            if (wodpellers == null) return NotFound("No list found");
            return Ok(wodpellers);
        }
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<Wodpeller> GetByID(int id)
        {
            Wodpeller wodpeller = _manager.GetById(id);
            if (wodpeller == null) return NotFound("No such class id: " + id);
            return Ok(wodpeller);

        }
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<Wodpeller> Post([FromBody] Wodpeller value)
        {
            Wodpeller wodpeller = _manager.Add(value);
            if (wodpeller == null) return NotFound("cant find object");
            return Created("api/IPAs/" + wodpeller.Id, wodpeller);
        }
        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<Wodpeller> Put(int id, [FromBody] Wodpeller value)
        {
            Wodpeller wodpeller = _manager.Update(id, value);
            if (wodpeller == null) return NotFound("Cant find object");
            return Ok(wodpeller);
        }

    }
}
