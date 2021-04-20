using System;
using System.Globalization;

namespace MovimentaBanco
{
    class Transacoes
    {
        public string Nome { get; private set; }
        public string Documento { get; private set; }

        public double ValorConta { get; private set; }

        public Transacoes(string nome, string documento, double valor_conta)
        {
            Nome = nome;
            Documento = documento;
            ValorConta = valor_conta;
        }

        public void Saque(string valores)
        {
            var list_saques = valores.Split(" ");

            for (int i = 0; i < list_saques.Length; i++)
            {                
                ValorConta -= Convert.ToDouble(list_saques[i]);

            }

        }

        public void Deposito(string valores)
        {
            var list_depo = valores.Split(" ");

            for (int i = 0; i < list_depo.Length; i++)
            {
                ValorConta += Convert.ToDouble(list_depo[i]);

            }

        }

        public override string ToString()
        {
            return "Cliente: " + Nome + 
                   ", Documento: " + Documento + 
                   ", Saldo Atual: " + ValorConta.ToString("F2", CultureInfo.InvariantCulture);
        }




    }
}
