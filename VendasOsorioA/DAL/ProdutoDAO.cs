using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendasOsorioA.Model;

namespace VendasOsorioA.DAL
{
    class ProdutoDAO
    {

        private static List<Produto> produtos = new List<Produto>();   //criação da lista 

        public static bool CadastrarProduto(Produto p)        //Grava os dados
        {
            if (BuscarProdutoPorNome(p) != null)
            {
                return false;
            }

            /*foreach (Vendedor vendedorCadastrado in vendedores)
            {

                if (vendedorCadastrado.CpfVendedor.Equals(v.CpfVendedor))
                {
                    return false;
                }

            }*/
            produtos.Add(p);
            return true;
        }

        public static Produto BuscarProdutoPorNome(Produto p)
        {
            foreach (Produto produtoCadastrado in produtos)
            {
                if (!produtoCadastrado.NomeProduto.Equals(p.NomeProduto))
                {
                    //Console.WriteLine("Vendedor não encontrado!");
                    return produtoCadastrado;

                }

            }
            return null;

        }



        public static List<Produto> RetornarProduto() //Retornar os dados
        {

            return produtos;

        }

    }
}
