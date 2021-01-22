using System;

namespace boleto{
    class Program{
        static void Main(string[] args){
            Console.WriteLine("Seja bem vindo");
            
            empresa emp = new empresa();
            emp.nome = "XY - Grupo XY";
            emp.endereco = "Rua Silva, Centro";
            emp.cidade = "Ibimirim";
            emp.uf = "PE";
            emp.cnpj = "123.123.456/0001-58";
            emp.ins = "12345678-9";
            emp.email = "xygrupo@gmail.com";
            emp.fone = "(87) 99999-8546";
            
            Console.WriteLine(emp.nome);


        }
    }
}
