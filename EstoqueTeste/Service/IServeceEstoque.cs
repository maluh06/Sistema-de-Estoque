using EstoqueTeste.Models.Entidades;
using Microsoft.AspNetCore.Mvc;

namespace EstoqueTeste.Service
{
    public interface IServeceEstoque
    {
        public Task<IActionResult> PostCadastrarProduto(AdicionarProduto produto);
        public Task<IActionResult> PutEditarProduto(int id);
        public Task<IActionResult> GetConsultarProduto(int id);
        public Task<IActionResult> PostCadastrarFornecedor(Fornecedor fornecedor);
        public Task<IActionResult> PutRegistrarSaida(int id, int quantidade);
        public Task<IActionResult> PutRegistrarEntrada(int id, int quantidade);
        public Task<IActionResult> GetRelatorioDisposição();
        public Task<IActionResult> GetMovimentação(DateTime periodoInicial);
    }
}
