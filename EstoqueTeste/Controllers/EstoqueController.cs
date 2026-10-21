using EstoqueTeste.Models.ApplicationDBContext;
using Microsoft.AspNetCore.Mvc;

namespace EstoqueTeste.Controllers
{
    public class EstoqueController : Controller
    {
        private readonly Context context;

        public EstoqueController(Context context)
        {
            this.context = context;
        }

        [HttpGet("consultar-produto/{id}")]
        public Task<IActionResult> GetConsultarProduto(int id)
        {

        }
    }
}
