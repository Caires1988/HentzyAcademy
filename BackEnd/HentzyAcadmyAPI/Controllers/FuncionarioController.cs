using HentzyAcadmyAPI.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics.Eventing.Reader;
using System.Security.Cryptography.X509Certificates;

namespace HentzyAcadmyAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FuncionarioController : ControllerBase
    {

        [HttpPost("CreateFuncionarioA")]
        public ActionResult CreateFuncionario(Funcionario objetoFuncionario)
        {
            if (objetoFuncionario.Idade > 18)
            {
                return Ok("Sucesso");
            }

            else
            {
                return Ok("Funcionário não pode ser contratado");
            }

        }

        [HttpGet("GetFuncionarioByName")]

        public ActionResult GetByName(String nome)

        {
            var funcionarioCadastro1 = new Aluno();
            funcionarioCadastro1.Nome = "Carlos";
            funcionarioCadastro1.Matricula = 345;
            funcionarioCadastro1.Telefone = 987623451;



            var funcionarioCadastro2 = new Aluno();
            funcionarioCadastro2.Nome = "Rodrigo";
            funcionarioCadastro2.Matricula = 4321;
            funcionarioCadastro2.Telefone = 987655643;

            var funcionarioCadastro3 = new Aluno();
            funcionarioCadastro3.Nome = "Cecília";
            funcionarioCadastro3.Matricula = 4321;
            funcionarioCadastro3.Telefone = 987655643;

            var funcionarioCadastro4 = new Aluno();
            funcionarioCadastro4.Nome = "Antônia";
            funcionarioCadastro4.Matricula = 4321;
            funcionarioCadastro4.Telefone = 987655643;

            var funcionarioCadastro5 = new Aluno();
            funcionarioCadastro5.Nome = "Luana";
            funcionarioCadastro5.Matricula = 4321;
            funcionarioCadastro5.Telefone = 987655643;

            if (funcionarioCadastro1.Nome == nome)
            {
                return Ok("Sucesso");
            }

            else
            {
                return Ok("funcionario não encontrado");
            }

            if (funcionarioCadastro2.Nome == nome)
            {
                return Ok("Sucesso");
            }

            else
            {
                return Ok("funcionario não encontrado");
            }

            if (funcionarioCadastro3.Nome == nome)
            {
                return Ok("Sucesso");
            }

            else
            {
                return Ok("funcionario não encontrado");
            }

            if (funcionarioCadastro4.Nome == nome)
            {
                return Ok("Sucesso");
            }

            else
            {
                return Ok("funcionario não encontrado");
            }

            if (funcionarioCadastro5.Nome == nome)
            {
                return Ok("Sucesso");
            }

            else
            {
                return Ok("funcionario não encontrado");
            }


            {

            }


        }


        [HttpGet("GetAll")]
        public ActionResult GetAll()
        {
            var lista = new List<Funcionario>();

            var funcionarioCadastro1 = new Funcionario();
            funcionarioCadastro1.Nome = "Carlos";
            funcionarioCadastro1.Matricula = 345;
            funcionarioCadastro1.Telefone = 987623451;



            var funcionarioCadastro2 = new Funcionario();
            funcionarioCadastro2.Nome = "Rodrigo";
            funcionarioCadastro2.Matricula = 4321;
            funcionarioCadastro2.Telefone = 987655643;

            var funcionarioCadastro3 = new Funcionario();
            funcionarioCadastro3.Nome = "Cecília";
             funcionarioCadastro3.Matricula = 4321;
            funcionarioCadastro3.Telefone = 987655643;

            var funcionarioCadastro4 = new  Funcionario();
            funcionarioCadastro4.Nome = "Antônia";
            funcionarioCadastro4.Matricula = 4321;
            funcionarioCadastro4.Telefone = 987655643;

            var funcionarioCadastro5 = new Funcionario();
            funcionarioCadastro5.Nome = "Luana";
            funcionarioCadastro5.Matricula = 4321;
            funcionarioCadastro5.Telefone = 987655643;

            lista.Add(funcionarioCadastro1);
            lista.Add(funcionarioCadastro2);
            lista.Add(funcionarioCadastro3);
            lista.Add(funcionarioCadastro5);



            return Ok(lista);

        }


    }

}























