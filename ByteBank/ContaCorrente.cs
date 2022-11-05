using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    public class ContaCorrente
    {
        public int numeroAgencia;
        public string conta;
        public string titular;
        public double saldo;

        public void Depositar(double valor)
        {
            this.saldo += valor;
        }

        public bool Sacar(double valor)
        {
            if (valor <= this.saldo)
            {
                this.saldo -= valor;
                return true;
            }
            return false;
        }

        public bool Transferir(ContaCorrente contaDestino, double valor)
        {
            if (valor <= this.saldo)
            {
                this.Sacar(valor);
                contaDestino.Depositar(valor);
                return true;
            }
            return false;
        }
    }
}