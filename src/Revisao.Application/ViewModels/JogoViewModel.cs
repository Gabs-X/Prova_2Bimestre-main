using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisao.Application.ViewModels
{
    public class JogoViewModel
    {
        [Required(ErrorMessage = "Informar o primeiro número")]
        [Range(1, 60, ErrorMessage = "Informe um número de 1 a 60")]
        public int primeiroNumero { get; set; }

        [Required(ErrorMessage = "Informar o primeiro número")]
        [Range(1, 60, ErrorMessage = "Informe um número de 1 a 60")]
        public int segundoNumero { get; set; }

        [Required(ErrorMessage = "Informar o primeiro número")]
        [Range(1, 60, ErrorMessage = "Informe um número de 1 a 60")]
        public int terceiroNumero { get; set; }

        [Required(ErrorMessage = "Informar o primeiro número")]
        [Range(1, 60, ErrorMessage = "Informe um número de 1 a 60")]
        public int quartoNumero { get; set; }

        [Required(ErrorMessage = "Informar o primeiro número")]
        [Range(1, 60, ErrorMessage = "Informe um número de 1 a 60")]
        public int quintoNumero { get; set; }

        [Required(ErrorMessage = "Informar o primeiro número")]
        [Range(1, 60, ErrorMessage = "Informe um número de 1 a 60")]
        public int sextoNumero { get; set; }
    }
}
