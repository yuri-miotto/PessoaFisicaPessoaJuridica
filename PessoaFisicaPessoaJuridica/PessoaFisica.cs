using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PessoaFisicaPessoaJuridica
{
    internal class PessoaFisica : Cadastro
    {
        public PessoaFisica(string nome, string cpf, string endereco, string email, string tel1, string tel2)
        {
            this.Nome = nome;
            this.NumeroCPF = cpf;
            this.Email = email;
            this.Endereco = endereco;
            this.Telefone1 = tel1;
            this.Telefone2 = tel2;
        }

        public override void ImprimirCadastro()
        {
            Console.WriteLine("Nome: " + Nome);
            Console.WriteLine("CPF: " + NumeroCPF);
            Console.WriteLine("Endereço: " + Endereco);
            Console.WriteLine("Email: " + Email);
            Console.WriteLine("Telefone 1: " + Telefone1);
            Console.WriteLine("Telefone 1: " + Telefone2);
        }
    }
}
