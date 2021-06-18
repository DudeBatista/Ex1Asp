using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ExCadastro.Models
{
    public class Produto
    {
        [Required(ErrorMessage = "Este campo é obrigatório!")]
        public string Codigo { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório!")]
        public string Nome { get; set; }

        [Required]
        public string Descricao { get; set; }

        [RegularExpression(@"^[0-9]+(\.[0-9]{1,2})$", ErrorMessage = "Valor inválido!")]
        public string Peso { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório!")]
        public string Categoria { get; set; }

        [RegularExpression(@"^[0-9]+(\.[0-9]{1,2})$", ErrorMessage = "Valor inválido!")]
        public string valorUnico { get; set; }
    }
}