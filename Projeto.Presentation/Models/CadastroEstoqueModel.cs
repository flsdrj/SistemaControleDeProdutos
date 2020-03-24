using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;//validações

namespace Projeto.Presentation.Models
{
    public class CadastroEstoqueModel
    {
        [MinLength(6,ErrorMessage ="Informe no mínimo {1} caracteres.")]
        [MaxLength(150, ErrorMessage = "Informe no máximo {1} caracteres.")]
        [Required(ErrorMessage = "Favor, Informar Nome.")]
        public string Nome { get; set; }

        [MinLength(6, ErrorMessage = "Informe no mínimo {1} caracteres.")]
        [MaxLength(150, ErrorMessage = "Informe no máximo {1} caracteres.")]
        [Required(ErrorMessage = "Favor, Informar Descricao.")]
        public string Descricao { get; set; }
    }
}
