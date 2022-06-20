using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            //Cliente gabriela = new Cliente();

            //gabriela.nome = "Gabriela";
            //gabriela.profissao = "Desenvolvedora C#";
            //gabriela.cpf = "021.045.110-62";

            ContaCorrente conta = new ContaCorrente();

            //conta.titular = gabriela;

            conta.titular = new Cliente();
            conta.titular.nome = "Gabriela Costa";
            conta.titular.cpf = "021.045.110-62";
            conta.titular.profissao = "Desenvolvedora C#";

            conta.saldo = 500;
            conta.agencia = 563;
            conta.numeroConta = 5634527;

            //Console.WriteLine(gabriela.nome);
            Console.WriteLine(conta.titular.nome);
            Console.WriteLine(conta.titular.cpf);
            Console.WriteLine(conta.titular.profissao);

            Console.ReadLine();
        }
    }
}
