using PessoaFisicaPessoaJuridica;

internal class Program
{
    private static void Main(string[] args)
    {
        PessoaFisica pessoa = new PessoaFisica("Yuri", "123456789", "Av. Brasil, 100", "yuri@gmail.com", "3333-9999", "7777-5555");
        pessoa.ImprimirCadastro();

        Console.WriteLine();

        PessoaJuridica empresa = new PessoaJuridica("YMM Ltda", "Yuri Solution", "987654321", "Av. São Paulo, 200", "yurisolution@yurisolution.com", "6666-0000", "4444-1111");
        empresa.ImprimirCadastro();

    }
}