using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoIN.Models
{
    public class CadastroModel
    {
        public int ID { get; set; }
        public int Valor { get; set; }
        public DateTime Data { get; set; }
        public string Descrição { get; set; }
        public string Categoria { get; set; }
        public string FormaDePagamento { get; set; }
        public int NumeroDeParcelas { get; set; }
        public string Paga { get; set; }
    }
}
