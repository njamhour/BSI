using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendasOsorioA.Model
{
    class Venda
    {
        public Venda()
        {
            Data = DateTime.Now;
            Quantidade = 1;
            Produto = new Produto(); // public Produto Produto { get; set; }
            Vendedor = new Vendedor();
            Cliente = new Cliente();
            
        }
        public List<ItemVenda> Produto { get; set; }
        public Vendedor Vendedor { get; set; }
        public Cliente Cliente { get; set; }
        public DateTime Data { get; set; }
        public int Quantidade { get; set; }
    }
}

// Fazer a venda com multiplos produtos