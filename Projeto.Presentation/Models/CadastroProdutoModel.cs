using Microsoft.AspNetCore.Mvc.Rendering;
using Projeto.Data.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations; //validações
using System.Linq;
using System.Threading.Tasks;

namespace Projeto.Presentation.Models
{
    public class CadastroProdutoModel
    {
        [MinLength(3, ErrorMessage = "Informe no mínimo {1} caracteres.")]
        [MaxLength(100, ErrorMessage = "Informe no máximo {1} caracteres.")]
        [Required(ErrorMessage = "Favor, Informar Nome.")]
        public string Nome { get; set; }        
        
        [Range(1, 9999, ErrorMessage ="Informe o preço entre {1} e {2}")]
        [Required(ErrorMessage = "Favor, Informar Preco.")]
        public decimal? Preco { get; set; }

        [Range(1, 9999, ErrorMessage = "Informe a quantidade entre {1} e {2}")]
        [Required(ErrorMessage = "Favor, Informar Quantidade.")]
        public int? Quantidade { get; set; }

        [Required(ErrorMessage = "Favor, Selecionar Estoque.")]
        public int? IdEstoque { get; set; }

        public List<SelectListItem> ListagemDeEstoque { get; set; }
        
    }
}
