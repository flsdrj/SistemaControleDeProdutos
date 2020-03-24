using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Projeto.Presentation.Models; //classe de modelo
using Projeto.Data.Entities; //classe de entidades
using Projeto.Data.Contracts; //interfaces
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Projeto.Presentation.Controllers
{
    public class ProdutoController : Controller
    {
        private readonly IProdutoRepository produtoRepository;
        private readonly IEstoqueRepository estoqueRepository;

        public ProdutoController(IProdutoRepository produtoRepository, IEstoqueRepository estoqueRepository)
        {
            this.produtoRepository = produtoRepository;
            this.estoqueRepository = estoqueRepository;
        }

        public IActionResult Cadastro()
        { 
            return View(GerarCadastroProdutoModel());
        }

        [HttpPost]//metodo executado pelo submite do formulário
        public IActionResult Cadastro(CadastroProdutoModel model)
        {
            //verificar se todos os campos passaram na validação
            if (ModelState.IsValid)
            {
                try
                {
                    var produto = new Produto();
                    produto.Nome = model.Nome;
                    produto.Preco = Convert.ToInt32(model.Preco);
                    produto.Quantidade = Convert.ToInt32(model.Quantidade);
                    produto.IdEstoque = Convert.ToInt32(model.IdEstoque);

                    produtoRepository.Inserir(produto);

                    TempData["Mensagem"] = "Produto cadastrado com sucesso.";
                    ModelState.Clear();
                }
                catch (Exception e)
                {
                    TempData["Mensagem"] = e.Message;
                }
            }
            
            return View(GerarCadastroProdutoModel());
        }        

        public IActionResult Consulta()
        {
            return View();
        }

        //metodo para retornar o conteúdo do campo de seleção do estoque..
        private List<SelectListItem> ObterlistagemDeEstoque()
        {
            var lista = new List<SelectListItem>();

            //consultando e percorrer os estoques do banco de dados
            foreach(var item in estoqueRepository.ConsultarTodos())
            {
                //adicionar um item de seleção no campo dropdownlist
                var opcao = new SelectListItem();
                opcao.Value = item.IdEstoque.ToString();
                opcao.Text = item.Nome;

                lista.Add(opcao);
            }

            return lista;
        }

        private CadastroProdutoModel GerarCadastroProdutoModel()
        {
            var model = new CadastroProdutoModel();
            model.ListagemDeEstoque = ObterlistagemDeEstoque();
            return model;
        }
    }
}