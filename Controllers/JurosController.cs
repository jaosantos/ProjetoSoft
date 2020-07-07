using Microsoft.AspNetCore.Mvc;

namespace ProjetoSoft
{
    [Route("api/[Controller]")]
    public class JurosController : Controller
    {
        public JurosController()
        {
        }

        [HttpGet,Route("taxajuros")]
        public TaxaJuros TaxaJuros()
        {
            var taxaJuros = new TaxaJuros{
                Juros = 0.01
            };
            
            return taxaJuros;
        }
    }
}