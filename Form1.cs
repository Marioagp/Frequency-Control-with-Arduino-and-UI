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
            serialPort1.Open(); //inicializa el puerto serie al iniciarse el programa
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void onButton_Click(object sender, EventArgs e)
        {
            //enviar datos al arduino con el click del botón
            Numerical_Useful int_to_BCD = new Numerical_Useful(); //creando un objeto de tipo Numerical_Useful
            string m = int_to_BCD.IntToBinary(Convert.ToInt32(numericUpDown1.Value)); //llamando a la instancia IntToBCD4
            
            serialPort1.Write(m);  //enviando datos por el puerto serial, el cambio del string to int se hace en el Arduino

            string Val;
            Val = numericUpDown1.Value.ToString();    //convertir a sring la salida decimal de numericDown1
            label_Valor_Div.Text = Val;               //mostrar el valor en el label
            //label_Valor_Div.Text = "I" + m;  //visualizando la salida en el label

        }
    }

    
}



