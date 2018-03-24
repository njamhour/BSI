using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendasOsorioA.Model;


namespace VendasOsorioA.DAL
{
    class ClienteDAO
    {
        private static List<Cliente> clientes = new List<Cliente>(); //Criação da lista 

        public static bool CadastrarCliente(Cliente c)        //Grava os dados
        {
            if (BuscarClientePorCpf(c) != null)
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
            clientes.Add(c);
            return true;
        }

        public static Cliente BuscarClientePorCpf(Cliente c)
        {
            foreach (Cliente clienteCadastrado in clientes)
            {
                if (!clienteCadastrado.CpfCliente.Equals(c.CpfCliente))
                {
                    //Console.WriteLine("Vendedor não encontrado!");
                    return clienteCadastrado;

                }

            }
            return null;

        }

        public static List<Cliente> RetornarClientes() //Retornar os dados
        {

            return clientes;

        }
    }
}
