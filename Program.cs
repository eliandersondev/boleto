using System;

namespace boleto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Seja bem vindo ao sistema de geração de Boletos!");

            //instanciar empresa com valores
            empresa emp = new empresa();
            emp.nome = "XY - Grupo XY";
            emp.endereco = "Rua Silva, Centro";
            emp.cidade = "Ibimirim";
            emp.cep = "56580-000";
            emp.uf = "PE";
            emp.cnpj = "123.123.456/0001-58";
            emp.ins = "12345678-9";
            emp.email = "xygrupo@gmail.com";
            emp.fone = "(87) 99999-8546";

            string cliente;
            int qtdParcela;
            double valorVenda, valorParcela;

            Console.Write("Nome do Cliente: ");
            cliente = Console.ReadLine();
            Console.Write("Quantida de Parcelas: ");
            qtdParcela = int.Parse(Console.ReadLine());
            Console.Write("Valor total da Venda: ");
            valorVenda = double.Parse(Console.ReadLine());
            valorParcela = valorVenda / qtdParcela;

            for (int i = 1; i <= qtdParcela; i++)
            {
                Console.Beep();
                Console.WriteLine("---------------------------------------------------------------------------------");
                Console.WriteLine("Empresa: " + emp.nome);
                Console.WriteLine("Endereço: " + emp.endereco + ", " + emp.cidade + "/" + emp.uf + " - CEP: " + emp.cep);
                Console.WriteLine("CNPJ: " + emp.cnpj + " - Inscrição estadual: " + emp.ins);
                Console.WriteLine("Email: " + emp.email + " Fone: " + emp.fone);
                Console.WriteLine();

                Console.WriteLine("Cliente: " + cliente);
                Console.WriteLine("Parcela: " + i + " de " + qtdParcela);
                Console.WriteLine("Valor: {0}", valorParcela.ToString("C"));


            }

            Console.WriteLine("---------------------------------------------------------------------------------");







        }
    }
}
