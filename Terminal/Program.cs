using System;
using System.IO;
using Dados;
using Util;


namespace Banco
{class Program

    {static void Main(string[] args)
        {string opcao1 = "";

        do{
            
            Console.WriteLine("Seja Bem-vindo ao banco Tal.");
            Console.WriteLine("Digite uma opção:");
            Console.WriteLine("1 - Cadastrar cliente.");
            Console.WriteLine("2 - Depositar/Sacar.");
            Console.WriteLine("3 - Exibir saldo.");
            Console.WriteLine("4 - Sair.");
            opcao1 = Console.ReadLine();
            
            switch(opcao1)
            
                {case "1": CadastrarCliente cliente1 = new CadastrarCliente();
                         cliente1.Cadastrarcliente(); 
                break;
                case "2":CadastrarCarro carro1 = new CadastrarCarro();
                         carro1.Cadastrarcarro();   
                break;
                case "3":VenderCarro venda1 = new VenderCarro();
                         venda1.Vendercarro();   
                break;
                case "4": ListarCarros lista1 = new ListarCarros();
                        lista1.Listarcarros(); 
                break;
                case "5": ListarCarrosnao listanao = new ListarCarrosnao();
                        listanao.Listarcarrosnao(); 
                break;
                
                case "6":
                        {Console.WriteLine("Deseja realmente sair(s ou n)");
                        string sair = Console.ReadLine();
                        if(sair.ToLower().Contains("s"))
                            Environment.Exit(0);
                        else if(!sair.ToLower().Contains("n"))    
                            {opcao1 = "0";
                            Console.WriteLine("Opção Inválida");
                            }
                        else
                            {opcao1 = "0";
                            }
                        }                 
                             
                break;
            }
        }
        while (opcao1 != "5");
        }
    } 
}       