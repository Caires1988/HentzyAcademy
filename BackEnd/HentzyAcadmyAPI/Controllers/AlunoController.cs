using HentzyAcadmyAPI.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics.Eventing.Reader;
using System.Security.Cryptography.X509Certificates;

namespace HentzyAcadmyAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AlunoController : ControllerBase
    {

        [HttpPost("CreateAluno")]
        public ActionResult CreateAluno(Aluno objetoAluno)
        {
            if (objetoAluno.Idade > 16)
            {
                return Ok("Sucesso");
            }

            else
            {
                return Ok("Aluno necessita de aprovacão dos pais");
            }

        }

        [HttpGet("GetAlunoByName")]

        public ActionResult GetByName(String nome)

        {
            var alunoCadastro1 = new Aluno();
            alunoCadastro1.Nome = "Carlos";
            alunoCadastro1.Matricula = 345;
            alunoCadastro1.Telefone = 987623451;



            var alunoCadastro2 = new Aluno();
            alunoCadastro2.Nome = "Rodrigo";
            alunoCadastro2.Matricula = 4321;
            alunoCadastro2.Telefone = 987655643;

            var alunoCadastro3 = new Aluno();
            alunoCadastro3.Nome = "Cecília";
            alunoCadastro3.Matricula = 4321;
            alunoCadastro3.Telefone = 987655643;

            var alunoCadastro4 = new Aluno();
            alunoCadastro4.Nome = "Antônia";
            alunoCadastro4.Matricula = 4321;
            alunoCadastro4.Telefone = 987655643;

            var alunoCadastro5 = new Aluno();
            alunoCadastro5.Nome = "Luana";
            alunoCadastro5.Matricula = 4321;
            alunoCadastro5.Telefone = 987655643;

            if (alunoCadastro1.Nome == nome)
            {
                return Ok("Sucesso");
            }

            else
            {
                return Ok("aluno não encontrado");
            }

            if (alunoCadastro2.Nome == nome)
            {
                return Ok("Sucesso");
            }

            else
            {
                return Ok("aluno não encontrado");
            }

            if (alunoCadastro3.Nome == nome)
            {
                return Ok("Sucesso");
            }

            else
            {
                return Ok("aluno não encontrado");
            }

            if (alunoCadastro4.Nome == nome)
            {
                return Ok("Sucesso");
            }

            else
            {
                return Ok("aluno não encontrado");
            }

            if (alunoCadastro5.Nome == nome)
            {
                return Ok("Sucesso");
            }

            else
            {
                return Ok("aluno não encontrado");
            }


            {

            }


        }


        [HttpGet("GetAll")]
        public ActionResult GetAll()
        {
            var listaAlunos = new List<Aluno>();

        var alunoCadastro1 = new Aluno();
        alunoCadastro1.Nome = "Carlos";
                alunoCadastro1.Matricula = 345;
                alunoCadastro1.Telefone = 987623451;



                var alunoCadastro2 = new Aluno();
        alunoCadastro2.Nome = "Rodrigo";
                alunoCadastro2.Matricula = 4321;
                alunoCadastro2.Telefone = 987655643;

                var alunoCadastro3 = new Aluno();
        alunoCadastro3.Nome = "Cecília";
                alunoCadastro3.Matricula = 4321;
                alunoCadastro3.Telefone = 987655643;

                var alunoCadastro4 = new Aluno();
        alunoCadastro4.Nome = "Antônia";
                alunoCadastro4.Matricula = 4321;
                alunoCadastro4.Telefone = 987655643;

                var alunoCadastro5 = new Aluno();
        alunoCadastro5.Nome = "Luana";
                alunoCadastro5.Matricula = 4321;
                alunoCadastro5.Telefone = 987655643;

                 listaAlunos.Add(alunoCadastro1);
            listaAlunos.Add(alunoCadastro2);
                 listaAlunos.Add(alunoCadastro3);
            listaAlunos.Add(alunoCadastro4);
            listaAlunos.Add(alunoCadastro5);



                return Ok(listaAlunos);

        }

               
    }
           
}







            
            
            
            








      
    

