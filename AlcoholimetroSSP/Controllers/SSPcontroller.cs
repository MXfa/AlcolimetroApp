using System;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics.CodeAnalysis;
using AlcoholimetroSSP.Domain;

namespace AlcoholimetroSSP.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SSPcontroller : ControllerBase
    {
        [HttpGet]
        [Route("CalcularNivelAlcohol/{bebida}/{cantidad}/{peso}")]
        public IActionResult ValorAlcholimetro (string bebida, int cantidad, double peso)                         
        {
            var eth = new CalAlcoholemia();
            var rst = eth.calcular(bebida, cantidad, peso);
            return Ok($"El alcoholimetro marca{rst}");
        }
    }
}