using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendasOsorioA.Model
{
    class VendaDAO
    {
        private static List<Venda> vendas = new List<Venda>(); //Criação da lista 

        public static void CadastrarVenda(Venda venda)
        {
            vendas.Add(venda);
        }
        public static List<Venda> RetornarVendas()
        {
            return vendas;
        }
    }
}
