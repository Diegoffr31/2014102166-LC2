using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014102166_ENT
{
    public class Cuenta
    {
        int saldo, opcion, pin;
        string _nombre;
        int _pin;
        int monto = 300;
        DispensadorEfectivo llamada = new DispensadorEfectivo();
        Teclado llamada1 = new Teclado();
        RanuraDeposito llamada7 = new RanuraDeposito();




        public void retirar(int monto1)
        {
            monto = monto - monto1;
        }
        public void mostrarCuenta(string nombre)
        {
            saldo = monto;
            _nombre = nombre;
            Console.WriteLine("Tu saldo es : " + saldo + "\n" + "Tu nombre es: " + _nombre + "\n");
            Console.WriteLine("1: Mostrar saldo " + "\n" + " 2: Retiro " + "\n" + "3:Deposito");
            Console.Write("Ingrese su opcion :          ");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    mostrarCuenta(nombre);
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
                    Console.WriteLine("1: Mostrar saldo " + "\n" + " 2: Retiro " + "\n" + "3:Deposito");

                    Console.Write("Ingrese su opcion :          ");
                    opcion = int.Parse(Console.ReadLine());
                    switch (opcion)
                    {
                        case 1:
                            mostrarCuenta(nombre);
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
                            llamada7.Generardeposito(saldo);
                            break;
                    }


                    break;
                default:
                    llamada7.Generardeposito(saldo);
                    break;
            }
            Console.ReadKey();

        }

    }
}
