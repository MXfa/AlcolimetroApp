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
        public IActionResult ValorAlcholimetro (string bebida, double cantidad, double peso)                         
        {
            var eth = new CalAlcoholemia();
            var rst = eth.calcular(bebida, cantidad, peso);
            if (rst >= 0.8)
            {
            return Ok($"El alcoholimetro marca {rst} g/L Por lo tanto el conductor requiere asistencia");
            }
            else
            {
                return Ok($"El alcoholimetro marca {rst} g/L Por lo tanto el conductor puede continuar manejando");
            }
        }
    }
}