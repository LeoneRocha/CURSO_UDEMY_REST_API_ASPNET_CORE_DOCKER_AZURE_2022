using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestWithASPNETUdemy.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculatorController : ControllerBase
    {
        private readonly ILogger<CalculatorController> _logger;

        public CalculatorController(ILogger<CalculatorController> logger)
        {
            _logger = logger;
        }

        [HttpGet("sum/{numeroUm}/{numeroDois}")]//https://localhost:44397/Calculator/sum/2/2
        public IActionResult Get(string numeroUm, string numeroDois)
        {
            if (isNumeric(numeroUm) & isNumeric(numeroDois))
            {
                var sum = converterDecimal(numeroUm) + converterDecimal(numeroDois);
                return Ok(sum.ToString());

            }
            return BadRequest("Invalid Input");
        }

        [HttpGet("subtraction/{numeroUm}/{numeroDois}")]//https://localhost:44397/Calculator/subtraction/8/2
        public IActionResult Subtraction(string numeroUm, string numeroDois)
        {
            if (isNumeric(numeroUm) & isNumeric(numeroDois))
            {
                var sum = converterDecimal(numeroUm) - converterDecimal(numeroDois);
                return Ok(sum.ToString());

            }
            return BadRequest("Invalid Input");
        }

        [HttpGet("multiplicacao/{numeroUm}/{numeroDois}")]//https://localhost:44397/Calculator/subtraction/8/2
        public IActionResult Multiplicacao(string numeroUm, string numeroDois)
        {
            if (isNumeric(numeroUm) & isNumeric(numeroDois))
            {
                var sum = converterDecimal(numeroUm) * converterDecimal(numeroDois);
                return Ok(sum.ToString());

            }
            return BadRequest("Invalid Input");
        }

        [HttpGet("divisao/{numeroUm}/{numeroDois}")]//https://localhost:44397/Calculator/subtraction/8/2
        public IActionResult Divisao(string numeroUm, string numeroDois)
        {
            if (isNumeric(numeroUm) & isNumeric(numeroDois))
            {
                var sum = converterDecimal(numeroUm) / converterDecimal(numeroDois);
                return Ok(sum.ToString());

            }
            return BadRequest("Invalid Input");
        }


        [HttpGet("mean/{numeroUm}/{numeroDois}")]//https://localhost:44397/Calculator/mean/8/2
        public IActionResult Mean(string numeroUm, string numeroDois)
        {
            if (isNumeric(numeroUm) & isNumeric(numeroDois))
            {
                var sum = (converterDecimal(numeroUm) + converterDecimal(numeroDois)) / 2;
                return Ok(sum.ToString());

            }
            return BadRequest("Invalid Input");
        }

        [HttpGet("raizquadrada/{numeroUm}")]//https://localhost:44397/Calculator/raizquadrada/8
        public IActionResult RaizQuadrada(string numeroUm)
        {
            if (isNumeric(numeroUm))
            {
                double resultado = Math.Sqrt((double)converterDecimal(numeroUm));


                return Ok(resultado.ToString());

            }
            return BadRequest("Invalid Input");
        }


        private decimal converterDecimal(string strNumero)
        {
            decimal numero = 0;
            if (decimal.TryParse(strNumero, System.Globalization.NumberStyles.Any
                , System.Globalization.NumberFormatInfo.InvariantInfo, out numero))
            {
                return numero;
            }
            return numero;
        }

        private bool isNumeric(string strNumero)
        {
            double numero;
            bool converteu = double.TryParse(strNumero, System.Globalization.NumberStyles.Any
                , System.Globalization.NumberFormatInfo.InvariantInfo, out numero);

            return converteu;
        }
    }
}
