using HentzyAcadmyAPI.Entities;
using Microsoft.AspNetCore.Mvc;

namespace HentzyAcadmyAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AlunoController : ControllerBase
    {

        [HttpPost(Name= "CreateAluno")]
        public ActionResult CreateAluno (Aluno aluno)
        {
            return Ok(aluno);
        }
    }
}
