using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PessoaFisicaPessoaJuridica
{
    internal abstract class Cadastro
    {
        public string Nome { get; set; }

        public string NomeFantasia { get; set; }

        public string NumeroCPF { get; set; }

        public string NumeroCNPJ { get; set; }

        public string Endereco { get; set; }

        public string Email { get; set; }

        public string Telefone1 { get; set; }

        public string Telefone2 { get; set; }

        public abstract void ImprimirCadastro();
        
    }
}
