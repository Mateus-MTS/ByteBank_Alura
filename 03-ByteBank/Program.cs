using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaGabriela = new ContaCorrente();

            contaGabriela.titular = "Gabriela";
            contaGabriela.agencia = 863;
            contaGabriela.numeroConta = 863452;

            ContaCorrente contaGabrielaCosta = new ContaCorrente();

            contaGabrielaCosta.titular = "Gabriela";
            contaGabrielaCosta.agencia = 863;
            contaGabrielaCosta.numeroConta = 863452;

            Console.WriteLine("Igualdade de tipo de referência, Número conta: " + (contaGabriela == contaGabrielaCosta));

            int idade = 27;
            int idadeMaisUmaVez = 27;

            Console.WriteLine("Igualdade de tipo de valor, Idade: " + (idade == idadeMaisUmaVez));

            contaGabriela = contaGabrielaCosta;

            Console.WriteLine("Igualdade de tipo de referência COM um objeto recebendo o valor(ENDEREÇO) de outro, Número conta:  " + 
                (contaGabriela == contaGabrielaCosta));

            contaGabriela.saldo = 300;

            Console.WriteLine("Conta Gabriela: " + contaGabriela.saldo);
            Console.WriteLine("Conta Gabriela Costa: " + contaGabrielaCosta.saldo);

            Console.ReadLine();

            if (contaGabriela.saldo >= 100 && contaGabriela.saldo>0)
            {
                contaGabriela.saldo -= 100;
            }
        }
    }
}
