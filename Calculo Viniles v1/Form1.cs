using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Calculo_Viniles_v1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try

            {
                int ancho = Convert.ToInt32(textBoxAncho.Text);
                int alto = Convert.ToInt32(textBoxAlto.Text);
                int area = ancho * alto;
                int colores = trackBarColores.Value;

                double material = 55.0 * area / 6000 + 9.5 * area / 3000 + 550.0 * area / 28800;
                double total = material * 2.5 * colores;

                MessageBox.Show("El total es: " + total.ToString("C2"), "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (FormatException)
            {
                MessageBox.Show("Los Valores Ingresados No Son Numericos o No Se Han Ingresado Valores", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (OverflowException)
            {
                MessageBox.Show("Los valores ingresados son demasiado Grandes", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            labelColores.Text = $"Colores: {trackBarColores.Value}";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int ancho = Convert.ToInt32(textBoxAncho.Text);
                int alto = Convert.ToInt32(textBoxAlto.Text);
                int area = ancho * alto;
                int colores = trackBarColores.Value;

                double material = 55.0 * area / 6000 + 9.5 * area / 3000 + 550.0 * area / 28800;
                double totalIVA = material * 2.5 * colores * 1.16;

                MessageBox.Show("El total con IVA es: " + totalIVA.ToString("C2"), "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (FormatException)
            {
                MessageBox.Show("Los Valores Ingresados No Son Numericos o No Se Han Ingresado Valores", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (OverflowException)
            {
                MessageBox.Show("Los valores ingresados son demasiado Grandes", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                int ancho = Convert.ToInt32(textBoxAncho.Text);
                int alto = Convert.ToInt32(textBoxAlto.Text);
                int area = ancho * alto;
                int colores = trackBarColores.Value;

                double material = 55.0 * area / 6000 + 9.5 * area / 3000 + 550.0 * area / 28800;
                double totalMayoreo = material * 2 * colores;

                MessageBox.Show("El total Con Precio de Mayoreo es: " + totalMayoreo.ToString("C2"), "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (FormatException)
            {
                MessageBox.Show("Los Valores Ingresados No Son Numericos o No Se Han Ingresado Valores", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (OverflowException)
            {
                MessageBox.Show("Los valores ingresados son demasiado Grandes", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Dessarrollado por: \n\n" +
                "Noe Gonzalez" + "\n Calculo Viniles " +
                "\n Version 1.0" + "\n\n" +
                "Todos los Derechos RESERVADOS., \n" +
                "No Disponible Para la Venta");
        }
    }
}
