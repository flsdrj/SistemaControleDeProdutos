using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Projeto.Data.Contracts;
using Projeto.Data.Entities;
using Projeto.Presentation.Models;


namespace Projeto.Presentation.Controllers
{
    public class EstoqueController : Controller
    {
        private readonly IEstoqueRepository estoqueRepository;

        public EstoqueController(IEstoqueRepository estoqueRepository)
        {
            this.estoqueRepository = estoqueRepository;
        }

        public IActionResult Cadastro()
        {
            return View();
        }

        [HttpPost] //método é executado pelo submit do Formulario
        public IActionResult Cadastro(CadastroEstoqueModel model)
        {
            //verificar se todos os campos da model
            //passaram nas regras de validação
            if (ModelState.IsValid)
            {
                try
                {
                    //cadastrar Estoque
                    var estoque = new Estoque();
                    estoque.Nome = model.Nome;
                    estoque.Descricao = model.Descricao;

                    estoqueRepository.Inserir(estoque);

                    TempData["Mensagem"] = "Estoque cadastrado com sucesso.";

                    ModelState.Clear(); //limpar os campos do formulário

                }

                catch (Exception e)
                {
                    TempData["Mensagem"] = "Ocorreu um erro." + e.Message;
                }
            }
            
            return View();
        }

        public IActionResult Consulta()
        {
            //declarando uma variavel do tipo lista de estoques...
            var lista = new List<Estoque>();
            try
            {
                lista = estoqueRepository.ConsultarTodos();
            }
            catch (Exception e)
            {
                TempData["Mensagem"] = "Ocorreu um erro." + e.Message;
            }

            //enviando a lista para a pagina
            return View(lista);
        }

        public IActionResult Exclusao(int id)
        {
            try
            {
                //buscar no banco de dados pelo id..
                var estoque = estoqueRepository.ConsultarPorId(id);

                //excluindo o estoque
                estoqueRepository.Excluir(estoque);

                TempData["Mensagem"] = "Estoque excluído com sucesso!";

            }
            catch (Exception e)
            {

                TempData["Mensagem"] = e.Message;
            }

            return RedirectToAction("Consulta");
        }

        public IActionResult Edicao(int id)
        {
            var model = new EdicaoEstoqueModel();

            try
            {
                //buscando o estoque no banco de dados pelo id..
                var estoque = estoqueRepository.ConsultarPorId(id);

                model.IdEstoque = estoque.IdEstoque;
                model.Nome = estoque.Nome;
                model.Descricao = estoque.Descricao;            

            }
            catch (Exception e)
            {
                TempData["Mensagem"] = e.Message;
            }
            
            return View(model);
        }

        [HttpPost] //recebe o submit do formulario
        public IActionResult Edicao(EdicaoEstoqueModel model)
        {
            if(ModelState.IsValid)
            {
                try
                {
                    var estoque = new Estoque();

                    estoque.IdEstoque = model.IdEstoque;
                    estoque.Nome = model.Nome;
                    estoque.Descricao = model.Descricao;

                    estoqueRepository.Alterar(estoque);

                    TempData["Mensagem"] = "Estoque alterado com sucesso!";

                }
                catch (Exception e)
                {

                    TempData["Mensagem"] = e.Message;
                }
            }
            
            return View();
        }
    }
}