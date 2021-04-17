using System;

namespace AgendaTelefonica
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===============================================");
            Console.WriteLine("===============AGENDA TELEFONICA===============");
            Console.WriteLine("===============================================");

            Console.WriteLine();

            Console.WriteLine("Qual a operacao que deseja realizar? ");
            Console.WriteLine("1. Adicionar contato");
            Console.WriteLine("2. Editar contato");
            Console.WriteLine("3. Excluir contato");
            Console.WriteLine("4. Exibir contatos");
            Console.WriteLine("5. Sair");

            Console.Write("\nOperação: ");
            int operacao = int.Parse(Console.ReadLine());

            //Criando vetor limitando a 50 contatos
            Agenda[] contatos = new Agenda[10];

            string nome = "";
            string sobrenome = "";
            long celular = 0;
            string email = "";


            //indice contatos adicionados
            int nr_contato = 0;

            while (true)
            {
                
                if (operacao >= 6)
                {
                    while (operacao >= 6)
                    {
                        Console.WriteLine("Informe uma opção válida");
                        Console.Write("Operação: ");
                        operacao = int.Parse(Console.ReadLine());
                    }

                }

                //Adicionando contato
                else if (operacao == 1)
                {
                                    
                    Console.WriteLine("Informe os seguintes dados: ");
                    Console.Write("Nome: ");
                    nome = Console.ReadLine();
                    Console.Write("Sobrenome: ");
                    sobrenome = Console.ReadLine();
                    Console.Write("Celular: ");
                    celular = long.Parse(Console.ReadLine());

                    Console.Write("Deseja informar o E-mail? ");
                    string sn_email = (Console.ReadLine());

                    if (sn_email.ToUpper() == 'S'.ToString())
                    {
                        Console.Write("Email: ");
                        email = Console.ReadLine();

                        contatos[nr_contato] = new Agenda (nome.ToUpper(), sobrenome.ToUpper(), celular, email );                        
                    }
                    else
                    {
                        contatos[nr_contato] = new Agenda(nome.ToUpper(), sobrenome.ToUpper(), celular);
                    }
                    
                    nr_contato += 1;                   

                }

                //Editando contato
                else if (operacao == 2)
                {
                    Console.Write("Qual contato você deseja editar? ");
                    string nome_edicao = Console.ReadLine();

                    for (int i = 0; i < 10; i++)
                    {
                        if (contatos[i] != null)
                        {
                            if (contatos[i].Nome == nome_edicao.ToUpper())
                            {
                                Console.WriteLine();
                                Console.WriteLine("Deseja editar qual campo: \n(1) Nome\n(2) Sobrenome\n(3) Celular\n(4) Email");
                                int campo_edicao = int.Parse(Console.ReadLine());
                                Console.WriteLine();

                                Console.Write("Novo Valor: ");
                                string new_value = Console.ReadLine();

                                if (campo_edicao == 1)
                                {
                                    contatos[i].Nome = new_value;
                                }

                                else if (campo_edicao == 2)
                                {
                                    contatos[i].Sobrenome = new_value;
                                }

                                else if (campo_edicao == 3)
                                {                                    
                                    contatos[i].Celular = (long)Convert.ToDouble(new_value);
                                }

                                else if (campo_edicao == 4)
                                {
                                    contatos[i].Email = new_value;
                                }

                                Console.WriteLine();
                                
                                Console.WriteLine("Exibindo contato editado: ");
                                Console.WriteLine("Contato #" + (i + 1) + ":\n"
                                              + "Nome: " + contatos[i].Nome + "\n"
                                              + "Sobrenome: " + contatos[i].Sobrenome + "\n"
                                              + "Celular: " + contatos[i].Celular + "\n"
                                              + "Email: " + contatos[i].Email + "\n"
                                              );

                            }
                        }

                    }
                }

                //Excluindo contato
                else if (operacao == 3)
                {
                    Console.Write("Qual contato você deseja excluir? ");
                    string nome_exclusao = Console.ReadLine();

                    for (int i = 0; i < 10; i++)
                    {
                        if (contatos[i] != null)
                        {                             
                            if (contatos[i].Nome == nome_exclusao.ToUpper())
                            {
                                Console.WriteLine();
                                Console.WriteLine("Excluindo contato.");
                                contatos[i] = null;
                            }                            
                        }

                    }
                }

                //Exibindo contato
                else if (operacao == 4)
                {
                    Console.WriteLine();
                    Console.WriteLine("=-==-==-==-==-==-==-==-==-==-=");
                    Console.WriteLine("Exibindo contatos: ");
                    Console.WriteLine("=-==-==-==-==-==-==-==-==-==-=");
                    
                    for (int i = 0; i < 10; i++)
                    {
                        if(contatos[i] != null)
                        {
                            Console.WriteLine("Contato #" + (i+1) + ":\n" 
                                              + "Nome: " + contatos[i].Nome + "\n"
                                              + "Sobrenome: " + contatos[i].Sobrenome + "\n"
                                              + "Celular: " + contatos[i].Celular + "\n"
                                              + "Email: " + contatos[i].Email + "\n"
                                              );
                        }

                    }
                }

                //Saindo da agenda
                else if (operacao == 5)
                {
                    Console.WriteLine("Fechando agenda telefônica...");
                    break;
                }

                Console.WriteLine();
                Console.WriteLine("Deseja realizar mais alguma operacao? ");
                Console.WriteLine("1. Adicionar contato");
                Console.WriteLine("2. Editar contato");
                Console.WriteLine("3. Excluir contato");
                Console.WriteLine("4. Exibir contatos");
                Console.WriteLine("5. Sair");
                Console.Write("\nOperação: ");
                operacao = int.Parse(Console.ReadLine());
                Console.WriteLine();

            }
            
        }
    }
}
