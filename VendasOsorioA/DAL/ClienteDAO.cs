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

        public static bool CadastrarCliente(Cliente c) //Grava os dados
        {

            foreach (Cliente clienteCadastrado in clientes)
            {

                if (clienteCadastrado.CpfCliente.Equals(c.CpfCliente))
                {
                    return false;
                }

            }
            clientes.Add(c);
            return true;

        }

        public static List<Cliente> RetornarClientes() //Retornar os dados
        {

            return clientes;

        }
    }
}
