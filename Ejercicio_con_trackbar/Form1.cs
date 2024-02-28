using System;

namespace Ejercicio_con_trackbar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void trckBar1_Scroll(object sender, EventArgs e)
        {
            int newSize = trckBar1.Value;
            label1.Font = new System.Drawing.Font(label1.Font.FontFamily, Math.Max(1, newSize));
        }


    }
}


