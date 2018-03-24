using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendasOsorioA.DAL;
using VendasOsorioA.Model;

namespace VendasOsorioA.View
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente c;
            Vendedor v;
            Produto p;
            Venda venda;
            int opcao;
            


            do
            {
                Console.Clear();
                Console.WriteLine(" -- VENDAS -- ");
                Console.WriteLine("1 - Cadastrar Cliente");
                Console.WriteLine("2 - Listar Clientes");
                Console.WriteLine("3 - Cadastrar Vendedor");
                Console.WriteLine("4 - Listar Vendedor");
                Console.WriteLine("5 - Cadastrar Produto");
                Console.WriteLine("6 - Listar  Produto");
                Console.WriteLine("7 - Registrar Venda");
                Console.WriteLine("8 - Listar Venda");
                Console.WriteLine("9 - Listar Venda por Cliente");
                Console.WriteLine("0 - Sair");
                Console.WriteLine("\nEscolha uma opção:");
                opcao = Convert.ToInt32(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        c = new Cliente();
                        Console.Clear();
                        Console.WriteLine(" -- CADASTRAR CLIENTE -- \n");
                        Console.WriteLine("Digite o nome do cliente:");
                        c.NomeCliente = Console.ReadLine();
                        Console.WriteLine("Digite o CPF do cliente:");
                        c.CpfCliente = Console.ReadLine();



                        //Chamar o método
                        if (ClienteDAO.CadastrarCliente(c))
                        {
                            Console.WriteLine("Cliente cadastrado com sucesso!");
                        }
                        else
                        {
                            Console.WriteLine("Cliente ja existente!");
                        }

                        break;
                    case 2:

                        Console.Clear();
                        Console.WriteLine(" -- LISTAR CLIENTE -- \n");

                        // for (int i = 0; i < clientes.Count; i++)
                        // {
                        //   Console.WriteLine("Nome: " + clientes[i].Nome);
                        //   Console.WriteLine("CPF: " + clientes[i].Cpf);
                        //  }



                        foreach (Cliente clienteCadastrado in ClienteDAO.RetornarClientes())
                        {
                            Console.WriteLine("Nome: " + clienteCadastrado.NomeCliente);
                            Console.WriteLine("CPF: " + clienteCadastrado.CpfCliente);
                        }


                        break;
                    case 3:

                        v = new Vendedor();

                        Console.Clear();
                        Console.WriteLine(" -- CADASTRAR VENDEDOR -- \n");
                        Console.WriteLine("Digite o nome do vendedor:");
                        v.NomeVendedor = Console.ReadLine();
                        Console.WriteLine("Digite o CPF do vendedor:");
                        v.CpfVendedor = Console.ReadLine();

                        //chamar o método
                        if (VendedorDAO.CadastrarVendedor(v))
                        {
                            Console.WriteLine("Vendedor Cadastrado com sucesso!");
                        }
                        else
                        {
                            Console.WriteLine("Vendedor já existente!");
                        }


                        break;
                    case 4:

                        Console.Clear();
                        Console.WriteLine(" -- LISTAR VENDEDOR -- \n");

                        foreach (Vendedor vendedorCadastrado in VendedorDAO.RetornarVendedor())
                        {
                            Console.WriteLine("Nome: " + vendedorCadastrado.NomeVendedor);
                            Console.WriteLine("CPF: " + vendedorCadastrado.CpfVendedor);
                        }

                        break;

                    case 5:

                        p = new Produto();

                        Console.Clear();
                        Console.WriteLine(" -- CADASTRAR PRODUTO -- \n");
                        Console.WriteLine("Digite o nome do produto:");
                        p.NomeProduto = Console.ReadLine();
                        Console.WriteLine("Digite o preço do produto:");
                        p.PrecoProduto = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Digite a quantidade de produtos:");
                        p.QuantidadeProduto = Convert.ToInt32(Console.ReadLine());

                        if (ProdutoDAO.CadastrarProduto(p))
                        {
                            Console.WriteLine("Produto cadastrado com sucesso!");
                        }
                        else
                        {
                            Console.WriteLine("Produto ja existente!");
                        }

                        break;

                    case 6:

                        Console.Clear();
                        Console.WriteLine(" -- LISTAR PRODUTOS -- \n");

                        foreach (Produto produtoCadastrado in ProdutoDAO.RetornarProduto())
                        {
                            Console.WriteLine("Nome: " + produtoCadastrado.NomeProduto);
                            Console.WriteLine("Preço: " + produtoCadastrado.PrecoProduto);
                            Console.WriteLine("Quantidade: " + produtoCadastrado.QuantidadeProduto);
                        }



                        break;
                    case 7:
                        venda = new Venda();

                        Console.Clear();
                        Console.WriteLine(" -- REALIZAR VENDA -- \n");
                        Console.WriteLine("Digite o CPF do Vendedor:");
                        venda.Vendedor.CpfVendedor = Console.ReadLine();
                        venda.Vendedor = VendedorDAO.BuscarVendedorPorCpf(venda.Vendedor);
                        if(venda.Vendedor != null)
                        {
                            Console.WriteLine("Digite o CPF do Cliente:");
                            //Continuar venda
                            //Console.WriteLine("Venda realizada com sucesso!");
                            if(venda.Cliente != null)
                            {
                                venda.Cliente.CpfCliente = Console.ReadLine();
                                venda.Cliente = ClienteDAO.BuscarClientePorCpf(venda.Cliente);
                                Console.WriteLine("Digite o nome do Produto");
                                venda.Produto.NomeProduto = Console.ReadLine();
                                venda.Produto = ProdutoDAO.BuscarProdutoPorNome(venda.Produto);
                                if(venda.Produto != null)
                                {
                                    Console.WriteLine("Digite a quantidade:");
                                    venda.Quantidade = Convert.ToInt32(Console.ReadLine());
                                    venda.Data = DateTime.Now;
                                    VendaDAO.CadastrarVenda(venda);
                                    Console.WriteLine("Venda cadastrada com sucesso!");
                                }
                                else
                                {
                                    Console.WriteLine("Produto não cadastrado!");
                                }

                            }
                            else
                            {
                                Console.WriteLine("Cliente não cadastrado!");
                            }
                        }
                            
                        else
                        {
                            Console.WriteLine("Vendedor não cadastrado!");
                        }


                        //Console.WriteLine("Digite o CPF do vendedor:");
                        


                        break;  

                    case 8:

                        Console.Clear();
                        Console.WriteLine(" -- LISTAR VENDAS -- \n");
                        VendaDAO.RetornarVendas();



                        break;
                    case 9:

                        Console.Clear();
                        Console.WriteLine(" -- LISTAR VENDAS POR CLIENTE -- \n");
                        Console.WriteLine("Digite o CPF do cliente:");

                        break;
                    case 0:
                        Console.WriteLine("Saindo...");
                        break;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }
                Console.WriteLine("Aperte para continuar...");
                Console.ReadKey();
            } while (opcao != 0);


        }
    }
}
