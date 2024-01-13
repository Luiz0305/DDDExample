using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entidades
{
    public class Cliente
    {
        public int ClienteId { get; set; }
        public string NomeCliente { get; set; }
        public DateTime DataNacimento { get; set; }
        public int Habilitacao { get; set; }
        public string Estado { get; set; }
    }
}
