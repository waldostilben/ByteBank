using System;

namespace ByteBank
{
    class Programa
    {
        static void Main(string[] args)
        {
            ContaCorrente contaAndre = new ContaCorrente();

            contaAndre.titular = "André Silva";
            contaAndre.numeroAgencia = 15;
            contaAndre.conta = "1010-X";
            contaAndre.saldo = 100.00;

            Console.WriteLine("# Nova Conta Bancária #");
            Console.WriteLine("Nome do titular: " + contaAndre.titular);
            Console.WriteLine("Agência: " + contaAndre.numeroAgencia);
            Console.WriteLine("Conta: " + contaAndre.conta);
            Console.WriteLine("Saldo: R$ " + String.Format("{0:0.00}", contaAndre.saldo));

            contaAndre.Depositar(100);

            Console.WriteLine("Novo saldo: R$ " + String.Format("{0:0.00}", contaAndre.saldo));

            contaAndre.Sacar(100);

            Console.WriteLine("Novo saldo: R$ " + String.Format("{0:0.00}", contaAndre.saldo));

            if (contaAndre.Sacar(50)) // mesmo que: contaAndre.Sacar(200) == true
            {
                Console.WriteLine("Saque realizado com sucesso! Novo saldo: R$ " + String.Format("{0:0.00}", contaAndre.saldo));
            }
            else
            {
                Console.WriteLine("Saldo insuficiente para saque.");
            }

            ContaCorrente contaMaria = new ContaCorrente();

            contaMaria.titular = "Maria das Graças";
            contaMaria.numeroAgencia = 16;
            contaMaria.conta = "1515-1";
            contaMaria.saldo = 500.00;

            if(contaAndre.Transferir(contaMaria, 50))
            {
                Console.WriteLine("Transferência realizada com sucesso! Novo saldo: R$ " + String.Format("{0:0.00}", contaAndre.saldo));
            }
            else
            {
                Console.WriteLine("Saldo insuficiente para transferência.");
            }

            Console.Write("\n");
            Console.WriteLine("# Nova Conta Bancária #");
            Console.WriteLine("Nome do titular: " + contaMaria.titular);
            Console.WriteLine("Agência: " + contaMaria.numeroAgencia);
            Console.WriteLine("Conta: " + contaMaria.conta);
            Console.WriteLine("Saldo: R$ " + String.Format("{0:0.00}", contaMaria.saldo));
        }
    }
}