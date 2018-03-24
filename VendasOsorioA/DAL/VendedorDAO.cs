using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendasOsorioA.Model;

namespace VendasOsorioA.DAL
{
    class VendedorDAO
    {

        private static List<Vendedor> vendedores = new List<Vendedor>(); //Criação da lista 


        public static bool CadastrarVendedor(Vendedor v)        //Grava os dados
        {
            if (BuscarVendedorPorCpf(v) != null)
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
            vendedores.Add(v);
            return true;
        }

        public static Vendedor BuscarVendedorPorCpf(Vendedor v)
        {
            foreach(Vendedor vendedorCadastrado in vendedores)
            {
                if (!vendedorCadastrado.CpfVendedor.Equals(v.CpfVendedor))
                {
                    //Console.WriteLine("Vendedor não encontrado!");
                    return vendedorCadastrado;
                    
                }
                
            }
            return null;
            
        }



        public static List<Vendedor> RetornarVendedor() //Retornar os dados
        {

            return vendedores;

        }


    
    }
}
