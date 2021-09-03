using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArduinoFrec_Control
{
    public class Numerical_Useful
    {
        //convierte a binario el int y returna un string
        public string IntToBinary(int numericvalue, int Base = 2) //Base debe ser 2,8,10,16, usamos 2 pq es binario
        {
            string binary = Convert.ToString(numericvalue + 16, Base); //se le suma 16 para que quede tener 5 digitos siempre
            binary = binary.Remove(0,1);  //se elmina el primer digito quedando de la forma de nipple (4 char en este caso)
            return binary;                //si el nuemro fuera "4" binary = "100" se pierde el primero por eso se suma 16 y se quita despues
        }
    }
}
