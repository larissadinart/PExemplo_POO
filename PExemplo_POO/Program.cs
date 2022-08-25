using System;

namespace PExemplo_POO
{
    internal class Program
    {
        static Pessoa lerPessoa()
        {
            string n;
            int i;

            Console.WriteLine("Informe o nome da pessoa: ");
            n = Console.ReadLine();

            Console.WriteLine("Informe a idade: ");
            i = int.Parse(Console.ReadLine());

            Pessoa pessoa = new Pessoa()
            {
                Nome = n,
                Idade = i,
            };
            return pessoa;

            //return new Pessoa()
            //{
               // Nome = n,
               // Idade = i,
           // };

        }

        static void Main(string[] args)
        {
            Pessoa[] contatos = new Pessoa[10];
            int opc;

            do
            {
                Console.WriteLine("Informe a opção desejada: ");
                Console.WriteLine("1- Cadastrar\n0-Sair");
                opc = int.Parse(Console.ReadLine());
            }while(opc != 0 || opc != 1);

            switch (opc)
            {
                case 0:
                    Console.WriteLine("Tchau");
                    break;
                case 1:
                    contatos[0] = lerPessoa();
                    break;
                default:
                    break;
            }
            Console.WriteLine(">>>>>FIM<<<<<");
        }
    }
}
