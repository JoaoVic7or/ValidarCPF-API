using CPFValidoAPI.Interface;
using Microsoft.AspNetCore.Mvc;

namespace CPFValidoAPI.Controllers
{
    [ApiController]
    [Route("/api/cpf")]
    public class CpfController : Controller
    {
        private readonly ICpfService _cpfService;

        public CpfController(ICpfService cpfService)
        {
            _cpfService = cpfService;
        }

        [HttpGet("validar")]
        public IActionResult ValidarCPFAsync(string cpf)
        {
            try
            {
                bool resultado = _cpfService.ValidarCPF(cpf);

                return Ok(new { valido = resultado });

            }
            catch (ArgumentNullException ex)
            {
                return BadRequest(new { erro = ex.Message });
            }
        }
    }
}
