using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendasOsorioA.Model
{
    class ItemVenda
    {
        public Produto Produto { get; set; }
        public DateTime Date { get; set; }
        public int Quantidade { get; set; }
        public double Valor { get; set; }

    }
}
