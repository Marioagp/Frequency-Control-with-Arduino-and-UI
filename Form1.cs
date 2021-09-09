using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ArduinoFrec_Control
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //serialPort1.Open(); //inicializa el puerto serie al iniciarse el programa
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void onButton_Click(object sender, EventArgs e)
        {
            //enviar datos al arduino con el click del botón
            Numerical_Useful int_to_BCD = new Numerical_Useful(); //creando un objeto de tipo Numerical_Useful
            string m = int_to_BCD.IntToBinary(10 - Convert.ToInt32(numericUpDown1.Value)); //llamando a la instancia IntToBCD4, el
                                                                                           //valor del factor de division se cuenta desde el valor
                                                                                           //que se carga hasta 10 por eso se carga en envia al mc (10 - valor)
            //serialPort1.Write("E" + m);  //enviando datos por el puerto serial, el cambio del string to int se hace en el Arduino

            string Val;
            Val = numericUpDown1.Value.ToString();    //convertir a sring la salida decimal de numericDown1
            label_Valor_Div.Text = Val;               //mostrar el valor en el label
            onButton.Text = "Dividir";                //Cambiar el texto del botón "Encender" -- > "Dividir", ya que ya esta encendido
            
        }

        private void Offbutton_Click(object sender, EventArgs e)
        {
            label_Valor_Div.Text = "APAGADO";
            numericUpDown1.Value = 1;      //reinicio el valor del factor de division de frecuencia
            string m = "A";
            //serialPort1.Write(m);          //enviando datos por el puerto serial, apagando las salidas P0-P3 y la señal de LOAD
            onButton.Text = "Encender";    //reiniciar el valor del texto en el botón de encendido
        }
    }

    
}



