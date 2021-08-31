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
            serialPort1.Open(); //inicializes and opens the serial port in the runtime
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
