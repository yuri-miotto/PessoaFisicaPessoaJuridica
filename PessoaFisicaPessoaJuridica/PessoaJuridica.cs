﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PessoaFisicaPessoaJuridica
{
    internal class PessoaJuridica : Cadastro
    {
        public PessoaJuridica(string nome, string nomeFantasia, string cnpj, string endereco, string email, string tel1, string tel2) 
        {
            this.Nome = nome;
            this.NomeFantasia = nomeFantasia;
            this.NumeroCNPJ = cnpj;
            this.Email = email;
            this.Endereco = endereco;
            this.Telefone1 = tel1;
            this.Telefone2 = tel2;            
        }


        public override void ImprimirCadastro()
        {
            Console.WriteLine("Nome: " + Nome);
            Console.WriteLine("Nome Fantasia: " + NomeFantasia);
            Console.WriteLine("CNPJ: " + NumeroCNPJ);
            Console.WriteLine("Endereço: " + Endereco);
            Console.WriteLine("Email: " + Email);
            Console.WriteLine("Telefone 1: " + Telefone1);
            Console.WriteLine("Telefone 1: " + Telefone2);
        }
    }
}
