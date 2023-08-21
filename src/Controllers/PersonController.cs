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
    public string Update(int id)
    {
        Console.WriteLine(id);                              
        return "Dados do id " + id + " atualizados";
    
    }

}