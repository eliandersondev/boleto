using System;

namespace boleto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Seja bem vindo ao sistema de geração de Boletos!");
            Console.WriteLine();

            //instanciar empresa com valores
            empresa emp = new empresa();
            Console.WriteLine("Informe os dados da empresa.");

            Console.Write("Nome da Empresa: ");
            emp.nome = Console.ReadLine();
            Console.Write("Endereço: ");
            emp.endereco = Console.ReadLine();
            Console.Write("Cidade: ");
            emp.cidade = Console.ReadLine();
            Console.Write("CEP: ");
            emp.cep = Console.ReadLine();
            Console.Write("UF: ");
            emp.uf = Console.ReadLine();
            Console.Write("CNPJ: ");
            emp.cnpj = Console.ReadLine();
            Console.Write("Inscrição Estadual: ");
            emp.ins = Console.ReadLine();
            Console.Write("Email: ");
            emp.email = Console.ReadLine();
            Console.Write("Fone: ");
            emp.fone = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("Informe os dados do clinte.");

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
