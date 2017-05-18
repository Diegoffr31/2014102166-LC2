using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014102166_ENT
{
    public class RanuraDeposito
    {
        int saldoDeposito;
        public void Generardeposito(int saldo3)
        {
            Console.WriteLine("INgrese su monto:");
            saldoDeposito = int.Parse(Console.ReadLine());
            saldoDeposito = saldoDeposito + saldo3;
            Console.WriteLine("Su nuevo saldo   :" + saldoDeposito);
        }
    }
}
