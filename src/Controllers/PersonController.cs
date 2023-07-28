using Microsoft.AspNetCore.Mvc;
using src.Models;

namespace src.Controllers;

[ApiController]
[Route("[controller]")]
public class PersonController : ControllerBase
{
    [HttpGet]
    public Pessoa Get()
    {
        Pessoa pessoa = new Pessoa("claudio", 30, "12345678");
        Contrato novoContrato = new Contrato();
        pessoa.contratos.Add(novoContrato);

        return pessoa;
    }
}