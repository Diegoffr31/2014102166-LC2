using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014102166_ENT
{
    public class DispensadorEfectivo
    {
        int saldoBruto;
        public void Retirodinero(int monto1, int saldo5)
        {
            int monto, cinco, diez, veinte, cincuenta, cien;
            monto = monto1;
            saldoBruto = saldo5 - monto;
            if (monto % 5 == 0)
            {

                cien = monto / 100;
                monto = monto % 100;
                cincuenta = monto / 50;
                monto = monto % 50;
                veinte = monto / 20;
                monto = monto % 20;
                diez = monto / 10;
                monto = monto % 10;
                cinco = monto / 5;
                monto = monto % 5;
                Console.SetCursorPosition(30, 20);
                Console.WriteLine("El monto en billetes de cien es: " + cien);
                Console.SetCursorPosition(30, 22);
                Console.WriteLine("El monto en billetes de 50 es: " + cincuenta);
                Console.SetCursorPosition(30, 24);
                Console.WriteLine("El monto en billetes de viente es: " + veinte);
                Console.SetCursorPosition(30, 26);
                Console.WriteLine("El monto en billetes de diez es: " + diez);
                Console.SetCursorPosition(30, 28);
                Console.WriteLine("El monto en billetes de cinco es: " + cinco);

                Console.SetCursorPosition(30, 30);
                Console.WriteLine("SALDO BRUTO" + saldoBruto);

            }
            else
            {
                Console.SetCursorPosition(25, 20);
                Console.WriteLine("MONTO INVALIDO");
            }

            Console.ReadKey();
        }
    }
}
