using HentzyAcadmyAPI.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.X509Certificates;

namespace HentzyAcadmyAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AlunoController : ControllerBase
    {

        [HttpPost(Name = "IdadeAluno")]
        public ActionResult CreateIdade(Aluno aluno)
        {

            if (aluno.Idade >= 18)
            {
                String resultado = "aluno cadastrado com suceso";
                return Ok(resultado);
            }
            else
            {
                string resultado = "aluno precisa de um reponsável";
                return Ok(resultado);
            }
        }

        [HttpGet(Name = "GetAluno")]

        public ActionResult CreateAluno()
        {
            var ListaAlunos = new List<Aluno>();    

            var alunoCadastro1 = new Aluno();
            alunoCadastro1.Nome = "Carlos";
            alunoCadastro1.Matricula = 345;
            alunoCadastro1.Telefone = 987623451;
            

            var alunoCadastro2 = new Aluno();
            alunoCadastro2.Nome = "Rita";
            alunoCadastro2.Matricula = 4321;
            alunoCadastro2.Telefone = 987655643;
            ListaAlunos.Add(alunoCadastro1);    
            ListaAlunos.Add (alunoCadastro2);

            return Ok(ListaAlunos);

        }
       
    } }







            
            
            
            








      
    

