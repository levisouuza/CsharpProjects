using System;
using System.Globalization;

namespace MovimentaBanco
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*****************************");
            Console.WriteLine(" Auto Atendimento Financeiro ");
            Console.WriteLine("*****************************");

            Console.WriteLine("\nCadastro Cliente:");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Documento: ");
            string doc = Console.ReadLine();
            Console.Write("Valor em conta: R$ ");
            double valor_conta = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Transacoes trans = new Transacoes(nome, doc, valor_conta);

            Console.WriteLine("\nQual operação deseja realizar ?");

            Console.WriteLine("1.Saque\n2.Depósito\n3.Consultar Saldo\n4.Finalizar Atendimento");
            Console.Write("Opção: ");
            int opcao = int.Parse(Console.ReadLine());

            while (true)
            {
                if (opcao > 4)
                {
                    while (opcao >= 4)
                    {
                        Console.Write("Informe uma opção válida: ");                        
                        opcao = int.Parse(Console.ReadLine());
                    }

                }

                else if (opcao == 4)
                {   
                    Console.WriteLine("\nFinalizando Atendimento. Volte sempre :)");
                    break;
                }

                else if (opcao == 3)
                {                   
                    Console.WriteLine("\n" + trans);
                }

                else if (opcao == 1)
                {
                    Console.Write("\nInforme os valores dos Saques: ");
                    string saques = Console.ReadLine();

                    trans.Saque(saques);
                    
                    Console.WriteLine("Saques Realizados com sucesso!");
                }


                else if (opcao == 2)
                {
                    Console.Write("\nInforme os valores dos Depositos: ");
                    string depositos = Console.ReadLine();

                    trans.Deposito(depositos);

                    Console.WriteLine("Depositos Realizados com sucesso!");
                }

                Console.WriteLine("\nDeseja realizar outra operação?");
                Console.WriteLine("1.Saque\n2.Depósito\n3.Consultar Saldo\n4.Finalizar Atendimento");
                Console.Write("Opção: ");
                opcao = int.Parse(Console.ReadLine());
            }

            

        }
    }
}
