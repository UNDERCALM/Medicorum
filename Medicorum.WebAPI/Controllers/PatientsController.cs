using System.Threading.Tasks;
using Medicorum.Core.Interactors.Patients.Queries.PatientDetails;
using Medicorum.Core.Interactors.Patients.Queries.PatientList;
using Microsoft.AspNetCore.Mvc;

namespace Medicorum.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientsController : BaseController
    {
        // GET: api/Patients
        [HttpGet]
        public async Task<ActionResult<PatientListViewModel>> Get()
        {
            return Ok(await Mediator.Send(new GetPatientListQuery()));
        }

        // GET: api/Patients/5
        [HttpGet("{id}", Name = "Get")]
        public async Task<ActionResult<PatientViewModel>> Get(int id)
        {
            return Ok(await Mediator.Send(new GetPatientQuery { Id = id }));
        }

        // POST: api/Patients
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Patients/5
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
