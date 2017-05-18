using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014102166_ENT
{
    public class Teclado
    {
        int validacion;
        public int validarPin(int pin)
        {
            do
            {
                if (pin == 1234)
                {

                    return validacion = 1;

                }
                else
                {

                    return validacion = 2;
                }

            } while (pin / 100 < 10);
        }
    }
}
