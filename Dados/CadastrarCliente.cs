using System;
using System.IO;
using NetOffice.ExcelApi;
namespace Util{
  
public class CadastrarCliente
{
    public void Cadastrarcliente()
    {
        Console.WriteLine("Cadastro.");
        Console.WriteLine("Insira as informações a seguir.");
        Console.WriteLine("Qual é seu nome?");
        string nome = Console.ReadLine();
        Console.WriteLine("Qual é seu e-mail?");
        string email = Console.ReadLine();
        Console.WriteLine("Pessoa física (digite 1), pessoa jurídica (digite 2)");
        string opcao2 = Console.ReadLine();
        
        Console.WriteLine("Qual sua cidade?");
        Endereco endereco1 = new Endereco();
        endereco1.cidade = Console.ReadLine();
        Console.WriteLine("Qual seu bairro?");
        endereco1.bairro = Console.ReadLine();
        Console.WriteLine("Qual sua rua?");
        endereco1.rua = Console.ReadLine();
        Console.WriteLine("Número:");
        endereco1.numero = Console.ReadLine();
        string cidade = Convert.ToString(endereco1.cidade);
        string bairro = Convert.ToString(endereco1.bairro);
        string rua = Convert.ToString(endereco1.rua);
        string numero = Convert.ToString(endereco1.numero);
        switch(opcao2)

        {case "1":
                    bool cpfvalido = false; 
                    Console.WriteLine("Qual é seu CPF?");
                    string cpf = Console.ReadLine();
                    Validacao cliente1 = new Validacao();
                    cliente1.ValidarCPF(cpf);
                    cpfvalido = cliente1.ValidarCPF(cpf);
                    if (cpfvalido==true)
                    {
                        StreamWriter cadastro = new StreamWriter ("Cadastro.txt", true);
                        FileInfo cabecalho = new FileInfo("Cadastro.txt");
                        if(cabecalho.Length == 0)
                        {
                            cadastro.WriteLine ("NOME; E-MAIL; CPF/CNPJ; DATA E HORA");
                        }
                        cadastro.WriteLine(nome + ";" + email + ";" + cpf + ";" + DateTime.Now);
                        cadastro.Close();           
                    }
                    
            break;
            case "2":
                    bool cnpjvalido = false; 
                    Console.WriteLine("Qual é seu CNPJ?");
                    string cnpj = Console.ReadLine(); 
                    Validacao cliente2 = new Validacao();
                    cnpjvalido = cliente2.ValidarCNPJ(cnpj);
                    if (cnpjvalido==true)
                    {
                        StreamWriter cadastro = new StreamWriter ("Cadastro.txt", true);
                        FileInfo cabecalho = new FileInfo("Cadastro.txt");
                        if(cabecalho.Length == 0)
                        {
                            cadastro.WriteLine ("NOME; E-MAIL; CPF/CNPJ; DATA E HORA");
                        }
                        cadastro.WriteLine(nome + ";" + email + ";" + cnpj + ";" + DateTime.Now);
                        cadastro.Close();
                                                
                    }

            break;
            default: 
                    Cadastrarcliente();
            break;
            }
    
               
        if(!File.Exists(@"C:\Users\39694603870\Desktop\Projetos\Banco\Library-Util\clientes.xls"))
        {
            Criarexcel(nome, email, cpfecnpj, cidade, bairro, rua, numero);
        }
        else
        {
            Application ex = new Application();
            ex.DisplayAlerts = false;
            ex.Workbooks.Open(@"C:\Users\39694603870\Desktop\Projetos\Banco\Library-Util\clientes.xls");
            int contador = 1;
            do
            {
                contador += 1;

            } while (ex.Cells[contador,1].Value != null);
            
            ex.Cells[contador,1].Value = nome;
            ex.Cells[contador,2].Value = email;
            ex.Cells[contador,3].Value = cpfecnpj;
            ex.Cells[contador,4].Value = cidade;
            ex.Cells[contador,5].Value = bairro;
            ex.Cells[contador,6].Value = rua;
            ex.Cells[contador,6].Value = numero;
            ex.ActiveWorkbook.Save();
            ex.Quit();
            ex.Dispose();
        }
    }
    public void Criarexcel(string nome, string email, string cpfecnpj, string cidade, string bairro, string rua, string numero)
    {    
        Application ex = new Application();
        ex.Workbooks.Add();
        ex.Cells[1,1].Value = nome;
        ex.Cells[1,2].Value = email;
        ex.Cells[1,3].Value = cpfecnpj;
        ex.Cells[1,4].Value = cidade;
        ex.Cells[1,5].Value = bairro;
        ex.Cells[1,6].Value = rua;
        ex.Cells[1,6].Value = numero;

        ex.ActiveWorkbook.SaveAs(@"C:\Users\39694603870\Desktop\Projetos\Banco\Library-Util\clientes.xls");
        ex.Quit();
        ex.Dispose();
    }
}     
}      
    
          