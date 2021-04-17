using System;

namespace AgendaTelefonica
{
    class Agenda
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public long Celular { get; set; }
        public string Email { get; set; }

        //Construtor 1
        
        public Agenda(string nome, string sobrenome, long celular)
        {
            Nome = nome;
            Sobrenome = sobrenome;
            Celular = celular;
        }

        //Construtor 2
        public Agenda(string nome, string sobrenome, long celular, string email) : this(nome, sobrenome, celular)
        {
            Email = email;
        }

    }
}   

