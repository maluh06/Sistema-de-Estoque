using EstoqueTeste.Models.Entidades;
using Microsoft.AspNetCore.Mvc;

namespace EstoqueTeste.Service
{
    public class ServeceEstoque : IServeceEstoque
    {
        public Task<IActionResult> GetConsultarProduto(int id)
        {
            // Buscaremos um produto pelo seu ID e retornaremos as informações do produto.
            // Informações: nome, quantidade em estoque, preço de venda, fornecedor, categoria e estoque mínimo, preço de custo.
            // se o ID não for encontrado, retornaremos NotFound.
        }

        public Task<IActionResult> GetMovimentação(DateTime periodoInicial)
        {
            // Buscaremos todas as movimentações de entrada e saída de produtos no período informado até o periodo atual
            // ver sobre estabelecer uma formatação de data 
            // gerar um arquivo
        }

        public Task<IActionResult> GetRelatorioDisposição()
        {
            // Ter no arquivo gerado itens: 
            //                             acima do estoque mínimo, abaixo do estoque mínimo e produtos com estoque zerado.
            // mostrará nome quantidade, status (acima do estoque mínimo, abaixo do estoque mínimo e produtos com estoque zerado)
        }

        public Task<IActionResult> PostCadastrarFornecedor(Fornecedor fornecedor)
        {
            // Cadastrar um novo fornecedor no sistema.
        }

        public Task<IActionResult> PostCadastrarProduto(AdicionarProduto produto)
        {
            // Cadastrar um novo produto no sistema.
        }

        public Task<IActionResult> PutEditarProduto(int id)
        {
            // Editar as informações (preco custo, preco venda, fornecedor) de um produto existente no sistema.
            // não mudar entrada e saida, pois terá métodos para isso. 
        }

        public Task<IActionResult> PutRegistrarEntrada(int id, int quantidade)
        {
            // Registrar a entrada de um produto no estoque, aumentando a quantidade em estoque do produto.
        }

        public Task<IActionResult> PutRegistrarSaida(int id, int quantidade)
        {
            // Registrar a saída de um produto no estoque, diminuindo a quantidade em estoque do produto.
        }
    }
}
