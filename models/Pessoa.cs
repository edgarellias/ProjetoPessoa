using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPessoa.models
{
    internal class Pessoa
    {
        public Pessoa(string name, int age, string cpf)
        {
            this.name = name;
            this.age = age;
            this.cpf = cpf;
        }

        public string name { get; set; }
        public int age { get; set; }
        public string cpf { get; set; }

    }
}
