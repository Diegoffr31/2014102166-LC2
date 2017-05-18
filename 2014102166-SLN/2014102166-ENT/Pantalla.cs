using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014102166_ENT
{
    public class Pantalla
    {
        Cuenta llamada2 = new Cuenta();
        RanuraDeposito llamada8 = new RanuraDeposito();
        DispensadorEfectivo llamada = new DispensadorEfectivo();
        Teclado llamada1 = new Teclado();
        int saldo = 300;
        int monto, pin, opcion;
        string nombre;
        public void pantallaso()
        {
            Console.SetBufferSize(150, 100);


            Console.Write("Ingrese NOMBRRE:           ");
            nombre = Console.ReadLine();

            Console.WriteLine("1: Mostrar saldo " + "\n" + " 2: Retiro " + "\n" + "3:Deposito");

            Console.Write("Ingrese su opcion :          ");
            opcion = int.Parse(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    llamada2.mostrarCuenta(nombre);
                    break;
                case 2:

                    Console.Write("INGRESE MONTO:             ");
                    monto = int.Parse(Console.ReadLine());

                    Console.Write("Ingrese su ping :          ");
                    pin = int.Parse(Console.ReadLine());

                    if (llamada1.validarPin(pin) == 1)
                    {

                        Console.WriteLine("PIN CORRECTO ");

                        llamada.Retirodinero(monto, saldo);
                    }
                    else
                    {

                        Console.WriteLine("INSERTE NUEVAMENTE ");

                        Console.Write("Ingrese su ping :          ");
                        pin = int.Parse(Console.ReadLine());
                        llamada.Retirodinero(monto, saldo);


                    }

                    break;
                default:
                    llamada8.Generardeposito(saldo);
                    break;
            }
        }
    }
}
