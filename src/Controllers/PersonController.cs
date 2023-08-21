using Microsoft.AspNetCore.Mvc;
using System;
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
        Contrato novoContrato = new Contrato("abc123", 50.46);

        pessoa.contratos.Add(novoContrato);

        return pessoa;
    }

    [HttpPost]
    public Pessoa Post(Pessoa pessoa)
    {
        return pessoa;
    }
    [HttpPut("{id}")]
    public string Update([FromRoute]int id, [FromBody]Pessoa pessoa)
    {
        Console.WriteLine(id); 
        Console.WriteLine(pessoa);                           
        return "Dados do id " + id + " atualizados";    
    }
    
    [HttpDelete("{id}")]
    public string Delete(int id){
        return "deletado pessoa de Id " + id;
    }
    
}