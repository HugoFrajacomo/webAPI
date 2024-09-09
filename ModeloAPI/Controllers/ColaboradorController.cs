using Microsoft.AspNetCore.Mvc;
using ModeloAPI.Model;
using ModeloAPI.ViewModel;

namespace ModeloAPI.Controllers
{
    [ApiController]
    [Route("api/v1/colaborador")]
    public class ColaboradorController : ControllerBase
    {
        private readonly IColaboradorRepository _colaboradorRepository;

        public ColaboradorController(IColaboradorRepository colaboradorRepository)
        {
            _colaboradorRepository = colaboradorRepository ?? throw new ArgumentNullException(nameof(colaboradorRepository));
        }

        [HttpPost]
        public IActionResult add(ColaboradorViewModel colaboradorView)
        {
            var colaborador = new Colaborador(colaboradorView.Nome, colaboradorView.Idade, null);

            _colaboradorRepository.add(colaborador);

            return Ok();
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var colaboradores = _colaboradorRepository.GetAll();

            return Ok(colaboradores);
        }
    }
}
