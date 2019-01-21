using System.Threading.Tasks;
using Medicorum.Core.Interactors.Patients.Queries.PatientHistory;
using Microsoft.AspNetCore.Mvc;

namespace Medicorum.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClinicalHistoryController : BaseController
    {
        //// GET: api/ClinicalHistory
        //[HttpGet]
        //public async Task<ActionResult<PatientHistorySearchViewModel>> Get()
        //{
        //    return Ok(await Mediator.Send(new GetPatientHistoryQuery()));
        //}
   
        // GET: api/ClinicalHistory/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PatientHistoryViewModel>> Get(int id)
        {
            return Ok(await Mediator.Send(new GetPatientHistoryQuery { Id = id }));
        }

        // POST: api/ClinicalHistory
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/ClinicalHistory/5
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
