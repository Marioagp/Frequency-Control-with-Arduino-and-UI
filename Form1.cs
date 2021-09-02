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

            string div = "I" + Convert.ToInt32(numericUpDown1.Value); //La I para decirle al Arduino que inicie y el valor de 
                                                                      // ToInt32(numericUpDown1.Value) con el int convertido a string con el 
                                                                      // valor a cargar
                                                                      //int div = Convert.ToInt32(numericUpDown1.Value); // se convierte a int el valor que devuelve el numericUpDown que es decimal
            serialPort1.Write(div);                                   //enviando datos por el puerto serial, el cambio del string to int se hace en el Arduino
            
        }
    }

}


